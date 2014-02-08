-- Creating table 'Posts'
CREATE TABLE [dbo].[Posts] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Content] nvarchar(max)  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [DateModified] datetime2  NOT NULL,
	   [UserId] int  NOT NULL
);
GO
-- Creating foreign key on [UserId] in table 'Posts'
ALTER TABLE [dbo].[Posts]
ADD CONSTRAINT [FK_PostUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Posts'
ALTER TABLE [dbo].[Posts]
ADD CONSTRAINT [PK_Posts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_PostUser'
CREATE INDEX [IX_FK_PostUser]
ON [dbo].[Posts]
    ([UserId]);