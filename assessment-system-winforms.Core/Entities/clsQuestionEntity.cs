using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_system_winforms.Core.Entities
{
    public class clsQuestionEntity
    {
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public int ExamID { get; set; }
        public int? RightAnswerID { get; set; }
        public string Explanation { get; set; }
    }
}
