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
    public class clsExaminationRecordData
    {
        public static clsExaminationRecordEntity GetExaminationRecordByID(int RecordID)
        {
            string query = "SELECT * FROM ExaminationRecords WHERE RecordID = @RecordID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RecordID", SqlDbType.Int){ Value = RecordID }

            };

            DataRow row = DbHelper.GetFirstRow(query, parameters);

            if (row != null)
            {
                return new clsExaminationRecordEntity
                {
                    RecordID = Convert.ToInt32(row["RecordID"]),
                    ExamID = Convert.ToInt32(row["ExamID"]),
                    PersonName = row["PersonName"].ToString(),
                    Score = Convert.ToInt32(row["Score"]),
                    IsPassed = Convert.ToBoolean(row["IsPassed"]),
                    StartedAt = Convert.ToDateTime(row["StartedAt"]),
                    TimeSpendPerMinutes = Convert.ToInt32(row["TimeSpendPerMinutes"])
                };
            }

            return null;
        }
        public static int AddNewExaminationRecord(clsExaminationRecordEntity ExaminationRecordInfo)
        {
            string query = @"INSERT INTO ExaminationRecords
                            (ExamID, PersonName, Score, IsPassed, StartedAt, TimeSpendPerMinutes)
                             VALUES
                            (@ExamID, @PersonName, @Score, @IsPassed, @StartedAt, @TimeSpendPerMinutes);
                             SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamID", SqlDbType.Int)
                { Value = ExaminationRecordInfo.ExamID },

                new SqlParameter("@PersonName", SqlDbType.NVarChar, 100)
                { Value = ExaminationRecordInfo.PersonName },

                new SqlParameter("@Score", SqlDbType.Int)
                { Value = ExaminationRecordInfo.Score },

                new SqlParameter("@IsPassed", SqlDbType.Bit)
                { Value = ExaminationRecordInfo.IsPassed },

                new SqlParameter("@StartedAt", SqlDbType.DateTime)
                { Value = ExaminationRecordInfo.StartedAt },

                new SqlParameter("@TimeSpendPerMinutes", SqlDbType.Int)
                { Value = ExaminationRecordInfo.TimeSpendPerMinutes }
            };

            object result = DbHelper.GetScalar(query, parameters);

            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                return insertedID;

            return -1;
        }
        public static bool UpdateExaminationRecord(clsExaminationRecordEntity ExaminationRecordInfo)
        {
            string query = @"UPDATE ExaminationRecords SET
                                ExamID = @ExamID,
                                PersonName = @PersonName,
                                Score = @Score,
                                IsPassed = @IsPassed,
                                StartedAt = @StartedAt,
                                TimeSpendPerMinutes = @TimeSpendPerMinutes
                             WHERE RecordID = @RecordID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RecordID", SqlDbType.Int)
                { Value = ExaminationRecordInfo.RecordID },

                new SqlParameter("@ExamID", SqlDbType.Int)
                { Value = ExaminationRecordInfo.ExamID },

                new SqlParameter("@PersonName", SqlDbType.NVarChar, 100)
                { Value = ExaminationRecordInfo.PersonName },

                new SqlParameter("@Score", SqlDbType.Int)
                { Value = ExaminationRecordInfo.Score },

                new SqlParameter("@IsPassed", SqlDbType.Bit)
                { Value = ExaminationRecordInfo.IsPassed },

                new SqlParameter("@StartedAt", SqlDbType.DateTime)
                { Value = ExaminationRecordInfo.StartedAt },

                new SqlParameter("@TimeSpendPerMinutes", SqlDbType.Int)
                { Value = ExaminationRecordInfo.TimeSpendPerMinutes }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool DeleteExaminationRecord(int RecordID)
        {
            string query = "DELETE FROM ExaminationRecords WHERE RecordID = @RecordID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RecordID", SqlDbType.Int)
                { Value = RecordID }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static bool IsRecordExist(int RecordID)
        {
            string query = "SELECT 1 FROM ExaminationRecords WHERE RecordID = @RecordID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RecordID", SqlDbType.Int)
                { Value = RecordID }
            };

            object result = DbHelper.GetScalar(query, parameters);
            return result != null;
        }
        public static bool IsRecordExistByExamID(int ExamID)
        {
            string query = "SELECT 1 FROM ExaminationRecords WHERE ExamID = @ExamID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamID", SqlDbType.Int) { Value = ExamID }
            };

            object result = DbHelper.GetScalar(query, parameters);
            return result != null;
        }
        public static DataTable GetAllExaminationRecords()
        {
            string query = "SELECT * FROM ExaminationRecords";
            return DbHelper.GetDataTable(query);
        }
    }
}
