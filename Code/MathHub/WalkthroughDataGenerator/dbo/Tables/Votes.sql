-- Creating table 'Votes'
CREATE TABLE [dbo].[Votes] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [PostId] int  NOT NULL,
	   [Type] int  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [Score] int  NOT NULL
);
GO
-- Creating foreign key on [PostId] in table 'Votes'
ALTER TABLE [dbo].[Votes]
ADD CONSTRAINT [FK_PostVote]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [UserId] in table 'Votes'
ALTER TABLE [dbo].[Votes]
ADD CONSTRAINT [FK_UserVote]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Votes'
ALTER TABLE [dbo].[Votes]
ADD CONSTRAINT [PK_Votes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_PostVote'
CREATE INDEX [IX_FK_PostVote]
ON [dbo].[Votes]
    ([PostId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserVote'
CREATE INDEX [IX_FK_UserVote]
ON [dbo].[Votes]
    ([UserId]);