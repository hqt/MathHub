-- Creating table 'BlogProblems'
CREATE TABLE [dbo].[BlogProblems] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [BlogId] int  NULL,
	   [ProblemId] int  NULL
);
GO
-- Creating foreign key on [BlogId] in table 'BlogProblems'
ALTER TABLE [dbo].[BlogProblems]
ADD CONSTRAINT [FK_BlogBlogProblem]
    FOREIGN KEY ([BlogId])
    REFERENCES [dbo].[Posts_Blog]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [ProblemId] in table 'BlogProblems'
ALTER TABLE [dbo].[BlogProblems]
ADD CONSTRAINT [FK_ProblemBlogProblem]
    FOREIGN KEY ([ProblemId])
    REFERENCES [dbo].[Posts_Problem]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'BlogProblems'
ALTER TABLE [dbo].[BlogProblems]
ADD CONSTRAINT [PK_BlogProblems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_BlogBlogProblem'
CREATE INDEX [IX_FK_BlogBlogProblem]
ON [dbo].[BlogProblems]
    ([BlogId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ProblemBlogProblem'
CREATE INDEX [IX_FK_ProblemBlogProblem]
ON [dbo].[BlogProblems]
    ([ProblemId]);