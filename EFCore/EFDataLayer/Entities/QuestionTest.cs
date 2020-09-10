using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataLayer.Entities
{
    public class QuestionTest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TestId { get; set; }
        public bool SoftDeleted { get; set; }
        public Question Question { get; set; }
        public Test Test { get; set; }
    }
}
