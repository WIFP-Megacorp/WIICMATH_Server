CREATE PROCEDURE [dbo].[spDeviceLog_Delete]
	@Id INT
AS
begin
	DELETE FROM [dbo].[DeviceLog]
	WHERE [Id] = @Id
end