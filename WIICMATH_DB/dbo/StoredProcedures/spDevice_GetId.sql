CREATE PROCEDURE [dbo].[spDevice_GetId]
	@ArdMAC NVARCHAR(50)
AS
begin
	SELECT Id 
	from dbo.Device
	where ArdMAC = @ArdMAC;
end