using BookingLibrary.Dtos;
using BookingLibrary.DTOs;
using BookingLibrary.Models;
using BookingLibrary.ModelsHelper;

namespace BookingLibrary.Data
{
    public interface IBookingData
    {
        //************************ APPOINTMENT
        Task CreateNewAppointment(string connectionStringName, AppointmentLibrary appointment);
        Task DeleteAppointment(string connectionStringName, int id);
        Task<IEnumerable<AppointmentLibrary>> GetAllAppointments(string connectionStringName);
        Task<AppointmentLibrary?> GetAppointmentById(string connectionStringName, int id);
        Task UpdateAppointment(string connectionStringName, AppointmentLibrary appointment);
        //***********************END APPOINTMENT

        
        //*********************** SIZE
        Task CreateNewSize(string connectionStringName, SizeLibrary size);
        Task DeleteSize(string connectionStringName, int id);
        Task<IEnumerable<SizeLibrary>> GetAllSizes(string connectionStringName);
        Task<IEnumerable<SizeLibrary>> GetAllSizesByIdStyle(string connectionStringName, int idCompany, int idStyle);
        Task<IEnumerable<SizeLibrary>> GetAllSizesByIdCompany(string connectionStringName, int idCompany);
        Task<SizeLibrary?> GetLatestAddedSize(string connectionStringName);
        Task<SizeLibrary?> GetSizeById(string connectionStringName, int id);
        Task UpdateSize(string connectionStringName, int id, SizeLibrary size);
        //*********************** END SIZE

        
        //*********************** LENGTH
        Task CreateNewLength(string connectionStringName, LengthLibrary length);
        Task DeleteLength(string connectionStringName, int id);
        Task<IEnumerable<LengthLibrary>> GetAllLengths(string connectionStringName);
        Task<IEnumerable<LengthLibrary>> GetAllLengthByIdStyleAndIdSize(string connectionStringName, int idCompany, int idStyle, int idSize);
        Task<LengthLibrary?> GetLatestAddedLength(string connectionStringName);
        Task<LengthLibrary?> GetLengthById(string connectionStringName, int id);
        Task UpdateLength(string connectionStringName, int id, LengthLibrary length);
        //*********************** END LENGTH


        //*********************** STYLE
        Task CreateNewStyle(string connectionStringName, StyleLibrary style);
        Task DeleteStyle(string connectionStringName, int id);
        Task<StyleLibrary?> GetLatestAddedStyle(string connectionStringName);
        Task<IEnumerable<StyleLibrary>> GetAllStyleByIdCompany(string connectionStringName, int idCompany);
        Task<StyleLibrary?> GetStyleById(string connectionStringName, int id);
        Task UpdateStyle(string connectionStringName, int id, StyleLibrary style);
        //*********************** END STYLE

        //****************Combine
        Task CreateNewCombine(string connectionStringName, CombineLibrary combine);

        Task<CombineLibrary?> GetLatestAddedCombine(string connectionStringName);
        Task<CombineLibrary?> GetCombinePricesByIDs(string connectionStringName, int idCompany, int idStyle, int idSize = 0, int idLength = 0);

        //Task<IEnumerable<CombineLibrary?>> GetCombineSizesByStyle(string connectionStringName, int idCompany, int idStyle);

        //

        //*****************************END COMBINE

        //**********************Catalog
        Task CreateNewCatalog(string connectionStringName, CatalogLibrary catalog);
        Task DeleteCatalog(string connectionStringName, int id);
        Task<IEnumerable<CatalogLibrary>> GetAllCatalog(string connectionStringName);
        Task<IEnumerable<CatalogLibrary>> GetAllCatalogByIdCompany(string connectionStringName, int idCompany);
        Task<IEnumerable<CatalogLibrary>> GetAllCatalogByIdCompanyAndStyle(string connectionStringName, int idCompany, int idStyle);
        Task<IEnumerable<CatalogCombine>> GetAllCatalogByAllParams(string connectionStringName, int idCompany, int idStyle, int idSize, int idLength);
        Task<CatalogLibrary?> GetLatestAddedCatalog(string connectionStringName);
        Task<CatalogLibrary?> GetCatalogById(string connectionStringName, int id);
        Task UpdateCatalog (string connectionStringName, int id, CatalogLibrary catalog);
        //*********************** END LENGTH
        //***********************************End Catalog
    }
}