using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    interface IThreadsRepository
    {
        Task WriteThread(ThreadWriteModel model);

        // Task<List<ThreadReadModel>> GetNewestThreads(); // selects most recent 20 entries from sql - but this is considered business logic - should be implemented at domain level through getall()

        Task<IEnumerable<ThreadReadModel>> GetAll();
    }
}
