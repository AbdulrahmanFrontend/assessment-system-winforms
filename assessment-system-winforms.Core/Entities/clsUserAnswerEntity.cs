using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_system_winforms.Core.Entities
{
    public class clsUserAnswerEntity
    {
        public int UserAnswerID { get; set; }
        public int RecordID { get; set; }
        public int QuestionID { get; set; }
        public int SelectedAnswerID { get; set; }
        public bool IsCorrect { get; set; }
    }
}
