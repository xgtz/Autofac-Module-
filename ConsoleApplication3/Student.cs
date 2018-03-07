using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Student:IPerson
    {
        public void Say()
        {
            Console.WriteLine("我是一名学生!");
        }
    }
}
