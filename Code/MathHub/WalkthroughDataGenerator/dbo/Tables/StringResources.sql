-- Creating table 'StringResources'
CREATE TABLE [dbo].[StringResources] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(250)  NOT NULL,
	   [Value] nvarchar(max)  NOT NULL
);
GO
-- Creating primary key on [Id] in table 'StringResources'
ALTER TABLE [dbo].[StringResources]
ADD CONSTRAINT [PK_StringResources]
    PRIMARY KEY CLUSTERED ([Id] ASC);