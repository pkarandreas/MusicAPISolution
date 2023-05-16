using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MusicAPIV2.Contracts;
using MusicAPIV2.Data;
using MusicAPIV2.Models;
using System.Xml.Linq;

namespace MusicAPIV2.Repositories
{
    public class SongRepository : GenericRepository<Song>, ISongRepository
    {
        public SongRepository(MusicDBcontext _ctx) : base(_ctx)
        {
        }

        public async Task<List<Song>?> DeleteSongAsync(int? id)
        {
            var entity = await this.GetByIDAsync(id);
            if (entity is null)
            {
                return null;
            }
            this.ctx.Set<Song>().Remove(entity);
            await this.ctx.SaveChangesAsync();
            return await this.GetSongsByGroupIDAsync(entity.GroupId);
        }


        public async Task<List<Song>?> GetSongsByGroupIDAsync(int id)
        {
            var results = await this.ctx.songs.Where(x => x.GroupId == id).ToListAsync();
            if (results == null)
                return null;
            return results;
        }

        public async Task<List<Song>?> UpdateSongAsync(Song _song)
        {
            this.ctx.Update(_song);
            await this.ctx.SaveChangesAsync();
            return await this.GetSongsByGroupIDAsync(_song.GroupId);
        }
    }
}
