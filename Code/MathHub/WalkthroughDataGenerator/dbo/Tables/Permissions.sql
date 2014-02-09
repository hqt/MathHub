-- Creating table 'Permissions'
CREATE TABLE [dbo].[Permissions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [RoleId] int  NOT NULL,
	   [FunctionId] int  NOT NULL
);
GO
-- Creating foreign key on [RoleId] in table 'Permissions'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [FK_RolePermission]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [FunctionId] in table 'Permissions'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [FK_FunctionPermission]
    FOREIGN KEY ([FunctionId])
    REFERENCES [dbo].[Functions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Permissions'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [PK_Permissions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_RolePermission'
CREATE INDEX [IX_FK_RolePermission]
ON [dbo].[Permissions]
    ([RoleId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_FunctionPermission'
CREATE INDEX [IX_FK_FunctionPermission]
ON [dbo].[Permissions]
    ([FunctionId]);