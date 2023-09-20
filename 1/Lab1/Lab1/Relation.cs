using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Relation
    {
        // Fields
        private string person1Role;
        private Person person1;

        private string person2Role;
        private Person person2;

        // Properties
        public string Person1Role { get => person1Role; set => person1Role = value;  }
        public string Person2Role { get => person2Role; set => person2Role = value; }
        public Person Person1 { get => person1; set => person1 = value; }
        public Person Person2 { get => person2; set => person2 = value; }

        // Constructor
        public Relation(string person1Role, Person person1, string person2Role, Person person2)
        {
            Person1Role = person1Role;
            Person1 = person1;
            Person2Role = person2Role;
            Person2 = person2;
        }

        // Methods
        public override string ToString()
        {
            return string.Format("Relationship between {0} and {1} is: {2}", person1.FirstName, person2.FirstName, person1Role + "hood");
        }
    }
}
