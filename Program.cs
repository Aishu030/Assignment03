using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assignment 03-P1
            //string myString = "1333";
            //int myInt;
            //if(int.TryParse(myString, out myInt))
            //{
            //    Console.WriteLine("Converted Integer: \t"+myInt);
            //}
            //else { Console.WriteLine("Failed"); }

            //string doublestring="13333";
            //try
            //{
            //    double val = Convert.ToDouble(doublestring);

            //    Console.WriteLine("converted successfully: " +doublestring);
            //}
            //catch (FormatException){
            //    Console.WriteLine("Format exception");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Overflow Exception");
            //}

            //string decimalString = "10.19";
            //try
            //{
            //    decimal decimalValue = decimal.Parse(decimalString);
            //    Console.WriteLine("Successfully parsed string to decimal: " + decimalValue);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format exception" + ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Overflow Exception" + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error!!!" + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("End of Program!!!");

            //    Console.ReadKey();
            //}


            //Assignment 03-P2
            // Convert string to integer using TryParse
            string tparse= "10";
            int resultInt;
            if (int.TryParse(tparse, out resultInt))
            {
                int finalValue = resultInt * 5;
                Console.WriteLine("Final value: " + finalValue);
            }
            else
            {
                Console.WriteLine("Error!!!");
            }

            // Convert string to DateTime using Convert
            string Dtobj = "01/06/2022";
            try
            {
                DateTime convertedDateTime = Convert.ToDateTime(Dtobj);
                DateTime subtractedDateTime = convertedDateTime.AddMonths(-1);
                Console.WriteLine("Subtracted DateTime: " + subtractedDateTime);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error!!" +ex.Message);
            }

            // Convert string to TimeSpan using Parse
            string timeSpanStr = "05:45:33";
            try
            {
                TimeSpan convertedTimeSpan = TimeSpan.Parse(timeSpanStr);
                TimeSpan addedTimeSpan = convertedTimeSpan.Add(new TimeSpan(5, 1, 0));
                Console.WriteLine("Added TimeSpan: " + addedTimeSpan);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error!!!" +ex.Message);
            }
            finally { Console.WriteLine("end");
                    
            Console.ReadKey();
            }

        }
    }
}
