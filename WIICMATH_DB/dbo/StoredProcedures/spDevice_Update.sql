CREATE PROCEDURE [dbo].[spDevice_Update]
	@Id int,
	@ArdMAC nvarchar(50),
	@name nvarchar(50),
	@minThresholdTemp int,
	@maxThresholdTemp int,
	@minThresholdHum int,
	@maxThresholdHum int,
	@sound tinyint,
	@light tinyint
AS
begin
	update dbo.Device
	set ArdMAC = @ArdMAC, [name]= @name , minThresholdTemp = @minThresholdTemp, maxThresholdTemp = @maxThresholdTemp, minThresholdHum = @minThresholdHum, maxThresholdHum = @maxThresholdHum, sound = @sound, light = @light
	where Id = @Id;
end

