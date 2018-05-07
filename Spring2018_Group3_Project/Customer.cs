using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring2018_Group3_Project
{
    public class Customer
    {
        // Customer Variables
        public CarRegistration carRec { get; set; }
        private string _strFirstName;
        public string strFirstName
        {
            get
            {
                return _strFirstName;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                    {
                        throw new ArgumentException("The First Name field must contain only letters");
                    }
                }
                _strFirstName = value;
            }
        }
        private string _strLastName;
        public string strLastName
        {
            get
            {
                return _strLastName;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                    {
                        throw new ArgumentException("The Last Name field must contain only letters");
                    }
                }
                _strLastName = value;
            }
        }
        private string _strEmail;
        public string strEmail
        {
            get
            {
                return _strEmail;
            }
            set
            {
                if (value.Length > 0)
                {
                    bool foundAt = false;
                    int index = 0;
                    foreach (char c in value)
                    {
                        if (c == ' ')
                        {
                            throw new ArgumentException("An email address may not contain spaces");
                        }
                        if (c == '@' && !foundAt)
                        {
                            if (index == 0 || index == value.Length - 1)
                            {
                                throw new ArgumentException("An email address may not contain an '@' at the start or end of the string");
                            }
                            foundAt = true;
                        }
                        else if (c == '@' && foundAt)
                        {
                            throw new ArgumentException("An email address may not contain multiple '@'");
                        }
                        index++;
                    }
                    if (!foundAt)
                    {
                        throw new ArgumentException("An email address must contain an '@'");
                    }
                    _strEmail = value;
                }
            }
        }
        private string _strPhoneNumber;
        public string strPhoneNumber
        {
            get
            {
                return _strPhoneNumber;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!((c >= '0' && c <= '9') || c == '(' || c == ')' || c == '-'))
                    {
                        throw new ArgumentException("A Phone Number must consist of only numbers, dashes, and parenthesis");
                    }
                }
                _strPhoneNumber = value;
            }
        }
        private string _strAddress;
        public string strAddress
        {
            get
            {
                return _strAddress;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!(c == '.' || c == ' ' || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z')))
                    {
                        throw new ArgumentException("The Address field may not contain special characters");
                    }
                }
                _strAddress = value;
            }
        }
        private string _strCity;
        public string strCity
        {
            get
            {
                return _strCity;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!((c >= 'a' && c <= 'z') || c == ' ' || (c >= 'A' && c <= 'Z')))
                    {
                        throw new ArgumentException("The City field must contain only letters");
                    }
                }
                _strCity = value;
            }
        }
        private string _strState;
        public string strState
        {
            get
            {
                return _strState;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                    {
                        throw new ArgumentException("The State field must contain only letters");
                    }
                }
                _strState = value;
            }
        }
        private string _strZipcode;
        public string strZipcode
        {
            get
            {
                return _strZipcode;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!(c >= '0' && c <= '9'))
                    {
                        throw new ArgumentException("The Zipcode field must contain only numbers");
                    }
                }
                _strZipcode = value;
            }
        }
        private string _strDriverID;
        public string strDriverID
        {
            get
            {
                return _strDriverID;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z')))
                    {
                        throw new ArgumentException("The Driver License field may not contain special characters and all letters must be capitalized");
                    }
                }
                _strDriverID = value;
            }
        }
        private DateTime _dtDOB;
        public DateTime dtDOB
        {
            get
            {
                return _dtDOB;
            }
            set
            {
                // Calculates age
                int iAge = DateTime.Today.Year - value.Year;
                if (!(iAge >= 18))
                {
                    throw new ArgumentException("You must be at least 18 years of age to drive a motorvehicle, according to US law");
                }
                _dtDOB = value;
            }
        }

        // Constructor
        public Customer()
        {
            carRec = new CarRegistration();
            strFirstName = "";
            strLastName = "";
            strEmail = "";
            strPhoneNumber = "";
            strAddress = "";
            strCity = "";
            strState = "";
            strZipcode = "";
            strDriverID = "";
        }
    }
}
