using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System;
namespace UserRegistration
{
    public class ValidateUser
    {
        public bool ValidateFirstName(string firstName)
        {
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(firstName);
        }

        public bool ValidateLastName(string lastName)
        {
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(lastName);
        }

        public bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9]+([._%+-]?[a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-]?[a-zA-Z0-9]+)*(\.[a-zA-Z]{2,})+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public bool ValidateMobileNumber(string mobileNumber)
        {
            string pattern = @"^[1-9][0-9]{0,2}\s[1-9][0-9]{9}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(mobileNumber);
        }
        public bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }
    }
}