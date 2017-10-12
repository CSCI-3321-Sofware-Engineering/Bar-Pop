using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barpop
{
    class LoginInfo
    {
     
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; set; }

        public LoginInfo(string firstName, string middleName, string lastName, DateTime dateTime)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DateTime = dateTime;
        }
    }
        
    
}

