USE [master]
GO
/****** Object:  Database [JulieDB]    Script Date: 27-12-2023 4.27.28 PM ******/
CREATE DATABASE [JulieDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JulieDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\JulieDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JulieDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\JulieDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [JulieDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JulieDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JulieDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JulieDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JulieDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JulieDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JulieDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [JulieDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JulieDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JulieDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JulieDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JulieDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JulieDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JulieDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JulieDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JulieDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JulieDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JulieDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JulieDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JulieDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JulieDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JulieDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JulieDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JulieDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JulieDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JulieDB] SET  MULTI_USER 
GO
ALTER DATABASE [JulieDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JulieDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JulieDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JulieDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JulieDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JulieDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [JulieDB] SET QUERY_STORE = OFF
GO
USE [JulieDB]
GO
/****** Object:  Table [dbo].[tbl_TItemMaster]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TItemMaster](
	[TItemId] [int] IDENTITY(1,1) NOT NULL,
	[TItemCode] [varchar](20) NULL,
	[BarCode] [varchar](50) NULL,
	[TItemName] [nvarchar](max) NULL,
	[TItemRate] [float] NULL,
	[CuttingRate] [float] NULL,
	[SewingRate] [float] NULL,
	[MaterialRate] [float] NULL,
	[ItemType] [nvarchar](100) NULL,
	[ItemCategory] [nvarchar](100) NULL,
	[MfgName] [nvarchar](100) NULL,
	[ItemSize] [varchar](50) NULL,
	[ItemSizeRange] [varchar](50) NULL,
	[ItemColor] [varchar](50) NULL,
	[ItemFor] [varchar](50) NULL,
	[UOM] [varchar](10) NULL,
	[AUOM] [varchar](10) NULL,
	[UOMValue] [float] NULL,
	[AUOMValue] [float] NULL,
	[PurchaseRate] [float] NULL,
	[MRP] [float] NULL,
	[SalesRate] [float] NULL,
	[SalesRateA] [float] NULL,
	[SalesUOM] [varchar](10) NULL,
	[ImgPath] [varchar](500) NULL,
	[ItemImage] [image] NULL,
	[ReOrderLevel] [int] NULL,
	[ItemSubType] [varchar](20) NULL,
	[IsActive] [bit] NULL,
	[HSNCode] [varchar](20) NULL,
	[TaxPer] [float] NULL,
	[CId] [int] NULL,
	[Sys_Name] [varchar](50) NULL,
	[Sys_Time] [datetime] NULL,
	[CurrUsr] [varchar](50) NULL,
	[TItemName1] [nvarchar](max) NULL,
	[M1] [nvarchar](100) NULL,
	[M2] [nvarchar](100) NULL,
	[M3] [nvarchar](100) NULL,
	[M4] [nvarchar](100) NULL,
	[M5] [nvarchar](100) NULL,
	[M6] [nvarchar](100) NULL,
	[M7] [nvarchar](100) NULL,
	[M8] [nvarchar](100) NULL,
	[M9] [nvarchar](100) NULL,
	[M10] [nvarchar](100) NULL,
	[M11] [nvarchar](100) NULL,
	[M12] [nvarchar](100) NULL,
	[M13] [nvarchar](100) NULL,
	[M14] [nvarchar](100) NULL,
	[M15] [nvarchar](100) NULL,
	[M16] [nvarchar](100) NULL,
	[M17] [nvarchar](100) NULL,
	[M18] [nvarchar](100) NULL,
	[M19] [nvarchar](100) NULL,
	[M20] [nvarchar](100) NULL,
	[M21] [nvarchar](100) NULL,
	[M22] [nvarchar](100) NULL,
	[M23] [nvarchar](100) NULL,
	[M24] [nvarchar](100) NULL,
	[M25] [nvarchar](100) NULL,
	[M26] [nvarchar](100) NULL,
	[M27] [nvarchar](100) NULL,
	[M28] [nvarchar](100) NULL,
	[M29] [nvarchar](100) NULL,
	[M30] [nvarchar](100) NULL,
	[M31] [nvarchar](100) NULL,
	[M32] [nvarchar](100) NULL,
	[M33] [nvarchar](100) NULL,
	[M34] [nvarchar](100) NULL,
	[M35] [nvarchar](100) NULL,
	[M36] [nvarchar](100) NULL,
	[M37] [nvarchar](100) NULL,
	[M38] [nvarchar](100) NULL,
	[M39] [nvarchar](100) NULL,
	[M40] [nvarchar](100) NULL,
	[M41] [nvarchar](100) NULL,
	[M42] [nvarchar](100) NULL,
	[M43] [nvarchar](100) NULL,
	[M44] [nvarchar](100) NULL,
	[M45] [nvarchar](100) NULL,
	[M46] [nvarchar](100) NULL,
	[M47] [nvarchar](100) NULL,
	[M48] [nvarchar](100) NULL,
	[M49] [nvarchar](100) NULL,
	[ManageStock] [bit] NULL,
	[DesignNo] [nvarchar](500) NULL,
	[CatalogName] [nvarchar](500) NULL,
	[Location] [nvarchar](100) NULL,
	[ItemGroupId] [int] NULL,
	[OnePieceStitchingHrs] [float] NULL,
	[AlterRate] [float] NULL,
	[SewingRate_R] [float] NULL,
	[SewingRate_Jw] [float] NULL,
	[SewingRate_Jw_R] [float] NULL,
	[AlterCharge] [float] NULL,
	[AlterCharge_R] [float] NULL,
	[CommissionPer] [float] NULL,
	[CommissionAmt] [float] NULL,
	[BarcodeType] [varchar](50) NULL,
	[MainItemId] [int] NULL,
	[ItemSubCategory] [varchar](50) NULL,
	[SupplierName] [varchar](100) NULL,
	[PurchaseDiscPer] [float] NULL,
	[SalesDiscPer] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[TItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemGroupMaster]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemGroupMaster](
	[ItemGroupId] [int] IDENTITY(1,1) NOT NULL,
	[ItemGroupName] [nvarchar](100) NULL,
	[ItemGroupNameR] [nvarchar](100) NULL,
	[ProductionLimit] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemGroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_TailoringItemMaster]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_TailoringItemMaster]
AS
SELECT dbo.tbl_TItemMaster.TItemId, dbo.tbl_TItemMaster.TItemCode, dbo.tbl_TItemMaster.BarCode, dbo.tbl_TItemMaster.TItemName, dbo.tbl_TItemMaster.TItemRate, dbo.tbl_TItemMaster.CuttingRate, dbo.tbl_TItemMaster.SewingRate, 
                  dbo.tbl_TItemMaster.MaterialRate, dbo.tbl_TItemMaster.ItemType, dbo.tbl_TItemMaster.SalesRate, dbo.tbl_TItemMaster.ItemSubType, dbo.tbl_TItemMaster.IsActive, dbo.tbl_TItemMaster.HSNCode, dbo.tbl_TItemMaster.TaxPer, 
                  dbo.tbl_TItemMaster.CId, dbo.tbl_TItemMaster.AlterRate, dbo.tbl_TItemMaster.SewingRate_R, dbo.tbl_TItemMaster.SewingRate_Jw, dbo.tbl_TItemMaster.SewingRate_Jw_R, dbo.tbl_TItemMaster.AlterCharge, 
                  dbo.tbl_TItemMaster.AlterCharge_R, dbo.tbl_TItemMaster.TItemName1, dbo.tbl_TItemMaster.OnePieceStitchingHrs, dbo.tbl_TItemMaster.UOM, dbo.tbl_TItemMaster.ImgPath, dbo.tbl_TItemMaster.ItemImage, 
                  dbo.tbl_TItemMaster.ItemGroupId, dbo.tbl_ItemGroupMaster.ItemGroupName, dbo.tbl_ItemGroupMaster.ProductionLimit
FROM     dbo.tbl_TItemMaster LEFT OUTER JOIN
                  dbo.tbl_ItemGroupMaster ON dbo.tbl_TItemMaster.ItemGroupId = dbo.tbl_ItemGroupMaster.ItemGroupId
WHERE  (dbo.tbl_TItemMaster.ItemSubType = 'Tailoring')
GO
/****** Object:  Table [dbo].[tbl_TItemMasterTabIndex]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TItemMasterTabIndex](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TItemId] [int] NOT NULL,
	[M1] [smallint] NULL,
	[M2] [smallint] NULL,
	[M3] [smallint] NULL,
	[M4] [smallint] NULL,
	[M5] [smallint] NULL,
	[M6] [smallint] NULL,
	[M7] [smallint] NULL,
	[M8] [smallint] NULL,
	[M9] [smallint] NULL,
	[M10] [smallint] NULL,
	[M11] [smallint] NULL,
	[M12] [smallint] NULL,
	[M13] [smallint] NULL,
	[M14] [smallint] NULL,
	[M15] [smallint] NULL,
	[M16] [smallint] NULL,
	[M17] [smallint] NULL,
	[M18] [smallint] NULL,
	[M19] [smallint] NULL,
	[M20] [smallint] NULL,
	[M21] [smallint] NULL,
	[M22] [smallint] NULL,
	[M23] [smallint] NULL,
	[M24] [smallint] NULL,
	[M25] [smallint] NULL,
	[M26] [smallint] NULL,
	[M27] [smallint] NULL,
	[M28] [smallint] NULL,
	[M29] [smallint] NULL,
	[M30] [smallint] NULL,
	[M31] [smallint] NULL,
	[M32] [smallint] NULL,
	[M33] [smallint] NULL,
	[M34] [smallint] NULL,
	[M35] [smallint] NULL,
	[M36] [smallint] NULL,
	[M37] [smallint] NULL,
	[M38] [smallint] NULL,
	[M39] [smallint] NULL,
	[M40] [smallint] NULL,
	[M41] [smallint] NULL,
	[M42] [smallint] NULL,
	[M43] [smallint] NULL,
	[M44] [smallint] NULL,
	[M45] [smallint] NULL,
	[M46] [smallint] NULL,
	[M47] [smallint] NULL,
	[M48] [smallint] NULL,
	[M49] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_TItemNotesStyles]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TItemNotesStyles](
	[ParaId] [int] IDENTITY(1,1) NOT NULL,
	[ParaName] [nvarchar](max) NULL,
	[TItemId] [int] NULL,
	[PrintRequired] [bit] NULL,
	[PrintOrder] [int] NULL,
	[Charge] [int] NULL,
	[ChargeW] [int] NULL,
	[ChargeJW] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ParaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_TItemParameter]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TItemParameter](
	[ParaId] [int] IDENTITY(1,1) NOT NULL,
	[ParaName] [nvarchar](max) NULL,
	[TItemId] [int] NULL,
	[PrintRequired] [bit] NULL,
	[PrintOrder] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ParaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_UserMaster]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_UserMaster](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[UserPwd] [nvarchar](50) NULL,
	[DeptId] [int] NULL,
	[PrintName] [nvarchar](50) NULL,
	[CId] [int] NULL,
	[Sys_Name] [nvarchar](50) NULL,
	[Sys_Time] [datetime] NULL,
	[CurrUsr] [nvarchar](50) NULL,
	[LedgerId] [int] NULL,
	[Barcode_CIdList] [varchar](50) NULL,
	[MobileNo] [varchar](15) NULL,
	[IsOTPRequired] [bit] NULL,
	[EmailId] [varchar](50) NULL,
	[IsDemo] [bit] NULL,
	[IsAdmin] [int] NULL,
 CONSTRAINT [PK_tbl_UserMaster] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUser]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[MiddleName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[Mobile] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[IsAdmin] [int] NULL,
 CONSTRAINT [PK_TblUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_ItemGroupMaster] ON 

INSERT [dbo].[tbl_ItemGroupMaster] ([ItemGroupId], [ItemGroupName], [ItemGroupNameR], [ProductionLimit]) VALUES (1, N'पेंट', N'', 40)
INSERT [dbo].[tbl_ItemGroupMaster] ([ItemGroupId], [ItemGroupName], [ItemGroupNameR], [ProductionLimit]) VALUES (2, N'सफारी', N'', 2)
INSERT [dbo].[tbl_ItemGroupMaster] ([ItemGroupId], [ItemGroupName], [ItemGroupNameR], [ProductionLimit]) VALUES (3, N'सूट', N'', 15)
INSERT [dbo].[tbl_ItemGroupMaster] ([ItemGroupId], [ItemGroupName], [ItemGroupNameR], [ProductionLimit]) VALUES (4, N'शर्ट', N'', 75)
SET IDENTITY_INSERT [dbo].[tbl_ItemGroupMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_TItemMaster] ON 

INSERT [dbo].[tbl_TItemMaster] ([TItemId], [TItemCode], [BarCode], [TItemName], [TItemRate], [CuttingRate], [SewingRate], [MaterialRate], [ItemType], [ItemCategory], [MfgName], [ItemSize], [ItemSizeRange], [ItemColor], [ItemFor], [UOM], [AUOM], [UOMValue], [AUOMValue], [PurchaseRate], [MRP], [SalesRate], [SalesRateA], [SalesUOM], [ImgPath], [ItemImage], [ReOrderLevel], [ItemSubType], [IsActive], [HSNCode], [TaxPer], [CId], [Sys_Name], [Sys_Time], [CurrUsr], [TItemName1], [M1], [M2], [M3], [M4], [M5], [M6], [M7], [M8], [M9], [M10], [M11], [M12], [M13], [M14], [M15], [M16], [M17], [M18], [M19], [M20], [M21], [M22], [M23], [M24], [M25], [M26], [M27], [M28], [M29], [M30], [M31], [M32], [M33], [M34], [M35], [M36], [M37], [M38], [M39], [M40], [M41], [M42], [M43], [M44], [M45], [M46], [M47], [M48], [M49], [ManageStock], [DesignNo], [CatalogName], [Location], [ItemGroupId], [OnePieceStitchingHrs], [AlterRate], [SewingRate_R], [SewingRate_Jw], [SewingRate_Jw_R], [AlterCharge], [AlterCharge_R], [CommissionPer], [CommissionAmt], [BarcodeType], [MainItemId], [ItemSubCategory], [SupplierName], [PurchaseDiscPer], [SalesDiscPer]) VALUES (1, N'26', N'54', N'Kylynn Baker', 84, 33, 34, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, 0, 0, 0, 0, N'', NULL, NULL, 0, N'', 0, NULL, 71, 0, NULL, CAST(N'2023-12-22T17:54:40.040' AS DateTime), NULL, NULL, N'', N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', N'', 0, N'', N'', N'', 0, 0, 38, 30, 47, 90, 0, 57, 0, 0, N'', 0, N'', N'', 0, 0)
INSERT [dbo].[tbl_TItemMaster] ([TItemId], [TItemCode], [BarCode], [TItemName], [TItemRate], [CuttingRate], [SewingRate], [MaterialRate], [ItemType], [ItemCategory], [MfgName], [ItemSize], [ItemSizeRange], [ItemColor], [ItemFor], [UOM], [AUOM], [UOMValue], [AUOMValue], [PurchaseRate], [MRP], [SalesRate], [SalesRateA], [SalesUOM], [ImgPath], [ItemImage], [ReOrderLevel], [ItemSubType], [IsActive], [HSNCode], [TaxPer], [CId], [Sys_Name], [Sys_Time], [CurrUsr], [TItemName1], [M1], [M2], [M3], [M4], [M5], [M6], [M7], [M8], [M9], [M10], [M11], [M12], [M13], [M14], [M15], [M16], [M17], [M18], [M19], [M20], [M21], [M22], [M23], [M24], [M25], [M26], [M27], [M28], [M29], [M30], [M31], [M32], [M33], [M34], [M35], [M36], [M37], [M38], [M39], [M40], [M41], [M42], [M43], [M44], [M45], [M46], [M47], [M48], [M49], [ManageStock], [DesignNo], [CatalogName], [Location], [ItemGroupId], [OnePieceStitchingHrs], [AlterRate], [SewingRate_R], [SewingRate_Jw], [SewingRate_Jw_R], [AlterCharge], [AlterCharge_R], [CommissionPer], [CommissionAmt], [BarcodeType], [MainItemId], [ItemSubCategory], [SupplierName], [PurchaseDiscPer], [SalesDiscPer]) VALUES (2, N'71', N'9', N'Janna Johnston', 64, 52, 76, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, 0, 0, 0, 0, N'', NULL, NULL, 0, N'', 0, NULL, 41, 0, NULL, CAST(N'2023-12-22T17:58:14.037' AS DateTime), NULL, NULL, N'', N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', N'', 0, N'', N'', N'', 0, 0, 43, 4, 48, 41, 0, 24, 0, 0, N'', 0, N'', N'', 0, 0)
SET IDENTITY_INSERT [dbo].[tbl_TItemMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_TItemNotesStyles] ON 

INSERT [dbo].[tbl_TItemNotesStyles] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder], [Charge], [ChargeW], [ChargeJW]) VALUES (1, N'Deserunt exercitatio', 2, 1, 1, 2, 51, 32)
INSERT [dbo].[tbl_TItemNotesStyles] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder], [Charge], [ChargeW], [ChargeJW]) VALUES (2, N'Nemo est qui sint e', 2, 1, 2, 44, 78, 46)
INSERT [dbo].[tbl_TItemNotesStyles] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder], [Charge], [ChargeW], [ChargeJW]) VALUES (3, N'At aute rem ab quam ', 2, 1, 3, 76, 43, 38)
INSERT [dbo].[tbl_TItemNotesStyles] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder], [Charge], [ChargeW], [ChargeJW]) VALUES (4, N'Autem quaerat et vol', 2, 1, 4, 18, 81, 68)
INSERT [dbo].[tbl_TItemNotesStyles] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder], [Charge], [ChargeW], [ChargeJW]) VALUES (5, N'Ratione quasi offici', 2, 1, 5, 7, 89, 9)
INSERT [dbo].[tbl_TItemNotesStyles] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder], [Charge], [ChargeW], [ChargeJW]) VALUES (6, N'Nemo dolore ut sequi', 2, 1, 6, 2, 3, 63)
INSERT [dbo].[tbl_TItemNotesStyles] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder], [Charge], [ChargeW], [ChargeJW]) VALUES (7, N'Sed distinctio Ex s', 2, 1, 7, 35, 40, 88)
INSERT [dbo].[tbl_TItemNotesStyles] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder], [Charge], [ChargeW], [ChargeJW]) VALUES (8, N'Nostrum est porro ip', 2, 1, 8, 46, 23, 89)
SET IDENTITY_INSERT [dbo].[tbl_TItemNotesStyles] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_TItemParameter] ON 

INSERT [dbo].[tbl_TItemParameter] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder]) VALUES (1, N'Quam elit qui qui f', 2, 1, 1)
INSERT [dbo].[tbl_TItemParameter] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder]) VALUES (2, N'Nesciunt voluptas u', 2, 1, 2)
INSERT [dbo].[tbl_TItemParameter] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder]) VALUES (3, N'Tempore ullam archi', 2, 1, 3)
INSERT [dbo].[tbl_TItemParameter] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder]) VALUES (4, N'Delectus aut nihil ', 2, 1, 4)
INSERT [dbo].[tbl_TItemParameter] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder]) VALUES (5, N'Nemo sunt aliquam il', 2, 1, 5)
INSERT [dbo].[tbl_TItemParameter] ([ParaId], [ParaName], [TItemId], [PrintRequired], [PrintOrder]) VALUES (6, N'Corrupti officiis q', 2, 1, 6)
SET IDENTITY_INSERT [dbo].[tbl_TItemParameter] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_UserMaster] ON 

INSERT [dbo].[tbl_UserMaster] ([UserId], [UserName], [UserPwd], [DeptId], [PrintName], [CId], [Sys_Name], [Sys_Time], [CurrUsr], [LedgerId], [Barcode_CIdList], [MobileNo], [IsOTPRequired], [EmailId], [IsDemo], [IsAdmin]) VALUES (2, N'JULIEMG', N'RADHEKRISHNA', 1, N'JULIEMG', 1, N'SSD', CAST(N'2018-08-21T13:55:11.000' AS DateTime), N'SUNRISE', 4727, N'', N'+916265883659', 0, N'', 1, 0)
SET IDENTITY_INSERT [dbo].[tbl_UserMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TblUser] ON 

INSERT [dbo].[TblUser] ([Id], [FirstName], [MiddleName], [LastName], [Email], [Password], [Mobile], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [IsAdmin]) VALUES (1, N'Admin', NULL, N'Master', N'admin@gmail.com', N'LCOTkAuDKOU9o8rrMUss+MRYMwlgCadjcQlNu2wysnU=', NULL, CAST(N'2023-11-28T10:31:55.063' AS DateTime), 1, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[TblUser] OFF
GO
ALTER TABLE [dbo].[tbl_UserMaster] ADD  CONSTRAINT [DF_tbl_UserMaster_IsAdmin]  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[TblUser] ADD  CONSTRAINT [DF_TblUser_IsAdmin]  DEFAULT ((0)) FOR [IsAdmin]
GO
/****** Object:  StoredProcedure [dbo].[Sp_DeleteItemMaster]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ravi Mori
-- Create date: 25-12-2023
-- Description:	Delete recored in ItemMaster
-- =============================================
CREATE PROCEDURE [dbo].[Sp_DeleteItemMaster] 
(@TItemId int)
AS
BEGIN
	SET NOCOUNT ON;

	Delete from [dbo].[tbl_TItemNotesStyles] where TItemId=@TItemId
	Delete from [dbo].[tbl_TItemParameter]where TItemId=@TItemId
	Delete from [dbo].[tbl_TItemMaster]where TItemId=@TItemId
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Deletetbluser]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-- =============================================-- Author      : dbo-- Create date : Nov 27 2023 11:20AM-- Description : Delete Procedure for tbluser-- Exec [dbo].[Sp_Deletetbluser] @Id  int    -- ============================================= */CREATE PROCEDURE [dbo].[Sp_Deletetbluser]     @Id  int    ASBEGIN    DELETE FROM [dbo].[tbluser]    WHERE [Id] = @IdEND
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetAlltbluser]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-- =============================================-- Author      : dbo-- Create date : Nov 27 2023 11:20AM-- Description : Select Procedure for tbluser-- Exec [dbo].[Sp_GetAlltbluser]-- ============================================= */CREATE PROCEDURE [dbo].[Sp_GetAlltbluser]ASBEGIN    SELECT * FROM [dbo].[tbl_UserMaster] WITH (NOLOCK)END
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetIteamMasterById]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ravi Mori
-- Create date: 25-12-2023
-- Description:	Get data ItemMaseter 
-- =============================================
CREATE PROCEDURE [dbo].[Sp_GetIteamMasterById]
	(@TItemId int)
	AS
BEGIN
	SET NOCOUNT ON;
	select [TItemId]
      ,[TItemCode]
      ,[BarCode]
      ,[TItemName]
      ,[TItemRate]
      ,[CuttingRate]
      ,[SewingRate]
      ,[MaterialRate]
      ,[ItemType]
      ,[ItemCategory]
      ,[MfgName]
      ,[ItemSize]
      ,[ItemSizeRange]
      ,[ItemColor]
      ,[ItemFor]
      ,[UOM]
      ,[AUOM]
      ,[UOMValue]
      ,[AUOMValue]
      ,[PurchaseRate]
      ,[MRP]
      ,[SalesRate]
      ,[SalesRateA]
      ,[SalesUOM]
      ,[ImgPath]
      ,[ItemImage]
      ,[ReOrderLevel]
      ,[ItemSubType]
      ,[IsActive]
      ,[HSNCode]
      ,[TaxPer]
      ,[CId]
      ,[Sys_Name]
      ,[CurrUsr]
      ,[TItemName1]
      ,[M1]
      ,[M2]
      ,[M3]
      ,[M4]
      ,[M5]
      ,[M6]
      ,[M7]
      ,[M8]
      ,[M9]
      ,[M10]
      ,[M11]
      ,[M12]
      ,[M13]
      ,[M14]
      ,[M15]
      ,[M16]
      ,[M17]
      ,[M18]
      ,[M19]
      ,[M20]
      ,[M21]
      ,[M22]
      ,[M23]
      ,[M24]
      ,[M25]
      ,[M26]
      ,[M27]
      ,[M28]
      ,[M29]
      ,[M30]
      ,[M31]
      ,[M32]
      ,[M33]
      ,[M34]
      ,[M35]
      ,[M36]
      ,[M37]
      ,[M38]
      ,[M39]
      ,[M40]
      ,[M41]
      ,[M42]
      ,[M43]
      ,[M44]
      ,[M45]
      ,[M46]
      ,[M47]
      ,[M48]
      ,[M49]
      ,[ManageStock]
      ,[DesignNo]
      ,[CatalogName]
      ,[Location]
      ,[ItemGroupId]
      ,[OnePieceStitchingHrs]
      ,[AlterRate]
      ,[SewingRate_R]
      ,[SewingRate_Jw]
      ,[SewingRate_Jw_R]
      ,[AlterCharge]
      ,[AlterCharge_R]
      ,[CommissionPer]
      ,[CommissionAmt]
      ,[BarcodeType]
      ,[MainItemId]
      ,[ItemSubCategory]
      ,[SupplierName]
      ,[PurchaseDiscPer]
      ,[SalesDiscPer]
	  from [dbo].[tbl_TItemMaster] where TItemId=@TItemId
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetIteamMasterParameter]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ravi Mori
-- Create date: 25-12-2023
-- Description:	Get data ItemMaseter with parameter
-- =============================================
CREATE PROCEDURE [dbo].[Sp_GetIteamMasterParameter]
	(@TItemId int)
	AS
