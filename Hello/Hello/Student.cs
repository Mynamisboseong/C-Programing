﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Student
    {
        public int grade;
        public string name;
        static void Main(String[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "연하진", grade = 2 });
            list.Add(new Student() { name = "윤아린", grade = 3 });
            list.Add(new Student() { name = "윤명월", grade = 4 });
            list.Add(new Student() { name = "구지연", grade = 1 });
            list.Add(new Student() { name = "김연화", grade = 2 });

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " :" + item.grade);
            }

            for(int i = 0; i< list.Count; i++)
            {
                if (list[i].grade>1)
                    list.RemoveAt(i);
            }
            //foreach(var item in list)
            //{
            //    if (item.grade > 1)
            //        list.RemoveAt(item);
            //}
        }

    }
}
