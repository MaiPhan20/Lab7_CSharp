using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet12._6
{
    
        public delegate void PrintDetails();

        class TestEvent
        {
            event PrintDetails Print;
            void Show()
            {
                Console.WriteLine("This program illustrate how to subscribe objects to an event");
            Console.WriteLine("This method will not execute since the event has not been raised");
        }
        static void Main(string[] args)
        {
            TestEvent objTestEvent = new TestEvent();
            objTestEvent.Print += new PrintDetails(objEvents.Show);
        }
    
}
}
