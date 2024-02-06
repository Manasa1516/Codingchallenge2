using CodingChallenge2.Model;
using CodingChallenge2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2.Service
{
    internal class CareerHubService : ICareerHubService
    {
        readonly ICareerHubRepository _service;
        public CareerHubService()
        {
            _service = new CareerHubRepository();
        }
        #region InsertJobListing
        public void InsertJobListing()
        {
            JobListing jobListing = new JobListing();
            Console.WriteLine("Enter JobId::");
            jobListing.JobId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter vehicle CompanyId::");
            jobListing.CompanyId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter JobDescription::");
            jobListing.JobDescription = Console.ReadLine();
            Console.WriteLine("Enter JobLocation::");
            jobListing.JobLocation = (Console.ReadLine());
            Console.WriteLine("Enter Salary::");
            jobListing.Salary = Console.ReadLine();
            Console.WriteLine("Enter JobType::");
            jobListing.JobType = Console.ReadLine();
            Console.WriteLine("Enter PostedDate::");
            jobListing.PostedDate = (Console.ReadLine());

            try
            {
                int InsertJobListingStatus = _service.InsertJobListing(jobListing);
                if (InsertJobListingStatus > 0)
                {
                    Console.WriteLine("Insertion success");
                }
            }
            catch (Exception uaex)
            {
                Console.WriteLine(uaex.Message);
            }
        }
        #endregion
        #region InsertCompany
        public void InsertCompany()
        {
            Company company = new Company();
            Console.WriteLine("Enter CompanyId::");
            company.CompanyId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Company Name::");
            company.CompanyName = (Console.ReadLine());
            Console.WriteLine("Enter Companylocation::");
            company.CompanyLocation = Console.ReadLine();
            try
            {
                int InsertCompanyStatus = _service.InsertCompany(company);
                if (InsertCompanyStatus > 0)
                {
                    Console.WriteLine("Insertion success");
                }
            }
            catch (Exception uaex)
            {
                Console.WriteLine(uaex.Message);
            }
        }
        #endregion
        #region InsertApplicant
        public void InsertApplicant()
        {
            Applicant applicant = new Applicant();
            Console.WriteLine("Enter ApplicantId::");
            applicant.ApplicantId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter FirstName::");
            applicant.FirstName = (Console.ReadLine());
            Console.WriteLine("Enter LastName::");
            applicant.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email::");
            applicant.Email = (Console.ReadLine());
            Console.WriteLine("Enter Phone::");
            applicant.Phone = (Console.ReadLine());
            Console.WriteLine("Enter Resume::");
            applicant.Resume = Console.ReadLine();

            try
            {
                int InsertApplicantStatus = _service.InsertApllicant(applicant);
                if (InsertApplicantStatus > 0)
                {
                    Console.WriteLine("Insertion success");
                }
            }
            catch (Exception uaex)
            {
                Console.WriteLine(uaex.Message);
            }
        }
        #endregion
        #region InsertJobApplication
        public void InsertJobApplication()
        {
            JobApplication jobApplication = new JobApplication();
            Console.WriteLine("Enter ApplicationId::");
            jobApplication.ApplicationId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter JobId::");
            jobApplication.JobId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ApplicantId::");
            jobApplication.ApplicantId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ApplicationDate::");
            jobApplication.ApplicationDate = (Console.ReadLine());
            Console.WriteLine("Enter CoverLetter::");
            jobApplication.CoverLetter = (Console.ReadLine());

            try
            {
                int InsertJobApplicationStatus = _service.InsertJobApplication(jobApplication);
                if (InsertJobApplicationStatus > 0)
                {
                    Console.WriteLine("Insertion success");
                }
            }
            catch (Exception uaex)
            {
                Console.WriteLine(uaex.Message);
            }
        }
        #endregion
        #region GetAllJobListing
        public void GetAllJobListing()
        {
            List<JobListing> allJobListing = _service.GetAllJobListing();
            foreach (JobListing jobListing in allJobListing)
            {
                Console.WriteLine(jobListing);
            }
        }
        #endregion
        #region GetAllJobListing
        public void GetAllJobApplication()
        {
            List<JobApplication> allJobApplication = _service.GetAllJobApplication();
            foreach (JobApplication jobListing in allJobApplication)
            {
                Console.WriteLine(jobListing);
            }
        }
        #endregion
        #region GetAllJobListing
        public void GetAllCompany()
        {
            List<Company> allCompany = _service.GetAllCompany();
            foreach (Company jobListing in allCompany)
            {
                Console.WriteLine(jobListing);
            }
        }
        #endregion
        #region GetAllJobListing
        public void GetAllAppicant()
        {
            List<Applicant> allApplicant = _service.GetAllAppicant();
            foreach (Applicant jobListing in allApplicant)
            {
                Console.WriteLine(jobListing);
            }
        }
        #endregion
        #region GetApplicants
        public void GetApplicantsByJobID()
        {
            Console.WriteLine("Enter JobID:");

            if (int.TryParse(Console.ReadLine(), out int jobID))
            {
                DisplayApplicantDetails(_service.GetApplicants(jobID));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for JobID.");
            }
        }

        private void DisplayApplicantDetails(List<Applicant> applicants)
        {
            if (applicants.Count > 0)
            {
                Console.WriteLine("Applicants found:");
                foreach (Applicant applicant in applicants)
                {
                    Console.WriteLine($"ApplicantID: {applicant.ApplicantId}\n FirstName: {applicant.FirstName}\n LastName: {applicant.LastName}\n Email: {applicant.Email}\n " +
                        $"Phone: {applicant.Phone}\n");

                    // Check if Resume field exists in the Applicant object
                    if (applicant.Resume != null)
                    {
                        Console.WriteLine($"Resume: {applicant.Resume}\n");
                    }
                    else
                    {
                        Console.WriteLine("No Resume found.\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No applicants found for the specified JobID.");
            }
        }

        #endregion
        public void ApplyS()
        {

            Console.WriteLine("Enter Applicant ID: ");
            int applicantID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Job ID: ");
            int jobID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Cover Letter: ");
            string coverLetter = Console.ReadLine();

            _service.Apply(applicantID, coverLetter, jobID);

        }
        public void postJobS()
        {
            Console.Write("Enter Company ID: ");
            int companyID = int.Parse(Console.ReadLine());


            Console.Write("Enter Job Title: ");
            string jobTitle = Console.ReadLine();


            Console.Write("Enter Job Description: ");
            string jobDescription = Console.ReadLine();


            Console.Write("Enter Job Location: ");
            string jobLocation = Console.ReadLine();


            Console.Write("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Job Type(Full-time,Part-time,Contract): ");
            string jobType = Console.ReadLine();

            _service.postJob(companyID, jobTitle, jobDescription, jobLocation, salary, jobType);

        }

    }
}
