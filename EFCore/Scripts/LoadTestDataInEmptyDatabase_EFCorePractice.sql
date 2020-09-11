USE [EFCorePractice]
GO
INSERT [dbo].[Questions] ([QuestionId], [QuestionText], [SoftDeleted], [MultiAnswer], [Rating], [Scope]) VALUES (1, N'Koliko je 5!', 0, 0, 0, 0)
GO
INSERT [dbo].[Questions] ([QuestionId], [QuestionText], [SoftDeleted], [MultiAnswer], [Rating], [Scope]) VALUES (2, N'Koliko je presjecnih elipticnih povrsina u znaku Olimpijskih igara?', 1, 0, 0, 0)
GO
INSERT [dbo].[Questions] ([QuestionId], [QuestionText], [SoftDeleted], [MultiAnswer], [Rating], [Scope]) VALUES (3, N'Ako je prvi januar srijeda, koji dan ce biti Bozic u januaru iste te godine?', 0, 0, 0, 0)
GO
INSERT [dbo].[Answers] ([AnswerId], [AnswerText], [IsCorrect], [Order], [QuestionId]) VALUES (1, N'120', 1, 1, 1)
GO
INSERT [dbo].[Answers] ([AnswerId], [AnswerText], [IsCorrect], [Order], [QuestionId]) VALUES (2, N'130', 0, 2, 1)
GO
INSERT [dbo].[Answers] ([AnswerId], [AnswerText], [IsCorrect], [Order], [QuestionId]) VALUES (3, N'140', 0, 3, 1)
GO
INSERT [dbo].[Answers] ([AnswerId], [AnswerText], [IsCorrect], [Order], [QuestionId]) VALUES (4, N'3', 0, 1, 2)
GO
INSERT [dbo].[Answers] ([AnswerId], [AnswerText], [IsCorrect], [Order], [QuestionId]) VALUES (5, N'4', 1, 2, 2)
GO
INSERT [dbo].[Answers] ([AnswerId], [AnswerText], [IsCorrect], [Order], [QuestionId]) VALUES (6, N'2', 0, 3, 2)
GO
INSERT [dbo].[Answers] ([AnswerId], [AnswerText], [IsCorrect], [Order], [QuestionId]) VALUES (7, N'Utorak', 1, 1, 3)
GO
INSERT [dbo].[Answers] ([AnswerId], [AnswerText], [IsCorrect], [Order], [QuestionId]) VALUES (8, N'Srijeda', 0, 2, 3)
GO
INSERT [dbo].[Answers] ([AnswerId], [AnswerText], [IsCorrect], [Order], [QuestionId]) VALUES (9, N'Ponedeljak', 0, 3, 3)
GO
INSERT [dbo].[Explanations] ([ExplanationId], [ExplanationText], [QuestionId]) VALUES (1, N'Jedonstavno pomnozite 1*2*3*4*5 = 120', 1)
GO
INSERT [dbo].[Explanations] ([ExplanationId], [ExplanationText], [QuestionId]) VALUES (2, N'Na presjeku gornja tri i donja dva kruga su cetiri elipticne povrsine.', 2)
GO
INSERT [dbo].[Explanations] ([ExplanationId], [ExplanationText], [QuestionId]) VALUES (3, N'Bozic je 7 mi dan u mjesecu. Sledeca srijeda je 8 mi dan u mjesecu', 3)
GO
--INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200910091225_InitialMigration', N'3.1.8')
--GO
--INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200910132010_AddCompositePrimaryKey_TableAnswers', N'3.1.8')
--GO
--INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200910140426_Add_EnumsForQuestionScopeAndQuestionRating_Entities_Test_QuestionTest', N'3.1.8')
--GO
--INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200910140809_Add_Entities_Test_QuestionTest', N'3.1.8')
--GO
