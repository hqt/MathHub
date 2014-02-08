-- Creating table 'Posts_Reply'
CREATE TABLE [dbo].[Posts_Reply] (
	   [Type] int  NOT NULL,
	   [MainPostId] int  NULL,
	   [TopicId] int  NULL,
	   [Id] int  NOT NULL
);
GO
-- Creating foreign key on [MainPostId] in table 'Posts_Reply'
ALTER TABLE [dbo].[Posts_Reply]
ADD CONSTRAINT [FK_MainPostReply]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [TopicId] in table 'Posts_Reply'
ALTER TABLE [dbo].[Posts_Reply]
ADD CONSTRAINT [FK_TopicReply]
    FOREIGN KEY ([TopicId])
    REFERENCES [dbo].[Topics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [Id] in table 'Posts_Reply'
ALTER TABLE [dbo].[Posts_Reply]
ADD CONSTRAINT [FK_Reply_inherits_Post]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Posts_Reply'
ALTER TABLE [dbo].[Posts_Reply]
ADD CONSTRAINT [PK_Posts_Reply]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostReply'
CREATE INDEX [IX_FK_MainPostReply]
ON [dbo].[Posts_Reply]
    ([MainPostId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_TopicReply'
CREATE INDEX [IX_FK_TopicReply]
ON [dbo].[Posts_Reply]
    ([TopicId]);