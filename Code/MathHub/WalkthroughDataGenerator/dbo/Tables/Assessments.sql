-- Creating table 'Assessments'
CREATE TABLE [dbo].[Assessments] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [RoleId] int  NOT NULL,
	   [UserId] int  NOT NULL,
	   [DateCreated] nvarchar(max)  NOT NULL
);
GO
-- Creating foreign key on [RoleId] in table 'Assessments'
ALTER TABLE [dbo].[Assessments]
ADD CONSTRAINT [FK_RoleAssessment]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [UserId] in table 'Assessments'
ALTER TABLE [dbo].[Assessments]
ADD CONSTRAINT [FK_UserAssessment]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Assessments'
ALTER TABLE [dbo].[Assessments]
ADD CONSTRAINT [PK_Assessments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_RoleAssessment'
CREATE INDEX [IX_FK_RoleAssessment]
ON [dbo].[Assessments]
    ([RoleId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserAssessment'
CREATE INDEX [IX_FK_UserAssessment]
ON [dbo].[Assessments]
    ([UserId]);