BEGIN
	SET NOCOUNT ON;
	select * from [dbo].[tbl_TItemParameter] where TItemId=@TItemId
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetItemNotesStyles]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ravi Mori
-- Create date: 25-12-2023
-- Description:	Get data ItemMaseter with ItemNotesStyles
-- =============================================
create PROCEDURE [dbo].[Sp_GetItemNotesStyles]
	(@TItemId int)
	AS
BEGIN
	SET NOCOUNT ON;
	select * from [dbo].[tbl_TItemNotesStyles] where TItemId=@TItemId

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetTItemMasterList]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-- =============================================-- Author      : dbo-- Create date : Dec 20 2023 -- Description : Select Procedure for TItemMasterList-- Exec [dbo].[Sp_GetUsers]-- ============================================= */CREATE PROCEDURE [dbo].[Sp_GetTItemMasterList]
AS
BEGIN
	SET NOCOUNT ON;
		SELECT * FROM 
			[dbo].[tbl_TItemMaster] 
   	    ORDER BY TItemId desc
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetUsers]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-- =============================================-- Author      : dbo-- Create date : Nov 27 2023 11:20AM-- Description : Select Procedure for tbl UserMaster-- Exec [dbo].[Sp_GetUsers]-- ============================================= */CREATE PROCEDURE [dbo].[Sp_GetUsers]
@UserName nvarchar(100)
AS
BEGIN
			SELECT  *
			 FROM [dbo].[tbl_UserMaster]
			 where UserName=@UserName
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertTblTItemNotesStyles]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ravi Mori
-- Create date: 22-12-2023
-- Description:	Insert tbl_TItemNotesStyles 
-- =============================================
CREATE PROCEDURE [dbo].[Sp_InsertTblTItemNotesStyles]
(
@ParaName nvarchar(max),
@TItemId int,
@PrintRequired bit,
@PrintOrder int,
@Charge int,
@ChargeW int,
@ChargeJW int
)
AS
BEGIN
	SET NOCOUNT ON;

	  INSERT INTO [dbo].[tbl_TItemNotesStyles]
			   ([ParaName]
			   ,[TItemId]
			   ,[PrintRequired]
			   ,[PrintOrder]
			   ,[Charge]
			   ,[ChargeW]
			   ,[ChargeJW])
		 VALUES
			   (
			    @ParaName
			   ,@TItemId
			   ,@PrintRequired
			   ,@PrintOrder
			   ,@Charge
			   ,@ChargeW
			   ,@ChargeJW
			   )
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertTblTItemParameter]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ravi Mori
-- Create date: 22-12-2023
-- Description:	Insert tbl_TItemParameter 
-- =============================================
CREATE PROCEDURE [dbo].[Sp_InsertTblTItemParameter]
(
@ParaName nvarchar(max),
@TItemId int,
@PrintRequired bit,
@PrintOrder int
)
AS
BEGIN
	SET NOCOUNT ON;

		INSERT INTO [dbo].[tbl_TItemParameter]
				   ([ParaName]
				   ,[TItemId]
				   ,[PrintRequired]
				   ,[PrintOrder])
			 VALUES
				   (
				   @ParaName, 
				   @TItemId, 
				   @PrintRequired, 
				   @PrintOrder 
				   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertTItemMaster_Sales_140922]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertTItemMaster_Sales_140922] 
	@TItemCode varchar(20), 
	@BarCode varchar(50), 
	@TItemName Nvarchar(MAX), 
	@TItemRate float, 
	@CuttingRate float, 
	@SewingRate float, 
	@MaterialRate float, 
	@ItemType nvarchar(100), 
	@ItemCategory nvarchar(100), 
	@MfgName nvarchar(100), 
	@ItemSize varchar(50), 
	@ItemSizeRange varchar(50), 
	@ItemColor varchar(50), 
	@ItemFor varchar(50), 
	@UOM varchar(10), 
	@AUOM varchar(10), 
	@UOMValue float, 
	@AUOMValue float, 
	@PurchaseRate float, 
	@MRP float, 
	@SalesRate float, 
	@SalesRateA float, 
	@SalesUOM varchar(10), 
	@ImgPath varchar(500), 
	--@ItemImage image, 
	@ReOrderLevel int, 
	@ItemSubType varchar(20), 
	@IsActive bit, 
	@HSNCode varchar(20), 
	@TaxPer float, 
	@CId int, 
	@Sys_Name varchar(50), 
	@Sys_Time datetime, 
	@CurrUsr varchar(50), 
	@TItemName1 Nvarchar(MAX),
	@ManageStock bit,
	@DesignNo nvarchar(500),
	@CatalogName nvarchar(500),
	@Location nvarchar(100),
	@ItemGroupId int,
	@OnePieceStitchingHrs float,
	@AlterRate float,
	@SewingRate_R float,
	@SewingRate_Jw float,
	@SewingRate_Jw_R float,
	@AlterCharge float,
	@AlterCharge_R float,
	@CommissionPer float,
	@CommissionAmt float,
	@M1 nvarchar(100),
	@M2 nvarchar(100),
	@M48 nvarchar(100),
	@M49 nvarchar(100),
	@BarcodeType varchar(50),
	@MainItemId int,
	@ItemSubCategory varchar(50),
	@SupplierName varchar(100),
	@PurchaseDiscPer float,
	@SalesDiscPer float
