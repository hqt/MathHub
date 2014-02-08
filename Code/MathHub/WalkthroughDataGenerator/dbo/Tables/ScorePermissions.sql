-- Creating table 'ScorePermissions'
CREATE TABLE [dbo].[ScorePermissions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Score] int  NOT NULL,
	   [Title] nvarchar(250)  NOT NULL,
	   [Color] nvarchar(10)  NULL
);
GO
-- Creating primary key on [Id] in table 'ScorePermissions'
ALTER TABLE [dbo].[ScorePermissions]
ADD CONSTRAINT [PK_ScorePermissions]
    PRIMARY KEY CLUSTERED ([Id] ASC);