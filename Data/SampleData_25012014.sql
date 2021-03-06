USE [MathHubDB]
GO

/****** Object:  Table [dbo].[StringResources]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Conversations]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Images]    Script Date: 01/26/2014 00:33:35 ******/
SET IDENTITY_INSERT [dbo].[Images] ON
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (1, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (2, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (3, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (4, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (5, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (6, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (7, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (8, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (9, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (10, N'123123', N'ASD')
INSERT [dbo].[Images] ([Id], [Url], [Description]) VALUES (11, N'123123', N'ASD')
SET IDENTITY_INSERT [dbo].[Images] OFF
/****** Object:  Table [dbo].[ReportReasons]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[ScoreRules]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[ScorePermissions]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Roles]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Users]    Script Date: 01/26/2014 00:33:35 ******/
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (1, N'Đinh Quang Trung 1', 1, 1)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (2, N'Đinh Quang Trung 2', 1, 2)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (3, N'Đinh Quang Trung 3', 1, 3)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (4, N'Đinh Quang Trung 4', 1, 4)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (5, N'Đinh Quang Trung 5', 1, 5)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (6, N'Đinh Quang Trung 6', 1, 6)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (7, N'Đinh Quang Trung 7', 1, 7)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (8, N'Đinh Quang Trung 123',  1, 8)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (9, N'Đinh Quang Trung 9',  1, 9)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (10, N'Thanh Hai', 1, 4)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (11, N'Đinh Quang Trung 1',  1, 10)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (12, N'Đinh Quang Trung 1',  1, 11)
INSERT [dbo].[Users] ([Id], [Username], [Score], [Avatar_Id]) VALUES (13, N'ADB', 23, 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[Functions]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Tags]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Subscriptions]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Attendances]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Assessments]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Activities]    Script Date: 01/26/2014 00:33:35 ******/
SET IDENTITY_INSERT [dbo].[Activities] ON
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (1, CAST(0x0762FC094D8919380B AS DateTime2), CAST(0x0762FC094D8919380B AS DateTime2), CAST(0x0762FC094D8919380B AS DateTime2), CAST(0x0762FC094D8919380B AS DateTime2), CAST(0x0762FC094D8919380B AS DateTime2), N'asd', CAST(0x0762FC094D8919380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 1)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (2, CAST(0x070F4663508919380B AS DateTime2), CAST(0x070F4663508919380B AS DateTime2), CAST(0x070F4663508919380B AS DateTime2), CAST(0x070F4663508919380B AS DateTime2), CAST(0x070F4663508919380B AS DateTime2), N'asd', CAST(0x070F4663508919380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 2)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (3, CAST(0x076D2509518919380B AS DateTime2), CAST(0x076D2509518919380B AS DateTime2), CAST(0x076D2509518919380B AS DateTime2), CAST(0x076D2509518919380B AS DateTime2), CAST(0x076D2509518919380B AS DateTime2), N'asd', CAST(0x076D2509518919380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 3)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (4, CAST(0x078AC66E518919380B AS DateTime2), CAST(0x078AC66E518919380B AS DateTime2), CAST(0x078AC66E518919380B AS DateTime2), CAST(0x078AC66E518919380B AS DateTime2), CAST(0x078AC66E518919380B AS DateTime2), N'asd', CAST(0x078AC66E518919380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 4)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (5, CAST(0x07428CB9518919380B AS DateTime2), CAST(0x07428CB9518919380B AS DateTime2), CAST(0x07428CB9518919380B AS DateTime2), CAST(0x07428CB9518919380B AS DateTime2), CAST(0x07428CB9518919380B AS DateTime2), N'asd', CAST(0x07428CB9518919380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 5)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (6, CAST(0x07A0D805528919380B AS DateTime2), CAST(0x07A0D805528919380B AS DateTime2), CAST(0x07A0D805528919380B AS DateTime2), CAST(0x07A0D805528919380B AS DateTime2), CAST(0x07A0D805528919380B AS DateTime2), N'asd', CAST(0x07A0D805528919380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 6)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (7, CAST(0x07E58C4F528919380B AS DateTime2), CAST(0x07E58C4F528919380B AS DateTime2), CAST(0x07E58C4F528919380B AS DateTime2), CAST(0x07E58C4F528919380B AS DateTime2), CAST(0x07E58C4F528919380B AS DateTime2), N'asd', CAST(0x07E58C4F528919380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 7)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (8, CAST(0x07003D9B528919380B AS DateTime2), CAST(0x07003D9B528919380B AS DateTime2), CAST(0x07003D9B528919380B AS DateTime2), CAST(0x07003D9B528919380B AS DateTime2), CAST(0x07003D9B528919380B AS DateTime2), N'asd', CAST(0x07003D9B528919380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 8)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (9, CAST(0x0702D8DB538919380B AS DateTime2), CAST(0x0702D8DB538919380B AS DateTime2), CAST(0x0702D8DB538919380B AS DateTime2), CAST(0x0702D8DB538919380B AS DateTime2), CAST(0x0702D8DB538919380B AS DateTime2), N'asd', CAST(0x0702D8DB538919380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 9)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (10, CAST(0x077389A3F59319380B AS DateTime2), CAST(0x077389A3F59319380B AS DateTime2), CAST(0x077389A3F59319380B AS DateTime2), CAST(0x077389A3F59319380B AS DateTime2), CAST(0x077389A3F59319380B AS DateTime2), N'asd', CAST(0x077389A3F59319380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 11)
INSERT [dbo].[Activities] ([Id], [LastSeenInvition], [LastSeenSubcription], [LastSeenReceivedMedal], [LastPermissionGain], [LastSeenPermissionGain], [NewPasswordKey], [NewPasswordRequestedDate], [NewEmail], [NewEmailKey], [LastLogin], [LastIp], [User_Id]) VALUES (11, CAST(0x079FF505A1BF19380B AS DateTime2), CAST(0x079FF505A1BF19380B AS DateTime2), CAST(0x079FF505A1BF19380B AS DateTime2), CAST(0x079FF505A1BF19380B AS DateTime2), CAST(0x079FF505A1BF19380B AS DateTime2), N'asd', CAST(0x079FF505A1BF19380B AS DateTime2), N'asd', N'asd', N'asd', N'asd', 12)
SET IDENTITY_INSERT [dbo].[Activities] OFF
/****** Object:  Table [dbo].[Categories]    Script Date: 01/26/2014 00:33:35 ******/
SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT [dbo].[Categories] ([Id], [Name], [Description], [DateCreated], [CreatorId], [ParentCategoryId]) VALUES (8, N'Category 7', N'12/12/12', CAST(0x07000000000080360B AS DateTime2), 4, NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [DateCreated], [CreatorId], [ParentCategoryId]) VALUES (9, N'Category 8', N'12/12/12', CAST(0x07000000000080360B AS DateTime2), 4, NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [DateCreated], [CreatorId], [ParentCategoryId]) VALUES (10, N'Category 9', N'12/12/12', CAST(0x07000000000080360B AS DateTime2), 4, NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [DateCreated], [CreatorId], [ParentCategoryId]) VALUES (11, N'Category 10', N'12/12/12', CAST(0x07000000000080360B AS DateTime2), 5, NULL)
INSERT [dbo].[Categories] ([Id], [Name], [Description], [DateCreated], [CreatorId], [ParentCategoryId]) VALUES (12, N'Category 11', N'12/12/12', CAST(0x07000000000080360B AS DateTime2), 5, NULL)
SET IDENTITY_INSERT [dbo].[Categories] OFF
/****** Object:  Table [dbo].[Posts]    Script Date: 01/26/2014 00:33:35 ******/
SET IDENTITY_INSERT [dbo].[Posts] ON
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (1, N'This is Blog 1', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 1)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (2, N'This is Blog 2', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 2)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (3, N'This is Blog 3', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 2)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (4, N'This is Blog 4', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 3)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (5, N'This is Blog 5', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 3)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (6, N'This is Blog 6', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 1)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (7, N'Comment 1', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 3)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (8, N'Comment 2', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 3)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (9, N'Comment 3', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 2)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (10, N'Comment 4', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 2)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (11, N'Comment 5', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 4)
INSERT [dbo].[Posts] ([Id], [Content], [DateCreated], [DateModified], [UserId]) VALUES (12, N'Comment 5', CAST(0x07000000000080360B AS DateTime2), CAST(0x07000000000080360B AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Posts] OFF
/****** Object:  Table [dbo].[Permissions]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[LoginSessions]    Script Date: 01/26/2014 00:33:35 ******/
SET IDENTITY_INSERT [dbo].[LoginSessions] ON
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (1, N'333', N'123', N'asd', CAST(0x0772230A4D8919380B AS DateTime2), 1)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (2, N'333', N'123', N'asd', CAST(0x070F4663508919380B AS DateTime2), 2)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (3, N'333', N'123', N'asd', CAST(0x076D2509518919380B AS DateTime2), 3)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (4, N'333', N'123', N'asd', CAST(0x078AC66E518919380B AS DateTime2), 4)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (5, N'333', N'123', N'asd', CAST(0x07428CB9518919380B AS DateTime2), 5)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (6, N'333', N'123', N'asd', CAST(0x07A0D805528919380B AS DateTime2), 6)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (7, N'333', N'123', N'asd', CAST(0x07E58C4F528919380B AS DateTime2), 7)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (8, N'333', N'123', N'asd', CAST(0x07003D9B528919380B AS DateTime2), 8)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (9, N'333', N'123', N'asd', CAST(0x0702D8DB538919380B AS DateTime2), 9)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (10, N'333', N'123', N'asd', CAST(0x0784B0A3F59319380B AS DateTime2), 11)
INSERT [dbo].[LoginSessions] ([Id], [SessionKey], [IpAddress], [Browser], [DateCreated], [User_Id]) VALUES (11, N'333', N'123', N'asd', CAST(0x079FF505A1BF19380B AS DateTime2), 12)
SET IDENTITY_INSERT [dbo].[LoginSessions] OFF
/****** Object:  Table [dbo].[Profiles]    Script Date: 01/26/2014 00:33:35 ******/
SET IDENTITY_INSERT [dbo].[Profiles] ON
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (1, N'Trung Đinh', NULL, CAST(0x0762FC094D8919380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 1)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (2, N'Trung Đinh', NULL, CAST(0x070F4663508919380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 2)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (3, N'Trung Đinh', NULL, CAST(0x076D2509518919380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 3)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (4, N'Trung Đinh', NULL, CAST(0x078AC66E518919380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 4)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (5, N'Trung Đinh', NULL, CAST(0x07428CB9518919380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 5)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (6, N'Trung Đinh', NULL, CAST(0x07A0D805528919380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 6)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (7, N'Trung Đinh', NULL, CAST(0x07E58C4F528919380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 7)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (8, N'Trung Đinh', NULL, CAST(0x07003D9B528919380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 8)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (9, N'Trung Đinh', NULL, CAST(0x0702D8DB538919380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 9)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (10, N'Trung Đinh', NULL, CAST(0x077389A3F59319380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 11)
INSERT [dbo].[Profiles] ([Id], [FullName], [School], [Birthday], [Website], [Location], [Facebook], [Summary], [View], [User_Id]) VALUES (11, N'Trung Đinh', NULL, CAST(0x079FF505A1BF19380B AS DateTime2), NULL, NULL, NULL, NULL, 1, 12)
SET IDENTITY_INSERT [dbo].[Profiles] OFF
/****** Object:  Table [dbo].[Topics]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[TopicEnrollments]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Messages]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Medals]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Posts_MainPost]    Script Date: 01/26/2014 00:33:35 ******/
INSERT [dbo].[Posts_MainPost] ([Title], [Id]) VALUES (N'Problem 1', 1)
INSERT [dbo].[Posts_MainPost] ([Title], [Id]) VALUES (N'Problem 2', 2)
INSERT [dbo].[Posts_MainPost] ([Title], [Id]) VALUES (N'Problem 3', 3)
INSERT [dbo].[Posts_MainPost] ([Title], [Id]) VALUES (N'Problem 4', 4)
INSERT [dbo].[Posts_MainPost] ([Title], [Id]) VALUES (N'Problem 5', 5)
INSERT [dbo].[Posts_MainPost] ([Title], [Id]) VALUES (N'Problem 6', 6)
/****** Object:  Table [dbo].[FollowPosts]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[FavoriteTags]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Reports]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Votes]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[ViewHits]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Shares]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[FavoritePosts]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Posts_Discussion]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[PostTags]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Posts_Reply]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Posts_Problem]    Script Date: 01/26/2014 00:33:35 ******/
INSERT [dbo].[Posts_Problem] ([Id]) VALUES (2)
INSERT [dbo].[Posts_Problem] ([Id]) VALUES (3)
INSERT [dbo].[Posts_Problem] ([Id]) VALUES (4)
INSERT [dbo].[Posts_Problem] ([Id]) VALUES (5)
INSERT [dbo].[Posts_Problem] ([Id]) VALUES (6)
/****** Object:  Table [dbo].[Rewards]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Posts_Blog]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Invitations]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[Posts_Comment]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[DiscusstionProblems]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[BlogProblems]    Script Date: 01/26/2014 00:33:35 ******/
/****** Object:  Table [dbo].[BlogInTopics]    Script Date: 01/26/2014 00:33:35 ******/
