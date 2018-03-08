using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    // 类型/泛型注册
    class Program
    {
       
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Class1>();
            //builder.RegisterType(Type.GetType("ClassLibrary1.Blog"));

            
            using (IContainer container = builder.Build())
            {
                //try
                //{
                //    var blog = container.Resolve(Type.GetType("ClassLibrary1.Blog"));
                //    Console.WriteLine(blog.ToString());
                //    if (null != blog)
                //    {
                //        ClassLibrary1.Blog blogCls = (ClassLibrary1.Blog)blog;
                //        blogCls.print();
                //    }
                //}
                //catch { }


                try
                {
                    Class1 cls1 = container.Resolve<Class1>();
                    if (null != cls1)
                        cls1.print();
                }
                catch { }
            }
            Console.ReadKey();
        }
    }
}
