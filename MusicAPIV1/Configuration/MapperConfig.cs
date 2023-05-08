using AutoMapper;
using MusicAPIV1.DTO;
using MusicAPIV1.Models;

namespace MusicAPIV1.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        { 
            CreateMap<Group,GroupDTO>().ReverseMap();
            CreateMap<Song, SongDTO>().ReverseMap();
            CreateMap<Song, CreateSongDTO>().ReverseMap();
            CreateMap<Genre, GenreDTO>().ReverseMap();
        }
    }
}
