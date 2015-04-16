using System;
using System.Configuration;
using System.Threading;

namespace ServiceLooper
{
    public class Looper
    {
        private Thread thread;
        private int startAt;
        private int sleepFor;
        private bool alive = true;

        public void start()
        {
            startAt = int.Parse(ConfigurationManager.AppSettings["startingValue"]);
            sleepFor = int.Parse(ConfigurationManager.AppSettings["sleepFor"]);
            thread = new Thread(run);
            thread.Start();
        }

        public void stop()
        {
            alive = false;
        }


        private void run()
        {
            while (alive)
            {
                Console.WriteLine(startAt++);
                Thread.Sleep(sleepFor);
            }
        } 
    }
}