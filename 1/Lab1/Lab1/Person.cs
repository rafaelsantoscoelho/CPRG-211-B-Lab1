using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        // Fields
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        // Properties
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = (value >= 0 && value <= 122) ? value : 122; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        // Constructor
        public Person(int id, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteColor = favoriteColor;
            IsWorking = isWorking;
        }

        // Methods
        public string DisplayPersonInfo()
        {
            return string.Format("{0}: {1}'s favorite colour is {2}", id, firstName + " " + lastName, favoriteColor);
        }

        public void ChangeFavoriteColor() { FavoriteColor = "White"; }
            
        public int GetAgeInTenYears() { return age + 10; }

        public override string ToString()
        {
            return string.Format("PersonId: {0}\nFirstName: {1}\nLastName: {2}\nFavoriteColour: {3}\nAge: {4}\nIsWorking: {5}", id, firstName, lastName, favoriteColor, age, isWorking);
        }
    }
}
