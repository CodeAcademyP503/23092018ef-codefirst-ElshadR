USE [CodeFirstDepoziteDb]
GO
/****** Object:  Schema [depozite]    Script Date: 9/26/2018 7:21:26 PM ******/
CREATE SCHEMA [depozite]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 9/26/2018 7:21:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [depozite].[Credits]    Script Date: 9/26/2018 7:21:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [depozite].[Credits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[OpenDatetime] [datetime] NOT NULL,
	[CloseDatetime] [datetime] NULL,
	[Person_Id] [int] NOT NULL,
	[Person_Id1] [int] NULL,
 CONSTRAINT [PK_dbo.Credits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [depozite].[People]    Script Date: 9/26/2018 7:21:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [depozite].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](90) NOT NULL,
	[Surname] [nvarchar](90) NOT NULL,
	[PasportNumber] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_depozite.People] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [depozite].[Credits]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Credits_depozite.People_Person_Id1] FOREIGN KEY([Person_Id1])
REFERENCES [depozite].[People] ([Id])
GO
ALTER TABLE [depozite].[Credits] CHECK CONSTRAINT [FK_dbo.Credits_depozite.People_Person_Id1]
GO
