USE [master]
GO
/****** Object:  Database [PRN231_ASM03_AJAX]    Script Date: 23/10/2023 7:50:46 pm ******/
CREATE DATABASE [PRN231_ASM03_AJAX]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRN231_ASM03_AJAX', FILENAME = N'D:\SQL_SERVER\MSSQL15.MSSQLSERVER\MSSQL\DATA\PRN231_ASM03_AJAX.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRN231_ASM03_AJAX_log', FILENAME = N'D:\SQL_SERVER\MSSQL15.MSSQLSERVER\MSSQL\DATA\PRN231_ASM03_AJAX_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRN231_ASM03_AJAX].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET RECOVERY FULL 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET  MULTI_USER 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PRN231_ASM03_AJAX', N'ON'
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET QUERY_STORE = OFF
GO
USE [PRN231_ASM03_AJAX]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](450) NULL,
	[OrderDate] [date] NOT NULL,
	[RequireDate] [date] NULL,
	[ShippedDate] [date] NULL,
	[Freight] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 23/10/2023 7:50:46 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Weight] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
	[UnitInStock] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231023045034_new', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231023045302_newMigration', N'5.0.17')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c745c069-1655-4134-ab86-203edbc5c4d0', N'Admin', N'ADMIN', N'admin')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', N'c745c069-1655-4134-ab86-203edbc5c4d0')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', N'Thanh@gmail.com', N'THANH@GMAIL.COM', N'Thanh@gmail.com', N'THANH@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEHzxZmRKYQ5LkVPooYTfQLASXIypOpXJqu9AbDcvmialCYPbeEa1oKLPglypxIo5vQ==', N'BFEH7Y6RPGUYOMBMH2APG72CF67NFI2L', N'ed525e41-267b-4d32-bf32-29ad97da80f4', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (5, 11111)
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (6, 22222)
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (7, 33333)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (2, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), 999)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (3, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-22' AS Date), CAST(N'2023-10-22' AS Date), CAST(N'2023-10-22' AS Date), 200)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (4, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), 200)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (5, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), 666)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (6, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), 655)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (7, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), 654)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (8, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), 31)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (9, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-09-25' AS Date), CAST(N'2023-10-02' AS Date), CAST(N'2023-09-27' AS Date), 90)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (10, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-09-26' AS Date), CAST(N'2023-09-26' AS Date), CAST(N'2023-09-26' AS Date), 454)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (13, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-03' AS Date), CAST(N'2023-09-27' AS Date), 678)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (14, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-03' AS Date), CAST(N'2023-09-27' AS Date), 6789)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (15, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-02' AS Date), CAST(N'2023-10-03' AS Date), 412)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (16, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-09-26' AS Date), CAST(N'2023-09-27' AS Date), 413)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (17, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), CAST(N'2023-10-23' AS Date), 98765)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequireDate], [ShippedDate], [Freight]) VALUES (18, N'26103d9a-58a2-4d0b-ab0c-d5d81bd9fa0b', CAST(N'2023-10-23' AS Date), CAST(N'2023-09-26' AS Date), CAST(N'2023-10-26' AS Date), 8888)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 1, 100, 10, 5000)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 2, 50, 20, 4000)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (3, 1, 100, 5, 2500)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (1, 5, N'Product 01', 100, 100, 150)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (2, 6, N'Product 02', 200, 200, 300)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 23/10/2023 7:50:46 pm ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 23/10/2023 7:50:46 pm ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 23/10/2023 7:50:46 pm ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 23/10/2023 7:50:46 pm ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 23/10/2023 7:50:46 pm ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 23/10/2023 7:50:46 pm ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 23/10/2023 7:50:46 pm ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_AspNetUsers] FOREIGN KEY([MemberId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_AspNetUsers]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [PRN231_ASM03_AJAX] SET  READ_WRITE 
GO
