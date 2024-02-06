using CodingChallenge2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2.Repository
{
    internal interface ICareerHubRepository
    {
        int InsertJobListing(JobListing jobListing);
        int InsertCompany(Company company);
        int InsertApllicant(Applicant applicant);
        int InsertJobApplication(JobApplication jobApplication);
        List<JobListing> GetAllJobListing();
        List<JobApplication> GetAllJobApplication();
        List<Company> GetAllCompany();
        List<Applicant> GetAllAppicant();
        List<Applicant> GetApplicants(int jobID);
        List<JobListing> GetJobs(int companyID);
        void Apply(int applicantID, string coverLetter, int jobID);
        void postJob(int companyID, string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType);

    }
}
