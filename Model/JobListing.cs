using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2.Model
{
    internal class JobListing
    {
        #region getter setter
        private int jobId;
        private int companyId;
        private string jobTitle;
        private string jobDescription;
        private string jobLocation;
        private string salary;
        private string jobType;
        private string postedDate;

        public int JobId
        {
            get { return jobId; }
            set { jobId = value; }
        }
        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }
        public string JobLocation
        {
            get { return jobLocation; }
            set { jobLocation = value; }
        }
        public String Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string JobType
        {
            get { return jobType; }
            set { jobType = value; }
        }
        public string PostedDate
        {
            get { return postedDate; }
            set { PostedDate = value; }
        }

        #endregion
        public JobListing()
        {

        }
        public JobListing(int _jobID, int _companyId, string _jobTitle, string _jobDescription, string _jobLocation , string _salary, string _jobType, string _postedDate)
        {
            JobId = _jobID;
            CompanyId = _companyId;
            JobTitle = _jobTitle;
            JobDescription = _jobDescription;
            JobLocation = _jobLocation;
            Salary = _salary;
            JobType = _jobType;
            PostedDate = _postedDate;
        }
        public override string ToString()
        {
            return $"JobID::{JobId} CompanyId::{CompanyId} JobTitle:: {JobTitle} JobDescription::{JobDescription} " +
                $"JobLocation:: {JobLocation} Salary::{Salary} JobType::{JobType} PostedDate::{PostedDate}";
        }
    }
}
