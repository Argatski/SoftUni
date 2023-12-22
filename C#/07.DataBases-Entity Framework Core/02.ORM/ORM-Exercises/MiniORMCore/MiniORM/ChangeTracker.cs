using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace MiniORM
{
    public class ChageTracker<T> where T : class, new()
    {
        private readonly List<T> allEntities;

        private readonly List<T> added;

        private readonly List<T> removed;


        public ChageTracker(IEnumerable<T> entities)
        {
            added = new List<T>();
            removed = new List<T>();

            this.allEntities = CloneEntities(entities);
        }

        private List<T> CloneEntities(IEnumerable<T> entities)
        {
            var clonedEntities =  new List<T>();

            PropertyInfo[] propertiesToClone = typeof(T).GetProperties()
                .Where(pi => DbContext.AllowedSqlTypes.Contains(pi.PropertyType)).ToArray();


            foreach(var entity in entities)
            {
                var clonedEnity = Activator.CreateInstance<T>();

                foreach(var property in propertiesToClone)
                {
                    var value =  property.GetValue(entity);
                    property.SetValue(clonedEnity, value);
                }

                clonedEntities.Add(entity);
            }


            return clonedEntities;
        }

       public IReadOnlyCollection<T> AllEntities => this.allEntities.AsReadOnly();

        public IReadOnlyCollection<T> Added =>this.added.AsReadOnly();

        public IReadOnlyCollection<T> Removed =>  this.removed.AsReadOnly();

        public void Add(T entity) =>this.Add(entity);

        public void Remove(T entity) =>this.Remove(entity);


        public IEnumerable<T> GetModifiedEntities(DbSet<T> dbSet)
        {
            var modifiedEntities =  new List<T>();

            var primaryKeys =  typeof(T).GetProperties().Where(pi=>pi.HasAttribute<KeyAttribute>())
                .ToArray();

            foreach (var proxyEntity in this.AllEntities)
            {
                var primaryKeyValue = GetPrimaryKeyValue(primaryKeys, proxyEntity).ToArray();

                var entity =  dbSet.Entities.Single(e=>GetPrimaryKeyValue(primaryKeys,e).SequenceEqual(primaryKeyValue));

                var isModified = IsModified(proxyEntity, entity);

                if (isModified)
                {
                    modifiedEntities.Add(entity);
                }
            }
            return modifiedEntities;
        }

        private IEnumerable<object> GetPrimaryKeyValue(IEnumerable<PropertyInfo> primaryKeys, T entity)
        {
            return primaryKeys.Select(pk => pk.GetValue(entity));
        }

        private static bool IsModified(T entity, T proxyEntity) 
        {
            var monitoredProperties =  typeof(T).GetProperties().Where(pi=>DbContext.AllowedSqlTypes.Contains(pi.PropertyType));

            var modifiedProperties =  monitoredProperties.Where(pi=>!Equals(pi.GetValue(entity),pi.GetValue(proxyEntity))).ToArray();

            var isModified =  modifiedProperties.Any();

            return isModified;
        }

        private static IEnumerable<object> GetPrimaryKeyValues(IEnumerable<PropertyInfo> primaryKeys, T entity)
        {
            return primaryKeys.Select(pk => pk.GetValue(entity));
        }
    }
}