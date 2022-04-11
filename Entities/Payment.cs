using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payment:BaseEntity
    {
        public DateTime PayDate { get; set; }
        public decimal PayAmount { get; set; }
        public int StudentID { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Student Student { get; set; } = null!;
    }
}
