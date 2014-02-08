-- Creating table 'Conversations'
CREATE TABLE [dbo].[Conversations] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Title] nvarchar(max)  NULL
);
GO
-- Creating primary key on [Id] in table 'Conversations'
ALTER TABLE [dbo].[Conversations]
ADD CONSTRAINT [PK_Conversations]
    PRIMARY KEY CLUSTERED ([Id] ASC);