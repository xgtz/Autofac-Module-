using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class AutoFacManager
    {
        IPerson person;
        public AutoFacManager(IPerson myPerson)
        {
            person = myPerson;
        }

        public void Say()
        {
            person.Say();
        }
    }
}
