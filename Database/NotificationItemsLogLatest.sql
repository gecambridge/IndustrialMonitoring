﻿CREATE TABLE [dbo].[NotificationItemsLogLatest]
(
	[NotificationLogLatestId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NotificationId] INT NOT NULL, 
    [Value] BIT NOT NULL DEFAULT 0, 
    [Time] DATETIME2 NOT NULL, 
    [TimeStamp] TIMESTAMP NOT NULL, 
    CONSTRAINT [FK_NotificationItemsLogLatest_NotificationItems] FOREIGN KEY (NotificationId) REFERENCES NotificationItems(NotificationId)
)
