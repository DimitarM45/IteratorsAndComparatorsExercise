using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (personInfo[0] != "END")
            {
                string name = personInfo[0];

                int age = int.Parse(personInfo[1]);

                string town = personInfo[2];

                people.Add(new Person(name, age, town));

                personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            int personIndex = int.Parse(Console.ReadLine()) - 1;

            int matchesCount = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].CompareTo(people[personIndex]) == 0)
                    matchesCount++;
            }

            if (matchesCount == 1)
                Console.WriteLine("No matches");

            else
                Console.WriteLine($"{matchesCount} {people.Count - matchesCount} {people.Count}");
        }
    }
}
