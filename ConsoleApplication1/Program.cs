using Autofac;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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


            var assembly2 = Assembly.Load("ClassLibrary1");
            builder.RegisterAssemblyModules(assembly2);

            using (IContainer container = builder.Build())
            {
                try
                {
                    Class1 cls1 = container.Resolve<Class1>();
                    Class2 cls2 = container.Resolve<Class2>();
                    Console.WriteLine(cls1.Id);
                    Console.WriteLine(cls2.ToString());
                }
                catch { }

                try{
                    ModuleCClass1 cls1 = container.Resolve<ModuleCClass1>();
                    cls1.say();
                }
                catch{}
            }

            Console.ReadKey();
        }
    }
}
