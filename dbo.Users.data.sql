SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password], [PhoneNum], [IsAdmin], [FullName], [Discriminator], [GradeAvg], [TeacherId]) VALUES (1, N'string', N'string', N'string', 1, N'string', N'User', NULL, NULL)
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password], [PhoneNum], [IsAdmin], [FullName], [Discriminator], [GradeAvg], [TeacherId]) VALUES (2, N'string', N'string', N'string', 1, N'string', N'User', NULL, NULL)
INSERT INTO [dbo].[Users] ([Id], [UserName], [Password], [PhoneNum], [IsAdmin], [FullName], [Discriminator], [GradeAvg], [TeacherId]) VALUES (3, N'testOne', N'123456789', N'0500000000', 0, N'Test1', N'User', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
DELETE FROM Users