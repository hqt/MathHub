-- Creating table 'Invitations'
CREATE TABLE [dbo].[Invitations] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [ProblemId] int  NOT NULL,
	   [UserId] int  NOT NULL,
	   [DateCreated] datetime2  NOT NULL
);
GO
-- Creating foreign key on [ProblemId] in table 'Invitations'
ALTER TABLE [dbo].[Invitations]
ADD CONSTRAINT [FK_ProblemInvitation]
    FOREIGN KEY ([ProblemId])
    REFERENCES [dbo].[Posts_Problem]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [UserId] in table 'Invitations'
ALTER TABLE [dbo].[Invitations]
ADD CONSTRAINT [FK_UserInvitation]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Invitations'
ALTER TABLE [dbo].[Invitations]
ADD CONSTRAINT [PK_Invitations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ProblemInvitation'
CREATE INDEX [IX_FK_ProblemInvitation]
ON [dbo].[Invitations]
    ([ProblemId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserInvitation'
CREATE INDEX [IX_FK_UserInvitation]
ON [dbo].[Invitations]
    ([UserId]);