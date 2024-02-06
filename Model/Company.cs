using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2.Model
{
    internal class Company
    {
        #region getter setter
        private int companyId;
        private string companyName;
        private string companyLocation;
        
        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string CompanyLocation
        {
            get { return companyLocation; }
            set { companyLocation = value; }
        }

        #endregion
        public Company()
        {

        }
        public Company(int _companyId, string _companyName, string _companyLocation)
        {
            CompanyId = _companyId;
            CompanyName = _companyName;
            CompanyLocation = _companyLocation;
        }
        public override string ToString()
        {
            return $"CompanyId::{CompanyId} CompanyName::{CompanyName} CompanyLocation:: {CompanyLocation}";
        }
    }
}
