using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IThreadsService
    {
        Task CreateThread(int threadId, string data);
        Task<IEnumerable<ThreadResponseModel>> GetAll();
        Task<ThreadResponseModel> SaveThread(ThreadRequestModel model);
        Task<IEnumerable<ThreadResponseModel>> GetNewestThreads();

    }
}
