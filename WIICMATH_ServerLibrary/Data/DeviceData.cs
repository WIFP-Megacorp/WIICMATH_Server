using WIICMATH_ServerLibrary.DbAccess;
using WIICMATH_ServerLibrary.Models;

namespace WIICMATH_ServerLibrary.Data;

public class DeviceData : IDeviceData
{
	private readonly ISqlDataAccess _db;

	public DeviceData(ISqlDataAccess db)
	{
		_db = db;
	}

	public Task<IEnumerable<DeviceModel>> GetDevices() =>
		_db.LoadData<DeviceModel, dynamic>("dbo.spDevice_GetAll", new { });

	//custom get with param ArdMac
	//creates a new DeviceModel if it doesn't exist
	//if a new DeviceModel is created, it returns the new device with default values
	public async Task<DeviceModel?> GetDevice(string ArdMac)
	{
		var queryResult = (await _db.LoadData<DeviceModel, dynamic>(
			"dbo.spDevice_Get", new { ArdMAC = ArdMac })
			).FirstOrDefault();
		if (queryResult == null)
		{
			DeviceModel nDevice = new DeviceModel(ArdMac);
			await InsertDevice(nDevice);

			queryResult = (await _db.LoadData<DeviceModel, dynamic>(
			"dbo.spDevice_Get", new { ArdMAC = ArdMac })
			).FirstOrDefault();

		}
		return queryResult;
	}

	public Task UpdateDevice(DeviceModel device) => _db.SaveData("dbo.spDevice_Update", device);

	public Task DeleteDevice(int? id, string? ardmac) => _db.SaveData("dbo.spDevice_Delete", new { Id = id, ArdMAC = ardmac});

	public async Task InsertDevice(DeviceModel nDevice)
	{
		await _db.SaveData("dbo.spDevice_Insert", new { nDevice.ArdMAC, nDevice.name, nDevice.maxThresholdHum, nDevice.minThresholdHum, nDevice.minThresholdTemp, nDevice.maxThresholdTemp, nDevice.light, nDevice.sound });
	}
}
