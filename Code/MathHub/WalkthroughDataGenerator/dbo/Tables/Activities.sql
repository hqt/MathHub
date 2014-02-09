-- Creating table 'Activities'
CREATE TABLE [dbo].[Activities] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [LastSeenInvition] datetime2  NOT NULL,
	   [LastSeenSubcription] datetime2  NOT NULL,
	   [LastSeenReceivedMedal] datetime2  NOT NULL,
	   [LastPermissionGain] datetime2  NOT NULL,
	   [LastSeenPermissionGain] datetime2  NOT NULL,
	   [NewPasswordKey] nvarchar(max)  NOT NULL,
	   [NewPasswordRequestedDate] datetime2  NOT NULL,
	   [NewEmail] nvarchar(max)  NOT NULL,
	   [NewEmailKey] nvarchar(max)  NOT NULL,
	   [LastLogin] nvarchar(max)  NOT NULL,
	   [LastIp] nvarchar(max)  NOT NULL,
	   [User_Id] int  NOT NULL
);
GO
-- Creating foreign key on [User_Id] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [FK_ActivityUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [PK_Activities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ActivityUser'
CREATE INDEX [IX_FK_ActivityUser]
ON [dbo].[Activities]
    ([User_Id]);