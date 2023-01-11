using AutoMapper;
using BookingLibrary.Dtos;
using BookingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Profiles
{
    public class LengthProfile : Profile
    {
        public LengthProfile()
        {
            CreateMap<LengthLibrary, LengthLibraryReadDto>();

            CreateMap<LengthLibraryCreateDto, LengthLibrary>();

            CreateMap<LengthLibraryUpdateDto, LengthLibrary>();

            CreateMap<LengthLibrary, LengthLibraryUpdateDto>();

            CreateMap<IEnumerable<LengthLibrary>, IEnumerable<LengthLibraryReadDto>>();

            CreateMap<IEnumerable<LengthLibraryReadDto>, IEnumerable<LengthLibrary>>();
        }
    }
}
