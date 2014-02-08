-- Creating table 'Posts_MainPost'
CREATE TABLE [dbo].[Posts_MainPost] (
	   [Title] nvarchar(250)  NOT NULL,
	   [Id] int  NOT NULL
);
GO
-- Creating foreign key on [Id] in table 'Posts_MainPost'
ALTER TABLE [dbo].[Posts_MainPost]
ADD CONSTRAINT [FK_MainPost_inherits_Post]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Posts_MainPost'
ALTER TABLE [dbo].[Posts_MainPost]
ADD CONSTRAINT [PK_Posts_MainPost]
    PRIMARY KEY CLUSTERED ([Id] ASC);