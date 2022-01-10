using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ThreadConfiguration
    {
        private readonly Random _random;
        private readonly IThreadsService _threadsService;
        

        /*public async void ThreadGenerator()
        {
            var thread = new Thread(ExecuteInForeground);

            thread.Start();

            var delayMiliseconds = _random.Next(500, 2001); //1s=1000ms 

            Thread.Sleep(delayMiliseconds);

            var threadID = Thread.CurrentThread.ManagedThreadId;

            await _threadsService.CreateThread(threadID);
        }

        public static void ExecuteInForeground(Object obj)
        {
            int interval;
            try
            {
                interval = (int)obj;
            }
            catch (InvalidCastException)
            {
                interval = 5000;
            }
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Thread {0}: {1}, Priority {2}",
                              Thread.CurrentThread.ManagedThreadId,
                              Thread.CurrentThread.ThreadState,
                              Thread.CurrentThread.Priority);
            do
            {
                Console.WriteLine("Thread {0}: Elapsed {1:N2} seconds",
                                  Thread.CurrentThread.ManagedThreadId,
                                  sw.ElapsedMilliseconds / 1000.0);
                Thread.Sleep(500);
            } while (sw.ElapsedMilliseconds <= interval);
            sw.Stop();
        }*/

        /*private static void ShowThreadInformation(Object state)
        {
            lock (obj)
            {
                var th = Thread.CurrentThread;
                Console.WriteLine("Managed thread #{0}: ", th.ManagedThreadId);
                Console.WriteLine("   Background thread: {0}", th.IsBackground);
                Console.WriteLine("   Thread pool thread: {0}", th.IsThreadPoolThread);
                Console.WriteLine("   Priority: {0}", th.Priority);
                Console.WriteLine("   Culture: {0}", th.CurrentCulture.Name);
                Console.WriteLine("   UI culture: {0}", th.CurrentUICulture.Name);
                Console.WriteLine();
            }
        }*/
    }
}

