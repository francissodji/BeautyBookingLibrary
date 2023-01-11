using AutoMapper;
using BookingLibrary.DTOs;
using BookingLibrary.Models;
using BookingLibrary.ModelsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BeautyWebAPI.Profiles
{
    public class AppointmentProfile:Profile
    {
        public AppointmentProfile()
        {
            CreateMap<AppointmentLibrary, AppointmentLibraryReadDto>();

            //CreateMap<AppointWithLibel, AppointWithLibelReadDto>();

            //CreateMap<AppointWithLibelReadDto, AppointWithLibel>();

            //CreateMap<AppointmentReadDto, AppointWithLibelReadDto>();

            CreateMap<AppointmentLibraryCreateDto, AppointmentLibrary>();

            CreateMap<AppointmentLibraryUpdateDto, AppointmentLibrary>();

            CreateMap<AppointmentLibrary, AppointmentLibraryUpdateDto>();

        }
    }
}

