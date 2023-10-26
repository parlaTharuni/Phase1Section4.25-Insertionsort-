using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            //insertion sort
            string[] students = new string[10];
            students[0] = "tharuni";
            students[1] = "idira";
            students[2] = "teju";
            students[3] = "vani";
            students[4] = "zoya";
            students[5] = "john";
            students[6] = "nick";
            students[7] = "priya";
            students[8] = "sravani";
            students[9] = "rishi";
            int n = 10, i, j, flag;
            string Val;
            for (i = 1; i < n; i++)
            {
                Val = students[i];
                flag = 0;
                for (j = i - 1; j>= 0 && flag != 1;)
                {
                    if (Val.CompareTo(students[j]) < 0)
                    {
                        students[j + 1] = students[j];
                        j--;
                        students[j + 1] = Val;
                    }
                    else flag = 1;
                    
                }
            }
            foreach( string s in students)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}

