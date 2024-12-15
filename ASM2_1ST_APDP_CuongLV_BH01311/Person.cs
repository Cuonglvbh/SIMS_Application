using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_1ST_APDP_CuongLV_BH01311
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor using encapsulation to initialize the common properties
        protected Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
