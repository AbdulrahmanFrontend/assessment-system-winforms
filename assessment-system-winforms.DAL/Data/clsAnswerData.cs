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
    public class clsAnswerData
    {
        public static clsAnswerEntity GetAnswerByAnswerID(int AnswerID)
        {
            string query = "SELECT * FROM Answers WHERE AnswerID = @AnswerID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@AnswerID", SqlDbType.Int){ Value = AnswerID }
            };

            DataRow row = DbHelper.GetFirstRow(query, parameters);

            if (row != null)
            {
                return new clsAnswerEntity
                {
                    AnswerID = Convert.ToInt32(row["AnswerID"]),
                    QuestionID = Convert.ToInt32(row["QuestionID"]),
                    Answer = row["Answer"].ToString()
                };
            }

            return null;
        }
        public static int AddNewAnswer(clsAnswerEntity AnswerInfo)
        {
            string query = @"INSERT INTO Answers
                            (QuestionID, Answer)
                             VALUES
                            (@QuestionID, @Answer);
                             SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
                new SqlParameter("@QuestionID", SqlDbType.Int)
                { Value = AnswerInfo.QuestionID },
                
                new SqlParameter("@Answer", SqlDbType.NVarChar, 500)
                { Value = AnswerInfo.Answer }
            };

            object result = DbHelper.GetScalar(query, parameters);

            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                return insertedID;

            return -1;
        }
        public static bool UpdateAnswer(clsAnswerEntity AnswerInfo)
        {
            string query = @"UPDATE Answers SET
                                QuestionID = @QuestionID,
                                Answer = @Answer
                             WHERE AnswerID = @AnswerID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@AnswerID", SqlDbType.Int)
                { Value = AnswerInfo.AnswerID },

                new SqlParameter("@QuestionID", SqlDbType.Int)
                { Value = AnswerInfo.QuestionID },

                new SqlParameter("@Answer", SqlDbType.NVarChar, 500)
                { Value = AnswerInfo.Answer }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool DeleteAnswer(int AnswerID)
        {
            string query = "DELETE FROM Answers WHERE AnswerID = @AnswerID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@AnswerID", SqlDbType.Int)
                { Value = AnswerID }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool IsAnswerExist(int AnswerID)
        {
            string query = "SELECT 1 FROM Answers WHERE AnswerID = @AnswerID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@AnswerID", SqlDbType.Int)
                { Value = AnswerID }
            };

            object result = DbHelper.GetScalar(query, parameters);
            return result != null;
        }
        public static DataTable GetAllAnswers()
        {
            string query = "SELECT * FROM Answers";
            return DbHelper.GetDataTable(query);
        }
        public static DataTable GetAnswersByQuestionID(int QuestionID)
        {
            string query = "SELECT * FROM Answers WHERE QuestionID = @QuestionID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@QuestionID", SqlDbType.Int) { Value = QuestionID }
            };

            return DbHelper.GetDataTable(query, parameters);
        }
    }
}
