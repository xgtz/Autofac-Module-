using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Class1>();
            //builder.RegisterType<Class2>();
            //builder.RegisterType<Class3>();
            using (IContainer container = builder.Build())
            {
                Class1 cls1 = container.Resolve<Class1>();
                cls1.print();

                Class2 cls2 = container.ResolveOptional<Class2>();
                if (null != cls2)
                    cls2.print();
                else
                    Console.WriteLine("cls2 is null ...");

                Class3 cls3 = null;
                if (container.TryResolve<Class3>(out cls3))
                {
                    cls3.print();
                }
                else
                    Console.WriteLine("cls3 is null ...");
            }

            Console.ReadKey();

        }
    }
}
