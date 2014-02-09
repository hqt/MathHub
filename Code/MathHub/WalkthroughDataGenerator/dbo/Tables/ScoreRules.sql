-- Creating table 'ScoreRules'
CREATE TABLE [dbo].[ScoreRules] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [ProblemUpvote] int  NOT NULL,
	   [ProblemDownvote] int  NOT NULL,
	   [DefaultUpvote] int  NOT NULL,
	   [DefaultDownvote] int  NOT NULL
);
GO
-- Creating primary key on [Id] in table 'ScoreRules'
ALTER TABLE [dbo].[ScoreRules]
ADD CONSTRAINT [PK_ScoreRules]
    PRIMARY KEY CLUSTERED ([Id] ASC);