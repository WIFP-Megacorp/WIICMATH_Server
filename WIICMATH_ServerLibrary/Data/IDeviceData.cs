using WIICMATH_ServerLibrary.Models;

namespace WIICMATH_ServerLibrary.Data;

public interface IDeviceData
{
	Task DeleteDevice(int id);
	Task<DeviceModel?> GetDevice(string ArdMac);
	Task<IEnumerable<DeviceModel>> GetDevices();
	Task InsertDevice(DeviceModel device);
	Task UpdateDevice(DeviceModel device);
}