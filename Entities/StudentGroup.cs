using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public partial class StudentGroup : BaseEntity 
    {
        private const string V = "nvarchar(100)";
        [Column(TypeName = V)]
        public string Number { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? TeacherId { get; set; }
        public int? SpecialityId { get; set; }
        public virtual Speciality? Specialities { get; set; }
        public virtual Teacher? Teacher { get; set; }

    }

}

