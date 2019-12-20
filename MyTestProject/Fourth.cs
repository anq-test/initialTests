using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Fourth
    {

        public String weather = "OK";

        public void sayGoodWeather()
        {
            Console.WriteLine("Sunny");
        }

        public void sayBadWeather()
        {
            Console.WriteLine("Rain");
        }


        public bool isGoodWeather(String weatherNow)
        {
            if (weatherNow == "Sunny")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
