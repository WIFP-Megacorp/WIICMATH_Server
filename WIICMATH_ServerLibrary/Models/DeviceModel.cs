using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIICMATH_ServerLibrary.Models;

public class DeviceModel
{
	public int Id { get; set; }
	public string ArdMAC { get; set; }
	public int minTemp { get; set; } = 0;
	public int maxTemp { get; set; } = 10;
	public int minHum { get; set; } = 0;
	public int maxHum { get; set; } = 10;
	public bool sound { get; set; } = false;
	public bool light { get; set; } = true;

	public DeviceModel(string ArdMac)
	{
		ArdMAC = ArdMac;
	}
}
