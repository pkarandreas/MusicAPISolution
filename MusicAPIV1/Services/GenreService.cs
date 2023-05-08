using Microsoft.EntityFrameworkCore;
using MusicAPIV1.Data;
using MusicAPIV1.Models;

namespace MusicAPIV1.Services
{
    public class GenreService : IGenreService
    {
        private readonly MusicDBcontext ctx;
        public GenreService(MusicDBcontext _ctx) 
        { 
            this.ctx = _ctx;
        }
        public async Task<List<Genre>?> AddGenre(Genre genre)
        {
            await this.ctx.genres.AddAsync(genre);
            await this.ctx.SaveChangesAsync();
            return await this.GetAllGenrs();
        }

        public async Task<List<Genre>?> DeleteGenre(int id)
        {
            var genre = await this.GetGenreByID(id);
            if (genre == null)
                return null;
            this.ctx.genres.Remove(genre);
            await this.ctx.SaveChangesAsync();
            return await this.GetAllGenrs();
        }

        public async Task<List<Genre>?> GetAllGenrs()
        {
            return await this.ctx.genres.ToListAsync();
        }

        public async Task<Genre?> GetGenreByID(int id)
        {
            var genre = await  this.ctx.genres.Where(g=> g.Id == id).FirstOrDefaultAsync();
            if (genre == null)
                return null;
            return genre;
        }

        public async Task<List<Genre>?> UpdateGenre(int id, Genre _genre)
        {
            var genre = await this.GetGenreByID(id);
            if (genre == null) 
                return null;
            genre.GenreName = _genre.GenreName;
            await this.ctx.SaveChangesAsync();
            return await this.GetAllGenrs();
        }
    }
}
