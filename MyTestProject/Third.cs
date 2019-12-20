using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Third : Fourth
    {

        int ten = 10;

        public void saySmallNumber ()
        {
            Console.WriteLine(5);
        }


        public void sayBigNumber ()
        {
            Console.WriteLine(5000);
        }

        public int giveThisNumber (int x)
        {
            return x;
        }
    }
}
