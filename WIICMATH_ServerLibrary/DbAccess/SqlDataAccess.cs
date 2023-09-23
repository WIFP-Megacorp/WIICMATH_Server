using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WIICMATH_ServerLibrary.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
	private readonly IConfiguration _config;

	public SqlDataAccess(IConfiguration config)
	{
		_config = config;
	}
	//Get
	public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default")
	{
		using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

		return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
	}

	//insert, update, delete
	public async Task SaveData<T>(string storedProcedure, T parameter, string connectionId = "Default")
	{
		using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

		await connection.ExecuteAsync(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
	}

}
