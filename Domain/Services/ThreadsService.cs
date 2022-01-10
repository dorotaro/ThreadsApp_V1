using Domain.Models;
using Domain.ServiceExtensions;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ThreadsService : IThreadsService
    {
        private readonly ThreadsRepository _threadsRepository;
        
        
        private readonly Random _random;

        public ThreadsService(ThreadsRepository threadsRepository)
        {
            _threadsRepository = threadsRepository;
        }

        //ThreadsService service = new ThreadsService(new ThreadsRepository);


        public static async Task InitializeThreadCreation(int id, string data)
        {
            await _threadsService.CreateThread(id, data);
        }

        public async Task CreateThread(int threadId, string data)
        {         
            var threadModel = new ThreadRequestModel
            {
                ThreadId = threadId,  
                Data = data,
                TimeCreated = DateTime.Now
            };

            await SaveThread(threadModel);
        }

        public async Task<IEnumerable<ThreadResponseModel>> GetNewestThreads()
        {
           var threads = await GetAll();

            if (threads.Count() == 0)
            {
                throw new Exception("There id no data to show at this time.");
            }

            var newestThreads = threads.OrderByDescending(thread => thread.TimeCreated).Take(20);

           return newestThreads;
        }

        public async Task<IEnumerable<ThreadResponseModel>> GetAll()
        {
            var threads = await _threadsRepository.GetAll();

            if (threads.Count() == 0)
            {
                throw new Exception("There id no data to show at this time.");
            }

            List<ThreadResponseModel> list = new List<ThreadResponseModel>();

            IEnumerable<ThreadResponseModel> threadsConverted = list;

            for (var i = 0; i < threads.Count(); i++ )
            {
                var model = threads.ElementAt(i).MapToResponseModel();

                threadsConverted.Append(model);
            }

            return threadsConverted;
        }

        public async Task<ThreadResponseModel> SaveThread(ThreadRequestModel model)
        {
            var convertedModel = model.MapToWriteModel();

            if (model == null)
            {
                throw new Exception("Bad Request");
            }

            await _threadsRepository.WriteThread(convertedModel);

            return model.MapToResponseModel();

        }
    }
}
