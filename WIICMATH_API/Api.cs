namespace WIICMATH_API;

public static class Api
{
	public static void ConfigureAPI(this WebApplication app)
	{
		//All of my Api endpoint mapping
		app.MapGet("/api/devices", GetDevices); //Get all devices
	}
	
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
}
