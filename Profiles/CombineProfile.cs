using AutoMapper;
using BookingLibrary.Dtos;
using BookingLibrary.Models;

namespace BeautyWebAPI.Profiles
{
    public class CombineProfile : Profile
    {
        public CombineProfile()
        {
            CreateMap<CombineLibrary, CombineLibraryReadDto>();

            CreateMap<CombineLibraryCreateDto, CombineLibrary>();

            CreateMap<CombineLibraryUpdateDto, CombineLibrary>();

            CreateMap<CombineLibrary, CombineLibraryUpdateDto>();
        }
    }
}
