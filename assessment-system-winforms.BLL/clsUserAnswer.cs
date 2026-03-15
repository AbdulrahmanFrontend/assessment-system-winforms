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
    public class clsUserAnswer : clsBaseBusiness
    {
        public clsUserAnswerEntity UserAnswerInfo { get; set; }
        public clsUserAnswer()
        {
            UserAnswerInfo = new clsUserAnswerEntity();
            UserAnswerInfo.UserAnswerID = -1;
            UserAnswerInfo.RecordID = -1;
            UserAnswerInfo.QuestionID = -1;
            UserAnswerInfo.SelectedAnswerID = -1;
            UserAnswerInfo.IsCorrect = false;

            Mode = clsEnums.enMode.enAddNew;
        }
        private clsUserAnswer(clsUserAnswerEntity UserAnswerInfo)
        {
            this.UserAnswerInfo = UserAnswerInfo;
            Mode = clsEnums.enMode.enUpdate;
        }
        protected override bool _AddNew()
        {
            this.UserAnswerInfo.UserAnswerID = clsUserAnswerData.AddNewUserAnswer(UserAnswerInfo);
            return (this.UserAnswerInfo.UserAnswerID != -1);
        }
        protected override bool _Update()
        {
            return clsUserAnswerData.UpdateUserAnswer(this.UserAnswerInfo);
        }
        public static bool DeleteUserAnswer(int UserAnswerID)
        {
            if (!clsUserAnswerData.IsUserAnswerExist(UserAnswerID))
                return false;

            return clsUserAnswerData.DeleteUserAnswer(UserAnswerID);
        }
        public static bool IsUserAnswerExist(int UserAnswerID)
        {
            return clsUserAnswerData.IsUserAnswerExist(UserAnswerID);
        }
        public static clsUserAnswer FindByUserAnswerID(int UserAnswerID)
        {
            clsUserAnswerEntity UserAnswerInfo = clsUserAnswerData.GetUserAnswerByID(UserAnswerID);

            if (UserAnswerInfo != null)
                return new clsUserAnswer(UserAnswerInfo);

            return null;
        }
        public static DataTable GetUserAnswers()
        {
            return clsUserAnswerData.GetAllUserAnswers();
        }
    }
}
