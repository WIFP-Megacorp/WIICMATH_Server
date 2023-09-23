CREATE PROCEDURE [dbo].[spDeviceLog_GetAll]

AS
begin
	SELECT * FROM [dbo].[DeviceLog]
end