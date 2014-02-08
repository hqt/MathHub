-- Creating table 'Functions'
CREATE TABLE [dbo].[Functions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(max)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [ScorePermissionId] int  NOT NULL
);
GO
-- Creating foreign key on [ScorePermissionId] in table 'Functions'
ALTER TABLE [dbo].[Functions]
ADD CONSTRAINT [FK_ScorePermissionFunction]
    FOREIGN KEY ([ScorePermissionId])
    REFERENCES [dbo].[ScorePermissions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Functions'
ALTER TABLE [dbo].[Functions]
ADD CONSTRAINT [PK_Functions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ScorePermissionFunction'
CREATE INDEX [IX_FK_ScorePermissionFunction]
ON [dbo].[Functions]
    ([ScorePermissionId]);