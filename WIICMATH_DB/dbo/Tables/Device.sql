CREATE TABLE [dbo].[Device]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ArdMAC] NVARCHAR(50) NOT NULL UNIQUE,
    [name] NVARCHAR(10),
    [minThresholdTemp] INT NOT NULL DEFAULT 0, 
    [maxThresholdTemp] INT NOT NULL DEFAULT 10, 
    [minThresholdHum] INT NOT NULL DEFAULT 0, 
    [maxThresholdHum] INT NOT NULL DEFAULT 10, 
    [sound] TINYINT NOT NULL DEFAULT 1, 
    [light] TINYINT NOT NULL DEFAULT 1
)
