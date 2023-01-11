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
    public class CatalogProfile:Profile
    {
        public CatalogProfile()
        {
            CreateMap<CatalogLibrary, CatalogLibraryReadDto>();

            CreateMap<CatalogLibraryCreateDto, CatalogLibrary>();

            CreateMap<CatalogLibraryUpdateDto, CatalogLibrary>();

            CreateMap<CatalogLibrary, CatalogLibraryUpdateDto>();
        }
        
    }
}
