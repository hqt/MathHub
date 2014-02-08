-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Username] nvarchar(50)  NOT NULL,
	   [Score] int  NULL,
	   [Avatar_Id] int  NULL
);
GO
-- Creating foreign key on [Avatar_Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_ImageUser]
    FOREIGN KEY ([Avatar_Id])
    REFERENCES [dbo].[Images]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ImageUser'
CREATE INDEX [IX_FK_ImageUser]
ON [dbo].[Users]
    ([Avatar_Id]);