-- Creating table 'FollowPosts'
CREATE TABLE [dbo].[FollowPosts] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [PostId] int  NOT NULL,
	   [DateSeen] datetime2  NOT NULL
);
GO
-- Creating foreign key on [UserId] in table 'FollowPosts'
ALTER TABLE [dbo].[FollowPosts]
ADD CONSTRAINT [FK_UserFollow]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [PostId] in table 'FollowPosts'
ALTER TABLE [dbo].[FollowPosts]
ADD CONSTRAINT [FK_PostFollow]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'FollowPosts'
ALTER TABLE [dbo].[FollowPosts]
ADD CONSTRAINT [PK_FollowPosts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserFollow'
CREATE INDEX [IX_FK_UserFollow]
ON [dbo].[FollowPosts]
    ([UserId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_PostFollow'
CREATE INDEX [IX_FK_PostFollow]
ON [dbo].[FollowPosts]
    ([PostId]);