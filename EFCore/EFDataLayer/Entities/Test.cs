using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataLayer.Entities
{
    public class Test
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int TestId { get; set; }
        public string TestTitle { get; set; }
        public DateTime TestCreatedOn { get; set; }
        public DateTime TestActivatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
