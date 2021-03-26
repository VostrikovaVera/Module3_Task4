using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Task4
{
    public class EventsTask
    {
        public event Func<int, int, int> SumHandler;

        public int RunSum()
        {
            SumHandler += Sum;
            SumHandler += Sum;

            var eventsResult = 0;

            TryCatchWrapper(() =>
            {
                var listOfEvents = SumHandler.GetInvocationList();

                foreach (var item in listOfEvents)
                {
                    var result = item.DynamicInvoke(2, 3);
                    eventsResult += (int)result;
                }
            });

            return eventsResult;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public void TryCatchWrapper(Action handler)
        {
            try
            {
                handler();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
