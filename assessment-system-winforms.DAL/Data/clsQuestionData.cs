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
    public class clsQuestionData
    {
        public static clsQuestionEntity GetQuestionByQuestionID(int QuestionID)
        {
            string query = "SELECT * FROM Questions WHERE QuestionID = @QuestionID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@QuestionID", SqlDbType.Int){ Value = QuestionID }
            };

            DataRow row = DbHelper.GetFirstRow(query, parameters);

            if (row != null)
            {
                return new clsQuestionEntity
                {
                    QuestionID = Convert.ToInt32(row["QuestionID"]),
                    Question = row["Question"].ToString(),
                    ExamID = Convert.ToInt32(row["ExamID"]),
                    RightAnswerID = row["RightAnswerID"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["RightAnswerID"]),
                    Explanation = row["Explanation"] == DBNull.Value ? null : row["Explanation"].ToString()
                };
            }

            return null;
        }
        public static int AddNewQuestion(clsQuestionEntity QuestionInfo)
        {
            string query = @"INSERT INTO Questions
                            (Question, ExamID, RightAnswerID, Explanation)
                             VALUES
                            (@Question, @ExamID, @RightAnswerID, @Explanation);
                             SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Question", SqlDbType.NVarChar, 1000)
                { Value = QuestionInfo.Question },

                new SqlParameter("@ExamID", SqlDbType.Int)
                { Value = QuestionInfo.ExamID },

                new SqlParameter("@RightAnswerID", SqlDbType.Int)
                { Value = (object)QuestionInfo.RightAnswerID ?? DBNull.Value },

                new SqlParameter("@Explanation", SqlDbType.NVarChar, 1000)
                { Value = (object)QuestionInfo.Explanation ?? DBNull.Value }
            };

            object result = DbHelper.GetScalar(query, parameters);

            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                return insertedID;

            return -1;
        }
        public static bool UpdateQuestion(clsQuestionEntity QuestionInfo)
        {
            string query = @"UPDATE Questions SET
                                Question = @Question,
                                ExamID = @ExamID,
                                RightAnswerID = @RightAnswerID,
                                Explanation = @Explanation
                             WHERE QuestionID = @QuestionID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@QuestionID", SqlDbType.Int)
                { Value = QuestionInfo.QuestionID },

                new SqlParameter("@Question", SqlDbType.NVarChar, 1000)
                { Value = QuestionInfo.Question },

                new SqlParameter("@ExamID", SqlDbType.Int)
                { Value = QuestionInfo.ExamID },

                new SqlParameter("@RightAnswerID", SqlDbType.Int)
                { Value = (object)QuestionInfo.RightAnswerID ?? DBNull.Value },

                new SqlParameter("@Explanation", SqlDbType.NVarChar, 1000)
                { Value = (object)QuestionInfo.Explanation ?? DBNull.Value }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool DeleteQuestion(int QuestionID)
        {
            string query = "DELETE FROM Questions WHERE QuestionID = @QuestionID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@QuestionID", SqlDbType.Int)
                { Value = QuestionID }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool IsQuestionExist(int QuestionID)
        {
            string query = "SELECT 1 FROM Questions WHERE QuestionID = @QuestionID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@QuestionID", SqlDbType.Int)
                { Value = QuestionID }
            };

            object result = DbHelper.GetScalar(query, parameters);
            return result != null;
        }
        public static DataTable GetAllQuestions()
        {
            string query = "SELECT * FROM Questions";
            return DbHelper.GetDataTable(query);
        }
        public static DataTable GetAllQuestionsByExamID(int ExamID)
        {
            string query = "SELECT * FROM Questions WHERE ExamID = @ExamID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamID", SqlDbType.Int) { Value = ExamID }
            };

            return DbHelper.GetDataTable(query, parameters);
        }
    }
}
