using System;
using System.Collections.Generic;

namespace Lab1_CreatingClasses
{
    class Person
    {
        public int personId; //define values
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{personId}: {firstName} {lastName}’s favorite colour is {favoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";
        }

        public void DisplayPersonDetails() // details
        {
            Console.WriteLine("PersonId: " + personId);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
            Console.WriteLine("FavoriteColour: " + favoriteColour);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("IsWorking: " + isWorking);
        }
    }

    class Relation
    {
        public string RelationshipType;

        public void ShowRelationship(Person p1, Person p2)
        {
            switch (RelationshipType)
            {
                case "Sister":
                    Console.WriteLine($"Relationship between {p1.firstName} and {p2.firstName} is: Sisterhood");
                    break;
                case "Brother":
                    Console.WriteLine($"Relationship between {p1.firstName} and {p2.firstName} is: Brotherhood");
                    break;
                case "Mother":
                    Console.WriteLine($"Relationship between {p1.firstName} and {p2.firstName} is: Motherhood");
                    break;
                case "Father":
                    Console.WriteLine($"Relationship between {p1.firstName} and {p2.firstName} is: Fatherhood");
                    break;
                default:
                    Console.WriteLine($"Relationship between {p1.firstName} and {p2.firstName} is: Unknown relationship");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { personId = 1, firstName = "Ian", lastName = "Brooks", favoriteColour = "Red", age = 30, isWorking = true };
            Person p2 = new Person { personId = 2, firstName = "Gina", lastName = "James", favoriteColour = "Green", age = 18, isWorking = false };
            Person p3 = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColour = "Blue", age = 45, isWorking = true };
            Person p4 = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColour = "Yellow", age = 28, isWorking = true };

            p1.ChangeFavoriteColour();

            Console.WriteLine($"{p2.personId}: {p2.firstName} {p2.lastName}'s favorite colour is {p2.favoriteColour}");
            p3.DisplayPersonDetails();
            Console.WriteLine($"{p1.personId}: {p1.firstName} {p1.lastName}'s favorite colour is: {p1.favoriteColour}");

            Console.Write($"{p4.firstName} {p4.lastName}'s Age in 10 years is: ");
            Console.WriteLine(p4.age + 10);

            Relation r1 = new Relation { RelationshipType = "Sister" };
            Relation r2 = new Relation { RelationshipType = "Brother" };
            r1.ShowRelationship(p2, p4);
            r2.ShowRelationship(p1, p3);

            List<Person> people = new List<Person> { p1, p2, p3, p4 }; // list of 4 people

            int totalAge = 0;
            for (int i = 0; i < people.Count; i++)
            {
                totalAge += people[i].age;
            }
            double averageAge = (double)totalAge / people.Count;
            Console.WriteLine($"Average age is: {averageAge}");

            Person youngest = people[0];
            Person oldest = people[0];

            for (int i = 1; i < people.Count; i++) // loop with if
            {
                switch (true)
                {
                    case bool _ when people[i].age < youngest.age:
                        youngest = people[i];
                        break;
                }
                switch (true)
                {
                    case bool _ when people[i].age > oldest.age:
                        oldest = people[i];
                        break;
                }
            }

            Console.WriteLine($"The youngest person is: {youngest.firstName}");
            Console.WriteLine($"The oldest person is: {oldest.firstName}");

            p3.DisplayPersonDetails(); // display details
            p4.DisplayPersonDetails();
            p3.DisplayPersonDetails();
        }
    }
}
