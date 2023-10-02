using WIICMATH_API;
using WIICMATH_ServerLibrary.DbAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//get parts of connection string from Evnironment variable if it exists
//check if the environment variable exists
if (Environment.GetEnvironmentVariable("DB_HOST") != null && Environment.GetEnvironmentVariable("DB_NAME") != null && Environment.GetEnvironmentVariable("DB_PASS") !=null) { 
	var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
	var dbName = Environment.GetEnvironmentVariable("DB_NAME");
	var dbPass = Environment.GetEnvironmentVariable("DB_PASS");
	//creating the string
	var connectionString = $"Data Source={dbHost};Initial Catalog={dbName};User Id=sa;Password={dbPass};";
	//builds the service with the connection string
	builder.Services.AddSingleton<ISqlDataAccess>(new SqlDataAccess(connectionString, builder.Configuration));
	
} else { builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>(); }

builder.Services.AddSingleton<IDeviceData, DeviceData>();
builder.Services.AddSingleton<IDeviceLogData, DeviceLogData>();

var app = builder.Build();

//cofigure the HTTO request pipeline
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.ConfigureAPI();

app.Run();