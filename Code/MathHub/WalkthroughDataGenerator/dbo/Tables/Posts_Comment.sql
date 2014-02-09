-- Creating table 'Posts_Comment'
CREATE TABLE [dbo].[Posts_Comment] (
	   [ReplyId] int  NULL,
	   [MainPostId] int  NULL,
	   [Id] int  NOT NULL
);
GO
-- Creating foreign key on [ReplyId] in table 'Posts_Comment'
ALTER TABLE [dbo].[Posts_Comment]
ADD CONSTRAINT [FK_ReplyComment]
    FOREIGN KEY ([ReplyId])
    REFERENCES [dbo].[Posts_Reply]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [MainPostId] in table 'Posts_Comment'
ALTER TABLE [dbo].[Posts_Comment]
ADD CONSTRAINT [FK_MainPostComment]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [Id] in table 'Posts_Comment'
ALTER TABLE [dbo].[Posts_Comment]
ADD CONSTRAINT [FK_Comment_inherits_Post]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Posts_Comment'
ALTER TABLE [dbo].[Posts_Comment]
ADD CONSTRAINT [PK_Posts_Comment]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ReplyComment'
CREATE INDEX [IX_FK_ReplyComment]
ON [dbo].[Posts_Comment]
    ([ReplyId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostComment'
CREATE INDEX [IX_FK_MainPostComment]
ON [dbo].[Posts_Comment]
    ([MainPostId]);