using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataLayer.Entities
{
    public class Test
    {
        public int TestId { get; set; }
        public string TestTitle { get; set; }
        public DateTime TestCreatedOn { get; set; }
        public DateTime TestActivatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
