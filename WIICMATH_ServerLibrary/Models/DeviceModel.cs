namespace WIICMATH_ServerLibrary.Models;

public class DeviceModel
{
	public int Id { get; set; }
	public string ArdMAC { get; set; }
	public string? name { get; set; }
	public int minThresholdTemp { get; set; } = 0;
	public int maxThresholdTemp { get; set; } = 10;
	public int minThresholdHum { get; set; } = 0;
	public int maxThresholdHum { get; set; } = 10;
	public bool sound { get; set; } = false;
	public bool light { get; set; } = true;

	public DeviceModel(string ArdMac)
	{
		ArdMAC = ArdMac;
	}
}
