-- Creating table 'PostTags'
CREATE TABLE [dbo].[PostTags] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [PostId] int  NOT NULL,
	   [TagId] int  NOT NULL,
	   [MainPostId] int  NOT NULL
);
GO
-- Creating foreign key on [TagId] in table 'PostTags'
ALTER TABLE [dbo].[PostTags]
ADD CONSTRAINT [FK_TagProblemTag]
    FOREIGN KEY ([TagId])
    REFERENCES [dbo].[Tags]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [MainPostId] in table 'PostTags'
ALTER TABLE [dbo].[PostTags]
ADD CONSTRAINT [FK_MainPostPostTag]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'PostTags'
ALTER TABLE [dbo].[PostTags]
ADD CONSTRAINT [PK_PostTags]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_TagProblemTag'
CREATE INDEX [IX_FK_TagProblemTag]
ON [dbo].[PostTags]
    ([TagId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostPostTag'
CREATE INDEX [IX_FK_MainPostPostTag]
ON [dbo].[PostTags]
    ([MainPostId]);