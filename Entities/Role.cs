using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Role:BaseEntity
    {
        public Role()
        {
            RoleToUsers = new HashSet<RoleToUser>();
        }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = null!;
        public virtual ICollection<RoleToUser> RoleToUsers { get; set; }
    }
}
