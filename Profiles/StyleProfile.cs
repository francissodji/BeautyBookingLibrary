using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookingLibrary.Dtos;
using BookingLibrary.Models;

namespace BeautyWebAPI.Profiles
{
    public class StyleProfile : Profile
    {
        public StyleProfile()
        {
            CreateMap<StyleLibrary, StyleLibraryReadDto>();

            CreateMap<StyleLibraryCreateDto, StyleLibrary>();

            CreateMap<StyleLibraryUpdateDto, StyleLibrary>();

            CreateMap<StyleLibrary, StyleLibraryUpdateDto>();
        }
    }
}
