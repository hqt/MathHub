-- Creating table 'Topics'
CREATE TABLE [dbo].[Topics] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [Title] nvarchar(250)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [CreatorId] int  NOT NULL
);
GO
-- Creating foreign key on [CreatorId] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [FK_UserTopic]
    FOREIGN KEY ([CreatorId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [PK_Topics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserTopic'
CREATE INDEX [IX_FK_UserTopic]
ON [dbo].[Topics]
    ([CreatorId]);