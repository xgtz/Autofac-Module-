using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Worker:IPerson
    {
        public void Say()
        {
            Console.WriteLine("我是一名工人!");
        }
    }
}
