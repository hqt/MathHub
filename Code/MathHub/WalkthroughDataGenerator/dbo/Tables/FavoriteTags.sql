-- Creating table 'FavoriteTags'
CREATE TABLE [dbo].[FavoriteTags] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [TagId] int  NOT NULL,
	   [UserId] int  NOT NULL
);
GO
-- Creating foreign key on [TagId] in table 'FavoriteTags'
ALTER TABLE [dbo].[FavoriteTags]
ADD CONSTRAINT [FK_FavoriteTagTag]
    FOREIGN KEY ([TagId])
    REFERENCES [dbo].[Tags]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [UserId] in table 'FavoriteTags'
ALTER TABLE [dbo].[FavoriteTags]
ADD CONSTRAINT [FK_FavoriteTagUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'FavoriteTags'
ALTER TABLE [dbo].[FavoriteTags]
ADD CONSTRAINT [PK_FavoriteTags]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_FavoriteTagTag'
CREATE INDEX [IX_FK_FavoriteTagTag]
ON [dbo].[FavoriteTags]
    ([TagId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_FavoriteTagUser'
CREATE INDEX [IX_FK_FavoriteTagUser]
ON [dbo].[FavoriteTags]
    ([UserId]);