CREATE PROCEDURE [dbo].[spDevice_Get]
	@Id INT,
	@ArdMAC NVARCHAR(50)
AS
begin
	select Id , ArdMAC ,[name] , minThresholdTemp , maxThresholdTemp , minThresholdHum , maxThresholdHum , sound , light
	from dbo.Device
	where Id = @Id or ArdMAC = @ArdMAC;
end

