
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 02/08/2014 12:35:45
-- Generated from EDMX file: G:\Github\MathHub\Code\MathHub\MathHub.Entity\Entity\MathHubModel.edmx
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
-- Script has ended
-- --------------------------------------------------



GO
