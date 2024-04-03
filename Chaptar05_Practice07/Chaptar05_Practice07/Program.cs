using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaptar05_Practice07
{
    internal class Program
    {
        class Person
        {
            public string name;
            public string adder;
            public List<Pet> animal;
        }
        class Pet
        {
            public string name;
            public int age;
        }
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                name = "윤인성",
                adder = "서울 특별시 강서구",
                animal = new List<Pet>{ new Pet() { name = "구름", age = 7 },
                new Pet() {name = "별",age = 1} }
            };

            Console.WriteLine("변수\t\t이름");
            Console.WriteLine("이름\t\t" + person.name);
            Console.WriteLine("주소\t\t" + person.adder);
            Console.WriteLine("반려동물\t");
            foreach(var i in person.animal)
            {
                Console.WriteLine(i.name + ":" + i.age);
                Console.WriteLine("   ");
            }
            
        }
    }
}
