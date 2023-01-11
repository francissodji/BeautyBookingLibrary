using BookingLibrary.DbAccess;
using BookingLibrary.Dtos;
using BookingLibrary.DTOs;
using BookingLibrary.Models;
using BookingLibrary.ModelsHelper;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Data
{
    public class BookingData : IBookingData
    {
        private readonly IBookingSqlDataAccess _dbConnect;


        public BookingData(IBookingSqlDataAccess dbConnect)
        {
            _dbConnect = dbConnect;
        }

        //***************************** appointment
        public Task<IEnumerable<AppointmentLibrary>> GetAllAppointments(string connectionStringName) =>
            _dbConnect.LaodData<AppointmentLibrary, dynamic>("dbo.spUsers_GetAllAppointments", new { });


        public async Task<AppointmentLibrary?> GetAppointmentById(string connectionStringName, int id)
        {
            var results = await _dbConnect.LaodData<AppointmentLibrary, dynamic>(
                            "dbo.spAppointments_GetAppointmentById",
                            new { IdUser = id },
                            connectionStringName);

            return results.FirstOrDefault();
        }


        public Task CreateNewAppointment(string connectionStringName, AppointmentLibrary appointment) =>
            _dbConnect.SaveData("dbo.spAppointments_CreateNewAppointment",
                                new
                                {
                                    appointment.IdStyleAppoint,
                                    appointment.IdSizeAppoint,
                                    appointment.IdLenghtAppoint
                                },
                                connectionStringName);


        public Task UpdateAppointment(string connectionStringName, AppointmentLibrary appointment) =>
            _dbConnect.SaveData("dbo.spAppointments_UpdateAppointment",
                                new
                                {
                                    appointment.IdAppoint
                                    /*,
                                    appointment.IdAppoint,
                                    appointment.IdAppoint,
                                    appointment.IdAppoint,
                                    appointment.IdAppoint,
                                    appointment.IdAppoint,
                                    appointment.IdAppoint,
                                    appointment.IdAppoint
                                    */
                                },
                               connectionStringName);


        public Task DeleteAppointment(string connectionStringName, int id) =>
            _dbConnect.SaveData("dbo.spAppointments_DeleteAppointment",
                               new { IdUser = id },
                               connectionStringName);

        //***************************************************************

        //************************ SIZE
        public Task<IEnumerable<SizeLibrary>> GetAllSizes(string connectionStringName) =>
           _dbConnect.LaodData<SizeLibrary, dynamic>("dbo.spSizes_GetAllSizes",
                                new { },
                                connectionStringName);

        public Task<IEnumerable<SizeLibrary>> GetAllSizesByIdCompany(string connectionStringName, int id) =>
            _dbConnect.LaodData<SizeLibrary, dynamic>("dbo.spSizes_GetAllSizesByIdCompany",
                                                        new
                                                        {
                                                            idCompany = id
                                                        },
                                                        connectionStringName);

        public Task<IEnumerable<SizeLibrary>> GetAllSizesByIdStyle(string connectionStringName, int idCompany, int idStyle) =>
            _dbConnect.LaodData<SizeLibrary, dynamic>("dbo.spCombine_GetAllSizesByIdStyle",
                                                        new
                                                        {
                                                            IdCompany = idCompany,
                                                            IdStyle = idStyle
                                                        },
                                                        connectionStringName);

        public async Task<SizeLibrary?> GetSizeById(string connectionStringName, int id)
        {

            var results = await _dbConnect.LaodData<SizeLibrary, dynamic>(
                                                                        "dbo.spSizes_GetSizeById",
                                                                        new { id },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task<SizeLibrary?> GetLatestAddedSize(string connectionStringName)
        {

            var results = await _dbConnect.LaodData<SizeLibrary, dynamic>(
                                                                        "dbo.spSizes_GetLatestAddedSize",
                                                                        new { },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }

        public Task CreateNewSize(string connectionStringName, SizeLibrary size) =>
            _dbConnect.SaveData("dbo.spSizes_CreateNewSize",
                                new
                                {
                                    size.TitleSize,
                                    size.IsDefault,
                                    size.IdCompany
                                },
                                connectionStringName);

        public Task DeleteSize(string connectionStringName, int id) =>
            _dbConnect.SaveData("dbo.spSizes_DeleteSize",
                               new
                               {
                                   idSize = id
                               },
                               connectionStringName);

        public Task UpdateSize(string connectionStringName, int idSize, SizeLibrary size) =>
            _dbConnect.SaveData("dbo.spSizes_UpdateSize",
                               new
                               {
                                   idSize,
                                   size.TitleSize,
                                   size.IsDefault,
                               },
                               connectionStringName);

        //********************************************************************************************
        //********************************************************************************************

        //************************ Length
        public Task<IEnumerable<LengthLibrary>> GetAllLengths(string connectionStringName) =>
           _dbConnect.LaodData<LengthLibrary, dynamic>("dbo.spLengths_GetAllLengths",
                                new { },
                                connectionStringName);

        public Task<IEnumerable<LengthLibrary>> GetAllLengthByIdStyleAndIdSize(string connectionStringName, int idCompany, int idStyle, int idSize) =>
            _dbConnect.LaodData<LengthLibrary, dynamic>("dbo.spCombine_GetAllLengthsByIdStyleAndIdSize",
                                                        new
                                                        {
                                                            IdCompany = idCompany,
                                                            IdStyle = idStyle,
                                                            IdSize = idSize
                                                            
                                                        },
                                                        connectionStringName);


        public async Task<LengthLibrary?> GetLengthById(string connectionStringName, int id)
        {

            var results = await _dbConnect.LaodData<LengthLibrary, dynamic>(
                                                                        "dbo.spLengths_GetLengthById",
                                                                        new { id },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }


        public async Task<LengthLibrary?> GetLatestAddedLength(string connectionStringName)
        {
            var results = await _dbConnect.LaodData<LengthLibrary, dynamic>(
                                                                        "dbo.spLengths_GetLatestAddedLength",
                                                                        new { },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }

        public Task CreateNewLength(string connectionStringName, LengthLibrary length) =>
            _dbConnect.SaveData("dbo.spLengths_CreateNewLength",
                                new
                                {
                                    length.TitleLength,
                                    length.IsDefault,
                                    length.IdCompany
                                },
                                connectionStringName);


        public Task DeleteLength(string connectionStringName, int id) =>
            _dbConnect.SaveData("dbo.spLengths_DeleteLength",
                               new
                               {
                                   IdLength = id
                               },
                               connectionStringName);

        public Task UpdateLength(string connectionStringName, int idLength, LengthLibrary length) =>
            _dbConnect.SaveData("dbo.spLengths_UpdateLength",
                               new
                               {
                                   idLength,
                                   length.TitleLength,
                                   length.IsDefault,
                               },
                               connectionStringName);

        //********************************************************************************************
        //********************************************************************************************


        //************************ Style
        public Task<IEnumerable<StyleLibrary>> GetAllStyleByIdCompany(string connectionStringName, int idCompany) =>
           _dbConnect.LaodData<StyleLibrary, dynamic>("dbo.spStyles_GetAllStylesByIdCompany",
                                new
                                {
                                    IdCompany = idCompany
                                },
                                connectionStringName);

        public async Task<StyleLibrary?> GetStyleById(string connectionStringName, int id)
        {

            var results = await _dbConnect.LaodData<StyleLibrary, dynamic>(
                                                                        "dbo.spStyles_GetStyleById",
                                                                        new { id },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task<StyleLibrary?> GetLatestAddedStyle(string connectionStringName)
        {

            var results = await _dbConnect.LaodData<StyleLibrary, dynamic>(
                                                                        "dbo.spStyles_GetLatestAddedStyle",
                                                                        new { },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task CreateNewStyle(string connectionStringName, StyleLibrary style) =>
            await _dbConnect.SaveData("dbo.spStyles_CreateNewStyle",
                                new
                                {
                                    style.TitleStyle,
                                    style.DescriptStyle,
                                    style.isHairProvided,
                                    style.PictureStyle,
                                    style.IdCompany
                                },
                                connectionStringName);

        public async Task DeleteStyle(string connectionStringName, int id) =>
            await _dbConnect.SaveData("dbo.spStyles_DeleteStyle",
                               new { IdStyle = id },
                               connectionStringName);

        public async Task UpdateStyle(string connectionStringName, int idStyle, StyleLibrary style) =>
            await _dbConnect.SaveData("dbo.spStyles_UpdateStyle",
                               new
                               {
                                   idStyle,
                                   style.TitleStyle,
                                   style.DescriptStyle,
                                   style.isHairProvided,
                                   style.PictureStyle,
                                   style.IdCompany
                               },
                               connectionStringName);

        //********************************************************************************************
        //********************************************************************************************

        //**********************Combine
        //Create
        public Task CreateNewCombine(string connectionStringName, CombineLibrary combine) =>
            _dbConnect.SaveData("dbo.spCombines_CreateNewCombine",
                                new
                                {
                                    combine.IdStyle,
                                    combine.IdSize,
                                    combine.IdLength,
                                    combine.CostStyle,
                                    combine.CostTakeDown,
                                    combine.CostTouchUp,
                                    combine.CostHairDeduct,
                                    combine.CostStyleBusyTime

                                },
                                connectionStringName);

        public async Task<CombineLibrary?> GetLatestAddedCombine(string connectionStringName)
        {

            var results = await _dbConnect.LaodData<CombineLibrary, dynamic>(
                                                                        "dbo.spCombines_GetLatestAddedCombine",
                                                                        new { },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }

        public async Task<CombineLibrary?> GetCombinePricesByIDs(string connectionStringName, int idCompany, int idStyle, int idSize = 0, int idLength = 0)
        {

            var results = await _dbConnect.LaodData<CombineLibrary, dynamic>(
                                                                        "dbo.spCombines_GetCombineByIdStyleIdSizeIdLength",
                                                                        new
                                                                        {
                                                                            idStyle,
                                                                            idSize,
                                                                            idLength,
                                                                            idCompany
                                                                        },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }


        


        //********************End Combine
        //********************************************************************************************************

        //*************************Catalog
        public async Task CreateNewCatalog(string connectionStringName, CatalogLibrary catalog)
        {
            await _dbConnect.SaveData("dbo.spCatalogs_CreateNewCatalog",
                                new
                                {
                                    catalog.ImageLink,
                                    catalog.IdCombine,
                                    catalog.IdCompany
                                },
                                connectionStringName);
        }


        public async Task DeleteCatalog(string connectionStringName, int id) =>
            await _dbConnect.SaveData("dbo.spCatalogs_DeleteCatalog",
                               new { IdCatalog = id },
                               connectionStringName);



        public Task<IEnumerable<CatalogLibrary>> GetAllCatalog(string connectionStringName) =>
           _dbConnect.LaodData<CatalogLibrary, dynamic>("dbo.spCatalogs_GetAllCatalogs",
                                new { },
                                connectionStringName);

        public Task<IEnumerable<CatalogCombine>> GetAllCatalogByAllParams(string connectionStringName, int idCompany, int idStyle, int idSize, int idLength) =>
           _dbConnect.LaodData<CatalogCombine, dynamic>("dbo.spCatalogs_GetAllCatalogs",
                                new 
                                {
                                    IdCompany = idCompany,
                                    IdStyle = idStyle,
                                    IdSize = idSize,
                                    IdLength = idLength
                                },
                                connectionStringName);


        public Task<IEnumerable<CatalogLibrary>> GetAllCatalogByIdCompany(string connectionStringName, int idCompany) =>
           _dbConnect.LaodData<CatalogLibrary, dynamic>("dbo.spCatalogs_GetAllCatalogs",
                                new
                                {
                                    IdCompany = idCompany
                                },
                                connectionStringName);


        public Task<IEnumerable<CatalogLibrary>> GetAllCatalogByIdCompanyAndStyle(string connectionStringName, int idCompany, int idStyle) =>
           _dbConnect.LaodData<CatalogLibrary, dynamic>("dbo.spCatalogs_GetAllCatalogs",
                                new
                                {
                                    IdCompany = idCompany,
                                    IdStyle = idStyle
                                },
                                connectionStringName);



        public async Task<CatalogLibrary?> GetLatestAddedCatalog(string connectionStringName)
        {

            var results = await _dbConnect.LaodData<CatalogLibrary, dynamic>(
                                                                        "dbo.spCatalogs_GetLatestAddedCatalog",
                                                                        new { },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }



        public async Task<CatalogLibrary?> GetCatalogById(string connectionStringName, int id)
        {

            var results = await _dbConnect.LaodData<CatalogLibrary, dynamic>(
                                                                        "dbo.spCatalogs_GetCatalogById",
                                                                        new { id },
                                                                        connectionStringName);

            return results.FirstOrDefault();
        }



        public async Task UpdateCatalog(string connectionStringName, int idCatalog, CatalogLibrary catalog) =>
            await _dbConnect.SaveData("dbo.spCatalogs_UpdateCatalog",
                               new
                               {
                                   idCatalog,
                                   catalog.ImageLink,
                                   catalog.IdCombine,
                                   catalog.IdCompany
                               },
                               connectionStringName);
        //*****************************************************************************************************


        //Get Specific braiding cos

    }
}

