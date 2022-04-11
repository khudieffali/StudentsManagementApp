using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public partial class Speciality : BaseEntity 
    {
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = null!;
        public bool IsDeleted { get; set; }
        
        public virtual List<StudentGroup>? StudentGroups { get; set; }
    }

}

