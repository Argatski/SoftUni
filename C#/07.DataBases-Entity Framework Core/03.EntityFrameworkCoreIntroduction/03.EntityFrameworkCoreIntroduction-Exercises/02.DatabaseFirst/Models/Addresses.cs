using System.Collections.Generic;

namespace SoftUni.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            Employees = new HashSet<Employees>();
        }

        public int AddressId { get; set; }
        public string AddressText { get; set; }
        public int? TownId { get; set; }

        public virtual Towns Town { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
