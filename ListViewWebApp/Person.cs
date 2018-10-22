using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListViewWebApp
{
    [Serializable]
    public class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;


        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
    }
}