-- Creating table 'BlogInTopics'
CREATE TABLE [dbo].[BlogInTopics] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [TopicId] int  NOT NULL,
	   [BlogId] int  NOT NULL
);
GO
-- Creating foreign key on [TopicId] in table 'BlogInTopics'
ALTER TABLE [dbo].[BlogInTopics]
ADD CONSTRAINT [FK_TopicBlogInTopic]
    FOREIGN KEY ([TopicId])
    REFERENCES [dbo].[Topics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [BlogId] in table 'BlogInTopics'
ALTER TABLE [dbo].[BlogInTopics]
ADD CONSTRAINT [FK_BlogBlogInTopic]
    FOREIGN KEY ([BlogId])
    REFERENCES [dbo].[Posts_Blog]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'BlogInTopics'
ALTER TABLE [dbo].[BlogInTopics]
ADD CONSTRAINT [PK_BlogInTopics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_TopicBlogInTopic'
CREATE INDEX [IX_FK_TopicBlogInTopic]
ON [dbo].[BlogInTopics]
    ([TopicId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_BlogBlogInTopic'
CREATE INDEX [IX_FK_BlogBlogInTopic]
ON [dbo].[BlogInTopics]
    ([BlogId]);