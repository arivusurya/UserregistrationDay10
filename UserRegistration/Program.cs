using System;
using System.Collections.Generic;
using System.Linq;


namespace UserRegistration{
    public class Program{
        public static void Main(string[] args)
        {
            ValidateUser validateUser   = new ValidateUser();
           string inputMobileNumber = "91 9919819801";
            bool isvalid = validateUser.ValidateMobileNumber(inputMobileNumber);

            if(isvalid)
            {
                Console.WriteLine("{0} is valid" ,inputMobileNumber);
            }else{
                Console.WriteLine("{0} is Not valid", inputMobileNumber);
            }
        }
    }
}