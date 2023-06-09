USE [Kursv]
GO
/****** Object:  Table [dbo].[Группа]    Script Date: 30.04.2023 22:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Группа](
	[КодГруппы] [int] NOT NULL,
	[Номер] [varchar](50) NULL,
	[КодСпециальности] [int] NOT NULL,
 CONSTRAINT [XPKГруппа] PRIMARY KEY CLUSTERED 
(
	[КодГруппы] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Дисциплина]    Script Date: 30.04.2023 22:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Дисциплина](
	[КодДисциплины] [int] NOT NULL,
	[Название] [varchar](100) NULL,
 CONSTRAINT [XPKДисциплина] PRIMARY KEY CLUSTERED 
(
	[КодДисциплины] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Занятие]    Script Date: 30.04.2023 22:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Занятие](
	[КодГруппы] [int] NOT NULL,
	[КодПреподавателя] [int] NOT NULL,
	[КодДисциплины] [int] NOT NULL,
	[ДатаЗанятия] [date] NULL,
 CONSTRAINT [XPKГруппа_Преподаватель] PRIMARY KEY CLUSTERED 
(
	[КодГруппы] ASC,
	[КодПреподавателя] ASC,
	[КодДисциплины] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Оценки]    Script Date: 30.04.2023 22:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Оценки](
	[КодПреподавателя] [int] NOT NULL,
	[КодДисциплины] [int] NOT NULL,
	[КодСтудента] [int] NOT NULL,
	[КодОценки] [int] NOT NULL,
	[КритерииОценки] [varchar](50) NULL,
	[Оценка] [varchar](20) NULL,
	[ДатаОценки] [date] NULL,
 CONSTRAINT [XPKПреподаватель_Дисциплина] PRIMARY KEY CLUSTERED 
(
	[КодОценки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Преподаватель]    Script Date: 30.04.2023 22:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Преподаватель](
	[КодПреподавателя] [int] NOT NULL,
	[Фамилия] [varchar](50) NULL,
	[Имя] [varchar](50) NULL,
	[Отчество] [varchar](50) NULL,
	[ДатаР] [date] NULL,
 CONSTRAINT [XPKПреподаватель] PRIMARY KEY CLUSTERED 
(
	[КодПреподавателя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Специальность]    Script Date: 30.04.2023 22:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Специальность](
	[КодСпециальности] [int] NOT NULL,
	[Название] [varchar](150) NULL,
 CONSTRAINT [XPKСпециальность] PRIMARY KEY CLUSTERED 
(
	[КодСпециальности] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Студент]    Script Date: 30.04.2023 22:56:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Студент](
	[КодСтудента] [int] NOT NULL,
	[Фамилия] [varchar](50) NULL,
	[Имя] [varchar](50) NULL,
	[Отчество] [varchar](50) NULL,
	[ДатаР] [date] NULL,
	[КодГруппы] [int] NOT NULL,
 CONSTRAINT [XPKСтудент] PRIMARY KEY CLUSTERED 
(
	[КодСтудента] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Группа]  WITH CHECK ADD  CONSTRAINT [R_2] FOREIGN KEY([КодСпециальности])
REFERENCES [dbo].[Специальность] ([КодСпециальности])
GO
ALTER TABLE [dbo].[Группа] CHECK CONSTRAINT [R_2]
GO
ALTER TABLE [dbo].[Занятие]  WITH CHECK ADD  CONSTRAINT [R_21] FOREIGN KEY([КодДисциплины])
REFERENCES [dbo].[Дисциплина] ([КодДисциплины])
GO
ALTER TABLE [dbo].[Занятие] CHECK CONSTRAINT [R_21]
GO
ALTER TABLE [dbo].[Занятие]  WITH CHECK ADD  CONSTRAINT [R_7] FOREIGN KEY([КодГруппы])
REFERENCES [dbo].[Группа] ([КодГруппы])
GO
ALTER TABLE [dbo].[Занятие] CHECK CONSTRAINT [R_7]
GO
ALTER TABLE [dbo].[Занятие]  WITH CHECK ADD  CONSTRAINT [R_8] FOREIGN KEY([КодПреподавателя])
REFERENCES [dbo].[Преподаватель] ([КодПреподавателя])
GO
ALTER TABLE [dbo].[Занятие] CHECK CONSTRAINT [R_8]
GO
ALTER TABLE [dbo].[Оценки]  WITH CHECK ADD  CONSTRAINT [R_19] FOREIGN KEY([КодПреподавателя])
REFERENCES [dbo].[Преподаватель] ([КодПреподавателя])
GO
ALTER TABLE [dbo].[Оценки] CHECK CONSTRAINT [R_19]
GO
ALTER TABLE [dbo].[Оценки]  WITH CHECK ADD  CONSTRAINT [R_20] FOREIGN KEY([КодДисциплины])
REFERENCES [dbo].[Дисциплина] ([КодДисциплины])
GO
ALTER TABLE [dbo].[Оценки] CHECK CONSTRAINT [R_20]
GO
ALTER TABLE [dbo].[Оценки]  WITH CHECK ADD  CONSTRAINT [R_22] FOREIGN KEY([КодСтудента])
REFERENCES [dbo].[Студент] ([КодСтудента])
GO
ALTER TABLE [dbo].[Оценки] CHECK CONSTRAINT [R_22]
GO
ALTER TABLE [dbo].[Студент]  WITH CHECK ADD  CONSTRAINT [R_1] FOREIGN KEY([КодГруппы])
REFERENCES [dbo].[Группа] ([КодГруппы])
GO
ALTER TABLE [dbo].[Студент] CHECK CONSTRAINT [R_1]
GO
