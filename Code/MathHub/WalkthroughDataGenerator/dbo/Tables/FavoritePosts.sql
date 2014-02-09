-- Creating table 'FavoritePosts'
CREATE TABLE [dbo].[FavoritePosts] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [UserId] int  NOT NULL,
	   [MainPostId] int  NOT NULL
);
GO
-- Creating foreign key on [UserId] in table 'FavoritePosts'
ALTER TABLE [dbo].[FavoritePosts]
ADD CONSTRAINT [FK_UserFavoritePost]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [MainPostId] in table 'FavoritePosts'
ALTER TABLE [dbo].[FavoritePosts]
ADD CONSTRAINT [FK_MainPostFavoritePost]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'FavoritePosts'
ALTER TABLE [dbo].[FavoritePosts]
ADD CONSTRAINT [PK_FavoritePosts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserFavoritePost'
CREATE INDEX [IX_FK_UserFavoritePost]
ON [dbo].[FavoritePosts]
    ([UserId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostFavoritePost'
CREATE INDEX [IX_FK_MainPostFavoritePost]
ON [dbo].[FavoritePosts]
    ([MainPostId]);