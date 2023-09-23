CREATE PROCEDURE [dbo].[spDevice_Delete]
	@Id INT,
	@ArdMAC NVARCHAR(50)
AS
begin
	delete
	from dbo.Device
	where Id = @Id or ArdMAC = @ArdMAC;
end
