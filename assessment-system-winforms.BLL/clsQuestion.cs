using assessment_system_winforms.Core.Entities;
using assessment_system_winforms.DAL.Data;
using BLL;
using Core;
using System.Data;

namespace assessment_system_winforms.BLL
{
    public class clsQuestion : clsBaseBusiness
    {
        public clsQuestionEntity QuestionInfo { get; set; }
        public clsQuestion()
        {
            QuestionInfo = new clsQuestionEntity();
            QuestionInfo.QuestionID = -1;
            QuestionInfo.Question = "";
            QuestionInfo.ExamID = -1;
            QuestionInfo.RightAnswerID = -1;
            QuestionInfo.Explanation = "";

            Mode = clsEnums.enMode.enAddNew;
        }
        private clsQuestion(clsQuestionEntity QuestionInfo)
        {
            this.QuestionInfo = QuestionInfo;
            Mode = clsEnums.enMode.enUpdate;
        }
        protected override bool _AddNew()
        {
            this.QuestionInfo.QuestionID = clsQuestionData.AddNewQuestion(QuestionInfo);
            return (this.QuestionInfo.QuestionID != -1);
        }
        protected override bool _Update()
        {
            return clsQuestionData.UpdateQuestion(this.QuestionInfo);
        }
        public static bool DeleteQuestion(int QuestionID)
        {
            if (!clsQuestionData.IsQuestionExist(QuestionID))
                return false;

            return clsQuestionData.DeleteQuestion(QuestionID);
        }
        public static bool IsQuestionExist(int QuestionID)
        {
            return clsQuestionData.IsQuestionExist(QuestionID);
        }
        public static clsQuestion FindByQuestionID(int QuestionID)
        {
            clsQuestionEntity QuestionInfo = clsQuestionData.GetQuestionByQuestionID(QuestionID);

            if (QuestionInfo != null)
                return new clsQuestion(QuestionInfo);

            return null;
        }
        public static DataTable GetQuestions()
        {
            return clsQuestionData.GetAllQuestions();
        }
        public static DataTable GetAllQuestionsByExamID(int ExamID)
        {
            return clsQuestionData.GetAllQuestionsByExamID(ExamID);
        }
    }
}
