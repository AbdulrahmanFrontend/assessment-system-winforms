using assessment_system_winforms.Core.Entities;
using assessment_system_winforms.DAL;
using BLL;
using Core;
using System.Collections.Generic;
using System.Data;

namespace assessment_system_winforms.BLL
{
    public class clsExam : clsBaseBusiness
    {
        public clsExamEntity ExamInfo { get; set; }
        public clsExam()
        {
            ExamInfo = new clsExamEntity();
            ExamInfo.ExamID = -1;
            ExamInfo.ExamTitle = "";
            
            Mode = clsEnums.enMode.enAddNew;
        }
        private clsExam(clsExamEntity examInfo)
        {
            this.ExamInfo = examInfo;
            Mode = clsEnums.enMode.enUpdate;
        }
        protected override bool _AddNew()
        {
            this.ExamInfo.ExamID = clsExamData.AddNewExam(ExamInfo);
            return (this.ExamInfo.ExamID != -1);
        }
        protected override bool _Update()
        {
            return clsExamData.UpdateExam(this.ExamInfo);
        }
        public static bool DeleteExam(int ExamID)
        {
            if (!clsExamData.IsExamExist(ExamID))
                return false;

            return clsExamData.DeleteExam(ExamID);
        }
        public static bool IsExamExist(int ExamID)
        {
            return clsExamData.IsExamExist(ExamID);
        }
        public static bool IsExamExistByTitle(string ExamTitle)
        {
            return clsExamData.IsExamExist(ExamTitle);
        }
        public static clsExam FindByExamID(int ExamID)
        {
            clsExamEntity ExamInfo = clsExamData.GetExamByExamID(ExamID);

            if (ExamInfo != null)
                return new clsExam(ExamInfo);

            return null;
        }
        public static clsExam FindByExamName(string ExamTitle)
        {
            clsExamEntity ExamInfo = clsExamData.GetExamByExamTitle(ExamTitle);

            if (ExamInfo != null)
                return new clsExam(ExamInfo);

            return null;
        }
        public static DataTable GetExams()
        {
            return clsExamData.GetAllExams();
        }
        public static List<clsQuestionEntity> PrepareExamList(int ExamID)
        {
            return clsExamData.PrepareExam(ExamID);
        }
    }
}
