-- Creating table 'LoginSessions'
CREATE TABLE [dbo].[LoginSessions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [SessionKey] nvarchar(max)  NOT NULL,
	   [IpAddress] nvarchar(max)  NOT NULL,
	   [Browser] nvarchar(max)  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [User_Id] int  NOT NULL
);
GO
-- Creating foreign key on [User_Id] in table 'LoginSessions'
ALTER TABLE [dbo].[LoginSessions]
ADD CONSTRAINT [FK_LoginSessionUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'LoginSessions'
ALTER TABLE [dbo].[LoginSessions]
ADD CONSTRAINT [PK_LoginSessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_LoginSessionUser'
CREATE INDEX [IX_FK_LoginSessionUser]
ON [dbo].[LoginSessions]
    ([User_Id]);