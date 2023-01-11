using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookingLibrary.Dtos;
using BookingLibrary.Models;

namespace BeautyWebAPI.Profiles
{
    public class SizeProfile : Profile
    {
        public SizeProfile()
        {
            CreateMap<SizeLibrary, SizeLibraryReadDto>();

            CreateMap<SizeLibraryCreateDto, SizeLibrary>();

            CreateMap<SizeLibraryUpdateDto, SizeLibrary>();

            CreateMap<SizeLibrary, SizeLibraryUpdateDto>();
        }
    }
}
