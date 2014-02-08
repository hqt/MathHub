-- Creating table 'Posts_Blog'
CREATE TABLE [dbo].[Posts_Blog] (
	   [CategoryId] int  NULL,
	   [Id] int  NOT NULL
);
GO
-- Creating foreign key on [CategoryId] in table 'Posts_Blog'
ALTER TABLE [dbo].[Posts_Blog]
ADD CONSTRAINT [FK_CategoryBlog]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [Id] in table 'Posts_Blog'
ALTER TABLE [dbo].[Posts_Blog]
ADD CONSTRAINT [FK_Blog_inherits_MainPost]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Posts_Blog'
ALTER TABLE [dbo].[Posts_Blog]
ADD CONSTRAINT [PK_Posts_Blog]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryBlog'
CREATE INDEX [IX_FK_CategoryBlog]
ON [dbo].[Posts_Blog]
    ([CategoryId]);