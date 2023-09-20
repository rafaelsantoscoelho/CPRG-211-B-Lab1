namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Person person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);

            // Display Gina's information
            Console.WriteLine(person2.DisplayPersonInfo());

            // Display Mike's information
            Console.WriteLine(person3.ToString());

            // Change Ian's favorite color to white
            person1.ChangeFavoriteColor();

            // Display Ian's information
            Console.WriteLine(person1.DisplayPersonInfo());

            // Display Mary's age in 10 years
            Console.WriteLine("Mary Beals's age in 10 years is: " + person4.GetAgeInTenYears());

            // Create Relation instances (linking Person instances together)
            Relation relation1 = new Relation("Sister", person2, "Sister", person4);
            Relation relation2 = new Relation("Brother", person1, "Brother", person3);

            // Display first relation
            Console.WriteLine(relation1.ToString());

            // Display second relation
            Console.WriteLine(relation2.ToString());

            // Create and populate list of people
            List<Person> people = new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            // Determine average age
            double sum = 0.0;

            int youngestAge = int.MaxValue;
            Person youngestPerson = null;

            int oldestAge = int.MinValue;
            Person oldestPerson = null;

            List<Person> peopleNamesM = new List<Person>();
            List<Person> peopleColorBlue = new List<Person>();

            // Get sum of everyone's age
            foreach (Person person in people)
            {
                sum += person.Age;

                if (person.Age > oldestAge)
                {
                    oldestPerson = person;
                    oldestAge = person.Age;
                }

                if (person.Age < youngestAge)
                {
                    youngestPerson = person;
                    youngestAge = person.Age;
                }

                if (person.FirstName[0] == 'M')
                {
                    peopleNamesM.Add(person);
                }

                if (person.FavoriteColor == "Blue")
                {
                    peopleColorBlue.Add(person);
                }
            }

            // Display average age
            Console.WriteLine("Average age is: " + (sum / (double) people.Count));

            // Display names of youngest person and oldest person
            Console.WriteLine("The youngest person is: " + youngestPerson.FirstName);
            Console.WriteLine("The oldest person is: " + oldestPerson.FirstName);

            // Display names of people whose names begin with M
            foreach (Person person in peopleNamesM)
            {
                Console.WriteLine(person.ToString());
            }

            // Display names of people that like the color blue
            foreach (Person person in peopleColorBlue)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
