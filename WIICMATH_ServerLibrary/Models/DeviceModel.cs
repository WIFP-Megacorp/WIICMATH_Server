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
	public int minTemp { get; set; }
	public int maxTemp { get; set; }
	public int minHum { get; set; }
	public int maxHum { get; set; }
	public bool sound { get; set; }
	public bool light { get; set; }
}
