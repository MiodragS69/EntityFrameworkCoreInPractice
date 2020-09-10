using EFDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConsApp.Dto
{
    public class QuestionPreview
    {
        public string QuestionText { get; set; }
        public ICollection<Answer> QuestionAnswers { get; set; }
        public string QuestionExplanation { get; set; }
    }
}
