-- Creating table 'Posts_Discussion'
CREATE TABLE [dbo].[Posts_Discussion] (
	   [Id] int  NOT NULL
);
GO
-- Creating foreign key on [Id] in table 'Posts_Discussion'
ALTER TABLE [dbo].[Posts_Discussion]
ADD CONSTRAINT [FK_Discussion_inherits_MainPost]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Posts_Discussion'
ALTER TABLE [dbo].[Posts_Discussion]
ADD CONSTRAINT [PK_Posts_Discussion]
    PRIMARY KEY CLUSTERED ([Id] ASC);