namespace APIclassLib
{
	public class WIICMATHdevice
	{
		//A static field holdin an array with the default setting for WIICMATHdevice
		//Field name DefaultSettings
		//Array of type, Key = string, Value = mixed
		//The Settings are:
		// minTemp = 0;
		// maxTemp = 10;
		// minHumidity = 0;
		// maxHumidity = 100;
		public static Dictionary<string, dynamic> DefaultSettings = new Dictionary<string, dynamic>()
		{
			{"minTemp", 0},
			{"maxTemp", 10},
			{"minHumidity", 0},
			{"maxHumidity", 100},
			{"sound", true },
			{"light",true }

		};

	}
}