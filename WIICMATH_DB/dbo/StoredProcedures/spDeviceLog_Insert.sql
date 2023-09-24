CREATE PROCEDURE [dbo].[spDeviceLog_Insert]
	@DeviceId INT,
	@Temperature INT,
	@Humidity INT
AS
begin
	INSERT INTO [dbo].[DeviceLog] ([DeviceId], [Temperature], [Humidity])
	VALUES (@DeviceId, @Temperature, @Humidity)
end
