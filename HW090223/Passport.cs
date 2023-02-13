using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW090223
{
    internal class Passport
    {
        private string type;
        private string countryCode;
        private string passportNumber;
        private string lastName;
        private string firstName;
        private string citizenship;
        private DateTime dateOfBirth;
        private string gender;
        private string recordNumber;
        private string placeOfBirth;
        private string issuingAuthority;
        private DateTime dateOfIssue;
        private DateTime expirationDate;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string CountryCode
        {
            get { return countryCode; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Z]+$"))
                {
                    throw new ArgumentException("Country code must contain only uppercase letters and contain only characters from the Latin alphabet.");
                }
                countryCode = value;
            }
        }

        public string PassportNumber
        {
            get { return passportNumber; }
            set
            {
                if (value.Length < 7)
                {
                    throw new ArgumentException("Passport number must be at least 7 characters long.");
                }
                passportNumber = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Z]+$"))
                {
                    throw new ArgumentException("Second name must contain only uppercase letters and contain only characters from the Latin alphabet.");
                }
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Z]+$"))
                {
                    throw new ArgumentException("First name must contain only uppercase letters and contain only characters from the Latin alphabet.");
                }
            }
        }

        public string Citizenship
        {
            get { return citizenship; }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Z]+$"))
                {
                    throw new ArgumentException("Citizenship must contain only uppercase letters and contain only characters from the Latin alphabet.");
                }
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set 
            {
                if (value.Year - DateTime.Now.Year < 16)
                    throw new ArgumentException("Person must be at least 16 years of age.");
                dateOfBirth = value; 
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Gender must be either 'Male' or 'Female'.");
                }
                gender = value;
            }
        }

        public string RecordNumber
        {
            get { return recordNumber; }
            set 
            { 
                if(!Regex.IsMatch(value, $""))
                recordNumber = value; 
            }
        }

        public string PlaceOfBirth
        {
            get { return placeOfBirth; }
            set { placeOfBirth = value; }
        }

        public string IssuingAuthority
        {
            get { return issuingAuthority; }
            set { issuingAuthority = value; }
        }

        public DateTime DateOfIssue
        {
            get { return dateOfIssue; }
            set { dateOfIssue = value; }
        }

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
    }
}
