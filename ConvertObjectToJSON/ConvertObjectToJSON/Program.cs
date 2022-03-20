using Newtonsoft.Json;
using System;

namespace ConvertObjectToJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 21);

            string userJson = JsonConvert.SerializeObject(person);

            Console.WriteLine(userJson);
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
