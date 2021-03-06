USE [master]
GO
/****** Object:  Database [TiendaMusical]    Script Date: 25/11/2020 22:55:41 ******/
CREATE DATABASE [TiendaMusical]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TiendaMusical}', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TiendaMusical}.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TiendaMusical}_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TiendaMusical}_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TiendaMusical] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TiendaMusical].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TiendaMusical] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TiendaMusical] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TiendaMusical] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TiendaMusical] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TiendaMusical] SET ARITHABORT OFF 
GO
ALTER DATABASE [TiendaMusical] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TiendaMusical] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TiendaMusical] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TiendaMusical] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TiendaMusical] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TiendaMusical] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TiendaMusical] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TiendaMusical] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TiendaMusical] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TiendaMusical] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TiendaMusical] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TiendaMusical] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TiendaMusical] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TiendaMusical] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TiendaMusical] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TiendaMusical] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TiendaMusical] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TiendaMusical] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TiendaMusical] SET  MULTI_USER 
GO
ALTER DATABASE [TiendaMusical] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TiendaMusical] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TiendaMusical] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TiendaMusical] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TiendaMusical] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TiendaMusical] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TiendaMusical] SET QUERY_STORE = OFF
GO
USE [TiendaMusical]
GO
/****** Object:  Table [dbo].[Bajos]    Script Date: 25/11/2020 22:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bajos](
	[numSerie] [varchar](50) NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NULL,
	[precio] [float] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Bajos] PRIMARY KEY CLUSTERED 
(
	[numSerie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guitarras]    Script Date: 25/11/2020 22:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guitarras](
	[numSerie] [varchar](50) NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NULL,
	[precio] [float] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Guitarras] PRIMARY KEY CLUSTERED 
(
	[numSerie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Bajos] ([numSerie], [marca], [modelo], [precio], [tipo]) VALUES (N'F29331991', N'Fender', N'P-Bass', 200000, N'Pasivo')
INSERT [dbo].[Bajos] ([numSerie], [marca], [modelo], [precio], [tipo]) VALUES (N'X01238412', N'Gibson', N'Hummingbird', 300000, N'Activo')
GO
INSERT [dbo].[Guitarras] ([numSerie], [marca], [modelo], [precio], [tipo]) VALUES (N'A12124828', N'Fender', N'Stratocaster', 850000, N'Electrica')
INSERT [dbo].[Guitarras] ([numSerie], [marca], [modelo], [precio], [tipo]) VALUES (N'G12356405423', N'Gibson', N'Les Paul', 300000, N'Electrica')
INSERT [dbo].[Guitarras] ([numSerie], [marca], [modelo], [precio], [tipo]) VALUES (N'ISSJQ415', N'Ibanez', N'EC100', 70000, N'Acustica')
GO
USE [master]
GO
ALTER DATABASE [TiendaMusical] SET  READ_WRITE 
GO
