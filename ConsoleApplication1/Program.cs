using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ModuleA>();
            builder.RegisterModule(new ModuleB());

            using (IContainer container = builder.Build())
            {
                Class1 cls1 = container.Resolve<Class1>();
                Class2 cls2 = container.Resolve<Class2>();
                Console.WriteLine(cls1.Id);
                Console.WriteLine(cls2.ToString());
            }

            Console.ReadKey();
        }
    }
}
