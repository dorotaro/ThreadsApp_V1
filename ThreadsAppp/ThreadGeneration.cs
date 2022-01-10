using Domain.ServiceExtensions;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsAppp
{
    public class ThreadGeneration
    {

        private static IThreadsService _threadsService;

        public ThreadGeneration(IThreadsService threadsService)
        {
            _threadsService = threadsService;
        }

        public static void ThreadGenerator()
        {
            var thread = new Thread(ExecuteInForeground);

            thread.Start();
        }

        public static async void ExecuteInForeground()
        {
            int interval = new Random().Next(500, 2001); //1s=1000ms

            try
            {
                interval = 0;
            }
            catch (Exception)
            {
                interval = 2000; //default interval is 2s
            }

            var sw = Stopwatch.StartNew();

            for (int i = 0; i <= interval; i++)
            {
                var threadID = Thread.CurrentThread.ManagedThreadId;

                var data = Guid.NewGuid().ToString().RandomizeData();

                //await _threadsService.CreateThread(threadID, data);
                await InitializeThreadCreation(threadID, data);

                interval = new Random().Next(500, 2001);
            }

            sw.Stop();
        }
    }
}
