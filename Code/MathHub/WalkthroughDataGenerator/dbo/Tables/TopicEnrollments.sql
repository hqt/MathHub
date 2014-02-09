-- Creating table 'TopicEnrollments'
CREATE TABLE [dbo].[TopicEnrollments] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [TopicId] int  NOT NULL,
	   [UserId] int  NOT NULL,
	   [Type] int  NOT NULL,
	   [DateSeen] datetime2  NOT NULL
);
GO
-- Creating foreign key on [TopicId] in table 'TopicEnrollments'
ALTER TABLE [dbo].[TopicEnrollments]
ADD CONSTRAINT [FK_TopicTopicEnrollment]
    FOREIGN KEY ([TopicId])
    REFERENCES [dbo].[Topics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [UserId] in table 'TopicEnrollments'
ALTER TABLE [dbo].[TopicEnrollments]
ADD CONSTRAINT [FK_UserTopicEnrollment]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'TopicEnrollments'
ALTER TABLE [dbo].[TopicEnrollments]
ADD CONSTRAINT [PK_TopicEnrollments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_TopicTopicEnrollment'
CREATE INDEX [IX_FK_TopicTopicEnrollment]
ON [dbo].[TopicEnrollments]
    ([TopicId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserTopicEnrollment'
CREATE INDEX [IX_FK_UserTopicEnrollment]
ON [dbo].[TopicEnrollments]
    ([UserId]);