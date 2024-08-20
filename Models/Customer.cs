using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;

namespace Loan_Orginition.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; } // Calculated from DateOfBirth
        public CustomerGender Gender { get; set; } //Option Menu
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int LegalID { get; set; }

        public DateTime legalID_issueDate { get; set; }

        public DateTime legalID_ExpDate { get; set; }
        public byte[] NationalIdFile { get; set; } // Photo or file as a byte array
        public byte[] PassportIdFile { get; set; } // Photo or file as a byte array
        public CustomerIDType IDType { get; set; } // Option Menu
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; } // Calculated as IssueDate+10
        public Address Address { get; set; }
        public CustomerStatus Status { get; set; }
        public string Occupation { get; set; }
        public int Salary { get; set; }
        public CustomerSalaryTransfer SalaryTransfer { get; set; }

        public byte[] BankStatement { get; set; } // Photo or file as a byte array

        public byte[] HRLetter { get; set; } // Photo or file as a byte array

        public String CompanyName { get; set; }

        public Address CompanyAddress { get; set; }

        public CompanyType CompanyType { get; set; }

        public int MonthOfBusiness { get; set; }

        public int NumberofLoans { get; set; }

        public string ClubName { get; set; }

        public byte[] ClubID { get; set; } // Photo or file as a byte array

        public int Steps { get; set; }
    }
}