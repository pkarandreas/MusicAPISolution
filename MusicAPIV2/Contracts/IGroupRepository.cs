using MusicAPIV2.Models;

namespace MusicAPIV2.Contracts
{
    public interface IGroupRepository : IGenericRepository<Group>
    {
        Task<List<Group>?> GetGroupsByGenre(int? genreId);
        Task<Group?> GetGroupByIdWithSongs(int? groupID);
    }
}
