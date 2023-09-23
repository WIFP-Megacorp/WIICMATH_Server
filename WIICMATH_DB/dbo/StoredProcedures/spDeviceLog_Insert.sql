CREATE PROCEDURE [dbo].[spDeviceLog_Insert]
	@DeviceId INT,
	@Timestamp DATETIME,
	@Temperature INT,
	@Humidity INT
AS
begin
	INSERT INTO [dbo].[DeviceLog] ([DeviceId], [Timestamp], [Temperature], [Humidity])
	VALUES (@DeviceId, @Timestamp, @Temperature, @Humidity)
end
