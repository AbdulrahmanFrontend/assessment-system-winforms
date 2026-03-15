using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_system_winforms.Core.Entities
{
    public class clsExaminationRecordEntity
    {
        public int RecordID { get; set; }
        public int ExamID { get; set; }
        public string PersonName { get; set; }
        public int Score { get; set; }
        public bool IsPassed { get; set; }
        public DateTime StartedAt { get; set; }
        public int TimeSpendPerMinutes { get; set; }
    }
}
