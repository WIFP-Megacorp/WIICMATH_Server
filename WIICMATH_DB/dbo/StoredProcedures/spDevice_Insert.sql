CREATE PROCEDURE [dbo].[spDevice_Insert]
	@ArdMAC NVARCHAR(50),
	@name NVARCHAR(50),
	@minThresholdTemp INT,
	@maxThresholdTemp INT,
	@minThresholdHum INT,
	@maxThresholdHum INT,
	@sound TINYINT,
	@light TINYINT
AS
begin
	insert into dbo.Device (ArdMAC,[name], minThresholdTemp, maxThresholdTemp, minThresholdHum, maxThresholdHum, sound, light)
	values (@ArdMAC, @name , @minThresholdTemp, @maxThresholdTemp, @minThresholdHum, @maxThresholdHum, @sound, @light);
end