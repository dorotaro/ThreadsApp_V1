using Persistence.Clients;
using Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ThreadsRepository : IThreadsRepository
    {

        private readonly ISqlClient _sqlClient;
        private readonly string tableName = "threads_repository";

        public ThreadsRepository(ISqlClient sqlClient)
        {
            _sqlClient = sqlClient;
        }

        public async Task<IEnumerable<ThreadReadModel>> GetAll()
        {
            var query = $"SELECT * FROM {tableName}";

            var threads = await _sqlClient.Query<ThreadReadModel>(query);

            return threads;
        }

        public async Task WriteThread(ThreadWriteModel model)
        {
            var query = $"INSERT INTO {tableName} " +
                       $"(Threadid, Data, TimeCreated)" +
                       $"VALUES (@Threadid, @Data, @TimeCreated); ";

            var param = new ThreadWriteModel
            {
                ThreadId = model.ThreadId,
                Data = model.Data,
                TimeCreated = model.TimeCreated
            };

            await _sqlClient.Execute<ThreadWriteModel>(query, param);
        }
    }
}
