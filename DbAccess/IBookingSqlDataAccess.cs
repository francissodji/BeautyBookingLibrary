namespace BookingLibrary.DbAccess
{
    public interface IBookingSqlDataAccess
    {
        Task<IEnumerable<T>> LaodData<T, U>(string storedProcedure, U parameters, string connectionStringName = "Default");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionStringName = "Default");
    }
}