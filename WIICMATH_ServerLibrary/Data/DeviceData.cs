using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIICMATH_ServerLibrary.DbAccess;

namespace WIICMATH_ServerLibrary.Data;

public class DeviceData
{
	private readonly ISqlDataAccess _db;

    public DeviceData(ISqlDataAccess db)
    {
		_db = db;
	}
}
