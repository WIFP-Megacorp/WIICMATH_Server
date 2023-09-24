using WIICMATH_ServerLibrary.Models;

namespace WIICMATH_ServerLibrary.Data
{
	public interface IDeviceData
	{
		Task DeleteDevice(int id);
		Task<DeviceModel?> GetDevice(string ArdMac);
		Task<IEnumerable<DeviceModel>> GetDevices();
		Task InsertDevice(string ardmac);
		Task UpdateDevice(DeviceModel device);
	}
}