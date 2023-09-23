using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIICMATH_ServerLibrary.DbAccess;

namespace WIICMATH_ServerLibrary.Data;

public class DeviceLogData
{
	private readonly ISqlDataAccess _db;

	public DeviceLogData(ISqlDataAccess db)
	{
		_db = db;
	}
}
