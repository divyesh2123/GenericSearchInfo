using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSearchInfo
{
    public class Person
    {
        public string FirstName { get; set; }
        public int YearOfBirth { get; set; }
    }

    public class Developer : Person
    {
        public Manager Manager { get; set; }
    }
    public class Manager : Person
    {
    }

}
