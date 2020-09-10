using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataLayer.Entities
{
    public class QuestionTest
    {
        public int QuestionId { get; set; }
        public int TestId { get; set; }
        public bool SoftDeleted { get; set; }
        public Question Question { get; set; }
        public Test Test { get; set; }
    }
}
