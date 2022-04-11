using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Teacher:BaseEntity
    {
        public string FullName { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool IsDeleted { get; set; }
        public virtual List<StudentGroup>? StudentGroups { get; set; }

    }
}
