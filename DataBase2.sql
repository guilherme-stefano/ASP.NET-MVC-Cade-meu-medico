USE [master]
GO
/****** Object:  Database [CadeMeuMedicoBD]    Script Date: 30/09/2018 15:50:58 ******/
CREATE DATABASE [CadeMeuMedicoBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CadeMeuMedicoBD', FILENAME = N'D:\arquivos de programas\MSSQL14.MSSQLSERVER\MSSQL\DATA\CadeMeuMedicoBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CadeMeuMedicoBD_log', FILENAME = N'D:\arquivos de programas\MSSQL14.MSSQLSERVER\MSSQL\DATA\CadeMeuMedicoBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CadeMeuMedicoBD] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CadeMeuMedicoBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CadeMeuMedicoBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET RECOVERY FULL 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET  MULTI_USER 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CadeMeuMedicoBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CadeMeuMedicoBD] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CadeMeuMedicoBD', N'ON'
GO
ALTER DATABASE [CadeMeuMedicoBD] SET QUERY_STORE = OFF
GO
USE [CadeMeuMedicoBD]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CadeMeuMedicoBD]
GO
/****** Object:  Table [dbo].[BannersPublicitarios]    Script Date: 30/09/2018 15:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BannersPublicitarios](
	[IDBanner] [bigint] IDENTITY(1,1) NOT NULL,
	[TituloCampanha] [varchar](60) NOT NULL,
	[BannerCampanha] [varchar](200) NOT NULL,
	[LinkBanner] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDBanner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Certificados]    Script Date: 30/09/2018 15:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificados](
	[IDCertificado] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[IDMedico] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cidades]    Script Date: 30/09/2018 15:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cidades](
	[IDCidade] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[IDEstado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 30/09/2018 15:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[IDEspecialidade] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEspecialidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 30/09/2018 15:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[IDEstado] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NULL,
 CONSTRAINT [PK_IDEstado] PRIMARY KEY CLUSTERED 
(
	[IDEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 30/09/2018 15:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[IDMedico] [bigint] IDENTITY(1,1) NOT NULL,
	[CRM] [varchar](30) NOT NULL,
	[Nome] [varchar](80) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[Bairro] [varchar](60) NOT NULL,
	[Email] [varchar](100) NULL,
	[AtendePorConvenio] [bit] NOT NULL,
	[TemClinica] [bit] NOT NULL,
	[WebsiteBlog] [varchar](80) NULL,
	[IDCidade] [int] NOT NULL,
	[IDEspecialidade] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 30/09/2018 15:50:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IDUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](80) NOT NULL,
	[Login] [varchar](30) NOT NULL,
	[Senha] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BannersPublicitarios] ON 

INSERT [dbo].[BannersPublicitarios] ([IDBanner], [TituloCampanha], [BannerCampanha], [LinkBanner]) VALUES (1, N'Campanha Conio', N'logo-conio-cademeumedico.png', N'http://conio.com.br')
INSERT [dbo].[BannersPublicitarios] ([IDBanner], [TituloCampanha], [BannerCampanha], [LinkBanner]) VALUES (2, N'Campanha Casa do Código', N'banner-cdc-cademeumedico.png', N'http://casadocodigo.com.br')
SET IDENTITY_INSERT [dbo].[BannersPublicitarios] OFF
SET IDENTITY_INSERT [dbo].[Cidades] ON 

INSERT [dbo].[Cidades] ([IDCidade], [Nome], [IDEstado]) VALUES (1, N'Blumenaus', NULL)
INSERT [dbo].[Cidades] ([IDCidade], [Nome], [IDEstado]) VALUES (2, N'São José do Rio Preto', NULL)
INSERT [dbo].[Cidades] ([IDCidade], [Nome], [IDEstado]) VALUES (1002, N'Cássia dos Coqueiros', NULL)
INSERT [dbo].[Cidades] ([IDCidade], [Nome], [IDEstado]) VALUES (1003, N'Araçatuba', NULL)
SET IDENTITY_INSERT [dbo].[Cidades] OFF
SET IDENTITY_INSERT [dbo].[Especialidades] ON 

INSERT [dbo].[Especialidades] ([IDEspecialidade], [Nome]) VALUES (1, N'Cardiologista')
INSERT [dbo].[Especialidades] ([IDEspecialidade], [Nome]) VALUES (2, N'Neurologista')
INSERT [dbo].[Especialidades] ([IDEspecialidade], [Nome]) VALUES (1002, N'Girontologiste')
INSERT [dbo].[Especialidades] ([IDEspecialidade], [Nome]) VALUES (1003, N'Azeitonista')
INSERT [dbo].[Especialidades] ([IDEspecialidade], [Nome]) VALUES (1004, N'Testonha')
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
SET IDENTITY_INSERT [dbo].[Medicos] ON 

INSERT [dbo].[Medicos] ([IDMedico], [CRM], [Nome], [Endereco], [Bairro], [Email], [AtendePorConvenio], [TemClinica], [WebsiteBlog], [IDCidade], [IDEspecialidade]) VALUES (1, N'1231111', N'Jeriel', N'123', N'123', N'123@123.com', 1, 0, N'asd', 1, 1)
INSERT [dbo].[Medicos] ([IDMedico], [CRM], [Nome], [Endereco], [Bairro], [Email], [AtendePorConvenio], [TemClinica], [WebsiteBlog], [IDCidade], [IDEspecialidade]) VALUES (2, N'Jambra!', N'''and', N'a', N'Shopping', N'passella@gmail.com', 1, 1, N'passella.blogspot', 1002, 1002)
INSERT [dbo].[Medicos] ([IDMedico], [CRM], [Nome], [Endereco], [Bairro], [Email], [AtendePorConvenio], [TemClinica], [WebsiteBlog], [IDCidade], [IDEspecialidade]) VALUES (3, N'1231', N'1231', N'1231', N'1231', N'1231', 1, 1, N'1231', 1, 1)
INSERT [dbo].[Medicos] ([IDMedico], [CRM], [Nome], [Endereco], [Bairro], [Email], [AtendePorConvenio], [TemClinica], [WebsiteBlog], [IDCidade], [IDEspecialidade]) VALUES (4, N'1231', N'1231', N'1231', N'1231', N'1231', 0, 0, N'1231', 1, 1004)
INSERT [dbo].[Medicos] ([IDMedico], [CRM], [Nome], [Endereco], [Bairro], [Email], [AtendePorConvenio], [TemClinica], [WebsiteBlog], [IDCidade], [IDEspecialidade]) VALUES (5, N'1231', N'1231', N'1231', N'1231', N'1231', 0, 0, NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[Medicos] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IDUsuario], [Nome], [Login], [Senha], [Email]) VALUES (1, N'Administrador', N'admin', N'40BD001563085FC35165329EA1FF5C5ECBDBBEEF', N'admin@cdmm.com')
INSERT [dbo].[Usuarios] ([IDUsuario], [Nome], [Login], [Senha], [Email]) VALUES (2, N'Jerielson', N'Jerielson', N'123mudar', N'123@123.com')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Certificados]  WITH CHECK ADD  CONSTRAINT [FK_Certificado_Medico] FOREIGN KEY([IDMedico])
REFERENCES [dbo].[Medicos] ([IDMedico])
GO
ALTER TABLE [dbo].[Certificados] CHECK CONSTRAINT [FK_Certificado_Medico]
GO
ALTER TABLE [dbo].[Cidades]  WITH CHECK ADD FOREIGN KEY([IDEstado])
REFERENCES [dbo].[Estados] ([IDEstado])
GO
ALTER TABLE [dbo].[Medicos]  WITH CHECK ADD  CONSTRAINT [fk_medicos_cidades] FOREIGN KEY([IDCidade])
REFERENCES [dbo].[Cidades] ([IDCidade])
GO
ALTER TABLE [dbo].[Medicos] CHECK CONSTRAINT [fk_medicos_cidades]
GO
ALTER TABLE [dbo].[Medicos]  WITH CHECK ADD  CONSTRAINT [fk_medicos_especialidades] FOREIGN KEY([IDEspecialidade])
REFERENCES [dbo].[Especialidades] ([IDEspecialidade])
GO
ALTER TABLE [dbo].[Medicos] CHECK CONSTRAINT [fk_medicos_especialidades]
GO
USE [master]
GO
ALTER DATABASE [CadeMeuMedicoBD] SET  READ_WRITE 
GO
