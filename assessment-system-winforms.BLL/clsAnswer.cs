using assessment_system_winforms.Core.Entities;
using assessment_system_winforms.DAL.Data;
using BLL;
using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_system_winforms.BLL
{
    public class clsAnswer : clsBaseBusiness
    {
        public clsAnswerEntity AnswerInfo { get; set; }
        public clsAnswer()
        {
            AnswerInfo = new clsAnswerEntity();
            AnswerInfo.AnswerID = -1;
            AnswerInfo.QuestionID = -1;
            AnswerInfo.Answer = "";

            Mode = clsEnums.enMode.enAddNew;
        }
        private clsAnswer(clsAnswerEntity AnswerInfo)
        {
            this.AnswerInfo = AnswerInfo;
            Mode = clsEnums.enMode.enUpdate;
        }
        protected override bool _AddNew()
        {
            this.AnswerInfo.AnswerID = clsAnswerData.AddNewAnswer(AnswerInfo);
            return (this.AnswerInfo.AnswerID != -1);
        }
        protected override bool _Update()
        {
            return clsAnswerData.UpdateAnswer(this.AnswerInfo);
        }
        public static bool DeleteAnswer(int AnswerID)
        {
            if (!clsAnswerData.IsAnswerExist(AnswerID))
                return false;

            return clsAnswerData.DeleteAnswer(AnswerID);
        }
        public static bool IsAnswerExist(int AnswerID)
        {
            return clsAnswerData.IsAnswerExist(AnswerID);
        }
        public static clsAnswer FindByAnswerID(int AnswerID)
        {
            clsAnswerEntity AnswerInfo = clsAnswerData.GetAnswerByAnswerID(AnswerID);

            if (AnswerInfo != null)
                return new clsAnswer(AnswerInfo);

            return null;
        }
        public static DataTable GetAnswers()
        {
            return clsAnswerData.GetAllAnswers();
        }
        public static DataTable GetAnswersByQuestionID(int QuestionID)
        {
            return clsAnswerData.GetAnswersByQuestionID(QuestionID);
        }
    }
}
