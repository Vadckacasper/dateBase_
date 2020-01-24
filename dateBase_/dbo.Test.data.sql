SET IDENTITY_INSERT [dbo].[Test] ON
INSERT INTO [dbo].[Test] ([Id], [Name], [Work], [date]) VALUES (1, N'Вадим                                             ', N'База данных                   ', N'23.01.20  ')
INSERT INTO [dbo].[Test] ([Id], [Name], [Work], [date]) VALUES (2, N'Дима                                              ', N'Лох                           ', N'Всегда    ')
INSERT INTO [dbo].[Test] ([Id], [Name], [Work], [date]) VALUES (3, N'Максим                                            ', N'Математика                    ', N'23.01.2020')
INSERT INTO [dbo].[Test] ([Id], [Name], [Work], [date]) VALUES (4, N'Антон                                             ', N'Геометрия                     ', N'20,05,2019')
SET IDENTITY_INSERT [dbo].[Test] OFF