as
begin
INSERT INTO [dbo].[tbl_TItemMaster]
	([TItemCode]
	,[BarCode]	
	,[TItemName]
	,[TItemRate]	
	,[CuttingRate]	
	,[SewingRate]	
	,[MaterialRate]				
	,[ItemType]
	,[ItemCategory]
	,[MfgName]
	,[ItemSize]
	,[ItemSizeRange]
	,[ItemColor]
	,[ItemFor]
	,[UOM]
	,[AUOM]
	,[UOMValue]
	,[AUOMValue]
	,[PurchaseRate]
	,[MRP]
	,[SalesRate]
	,[SalesRateA]
	,[SalesUOM]
	,[ImgPath]
	--,[ItemImage]
	,[ReOrderLevel]	
	,[ItemSubType]		
	,[IsActive]
	,[HSNCode]		
	,[TaxPer]
	,[CId]
	,[Sys_Name]
	,[Sys_Time]
	,[CurrUsr]
	,[TItemName1]
	,[ManageStock]
	,[DesignNo]
	,[CatalogName]
	,[Location]
	,ItemGroupId
	,OnePieceStitchingHrs 
	,AlterRate 
	,SewingRate_R 
	,SewingRate_Jw 
	,SewingRate_Jw_R 
	,AlterCharge 
	,AlterCharge_R 
	,CommissionPer 
	,CommissionAmt 
	,M1
	,M2
	,M48
	,M49
	,BarcodeType
	,MainItemId
	,ItemSubCategory
	,SupplierName
	,[PurchaseDiscPer]
	,[SalesDiscPer]
	)
     VALUES
		(@TItemCode, 
		@BarCode, 
		@TItemName, 
		@TItemRate, 
		@CuttingRate, 
		@SewingRate, 
		@MaterialRate, 
		@ItemType, 
		@ItemCategory, 
		@MfgName, 
		@ItemSize, 
		@ItemSizeRange, 
		@ItemColor, 
		@ItemFor, 
		@UOM, 
		@AUOM, 
		@UOMValue, 
		@AUOMValue, 
		@PurchaseRate, 
		@MRP, 
		@SalesRate, 
		@SalesRateA, 
		@SalesUOM, 
		@ImgPath, 
	--	@ItemImage, 
		@ReOrderLevel, 
		@ItemSubType, 
		@IsActive, 
		@HSNCode, 
		@TaxPer, 
		@CId, 
		@Sys_Name, 
		@Sys_Time, 
		@CurrUsr,
		@TItemName1,
		@ManageStock,
		@DesignNo,
		@CatalogName,
		@Location 
	    ,@ItemGroupId
		,@OnePieceStitchingHrs 
		,@AlterRate 
		,@SewingRate_R 
		,@SewingRate_Jw 
		,@SewingRate_Jw_R 
		,@AlterCharge 
		,@AlterCharge_R 
		,@CommissionPer 
		,@CommissionAmt 
		,@M1
		,@M2
		,@M48
		,@M49
		,@BarcodeType
		,@MainItemId
		,@ItemSubCategory
		,@SupplierName
		,@PurchaseDiscPer
		,@SalesDiscPer
		)
		SELECT SCOPE_IDENTITY();
