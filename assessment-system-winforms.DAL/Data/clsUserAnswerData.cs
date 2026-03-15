using assessment_system_winforms.Core.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_system_winforms.DAL.Data
{
    public class clsUserAnswerData
    {
        public static clsUserAnswerEntity GetUserAnswerByID(int UserAnswerID)
        {
            string query = "SELECT * FROM UserAnswers WHERE UserAnswerID = @UserAnswerID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserAnswerID", SqlDbType.Int){ Value = UserAnswerID }

            };

            DataRow row = DbHelper.GetFirstRow(query, parameters);

            if (row != null)
            {
                return new clsUserAnswerEntity
                {
                    UserAnswerID = Convert.ToInt32(row["UserAnswerID"]),
                    RecordID = Convert.ToInt32(row["RecordID"]),
                    QuestionID = Convert.ToInt32(row["QuestionID"]),
                    SelectedAnswerID = Convert.ToInt32(row["SelectedAnswerID"]),
                    IsCorrect = Convert.ToBoolean(row["IsCorrect"]),
                };
            }

            return null;
        }
        public static int AddNewUserAnswer(clsUserAnswerEntity UserAnswerInfo)
        {
            string query = @"INSERT INTO UserAnswers
                            (RecordID, QuestionID, SelectedAnswerID, IsCorrect)
                             VALUES
                            (@RecordID, @QuestionID, @SelectedAnswerID, @IsCorrect);
                             SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RecordID", SqlDbType.Int)
                { Value = UserAnswerInfo.RecordID },
                
                new SqlParameter("@QuestionID", SqlDbType.Int)
                { Value = UserAnswerInfo.QuestionID },
                
                new SqlParameter("@SelectedAnswerID", SqlDbType.Int)
                { Value = UserAnswerInfo.SelectedAnswerID },
                
                new SqlParameter("@IsCorrect", SqlDbType.Bit)
                { Value = UserAnswerInfo.IsCorrect }
            };

            object result = DbHelper.GetScalar(query, parameters);

            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                return insertedID;

            return -1;
        }
        public static bool UpdateUserAnswer(clsUserAnswerEntity UserAnswerInfo)
        {
            string query = @"UPDATE UserAnswers SET
                                RecordID = @RecordID,
                                QuestionID = @QuestionID,
                                SelectedAnswerID = @SelectedAnswerID,
                                IsCorrect = @IsCorrect
                             WHERE UserAnswerID = @UserAnswerID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserAnswerID", SqlDbType.Int)
                { Value = UserAnswerInfo.UserAnswerID },

                new SqlParameter("@RecordID", SqlDbType.Int)
                { Value = UserAnswerInfo.RecordID },
                
                new SqlParameter("@QuestionID", SqlDbType.Int)
                { Value = UserAnswerInfo.QuestionID },
                
                new SqlParameter("@SelectedAnswerID", SqlDbType.Int)
                { Value = UserAnswerInfo.SelectedAnswerID },
                
                new SqlParameter("@IsCorrect", SqlDbType.Bit)
                { Value = UserAnswerInfo.IsCorrect }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool DeleteUserAnswer(int UserAnswerID)
        {
            string query = "DELETE FROM UserAnswers WHERE UserAnswerID = @UserAnswerID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserAnswerID", SqlDbType.Int)
                { Value = UserAnswerID }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool IsUserAnswerExist(int UserAnswerID)
        {
            string query = "SELECT 1 FROM UserAnswers WHERE UserAnswerID = @UserAnswerID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserAnswerID", SqlDbType.Int)
                { Value = UserAnswerID }
            };

            object result = DbHelper.GetScalar(query, parameters);
            return result != null;
        }
        public static DataTable GetAllUserAnswers()
        {
            string query = "SELECT * FROM UserAnswers";
            return DbHelper.GetDataTable(query);
        }
    }
}
