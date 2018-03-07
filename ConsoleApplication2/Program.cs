using Autofac;
using ConsoleApplication2.IocAutofac.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    // 程序集批量注册
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var builder = new ContainerBuilder();
            // Where+Lambda
            // builder.RegisterAssemblyTypes(assembly).Where(type => type.Namespace.Equals("ConsoleApplication2.IocAutofac.Example"));
            
            // 类型在ConsoleApplication2.IocAutofac.Example命名空间中
            //builder.RegisterAssemblyTypes(assembly).InNamespace("ConsoleApplication2.IocAutofac.Example");

            // 也是用来判断命名空间的，这种方式是根据类型来获取命名空间
            //builder.RegisterAssemblyTypes(assembly).InNamespaceOf<Program>();
            builder.RegisterAssemblyTypes(assembly).InNamespaceOf<IocClass1>();
            using (IContainer container = builder.Build())
            {
                try
                {
                    Class1 cls1 = container.Resolve<Class1>();
                    if (null != cls1)
                        cls1.print();
                    Class2 cls2 = container.Resolve<Class2>();
                    if (null != cls2)
                        cls2.print();
                }
                catch
                { }
                try
                {
                    IocClass1 IocCls1 = container.Resolve<IocClass1>();
                    if (null != IocCls1)
                        IocCls1.Print();
                }
                catch { }

            }
            Console.ReadKey();
        }
    }
}
