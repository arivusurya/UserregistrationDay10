using System;
using System.Collections.Generic;
using System.Linq;


namespace UserRegistration{
    public class Program{
        public static void Main(string[] args)
        {
            ValidateUser validateUser   = new ValidateUser();
            string lastName = "Zeus";
            bool isvalid = validateUser.ValidateLastName(lastName);

            if(isvalid)
            {
                Console.WriteLine("{0} is valid" ,lastName);
            }else{
                Console.WriteLine("{0} is Not valid", lastName);
            }
        }
    }
}