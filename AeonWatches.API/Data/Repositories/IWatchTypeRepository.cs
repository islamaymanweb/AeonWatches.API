
using AeonWatches.API.Entities.WatchEntities;

namespace AeonWatches.API.Data.Repositories;

public interface IWatchTypeRepository
{
    Task<IEnumerable<WatchType>> GetWatchTypes();
    Task<bool> WatchTypeExists(int id);
    Task<bool> WatchTypeExists(string watchType);
}