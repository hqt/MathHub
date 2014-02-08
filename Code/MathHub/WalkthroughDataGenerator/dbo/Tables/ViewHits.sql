-- Creating table 'ViewHits'
CREATE TABLE [dbo].[ViewHits] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateRecord] datetime2  NOT NULL,
	   [Hits] int  NOT NULL,
	   [MainPostId] int  NOT NULL
);
GO
-- Creating foreign key on [MainPostId] in table 'ViewHits'
ALTER TABLE [dbo].[ViewHits]
ADD CONSTRAINT [FK_MainPostViewHit]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'ViewHits'
ALTER TABLE [dbo].[ViewHits]
ADD CONSTRAINT [PK_ViewHits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO
-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostViewHit'
CREATE INDEX [IX_FK_MainPostViewHit]
ON [dbo].[ViewHits]
    ([MainPostId]);