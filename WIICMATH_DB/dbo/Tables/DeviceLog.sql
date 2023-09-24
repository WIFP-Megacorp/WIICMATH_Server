CREATE TABLE [dbo].[DeviceLog]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[DeviceId] INT NOT NULL, 
	[Timestamp] DATETIME DEFAULT CURRENT_TIMESTAMP, 
	[Temperature] INT NOT NULL, 
	[Humidity] INT NOT NULL,  
	CONSTRAINT [FK_DeviceLog_Device_DeviceId] FOREIGN KEY ([DeviceId]) REFERENCES [dbo].[Device] ([Id]) ON DELETE CASCADE
)
