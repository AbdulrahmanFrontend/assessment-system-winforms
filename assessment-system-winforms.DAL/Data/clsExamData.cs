using System;
using System.Data;
using System.Data.SqlClient;
using DAL;
using assessment_system_winforms.Core.Entities;

namespace assessment_system_winforms.DAL
{
    public class clsExamData
    {
        public static clsExamEntity GetExamByExamID(int ExamID)
        {
            string query = "SELECT * FROM Exams WHERE ExamID = @ExamID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamID", SqlDbType.Int){ Value = ExamID }
            };

            DataRow row = DbHelper.GetFirstRow(query, parameters);

            if (row != null)
            {
                return new clsExamEntity
                {
                    ExamID = Convert.ToInt32(row["ExamID"]),
                    ExamTitle = row["ExamTitle"].ToString()
                };
            }

            return null;
        }
        public static clsExamEntity GetExamByExamTitle(string ExamTitle)
        {
            string query = "SELECT * FROM Exams WHERE ExamTitle = @ExamTitle";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamTitle", SqlDbType.NVarChar, 100){ Value = ExamTitle }
            };

            DataRow row = DbHelper.GetFirstRow(query, parameters);

            if (row != null)
            {
                return new clsExamEntity
                {
                    ExamID = Convert.ToInt32(row["ExamID"]),
                    ExamTitle = row["ExamTitle"].ToString()
                };
            }

            return null;
        }
        public static int AddNewExam(clsExamEntity ExamInfo)
        {
            string query = @"INSERT INTO Exams (ExamTitle)
                             VALUES (@ExamTitle);
                             SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamTitle", SqlDbType.NVarChar, 100){ Value = ExamInfo.ExamTitle }
            };

            object result = DbHelper.GetScalar(query, parameters);

            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                return insertedID;

            return -1;
        }
        public static bool UpdateExam(clsExamEntity ExamInfo)
        {
            string query = @"UPDATE Exams SET
                                ExamTitle = @ExamTitle
                             WHERE ExamID = @ExamID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamID", SqlDbType.Int){ Value = ExamInfo.ExamID },
                new SqlParameter("@ExamTitle", SqlDbType.NVarChar, 100){ Value = ExamInfo.ExamTitle }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool DeleteExam(int ExamID)
        {
            string query = "DELETE FROM Exams WHERE ExamID = @ExamID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamID", SqlDbType.Int){ Value = ExamID }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool IsExamExist(int ExamID)
        {
            string query = "SELECT 1 FROM Exams WHERE ExamID = @ExamID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamID", SqlDbType.Int){ Value = ExamID }
            };

            return DbHelper.GetScalar(query, parameters) != null;
        }
        public static bool IsExamExist(string ExamTitle)
        {
            string query = "SELECT 1 FROM Exams WHERE Exam = @Exam";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamTitle", SqlDbType.NVarChar, 100){ Value = ExamTitle }
            };

            return DbHelper.GetScalar(query, parameters) != null;
        }
        public static DataTable GetAllExams()
        {
            string query = "SELECT * FROM Exams";
            return DbHelper.GetDataTable(query);
        }
    }
}
