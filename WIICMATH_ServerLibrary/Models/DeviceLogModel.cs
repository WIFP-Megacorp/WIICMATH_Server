namespace WIICMATH_ServerLibrary.Models;

public class DeviceLogModel
{
	public int Id { get; set; }
	public int DeviceId { get; set; }
	public DateTime TimeStamp { get; set; }
	public int Temperature { get; set; }
	public int Humidity { get; set; }
}
