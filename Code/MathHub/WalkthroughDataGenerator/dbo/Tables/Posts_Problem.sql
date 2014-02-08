-- Creating table 'Posts_Problem'
CREATE TABLE [dbo].[Posts_Problem] (
	   [Id] int  NOT NULL
);
GO
-- Creating foreign key on [Id] in table 'Posts_Problem'
ALTER TABLE [dbo].[Posts_Problem]
ADD CONSTRAINT [FK_Problem_inherits_MainPost]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO
-- Creating primary key on [Id] in table 'Posts_Problem'
ALTER TABLE [dbo].[Posts_Problem]
ADD CONSTRAINT [PK_Posts_Problem]
    PRIMARY KEY CLUSTERED ([Id] ASC);