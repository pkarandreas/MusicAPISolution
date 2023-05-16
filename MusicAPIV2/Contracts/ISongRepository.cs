using MusicAPIV2.Models;

namespace MusicAPIV2.Contracts
{
    public interface ISongRepository : IGenericRepository<Song>
    {
        Task<List<Song>?> GetSongsByGroupIDAsync(int id);
        Task<List<Song>?> DeleteSongAsync(int? id);
        Task<List<Song>?> UpdateSongAsync(Song _song);
    }
}
