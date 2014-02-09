-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Url] nvarchar(max)  NOT NULL,
	   [Description] nvarchar(max)  NULL
);
GO
-- Creating primary key on [Id] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([Id] ASC);