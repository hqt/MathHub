-- Creating table 'Shares'
CREATE TABLE [dbo].[Shares] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [MainPostId] int  NOT NULL
);
GO
-- Creating foreign key on [UserId] in table 'Shares'
ALTER TABLE [dbo].[Shares]
ADD CONSTRAINT [FK_UserShare]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [MainPostId] in table 'Shares'
ALTER TABLE [dbo].[Shares]
ADD CONSTRAINT [FK_MainPostShare]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Shares'
ALTER TABLE [dbo].[Shares]
ADD CONSTRAINT [PK_Shares]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserShare'
CREATE INDEX [IX_FK_UserShare]
ON [dbo].[Shares]
    ([UserId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostShare'
CREATE INDEX [IX_FK_MainPostShare]
ON [dbo].[Shares]
    ([MainPostId]);