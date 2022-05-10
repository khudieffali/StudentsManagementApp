using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InformationStudent:BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Description { get; set; }
        public string? Interests { get; set; }
        public string? FatherName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string WhereFrom { get; set; } = null!;
        public DateTime InformationDate { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;


    }
}
