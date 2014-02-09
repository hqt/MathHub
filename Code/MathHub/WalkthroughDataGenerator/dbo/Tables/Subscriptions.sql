-- Creating table 'Subscriptions'
CREATE TABLE [dbo].[Subscriptions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [FollowingId] int  NOT NULL,
	   [FollowerId] int  NOT NULL,
	   [DateSeen] datetime2  NOT NULL,
	   [SubsProblem] bit  NOT NULL,
	   [SubsBlog] bit  NOT NULL,
	   [SubsDiscussion] bit  NOT NULL,
	   [SubsShare] bit  NOT NULL
);
GO
-- Creating foreign key on [FollowingId] in table 'Subscriptions'
ALTER TABLE [dbo].[Subscriptions]
ADD CONSTRAINT [FK_UserSubscription]
    FOREIGN KEY ([FollowingId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating foreign key on [FollowerId] in table 'Subscriptions'
ALTER TABLE [dbo].[Subscriptions]
ADD CONSTRAINT [FK_UserSubscription1]
    FOREIGN KEY ([FollowerId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Subscriptions'
ALTER TABLE [dbo].[Subscriptions]
ADD CONSTRAINT [PK_Subscriptions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserSubscription'
CREATE INDEX [IX_FK_UserSubscription]
ON [dbo].[Subscriptions]
    ([FollowingId]);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_UserSubscription1'
CREATE INDEX [IX_FK_UserSubscription1]
ON [dbo].[Subscriptions]
    ([FollowerId]);