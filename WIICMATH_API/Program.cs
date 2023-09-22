using APIclassLib;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

//Get the default settings for the device from the APIclassLib
app.MapGet(pattern: "Api/Device/Settings", () => { return WIICMATHdevice.DefaultSettings; });

//gets the device settings for the device with the given id
//not implemented yet
//app.MapGet(pattern: "Api/Device/Settings/{id}", (object id) => { return "Not implemented yet"; });

//endpoint for device to post data readings
app.MapPost(pattern: "Api/Device/Readings", (WIICMATHdevice device) => { return device; });




//example
//app.MapGet("/weatherforecast", () =>
//{

//})
//.WithName("GetWeatherForecast");

app.Run();