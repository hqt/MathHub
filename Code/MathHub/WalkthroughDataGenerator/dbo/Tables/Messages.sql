-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Content] nvarchar(3000)  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [AttendanceId] int  NOT NULL
);
GO
-- Creating foreign key on [AttendanceId] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_AttendanceMessage]
    FOREIGN KEY ([AttendanceId])
    REFERENCES [dbo].[Attendances]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [PK_Messages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_AttendanceMessage'
CREATE INDEX [IX_FK_AttendanceMessage]
ON [dbo].[Messages]
    ([AttendanceId]);