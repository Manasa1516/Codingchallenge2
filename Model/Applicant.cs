using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2.Model
{
    internal class Applicant
    {
        #region getter setter
        private int applicantId;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string resume;

        public int ApplicantId
        {
            get { return applicantId; }
            set { applicantId = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }
        #endregion
        public Applicant()
        {

        }
        public Applicant(int _applicantId, string _firstName, string _lastName, string _email, string _phone, string _resume)
        {
            ApplicantId = _applicantId;
            FirstName = _firstName;
            LastName = _lastName;
            Email = _email;
            Phone = _phone;
            Resume = _resume;
        }
        public override string ToString()
        {
            return $"ApplicantId::{ApplicantId} FirstName::{firstName} LastName:: {lastName} Email::{email} " +
                $"Phone:: {phone} Resume::{resume}";
        }
    }
}
