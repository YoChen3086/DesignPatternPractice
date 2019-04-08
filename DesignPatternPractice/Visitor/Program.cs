using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> persons = new List<Person>();

            Person man1 = new Man();
            man1.Action = "成功";
            persons.Add(man1);

            Person man2 = new Man();
            man2.Action = "失敗";
            persons.Add(man2);

            Person man3 = new Man();
            man3.Action = "戀愛";
            persons.Add(man3);

            Person woman1 = new Woman();
            woman1.Action = "成功";
            persons.Add(woman1);

            Person woman2 = new Woman();
            woman2.Action = "失敗";
            persons.Add(woman2);

            Person woman3 = new Woman();
            woman3.Action = "戀愛";
            persons.Add(woman3);

            foreach (Person person in persons)
            {
                person.GetConclusion();
            }

            Console.ReadLine();
        }
    }
}
