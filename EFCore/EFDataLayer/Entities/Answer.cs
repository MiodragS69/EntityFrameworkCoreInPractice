using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataLayer.Entities
{
    public class Answer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public int Order { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
