using Domain.Models;
using Persistence.Models;
using System;

namespace Domain.ServiceExtensions
{
    public static class ThreadsExtensions
    {
        private static Random _random; //check if it works properly! due to static class??????

        public static string RandomizeData (this string data)
        {
            data = data.Substring(0, new Random().Next(5, 11));

            return data;
        }

        public static ThreadResponseModel MapToResponseModel(this ThreadReadModel model)
        {
            return new ThreadResponseModel
            {
                ThreadId = model.ThreadId,
                Data = model.Data,
                TimeCreated = model.TimeCreated
            };
        }

        public static ThreadResponseModel MapToResponseModel(this ThreadRequestModel model)
        {
            return new ThreadResponseModel
            {
                ThreadId = model.ThreadId,
                Data = model.Data,
                TimeCreated = model.TimeCreated
            };
        }

        public static ThreadWriteModel MapToWriteModel(this ThreadRequestModel model)
        {
            return new ThreadWriteModel
            {
                ThreadId = model.ThreadId,
                Data = model.Data,
                TimeCreated = model.TimeCreated
            };
        }

    }
}
