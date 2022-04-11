using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class User:BaseEntity
    {

        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; } = null!;
        [Column(TypeName = "nvarchar(150)")]
        public string FullName { get; set; } = null!;
        [Column(TypeName = "nvarchar(800)")]
        public string Password { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public virtual List<RoleToUser>? RoleToUsers { get; set; }

    }
}
