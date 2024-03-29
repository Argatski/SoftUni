USE [Schooll]
GO

/****** Object:  Table [dbo].[Peaks]    Script Date: 10/1/2023 5:34:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Peaks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[MountainId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Peaks]  WITH CHECK ADD  CONSTRAINT [FK_Peaks_MountainsId] FOREIGN KEY([MountainId])
REFERENCES [dbo].[Mountains] ([Id])
GO

ALTER TABLE [dbo].[Peaks] CHECK CONSTRAINT [FK_Peaks_MountainsId]
GO


