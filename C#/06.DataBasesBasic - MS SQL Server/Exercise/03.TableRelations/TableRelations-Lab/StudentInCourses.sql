USE [Schooll]
GO

/****** Object:  Table [dbo].[StudentInCourses]    Script Date: 10/1/2023 5:34:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentInCourses](
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
	[Mark] [tinyint] NULL,
 CONSTRAINT [PK_StudentInCourses] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


