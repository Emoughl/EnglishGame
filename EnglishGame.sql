USE [master]
GO
/****** Object:  Database [EnglishQG]    Script Date: 2/23/2023 6:44:27 AM ******/
CREATE DATABASE [EnglishQG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EnglishQG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\EnglishQG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EnglishQG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\EnglishQG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EnglishQG] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EnglishQG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EnglishQG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EnglishQG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EnglishQG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EnglishQG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EnglishQG] SET ARITHABORT OFF 
GO
ALTER DATABASE [EnglishQG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EnglishQG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EnglishQG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EnglishQG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EnglishQG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EnglishQG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EnglishQG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EnglishQG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EnglishQG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EnglishQG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EnglishQG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EnglishQG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EnglishQG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EnglishQG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EnglishQG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EnglishQG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EnglishQG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EnglishQG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EnglishQG] SET  MULTI_USER 
GO
ALTER DATABASE [EnglishQG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EnglishQG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EnglishQG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EnglishQG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EnglishQG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EnglishQG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EnglishQG] SET QUERY_STORE = OFF
GO
USE [EnglishQG]
GO
/****** Object:  Table [dbo].[answers]    Script Date: 2/23/2023 6:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[answers](
	[id] [int] NOT NULL,
	[question_id] [int] NULL,
	[answer] [nvarchar](50) NULL,
	[is_correct] [tinyint] NULL,
 CONSTRAINT [PK_answers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[questions]    Script Date: 2/23/2023 6:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[questions](
	[id] [int] NOT NULL,
	[subject_id] [int] NULL,
	[question] [nvarchar](50) NULL,
 CONSTRAINT [PK_questions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subjects]    Script Date: 2/23/2023 6:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subjects](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_subjects] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2/23/2023 6:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[HighScore] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[answers]  WITH CHECK ADD  CONSTRAINT [FK_answers_questions] FOREIGN KEY([question_id])
REFERENCES [dbo].[questions] ([id])
GO
ALTER TABLE [dbo].[answers] CHECK CONSTRAINT [FK_answers_questions]
GO
ALTER TABLE [dbo].[questions]  WITH CHECK ADD  CONSTRAINT [FK_questions_subjects] FOREIGN KEY([subject_id])
REFERENCES [dbo].[subjects] ([id])
GO
ALTER TABLE [dbo].[questions] CHECK CONSTRAINT [FK_questions_subjects]
GO
USE [master]
GO
ALTER DATABASE [EnglishQG] SET  READ_WRITE 
GO
