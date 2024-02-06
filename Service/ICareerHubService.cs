using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2.Service
{
    internal interface ICareerHubService
    {
        void InsertJobListing();
        void InsertCompany();
        void InsertApplicant();
        void InsertJobApplication();
        void GetAllJobListing();
        void GetAllJobApplication();
        void GetAllCompany();
        void GetAllAppicant();
        void postJobS();
        void ApplyS();
        void GetApplicantsByJobID();

    }
}
