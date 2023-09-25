using WIICMATH_ServerLibrary.DbAccess;
using WIICMATH_ServerLibrary.Models;

namespace WIICMATH_ServerLibrary.Data;

public class DeviceLogData : IDeviceLogData
{
	private readonly ISqlDataAccess _db;

	public DeviceLogData(ISqlDataAccess db)
	{
		_db = db;
	}

	public Task<IEnumerable<DeviceLogModel>> GetDeviceLogs() => _db.LoadData<DeviceLogModel, dynamic>("dbo.spDeviceLog_GetAll", new { });

	//private get methode to get deviceID from ArdMac
	private async Task<int> getDeviceId(int? id, string ardmac)
	{
		var result = (await _db.LoadData<DeviceModel, dynamic>("dbo.spDevice_Get", new {Id = id, ArdMAC = ardmac })).FirstOrDefault();
		if (result == null) return -1;
		return result.Id;
	}

	//custom get with param ArdMac
	public Task<IEnumerable<DeviceLogModel>> GetByDevice(string ArdMac)
	{
		int id = getDeviceId(null, ArdMac).Result;
		var query = _db.LoadData<DeviceLogModel, dynamic>("dbo.spDeviceLog_GetDevice", new { DeviceId = id});
		return query;
	}
	public Task Insert(DeviceLogModel log) => _db.SaveData("dbo.spDeviceLog_Insert", new { log.DeviceId, log.Temperature, log.Humidity});

	public Task Delete(int id) => _db.SaveData("dbo.spDeviceLog_Delete", new { Id = id });
}
