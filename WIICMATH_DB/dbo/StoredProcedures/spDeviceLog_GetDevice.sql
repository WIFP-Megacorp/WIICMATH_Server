CREATE PROCEDURE [dbo].[spDeviceLog_GetDevice]
	@DeviceId INT
AS
begin
	SELECT * FROM [dbo].[DeviceLog]
	WHERE [DeviceId] = @DeviceId
end