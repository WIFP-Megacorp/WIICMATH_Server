CREATE PROCEDURE [dbo].[spDevice_GetAll]
AS
begin
	select * 
	from dbo.Device;
end
