
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- -------------------------------------------------
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MathHubDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TagUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tags] DROP CONSTRAINT [FK_TagUser];
GO
IF OBJECT_ID(N'[dbo].[FK_FavoriteTagTag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FavoriteTags] DROP CONSTRAINT [FK_FavoriteTagTag];
GO
IF OBJECT_ID(N'[dbo].[FK_FavoriteTagUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FavoriteTags] DROP CONSTRAINT [FK_FavoriteTagUser];
GO
IF OBJECT_ID(N'[dbo].[FK_TagProblemTag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PostTags] DROP CONSTRAINT [FK_TagProblemTag];
GO
IF OBJECT_ID(N'[dbo].[FK_PostUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts] DROP CONSTRAINT [FK_PostUser];
GO
IF OBJECT_ID(N'[dbo].[FK_MainPostPostTag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PostTags] DROP CONSTRAINT [FK_MainPostPostTag];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Categories] DROP CONSTRAINT [FK_UserCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Categories] DROP CONSTRAINT [FK_CategoryCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_BlogBlogProblem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogProblems] DROP CONSTRAINT [FK_BlogBlogProblem];
GO
IF OBJECT_ID(N'[dbo].[FK_ProblemBlogProblem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogProblems] DROP CONSTRAINT [FK_ProblemBlogProblem];
GO
IF OBJECT_ID(N'[dbo].[FK_ProblemDiscusstionProblem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DiscusstionProblems] DROP CONSTRAINT [FK_ProblemDiscusstionProblem];
GO
IF OBJECT_ID(N'[dbo].[FK_DiscussionDiscusstionProblem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DiscusstionProblems] DROP CONSTRAINT [FK_DiscussionDiscusstionProblem];
GO
IF OBJECT_ID(N'[dbo].[FK_UserFavoritePost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FavoritePosts] DROP CONSTRAINT [FK_UserFavoritePost];
GO
IF OBJECT_ID(N'[dbo].[FK_MainPostFavoritePost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FavoritePosts] DROP CONSTRAINT [FK_MainPostFavoritePost];
GO
IF OBJECT_ID(N'[dbo].[FK_ProblemInvitation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Invitations] DROP CONSTRAINT [FK_ProblemInvitation];
GO
IF OBJECT_ID(N'[dbo].[FK_UserInvitation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Invitations] DROP CONSTRAINT [FK_UserInvitation];
GO
IF OBJECT_ID(N'[dbo].[FK_ReplyComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Comment] DROP CONSTRAINT [FK_ReplyComment];
GO
IF OBJECT_ID(N'[dbo].[FK_MainPostComment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Comment] DROP CONSTRAINT [FK_MainPostComment];
GO
IF OBJECT_ID(N'[dbo].[FK_MainPostViewHit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ViewHits] DROP CONSTRAINT [FK_MainPostViewHit];
GO
IF OBJECT_ID(N'[dbo].[FK_PostReport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reports] DROP CONSTRAINT [FK_PostReport];
GO
IF OBJECT_ID(N'[dbo].[FK_ReportReasonReport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reports] DROP CONSTRAINT [FK_ReportReasonReport];
GO
IF OBJECT_ID(N'[dbo].[FK_PostVote]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Votes] DROP CONSTRAINT [FK_PostVote];
GO
IF OBJECT_ID(N'[dbo].[FK_UserVote]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Votes] DROP CONSTRAINT [FK_UserVote];
GO
IF OBJECT_ID(N'[dbo].[FK_UserSubscription]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Subscriptions] DROP CONSTRAINT [FK_UserSubscription];
GO
IF OBJECT_ID(N'[dbo].[FK_UserSubscription1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Subscriptions] DROP CONSTRAINT [FK_UserSubscription1];
GO
IF OBJECT_ID(N'[dbo].[FK_MainPostReply]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Reply] DROP CONSTRAINT [FK_MainPostReply];
GO
IF OBJECT_ID(N'[dbo].[FK_RoleAssessment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assessments] DROP CONSTRAINT [FK_RoleAssessment];
GO
IF OBJECT_ID(N'[dbo].[FK_UserAssessment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Assessments] DROP CONSTRAINT [FK_UserAssessment];
GO
IF OBJECT_ID(N'[dbo].[FK_RolePermission]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permissions] DROP CONSTRAINT [FK_RolePermission];
GO
IF OBJECT_ID(N'[dbo].[FK_FunctionPermission]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permissions] DROP CONSTRAINT [FK_FunctionPermission];
GO
IF OBJECT_ID(N'[dbo].[FK_ScorePermissionFunction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Functions] DROP CONSTRAINT [FK_ScorePermissionFunction];
GO
IF OBJECT_ID(N'[dbo].[FK_MedalTag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medals] DROP CONSTRAINT [FK_MedalTag];
GO
IF OBJECT_ID(N'[dbo].[FK_UserReward]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rewards] DROP CONSTRAINT [FK_UserReward];
GO
IF OBJECT_ID(N'[dbo].[FK_MedalReward]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rewards] DROP CONSTRAINT [FK_MedalReward];
GO
IF OBJECT_ID(N'[dbo].[FK_ImageTag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tags] DROP CONSTRAINT [FK_ImageTag];
GO
IF OBJECT_ID(N'[dbo].[FK_UserAttendance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Attendances] DROP CONSTRAINT [FK_UserAttendance];
GO
IF OBJECT_ID(N'[dbo].[FK_ConversationAttendance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Attendances] DROP CONSTRAINT [FK_ConversationAttendance];
GO
IF OBJECT_ID(N'[dbo].[FK_AttendanceMessage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Messages] DROP CONSTRAINT [FK_AttendanceMessage];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTopic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Topics] DROP CONSTRAINT [FK_UserTopic];
GO
IF OBJECT_ID(N'[dbo].[FK_TopicTopicEnrollment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TopicEnrollments] DROP CONSTRAINT [FK_TopicTopicEnrollment];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTopicEnrollment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TopicEnrollments] DROP CONSTRAINT [FK_UserTopicEnrollment];
GO
IF OBJECT_ID(N'[dbo].[FK_TopicBlogInTopic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogInTopics] DROP CONSTRAINT [FK_TopicBlogInTopic];
GO
IF OBJECT_ID(N'[dbo].[FK_BlogBlogInTopic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogInTopics] DROP CONSTRAINT [FK_BlogBlogInTopic];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryBlog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Blog] DROP CONSTRAINT [FK_CategoryBlog];
GO
IF OBJECT_ID(N'[dbo].[FK_UserShare]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shares] DROP CONSTRAINT [FK_UserShare];
GO
IF OBJECT_ID(N'[dbo].[FK_MainPostShare]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shares] DROP CONSTRAINT [FK_MainPostShare];
GO
IF OBJECT_ID(N'[dbo].[FK_TopicReply]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Reply] DROP CONSTRAINT [FK_TopicReply];
GO
IF OBJECT_ID(N'[dbo].[FK_UserFollow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FollowPosts] DROP CONSTRAINT [FK_UserFollow];
GO
IF OBJECT_ID(N'[dbo].[FK_PostFollow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FollowPosts] DROP CONSTRAINT [FK_PostFollow];
GO
IF OBJECT_ID(N'[dbo].[FK_LoginSessionUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoginSessions] DROP CONSTRAINT [FK_LoginSessionUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ActivityUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Activities] DROP CONSTRAINT [FK_ActivityUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfileUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Profiles] DROP CONSTRAINT [FK_ProfileUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ImageUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_ImageUser];
GO
IF OBJECT_ID(N'[dbo].[FK_MainPost_inherits_Post]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_MainPost] DROP CONSTRAINT [FK_MainPost_inherits_Post];
GO
IF OBJECT_ID(N'[dbo].[FK_Blog_inherits_MainPost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Blog] DROP CONSTRAINT [FK_Blog_inherits_MainPost];
GO
IF OBJECT_ID(N'[dbo].[FK_Problem_inherits_MainPost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Problem] DROP CONSTRAINT [FK_Problem_inherits_MainPost];
GO
IF OBJECT_ID(N'[dbo].[FK_Discussion_inherits_MainPost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Discussion] DROP CONSTRAINT [FK_Discussion_inherits_MainPost];
GO
IF OBJECT_ID(N'[dbo].[FK_Reply_inherits_Post]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Reply] DROP CONSTRAINT [FK_Reply_inherits_Post];
GO
IF OBJECT_ID(N'[dbo].[FK_Comment_inherits_Post]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Posts_Comment] DROP CONSTRAINT [FK_Comment_inherits_Post];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Tags]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tags];
GO
IF OBJECT_ID(N'[dbo].[FavoriteTags]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FavoriteTags];
GO
IF OBJECT_ID(N'[dbo].[PostTags]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PostTags];
GO
IF OBJECT_ID(N'[dbo].[Posts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posts];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[BlogProblems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BlogProblems];
GO
IF OBJECT_ID(N'[dbo].[DiscusstionProblems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DiscusstionProblems];
GO
IF OBJECT_ID(N'[dbo].[FavoritePosts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FavoritePosts];
GO
IF OBJECT_ID(N'[dbo].[Invitations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invitations];
GO
IF OBJECT_ID(N'[dbo].[ViewHits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ViewHits];
GO
IF OBJECT_ID(N'[dbo].[Reports]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reports];
GO
IF OBJECT_ID(N'[dbo].[ReportReasons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReportReasons];
GO
IF OBJECT_ID(N'[dbo].[Votes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Votes];
GO
IF OBJECT_ID(N'[dbo].[ScoreRules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScoreRules];
GO
IF OBJECT_ID(N'[dbo].[Subscriptions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Subscriptions];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Assessments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Assessments];
GO
IF OBJECT_ID(N'[dbo].[Functions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Functions];
GO
IF OBJECT_ID(N'[dbo].[Permissions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permissions];
GO
IF OBJECT_ID(N'[dbo].[ScorePermissions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScorePermissions];
GO
IF OBJECT_ID(N'[dbo].[Medals]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medals];
GO
IF OBJECT_ID(N'[dbo].[Rewards]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rewards];
GO
IF OBJECT_ID(N'[dbo].[Images]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Images];
GO
IF OBJECT_ID(N'[dbo].[Profiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profiles];
GO
IF OBJECT_ID(N'[dbo].[Conversations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Conversations];
GO
IF OBJECT_ID(N'[dbo].[Attendances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Attendances];
GO
IF OBJECT_ID(N'[dbo].[Messages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Messages];
GO
IF OBJECT_ID(N'[dbo].[Topics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Topics];
GO
IF OBJECT_ID(N'[dbo].[TopicEnrollments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TopicEnrollments];
GO
IF OBJECT_ID(N'[dbo].[BlogInTopics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BlogInTopics];
GO
IF OBJECT_ID(N'[dbo].[Shares]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Shares];
GO
IF OBJECT_ID(N'[dbo].[StringResources]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StringResources];
GO
IF OBJECT_ID(N'[dbo].[FollowPosts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FollowPosts];
GO
IF OBJECT_ID(N'[dbo].[Activities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Activities];
GO
IF OBJECT_ID(N'[dbo].[LoginSessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoginSessions];
GO
IF OBJECT_ID(N'[dbo].[Posts_MainPost]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posts_MainPost];
GO
IF OBJECT_ID(N'[dbo].[Posts_Blog]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posts_Blog];
GO
IF OBJECT_ID(N'[dbo].[Posts_Problem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posts_Problem];
GO
IF OBJECT_ID(N'[dbo].[Posts_Discussion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posts_Discussion];
GO
IF OBJECT_ID(N'[dbo].[Posts_Reply]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posts_Reply];
GO
IF OBJECT_ID(N'[dbo].[Posts_Comment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posts_Comment];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Username] nvarchar(50)  NOT NULL,
	   [Score] int  NULL,
	   [Avatar_Id] int  NULL
);
GO

-- Creating table 'Tags'
CREATE TABLE [dbo].[Tags] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(250)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [CreatorId] int  NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [DateModified] datetime2  NOT NULL,
	   [Image_Id] int  NULL
);
GO

-- Creating table 'FavoriteTags'
CREATE TABLE [dbo].[FavoriteTags] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [TagId] int  NOT NULL,
	   [UserId] int  NOT NULL
);
GO

-- Creating table 'PostTags'
CREATE TABLE [dbo].[PostTags] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [TagId] int  NOT NULL,
	   [MainPostId] int  NOT NULL
);
GO

-- Creating table 'Posts'
CREATE TABLE [dbo].[Posts] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Content] nvarchar(max)  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [DateModified] datetime2  NOT NULL,
	   [UserId] int  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(250)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [CreatorId] int  NOT NULL,
	   [ParentCategoryId] int  NULL
);
GO

-- Creating table 'BlogProblems'
CREATE TABLE [dbo].[BlogProblems] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [BlogId] int  NULL,
	   [ProblemId] int  NULL
);
GO

-- Creating table 'DiscusstionProblems'
CREATE TABLE [dbo].[DiscusstionProblems] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [ProblemId] int  NULL,
	   [DiscussionId] int  NULL
);
GO

-- Creating table 'FavoritePosts'
CREATE TABLE [dbo].[FavoritePosts] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [UserId] int  NOT NULL,
	   [MainPostId] int  NOT NULL
);
GO

-- Creating table 'Invitations'
CREATE TABLE [dbo].[Invitations] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [ProblemId] int  NOT NULL,
	   [UserId] int  NOT NULL,
	   [DateCreated] datetime2  NOT NULL
);
GO

-- Creating table 'ViewHits'
CREATE TABLE [dbo].[ViewHits] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateRecord] datetime2  NOT NULL,
	   [Hits] int  NOT NULL,
	   [MainPostId] int  NOT NULL
);
GO

-- Creating table 'Reports'
CREATE TABLE [dbo].[Reports] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [PostId] int  NOT NULL,
	   [ReportReasonId] int  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [OtherReason] nvarchar(max)  NULL
);
GO

-- Creating table 'ReportReasons'
CREATE TABLE [dbo].[ReportReasons] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [Priority] int  NOT NULL
);
GO

-- Creating table 'Votes'
CREATE TABLE [dbo].[Votes] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [PostId] int  NOT NULL,
	   [Type] int  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [Score] int  NOT NULL
);
GO

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

-- Creating table 'Subscriptions'
CREATE TABLE [dbo].[Subscriptions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [FollowingId] int  NOT NULL,
	   [FollowerId] int  NOT NULL,
	   [DateSeen] datetime2  NOT NULL,
	   [SubsProblem] bit  NOT NULL,
	   [SubsBlog] bit  NOT NULL,
	   [SubsDiscussion] bit  NOT NULL,
	   [SubsShare] bit  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'Assessments'
CREATE TABLE [dbo].[Assessments] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [RoleId] int  NOT NULL,
	   [UserId] int  NOT NULL,
	   [DateCreated] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Functions'
CREATE TABLE [dbo].[Functions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(max)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [ScorePermissionId] int  NOT NULL
);
GO

-- Creating table 'Permissions'
CREATE TABLE [dbo].[Permissions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [RoleId] int  NOT NULL,
	   [FunctionId] int  NOT NULL
);
GO

-- Creating table 'ScorePermissions'
CREATE TABLE [dbo].[ScorePermissions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Score] int  NOT NULL,
	   [Title] nvarchar(250)  NOT NULL,
	   [Color] nvarchar(10)  NULL
);
GO

-- Creating table 'Medals'
CREATE TABLE [dbo].[Medals] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(max)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [Type] int  NOT NULL,
	   [TagId] int  NULL,
	   [Maximum] int  NOT NULL
);
GO

-- Creating table 'Rewards'
CREATE TABLE [dbo].[Rewards] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [MedalId] int  NOT NULL
);
GO

-- Creating table 'Images'
CREATE TABLE [dbo].[Images] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Url] nvarchar(max)  NOT NULL,
	   [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Profiles'
CREATE TABLE [dbo].[Profiles] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [FullName] nvarchar(250)  NULL,
	   [Email] nvarchar(250)  NULL,
	   [School] nvarchar(250)  NULL,
	   [Birthday] datetime2  NULL,
	   [Website] nvarchar(250)  NULL,
	   [Location] nvarchar(250)  NULL,
	   [Facebook] nvarchar(250)  NULL,
	   [Summary] nvarchar(max)  NULL,
	   [View] int  NULL,
	   [User_Id] int  NOT NULL
);
GO

-- Creating table 'Conversations'
CREATE TABLE [dbo].[Conversations] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Title] nvarchar(max)  NULL
);
GO

-- Creating table 'Attendances'
CREATE TABLE [dbo].[Attendances] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateJoined] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [ConversationId] int  NOT NULL,
	   [DateSeen] datetime2  NULL
);
GO

-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Content] nvarchar(3000)  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [AttendanceId] int  NOT NULL
);
GO

-- Creating table 'Topics'
CREATE TABLE [dbo].[Topics] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [Title] nvarchar(250)  NOT NULL,
	   [Description] nvarchar(max)  NOT NULL,
	   [CreatorId] int  NOT NULL
);
GO

-- Creating table 'TopicEnrollments'
CREATE TABLE [dbo].[TopicEnrollments] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [TopicId] int  NOT NULL,
	   [UserId] int  NOT NULL,
	   [Type] int  NOT NULL,
	   [DateSeen] datetime2  NOT NULL
);
GO

-- Creating table 'BlogInTopics'
CREATE TABLE [dbo].[BlogInTopics] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [TopicId] int  NOT NULL,
	   [BlogId] int  NOT NULL
);
GO

-- Creating table 'Shares'
CREATE TABLE [dbo].[Shares] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [MainPostId] int  NOT NULL
);
GO

-- Creating table 'StringResources'
CREATE TABLE [dbo].[StringResources] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [Name] nvarchar(250)  NOT NULL,
	   [Value] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FollowPosts'
CREATE TABLE [dbo].[FollowPosts] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [UserId] int  NOT NULL,
	   [PostId] int  NOT NULL,
	   [DateSeen] datetime2  NOT NULL
);
GO

-- Creating table 'Activities'
CREATE TABLE [dbo].[Activities] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [LastSeenInvition] datetime2  NOT NULL,
	   [LastSeenSubcription] datetime2  NOT NULL,
	   [LastSeenReceivedMedal] datetime2  NOT NULL,
	   [LastPermissionGain] datetime2  NOT NULL,
	   [LastSeenPermissionGain] datetime2  NOT NULL,
	   [NewPasswordKey] nvarchar(max)  NOT NULL,
	   [NewPasswordRequestedDate] datetime2  NOT NULL,
	   [NewEmail] nvarchar(max)  NOT NULL,
	   [NewEmailKey] nvarchar(max)  NOT NULL,
	   [LastLogin] nvarchar(max)  NOT NULL,
	   [LastIp] nvarchar(max)  NOT NULL,
	   [User_Id] int  NOT NULL
);
GO

-- Creating table 'LoginSessions'
CREATE TABLE [dbo].[LoginSessions] (
	   [Id] int IDENTITY(1,1) NOT NULL,
	   [SessionKey] nvarchar(max)  NOT NULL,
	   [IpAddress] nvarchar(max)  NOT NULL,
	   [Browser] nvarchar(max)  NOT NULL,
	   [DateCreated] datetime2  NOT NULL,
	   [User_Id] int  NOT NULL
);
GO

-- Creating table 'Posts_MainPost'
CREATE TABLE [dbo].[Posts_MainPost] (
	   [Title] nvarchar(250)  NOT NULL,
	   [Id] int  NOT NULL
);
GO

-- Creating table 'Posts_Blog'
CREATE TABLE [dbo].[Posts_Blog] (
	   [CategoryId] int  NULL,
	   [Id] int  NOT NULL
);
GO

-- Creating table 'Posts_Problem'
CREATE TABLE [dbo].[Posts_Problem] (
	   [Id] int  NOT NULL
);
GO

-- Creating table 'Posts_Discussion'
CREATE TABLE [dbo].[Posts_Discussion] (
	   [Id] int  NOT NULL
);
GO

-- Creating table 'Posts_Reply'
CREATE TABLE [dbo].[Posts_Reply] (
	   [Type] int  NOT NULL,
	   [MainPostId] int  NULL,
	   [TopicId] int  NULL,
	   [Id] int  NOT NULL
);
GO

-- Creating table 'Posts_Comment'
CREATE TABLE [dbo].[Posts_Comment] (
	   [ReplyId] int  NULL,
	   [MainPostId] int  NULL,
	   [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [PK_Tags]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FavoriteTags'
ALTER TABLE [dbo].[FavoriteTags]
ADD CONSTRAINT [PK_FavoriteTags]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PostTags'
ALTER TABLE [dbo].[PostTags]
ADD CONSTRAINT [PK_PostTags]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Posts'
ALTER TABLE [dbo].[Posts]
ADD CONSTRAINT [PK_Posts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BlogProblems'
ALTER TABLE [dbo].[BlogProblems]
ADD CONSTRAINT [PK_BlogProblems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiscusstionProblems'
ALTER TABLE [dbo].[DiscusstionProblems]
ADD CONSTRAINT [PK_DiscusstionProblems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FavoritePosts'
ALTER TABLE [dbo].[FavoritePosts]
ADD CONSTRAINT [PK_FavoritePosts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Invitations'
ALTER TABLE [dbo].[Invitations]
ADD CONSTRAINT [PK_Invitations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ViewHits'
ALTER TABLE [dbo].[ViewHits]
ADD CONSTRAINT [PK_ViewHits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [PK_Reports]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReportReasons'
ALTER TABLE [dbo].[ReportReasons]
ADD CONSTRAINT [PK_ReportReasons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Votes'
ALTER TABLE [dbo].[Votes]
ADD CONSTRAINT [PK_Votes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ScoreRules'
ALTER TABLE [dbo].[ScoreRules]
ADD CONSTRAINT [PK_ScoreRules]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Subscriptions'
ALTER TABLE [dbo].[Subscriptions]
ADD CONSTRAINT [PK_Subscriptions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Assessments'
ALTER TABLE [dbo].[Assessments]
ADD CONSTRAINT [PK_Assessments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Functions'
ALTER TABLE [dbo].[Functions]
ADD CONSTRAINT [PK_Functions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Permissions'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [PK_Permissions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ScorePermissions'
ALTER TABLE [dbo].[ScorePermissions]
ADD CONSTRAINT [PK_ScorePermissions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Medals'
ALTER TABLE [dbo].[Medals]
ADD CONSTRAINT [PK_Medals]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rewards'
ALTER TABLE [dbo].[Rewards]
ADD CONSTRAINT [PK_Rewards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Images'
ALTER TABLE [dbo].[Images]
ADD CONSTRAINT [PK_Images]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [PK_Profiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Conversations'
ALTER TABLE [dbo].[Conversations]
ADD CONSTRAINT [PK_Conversations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Attendances'
ALTER TABLE [dbo].[Attendances]
ADD CONSTRAINT [PK_Attendances]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [PK_Messages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [PK_Topics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TopicEnrollments'
ALTER TABLE [dbo].[TopicEnrollments]
ADD CONSTRAINT [PK_TopicEnrollments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BlogInTopics'
ALTER TABLE [dbo].[BlogInTopics]
ADD CONSTRAINT [PK_BlogInTopics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Shares'
ALTER TABLE [dbo].[Shares]
ADD CONSTRAINT [PK_Shares]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StringResources'
ALTER TABLE [dbo].[StringResources]
ADD CONSTRAINT [PK_StringResources]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FollowPosts'
ALTER TABLE [dbo].[FollowPosts]
ADD CONSTRAINT [PK_FollowPosts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [PK_Activities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LoginSessions'
ALTER TABLE [dbo].[LoginSessions]
ADD CONSTRAINT [PK_LoginSessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Posts_MainPost'
ALTER TABLE [dbo].[Posts_MainPost]
ADD CONSTRAINT [PK_Posts_MainPost]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Posts_Blog'
ALTER TABLE [dbo].[Posts_Blog]
ADD CONSTRAINT [PK_Posts_Blog]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Posts_Problem'
ALTER TABLE [dbo].[Posts_Problem]
ADD CONSTRAINT [PK_Posts_Problem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Posts_Discussion'
ALTER TABLE [dbo].[Posts_Discussion]
ADD CONSTRAINT [PK_Posts_Discussion]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Posts_Reply'
ALTER TABLE [dbo].[Posts_Reply]
ADD CONSTRAINT [PK_Posts_Reply]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Posts_Comment'
ALTER TABLE [dbo].[Posts_Comment]
ADD CONSTRAINT [PK_Posts_Comment]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CreatorId] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [FK_TagUser]
    FOREIGN KEY ([CreatorId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TagUser'
CREATE INDEX [IX_FK_TagUser]
ON [dbo].[Tags]
    ([CreatorId]);
GO

-- Creating foreign key on [TagId] in table 'FavoriteTags'
ALTER TABLE [dbo].[FavoriteTags]
ADD CONSTRAINT [FK_FavoriteTagTag]
    FOREIGN KEY ([TagId])
    REFERENCES [dbo].[Tags]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FavoriteTagTag'
CREATE INDEX [IX_FK_FavoriteTagTag]
ON [dbo].[FavoriteTags]
    ([TagId]);
GO

-- Creating foreign key on [UserId] in table 'FavoriteTags'
ALTER TABLE [dbo].[FavoriteTags]
ADD CONSTRAINT [FK_FavoriteTagUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FavoriteTagUser'
CREATE INDEX [IX_FK_FavoriteTagUser]
ON [dbo].[FavoriteTags]
    ([UserId]);
GO

-- Creating foreign key on [TagId] in table 'PostTags'
ALTER TABLE [dbo].[PostTags]
ADD CONSTRAINT [FK_TagProblemTag]
    FOREIGN KEY ([TagId])
    REFERENCES [dbo].[Tags]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TagProblemTag'
CREATE INDEX [IX_FK_TagProblemTag]
ON [dbo].[PostTags]
    ([TagId]);
GO

-- Creating foreign key on [UserId] in table 'Posts'
ALTER TABLE [dbo].[Posts]
ADD CONSTRAINT [FK_PostUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PostUser'
CREATE INDEX [IX_FK_PostUser]
ON [dbo].[Posts]
    ([UserId]);
GO

-- Creating foreign key on [MainPostId] in table 'PostTags'
ALTER TABLE [dbo].[PostTags]
ADD CONSTRAINT [FK_MainPostPostTag]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostPostTag'
CREATE INDEX [IX_FK_MainPostPostTag]
ON [dbo].[PostTags]
    ([MainPostId]);
GO

-- Creating foreign key on [CreatorId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_UserCategory]
    FOREIGN KEY ([CreatorId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCategory'
CREATE INDEX [IX_FK_UserCategory]
ON [dbo].[Categories]
    ([CreatorId]);
GO

-- Creating foreign key on [ParentCategoryId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_CategoryCategory]
    FOREIGN KEY ([ParentCategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryCategory'
CREATE INDEX [IX_FK_CategoryCategory]
ON [dbo].[Categories]
    ([ParentCategoryId]);
GO

-- Creating foreign key on [BlogId] in table 'BlogProblems'
ALTER TABLE [dbo].[BlogProblems]
ADD CONSTRAINT [FK_BlogBlogProblem]
    FOREIGN KEY ([BlogId])
    REFERENCES [dbo].[Posts_Blog]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BlogBlogProblem'
CREATE INDEX [IX_FK_BlogBlogProblem]
ON [dbo].[BlogProblems]
    ([BlogId]);
GO

-- Creating foreign key on [ProblemId] in table 'BlogProblems'
ALTER TABLE [dbo].[BlogProblems]
ADD CONSTRAINT [FK_ProblemBlogProblem]
    FOREIGN KEY ([ProblemId])
    REFERENCES [dbo].[Posts_Problem]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProblemBlogProblem'
CREATE INDEX [IX_FK_ProblemBlogProblem]
ON [dbo].[BlogProblems]
    ([ProblemId]);
GO

-- Creating foreign key on [ProblemId] in table 'DiscusstionProblems'
ALTER TABLE [dbo].[DiscusstionProblems]
ADD CONSTRAINT [FK_ProblemDiscusstionProblem]
    FOREIGN KEY ([ProblemId])
    REFERENCES [dbo].[Posts_Problem]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProblemDiscusstionProblem'
CREATE INDEX [IX_FK_ProblemDiscusstionProblem]
ON [dbo].[DiscusstionProblems]
    ([ProblemId]);
GO

-- Creating foreign key on [DiscussionId] in table 'DiscusstionProblems'
ALTER TABLE [dbo].[DiscusstionProblems]
ADD CONSTRAINT [FK_DiscussionDiscusstionProblem]
    FOREIGN KEY ([DiscussionId])
    REFERENCES [dbo].[Posts_Discussion]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DiscussionDiscusstionProblem'
CREATE INDEX [IX_FK_DiscussionDiscusstionProblem]
ON [dbo].[DiscusstionProblems]
    ([DiscussionId]);
GO

-- Creating foreign key on [UserId] in table 'FavoritePosts'
ALTER TABLE [dbo].[FavoritePosts]
ADD CONSTRAINT [FK_UserFavoritePost]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFavoritePost'
CREATE INDEX [IX_FK_UserFavoritePost]
ON [dbo].[FavoritePosts]
    ([UserId]);
GO

-- Creating foreign key on [MainPostId] in table 'FavoritePosts'
ALTER TABLE [dbo].[FavoritePosts]
ADD CONSTRAINT [FK_MainPostFavoritePost]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostFavoritePost'
CREATE INDEX [IX_FK_MainPostFavoritePost]
ON [dbo].[FavoritePosts]
    ([MainPostId]);
GO

-- Creating foreign key on [ProblemId] in table 'Invitations'
ALTER TABLE [dbo].[Invitations]
ADD CONSTRAINT [FK_ProblemInvitation]
    FOREIGN KEY ([ProblemId])
    REFERENCES [dbo].[Posts_Problem]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProblemInvitation'
CREATE INDEX [IX_FK_ProblemInvitation]
ON [dbo].[Invitations]
    ([ProblemId]);
GO

-- Creating foreign key on [UserId] in table 'Invitations'
ALTER TABLE [dbo].[Invitations]
ADD CONSTRAINT [FK_UserInvitation]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserInvitation'
CREATE INDEX [IX_FK_UserInvitation]
ON [dbo].[Invitations]
    ([UserId]);
GO

-- Creating foreign key on [ReplyId] in table 'Posts_Comment'
ALTER TABLE [dbo].[Posts_Comment]
ADD CONSTRAINT [FK_ReplyComment]
    FOREIGN KEY ([ReplyId])
    REFERENCES [dbo].[Posts_Reply]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ReplyComment'
CREATE INDEX [IX_FK_ReplyComment]
ON [dbo].[Posts_Comment]
    ([ReplyId]);
GO

-- Creating foreign key on [MainPostId] in table 'Posts_Comment'
ALTER TABLE [dbo].[Posts_Comment]
ADD CONSTRAINT [FK_MainPostComment]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostComment'
CREATE INDEX [IX_FK_MainPostComment]
ON [dbo].[Posts_Comment]
    ([MainPostId]);
GO

-- Creating foreign key on [MainPostId] in table 'ViewHits'
ALTER TABLE [dbo].[ViewHits]
ADD CONSTRAINT [FK_MainPostViewHit]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostViewHit'
CREATE INDEX [IX_FK_MainPostViewHit]
ON [dbo].[ViewHits]
    ([MainPostId]);
GO

-- Creating foreign key on [PostId] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [FK_PostReport]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PostReport'
CREATE INDEX [IX_FK_PostReport]
ON [dbo].[Reports]
    ([PostId]);
GO

-- Creating foreign key on [ReportReasonId] in table 'Reports'
ALTER TABLE [dbo].[Reports]
ADD CONSTRAINT [FK_ReportReasonReport]
    FOREIGN KEY ([ReportReasonId])
    REFERENCES [dbo].[ReportReasons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ReportReasonReport'
CREATE INDEX [IX_FK_ReportReasonReport]
ON [dbo].[Reports]
    ([ReportReasonId]);
GO

-- Creating foreign key on [PostId] in table 'Votes'
ALTER TABLE [dbo].[Votes]
ADD CONSTRAINT [FK_PostVote]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PostVote'
CREATE INDEX [IX_FK_PostVote]
ON [dbo].[Votes]
    ([PostId]);
GO

-- Creating foreign key on [UserId] in table 'Votes'
ALTER TABLE [dbo].[Votes]
ADD CONSTRAINT [FK_UserVote]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserVote'
CREATE INDEX [IX_FK_UserVote]
ON [dbo].[Votes]
    ([UserId]);
GO

-- Creating foreign key on [FollowingId] in table 'Subscriptions'
ALTER TABLE [dbo].[Subscriptions]
ADD CONSTRAINT [FK_UserSubscription]
    FOREIGN KEY ([FollowingId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserSubscription'
CREATE INDEX [IX_FK_UserSubscription]
ON [dbo].[Subscriptions]
    ([FollowingId]);
GO

-- Creating foreign key on [FollowerId] in table 'Subscriptions'
ALTER TABLE [dbo].[Subscriptions]
ADD CONSTRAINT [FK_UserSubscription1]
    FOREIGN KEY ([FollowerId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserSubscription1'
CREATE INDEX [IX_FK_UserSubscription1]
ON [dbo].[Subscriptions]
    ([FollowerId]);
GO

-- Creating foreign key on [MainPostId] in table 'Posts_Reply'
ALTER TABLE [dbo].[Posts_Reply]
ADD CONSTRAINT [FK_MainPostReply]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostReply'
CREATE INDEX [IX_FK_MainPostReply]
ON [dbo].[Posts_Reply]
    ([MainPostId]);
GO

-- Creating foreign key on [RoleId] in table 'Assessments'
ALTER TABLE [dbo].[Assessments]
ADD CONSTRAINT [FK_RoleAssessment]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleAssessment'
CREATE INDEX [IX_FK_RoleAssessment]
ON [dbo].[Assessments]
    ([RoleId]);
GO

-- Creating foreign key on [UserId] in table 'Assessments'
ALTER TABLE [dbo].[Assessments]
ADD CONSTRAINT [FK_UserAssessment]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAssessment'
CREATE INDEX [IX_FK_UserAssessment]
ON [dbo].[Assessments]
    ([UserId]);
GO

-- Creating foreign key on [RoleId] in table 'Permissions'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [FK_RolePermission]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RolePermission'
CREATE INDEX [IX_FK_RolePermission]
ON [dbo].[Permissions]
    ([RoleId]);
GO

-- Creating foreign key on [FunctionId] in table 'Permissions'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [FK_FunctionPermission]
    FOREIGN KEY ([FunctionId])
    REFERENCES [dbo].[Functions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FunctionPermission'
CREATE INDEX [IX_FK_FunctionPermission]
ON [dbo].[Permissions]
    ([FunctionId]);
GO

-- Creating foreign key on [ScorePermissionId] in table 'Functions'
ALTER TABLE [dbo].[Functions]
ADD CONSTRAINT [FK_ScorePermissionFunction]
    FOREIGN KEY ([ScorePermissionId])
    REFERENCES [dbo].[ScorePermissions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ScorePermissionFunction'
CREATE INDEX [IX_FK_ScorePermissionFunction]
ON [dbo].[Functions]
    ([ScorePermissionId]);
GO

-- Creating foreign key on [TagId] in table 'Medals'
ALTER TABLE [dbo].[Medals]
ADD CONSTRAINT [FK_MedalTag]
    FOREIGN KEY ([TagId])
    REFERENCES [dbo].[Tags]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MedalTag'
CREATE INDEX [IX_FK_MedalTag]
ON [dbo].[Medals]
    ([TagId]);
GO

-- Creating foreign key on [UserId] in table 'Rewards'
ALTER TABLE [dbo].[Rewards]
ADD CONSTRAINT [FK_UserReward]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserReward'
CREATE INDEX [IX_FK_UserReward]
ON [dbo].[Rewards]
    ([UserId]);
GO

-- Creating foreign key on [MedalId] in table 'Rewards'
ALTER TABLE [dbo].[Rewards]
ADD CONSTRAINT [FK_MedalReward]
    FOREIGN KEY ([MedalId])
    REFERENCES [dbo].[Medals]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MedalReward'
CREATE INDEX [IX_FK_MedalReward]
ON [dbo].[Rewards]
    ([MedalId]);
GO

-- Creating foreign key on [Image_Id] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [FK_ImageTag]
    FOREIGN KEY ([Image_Id])
    REFERENCES [dbo].[Images]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ImageTag'
CREATE INDEX [IX_FK_ImageTag]
ON [dbo].[Tags]
    ([Image_Id]);
GO

-- Creating foreign key on [UserId] in table 'Attendances'
ALTER TABLE [dbo].[Attendances]
ADD CONSTRAINT [FK_UserAttendance]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAttendance'
CREATE INDEX [IX_FK_UserAttendance]
ON [dbo].[Attendances]
    ([UserId]);
GO

-- Creating foreign key on [ConversationId] in table 'Attendances'
ALTER TABLE [dbo].[Attendances]
ADD CONSTRAINT [FK_ConversationAttendance]
    FOREIGN KEY ([ConversationId])
    REFERENCES [dbo].[Conversations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConversationAttendance'
CREATE INDEX [IX_FK_ConversationAttendance]
ON [dbo].[Attendances]
    ([ConversationId]);
GO

-- Creating foreign key on [AttendanceId] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_AttendanceMessage]
    FOREIGN KEY ([AttendanceId])
    REFERENCES [dbo].[Attendances]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AttendanceMessage'
CREATE INDEX [IX_FK_AttendanceMessage]
ON [dbo].[Messages]
    ([AttendanceId]);
GO

-- Creating foreign key on [CreatorId] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [FK_UserTopic]
    FOREIGN KEY ([CreatorId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTopic'
CREATE INDEX [IX_FK_UserTopic]
ON [dbo].[Topics]
    ([CreatorId]);
GO

-- Creating foreign key on [TopicId] in table 'TopicEnrollments'
ALTER TABLE [dbo].[TopicEnrollments]
ADD CONSTRAINT [FK_TopicTopicEnrollment]
    FOREIGN KEY ([TopicId])
    REFERENCES [dbo].[Topics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TopicTopicEnrollment'
CREATE INDEX [IX_FK_TopicTopicEnrollment]
ON [dbo].[TopicEnrollments]
    ([TopicId]);
GO

-- Creating foreign key on [UserId] in table 'TopicEnrollments'
ALTER TABLE [dbo].[TopicEnrollments]
ADD CONSTRAINT [FK_UserTopicEnrollment]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTopicEnrollment'
CREATE INDEX [IX_FK_UserTopicEnrollment]
ON [dbo].[TopicEnrollments]
    ([UserId]);
GO

-- Creating foreign key on [TopicId] in table 'BlogInTopics'
ALTER TABLE [dbo].[BlogInTopics]
ADD CONSTRAINT [FK_TopicBlogInTopic]
    FOREIGN KEY ([TopicId])
    REFERENCES [dbo].[Topics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TopicBlogInTopic'
CREATE INDEX [IX_FK_TopicBlogInTopic]
ON [dbo].[BlogInTopics]
    ([TopicId]);
GO

-- Creating foreign key on [BlogId] in table 'BlogInTopics'
ALTER TABLE [dbo].[BlogInTopics]
ADD CONSTRAINT [FK_BlogBlogInTopic]
    FOREIGN KEY ([BlogId])
    REFERENCES [dbo].[Posts_Blog]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BlogBlogInTopic'
CREATE INDEX [IX_FK_BlogBlogInTopic]
ON [dbo].[BlogInTopics]
    ([BlogId]);
GO

-- Creating foreign key on [CategoryId] in table 'Posts_Blog'
ALTER TABLE [dbo].[Posts_Blog]
ADD CONSTRAINT [FK_CategoryBlog]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryBlog'
CREATE INDEX [IX_FK_CategoryBlog]
ON [dbo].[Posts_Blog]
    ([CategoryId]);
GO

-- Creating foreign key on [UserId] in table 'Shares'
ALTER TABLE [dbo].[Shares]
ADD CONSTRAINT [FK_UserShare]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserShare'
CREATE INDEX [IX_FK_UserShare]
ON [dbo].[Shares]
    ([UserId]);
GO

-- Creating foreign key on [MainPostId] in table 'Shares'
ALTER TABLE [dbo].[Shares]
ADD CONSTRAINT [FK_MainPostShare]
    FOREIGN KEY ([MainPostId])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MainPostShare'
CREATE INDEX [IX_FK_MainPostShare]
ON [dbo].[Shares]
    ([MainPostId]);
GO

-- Creating foreign key on [TopicId] in table 'Posts_Reply'
ALTER TABLE [dbo].[Posts_Reply]
ADD CONSTRAINT [FK_TopicReply]
    FOREIGN KEY ([TopicId])
    REFERENCES [dbo].[Topics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TopicReply'
CREATE INDEX [IX_FK_TopicReply]
ON [dbo].[Posts_Reply]
    ([TopicId]);
GO

-- Creating foreign key on [UserId] in table 'FollowPosts'
ALTER TABLE [dbo].[FollowPosts]
ADD CONSTRAINT [FK_UserFollow]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserFollow'
CREATE INDEX [IX_FK_UserFollow]
ON [dbo].[FollowPosts]
    ([UserId]);
GO

-- Creating foreign key on [PostId] in table 'FollowPosts'
ALTER TABLE [dbo].[FollowPosts]
ADD CONSTRAINT [FK_PostFollow]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PostFollow'
CREATE INDEX [IX_FK_PostFollow]
ON [dbo].[FollowPosts]
    ([PostId]);
GO

-- Creating foreign key on [User_Id] in table 'LoginSessions'
ALTER TABLE [dbo].[LoginSessions]
ADD CONSTRAINT [FK_LoginSessionUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LoginSessionUser'
CREATE INDEX [IX_FK_LoginSessionUser]
ON [dbo].[LoginSessions]
    ([User_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Activities'
ALTER TABLE [dbo].[Activities]
ADD CONSTRAINT [FK_ActivityUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ActivityUser'
CREATE INDEX [IX_FK_ActivityUser]
ON [dbo].[Activities]
    ([User_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [FK_ProfileUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileUser'
CREATE INDEX [IX_FK_ProfileUser]
ON [dbo].[Profiles]
    ([User_Id]);
GO

-- Creating foreign key on [Avatar_Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_ImageUser]
    FOREIGN KEY ([Avatar_Id])
    REFERENCES [dbo].[Images]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ImageUser'
CREATE INDEX [IX_FK_ImageUser]
ON [dbo].[Users]
    ([Avatar_Id]);
GO

-- Creating foreign key on [Id] in table 'Posts_MainPost'
ALTER TABLE [dbo].[Posts_MainPost]
ADD CONSTRAINT [FK_MainPost_inherits_Post]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Posts_Blog'
ALTER TABLE [dbo].[Posts_Blog]
ADD CONSTRAINT [FK_Blog_inherits_MainPost]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Posts_Problem'
ALTER TABLE [dbo].[Posts_Problem]
ADD CONSTRAINT [FK_Problem_inherits_MainPost]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Posts_Discussion'
ALTER TABLE [dbo].[Posts_Discussion]
ADD CONSTRAINT [FK_Discussion_inherits_MainPost]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts_MainPost]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Posts_Reply'
ALTER TABLE [dbo].[Posts_Reply]
ADD CONSTRAINT [FK_Reply_inherits_Post]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Posts_Comment'
ALTER TABLE [dbo].[Posts_Comment]
ADD CONSTRAINT [FK_Comment_inherits_Post]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Posts]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO



-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