End
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertUpdatetbluser]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-- =============================================
-- Author      : dbo
-- Create date : Nov 27 2023 11:20AM
-- Description : Update Procedure for tbluser
-- Exec [dbo].[Sp_InsertUpdatetbluser] [FirstName],[MiddleName],[LastName],[Email],[Password],[Mobile],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[IsAdmin]
-- ============================================= */
CREATE PROCEDURE [dbo].[Sp_InsertUpdatetbluser]
	@UserId int,
	@UserName nvarchar(max)NULL,
	@UserPwd nvarchar(50)NULL,
	@DeptId int NULL,
	@PrintName nvarchar(50) NULL,
	@CId int NULL,
	@Sys_Name nvarchar(50) NULL,
	@Sys_Time datetime NULL,
	@CurrUsr nvarchar(50) NULL,
	@LedgerId int NULL,
	@Barcode_CIdList varchar(50) NULL,
	@MobileNo varchar(15) NULL,
	@IsOTPRequired bit NULL,
	@EmailId varchar(50) NULL,
	@IsDemo bit NULL
    ,@RetVal INT =0  OUT
AS
BEGIN
  SET NOCOUNT ON;
  BEGIN TRAN;
  BEGIN TRY
	  IF @UserId=0
		BEGIN
			INSERT INTO [dbo].[tbl_UserMaster]
				   (
					[UserName] ,
					[UserPwd],
					[DeptId],
					[PrintName],
					[CId],
					[Sys_Name],
					[Sys_Time],
					[CurrUsr],
					[LedgerId],
					[Barcode_CIdList],
					[MobileNo],
					[IsOTPRequired],
					[EmailId],
					[IsDemo]
					)
			 VALUES
				   (
					@UserName,
					@UserPwd,
					@DeptId,
					@PrintName,
					@CId,
					@Sys_Name,
					@Sys_Time,
					@CurrUsr,
					@LedgerId,
					@Barcode_CIdList,
					@MobileNo,
					@IsOTPRequired,
					@EmailId,
					@IsDemo
					)
		END
		ELSE
		BEGIN
			UPDATE [dbo].[tbl_UserMaster]
			SET 
 			  [UserName] = @UserName,
			  [UserPwd] = @UserPwd,
			  [DeptId] = @DeptId,
			  [PrintName] = @PrintName,
			  [CId] = @CId,
			  [Sys_Name] = @Sys_Name,
			  [Sys_Time] = @Sys_Time,
			  [CurrUsr] = @CurrUsr,
			  [LedgerId] = @LedgerId,
			  [Barcode_CIdList] = @Barcode_CIdList,
			  [MobileNo] = @MobileNo,
			  [IsOTPRequired] = @IsOTPRequired,
			  [EmailId] = @EmailId,
			  [IsDemo] = @IsDemo
	  
			WHERE [UserId] = @UserId
		END
		
		IF @@ERROR <> 0
		BEGIN
			SET @RetVal = 0
			ROLLBACK TRAN
			RETURN
		END
		ELSE
        BEGIN
		    SET @RetVal = 1
			COMMIT TRAN
			RETURN
		END
			print @RetVal 
	END TRY
    BEGIN CATCH
		SET @RetVal = 500
		ROLLBACK TRAN
		RETURN
	END CATCH

