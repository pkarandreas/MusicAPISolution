using MusicAPIV1.Models;

namespace MusicAPIV2.Services
{
    public interface IGenreService
    {
        Task<List<Genre>?> GetAllGenrs();
        Task<Genre?> GetGenreByID(int id);
        Task<List<Genre>?> AddGenre(Genre _genre);
        Task<List<Genre>?> UpdateGenre(int id, Genre _genre);
        Task<List<Genre>?> DeleteGenre(int id);
    }
}
