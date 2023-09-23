CREATE PROCEDURE [dbo].[spDevice_Update]
	@Id int,
	@ArdMAC nvarchar(50),
	@minTemp int,
	@maxTemp int,
	@minHum int,
	@maxHum int,
	@sound tinyint,
	@light tinyint
AS
begin
	update dbo.Device
	set ArdMAC = @ArdMAC, minTemp = @minTemp, maxTemp = @maxTemp, minHum = @minHum, maxHum = @maxHum, sound = @sound, light = @light
	where Id = @Id;
end

