using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2HomeworkPacket
{
    class DatatypeHarness
    {
        static void Main(string[] args)
        {
            Student brandon = new Student("Brandon", "Smith", "123456", 3.6f);
            Console.WriteLine(brandon);

            Vehicle skyline = new Vehicle("Nissan", "Skyline", 1994, 3600);
            Console.WriteLine(skyline);

            Login me = new Login("Bsmith", "066598");
            Console.WriteLine(me);

            ContactInfo mySelf = new ContactInfo("123 W. Road", "Kansas City", "Kansas", "66065", "913-555-8965", "email@email.com");
            Console.WriteLine(mySelf);
        }
    }
}
