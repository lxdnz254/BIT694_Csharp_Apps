using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddingAClass2
{
    class Person
    {
        private String firstName;
        private String lastName;
        private String dob; // date of birth
        private int id;

        public Person(String firstName, String lastName, String dob, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.id = id;
        } // end of constructor

    } // end of class
} // end of namespace