USE [master]
GO
/****** Object:  Database [DGTdb]    Script Date: 12/02/2019 17:10:37 ******/
CREATE DATABASE [DGTdb]
 CONTAINMENT = NONE
GO
ALTER DATABASE [DGTdb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DGTdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DGTdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DGTdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DGTdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DGTdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DGTdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [DGTdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DGTdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DGTdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DGTdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DGTdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DGTdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DGTdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DGTdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DGTdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DGTdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DGTdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DGTdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DGTdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DGTdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DGTdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DGTdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DGTdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DGTdb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DGTdb] SET  MULTI_USER 
GO
ALTER DATABASE [DGTdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DGTdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DGTdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DGTdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DGTdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DGTdb] SET QUERY_STORE = OFF
GO
USE [DGTdb]
GO
/****** Object:  Table [dbo].[conductor]    Script Date: 12/02/2019 17:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[conductor](
	[conductor_id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [nvarchar](10) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[apellidos] [nvarchar](30) NOT NULL,
	[puntos] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[conductor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[infraccion]    Script Date: 12/02/2019 17:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[infraccion](
	[infraccion_id] [int] IDENTITY(1,1) NOT NULL,
	[identificador] [nvarchar](10) NOT NULL,
	[descripcion] [nvarchar](250) NOT NULL,
	[puntos_descuenta] [tinyint] NOT NULL,
 CONSTRAINT [PK_infraccion] PRIMARY KEY CLUSTERED 
(
	[infraccion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[infraccion_vehiculo]    Script Date: 12/02/2019 17:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[infraccion_vehiculo](
	[infraccion_vehiculo_id] [int] IDENTITY(1,1) NOT NULL,
	[infraccion_id] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[conductor_id] [int] NOT NULL,
	[vehiculo_id] [int] NOT NULL,
 CONSTRAINT [PK_infraccion_vehiculo] PRIMARY KEY CLUSTERED 
(
	[infraccion_vehiculo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehiculo]    Script Date: 12/02/2019 17:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehiculo](
	[vehiculo_id] [int] IDENTITY(1,1) NOT NULL,
	[matricula] [nvarchar](15) NOT NULL,
	[marca] [nvarchar](25) NOT NULL,
	[modelo] [nvarchar](25) NOT NULL,
	[conductor_id] [int] NOT NULL,
 CONSTRAINT [PK_vehiculo] PRIMARY KEY CLUSTERED 
(
	[vehiculo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehiculo_conductor]    Script Date: 12/02/2019 17:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehiculo_conductor](
	[vehiculo_id] [int] NOT NULL,
	[conductor_id] [int] NOT NULL,
 CONSTRAINT [PK_vehiculo_conductor] PRIMARY KEY CLUSTERED 
(
	[vehiculo_id] ASC,
	[conductor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[infraccion_vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_infraccion_vehiculo_conductor] FOREIGN KEY([conductor_id])
REFERENCES [dbo].[conductor] ([conductor_id])
GO
ALTER TABLE [dbo].[infraccion_vehiculo] CHECK CONSTRAINT [FK_infraccion_vehiculo_conductor]
GO
ALTER TABLE [dbo].[infraccion_vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_infraccion_vehiculo_infraccion] FOREIGN KEY([infraccion_id])
REFERENCES [dbo].[infraccion] ([infraccion_id])
GO
ALTER TABLE [dbo].[infraccion_vehiculo] CHECK CONSTRAINT [FK_infraccion_vehiculo_infraccion]
GO
ALTER TABLE [dbo].[infraccion_vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_infraccion_vehiculo_vehiculo] FOREIGN KEY([vehiculo_id])
REFERENCES [dbo].[vehiculo] ([vehiculo_id])
GO
ALTER TABLE [dbo].[infraccion_vehiculo] CHECK CONSTRAINT [FK_infraccion_vehiculo_vehiculo]
GO
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_conductor] FOREIGN KEY([conductor_id])
REFERENCES [dbo].[conductor] ([conductor_id])
GO
ALTER TABLE [dbo].[vehiculo] CHECK CONSTRAINT [FK_vehiculo_conductor]
GO
ALTER TABLE [dbo].[vehiculo_conductor]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_conductor_conductor] FOREIGN KEY([conductor_id])
REFERENCES [dbo].[conductor] ([conductor_id])
GO
ALTER TABLE [dbo].[vehiculo_conductor] CHECK CONSTRAINT [FK_vehiculo_conductor_conductor]
GO
ALTER TABLE [dbo].[vehiculo_conductor]  WITH CHECK ADD  CONSTRAINT [FK_vehiculo_conductor_vehiculo] FOREIGN KEY([vehiculo_id])
REFERENCES [dbo].[vehiculo] ([vehiculo_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[vehiculo_conductor] CHECK CONSTRAINT [FK_vehiculo_conductor_vehiculo]
GO
USE [master]
GO
ALTER DATABASE [DGTdb] SET  READ_WRITE 
GO
