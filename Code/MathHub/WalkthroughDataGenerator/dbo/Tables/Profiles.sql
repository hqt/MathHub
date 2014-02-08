-- Creating table 'Profiles'
CREATE TABLE [dbo].[Profiles] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [FullName] nvarchar(250)  NULL,
	   [Email] nvarchar(250)  NULL,
	   [School] nvarchar(250)  NULL,
	   [Birthday] datetime2  NULL,
	   [Website] nvarchar(250)  NULL,
	   [Location] nvarchar(250)  NULL,
	   [Facebook] nvarchar(250)  NULL,
	   [Summary] nvarchar(max)  NULL,
	   [View] int  NULL,
	   [User_Id] int  NOT NULL
);
GO
-- Creating foreign key on [User_Id] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [FK_ProfileUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [PK_Profiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileUser'
CREATE INDEX [IX_FK_ProfileUser]
ON [dbo].[Profiles]
    ([User_Id]);