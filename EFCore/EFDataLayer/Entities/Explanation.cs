using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataLayer.Entities
{
    public class Explanation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ExplanationId { get; set; }
        public string ExplanationText { get; set; }
        public int QuestionId { get; set; }
    }
}
