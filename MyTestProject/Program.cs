using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Program : Second
    {
        static void Main(string[] args)
        {

            Second myObj = new Second();

            myObj.sayHello();
            Console.WriteLine(myObj.getGoodbye());
            myObj.saySomething("End of Second");

            myObj.sayBigNumber();
            myObj.saySmallNumber();
            int myNumber = myObj.giveThisNumber(100000);
            myObj.saySomething("End of Third x" + myNumber);

            myObj.sayBadWeather();
            myObj.sayGoodWeather();

            Console.WriteLine("Weather is " + myObj.weather);


            Console.WriteLine(myObj.isGoodWeather("Sunny"));
            Console.WriteLine(myObj.name);
           





            Thread.Sleep(15000);

        }
    }
}




//Console.WriteLine("Hello");
// System.Threading.Thread.Sleep(5000);

//ToLower
//ToUpper
//Substring
//Replace
//Length

//string k = "I am in etesting office";

//int kLength = k.Length;
//Console.WriteLine("The length of the line is " + kLength);

//string upperK = k.ToUpper();
//string lowerK = k.ToLower();

//Console.WriteLine(upperK);
//Console.WriteLine(lowerK);

//string stringWithoutE = lowerK.Replace("e", "");
//int lengthWithoutE = stringWithoutE.Length;
//int countE = kLength - lengthWithoutE;


//Console.WriteLine("Total number of E is " + countE);

//string replaceProlifics = k.Replace("Etesting", "Prolifics");
//Console.WriteLine(replaceProlifics);

//string letterPosition10 = k.Substring(9, 1);

//if (letterPosition10 == "a")
//{
//    Console.WriteLine("10th character is a");
//}
//else
//{
//    Console.WriteLine("10th character is not a");
//}


//int x = 25;
//int y = 35;
//int z = 45;

////find out which is greater

//if (x > y & x > z)
//{
//    Console.WriteLine("X is greater");
//}
//else if (y > z)
//{
//    Console.WriteLine("Y is greater");
//}
//else
//{
//    Console.WriteLine("Z is greater");
//}






//find out how many words are there in a string



//string str = "I am in etesting office";

//int amountOfSpaces = 0;

//for (int i = 0; i < str.Length; i++)
//{
//    string s = str.Substring(i,1);
//    if (s == " ")
//    {
//        amountOfSpaces++;
//    } 
//}

//int totalWords = amountOfSpaces + 1;

//Console.WriteLine(totalWords);


//find out how many times letter a was repeated without using replace

//string str = "I am in etesting office";

//int letterRepeated = 0;

//for (int i = 0; i < str.Length; i++)
//{
//    string s = str.Substring(i, 1);
//    if (s == "t")
//    {
//        letterRepeated++;
//    }
//}

//Console.WriteLine(letterRepeated);





//Check whether length of the string is even or odd

//string str = "abcdef";
//int stringLength = str.Length;


//if (stringLength % 2 == 0)
//{
//    Console.WriteLine("Length is even");
//}
//else
//{
//    Console.WriteLine("Length is odd");
//}

