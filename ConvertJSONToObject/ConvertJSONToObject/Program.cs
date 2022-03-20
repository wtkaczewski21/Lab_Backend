using Newtonsoft.Json;
using System;

namespace ConvertJSONToObject
{
    class Program
    {
        static void Main(string[] args)
        {          
            string userJson = "{\"name\":\"John\",\"age\":21}";

            Person person = JsonConvert.DeserializeObject<Person>(userJson);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }

        public class Person
        {
            public string Name;
            public int Age;
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
