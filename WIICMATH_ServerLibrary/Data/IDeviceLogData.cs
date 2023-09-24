using WIICMATH_ServerLibrary.Models;

namespace WIICMATH_ServerLibrary.Data;

public interface IDeviceLogData
{
	Task Delete(int id);
	Task<IEnumerable<DeviceLogModel>> GetByDevice(string ArdMac);
	Task<IEnumerable<DeviceLogModel>> GetDeviceLogs();
	Task Insert(DeviceLogModel log);
}