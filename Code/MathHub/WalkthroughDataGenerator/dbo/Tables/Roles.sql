-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(250)  NOT NULL
);
GO
-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);