using System;
using System.IO;

namespace SleepData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ask for input
            Console.WriteLine("Enter 1 to create data file.");
            Console.WriteLine("Enter 2 to parse data.");
            Console.WriteLine("Enter anything else to quit.");
            // input response
            string resp = Console.ReadLine();

            // specify path for data file
            string file = "data.txt";

            if (resp == "1")
            {
                // create data file

                // ask a question
                Console.WriteLine("How many weeks of data is needed?");
                // input the response (convert to int)
                int weeks = int.Parse(Console.ReadLine());

                // determine start and end date
                DateTime today = DateTime.Now;
                // we want full weeks sunday - saturday
                DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
                // subtract # of weeks from endDate to get startDate
                DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));

                // random number generator
                Random rnd = new Random();

                // create file
                StreamWriter sw = new StreamWriter(file);
                // loop for the desired # of weeks
                while (dataDate < dataEndDate)
                {
                    // 7 days in a week
                    int[] hours = new int[7];
                    for (int i = 0; i < hours.Length; i++)
                    {
                        // generate random number of hours slept between 4-12 (inclusive)
                        hours[i] = rnd.Next(4, 13);
                    }
                    // M/d/yyyy,#|#|#|#|#|#|#
                    //Console.WriteLine($"{dataDate:M/d/yy},{string.Join("|", hours)}");
                    sw.WriteLine($"{dataDate:M/d/yyyy},{string.Join("|", hours)}");
                    // add 1 week to date
                    dataDate = dataDate.AddDays(7);
                }
                sw.Close();
            }
            else if (resp == "2")
            {
                if (File.Exists(file))
                {
                    // read data from file
                    StreamReader sr = new StreamReader(file);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
               
                        string[] week = line.Split(',');
                        
                        DateTime date = DateTime.Parse(week[0]);
                      
                        int[] hours = Array.ConvertAll(week[1].Split('|'), int.Parse);
                       
                        Console.WriteLine($"Week of {date:MMM}, {date:dd}, {date:yyyy}");
                        // display column headers
                        Console.WriteLine($"{"Sun",3}{"Mon",3}{"Tue",3}{"Wed",3}{"Thur",3}{"Fri",3}{"Sat",3}"); 
                        Console.WriteLine($"{"--",3}{"--",3}{"--",3}{"--",3}{"--",3}{"--",3}{"--",3}"); 
                        // display hours of sleep for each day
                        Console.WriteLine($"{hours[0],3}{hours[1],3}{hours[2],3}{hours[3],3}{hours[4],3}{hours[5],3}{hours[6],3}"); 
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                   
                }
            }
           
        }
        }
    }

