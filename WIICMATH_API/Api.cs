namespace WIICMATH_API;

public static class Api
{
	public static void ConfigureAPI(this WebApplication app)
	{
		//All of my Api endpoint mapping
		//Device endpoints
		app.MapGet("/api/devices", GetDevices); //Get all devices
		app.MapGet("/api/devices/{ArdMac}/{id}", GetDevice); //Get a device by its ArdMac
		app.MapPost("/api/insertDevice", InsertDevice);
		app.MapPost("/api/deleteDevice", DeleteDevice);
		//DeviceLog endpoints
		app.MapGet("/api/deviceLogs", GetDeviceLogs); //Get all device logs
		app.MapGet("/api/deviceLogs/{ArdMac}", GetLogsByDevice); //Get all device logs by device ArdMac
		app.MapPost("/api/insertDeviceLog", InsertDeviceLog);
		app.MapPost("/api/deleteDeviceLog", DeleteDeviceLog);
	}

	//IDeviceData endpoints methodes
	//getAll
	private static async Task<IResult> GetDevices(IDeviceData data)
	{
		try
		{
			return Results.Ok(await data.GetDevices());
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
	//get with string parameter
	private static async Task<IResult> GetDevice(IDeviceData data,int? id, string? ArdMac)
	{
		try
		{
			return Results.Ok(await data.GetDevice(id, ArdMac));
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
	//Insert
	private static async Task<IResult> InsertDevice(DeviceModel device, IDeviceData data)
	{
		try
		{
			await data.InsertDevice(device);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
	//Delete
	private static async Task<IResult> DeleteDevice(int? id, string? ArdMac, IDeviceData data)
	{
		try
		{
			await data.DeleteDevice(id, ArdMac);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
	//Update
	private static async Task<IResult> UpdateDevice(DeviceModel device, IDeviceData data)
	{
		try
		{
			await data.UpdateDevice(device);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	//IDeviceLogData endpoints methodes
	//getAll
	private static async Task<IResult> GetDeviceLogs(IDeviceLogData data)
	{
		try
		{
			return Results.Ok(await data.GetDeviceLogs());
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
	//get device spesific logs
	private static async Task<IResult> GetLogsByDevice(IDeviceLogData data, string ArdMac)
	{
		try
		{
			return Results.Ok(await data.GetByDevice(ArdMac));
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
	//Insert
	private static async Task<IResult> InsertDeviceLog(DeviceLogModel log, IDeviceLogData data)
	{
		try
		{
			await data.Insert(log);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
	//Delete
	private static async Task<IResult> DeleteDeviceLog(int id, IDeviceLogData data)
	{
		try
		{
			await data.Delete(id);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
}