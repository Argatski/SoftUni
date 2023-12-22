using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace MiniORM
{
	public class DbSet<TEntity>: ICollection<TEntity>
		where TEntity : class,new()
	{
		internal ChageTracker<TEntity> ChageTracker { get; set;}
		internal IList<TEntity> Entities { get; set; }

		internal DbSet(IEnumerable<TEntity> entities)
		{
			this.Entities =  entities.ToList();
			this.ChageTracker = new ChageTracker<TEntity>(entities);
		}

		public void Add(TEntity item)
		{
			if(item==null)
			{
				throw new ArgumentNullException(nameof(item), "Item cannot be null!");
			}
			this.Entities.Add(item);
			this.ChageTracker.Add(item);
		}

		public void Clear() 
		{
			while (this.Entities.Count > 0)
			{
				var entity=this.Entities.First();
                this.Remove(entity);
			}
			
		}

		public bool Contains(TEntity item) =>this.Entities.Contains(item);

		public void CopyTo(TEntity[] array,int arrayIndex)=>this.Entities.CopyTo(array, arrayIndex);

		public int Count => this.Entities.Count;

		public bool IsReadOnly => this.Entities.IsReadOnly;


        private bool Remove(TEntity item)
        {
			if (item==null)
			{
				throw new ArgumentNullException(nameof(item),"Item cannot be null!");
			}

			var removedSuccessfully =  this.Entities.Remove(item);

			if (removedSuccessfully) 
			{
				this.ChageTracker.Remove(item);
			}

			return removedSuccessfully;
        }

		public IEnumerator<TEntity> GetEnumerator()
		{
			return this.Entities.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			foreach(var entity in entities.ToArray())
			{
				this.Remove(entity);
			}
		}
    }
	
}