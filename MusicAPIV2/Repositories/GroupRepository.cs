using Microsoft.EntityFrameworkCore;
using MusicAPIV2.Contracts;
using MusicAPIV2.Data;
using MusicAPIV2.Models;

namespace MusicAPIV2.Repositories
{
    public class GroupRepository : GenericRepository<Group> ,IGroupRepository
    {
        public GroupRepository(MusicDBcontext _ctx) : base(_ctx)
        {
        }

        public async Task<List<Group>?> GetGroupsByGenre(int? genreId)
        {
            var group = await this.ctx.Set<Group>().Where(i=>i.GroupGenreID ==genreId).ToListAsync();
            if (group == null )
            {
                return null;
            }
            return group;
        }

        public async Task<Group?> GetGroupByIdWithSongs(int? groupID)
        {
            var group = await this.ctx.Set<Group>().Include(s => s.Songs).Where(i => i.Id==groupID).FirstOrDefaultAsync();
            if (group == null )
            {
                return null;
            }
            return group;
        }
    }
}
