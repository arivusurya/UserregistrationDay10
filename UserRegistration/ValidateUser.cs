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
    }
}