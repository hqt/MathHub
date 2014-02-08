-- Creating table 'Attendances'
CREATE TABLE [dbo].[Attendances] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateJoined] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [ConversationId] int  NOT NULL,
	   [DateSeen] datetime2  NULL
);
GO
-- Creating foreign key on [UserId] in table 'Attendances'
ALTER TABLE [dbo].[Attendances]
ADD CONSTRAINT [FK_UserAttendance]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [ConversationId] in table 'Attendances'
ALTER TABLE [dbo].[Attendances]
ADD CONSTRAINT [FK_ConversationAttendance]
    FOREIGN KEY ([ConversationId])
    REFERENCES [dbo].[Conversations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Attendances'
ALTER TABLE [dbo].[Attendances]
ADD CONSTRAINT [PK_Attendances]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserAttendance'
CREATE INDEX [IX_FK_UserAttendance]
ON [dbo].[Attendances]
    ([UserId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ConversationAttendance'
CREATE INDEX [IX_FK_ConversationAttendance]
ON [dbo].[Attendances]
    ([ConversationId]);