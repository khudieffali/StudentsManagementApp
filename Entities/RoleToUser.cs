using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RoleToUser:BaseEntity
    {
        public int? RoleID { get; set; }
        public int? UserID { get; set; }
        public virtual Role Role { get; set; } = null!;
        public virtual User User { get; set; }= null!;
    }
}
