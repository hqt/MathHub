-- Creating table 'DiscusstionProblems'
CREATE TABLE [dbo].[DiscusstionProblems] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [ProblemId] int  NULL,
	   [DiscussionId] int  NULL
);
GO
-- Creating foreign key on [ProblemId] in table 'DiscusstionProblems'
ALTER TABLE [dbo].[DiscusstionProblems]
ADD CONSTRAINT [FK_ProblemDiscusstionProblem]
    FOREIGN KEY ([ProblemId])
    REFERENCES [dbo].[Posts_Problem]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [DiscussionId] in table 'DiscusstionProblems'
ALTER TABLE [dbo].[DiscusstionProblems]
ADD CONSTRAINT [FK_DiscussionDiscusstionProblem]
    FOREIGN KEY ([DiscussionId])
    REFERENCES [dbo].[Posts_Discussion]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'DiscusstionProblems'
ALTER TABLE [dbo].[DiscusstionProblems]
ADD CONSTRAINT [PK_DiscusstionProblems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ProblemDiscusstionProblem'
CREATE INDEX [IX_FK_ProblemDiscusstionProblem]
ON [dbo].[DiscusstionProblems]
    ([ProblemId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_DiscussionDiscusstionProblem'
CREATE INDEX [IX_FK_DiscussionDiscusstionProblem]
ON [dbo].[DiscusstionProblems]
    ([DiscussionId]);