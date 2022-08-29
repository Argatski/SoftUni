using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {

        //Properties
        public List<Renovator> Renovators;

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }


        //Constructors
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>(neededRenovators);
        }

        //Methods

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for {Project} Kitchen:");

            List<Renovator> noHire = new List<Renovator>();

            noHire = Renovators.Where(m => m.Hired == false).ToList();

            for (int i = 0; i < noHire.Count; i++)
            {
                sb.AppendLine(noHire[i].ToString());
            }


            return sb.ToString().TrimEnd();
        }

        /// <summary>
        /// Return a list with all renovators that have been working for days days or more.
        /// </summary>
        /// <param name="days"></param>
        /// <returns></returns>
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> allRenovators = new List<Renovator>();

            for (int i = 0; i < Renovators.Count; i++)
            {
                if (Renovators[i].Days >= days)
                {
                    allRenovators.Add(Renovators[i]);
                    //Renovators[i].Hired = true;
                }
            }

            return allRenovators;
        }

        /// <summary>
        /// Hire (set their available property to true without removing them from the collection) the renovator with the given name, if they exist. As a result, return the renovator, or null, if they don't exist.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Renovator HireRenovator(string name)
        {
            var targetRenovator = this.Renovators.FirstOrDefault(x => x.Name == name);
            if (targetRenovator == null)
            {
                return null;
            }
            this.Renovators.FirstOrDefault(x => x.Name == name).Hired = true;
            return targetRenovator;
        }

        /// <summary>
        /// Removes all renovators by the given specialty.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int RemoveRenovatorBySpecialty(string type)
        {
            //Otherwise, returns 0.
            int result = 0;

            for (int i = 0; i < Renovators.Count; i++)
            {
                //If such exist(s), returns the count of the removed renovators;
                if (Renovators[i].Type == type)
                {
                    Renovators.Remove(Renovators[i]);
                    result++;
                }
            }

            return result;
        }


        /// <summary>
        /// Removes a renovator by given name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool RemoveRenovator(string name)
        {
            //Otherwise, returns false.
            bool isRemove = false;

            for (int i = 0; i < Renovators.Count; i++)
            {
                //If such exists returns true;
                if (Renovators[i].Name == name)
                {
                    isRemove = true;
                    Renovators.Remove(Renovators[i]);
                }
            }
            return isRemove;

            /*
             //Another solution
            var targetRenovator = this.Renovators.FirstOrDefault(x => x.Name == name);
            if (targetRenovator == null)
            {
                return false;
            }
            this.renovators.Remove(targetRenovator);
            return true;
            */
        }


        /// <summary>
        /// Getter Count - returns the count of the renovators in the catalog.
        /// </summary>
        /// <returns></returns>

        public int Count
        {
            get { return Renovators.Count; }
        }

        /// <summary>
        /// Adds a renovator to the catalog's collection, if renovators are still needed.
        /// </summary>
        /// <param name="renovator"></param>
        /// <returns></returns>
        public string AddRenovator(Renovator renovator)
        {
            string result = string.Empty;

            //If the name or specialty are null or empty, return "Invalid renovator's information."
            bool nameEmptyOrNull = renovator.Name == string.Empty || renovator.Name == null;
            bool specialtyEmptyOrNull = renovator.Type == string.Empty || renovator.Type == null;

            //bool isCorrect = string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type);

            if (nameEmptyOrNull == true || specialtyEmptyOrNull == true)
            {
                result = "Invalid renovator's information.";
            }
            //If renovators are no more needed, return "Renovators are no more needed.". Renovators are needed when the count of the added renovators is less than the NeededRenovators property of the Catalog.
            else if (Renovators.Count == NeededRenovators)
            {
                result = "Renovators are no more needed.";
            }
            //If the rate is above 350 BGN, return "Invalid renovator's rate.".
            else if (renovator.Rate > 350)
            {
                result = $"Invalid renovator's rate.";
            }
            //Otherwise, return: "Successfully added {renovatorName} to the catalog.".
            else
            {
                Renovators.Add(renovator);
                result = $"Successfully added {renovator.Name} to the catalog.";
            }

            return result;
        }

    }
}
