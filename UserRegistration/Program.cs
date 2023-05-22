using System;
using System.Collections.Generic;
using System.Linq;


namespace UserRegistration{
    public class Program{
        public static void Main(string[] args)
        {
            ValidateUser validateUser   = new ValidateUser();
            string firstName = "Ares";
            bool isvalid = validateUser.ValidateFirstName(firstName);

            if(isvalid)
            {
                Console.WriteLine("{0} is valid" ,firstName);
            }else{
                Console.WriteLine("{0} is Not valid", firstName);
            }
        }
    }
}