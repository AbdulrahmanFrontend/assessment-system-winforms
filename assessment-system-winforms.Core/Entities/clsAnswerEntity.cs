using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_system_winforms.Core.Entities
{
    public class clsAnswerEntity
    {
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        public string Answer { get; set; }
    }
}
