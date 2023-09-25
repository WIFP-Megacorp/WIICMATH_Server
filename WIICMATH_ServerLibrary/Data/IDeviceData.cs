using WIICMATH_ServerLibrary.Models;

namespace WIICMATH_ServerLibrary.Data;

public interface IDeviceData
{
	Task DeleteDevice(int? id, string? ardmac );
	Task<DeviceModel?> GetDevice(int? id, string? ArdMac);
	Task<IEnumerable<DeviceModel>> GetDevices();
	Task InsertDevice(DeviceModel device);
	Task UpdateDevice(DeviceModel device);
}