using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Utility.SetUnicodeConsole();

            List<TimeSpan> timeSpans = CreateRandomTimeSpans();

            Utility.WriteTitle("Less than 12h");
            ForEachTime(FindTimeSpansLessThan12Hours(timeSpans));

            Utility.WriteTitle("TimeSpan with 5h");
            TimeSpan5Hours(timeSpans);

            Utility.WriteTitle("True For All");
            TrueAll(timeSpans);

            Utility.WriteTitle("Convert Hours");
            Hours(timeSpans);

            Utility.TerminateConsole();

        }


        public static List<TimeSpan> CreateRandomTimeSpans()
        {
            Random random = new Random();
            List<TimeSpan> timeSpans = new List<TimeSpan>();
            for (int i = 0; i < 10; i++)
            {
                int hours = random.Next(0, 25);
                TimeSpan timeSpan = new TimeSpan(hours, 0, 0);
                timeSpans.Add(timeSpan);
            }
            return timeSpans;
        }

        public static List<TimeSpan> FindTimeSpansLessThan12Hours(List<TimeSpan> timeSpans)
        {
            return timeSpans.FindAll(timeSpan => timeSpan.TotalHours < 12);
        }

        public static void TimeSpan5Hours(List<TimeSpan> timeSpans)
        {
            bool has5Hours = timeSpans.Exists(timeSpan => timeSpan.Hours == 5);
            if (has5Hours)
            {
                Console.WriteLine("Pelo menos um TimeSpan tem 5 horas.");
            }
            else
            {
                Console.WriteLine("Nenhum TimeSpan tem 5 horas.");
            }
        }

        public static void TrueAll(List<TimeSpan> timeSpans)
        {
            bool allInRange = timeSpans.TrueForAll(timeSpan => timeSpan.TotalHours >= 0 && timeSpan.TotalHours <= 24);
            if (allInRange)
            {
                Console.WriteLine("All Good");
            }
            else
            {
                Console.WriteLine("Algo esta mal");
            }
        }

        public static void Hours(List<TimeSpan> timeSpans)
        {
            List<int> hours = timeSpans.ConvertAll(timeSpan => timeSpan.Hours);

            foreach (int hour in hours)
            {
                Console.WriteLine(hour);
            }
        }

        public static void ForEachTime(List<TimeSpan> timeSpans) 
        {
        foreach (TimeSpan timeSpan in timeSpans)
            {
                Console.WriteLine(timeSpan);
            }
        }

    }
}
