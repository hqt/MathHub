-- Creating table 'Rewards'
CREATE TABLE [dbo].[Rewards] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [MedalId] int  NOT NULL
);
GO
-- Creating foreign key on [UserId] in table 'Rewards'
ALTER TABLE [dbo].[Rewards]
ADD CONSTRAINT [FK_UserReward]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [MedalId] in table 'Rewards'
ALTER TABLE [dbo].[Rewards]
ADD CONSTRAINT [FK_MedalReward]
    FOREIGN KEY ([MedalId])
    REFERENCES [dbo].[Medals]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Rewards'
ALTER TABLE [dbo].[Rewards]
ADD CONSTRAINT [PK_Rewards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserReward'
CREATE INDEX [IX_FK_UserReward]
ON [dbo].[Rewards]
    ([UserId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_MedalReward'
CREATE INDEX [IX_FK_MedalReward]
ON [dbo].[Rewards]
    ([MedalId]);