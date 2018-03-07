using Autofac;
using Autofac.Features.Indexed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterType<AutoFacManager>();
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly());
            //builder.RegisterType<Worker>().As<IPerson>();

         
            //using (IContainer container = builder.Build())
            //{
            //    AutoFacManager manager = container.Resolve<AutoFacManager>();
            //    manager.Say();
            //}

            builder.RegisterType<Student>().Keyed<IPerson>(DeviceState.Student);
            using (IContainer container = builder.Build())
            {
                IIndex<DeviceState, IPerson> IIndex = container.Resolve<IIndex<DeviceState, IPerson>>();
                IPerson p = IIndex[DeviceState.Student];
                p.Say();
            }

            Console.ReadKey();
        }
    }
}
