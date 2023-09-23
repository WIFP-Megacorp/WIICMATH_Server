CREATE PROCEDURE [dbo].[spDevice_Insert]
	@ArdMAC NVARCHAR(50),
	@minTemp INT,
	@maxTemp INT,
	@minHum INT,
	@maxHum INT,
	@sound TINYINT,
	@light TINYINT
AS
begin
	insert into dbo.Device (ArdMAC, minTemp, maxTemp, minHum, maxHum, sound, light)
	values (@ArdMAC, @minTemp, @maxTemp, @minHum, @maxHum, @sound, @light);
end