using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataLayer.Entities
{
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public bool SoftDeleted { get; set; }
        public bool MultiAnswer { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public Explanation Explanation { get; set; }
    }
}
