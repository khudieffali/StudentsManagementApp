using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cost:BaseEntity
    {
        public string Title { get; set; } = null!;
        public decimal CostPrice { get; set; }
        public DateTime CostDate { get; set; }
    }
}
