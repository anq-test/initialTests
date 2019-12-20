using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Second : Third
    {

        public string name = "anquite";


        public void sayHello()
        {
            Console.WriteLine("Hello");
        }

        public string getGoodbye()
        {
            string str = "Goodbye";
            return str;
        }

        public void saySomething(String x)
        {
            Console.WriteLine(x);
        }

    }
}
