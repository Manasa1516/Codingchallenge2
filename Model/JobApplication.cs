using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2.Model
{
    internal class JobApplication
    {
        #region getter setter
        private int applicationId;
        private int jobId;
        private int applicantId;
        private string applicationDate;
        private string coverLetter;
        public int ApplicationId
        {
            get { return applicationId; }
            set { applicationId = value; }
        }
        public int JobId
        {
            get { return jobId; }
            set { jobId = value; }
        }
        public int ApplicantId
        {
            get { return applicantId; }
            set { applicantId = value; }
        }
        public string ApplicationDate
        {
            get { return applicationDate; }
            set { applicationDate = value; }
        }
        public string CoverLetter
        {
            get { return coverLetter; }
            set { coverLetter = value; }
        }
        #endregion
        public JobApplication()
        {

        }
        public JobApplication(int _jobID, int _applicationId, int _applicantId, string _applicationDate, string _coverLetter)
        {
            JobId = _jobID;
            ApplicationId = _applicationId;
            ApplicantId = _applicantId;
            ApplicationDate = _applicationDate;
            CoverLetter = _coverLetter;
        }
        public override string ToString()
        {
            return $"JobID::{JobId} ApplicationId::{ApplicationId} ApllicantId:: {ApplicantId} ApplicationDate::{ApplicationDate} " +
                $"CoverLetter:: {CoverLetter}";
        }
    }
}
