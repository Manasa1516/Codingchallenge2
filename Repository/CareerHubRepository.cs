using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge2.Exceptions;
using CodingChallenge2.Model;
using CodingChallenge2.Utility;

namespace CodingChallenge2.Repository
{
    internal class CareerHubRepository : ICareerHubRepository
    {
        public string connectionString;
        SqlConnection sqlconn = null;
        SqlCommand cmd = null;

        public CareerHubRepository()
        {
            connectionString = DBConnectionUtil.GetConnectionString();
            cmd = new SqlCommand();
        }

        #region InsertJobListing
        public int InsertJobListing(JobListing jobListing)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into JobListing values(@JobId,@CompanyId ,@JobTitle,@JobDescription, @JobLocation ,@Salary,@JobType,@PostedDate)";
                cmd.Parameters.AddWithValue("@JobId", jobListing.JobId);
                cmd.Parameters.AddWithValue("@CompanyId", jobListing.CompanyId);
                cmd.Parameters.AddWithValue("@JobDescription", jobListing.JobDescription);
                cmd.Parameters.AddWithValue("@JobLocation", jobListing.JobLocation);
                cmd.Parameters.AddWithValue("@Salary", jobListing.Salary);
                cmd.Parameters.AddWithValue("@JobType", jobListing.JobType);
                cmd.Parameters.AddWithValue("@PostedDate", jobListing.PostedDate);
                cmd.Connection = sqlconn;
                sqlconn.Open();
                int InsertJobListingStatus = cmd.ExecuteNonQuery();
                return InsertJobListingStatus;
            }
        }
        #endregion
        #region InsertCompany
        public int InsertCompany(Company company)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into Company values(@CompanyId ,@CompanyName,@CompanyLocation)";
                cmd.Parameters.AddWithValue("@CompanyId", company.CompanyId);
                cmd.Parameters.AddWithValue("@CompanyName", company.CompanyName);
                cmd.Parameters.AddWithValue("@CompanyLocation", company.CompanyLocation);
                cmd.Connection = sqlconn;
                sqlconn.Open();
                int InsertCompanyStatus = cmd.ExecuteNonQuery();
                return InsertCompanyStatus;
            }
        }
        #endregion
        #region InsertApplicant
        public int InsertApllicant(Applicant applicant)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into Applicant values(@ApplicantId,@FirstName ,@LastName,@Email, @Phone ,@Resume)";
                cmd.Parameters.AddWithValue("@ApllicantId", applicant.ApplicantId);
                cmd.Parameters.AddWithValue("@ComPanyId", applicant.FirstName);
                cmd.Parameters.AddWithValue("@JobDescription", applicant.LastName);
                cmd.Parameters.AddWithValue("@JobLocation", applicant.Email);
                cmd.Parameters.AddWithValue("@Salary", applicant.Phone);
                cmd.Parameters.AddWithValue("@JobType", applicant.Resume);
                cmd.Connection = sqlconn;
                sqlconn.Open();
                int InsertApplicantStatus = cmd.ExecuteNonQuery();
                return InsertApplicantStatus;
            }
        }
        #endregion
        #region InsertJobApplication
        public int InsertJobApplication(JobApplication jobApplication)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into JobApplication values(@JobId,@ApplicationId ,@ApplicantId,@ApplicationDate, @CoverLetter)";
                cmd.Parameters.AddWithValue("@JobId", jobApplication.JobId);
                cmd.Parameters.AddWithValue("@ApllicationId", jobApplication.ApplicationId);
                cmd.Parameters.AddWithValue("@ApplicantId", jobApplication.ApplicantId);
                cmd.Parameters.AddWithValue("@ApplicationDate", jobApplication.ApplicationDate);
                cmd.Parameters.AddWithValue("@CoverLetter", jobApplication.CoverLetter);
                cmd.Connection = sqlconn;
                sqlconn.Open();
                int InsertJobApplicationStatus = cmd.ExecuteNonQuery();
                return InsertJobApplicationStatus;
            }
        }
        #endregion
        #region ListAllJobListing
        public List<JobListing> GetAllJobListing()
        {
            List<JobListing> jobListingList = new List<JobListing>();
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "select * from JobListing";
                    cmd.Connection = sqlconn;
                    sqlconn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        JobListing jobListing = new JobListing();
                        jobListing.JobId = (int)reader["JobId"];
                        jobListing.CompanyId = (int)reader["CompanyId"];
                        jobListing.JobTitle = (String)reader["JobTitle"];
                        jobListing.JobDescription = (String)reader["JobDescription"];
                        jobListing.JobLocation = (String)reader["JobLocation"];
                        jobListing.Salary = (string)reader["JobLocation"];
                        jobListing.JobType = (String)reader["JobType"];
                        jobListing.PostedDate = (String)reader["PostedDate"];

                        jobListingList.Add(jobListing);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return jobListingList;
        }
        #endregion
        #region ListAllJobApplication
        public List<JobApplication> GetAllJobApplication()
        {
            List<JobApplication> jobApplicationList = new List<JobApplication>();
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "select * from JobApplication";
                    cmd.Connection = sqlconn;
                    sqlconn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        JobApplication jobApplication = new JobApplication();
                        jobApplication.JobId = (int)reader["JobId"];
                        jobApplication.ApplicationId = (int)reader["ApplicationId"];
                        jobApplication.ApplicantId = (int)reader["ApplicantId"];
                        jobApplication.ApplicationDate = (String)reader["ApplicationDate"];
                        jobApplication.CoverLetter = (String)reader["CoverLetter"];

                        jobApplicationList.Add(jobApplication);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return jobApplicationList;
        }
        #endregion
        #region ListAllCompany
        public List<Company> GetAllCompany()
        {
            List<Company> companyList = new List<Company>();
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "select * from Company";
                    cmd.Connection = sqlconn;
                    sqlconn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Company company = new Company();
                        company.CompanyId = (int)reader["CompanyId"];
                        company.CompanyName = (string)reader["CompanyName"];
                        company.CompanyLocation = (String)reader["CompanyLocation"];

                        companyList.Add(company);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return companyList;
        }
        #endregion
        #region ListAllApplicant
        public List<Applicant> GetAllAppicant()
        {
            List<Applicant> applicantList = new List<Applicant>();
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    cmd.CommandText = "select * from Applicant";
                    cmd.Connection = sqlconn;
                    sqlconn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Applicant applicant = new Applicant();
                        applicant.ApplicantId = (int)reader["ApplicantId"];
                        applicant.FirstName = (string)reader["FirstName"];
                        applicant.LastName = (String)reader["LastName"];
                        applicant.Email = (String)reader["Email"];
                        applicant.Phone = (String)reader["Phone"];
                        applicant.Resume = (string)reader["Resume"];

                        applicantList.Add(applicant);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return applicantList;
        }
        #endregion
        #region GetApplicants
        public List<Applicant> GetApplicants(int jobID)
        {
            List<Applicant> applicants = new List<Applicant>();

            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT Applicant.* FROM JobApplication JOIN Applicant ON JobApplication.ApplicantID = Applicant.ApplicantID WHERE JobApplication.JobID = @JobID";
                cmd.Parameters.AddWithValue("@JobID", jobID);
                cmd.Connection = sqlconn;
                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Applicant applicant = new Applicant
                    {
                        ApplicantId = (int)reader["ApplicantId"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        Email = (string)reader["Email"],
                        Phone = (string)reader["Phone"],
                        Resume = (string)reader["Resume"]
                    };
                    applicants.Add(applicant);
                }
            }

            return applicants;
        }
        #endregion
        #region GetJobs
        public List<JobListing> GetJobs(int companyID)
        {
            List<JobListing> jobs = new List<JobListing>();
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Jobs where CompanyID=@CompanyID;";
                    cmd.Parameters.AddWithValue("@CompanyID", companyID);
                    cmd.Connection = sqlconn;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        JobListing job = new JobListing();
                        Company company = new Company();
                        company.CompanyId = (int)reader["CompanyID"];
                        job.JobId = (int)reader["jobID"];
                        job.JobLocation = (string)reader["JobLocation"];
                        job.PostedDate = (string)reader["PostedDate"];
                        job.Salary = (string)reader["salary"];
                        job.JobDescription = (string)reader["JobDescription"];
                        job.JobTitle = (string)reader["JobTitle"];
                        job.JobType = (string)reader["JobType"];

                        jobs.Add(job);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error Occured:{ex.Message}");
                }

                return jobs;
            }
        }
        #endregion
        public void Apply(int applicantID, string coverLetter, int jobID)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO Applications VALUES (@JobID, @ApplicantID,GetDate(), @CoverLetter)";
                    cmd.Connection = sqlconn;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@JobID", jobID);
                    cmd.Parameters.AddWithValue("@ApplicantID", applicantID);
                    cmd.Parameters.AddWithValue("@CoverLetter", coverLetter);

                    int applicationStatus = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public void postJob(int companyID, string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO Jobs VALUES (@CompanyID, @jobTitle,@jobDescription,@jobLocation,@salary,@jobType,GetDate())";
                    cmd.Connection = sqlconn;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CompanyID", companyID);
                    cmd.Parameters.AddWithValue("@jobTitle", jobTitle);
                    cmd.Parameters.AddWithValue("@jobDescription", jobDescription);
                    cmd.Parameters.AddWithValue("@jobLocation", jobLocation);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@jobType", jobType);
                    int postingStatus = cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }


    }
}
