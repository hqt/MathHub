-- Creating table 'Tags'
CREATE TABLE [dbo].[Tags] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(250)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [CreatorId] int  NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [DateModified] datetime2  NOT NULL,
	   [Image_Id] int  NULL
);
GO
-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CreatorId] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [FK_TagUser]
    FOREIGN KEY ([CreatorId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [Image_Id] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [FK_ImageTag]
    FOREIGN KEY ([Image_Id])
    REFERENCES [dbo].[Images]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [PK_Tags]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_TagUser'
CREATE INDEX [IX_FK_TagUser]
ON [dbo].[Tags]
    ([CreatorId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ImageTag'
CREATE INDEX [IX_FK_ImageTag]
ON [dbo].[Tags]
    ([Image_Id]);