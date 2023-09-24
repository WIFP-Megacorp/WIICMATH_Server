using WIICMATH_API;
using WIICMATH_ServerLibrary.DbAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IDeviceData, DeviceData>();
builder.Services.AddSingleton<IDeviceLogData, DeviceLogData>();

var app = builder.Build();

//cofigure the HTTO request pipeline
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.ConfigureAPI();

app.Run();