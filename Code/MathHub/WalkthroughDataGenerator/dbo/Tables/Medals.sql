-- Creating table 'Medals'
CREATE TABLE [dbo].[Medals] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(max)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [Type] int  NOT NULL,
	   [TagId] int  NULL,
	   [Maximum] int  NOT NULL
);
GO
-- Creating foreign key on [TagId] in table 'Medals'
ALTER TABLE [dbo].[Medals]
ADD CONSTRAINT [FK_MedalTag]
    FOREIGN KEY ([TagId])
    REFERENCES [dbo].[Tags]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Medals'
ALTER TABLE [dbo].[Medals]
ADD CONSTRAINT [PK_Medals]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_MedalTag'
CREATE INDEX [IX_FK_MedalTag]
ON [dbo].[Medals]
    ([TagId]);