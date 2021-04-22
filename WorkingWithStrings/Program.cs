using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = @"\Hello";
            //string myString = string.Format("{0:C}", 123.45);
            // string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("{0} = {1}", "First", "Second");
            //string myString = string.Format("Percentage: {0:P}", .123);
            //string myString = string.Format("Phone no: {0:(###) ###-####}", 1234567890);
            // string myString = " As long as you love me  ";
            //myString = myString.Substring(6, 12);
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 12);
            //  myString = string.Format("Before trim {0} - after trim {1}", myString.Length, myString.Trim().Length);
            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            { 
                myString.Append("--");
            myString.Append(i);

            

            }

            
           Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
