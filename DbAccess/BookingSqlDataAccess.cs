using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BookingLibrary.DbAccess
{
    public class BookingSqlDataAccess : IBookingSqlDataAccess
    {

        private readonly IConfiguration _config;

        public BookingSqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LaodData<T, U>(
                                     string storedProcedure,
                                     U parameters,
                                     string connectionStringName = "Default")
        {

            //using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionStringName));
            using IDbConnection connection = new SqlConnection(connectionStringName);
            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }



        public async Task SaveData<T>(
                                     string storedProcedure,
                                     T parameters,
                                     string connectionStringName = "Default")
        {

            //using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionStringName));
            using IDbConnection connection = new SqlConnection(connectionStringName);
            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