END

GO
/****** Object:  StoredProcedure [dbo].[Sp_UpdateTblTItemNotesStyles]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_UpdateTblTItemNotesStyles]
(
@ParaId int,
@ParaName nvarchar(max),
@TItemId int,
@PrintRequired bit,
@PrintOrder int,
@Charge int,
@ChargeW int,
@ChargeJW int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		UPDATE [dbo].[tbl_TItemNotesStyles]
		   SET [ParaName] = @ParaName
			  ,[TItemId] = @TItemId 
			  ,[PrintRequired] = @PrintRequired
			  ,[PrintOrder] = @PrintOrder
			  ,[Charge] = @Charge
			  ,[ChargeW] = @ChargeW
			  ,[ChargeJW] = @ChargeJW
		 WHERE ParaId=@ParaId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateTItemMaster_Sales_251021]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_UpdateTItemMaster_Sales_251021] 

@UpTItemCode varchar(20), 
@UpBarCode varchar(50), 
@UpTItemName Nvarchar(MAX), 
@UpTItemRate float, 
@UpCuttingRate float, 
@UpSewingRate float, 
@UpMaterialRate float, 
@UpItemType varchar(50), 
@UpItemCategory varchar(50), 
@UpMfgName varchar(50), 
@UpItemSize varchar(50), 
@UpUOM varchar(10), 
@UpAUOM varchar(10), 
@UpUOMValue float, 
@UpAUOMValue float, 
@UpSalesRate float, 
@UpSalesRateA float, 
@UpSalesUOM varchar(10), 
@UpImgPath varchar(500), 
@UpItemImage image, 
@UpReOrderLevel int, 
@UpItemSubType varchar(20), 
@UpIsActive bit, 
@UpHSNCode varchar(20), 
@UpTaxPer float, 
@UpItemGroupId int,
	@UpOnePieceStitchingHrs float,
	@UpAlterRate float,
	@UpSewingRate_R float,
	@UpSewingRate_Jw float,
	@UpSewingRate_Jw_R float,
	@UpAlterCharge float,
	@UpAlterCharge_R float,
	@UpCommissionPer float,
	@UpCommissionAmt float,
@UpTItemId int

as
begin
Update [dbo].[tbl_TItemMaster]
Set
	[TItemCode] = @UpTItemCode,
	[BarCode] = @UpBarCode,	
	[TItemName] = @UpTItemName,
	[TItemRate] = @UpTItemRate,	
	[CuttingRate] = @UpCuttingRate,	
	[SewingRate] = @UpSewingRate,	
	[MaterialRate] = @UpMaterialRate,				
	[ItemType] = @UpItemType,
	[ItemCategory] = @UpItemCategory,
	[MfgName] = @UpMfgName,
	[ItemSize] = @UpItemSize,
	[UOM] = @UpUOM,
	[AUOM] = @UpAUOM,
	[UOMValue] = @UpUOMValue,
	[AUOMValue] = @UpAUOMValue,
	[SalesRate] = @UpSalesRate,
	[SalesRateA] = @UpSalesRateA,
	[SalesUOM] = @UpSalesUOM,
	[ImgPath] = @UpImgPath,
	[ItemImage] = @UpItemImage,
	[ReOrderLevel] = @UpReOrderLevel,	
	[ItemSubType] = @UpItemSubType,		
	[HSNCode] = @UpHSNCode,	
	[TaxPer] = @UpTaxPer,		
	[IsActive] = @UpIsActive
	,ItemGroupId = @UpItemGroupId
	,OnePieceStitchingHrs = @UpOnePieceStitchingHrs
	,AlterRate = @UpAlterRate
	,SewingRate_R = @UpSewingRate_R
	,SewingRate_Jw = @UpSewingRate_Jw
	,SewingRate_Jw_R = @UpSewingRate_Jw_R
	,AlterCharge = @UpAlterCharge
	,AlterCharge_R = @UpAlterCharge_R
	,CommissionPer = @UpCommissionPer
	,CommissionAmt = @UpCommissionAmt
	
		Where TItemId=@UpTItemId
End


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateTItemParameter]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_UpdateTItemParameter] 
 @UpParaId int
,@UpParaName nvarchar(max)
,@UpPrintRequired bit
,@UpPrintOrder int
as
begin
Update [dbo].[tbl_TItemParameter]
Set
	 [ParaName] = @UpParaName
	,[PrintRequired] = @UpPrintRequired
	,[PrintOrder] =	@UpPrintOrder
	where ParaId=@UpParaId
End
GO
/****** Object:  StoredProcedure [dbo].[usp_create_sps_for_table]    Script Date: 27-12-2023 4.27.28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =======================================================================================
-- Author      : Ravi c. Mori
-- Createdn On : jan 21 2022  3:42PM
-- Modified On : jan 21 2022
-- Description : Generate the Insert / Update/ Delete Stored procedure script of any table  
--				 by passing the table name
--	Exec [dbo].[usp_create_sps_for_table] 'et_application'
--
-- ========================================================================================= 

create PROCEDURE [dbo].[usp_create_sps_for_table]
	@tblName Varchar(50) 
AS
BEGIN

	Declare @dbName Varchar(50) 
	Declare @selectSPName Varchar(50), @insertSPName Varchar(50), @updateSPName Varchar(50), @deleteSPName Varchar(50) ;
	Declare @tablColumnParameters   Varchar(max);
	Declare @tableColumns           Varchar(max)
	Declare @tableColumnVariables   Varchar(max);
	Declare @tablColumnParametersUpdate Varchar(max);
	Declare @tableCols	    Varchar(max);
	Declare @space			Varchar(50)  ;
	Declare @colName 		Varchar(100) ;
	Declare @colVariable	Varchar(100) ;
	Declare @colParameter	Varchar(100) ;
	Declare @colIdentity	bit			 ;
	Declare @strSpText		Varchar(max);
	Declare @updCols		Varchar(max);
	Declare @delParamCols	Varchar(max);
	Declare @whereCols		Varchar(max);
	Set		@tblName		   =  SubString(@tblName,CharIndex('.',@tblName)+1, Len(@tblName))

	Set		@selectSPName      = '[dbo].[Sp_GetAll' + Replace(@tblName,'_','') +']' ;
	Set		@insertSPName      = '[dbo].[Sp_Insert' + Replace(@tblName,'_','') +']' ;
	Set		@updateSPName      = '[dbo].[Sp_Update' + Replace(@tblName,'_','') +']' ;
	Set		@deleteSPName      = '[dbo].[Sp_Delete' + Replace(@tblName,'_','') +']' ;

	Set		@space				  = REPLICATE(' ', 4)  ;
	Set		@tablColumnParameters = '' ;
	Set		@tableColumns		  = '' ;
	Set		@tableColumnVariables = '' ;
	Set		@strSPText			  = '' ;
	Set		@tableCols			  = '' ;
	Set		@updCols			  = '' ;
	Set		@delParamCols		  = '' ;
	Set		@whereCols			  = '' ;
	Set		@tablColumnParametersUpdate = '' ;
	SET NOCOUNT ON 

	-- Get all columns & data types for a table 
	SELECT distinct
			COLUMNPROPERTY(syscolumns.id, syscolumns.name, 'IsIdentity') as 'IsIdentity',
			sysobjects.name as 'Table', 
			syscolumns.colid ,
			'[' + syscolumns.name + ']' as 'ColumnName',
			'@'+syscolumns.name  as 'ColumnVariable',
			systypes.name + 
	Case  When  systypes.xusertype in (165,167,175,231,239 ) Then '(' + REPLACE(Convert(varchar(10),syscolumns.prec),'-1','max')  +')' Else '' end as 'DataType' ,
			'@'+syscolumns.name  + '  ' + systypes.name + 
	Case  When  systypes.xusertype in (165,167,175,231,239 ) Then '(' + REPLACE(Convert(varchar(10),syscolumns.prec),'-1','max') +')' Else '' end as 'ColumnParameter'
	Into	#tmp_Structure	
	From	sysobjects , syscolumns ,  systypes
	Where	sysobjects.id			 = syscolumns.id
			and syscolumns.xusertype = systypes.xusertype
			and sysobjects.xtype	 = 'u'
			and sysobjects.name		 = @tblName
			and systypes.xusertype not in (189)
	Order by syscolumns.colid

	-- Get all Primary KEY columns & data types for a table 
	SELECT		t.name as 'Table', 
				c.colid ,
				'[' + c.name + ']' as 'ColumnName',
				'@'+c.name  as 'ColumnVariable',
				systypes.name + 
		Case  When  systypes.xusertype in (165,167,175,231,239 ) Then '(' + Convert(varchar(10),c.length) +')' Else '' end as 'DataType' ,
				'@'+c.name  + '  ' + systypes.name + 
		Case  When  systypes.xusertype in (165,167,175,231,239 ) Then '(' + Convert(varchar(10),c.length) +')' Else '' end as 'ColumnParameter'
	Into	#tmp_PK_Structure	
	FROM    sysindexes i, sysobjects t, sysindexkeys k, syscolumns c, systypes
	WHERE	i.id = t.id	 AND
			i.indid = k.indid  AND i.id = k.ID And
			c.id = t.id    AND c.colid = k.colid AND  
			i.indid BETWEEN 1 And 254  AND 
			c.xusertype = systypes.xusertype AND
			(i.status & 2048) = 2048 AND t.id = OBJECT_ID(@tblName)

	/* Read the table structure and populate variables*/
	Declare SpText_Cursor Cursor For
		Select ColumnName, ColumnVariable, ColumnParameter, IsIdentity
		From #tmp_Structure 

	Open SpText_Cursor

	Fetch Next From SpText_Cursor Into @colName,  @colVariable, @colParameter, @colIdentity
	While @@FETCH_STATUS = 0
	Begin
		If (@colIdentity=0)
		Begin
			Set @tablColumnParameters   = @tablColumnParameters + @colParameter + CHAR(13) + @space + ',' ; 
			Set @tableCols				= @tableCols + @colName +  ',' ; 		
			Set @tableColumns			= @tableColumns + @colName + CHAR(13) + @space + @space + ',' ; 		
			Set @tableColumnVariables   = @tableColumnVariables + @colVariable + CHAR(13) + @space + @space + ',' ; 
			Set @updCols				= @updCols + @colName + ' = ' + @colVariable + CHAR(13) + @space + @space + ',' ; 
		End
		
		Set @tablColumnParametersUpdate   = @tablColumnParametersUpdate + @colParameter + CHAR(13) + @space + ',' ; 

	    Fetch Next From SpText_Cursor Into @colName,  @colVariable, @colParameter , @colIdentity
	End

	Close SpText_Cursor
	Deallocate SpText_Cursor

	/* Read the Primary Keys from the table and populate variables*/
	Declare SpPKText_Cursor Cursor For
		Select ColumnName, ColumnVariable, ColumnParameter
		From #tmp_PK_Structure 

	Open SpPKText_Cursor

	Fetch Next From SpPKText_Cursor Into @colName,  @colVariable, @colParameter
	While @@FETCH_STATUS = 0
	Begin
		Set @delParamCols   = @delParamCols + @colParameter + CHAR(13) + @space + ',' ; 
		Set @whereCols		= @whereCols + @colName + ' = ' + @colVariable + ' AND '  ; 
	    Fetch Next From SpPKText_Cursor Into @colName,  @colVariable, @colParameter 
	End

	Close SpPKText_Cursor
	Deallocate SpPKText_Cursor

	-- Stored procedure scripts starts here
	If (LEN(@tablColumnParameters)>0)
	Begin 
		Set @tablColumnParameters	= LEFT(@tablColumnParameters,LEN(@tablColumnParameters)-1) ;
		Set @tablColumnParametersUpdate	= LEFT(@tablColumnParametersUpdate,LEN(@tablColumnParametersUpdate)-1) ;
		Set @tableColumnVariables	= LEFT(@tableColumnVariables,LEN(@tableColumnVariables)-1) ;
		Set @tableColumns			= LEFT(@tableColumns,LEN(@tableColumns)-1) ;
		Set @tableCols				= LEFT(@tableCols,LEN(@tableCols)-1) ;
		Set @updCols				= LEFT(@updCols,LEN(@updCols)-1) ;

		If (LEN(@whereCols)>0)
		Begin 
			Set @whereCols			= 'WHERE ' + LEFT(@whereCols,LEN(@whereCols)-4) ;
			Set @delParamCols		= LEFT(@delParamCols,LEN(@delParamCols)-1) ;
		End

		/*  Create Select stored procedure for the table if it does not exist */
		IF  Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(@selectSPName) AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
		Begin
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + '/*-- ============================================='
			Set @strSPText = @strSPText +  CHAR(13) + '-- Author      : dbo'
			Set @strSPText = @strSPText +  CHAR(13) + '-- Create date : ' + Convert(varchar(20),Getdate())
			Set @strSPText = @strSPText +  CHAR(13) + '-- Description : Select Procedure for ' + @tblName
			Set @strSPText = @strSPText +  CHAR(13) + '-- Exec ' + @selectSPName 
			Set @strSPText = @strSPText +  CHAR(13) + '-- ============================================= */'
			Set @strSPText = @strSPText +  CHAR(13) + 'CREATE PROCEDURE ' + @selectSPName
			Set @strSPText = @strSPText +  CHAR(13) + 'AS'
			Set @strSPText = @strSPText +  CHAR(13) + 'BEGIN'
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + @space + 'SELECT * FROM [dbo].['+@tblName +']' 
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + 'END'
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + ''
--			Print @strSPText ;

			Exec(@strSPText);

			if (@@ERROR=0) 
				Print 'Procedure ' + @selectSPName + ' Created Successfully '
		End
		Else
		Begin
			Print 'Sorry!!  ' + @selectSPName + ' Already exists in the database. '
		End

		/*  Create INSERT stored procedure for the table if it does not exist */
		IF  Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(@insertSPName) AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
		Begin
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + '/*-- ============================================='
			Set @strSPText = @strSPText +  CHAR(13) + '-- Author      : dbo'
			Set @strSPText = @strSPText +  CHAR(13) + '-- Create date : ' + Convert(varchar(20),Getdate())
			Set @strSPText = @strSPText +  CHAR(13) + '-- Description : Insert Procedure for ' + @tblName
			Set @strSPText = @strSPText +  CHAR(13) + '-- Exec ' + @insertSPName + ' ' + @tableCols
			Set @strSPText = @strSPText +  CHAR(13) + '-- ============================================= */'
			Set @strSPText = @strSPText +  CHAR(13) + 'CREATE PROCEDURE ' + @insertSPName
			Set @strSPText = @strSPText +  CHAR(13) + @space + ' ' + @tablColumnParameters
			Set @strSPText = @strSPText +  CHAR(13) + 'AS'
			Set @strSPText = @strSPText +  CHAR(13) + 'BEGIN'
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + @space + 'INSERT INTO [dbo].['+@tblName +']' 
			Set @strSPText = @strSPText +  CHAR(13) + @space + '( ' 
			Set @strSPText = @strSPText +  CHAR(13) + @space + @space + ' ' + @tableColumns  
			Set @strSPText = @strSPText +  CHAR(13) + @space + ')'
			Set @strSPText = @strSPText +  CHAR(13) + @space + 'VALUES'
			Set @strSPText = @strSPText +  CHAR(13) + @space + '('
			Set @strSPText = @strSPText +  CHAR(13) + @space + @space + ' ' + @tableColumnVariables
			Set @strSPText = @strSPText +  CHAR(13) + @space + ')'
			Set @strSPText = @strSPText +  CHAR(13) + 'END'
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + ''
--			Print @strSPText ;

			Exec(@strSPText);

			if (@@ERROR=0) 
				Print 'Procedure ' + @insertSPName + ' Created Successfully '

		End
		Else
		Begin
			Print 'Sorry!!  ' + @insertSPName + ' Already exists in the database. '
		End
		/*  Create UPDATE stored procedure for the table if it does not exist */
		IF  Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(@updateSPName) AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
		Begin
			Set @strSPText = ''
			Set @strSPText = @strSPText +  CHAR(13) + '/*-- ============================================='
			Set @strSPText = @strSPText +  CHAR(13) + '-- Author      : dbo'
			Set @strSPText = @strSPText +  CHAR(13) + '-- Create date : ' + Convert(varchar(20),Getdate())
			Set @strSPText = @strSPText +  CHAR(13) + '-- Description : Update Procedure for ' + @tblName
			Set @strSPText = @strSPText +  CHAR(13) + '-- Exec ' + @updateSPName + ' ' + @tableCols
			Set @strSPText = @strSPText +  CHAR(13) + '-- ============================================= */'
			Set @strSPText = @strSPText +  CHAR(13) + 'CREATE PROCEDURE ' + @updateSPName
			Set @strSPText = @strSPText +  CHAR(13) + @space + ' ' + @tablColumnParametersUpdate
			Set @strSPText = @strSPText +  CHAR(13) + 'AS'
			Set @strSPText = @strSPText +  CHAR(13) + 'BEGIN'
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + @space + 'UPDATE [dbo].['+@tblName +']' 
			Set @strSPText = @strSPText +  CHAR(13) + @space + 'SET ' 
			Set @strSPText = @strSPText +  CHAR(13) + @space + @space + ' ' + @updCols  
			Set @strSPText = @strSPText +  CHAR(13) + @space + @whereCols
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + 'END'
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + ''
--			Print @strSPText ;
			Exec(@strSPText);

			if (@@ERROR=0) 
				Print 'Procedure ' + @updateSPName + ' Created Successfully '
		End
		Else
		Begin
			Print 'Sorry!!  ' + @updateSPName + ' Already exists in the database. '
		End
		/*  Create DELETE stored procedure for the table if it does not exist */
		IF  Not EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(@deleteSPName) AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
		Begin
			Set @strSPText = ''
			Set @strSPText = @strSPText +  CHAR(13) + '/*-- ============================================='
			Set @strSPText = @strSPText +  CHAR(13) + '-- Author      : dbo'
			Set @strSPText = @strSPText +  CHAR(13) + '-- Create date : ' + Convert(varchar(20),Getdate())
			Set @strSPText = @strSPText +  CHAR(13) + '-- Description : Delete Procedure for ' + @tblName
			Set @strSPText = @strSPText +  CHAR(13) + '-- Exec ' + @deleteSPName + ' ' + @delParamCols
			Set @strSPText = @strSPText +  CHAR(13) + '-- ============================================= */'
			Set @strSPText = @strSPText +  CHAR(13) + 'CREATE PROCEDURE ' + @deleteSPName
			Set @strSPText = @strSPText +  CHAR(13) + @space + ' ' + @delParamCols
			Set @strSPText = @strSPText +  CHAR(13) + 'AS'
			Set @strSPText = @strSPText +  CHAR(13) + 'BEGIN'
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + @space + 'DELETE FROM [dbo].['+@tblName +']' 
			Set @strSPText = @strSPText +  CHAR(13) + @space + @whereCols
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + 'END'
			Set @strSPText = @strSPText +  CHAR(13) + ''
			Set @strSPText = @strSPText +  CHAR(13) + ''
--			Print @strSPText ;
			Exec(@strSPText);

			if (@@ERROR=0) 
				Print 'Procedure ' + @deleteSPName + ' Created Successfully '
		End
		Else
		Begin
			Print 'Sorry!!  ' + @deleteSPName + ' Already exists in the database. '
		End
	End
	Drop table #tmp_Structure
	Drop table #tmp_PK_Structure

END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_TItemMaster"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 285
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_ItemGroupMaster"
            Begin Extent = 
               Top = 7
               Left = 333
               Bottom = 170
               Right = 548
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_TailoringItemMaster'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_TailoringItemMaster'
GO
USE [master]
GO
ALTER DATABASE [JulieDB] SET  READ_WRITE 
GO
