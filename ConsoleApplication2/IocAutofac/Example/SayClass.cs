using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.IocAutofac.Example
{
    public class SayClass:Interface1
    {
        public void say()
        {
            Console.WriteLine("SayClass Object !!");
        }
    }
}
