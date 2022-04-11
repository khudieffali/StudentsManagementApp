using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Student:BaseEntity
    {
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; } = null!;
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; } = null!;
        [Column(TypeName = "nvarchar(100)")]
        public string? FatherName { get; set; }
        public string? Address { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public decimal TotalPayment { get; set; }
        public decimal? RestAmount { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsDiscount { get; set; }
        public bool? IsSale { get; set; }
        public int StudentGroupID { get; set; }
        public virtual StudentGroup? StudentGroup { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


    }

}

