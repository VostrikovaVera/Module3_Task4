using System;

namespace Module3_Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var eventsTask = new EventsTask();
            var sumResult = eventsTask.RunSum();

            Console.WriteLine(sumResult);

            var linqTask = new LINQTask();
            linqTask.Run();
        }
    }
}
