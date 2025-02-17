using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace stopWatchExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Design a class called Stopwatch.
            //The job of this class is to simulate a stopwatch. It should
            //provide two methods: Start and Stop.
            //We call the start method first, and the stop method next.
            //Then we ask the stopwatch about the duration between start and stop.
            //Duration should be a
            //value in TimeSpan.
            //Display the duration on the console.
            //We should also be able to use a stopwatch multiple times.
            //So we may start and stop it and then
            //start and stop it again.
            //Make sure the duration value each time is calculated properly.
            //We should not be able to start a stopwatch twice in a row
            //(because that may overwrite the initial
            //start time). So the class should throw an InvalidOperationException
            //if its started twice.

            StopWatch stopWatch = new StopWatch();

            stopWatch.Start();

            Thread.Sleep(1100);

            stopWatch.Stop();

            Console.WriteLine(stopWatch.Duration);


        }
    }
    
    
    
    public class StopWatch
    {

        private DateTime? startTime;
        private DateTime? endTime;
        private bool Running;

        public TimeSpan Duration { get; private set; }
  

        public void Start()
        {
            if (!Running)
            {
                startTime = DateTime.Now;
                Running = true;
            }
            else
            {
                Console.WriteLine("Cannot start. Stopwatch is already running");
            }
        }
        public void Stop() 
        {
            if (Running)
            {
                endTime = DateTime.Now;
                UpdateDuration();
                Running = false;
            }
            else
            {
                Console.WriteLine("Cannot stop stopwatch. It is not running");
            }

        }
        public void Clear()
        {
            startTime = null;
            endTime = null;
            Duration = TimeSpan.Zero;
            Running = false;
        }

        private void UpdateDuration()
        {
            var newDuration = (endTime - startTime).Value;
            Duration = Duration.Add(newDuration);
        }
    }
}
