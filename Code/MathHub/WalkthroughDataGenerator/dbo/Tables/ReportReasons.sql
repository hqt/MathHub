-- Creating table 'ReportReasons'
CREATE TABLE [dbo].[ReportReasons] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [Priority] int  NOT NULL
);
GO
-- Creating primary key on [Id] in table 'ReportReasons'
ALTER TABLE [dbo].[ReportReasons]
ADD CONSTRAINT [PK_ReportReasons]
    PRIMARY KEY CLUSTERED ([Id] ASC);