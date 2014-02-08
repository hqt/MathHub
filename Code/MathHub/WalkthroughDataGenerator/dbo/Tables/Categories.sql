-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(250)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [CreatorId] int  NOT NULL,
	   [ParentCategoryId] int  NULL
);
GO
-- Creating foreign key on [CreatorId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_UserCategory]
    FOREIGN KEY ([CreatorId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [ParentCategoryId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_CategoryCategory]
    FOREIGN KEY ([ParentCategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserCategory'
CREATE INDEX [IX_FK_UserCategory]
ON [dbo].[Categories]
    ([CreatorId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryCategory'
CREATE INDEX [IX_FK_CategoryCategory]
ON [dbo].[Categories]
    ([ParentCategoryId]);