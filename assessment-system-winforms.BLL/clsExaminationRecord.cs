using assessment_system_winforms.Core.Entities;
using assessment_system_winforms.DAL;
using assessment_system_winforms.DAL.Data;
using BLL;
using Core;
using System;
using System.Data;

namespace assessment_system_winforms.BLL
{
    public class clsExaminationRecord : clsBaseBusiness
    {
        public clsExaminationRecordEntity ExaminationRecordInfo { get; set; }
        public clsExaminationRecord()
        {
            ExaminationRecordInfo = new clsExaminationRecordEntity();
            ExaminationRecordInfo.RecordID = -1;
            ExaminationRecordInfo.ExamID = -1;
            ExaminationRecordInfo.PersonName= "";
            ExaminationRecordInfo.Score = 0;
            ExaminationRecordInfo.IsPassed = false;
            ExaminationRecordInfo.StartedAt = DateTime.Now;
            
            Mode = clsEnums.enMode.enAddNew;
        }
        private clsExaminationRecord(clsExaminationRecordEntity ExaminationRecordInfo)
        {
            this.ExaminationRecordInfo = ExaminationRecordInfo;
            Mode = clsEnums.enMode.enUpdate;
        }
        protected override bool _AddNew()
        {
            this.ExaminationRecordInfo.RecordID = clsExaminationRecordData.AddNewExaminationRecord(ExaminationRecordInfo);
            return (this.ExaminationRecordInfo.RecordID != -1);
        }
        protected override bool _Update()
        {
            return clsExaminationRecordData.UpdateExaminationRecord(this.ExaminationRecordInfo);
        }
        public static bool DeleteExaminationRecord(int RecordID)
        {
            if (!clsExaminationRecordData.IsRecordExist(RecordID))
                return false;

            return clsExaminationRecordData.DeleteExaminationRecord(RecordID);
        }
        public static bool IsRecordExist(int RecordID)
        {
            return clsExaminationRecordData.IsRecordExist(RecordID);
        }
        public static bool IsRecordExistByExam(int ExamID)
        {
            return clsExaminationRecordData.IsRecordExistByExamID(ExamID);
        }
        public static clsExaminationRecord FindByExaminationRecordID(int RecordID)
        {
            clsExaminationRecordEntity ExaminationRecordInfo = clsExaminationRecordData.GetExaminationRecordByID(RecordID);

            if (ExaminationRecordInfo != null)
                return new clsExaminationRecord(ExaminationRecordInfo);

            return null;
        }
        public static DataTable GetExaminationRecords()
        {
            return clsExaminationRecordData.GetAllExaminationRecords();
        }
    }
}
