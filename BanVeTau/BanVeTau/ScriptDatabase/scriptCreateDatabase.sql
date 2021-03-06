USE [master]
GO
/****** Object:  Database [VeTau]    Script Date: 27/06/2015 18:50:59 ******/
CREATE DATABASE [VeTau]

USE [VeTau]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VeTau', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\VeTau.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VeTau_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\VeTau_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VeTau] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VeTau].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VeTau] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VeTau] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VeTau] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VeTau] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VeTau] SET ARITHABORT OFF 
GO
ALTER DATABASE [VeTau] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VeTau] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [VeTau] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VeTau] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VeTau] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VeTau] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VeTau] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VeTau] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VeTau] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VeTau] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VeTau] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VeTau] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VeTau] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VeTau] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VeTau] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VeTau] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VeTau] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VeTau] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VeTau] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VeTau] SET  MULTI_USER 
GO
ALTER DATABASE [VeTau] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VeTau] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VeTau] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VeTau] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [VeTau]
GO
/****** Object:  Table [dbo].[ChiTietGiaoDich]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietGiaoDich](
	[GiaoDichId] [int] NOT NULL,
	[Huy] [bit] NULL CONSTRAINT [DF_ChiTietGiaoDich_Huy]  DEFAULT ((0)),
	[ThuTu] [int] NOT NULL,
	[LoaiGheId] [int] NOT NULL CONSTRAINT [DF_ChiTietGiaoDich_LoaiGheId]  DEFAULT ((0)),
	[LichTrinhTuyenDuongId] [int] NOT NULL CONSTRAINT [DF_ChiTietGiaoDich_LichTrinhTuyenDuongId]  DEFAULT ((0)),
	[SoGhe] [int] NOT NULL CONSTRAINT [DF_ChiTietGiaoDich_SoGhe]  DEFAULT ((0)),
 CONSTRAINT [PK_ChiTietGiaoDich] PRIMARY KEY CLUSTERED 
(
	[GiaoDichId] ASC,
	[LoaiGheId] ASC,
	[LichTrinhTuyenDuongId] ASC,
	[SoGhe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoanTau]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanTau](
	[Id] [nvarchar](20) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[GhiChu] [nvarchar](250) NULL,
	[TocDo] [int] NOT NULL,
 CONSTRAINT [PK_DoanTau] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoanTau_LoaiGhe]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanTau_LoaiGhe](
	[DoanTauId] [nvarchar](20) NOT NULL,
	[LoaiGheId] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_DoanTau_LoaiGhe] PRIMARY KEY CLUSTERED 
(
	[DoanTauId] ASC,
	[LoaiGheId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GaTau]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GaTau](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](500) NULL,
 CONSTRAINT [PK_GaTau] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoDich]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDich](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KhachHangId] [nvarchar](20) NULL CONSTRAINT [DF_GiaoDich_KhachHangId]  DEFAULT ((0)),
	[LichTrinhId] [int] NOT NULL,
	[ThanhToan] [bit] NOT NULL,
	[HeSo] [float] NOT NULL,
	[NhanVienId] [nvarchar](20) NULL CONSTRAINT [DF_GiaoDich_NhanVienId]  DEFAULT (''),
	[SoTien] [float] NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
	[NgayLap] [date] NOT NULL,
 CONSTRAINT [PK_GiaoDich] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Id] [nvarchar](20) NOT NULL,
	[TenKhachHang] [nvarchar](250) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[CMND] [nvarchar](20) NULL,
	[LoaiKhachHangId] [int] NOT NULL,
	[MatKhau] [nvarchar](250) NULL,
	[RuleDangNhap] [bit] NOT NULL CONSTRAINT [DF_KhachHang_XacNhan]  DEFAULT ((0)),
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LichTrinh]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinh](
	[DoanTauId] [nvarchar](20) NOT NULL,
	[GioChay] [datetime] NOT NULL,
	[GioDen] [datetime] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenLichTrinh] [nvarchar](250) NULL,
	[LichTrinhMau] [bit] NOT NULL,
	[TrangThai] [int] NOT NULL CONSTRAINT [DF_LichTrinh_TrangThai]  DEFAULT ((-1)),
 CONSTRAINT [PK_LichTrinh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LichTrinh_TuyenDuong]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinh_TuyenDuong](
	[LichTrinhId] [int] NOT NULL,
	[TuyenDuongId] [int] NOT NULL,
	[ThuTu] [int] NOT NULL,
	[ThoiGianDung] [float] NOT NULL,
	[GiaVe] [float] NOT NULL,
	[DaChayQua] [bit] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_LichTrinh_TuyenDuong] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiGhe]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiGhe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](250) NULL,
	[Anh] [image] NULL,
	[HeSo] [float] NOT NULL,
 CONSTRAINT [PK_LoaiGhe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiKhachHang]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKhachHang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HeSo] [float] NOT NULL,
	[Ten] [nvarchar](250) NULL,
 CONSTRAINT [PK_LoaiKhachHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [nvarchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](150) NULL,
	[GioiTinh] [bit] NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[NgayVaoLam] [datetime] NOT NULL,
	[CMND] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](250) NULL,
	[PhongBanID] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[Id] [nvarchar](20) NOT NULL,
	[TenPhongBan] [nvarchar](250) NULL,
	[RuleChuyenTau] [bit] NOT NULL CONSTRAINT [DF_PhongBan_RuleChuyenTau]  DEFAULT ((0)),
	[RuleNhanSu] [bit] NOT NULL CONSTRAINT [DF_PhongBan_RuleNhanSu]  DEFAULT ((0)),
	[RuletBanVe] [bit] NOT NULL CONSTRAINT [DF_PhongBan_RuletBanVe]  DEFAULT ((0)),
	[RuleLichTrinh] [bit] NOT NULL CONSTRAINT [DF_PhongBan_RuleLichTrinh]  DEFAULT ((0)),
	[RuleBaoCao] [bit] NOT NULL CONSTRAINT [DF_PhongBan_RuleBaoCao]  DEFAULT ((0)),
	[RuleQuanTri] [bit] NOT NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TuyenDuong]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuyenDuong](
	[GaTauDauId] [int] NOT NULL,
	[GaTauCuoiId] [int] NOT NULL,
	[KhoangCach] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_TuyenDuong_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_DoanhThu]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_DoanhThu]
AS
SELECT        CASE WHEN dbo.ChiTietGiaoDich.Huy = 1 THEN - dbo.GiaoDich.SoTien ELSE dbo.GiaoDich.SoTien END AS SoTien, dbo.GiaoDich.NgayLap, dbo.GiaoDich.Id AS GiaoDichId, dbo.ChiTietGiaoDich.Huy, 
                         dbo.DoanTau.Id AS DoanTauId, dbo.LichTrinh.Id AS LichTrinhId, DATENAME(month, dbo.GiaoDich.NgayLap) AS Thang, DATEPART(year, dbo.GiaoDich.NgayLap) AS Nam, dbo.DoanTau.Name, DATEPART(month, 
                         dbo.GiaoDich.NgayLap) AS ThangSo
FROM            dbo.LichTrinh INNER JOIN
                         dbo.DoanTau ON dbo.LichTrinh.DoanTauId = dbo.DoanTau.Id INNER JOIN
                         dbo.GiaoDich ON dbo.LichTrinh.Id = dbo.GiaoDich.LichTrinhId INNER JOIN
                         dbo.ChiTietGiaoDich ON dbo.GiaoDich.Id = dbo.ChiTietGiaoDich.GiaoDichId
GROUP BY dbo.GiaoDich.SoTien, dbo.GiaoDich.NgayLap, dbo.GiaoDich.Id, dbo.ChiTietGiaoDich.Huy, dbo.DoanTau.Id, dbo.LichTrinh.Id, dbo.DoanTau.Name

GO
/****** Object:  View [dbo].[View_GiaoDich]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_GiaoDich]
AS
SELECT        TOP (100) PERCENT dbo.NhanVien.TenNhanVien, GiaoDich_1.SoTien, dbo.KhachHang.TenKhachHang, dbo.LoaiGhe.Ten, dbo.ChiTietGiaoDich.Huy, GiaoDich_1.NgayLap, dbo.ChiTietGiaoDich.GiaoDichId, 
                         dbo.ChiTietGiaoDich.SoGhe, GiaoDich_1.LichTrinhId, GiaoDich_1.NhanVienId, dbo.KhachHang.Id AS KhachHangId, GiaoDich_1.HeSo, dbo.LoaiGhe.Id AS LoaiGheId, dbo.DoanTau.Name AS TenDoanTau, 
                         dbo.DoanTau.Id AS DoanTauId, dbo.LichTrinh.TenLichTrinh
FROM            dbo.DoanTau INNER JOIN
                         dbo.LichTrinh ON dbo.DoanTau.Id = dbo.LichTrinh.DoanTauId RIGHT OUTER JOIN
                         dbo.GiaoDich AS GiaoDich_1 INNER JOIN
                         dbo.KhachHang ON GiaoDich_1.KhachHangId = dbo.KhachHang.Id INNER JOIN
                         dbo.NhanVien ON GiaoDich_1.NhanVienId = dbo.NhanVien.Id INNER JOIN
                         dbo.ChiTietGiaoDich ON GiaoDich_1.Id = dbo.ChiTietGiaoDich.GiaoDichId INNER JOIN
                         dbo.LoaiGhe ON dbo.ChiTietGiaoDich.LoaiGheId = dbo.LoaiGhe.Id ON dbo.LichTrinh.Id = GiaoDich_1.LichTrinhId
GROUP BY dbo.NhanVien.TenNhanVien, GiaoDich_1.SoTien, dbo.KhachHang.TenKhachHang, dbo.LoaiGhe.Ten, dbo.ChiTietGiaoDich.Huy, dbo.ChiTietGiaoDich.GiaoDichId, GiaoDich_1.NgayLap, dbo.ChiTietGiaoDich.SoGhe, 
                         GiaoDich_1.LichTrinhId, GiaoDich_1.NhanVienId, dbo.KhachHang.Id, GiaoDich_1.HeSo, dbo.LoaiGhe.Id, dbo.DoanTau.Name, dbo.DoanTau.Id, dbo.LichTrinh.TenLichTrinh
ORDER BY GiaoDich_1.LichTrinhId

GO
/****** Object:  View [dbo].[View_GiaVe]    Script Date: 27/06/2015 18:50:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_GiaVe]
AS
SELECT        TOP (100) PERCENT dbo.DoanTau.Name, dbo.GaTau.Ten AS GaDau, GaTau_1.Ten AS GaCuoi, dbo.LichTrinh.TenLichTrinh, dbo.TuyenDuong.KhoangCach, dbo.LoaiGhe.Ten, 
                         dbo.LichTrinh_TuyenDuong.GiaVe * dbo.LoaiGhe.HeSo AS GiaVe, dbo.DoanTau.Id AS DoanTauId, dbo.LichTrinh.Id AS LichTrinhId
FROM            dbo.DoanTau INNER JOIN
                         dbo.LichTrinh ON dbo.DoanTau.Id = dbo.LichTrinh.DoanTauId INNER JOIN
                         dbo.LichTrinh_TuyenDuong ON dbo.LichTrinh.Id = dbo.LichTrinh_TuyenDuong.LichTrinhId INNER JOIN
                         dbo.TuyenDuong ON dbo.LichTrinh_TuyenDuong.TuyenDuongId = dbo.TuyenDuong.Id INNER JOIN
                         dbo.GaTau ON dbo.TuyenDuong.GaTauDauId = dbo.GaTau.Id INNER JOIN
                         dbo.GaTau AS GaTau_1 ON dbo.TuyenDuong.GaTauCuoiId = GaTau_1.Id CROSS JOIN
                         dbo.LoaiGhe
WHERE        (dbo.LichTrinh.LichTrinhMau = 0)
ORDER BY LichTrinhId, dbo.LoaiGhe.Ten, dbo.LichTrinh_TuyenDuong.ThuTu

GO
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (10, 1, 0, 17, 59, 1)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (10, 1, 0, 17, 60, 1)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (11, 0, 0, 17, 59, 2)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (11, 0, 0, 17, 60, 2)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (12, 0, 0, 17, 59, 1)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (13, 1, 0, 17, 63, 0)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (13, 1, 0, 17, 64, 0)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (14, 0, 0, 17, 63, 1)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (14, 0, 0, 17, 64, 1)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (15, 0, 0, 17, 63, 0)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (15, 0, 0, 17, 64, 0)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (16, 0, 0, 21, 86, 0)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (17, 0, 0, 21, 87, 1)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (17, 0, 0, 21, 88, 1)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (18, 0, 0, 21, 87, 0)
INSERT [dbo].[ChiTietGiaoDich] ([GiaoDichId], [Huy], [ThuTu], [LoaiGheId], [LichTrinhTuyenDuongId], [SoGhe]) VALUES (18, 0, 0, 21, 88, 0)
INSERT [dbo].[DoanTau] ([Id], [Name], [GhiChu], [TocDo]) VALUES (N'SE01', N'Đoàn tàu SE01', N'Tàu lửa được mua 20 năm trước', 170)
INSERT [dbo].[DoanTau] ([Id], [Name], [GhiChu], [TocDo]) VALUES (N'SE02', N'Đoàn tàu SE02', N'Tàu mới mua', 258)
INSERT [dbo].[DoanTau_LoaiGhe] ([DoanTauId], [LoaiGheId], [SoLuong]) VALUES (N'SE01', 17, 31)
INSERT [dbo].[DoanTau_LoaiGhe] ([DoanTauId], [LoaiGheId], [SoLuong]) VALUES (N'SE01', 18, 27)
INSERT [dbo].[DoanTau_LoaiGhe] ([DoanTauId], [LoaiGheId], [SoLuong]) VALUES (N'SE01', 20, 22)
INSERT [dbo].[DoanTau_LoaiGhe] ([DoanTauId], [LoaiGheId], [SoLuong]) VALUES (N'SE01', 21, 18)
INSERT [dbo].[DoanTau_LoaiGhe] ([DoanTauId], [LoaiGheId], [SoLuong]) VALUES (N'SE02', 17, 0)
INSERT [dbo].[DoanTau_LoaiGhe] ([DoanTauId], [LoaiGheId], [SoLuong]) VALUES (N'SE02', 18, 0)
INSERT [dbo].[DoanTau_LoaiGhe] ([DoanTauId], [LoaiGheId], [SoLuong]) VALUES (N'SE02', 21, 0)
SET IDENTITY_INSERT [dbo].[GaTau] ON 

INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (1, N'Hà Nội', N'123 Giáp Bát, Hà Nội')
INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (2, N'Đà Nẵng', N'125 Cách mạng tháng 8, Phường 2, Đà Nẵng')
INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (3, N'Nha Trang', N'78 Diện Biên Phủ, Nha Trang')
INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (4, N'Bà Rịa- Vũng Tàu', N'15 P6 Thành phố Vũng Tàu')
INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (5, N'Lâm Đồng', N'40 Nam kì khởi nghĩa,Bảo Lộc, Lâm đồng')
INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (6, N'Hồ Chí Minh', N'450 Cách mạng tháng 8, Q3, Hồ Chí Minh')
INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (12, N'Phan Thiết', N'125 thành phố Phan Thiết')
INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (13, N'Bình Dương', N'125 Cách mạng tháng 8, Bình Dương')
INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (14, N'Tây Ninh', N'45 Cách mạng tháng 8, Bình Dương')
INSERT [dbo].[GaTau] ([Id], [Ten], [DiaChi]) VALUES (15, N'Huế', N'Huế')
SET IDENTITY_INSERT [dbo].[GaTau] OFF
SET IDENTITY_INSERT [dbo].[GiaoDich] ON 

INSERT [dbo].[GiaoDich] ([Id], [KhachHangId], [LichTrinhId], [ThanhToan], [HeSo], [NhanVienId], [SoTien], [GhiChu], [NgayLap]) VALUES (10, N'KH01', 19, 0, 0.9, N'Admin', 234000, N'', CAST(N'2015-06-27' AS Date))
INSERT [dbo].[GiaoDich] ([Id], [KhachHangId], [LichTrinhId], [ThanhToan], [HeSo], [NhanVienId], [SoTien], [GhiChu], [NgayLap]) VALUES (11, N'KH01', 19, 0, 0.9, N'Admin', 234000, N'', CAST(N'2015-06-27' AS Date))
INSERT [dbo].[GiaoDich] ([Id], [KhachHangId], [LichTrinhId], [ThanhToan], [HeSo], [NhanVienId], [SoTien], [GhiChu], [NgayLap]) VALUES (12, N'KH01', 19, 0, 0.9, N'Admin', 135000, N'', CAST(N'2015-06-27' AS Date))
INSERT [dbo].[GiaoDich] ([Id], [KhachHangId], [LichTrinhId], [ThanhToan], [HeSo], [NhanVienId], [SoTien], [GhiChu], [NgayLap]) VALUES (13, N'KH01', 20, 0, 0.9, N'Admin', 180000, N'', CAST(N'2015-06-27' AS Date))
INSERT [dbo].[GiaoDich] ([Id], [KhachHangId], [LichTrinhId], [ThanhToan], [HeSo], [NhanVienId], [SoTien], [GhiChu], [NgayLap]) VALUES (14, N'KH01', 20, 0, 0.9, N'Admin', 180000, N'', CAST(N'2015-06-27' AS Date))
INSERT [dbo].[GiaoDich] ([Id], [KhachHangId], [LichTrinhId], [ThanhToan], [HeSo], [NhanVienId], [SoTien], [GhiChu], [NgayLap]) VALUES (15, N'KH01', 20, 0, 0.9, N'Admin', 180000, N'Ghế đặt lại', CAST(N'2015-06-27' AS Date))
INSERT [dbo].[GiaoDich] ([Id], [KhachHangId], [LichTrinhId], [ThanhToan], [HeSo], [NhanVienId], [SoTien], [GhiChu], [NgayLap]) VALUES (16, N'KH04', 24, 0, 1, N'Admin', 180000, N'', CAST(N'2015-06-27' AS Date))
INSERT [dbo].[GiaoDich] ([Id], [KhachHangId], [LichTrinhId], [ThanhToan], [HeSo], [NhanVienId], [SoTien], [GhiChu], [NgayLap]) VALUES (17, N'KH03', 24, 0, 0.3, N'Admin', 108000, N'', CAST(N'2015-06-27' AS Date))
INSERT [dbo].[GiaoDich] ([Id], [KhachHangId], [LichTrinhId], [ThanhToan], [HeSo], [NhanVienId], [SoTien], [GhiChu], [NgayLap]) VALUES (18, N'KH02', 24, 0, 0.6, N'Admin', 216000, N'', CAST(N'2015-06-27' AS Date))
SET IDENTITY_INSERT [dbo].[GiaoDich] OFF
INSERT [dbo].[KhachHang] ([Id], [TenKhachHang], [SoDienThoai], [CMND], [LoaiKhachHangId], [MatKhau], [RuleDangNhap]) VALUES (N'KH01', N'Nguyễn Văn A', N'0902496785', N'2504515441', 2, N'c4ca4238a0b923820dcc509a6f75849b', 1)
INSERT [dbo].[KhachHang] ([Id], [TenKhachHang], [SoDienThoai], [CMND], [LoaiKhachHangId], [MatKhau], [RuleDangNhap]) VALUES (N'KH02', N'Trân Quang Em', N'0545412455', N'2501542412', 3, N'625d45c587033e8970af8b4e3fdb575c', 1)
INSERT [dbo].[KhachHang] ([Id], [TenKhachHang], [SoDienThoai], [CMND], [LoaiKhachHangId], [MatKhau], [RuleDangNhap]) VALUES (N'KH03', N'Mai Phi Tật', N'7454212233', N'8457547451', 4, N'202cb962ac59075b964b07152d234b70', 1)
INSERT [dbo].[KhachHang] ([Id], [TenKhachHang], [SoDienThoai], [CMND], [LoaiKhachHangId], [MatKhau], [RuleDangNhap]) VALUES (N'KH04', N'Hoàng Phi Thường', N'1234545875', N'54785455', 1, N'202cb962ac59075b964b07152d234b70', 1)
SET IDENTITY_INSERT [dbo].[LichTrinh] ON 

INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-10 22:47:18.000' AS DateTime), CAST(N'2015-06-13 22:47:18.000' AS DateTime), 1, N'Hà Nội - Sài Gòn', 0, -1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-14 23:44:46.000' AS DateTime), CAST(N'2015-06-16 23:44:46.000' AS DateTime), 2, N'Sài Gòn - Hà Nội', 0, -1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-12 19:49:49.410' AS DateTime), CAST(N'2015-06-12 19:49:49.410' AS DateTime), 7, N'[Mẫu] Hà Nội - Sài Gòn', 1, 1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-12 19:53:22.857' AS DateTime), CAST(N'2015-06-12 19:53:22.857' AS DateTime), 9, N'[Mẫu] Sài Gòn - Hà Nội', 1, 1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-18 21:34:32.000' AS DateTime), CAST(N'2015-06-18 21:34:32.000' AS DateTime), 10, N'Hà Nội - Sài Gòn 2', 0, -1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-24 19:19:47.270' AS DateTime), CAST(N'2015-06-24 19:19:47.273' AS DateTime), 17, N'Hà Nội - Sài Gòn 4', 0, -1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-24 19:21:35.227' AS DateTime), CAST(N'2015-06-24 19:21:35.227' AS DateTime), 18, N'Hà Nội - Sài Gòn 1', 0, -1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-25 19:30:19.000' AS DateTime), CAST(N'2015-06-28 19:30:19.000' AS DateTime), 19, N'Hà Nội - Sài Gòn 3', 0, -1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-28 20:22:59.000' AS DateTime), CAST(N'2015-07-01 20:22:59.000' AS DateTime), 20, N'Hà Nội - Sài Gòn 5', 0, 0)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-06-26 20:24:55.183' AS DateTime), CAST(N'2015-06-26 20:24:55.183' AS DateTime), 21, N'[Mẫu] Hà Nội - Sài Gòn 5', 1, 1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE01', CAST(N'2015-07-02 20:57:27.000' AS DateTime), CAST(N'2015-07-05 20:57:27.000' AS DateTime), 23, N'Hà Nội - Sài Gòn 6', 0, 1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE02', CAST(N'2015-06-28 17:02:34.000' AS DateTime), CAST(N'2015-06-30 17:02:34.000' AS DateTime), 24, N'Sài Gòn - Huế', 0, 1)
INSERT [dbo].[LichTrinh] ([DoanTauId], [GioChay], [GioDen], [Id], [TenLichTrinh], [LichTrinhMau], [TrangThai]) VALUES (N'SE02', CAST(N'2015-06-27 17:16:48.820' AS DateTime), CAST(N'2015-06-27 17:16:48.820' AS DateTime), 27, N'[Mẫu] Sài Gòn - Huế', 1, 1)
SET IDENTITY_INSERT [dbo].[LichTrinh] OFF
SET IDENTITY_INSERT [dbo].[LichTrinh_TuyenDuong] ON 

INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (1, 12, 0, 10, 100000, 1, 9)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (1, 13, 1, 10, 100000, 1, 22)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (1, 14, 2, 10, 100000, 1, 23)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (1, 15, 3, 10, 100000, 1, 24)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (7, 12, 0, 10, 100000, 0, 26)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (7, 13, 1, 10, 100000, 0, 27)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (7, 14, 2, 10, 100000, 0, 28)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (7, 15, 3, 10, 100000, 0, 29)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (1, 16, 4, 10, 100000, 1, 31)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (2, 26, 0, 10, 100000, 1, 32)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (2, 27, 1, 10, 100000, 1, 33)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (2, 28, 2, 10, 100000, 1, 34)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (2, 29, 3, 10, 100000, 1, 35)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (9, 26, 0, 10, 100000, 0, 43)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (9, 27, 1, 10, 100000, 0, 44)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (9, 28, 2, 10, 100000, 0, 45)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (9, 29, 3, 10, 100000, 0, 46)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (2, 30, 4, 10, 100000, 1, 49)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (9, 30, 4, 10, 100000, 0, 50)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (10, 12, 0, 10, 100000, 1, 51)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (10, 20, 1, 10, 100000, 1, 52)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (10, 16, 2, 10, 100000, 1, 53)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (18, 12, 0, 10, 105000, 1, 54)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (18, 13, 1, 10, 105000, 1, 55)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (18, 14, 2, 10, 105000, 1, 56)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (18, 15, 3, 10, 105000, 1, 57)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (19, 12, 0, 10, 150000, 1, 59)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (19, 13, 1, 10, 110000, 1, 60)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (19, 14, 2, 10, 110000, 1, 61)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (19, 15, 3, 10, 115000, 1, 62)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (20, 12, 0, 10, 100000, 1, 63)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (20, 13, 1, 10, 100000, 1, 64)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (20, 14, 2, 10, 100000, 0, 65)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (20, 15, 3, 10, 100000, 0, 66)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (20, 16, 4, 10, 100000, 0, 67)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (21, 12, 0, 10, 100000, 0, 68)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (21, 13, 1, 10, 100000, 0, 69)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (21, 14, 2, 10, 100000, 0, 70)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (21, 15, 3, 10, 100000, 0, 71)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (21, 16, 4, 10, 100000, 0, 72)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (23, 12, 0, 10, 100000, 0, 78)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (23, 13, 1, 10, 100000, 0, 79)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (23, 14, 2, 10, 100000, 0, 80)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (23, 15, 3, 10, 100000, 0, 81)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (23, 16, 4, 10, 100000, 0, 82)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (24, 33, 2, 10, 100000, 0, 85)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (24, 34, 0, 10, 100000, 0, 86)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (24, 33, 1, 10, 100000, 0, 87)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (24, 35, 2, 10, 100000, 0, 88)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (24, 36, 3, 10, 100000, 0, 89)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (27, 34, 0, 10, 100000, 0, 90)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (27, 33, 1, 10, 100000, 0, 91)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (27, 35, 2, 10, 100000, 0, 92)
INSERT [dbo].[LichTrinh_TuyenDuong] ([LichTrinhId], [TuyenDuongId], [ThuTu], [ThoiGianDung], [GiaVe], [DaChayQua], [Id]) VALUES (27, 36, 3, 10, 100000, 0, 93)
SET IDENTITY_INSERT [dbo].[LichTrinh_TuyenDuong] OFF
SET IDENTITY_INSERT [dbo].[LoaiGhe] ON 

INSERT [dbo].[LoaiGhe] ([Id], [Ten], [Anh], [HeSo]) VALUES (17, N'Ghế cứng', 0x89504E470D0A1A0A0000000D4948445200000040000000400806000000AA6971DE000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000157949444154785EDD5A07545547B77E6BBDF7271A6341E9172E1D140445445112BB62AF2076C42EB1A3D8402C88BD445144B144130B96188D46632396D8506389BD2BF1B79768A47F6FEF7D18B8B600465762F65A9B39E7DC9939B3BFD9750EFF8397282B2B2B873333D3E94926BEDFF42DCAB83AC2D1C91AA5CB3860C0C03EF29C292D25950669E39854FBA1D02B0064666A82B120696929FC0413268E83B94529D8D95B65B335BA77EF8AFBF7EF4B5F1EA340FBE00160528228000685F683A97929D8D85941676D0E7B473B989819A349B3C6B87DF78E8C494F676DF917680093DAD18C8C0CBEC3A0C1FD616C6A042B3B1DB135F40E3628EDEA022BBD0EED3B76406A7A1AD232D273C67D48940B00AF9B58ED7E465626D23333E851262222C361A13385CED65200B0B2B7858D833D5C3DDC6162618E15AB1364B8F4CF06E04301E21500940F600078571980899327C0426F2E1AA02300AC1DECA0B7B7838B9B2BF48EF66811E02FFD993F5C0DC826A501CC9A5D67627E7C1C6C9D6C6069632100E8EC6C60EBE804C7D26550BAAC1B9C5DCB20E9E81119AFCC80FE0AA6FF747AAD0F50A47CC09A75ABE15AD60516B616A4FE7A58D86B00D83939C3DDB33CACED6C111F1F2F82A7A5A5C9D87F05009A396462EFCF7BE053D51BD68E6CFF7A98DBE909000702C0116EE53CC41C468D1A25631834A5411F02E509405656062E5EBE40DEBE0D1C5C1D6061A3130DB07122005C9C50C6BD2C9CCA94464BFF56B9BBFF0145837C6800F0F8F747E8D3AF379CDD9D4503748E36D0BB38C2B68C335CDCDDE0EEE509EFCA9570F5FA35119C7DC7BF480348200A6FA3C746C2C3DB8376DE0ED6CE76B0294D3E807201270F377856F62687E882C4DD3FC938064081F74FA73F0580851710E87AF69C59F0A95695C29E2DEDBEBD0060EF561A8EEEAE28E7ED253E61E1E245796B003FFE0729479E00286112D6AC42F53A3560696B45C23B88093000CEE5CAA2824F257188C3460C97711F3600060B64213232D8B165223131118D9B3681AD33095EDA5934C0A12CE5019E1E6202EC0CDB525A6C9810BD11847F10E5090097C41C09CE9D3B87A0E0CE62EB8EAEA5C501B2FABB9477877B252F94AF5411BED5ABE1D6EDFFCAF07F950F604A4E4E46EF2F4224F3E3F0C7EACF0E900170F52A0FAF2A9551B67C391C3E92244990CA077281E0F6F5A0FC9D9A9227008AFFF8E30F8C8C0897CC8F7300567FD6000681CDC0DBB70A1CCAB860F1B2A56202EC0798F20380A2BF03887C68008734CDA94D9D3E0D9E952A90063888F00A00D602D600E7B2AEE81F3AE80D1A902D20CBF8F76DF82B940F0DC8A0DD4C95FBD8B879A8E45B99769A0A21125E85418E041E152BA06C85F2A8DBA03E9E3CFD5DFA2B105EA0B704E09579DE11E51B00BEDEF4C366D4F2AB2DC9109B0003C02D03E05A5E8B067C46A02A43150E0D19991ABFFCDC901938C39A4231534E9BCD7F95F20580160A81434987D1A069433101165E69009B8100E05D11F6CE4E885B305FC6726DA0169C437C4B002821995FF41386AD46FCFBDF0880B658B6EBCB57AFA0498BE6920B7018E45458A2815B19C903CA57F4923019D2AFAF2C4EED220BC0D7292929D21A12FD2ACC7EE6C9EF0F70FFE13D0AA537F1DB6F3771F7EE6DA943F877E99B2D3C93E1F55FA13C0160921DA0F6C193C7E8D03948F2004E841408ECFDF97488230487C95AF5EAD2C29FC8783603B5C33C07F3CDDF92B17BEF1EF12961943DB60B6A8F868D1BA08AAF0FBCAB5624475B1E9E5E1EA85C85728BCFABA243A7F6B87EFD7A0E98EF4A78A63F05802907045A7A1A8537F6F2ACEE7A1716BE8C0602E5057C2AC467030C0297C7478E1DCD1138252D15070E1DC4842993D12CA015DC3CCBC9B96249735394B03045499D394A5998C1D4CA12267A0B98DA584AD5C97507FB9B4F8A17C1AAD509A23DCF9F3F136D3104E1AF009227004CA2C29CDED275D4C409D900380A00AC09CCACFABCFB1E153C61A6B3C4B26FBEC6BD07F7317E4234FC1A3584CE468FA2462550C4A8388A181BC1C8CC0446966628696D21E34B7B78485155BE4A2572AAAE3437559BE46B98CB7ABAE3CAB5ABDA62C41C349352DAF05E01502F901712040B972EA270A701A0D8DA991223D208D60206C7C2C61A9DBB75857F9B407CF44961FCEFC71FE1936245C541D6A8531B811DDBA3FFE0011815351A91E3C76078E448840E0D4370F76E68D2AA053EAF5D530A2C4EAF1914DF9AD5D1B14B27F41BD0173131B370EB56B2B629B4A6F70E0013BF40CBEC32F1C3D6EF51A1B227AC1D6C447005009B01FB064E86D827B01958D9DAC8FDF0C8082C5BB11C9B7FDC8AD5DFAEC31CB2FD49D327A37B480FD46BE4877215CB0B78CCAC456C46EC50BDABF8488255B1AA8FF81867371758DB58A17F7F72B2D99BC2ED5FF10B796B00094D5867BF2C03BF9C38822AD57C241962C10D995599A382B45431B60F0E92D47823E50F61C386A276DD3A70219FA1B3B61441F80B130BC611C4A38217CA795524FFE029A74CEC27DCBDCA89493118AC095E952B49DFE0AE5D5E50FF97852F0818F906805FC81AF0DF3BC9F06B5C8F429F0BAC9CECA1232158786E99734CC3D15EB243DE4DFE78626A6E063D690403C05F959C0924071A6F63672BFE416F43F3D8D1BD83A3681217565E3E64025E1524B9E27B66D6AA79F3E344480EABAC992ADF7899F34306006802BE4C0C404696F2BA99789EFA146D3A06D2229D05004BF2D23AE75C2078F73932F0C71373BD953844534B0B9432318619016163A7872B658F7CCADCA2555374EE1284D021833169D224C42F5A888435ABB13D71174E9C3A2979C78DE4EB181C162ADF21878D184A7D07E1D9332DD57E99B44D2A18E50B00D60006803342F206E8DB3F84922112DEC1564E88995960AE12392962FF6069A383A5DE5AECBA014581F05111F88ACC6167E20E12EE38AEDDB88ADF9F3DA137BCF85E8699F9796A0ACE5FBC20FDBFE81B4239412504B46E815509DFA05BB72EF0F7F727F082111515854D9B36213555AB570CD3EFFC50BE9CA0666F19F2B598DB29D326CB4EF2071156496B0707DA692BB40A6C8DF193A3A960F28615C5F3BEFDFBC84931ABAA222520132F32F5790A926FDCC4BE7DFB101B1B8B018306A27EE346925330801C3A8B1B97809995398A16FF944AF26168D4A4218A14FD944CCB52B44A676D25CF4E9F3E25F366A4E57EA8E59C8101E6776A7F5FA47C01A021AA8AA20C2424AC1407A6B3B5220034DBB5B0B4C2244A74E216CCC580D03EB077D063E3C6EF687466CEEE30B15A73521311390A010101F0F1F1819393134C4C4C50AC44710997C54B9514B331B7D2494865E677152B559CB2C2B618183A00A5CC4CE51C920F63390731A77CA29CA7074E9E3C2EEBCDF50BDAD72D43E00DA9000068618769CFBEBD7028EDA87D29CE06C052674D765D0563C68D421DBF1A746F8A0D1BD6536F2DCF4F4848406060A00057A86861FCA770217CF2691114A71D3636358179B6C0EC33143308263A7A4EBE84DF55D2AC14FCC90CF81B85392551B6F6DA475A6627F249A63A3349A953539FCB5A590B942630BF8E0A0C00B737926FE2B39A9F8B9DB309E86C6C6167EF8812258DC8610D242FEF8432940BCC9D1B836FBE5906BF06F550A850217C4ABB5BCADC58988533A6C8201182AE596075CD4030B30958DAEAE563AC0DA5C53CAE6DFBD6E8D22D8854DF54C0E4CFF4CCEC77ECC82F953031C2EAB509B2EEFCF8837C0360D8F2F1187B65465C1649CC218E6D316CE820383AD9626CD4184C9E3A09853EF9181F15F998E2BE5EFA29C195F0863B6E28380BCDCC3503333BDD52E625D1A9737B74EB112CEF5626A0B48081E0F9ABD7AC81070F1EBC20F89B40C817004C3C01B372883D7A75A55D308685DE320700537313F4EBD7070D1AD6A55A60A954779F1A1515FB649B658195D02CA80501C663D535336B940844790433471766AE09CCF466E20382823B88A0EC843987E09699C73128C54813972D5B26EBCE4B0BF204C07030B72A250E276FCCFF36C3C2313300A54C4AA2F717BD244C8E9F1045365E182696A630B6C8B67162A5EEAC2D5624BC125C769D846100945AB3402C3C6B025786A614095803DAB40B8011E515DCDF104805063BD2E8E868592F3B606E5534507228CAB7063029005803162F590063B312F29F231CA258A09254E5F50AE98EC831E118353A02FF57F83FA2AAFCBB5A24B792F991A06AD7C486E99A8557CC7DB8BF8CE128404E90ED9B352020B0A54404EEC3F3BD0C42610A9151D1E3455B7335408B062F538101D02241261277EF80A94549DA7D3361CEEF8B95288AEE3DBB60F8C830AA17AA4AFC96859123B3B2D7D25C2528470E891EB468C918ADC93F5869C2B0867054E1B1329E9CADB53D95D3258B89136CDDA61539DCE29A5FC9EE6F6E654D739053A67E1C65E6C72F90352BC7FD262A30000ACD078FEFA05C053718199367372921CCC94F48DF1EE814DC4EFEA9CAC4AC248C4C4B101350B450169C5B5E34336B0D9B0FFB11DE3901868A24FEEF33BD9EEEAD08082B33998BFD4D91621FC33FB0399AB76A0CA352C5E4B9858E349022028F63908A1BD373D2CA4B972EC85ADF491854A484CFC84CC1EF4FEFA167AFCE702BEB885AB57D51BD860FFC039A50AE1E42296A205A0534C4A0C1BDA90AEC8BD0C17D30745828860F1F8AB1634763EAB48998F9E554E1397367625EDC6C2C8C8F453C2551B1F366216E7E0CE2E6CDC6DC39332994529F3953306B168D99198DA54BE7217A6204AA7EE6899EBD3BA14FDFEE7075230749FE88D952678298393368B5B9E7057F466FE10338AB4BC7E1A4BDE4E8C22929E94AE9E920B2CD5622F08143BB7028E9275CBC7802C9C917F0E4C97F69214F9145A0218B4F97D919A5E3CCE913484F7B46D76954DCDCC7FEBDBB70E3C605BAA7D438F9128E1F3F289C94B41B870EEDC4C183BB9098B819EBD67D8DE5CBE7A369F3BA183D760866CE9A80D0D0DE98316302562CFF8AE63D2EF3AB6333D6803FA3B7D2004A34C9BB3EA65477159A37AF871A352A51B2530DFDFAF7C4B6ED9BB17DC70F387A6C3FCE5F3889A7CF1ED24825B82A7C32099847D9CFD271EEFC29CC899989D554E8A451B59991F95C9E1D38B8073B776DC5A6CDEBE5FF95D77DBB0A8B16C72266EE14346C580B8D1AD584AFAF17D6AF5F993D9736B7146DB2D6F70000BF20338BFF419AC3CB53040505A056AD4AB2231D3BB5C6B7EB13B065EB467CB7610D7ED8B2017BF725E2C8D1833872E4300E1F3E48BB79403829E990B4FCFB9AB52BC914BEC4B8A8487C43BBB8F5C74D58B36E15167F158F39B1B3A8C68826B51F87D1E3C211353E4234CDCFEF7302A106AA7FE68DAD5B362283349313B4FCA6C08A0A0440EEA49A16F04E85F409A6CCAB229942B0D87BB3E6F5D1A16320D9F714DAADF958B26411D9ED12498957AE5C8EB524D8868DEBA450DAB4692381F53D69CC1652EF9DC2DBB66DC58F3F6EC1CE9DDB739EFDFCF35E1AB316ADFC1B5398ED88ADDBD661EDDAAFD0A4494DD4A9E983FDFB77D18668A7564A0B5EA5D73F7F0B13506A4560100863C60D439D7A5528EE0EC7F69D1BD1B0516DF4EADD150F1FDD953ED28F1697BB80D733CD2AFC7ACAA4F9EEA06FBF1E0478109E3DBF83A3477793F9D5418B66B5A9023C487DD4F707ED7D6AE7B5677295CD2F528100502493F3373E7AE9B8F12304000662C3F7AB2412F4E9DB931CD90D2949993919C93FA7CA4EAA719CC9F139C4F51B97D139B83D715B3C78948C1D3BBE43FB0E4DD129A805CE9E3D2A6B511AA0019E3F2A30004A03B232084DF2EA53A78F434B7F3F026218366F598B80D6BCA8B6F2592B2F52BBF422BDBA4BFCECD2E573046E33F2336D90420E9801E8DEA30D811D840B1794E757BBFCBA395E4F6FA101D92A960D40DC82E968DFB119C2470D406CDC54346FE987BAF56A202A6AAC242357AE5CC1B56BD784AF5EBD2ACCCF2E5DBA44A1F2222DFE82FCFBCDF9F3E7A53D73E60C4E9F3E2D7CEAD4299C38F10B0E1EDA87E02E1DE157BF169A34AD8F858BE6223E7E267A8774C0C041DD68BE5F695DB91AF0DE00E01D63E139C666A6D3CB0880E52B17A073D796E8D1BB0D85C2CFD0B55B070C1F31185DBB0663E4C8E1888C8C444444440E8787874BCBFF5AABEED5B3112346D0989172CFD7DC8E191389D1545B8C0C1F2AEDB0E183D1B69D3F5AB4A84BC277C1175F0449BEC1421B6AC0EBB5EB552A3000AACD92EA2A0D4B96CE11E1C386854842B47ACD72DCBC791D972F5F24BE9CB3EBAC01FC8193F9E64DFEFAFB9BF0AD5BB772F8F6EDDBB873E70E99CF5DE17BF7EE495DCF39C3E3C70FF1E8D10369EFDEBB85989889E4143B212C2C84E6B998BD31CAFEDF13004C3CB1A81ABDE8B7E4ABE837A02B4644F4C190A1BD917CEB22F55009C9FBA4746CD8B01C8387F424CDE847A09E9588F4DE7D80EC3C317B670660C38604346A5C8D727B52E9D18370FEE2714992F8770649312F8C59BBE7856A0ECB905FEECBACDEA7989FF1DCFC8E356B962292DE3994342F216109AD4E7D20E110981B06F3A2B702808560FB1F38B03739A51AF872D6588C8D0AC3997347B504890479F3027277E84D7DD473F53E450A141676E5CA4518153990FC4D1FB46EDD58CC8281E5B52973D0E8CF35225F00E42E485B044F78FDDA454A47AB232E6E1AA64C1D2589D0C95F0FD16FBCBBB9C7503C26F75A0326BFACBDF3C56B4DAE4CAC5AB5182346F6C5D4A9A325255EF6F5227AAEE5112F6AC03B0520F74084CBD7C0C02614B60E53891B468950188E9F3C40BF69BB90ABC22F02F026327CC7EB889FF39C0C00CFC36A1F467E67C58A0558BC788EE41F69E9CFE437DE805C7A8700680B20C148CDDBB56B29F5F9C3873728540D21008648196CE80378DCCB766DC8FC9BD874F6755ECC7D656E2AAD972F8F17FB9F3F7F3AEEDFBF41D9A82FF6ECDDCEAB94BE0A470DF4770480367106CE9C3D89DAB57D29CC9DA25AFE36468F1E4C21B03F7E3EB08D7A29F415F205E7DC45BF89D3C807C46348582F2C5CF825DDFF2115E28489A365ACA62DF498485B7BF6CD6BA8400030FA3CD9CE5D3FC2DBDB5D3CF18103DB2989198808CA0439343D78788762FE15DCB8C97C1957AE9EC7D56BE770EDFA456A2933BC7A1697AF9CC1858BA771FEC2AF02E6D973A770FACC099C387914C77E39249C74643F65807B7138E967EC3FB09BCAE65DB4C33BB163E766ACDFB002317326501418207E60C4887E947D56233FB058D6A76D94B666D5BE890A6C028CF01FCF9F90D04350B7AE2F39425F4949274D0E47E7CEFE92068F191B81C953A23163E6640A91E3317DC604CC8E998AB8F9B3103B6F262D7E9A1C7DA9E3AFD879B3B1807CCAFC05733137F64B39D29A1D331DB3664F936B6EA7CF988469D339F9E90197327AA9035878BFFA55C517F1A189F6F156F99B770880220D00CD99652195763F11F5EA5545DBC086881A3F141D3A34473DBF9AD8F8FDB7D895B80D3FEDDE21273A893F6DC3EE3D3BA4E59DE45D3DF6CB611C3D76480E4B8E1D3B22793FD701A74E9DC02FC793F0EBE9E33877FE5729822E5FA13A81AECF5F60AD394DE16F38162C988DE8E8707A674B2C5D3A9F5697EB770C01D0D4FF1D998022F6F2E919CFE92A05B366466148680F127AB998C0C9535A699A37AB85E52EF0D545BFC91FA4E3E183DB544C9DA202EAB89C37A6A468A741050300F87FB6FF65D6D09C0A620000000049454E44AE426082, 1)
INSERT [dbo].[LoaiGhe] ([Id], [Ten], [Anh], [HeSo]) VALUES (18, N'Ghế cứng phòng lạnh', 0x89504E470D0A1A0A0000000D4948445200000040000000400806000000AA6971DE0000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA86400001CFD49444154785ED57B677455679665FF9AB53AFD9B35B57AAA7BBAC6AE72B713607210CA3967A19C7378CA59424202948584482E1B1B0C36C920033650600B8A6804186C9193C8981C844089DDFB7CF75DF14428630FF6CC9CC5F10DEFDD7BBFBDBF73F677CEBBF2DFC1688F1F3F56DB818101E572AC793F8FFBD03F00F4F60DA0A7A747797777177A7B1FA1FFF100FA799D781FBDC7E88FE80F8DFE80DE6DDC97F3E2F25DB9E6516F8F7A0E9FA8B9F1D93F69F295E77DED45E75F60430878DA65307D03FDE811E77764E0FA5607789F7EA3BF0F9DF7EFE2C88F57B0FF5C27769F3C81AF0F1DC497EDDF62CD9E9D58B9631B3EDFAEF9DA5D3BB169DF5EECE8E8C0B5EE6EF4F27A7986102904C8735FCA5E3501620AB40C82FBC48E01EE0860017A877EBEFB01F65EE8C4FA43FBB1A8ED6BD4AE5E81A2C51FC230BF05D1F5D5089E5E0EFFB252F89616C3A7A408DEC585F02C29844B7E0EDCF272E0929305B79C6C7817E4C23B371786BA1A9CBB7393243C56249892AF1E6E0244764D0E5F990D21404C85B4CC069F76EF612F36B5B7E3C30D5FA172F162E42D781FB175B508AC2887DFB4A9709F5A0CE7D24238951529779C5AA8DCA1B400F6046E579CA7DCB62857F3FC6CD8E565C39EEE989B0DF3D818542DFCB3961A8CA221043C85F8A9C357664F4580B8713678BC71FB4E84169722AE7936A267CD46687D13FCAB6BE031A302AE1565045D029BA27C587286AD0BF3945B7176C52D0BB23039375DF9A4EC34E56659DCCF34C0222B03D6D959B0494F854F7A1A3AEFDC56A960AA3F4F8CA1A8FCD7B117122022B5F22F5FC39DA11AD2D88C90A639086A6A81674D2DECCACB61CD10B728CCC7E4FC5C9831BC27E7642A37CBCE18DC2AD039066DCB63338216022673DF3C331D7642444C34D6EFDDA30963DFD028D088F84D09D034405776112A274326BCA6CD805F551D7C6AEAE136B30A5625253023F0F1D999184F10E30846B6E213786E3243DD940CE55924493949C8E077D3D260999E8E099111A85AFC91D29AFE7E79AA360EDD64CF341E9ED8AB216690009D715D03E4A1277FBC06CFAC3CB8974E830749F0AAAA8573E574581415612223632C818FCD30600CC358B64284103089F9AD13A0CFBC7976AE729D80090603CCD30D98181F83706AC93D596EF954D325588DCBE8CFDA6F40C0EDDE7E44964D875D661E9CA756C065FA4C385454C2BCB010937248407A86023F2A2D456DF50810D7675F27C02C93A4300274F01201135293313E3116B609313876F58A564B300DE4E142C450FB09C0834CFD3C625E488084A3E4655ECB7C4C8A4F8253F154384EAB546E51548C0959D98A009975997D713D0DC42789E0D12732E7276591884CF1EC4102C6A5A6627C4A1226A42560746800D6B04610DDE9EDA51C12881E014FEC3722405CD8EFE9EB55CBD3EC35AD18C73C752C94656E9A22C0AAA84411303E330BE318D263096E8C906042C6C44C02CDA03630CC652B044C64CE8B0B011352523136298124246058B03F2A3E58A01558C6CA50276010D7D3F6C20F5E1101BD5C978580D57B762BA1B2CBC9817DE954389757C2A664AA4A012140039F81D14C01715D0F04F838439A72D917E012F6839E9C825149F1189D1C879111A1F036A4AA8AB297A0F431A82D518ACBBEE938759C7AAAE89FFF6202D4438C5B4901C94551E6F673676197180FCB0CAA767E1E5CA8017653CB60969BA74540462646A5123C0108F051DC0A09027C6C1AC3DC0858665D4890D0D735604C72B222617C621C46F9F962C3FE763C12D03A786EF57D31055EB6EA68A8E963D729D3ED0931CFB72104880B78B5CF074B7172BEAB0B7E2C5F270909547EE7691524A01CE6F985984855171246A731EC0956481057A2989A82D129C9189B92A25CE5BC0919B295F3A3929906498978D3CB13E51F2E44179F799F65A8A4834C80B86883B8EA498C7D83B822C40850C6AC9120AB89B69C8ABD3401BAC9051AEBFD0CC701D5ECE4CE6AC4E888700A58164BDC3296BA15B02C2C25F85C8C24F8F718CE6392093E49032BC0472725615462A2DAAA99E6BE2911FAB9F7E2E3312A3E16C38383E04EA23F6CDB8ADC96B9A858B4089F6EDD869D274EE2CC9D3BB8C771E8A408197A772A622DE3956315B9460274E03F9B00319D00BD0B9CF7F94A8C0C0B55EBB86D5129EB7B46405E29C618B214012A05087E4C82065C800A40D9EA2EC7A65120E78480910909782F361AA322C3F1BF9C9D30CCDF1FD6BC8713C9F6649AF973C94D6BA867B1B4089F6CDA80DDC78FABD2B98BB886448738C72B3D45DF40EF60EAFCA208D02F12219434F8F42F9B303224582D6196F905B02E28660A147319CC66F8A76B2990A291A0CFF88B0810D78F15595C0946C7C5627454045E7773C5EF269BE30D57370C0B0864D445C22C310576D41977EA8F7F4931C2D988191AEB1421CBBED9821DC78EE2DCDD3B4C9DC78A04097E95C60342CB13124C71E95BB12104987E20FB2AD7B8BFEFD4494C8A0AC798F8382564B20C4A0A8CCBC851E0350D60456804651AFAB23575FD9C9A7986FFC8B8188C643F308E51F0BA8B33420972C6E24FE04642877BFBE28FAEEE78C3C30BA342436046A26C583CD932C55CA835A24D116CC8F25A9A51FFE92758B76B070E9F3D83AE473D468DD0D2E36FD90B2340B8E8EB676344664FFC781936D11178D3DF470D5A945F44707C3623C0A8FE92F723296623126295ABDC1622E2133032360EEFC5C462541C973D1EEBE74644C76018677E18F5654464185E737244CB8A656AF9BDCB67B71F3F81F757AD46D99CF970E5B5EF3242DE7076C45BDE5E981815A552C5DA90A2DC8DCB747061315C1935874E9ED22281FA608A475C4C8E757B2101429C6CF77F7700AB377D89C2590D70484EC498D85855DABA4C9F01BB320A619681C0E3093A1EEF71391BC1DA5E7C38BF37224E033E3C2A5A81957D7D2BE7864546E19D8830BC437D19161E823F393960C6DCB96A29148193614A208BF85DED7E88AD1D3FA066C92708C861FDE11780B73D3CF01F1EEE181E18004B92EFC94A73C986CD3873F51AB54013480D8BA4C4CF2440EFCCF6B255ADAAAFC607CB96617E6B2BC2AB6722B4A911212DB311D8340BFE0DB5702C2F52BDFEF0B86805687874A402290005A80E768873A6DE0D8FC0DBE1A178932BC0BBC18178CDDE1645F5F50AB4E88FFA398EFDC8C33EAD3D57424717424E5DBD8A2FB66D5313E3919880097EFEC8A96F54FDCBEDAE87B87BAF4BAD0C3A1E668348C2E0B16ECF10A0ABA7CEDE850BE7904B018AA2C015343422A26A26FC66CE803723C0AFB616C1CD8D089BD38CF0D94DF0AD9A019BBC1C95D76F85850C1220B3FE2E01BF1D163EE86F850870CE3A67EF8F4CAD377CBDF1EF5696286AA85320850079BEC481FA7D82AE4499BD82FE838D1E1D3778EEAFDF1F42C7F9F3E8E60737EEDCC5AD7B0FF0A8C7E4F70521E0E52240803F118F7BF7EE219ECA1D9F9787202E4BBEA52524A00A6EAC067DB9F5ABAA46507D03421B672172760BE217CC474473135C286652E04878CB0C0BE87738E3FFC9507F2334086F0406E18F0153F00701EEE58ED719CAFF32613CAAE6CF532B8FF4225AE83E719D1025CE742144963DA957840C1539DCBF7DBF0B07BE3F8CA327CF686419F10C92A1D8D0EC6F12A0BECC73D9B2FC70098CADA8C064869B2B49985255838099D5F0609BEC593E1DFE24228411123D7B0EE2E7CD431C8144B534F1FC4CD8338286B39FF803C5EBF500CEF6143FFC8939FC1A55FE7F7B79E10FAE2EF89FD6D6F887B7DEC4A275EB86143CD21BC8FA2E4074E0E2A68064BFBF5F2283A471C4DDBD7DD8B0A50D7FF9669BB1B9D2A2594C03AF4DAED83304C8876A0D65392AFD80DC70D1679FC129700A8AE6CFC578AAF618E6FA7BE1E15C9FB3E159324D91E056520ECFB269089C518D50E67118AB478984A43FCF87E1E30F113B77363CB864BDCD90FF574707BCE6E2817FB375C27F9F3819FF347C94F2B79DDDD0BA672F0E5DBA8CE3D7AFE37277B77AA720840819DAD08D29D1D73348829C53EF2E1ECB9A05A5196BD66F24095BD58FBBEA7B22087240D327567C90009D21F5086189874A077866F3B6365879BA61E6A285545B766FD1E1F84F5F1FFCDE814B5240101CF28AD4AF465EE5157067A5E8513C15BE953330A5A61AB173E628F0A97F5E80B2552B51BE72053C0AF2F18F23C7E177E636F893B327264725C0AFB00CF175CD88AFAA4762552D0C14B49279F351B76409966EDA88ED870FA3F3D62D45885EF048B8F71094B816195208035DD484CFBFDC88B61D7BD4F895A02B26F414788A8027E0C5243C8CCC923961F7E0910ED87B7A603A67D3233783652B959E79FD476F6FBCC1D255046D5858041CB2A9116515F02E2D8723EB044F364E9202C175D58861391B3ABD12CEE919B067292C24491A05D7CD4258E36C04107860550382B90DABA94744752DA26BEB11C5D48AA9A945EAAC66E4CF7B1F2DADEBB0E9C0219CBA7143F5297A74C8DCAB9583DBDB0F1EE0D3D5ADF8AEE3A8C2ADAF686243B1BE200534D7BE2C5FBFC952D397955829973FC3EC46BC1BE4871114B2D73C59A505F8127C18FEE4E3C3D076C27096B0D6C90678B16112A1F4282F53EF0FACA81D362C8E92092C6E7A153C0B0B10CC552480E9E247A07E3504DFD08C29B58D9852DD40AF47504D1DC21B9BD44FF2F12D0B90D8F23E929BE7C1D03C17250B3EC0BC356BF0E5B77B71B0B313770852C89022EAC2CD5B58C202EA64E78541023897C463C46442C273087862F23D953FDC2F9F391D0E043B253F0763C2833122C81FFFEEEA80D7991A6FFA78E33FDCDCF1AF1636F8FB7746E0BFBDFD1E860745C03E375FAD06F2226498BF1F7C58A81CBB7E1B67EF75A365ED5A98B10476292984C7F4E904DE8090FA6646438BF290FA26151DB20D2331F24E22829F47F1B3F89679485FF0210CF316206D4E0B72E6CD45F5D24FB16AD74E9CBCFF00BB8E9DC0C2152B708D5DA48C5DD70A53D7ED391AF0C484355D07D6AC6FC5785B6BB8C446C12C826BBC9F277E6F6BA9CAD77FB3B4C53F8F188DFF31C102C37D43E05D540EFF1935B0CD2980597A1ACCD2D80845CB7511686358DEE5FD6ED39BD67C8E5111A1B06211E5405DF09D3153A543246738BC793623A211418C885021802E9F85CF22414D2D88689A43A16D424C4B0BE228B6894D4D88674465B2952E9A33171F313A1EC86AC1D1EB04883D8DF32722402F88FA71F0FBFDF00B0BC4A22FD7C12A2C08637C3DF0BB7163F14F6F8FC0EFCDEC609D9081D0AA26CE580B7C98CBDED575F0AAAE814BC534768FB9EA07D0E1A1C1B06513D4C61AFF06EF7B83830B2D2FC1E8E8508C4B8AC584D4449291C9D429857F4D154258E585B0BE1017D0A14C85E08626A64D23EB8F5AF890B080993311C8E80C66711646BD89648A45554E475E7D2DCE5EFF5169C2F35FB868F69304087BA209B7EF5C4774622C0A79637B362F7F3037C33FBEF50E46B8FBF3810D88AC9BC3D99987A0C639F0AB6B823B054E5CDE24F91188575D0D1CA9056363A2E09393ABF256147DF1B62D1813360513526231363916E3D84F4C4C4984057B0C97A92508E0F552680970F1290DB3946678CEA08E5454C28B04FB5432E22A2B95FB96515C4960606E263E59D7AA2D9F6A129F052FF64202B8A8185D5B77A5D0A86EACC75867278266E5E6E0A03A32F79C42D81A726091960DC782527855B23AA4A04D61CECA56DE2679D5D6C197E13C85213B85FB2E5959F878FD97387DF326966DFB06F65C5ACD0DC94C97144C6667272EAFCEEC0BF3E15E3E4D559CFE8CA800DE4B44D3BFAE0EDE5555F0A828873B01BB9796C253BCB8085E4505F029CC835F761AA6CD6B560488126A13F93352809728D709104A56AD6D857B5424AC23A361C3BEDE92CBD9A484644CA2EA4F484CC578FAA4947458E7E4B33A641DC0FC15127C29705E9C35F14086B12C738D4B9662C3EE5D58FCD57A0450242DA91396D9E9B0CC3428B7CECD86530901319C65A67D586049D80B1902DE8761EF3EAD4C55A56EA54570CECF85634E265C7332E0919D0AE7C46814CDAA55AFDE05FCD304E85B1302B4503735FD4BDADB9A7EECFBFE203CA9DC428019DB5FA9F52725A76262128920096604AF3C8D00327339B069DAA0B99CF95471D6388B7E75EC2267D4A276C9226CFD6E2FD6EDFA2B321A6AE0CA72D9AD7C2A1C3883566C772767185414381414AAE554CA6DEF8A99AAB690A8109D9015C689CD972B35C699E4D9A525C0DE100FB7F444B8C485A3AC4923404B0115086A4235549ABD14017203F9ECD28F5761983A15D65473738297575B0256C00B0913D9310A21662969B03064A955C0B18033C4E2C8772689A86E643434C3BFA24ABD08D9D9F11DB61E6A47C5C20588A8ABA5C851E06AAB55EE5B66672AB7CACAD6482891502F834B51098BAC7C569F79BC772ECBF17438512F1C3392619D1409C7B468B81B62E01C138C860FE7ABCA5026502A61F981478BEB2714FC8D1430B24512F4F0B9FBA00B73177F0C7B767416F171CC55CE7C2A973902D6C027739BC47392C7E96AF0D65979B0CB2D844B317B85F22A92D084A0E9B5CCCFF9D873B4037B8EFFC01E8351C1900E9D3D9B5D257563FA343815515B72736043C1140204B87361A1069E1162C308B163AAD866A4C0293305CE8604D82544C2393902BE996CD82283F0E9DAD55A85C8D25870E8136A6A3F4980DA375ED8FDE821DA76EE44191B1D570295EACE96A5AD05DB6571F394149221E0D360CEF342824482A4837D4E911249D7528672498522A0FDC45145400909F0A3A0296163E528332BE0A5361077292A522E792EE0ED5937D866A4C18EC22933EF9C990497B478382544705C6108C888837F7C24761DDAFF0C014F93F04202745321638C0009A5BD7BF7B239DA86655F6D40A8BC2E8B8D872301DBA551C0288A8A086ECD793C3995799C96A9919091079BEC0258322DAC0C066453C9BF3B73127B8F1E447E6335C1A4AADC97A2C88662262DB444816B7131A3A7001EDC77C8CE80B5214901B765CD609F9A0017E6BBE4BC2773DF39210CBE29E1086014945657E07ECF438E5FCA60ADAB958649E09B52F0E20830B2A5A7813AC744DAB97D0776EDDAC39E7B800C337C59A4B82771165252E19491314884A485290156E9B95CEAB23031351D13626310CFD6F8C0E9633870B20331453918C5224934C582392D7F47A4CD7E2E9CB8A439B3FC168577C848659F110B4B2ABC0D0B27574322BC3293E19D91089FB458F8A7452228250231E971F866C7560554DA66F5FB068F14169E1331D4ED27234091A047404F2F766DDB8923870E6BC7F4CBB7EE6071EB17882C28802B05D035334BFD8E6F61600A2802A8056919B04967AD2004C892C9B238AA289F11701CBB0E1F44A0ACFB5C559C8A8A39E3A52AD71D08DA4696451137BA2567DB26250E5609D1B0A2C23B71DF87B9EFCD8808E4B237C5108BC0E47094571763F7DE36A6EB0325DE7A1124A6E330B59F4540CFC347D8B975073A4F9E5534AA9BF3FC03A6C6EEC347504C15F76424B810B4131B1F1B468484BB10202E8488684E6435185190838E0B67B09695A06B54387C09DC7BDA0CD5463BE6523318EE56E9492CB0E260C12AD18A6E991809BBA4683826C7C0834B9E1F433F982404A6C6202C2D061F2D5F886327F6E3EEDD4B1C9EF10F304D40EB4498DA4B11A05FF8A8BB076D9BB7E0C2D94E7EA0312AF79725467E94B874F336B56113E28A5895910479D7E798C9D9A7625BA7A72B6D304B63B1141B8DF0FC6C1CB9720E0B3F5F0627AE2A01256C9B799D7D76B61238F57B7F4A022C085880DB24472BF032F3EEA9F108C84C454846124253A3515A35157BF6EF62B97E9529FA15BABBAE727C9AF0BD3202E4DAFB6C35D732DC2F9EBF30F899DC5FBFB1FC2071FECA35B4EDDD87A9B35B5434B8A7B3A6678363CBADFC5194BC669F101DAE22E0F8D50B98BBF46398FB7AC12B9B955C368592826A951CAF5CF2DD223E1C96B1A1B0A5AA3B7099734F89811F67DF97C789B9A958B1F6335CBB79519E8E5BD72FA27DF7660CF4DDC6E381A17F6821F6F4B1D84F12A0954FDA455D5D5D685DBD06972F5E1ABC916CEFDFBF8F8B17CFE3CC9953B874E532EB856E9CB97C158BD6B4229ACB976B4AB2D2067B468344814440686E3A4EFC781EF3972EC4244F17D8C6C563520C6B0B0AA4797C349D257752148F4360131FCA252E0A9E0C7DDFC42804254560D6FB4D3876A6038FFAEEB1C0E926E047B876A513DF1FD84EB1BEC381BD78ED37B59726406E24E1B472F90AEC6FDFA73EBA71E3062E5DBA44F01771EDDA556A82FA7347F5BD7E565DF282E29B6FDBD59AEFC39AC0857AE0C468B0641115CA66E5F8D57358B0E4034C7473507F2F382634141323C33039265C099D3567DF2A36182E24C29BD1E01611848CD23CAC5CBB021B36ACC4918EDD7C9EFC1936FBCAC70F70F9C2091CEBF89639799F84A836E827ED590284B0A748D3C18B7DFDF566AC5EBD0AA74E1EC789E347F1E0C183217926FBF27D1148392DFC9DBE74056BBEFE0649D32A0926050EB1B18862B32311F0D18AC530F77281437C0CC68404625278302C6242611317C1B08F800BF3DF293A088154FF067677E7A91B172F9E42514E22CA8B92F1E59A8F70B9F32045E806CE9F3A88F367B8425100F5B5FFE747C05304E8E0652BEB6957D73DECDCB91D2B577C8A9B37283634D34A4B032E84F09ADE1E1C65ADD0CCD5E1F32FD6A3FDC831547DF831C398E2C59EFF140958BE7E15AC7CDD61CB591F1DEC8FC99C65DBD8303832059CB9758908445A492EB6ECFC2B7AFA1E69B9DDD7C58175E1C70B87D1B66925967F3207DB36ADC2F7EDDB70FF960820C193007D4CA6F6D4E14BA4004DBB8984B684D5004E9C3C82E52B96E2AFDBBF4177B784A05625AA3F71E3E7E2A78F1FC1C20573515E90873FCF6EC277FB0F286D3841FD58B379132AEB6B70EAF219B46E5E07330F27988705E2BD293EB0880A816B620C9C78ECC728F8E0B38F7091E2263F79AB5915EFD788909916BF7DED223A4F1FC1DD5B578CE738216AAC3276AD917BE243EDA50950D5146F2A79DE4FC1397CE41056AD5A812D5BB6E0D6AD5BC66F0EE02C8570E9928F51C22A6E76432D7E68674EB224E58878BDF63AEBC69DDB387ABC03672F9EC6C6B60D98E8640DCBD0408C0BF287757890029F35B5083BF6EFC1430A9CACE98A7CE31834D7FE906BC0A83BAA2C53C085008296DC937FAF8A006DABFD3EA8DF54947FE3C68D686D6DC5D1231D685DB312952C71EBAB6760E7B66FF0E8A188131FCAC10CF469A9A15DDB87FBF76EAA5CDEDBBE1DCEBEAEB0F0F3C6441F4F04A7256169EB2A5CB9799D4FE075C65AFE79E1ACCC28D043C7A6D90BAF31B197224037D307A919A1C94AD0D6D68615CB3F434DF5746C5CFF051EDE97658803A14B5A68C039562301FD7D12113DB8C208F8E187766CD8F2A56A5D6B983247CE9E522F3C05BC69296B0A44EDCB3FA9C08CC7CF7C6E34D3FDE7D92F20E0890B2031A90F0E1CD887152B9661D3C6AF38BBF2FF9768E228DFD1800F15C8AEBB3770FAC4611C3BFA3DCE9C3D8E5B776EE2FAED5B6AC6D52B2EFD276DBA40D0B7CF33B9F72FB59F45806E1A01B2D56755EBB98F1C3982458B1661E1C285AA3610D309D080D318017BBFDD8DE6C61A1CEFE0B275F6047A1EC95F07123A3B37D118F57DC21D7C136C042FFB2F633A212F43CCCF26C0F4E6FABE6013CD918176767662D9B26558B0601E3A3ABE579F2BE3E752372C5BB208E5A505787F4E132E759EC23976848F1E6A858B69B88BCBFD74F0FAB39E352DA29EB5179D1F6ABF380274D36756FD41155DECFAF5EB58B76E1DEA1AEA5933ECC4EDDBB7F1359BA8BADA6A34D656E18BD5CB71F55227AEB317E83C757C300234E0EA1683A6C06BBB2FB0FF0B04989A3E5BBAEB76BFAB1B9BDBB662DE82F998FFFE0254564EC3FB8C8AFDFBF6A8755C0677E17C27CE9D36A68012562D559EBED7AF69FFC70408107DE9D107AE40F058FE52ABFDBB0358BE720566353761FBF66DEAFB3DAC0B24D765193DC7349014D0EEF3DB01D7ED954480BE3505A00B99BC54397AF2044BE1562C5DBE0CA7CF75F22CC54D08601A5CBC70763005F4D97FAEC9E95F819B5710019A3D4B84B15E1012E89D972F6253DBD758B1FA731C3F7D8ADF640A5C3C8BF3E74EA39711F1E4BA27F71962FFAF1320663A681D8C1E059224D76EDDC4EEF6BD58B9663576EDDA81D3A74FAAAEB2AF573441BFC658C9C9B262B45F01F7A0BD52024CCD9400DDE5BFF7BAEEABBF3EDDCC8668DFBEBDB87CE9825A02D57799021219CAFEBF234046F99C91CA29059E004DABBB1B37AEE1DA8F575463A5D7FA621A091A81BF85FD6A040C02E2465C8EC5251DE46FF7841671F5EBADBCC2347EAE5FA76F7F5D03FE0B1B7495FAB19F5BB70000000049454E44AE426082, 1.2)
INSERT [dbo].[LoaiGhe] ([Id], [Ten], [Anh], [HeSo]) VALUES (20, N'Ghế mềm', 0x89504E470D0A1A0A0000000D4948445200000040000000400806000000AA6971DE0000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000184749444154785EED5A075856D7B2E5BD249AC4DEC588B11BBB5183BD8B80A22888BDF71A1BB1D7D8156CD8150401A9D2447A93DE3B220828282A0882800A88596F66FF1CFC259AE4DEA7DEFBEECB7C8EBB9C7DCED96BED99D9B3CF8F023EBBBCA9D47F0FF99B80CAF22FCB6F95FA9F227F135059FEBF95BF09A82C7F2FFF69B6FE01F99B80CAF2BDF2DB6F7FCE40759EFEAFF1A6C020FF4C59DED71665A5CACBEFDAEF79C6FBF4CD9B37A294C67E0E51E0D7C85E2525283C890AD14735BEF08EC8F7CB4F1E6FDEF649A5546791AFCB0BF7CAEBE7160506C32A40CBE9DBFE7795FB2A7EA3FFE500893A378904F9B17F45A5E7C9BFAFEA999F41840BB0E9F124E495FB644AB8E494E7252B65F7712926CB7D157C4DEA7B3B4E5CAF94B7402B9F25075C7E6CF5F253898234615156304A9E1923E1D9914A7DACAFE90EBA242B2BFB5F93C594BF162AD5DF505941E5BBFA06AFCB64FDAF5FCBDAACE5E5E5A2CD256B45055BE0EF89F854A2505E217B3968D541934319D5A98FC10890F2CAC0AB6BF53155CAD724AD6C5351A5529BF15553265022E19313C0E66E636303D511233061B40AB45555A1367830D4860E81CAA0819830722434478D82D61835A11355D431597D3CA6694CC4F4F193307B9236164C998665B3E660ED92A558B37891D0550B160A5DB378097E5EB418EB97AEC4BA652BB161C56AAC5FBE0A5BD7E90ADDB2E117ECDDB10B47F61DC0B64D9B71E1DC796125EFB8D72714E102393939F0F6F4A249EC43F3BA75607AE13CF66CDE820B0606D8BE4117270F1E82DEDE7DD8B571130C8E1C15E591DD7B707CFF01ECE6BEC347B08726BF53F7179C38B01F07766EC7CE8DBAD8B3651391301FDBD7AF23E02BB17CDE7C2C993D07F366CCC0AC29533077FA742C99B70043FB0F449736EDB169DD065C333725F0E42215E5049E827125119F4A14D8E7642E0078BBBBA149ADDAC8BA930C7B2B1B24C4C4C2C1DA1A114141F0F3F0808B8303EEC4C78B32C8CB1B910181F074BA81F8B070B83B38C2EB8633D21212111EE48F004F7784FBFBE1868D15427C7C11EAEB070F6767DCF2F484BF9717BC5DDDE1E5E68EBBC977B077D76E688E51AF7289F2F252015EA69FC10544F021B3B3B3B642A36F6BE1767424CC8C4D104200AF5D3511C4DCB0B7858D8519A2C242616B692148F07675858DB9B9006561620A6BB36B880E0D879BF30D38D9DA8A31D78C8DE1EAC86D3B7A9629EC6D6CE93D36B86E690B4B3373840787E09775EB317CE06054BC2CADF27F5EF9CF21550430F39666A682803BB1D13037B98AE0C020985E31828F873B5C9C1C0541B19111A274757484AFBB3BACCCCDE0EFE32D08B03235477C740C8DBD418439E0A6A39300CD25B72D4CCDE068EB003B5B7BD85F7780E5352B44864760C39AB5183660906C2721DC8C5DF2FF4F6E01FC02DE869800934B97D0E0EB6F90121703F32B2608F60F1096E0E1E20A6702759D568F27CC2BC82BEA79D35580F2A5F86166642C08888B8A86839D3D1CAFDB093567D004DE9EEA26578CC533ACC9ADAE5FBF8E6BD7AE2182DC67EDAAD518ACAC4C3B906C1E8CB93A706EBDDBF371440441C902CE9F3A857A356A22353E56000AF4BB4516604C267DB38A8090A06072054B8A0DB6F072711396E2E3E149E4190AB26223A3C43806CF445D23336742AC2DAD70C5D008565656B0B4B4143B8F858505C243C3B082768F7E3FFE8837AFCAC43C3E4400274C1F5BDE21C0405F1FF5BEAA81B4F838185F36840F05BA2B972E0B13762112AC08389372DDCA1A7696D62290F138B6102680C98A260B61B00CDE964AB6003B5B5A6D7205231ACBAB6E4E718389E06BA1140316CE9D07E55EBDF1FAC5AB4A022AD3EDCA49B270FDE3C3AFE602C70E1D41839A5FE36E7C8200EE7AD30517CF5F10009800CB6B16F0A2D5660B6012BCDD3D0401AE14FD8DCE5F14F7B085F0AAF3582ECD08385B048335A4EB666666303535850DDD6F4AD6C3E3E7CD998BDE3D7AE26551312DB32C00327C56C9123E1901FC328980FDBBF6C862406C1C0C2F5C842345EFF304CC8CA2FB4DF6770B2BDCB871938059C0D8C8046E2EEE3877E62C9C680BBC70FA3C2E9EB9005F6F1F9898981048735CBC7819E7CE5DA0B6290C0DAFE0F4E9B33036BE8A4B642DDCC765606030B4B575D0E587AE28297A21004BCAF2A9804B22F20089804D94F434FAB60EEDF589D03F7A0CD76D1D6170EA1C2527D67077F386B7D72D8487452324380241816148884F86879B27FC7C6EC182C69C3A71461075F2A481B8D7CCD412F676CEB8E9E20917574FDC7076838FB73FDC5CBDA80C10E5EDA4542C5DB212CA3F0D42D1F3976252C202489984EA96F0B14510C0CAA6C7C1A879C3C6488C498083BD33926EDF457C7C2AB2B2F270FFFE133C7E5C80274F0A919B5B84FCBC12E4E63C47DED3623C7EF40C69771F203E2E858889849D9D0B1E3C788AF4F46CBA3717999939B877EFB14C331EE13E9559D4F7949EC3CFCB7AF0047174EFC3EC5CBCA24028598044C43F2B7F449A744D81575FBC84DA5375A661F4B051C879988B1725E5C8CF7F81C2C20A4A955F10A00202F29488C84546C61364A43DAED27BE9B276E63DD9351E979C9C89D4D4874849795055177AE781D0BB29B2FA9D3BF77197C8E3FBD2D21E223D2D130505CFC5A25459812879D2B2894B93FF23807F55C469503C948C406BA20EBA76EE81A4F81494D38E54F0ECA5009F99998FB454069B83F4BB8FC4E45392B3AAC0C8806409A0C94959B89D9849D719603612E3D3911097467DF770E7365FBF2FEA7C3F2BB765F587E27A62420A59D26DB2B61C022E730779D0D5E57F4B8220808FF5A52F5F6382C624D4ABDD0841FE61E4A341C2B41F3E2C14E07982293C4102141F4BAE41CAC0E26252AB34262605D191C994DC24E2966F2402FDA328CAC752F29444FB7D82A8F335D6E0C01804DC8AA46D300E6121F1E23A3F3383DCE6597E31DED0823036619C54612224950891C0CBB7E5F5CFC86351287B5D2E0878515C8A1143553062F818F2E74CB8DCF416BE9A49BE1F137D1B01FEE1080CA0E0E71F81E0804801464C9E944B06C47D4101D1823C67276FDA328304094C4A6C748A202226EA0E12082803E6FBA2C213101D9188D89864DC4DCD4236B95F6E4E01C598E778FEBC58C48432CA102B2A18888C94EA220FFA43603F344610C0ED278FF3B078D10A3CCA7E8AE2A2529414BFA695784141EE3959421E1E5250E3C0C5A4B0B2CFDFCFA036F9FFBDCA58C0EEC12BC8D71F70F023F2B84F68BA6C3CC70B69BC203883355BDC974E312035E59E505E84B4BBF78566A467D1FB9FD0DC72693E8562B7606298148918796180EFB396F7A9425959190D04BD3403C78F19A0F4D51B3C25F6F328CA73107C4671804B6EB3E650E47F42BB01BBC7A3EC7C01948961B01CE1256530AC1230A92EB579B55353327FD7CFBB89D4772F834B0A90A4E969598294BBA9F705411977B304710FB21E5711F3EC59215ED089B2FC3583AF64A35224C0D545E1D52B4A3F49784F3F7FEE325E95CA0860D0F204E417BE125A50F04AF47180640BE1AD2C87B6322624FB615E1521BCBA4C840C88AC94EAD5096295DA4C804482749F7C9FD44E4FA5E09BCC6450C0BD9321941791952D262BF391B06ADE514A4BF95B235B057EF7FD51A1B8B8585422C26370921219262097D8942C203FFF55553D2FBF48802F2C2C452111C15A905F8A6779440E8D9191C196F114D9596F5D86B7395EF114DAF278DBBB7D3B03C9959A488910E71BB793D285C627DC412CED0271B154525C88A592C72725A6D12251B0A57674549250BE2E8D93B593A87D9B624C3212E352111FC3F1269988CAC003228403BD482BE50C41E1D9B367C29FFCFCFCB167F77E71ADB8A4ACCADC9F52A223CC9FC0E73F2BAEB20AB600A14480D04A8B282C7821DCA8E47939721F17D2CE914E412E1EA101E1B8E513045FAF00F879078A3A97DCF6F1F4878FBB1FBC5C7DE0E9EE0377CA10BDDD7CE1E9E24DC1D415D6E63630353283CD355BD859D151DBD6093728C33437B6C0A5B38630BE745528D74F1F3F8363874F40EFC009E81F3C89E3474E42EFE031E8EDD7C7A13D8770E2E871ECDCBE039B376EA2BC24150A4F9FE60B336102264ED48297A71FB19D22B6228A8F222162501C0C5999109965C8B947A5B27B643F7A0A5F9F00DC7472A7B3C1659CD53B8D433BF66397EE56EC58BF19DBD66EC4F60D9BB1798D2EB6FCAC0BDDE56BB076E12AAC98BD847411164E9D8945D366618ED614CC9A381993545431BAFF408CEADB0FC37AF5C1C05E3F6240CF5EA2ECDEAE3DBAB66E8F4E2DDBE207A57668D54811DF376E01A5C68A68D9B005141B2A5266DB5468D33A0D8536FCA636DA7CA704ED495A64C98550E0848349F0F4F4C4F0E123A13A661C34C64DC4C2054B854BF8F9069119670B22F86B39BB4841A10C30A7C4C23A2465172928C1C1437AA85BAB216A7F551BAD1BB5C00F8AADD0BD4D07F46CFF03BAB5E924CA013DFA0A1DD67B1006765786FA60152AFB62CC80E1E8D7B52781FD0903BAFF88C1744C1EDA8B0077E90AB5810331BC6F5F68ABAB61589F3E5834632654870CC5AAF98B314B730A964C9F8735B493CDD399893D9B774047531B1BD7EA62A6CE749CD53F857E3DFAA0799D06B86C7056B841696929147273F3084C01999E17860E1E06AD4953309E12222662C890611839620C34276863E58A35E260E4772B08D93979282DA36334252B4545E5023CC70D560EA0ACDE1EB7A0A9A6899EED3AA1730B251CDAB50FD3B5A7E2F8A1E3984113BA72FE0A16D18A5F3875118B672F83BBA317664F9903ABABD6983A712AF4F71E85CE041DAC5EBA126B96AFC61C9D19E2191B56AF83E1F9CBA2CFCED256B4ADCC2CB165FD1618E819E00499FFAECDBBC4F3972F5A264C7ED9C2A5F020F71ADC6F081A7F530FE78E9D14DF1E39FE29E4E53D231025F0F1F245DFDE3F415D6D3CC6AA4F80CA6875A8AB8F1364701F13D1BFDF60F41F3004E3276861FD864DB86A6A2182165B047FCE7B5EF40A39B9052210E6E5146296CE2CF46ED711ED1A3783CD550BCC9D3147F8F16C32F1EB967644C44C185F34C3C279CBE1E5EE8FE953E612181B688D9F8C3DDB7FC5B8311A58BA7805266B4DC574ADE9D8B47613E6CD9C8F53FA0658307B21F9FC65515E3E678825F39762DFAEFDF875DBAF58B7720DC580239831791AF5EDA531F345ECF8A997B220E0349D7439FB2B292981C27302CF9956504030DAB66E87AF6BD6C66E625A5FEF24A610EB2347A862D8D0D150531D2F5C4355551D23468CC2800183D0B74F7FCA1C553077CE42189C3E8F683A453E2FA424E56505B2EE3D82D6382D74536A8D56751BC0E8CC794CD4180FB32BA650571983B3274E4363CC589CD43B85491ADAB0B77684E6D849B8666201B551EA0280FA6835ECD8B6139334B5B06CC112AC5FB556803138760AF3A7CDA6675EC4FCA973617CC11873A7CDC5F68D5BA1BBF2672C983E0BBF6ED90E2D750DD1D6D1D084FEBEC3E8DEBE339AD6AA875387F5840BF0F70785E2929722150E0A0A41FBB61DA0A0F025AE1899A2ACF4370A86A9E23CBF6FEF61CC9C314F801D3C7828860D1B2688183F5E53B8CAD02123F193F2400C193A12AB57AD83B9991505D35B18A7A28E2E64FE4ADFD686D1E933501F3E0A2ED7EDA03278083C1C1CA1ADA6016B13334C220BB335B5C444550DF2CFF398416E78F2D0514C1EA7814D3FAFC30415352CA0E0A83376023446A860DAF84918DA5B19DA64A57D3A7585EAA06122C6FCD4B92BBAB5A680D8B2253A2B29A17DF3E6E8A0A888364D9A092B6CD74C11CDEAD425720FC80820EC0AC52F4AC4D617121286D674B382C27FE3E2052311F139EB7A90F584D2D01CB1BF32B083070F63D6AC3944C2080C1A3404A346AA0A9761EBE092C95056EE2FCAD1C3471001DFA15DFD86501B3098825A4F2CD4D1C1C8DE7DB04C672A26528C994920C75320631D4E517E50D71E18D2BD17FA5084EFAED40A9D9AB540C7A68A685BAF115A7E5387B4169A7F55134ADF7C8B665F7C09A55AD4AE5103ADBEAD85965F7F8356B529F0D6AD8BEFEBD441FB860DD1B67E7D7468D488ACB01E3AD073F8879FC37BF70A02D8FA155E96BE125F5C828343D1BE7D477C450F373232A6ADAF841295346105F171C9A2CE1916E7E6D1D1B1B0B5B5C3CE9DBB859B8C51198BD1A3D4643B88C6048C1B371EAA6A63A1365A8526DF0C1D1AD044EA354067C5166853AF1EDAD76F800ED4EED2B8A9D0EEB432ACDD9A2BA24BD3E654B64037C5EFD085FA3A53BB33AD60175AC11F1A36A16735AABABF2311CB201920F7B5AB571FADEBD443AB5A758432398A4454D31A35D1B2761DB46BD244107060F7EEB70448A9B0B7B72F9AD0FEC91670E1C2251118A3A32881098B427048049D0643458EE0EAE20937370FDA36BD45C944E8E91DC3B2652BA0A94901930227BB07971A6AEA68DFB809DAD7AD8F6E8D9AA20FB9435702F343C3C6E8D1B4297A366B861E4D08305DEB4AE0B85F069008A37BD875146BD04A7FF9359A7E51134DFEFB4B34A2556FF0C5175565C31A5FA319816D5EBB3E5AD66F4C664EC47DDF0EBD3A7486326FA7CA83442CE8D85209DF37692A2360C74E41006354E09C980F09A9A96958B0601174C8343D3CBC909DFD18E1E19162DB73F7F0C10D2737D8DA380837600BE18F9DC78F9F14DFFFB83C7A541F5BB76EC7E2C54B3165CA34610913C68E43DBC68D65AB432BD3B6765D018CAD81578EB553A326628579C57B297D8FDE1487FA75EA82A13D7E848AF200680C1F0DED31E33193F6744E90F8D7E61DBABFE0E0CE3D224E18D23CAC691B74B9EE043FCA2083FD02111D1A8984E844DC4948415A723A1E653EC6907E0328419259C0AF5BB6D22E50490083E763A3BC30297CB26212F81355226D7561A1D19414058A8FA30E0E4EE20B317FE13D77EE1CF4F5F5B17FFF41ECDAB5075BB66CC3FAF5BA58B4688920A00DADAC12059E413D7B42536534053C754CD39C8859DA93696F9F827953A761E99CB958B76C39B6EAEA8A9FC90DF48FC388F67A2BDA6639E5F576F3412025646181E188A4334B6C740212E9F0769B32D6249A5B329D272495FA12E3647A3B81FAC8857B77EB8556646D8D2956F0AFDBEF102091C0872206CF47643E41151773BA4B094E0E9FF4F8C84B27B1343AC424A7202E2E01111151080C0C849797179142D6616E01038333D8BB773FD6AC598771AA6A684BE6DD9CD24F8EE8BA6BD761D58A9558BD7215562E5F8115047AD992A542B9CED774753762DBB61DD8B5E3571CA0ADEBC4F1D33847FBBD91A129AED199E0BADD0D38DD7083CB4D4F787AF889AFCCB7FC821018102ABE5687854689835D44782C62C80AF830141D19876E1DBBA04DF3EFD08C5C65E72F1B0501858545B2BF13940890C86022F8D8C8A922C708DE2E589990A2A2229143F3212A3737174F9ED0F1372B0B1969E9888B8915B1C4D2D21A7BF6ECC59891A3C4D6F35DED7AB4F2E3B0834C6FC7B6ED642DFB71F8F061729BA3557AE4C8118A257A3876EC184E9F3E8D3367CE0937E3DF252E5F328689B1B9703F1B6B3A0C39DC843391C09FD53DE8F0C49FEB6F917506FA872088AC24382802218151080B8E4254781C026E05A30BA5DF1D2927E1545822A0CA022491EA121992553019D2395AFE3CCD96C249D4CB9744CE733A2D3ECD43464686B00CB68411B4B575A580A444818DF372BD23FA30343484B3B3337C7D7D11101040DB6F88D0D0D05084858555951C7FF8396161116287E21F50588383C2690C6948A4B8C62BCE63A3226285F2EF16A12114B8E9F4C9DF36C3681C9F30BB920574EFD419DF914BEEDDBA8D40FE2623401E380BD7A536974C001321A93C31F2D7981026822DE3F1E3C722500EEAD75F4463B6024E7FF99722061F131323AC86FF32252F8F3F5A1488FBE455EACBCFCFA7C3DA5331F6C913FE6DE26DF9E8D12311A71E3E7C48CF7B88CC4CFE6892893BC969E2CB32EF6271B149F0F5F643D3064DD092B6D99AFFF50536ACF959E02B2C7AFEE13F9595274592EA7DF24431096C1D7CC060B7613718A8DC8F4E7CBDE9A8DA06ABC8C79D9C9CC50A337876231EC7F74884CA97529DF5ADB595897B58996CD6172F5E5429BB27C7AC9C1CFE18C3DF21EFE1EEDD74242424E1970D1BC5B63C63CA543839DA8BE7BF2AA3D3A040504DE481495ABD5D5DA509F3E4B8CDBF00F7F9B137465206D899CE18870E1C44525292F808C1ABCA1366F0F280E5557AA6FCB3A5BAD496EEE5527A162B13C6419C0F3B52CC92FE744FA4BD24D2F83F24E0AF088F959427C38193EBF6F6F674B86A83F6A48D2843E33F8E60B3E6C0C924F1380980FC33FE1991BF4F22A83A31AFCB287E914AEFE57BDE4B80F4B0BF3219F9B1924A2F6590BC45F24FEBEEAE6E78909945A7AF6261B6BC423C461E3CD7AB3FAB7A5B5EE5EF7DFF38D91F5949E3E4C7B30A4BA040F8C118F0211137578AFC03E5955FC644C80BFF152AAF00F7579F8CBC7E48FEEC9A74FD6D9D099591FA5EE12330FDFB8709F890549F844402AFB4B4DAD235F9711F5BA4E7B3BE4BB4CC22AAB73F0A01D2CB58A45212BEF63E91FADF4E48A69F4EAA5B84ACFDD12C80A5FA2A4BCAFDB416C2EDA4BECF2FD50990C94725E08F44809755FF45F22F26E0DF55FE26A0B2FC08F27E13FB9DED7F645F78E751FFC8732BE7F1490910C1AEF2455552D9FE5881B0EAF15595BF28623CF03FDC19AD9AB91E973B0000000049454E44AE426082, 1.4)
INSERT [dbo].[LoaiGhe] ([Id], [Ten], [Anh], [HeSo]) VALUES (21, N'Giường mềm phòng lạnh', 0x89504E470D0A1A0A0000000D4948445200000040000000400806000000AA6971DE0000000467414D410000B18F0BFC6105000000097048597300000EC300000EC301C76FA8640000113A49444154785EED5AF9771CD599F59F34BFCCFC9064269CC9095B201002041F0E64424E9273E264026320303631090602C6C436962CBC69B7366B6DEDBBBAD5AD5EA4DED5ABBAD5AD96D4DAF77DBBF37DAFFA49A572CBB2866048EC3AE7FAD5AB7A5DF5EEFD96F7BD928FE1013F1E0A906A1FD8E3A100A9F66B3B7652D83BB653F8761C0F0548B50FECF15080547BE8B1B3B3DF918F7A7CD5DF7F5DC7AE00DFC404BF0DA29000DAA474705F99F0FEFB7C6D1FE8DA36FDCB4305A8BFB5435752F7B5BFFFA6FB1A01E4F9417D3EB4FDFD075364C8637F5FFD3C2DF8B8DF7D21C026350CF5CD3BFB3B3B5BE29C5B35B6B11F7BF7A4C54900D5F8BDE76BB1FF7DF7AB9F4600228B0D71AE4C58B9BFBDAD88205B0926BDB5B329B0B9BDA11AB343ADF20CEEEFFE7E675D3C7F6B7B2DF59EF4EF53CFE7EBECAB42603F94C9ECB7F8FEEB8A85E96C17EAB17BF71581E475E5E50A7186724DFD5CA5BD5F382627A686DADA026C35EE532B2DB843D7F9014C713B6541ECEC1153FAF43CBAB7BD43D6268B6F6DAE60636301EBEBF302DC17CF4ABD97212776BFA0F20039710D04A91431269F22B2BDB18C8DF525416465650ACB7313589C1DC5CC441CD3E3318C8F0C60742888A1A807F1881BB1011782FD56785CDD307537A0A9A114F168BF789E14F81B1140589B0832A9B5E5392CCE4D626E7A0C13E3C3482607911C8ED044FD88843C8886DD18083A31107020ECB7C3EFB1C2E7EEA196E032C2E7ECDE45BFC320E0B37751DB054F5F171C9636988DF5D055E5223FE722F4ED3A126F46F1AC944749EFD34E548DBFA758C736B65649807544831EF81C3DF0F619E0B276C26DEB12ADC74A93B7514B04185E7BA72024C81151BFCB80805B69255931A64F2F7EE7EA6981CD500F13916D6B28436559362E5F388BBF9D3B83C2DC4C8C0C85859749E22297D0D4D24D560D9979D2DD3B0A8EAD8B385C473CE416644364519FDD00BF83AC4824FC443A60D70B727E07B54E7D8AA41EEE5E22686B83D3DA8A3E266A6C82B1A31A5D2D9568AA2A42DDED7CE84A73515D9C8DAA926C94DFBA8E5B0559C8F8E2637CF2E1699CFFE47D34D5568870E27CA188A0504B375935EE5580C3BC853C40496A93C303705B3A117499E0B2B412DAE1B676C0D1D34A166C8455DF80EED66AB43794A3B9BE0C0DBA52D45517A3BA3C8FAC9A83B2A29BC8CFCE44F6B54B64D92C9417E7A1B9AE1A467D1BEC3613BC0E1B427ECA0591008613510CC722A2EFEEB360762AA924CC94083C3139F13BC049339538D5E3D4A48E8263BC447182E3C4E5B474C0696E83A5AB16C6B61A345617A1ACE02A0A6F66A2E046066ACB0BD1A82B477B4B3D0CEDCD14CF9D44AE1B2E7B0FDC0E4A704E1B02FD4ECA19414A7C2184433E221BC7F8D828A6C692F48E31CC4C4F6276660AD353943417E6B0BA3887917894724E92F2D0BA98D42ED9140ECA0BEA31DA7BF70A65192445E767927050CC5A0C0D68AEBD851B57CEE1DCC77F4256C605B272292C463D22411F65F5882035369CC0E40427CB24A626C70521498EC1E763C911CC4ECF6062620293E313181B4D6274780443B138064261F47BBC301929E738ED480CC5B0B2B48CED4D224CD8D9A2096EA76A092AA824B6B6581026AFDCDB1341DBBF134C98B92A2B5C4A00A12E5D5C981D83D7D9037D6B156E667D866B573E47635D15EA6A6B68D932C2EFF36224318CF1E4181119C7C4D838A62626313D49D624F03993E4318391285A9B5B60E8A21CD2EF432844DE101C40281046D01FA0368848382A44888469B91C492039328AE1A18410899FC3CF63F1161717B1B6B686CD4DAA34092C8024AB1CD213F60490E4D243F178D91721A0083081C19057C4785DC52D847D1EB43737A1A2BC0C5EAF1B43434388C56288C7E348C487101F8CD1DA1E112498647F7F3F7C3E6AC9AA3D4613E5885AD1729F05E1DF480199200BC82D83C93371BEC7E70C45E8E4EE751684313F3B8785B9792C2F531DB2B121A01584C142C8D09190D7E518C631AEDF5911AE01E2033E38CCEDB85D78038DB53AE4E7E62137371781800FE1701846A351C0E570C2EBF6506143D6256B46490816687C5CF10CB6DC124D729E5AF60E26292D2BC94B8F51F7A52749AFD2F6F99CC1E339ACA6A7A731333323303B3B8BA5A525F296152ACE56C95BF68A2B865A0C2904E398A8C2B6D7B1B9362F2AB758C88E92BC2CBCF7EEDBC8CDCE415151115C2E97885DB684B4204F64666A5A90E5C971CB7D8676E20C794F0BF57DF98CB9995971CE90E73C46B68CA9296A53024C4E9230A9FE34E51E065F5F5858204F59242FA1523C455C92DFF580DD98D85A2601FC188DBAD0D95C81A2826C5456DC86D1D08D4482129EC65272D2D22A72F21292C051217F2B5B2980BACF61C004B51EA0F449A8591A4B7D45183216618212F6DCDC0CE590BDBD8710405977C93DA8264F2642188B79C452987B3D1357322F892CCDF1CB1EC0B1295BF6041644ED15D24ADAC9A76BB590D7396C665502F3756EB92FC7720E601118EADFCB6B7CCE46E1F90D0F73EE8A8A44CC398A3D8289336F86B20AB01A548E72593A32E84122EC440555707F39F3BFD0D5548924C64B170B21C1094D8AA11644ED11EA09CAC94948126A327CBE48ED5C8A783AF038F93C1ECFE752209E03CF855793587450AC309CBF7CB48279BD5E3A0F881C213D802104905E3031416AD1AE6D344699BCB31EAF9FF8155E7BF515B1A4F1035908069F4B41F8658A18497AB932014E78EA70E1894BA272F28BF30B0A6155BBB4B0285A494E8E97C499A8043F9B09CBBA623012A364AC9066C8D5C9ED76C36EB7A3B7B7579C8B7C40AB9E34BC2884448797C2F9292A74FA31147621E0EAA1647815AFBEFC229E7DEA097C70E63495C03A04BC2E442361AAF202B4B687C4CB78494CC4876922897D1E22BD440A228948C25208D94A0124A4D525597E0E0BCECFE7774AA24C7CAFCE2057F7F6C36977C06635C364EA86955A63B71EDD860E91F065DE533C20F51D8F6B715A0AB0B1BA80A9649C3C41D9C7F3CA60EE6EA172F832CE7F741A7F3D7B0AB937AFC0A4EFA065D04BD56108037E563B2026A20D179EB01A4C440AC1D6959696E07BEC354C9ABD698462982B4FAE41A2D128229188C0C0001557B434736C078361F8FAC3F0B80370385CB0582CE826C2A61E3D5ADB1A91977B5D84735E7616C6470769CB3F8EB5D5456C6FADC9BD002D0D1C069B54131096E767303612A55A9F7679B4414A0C7A4558F01269ECD0E16AE639FCE5BD3FE2FC5FCFD246A8145613ED2049752E7AB83E08F8FCA23660A8C3855B861482C96BDD99BD86EFB385198351726922CB4439863991713C7B3C2E8247B83593B6F7B961B5D845F1A5EFEA40556519FEFCFE29BCF0C2D378FC87DFC33B6F9E80A9A30E41B759F99E11F09027072804C8F5A50770FDCD75F80A654ADEA81417E5D3CEEE266C66037ACD1D180CD8110FF76168C02EBE0D5414DDC02767FF8433A7FF88CC8C8B686E6AA0787352DDE01142700CEE0F13C5759924BBB3F41026CFD66601D4E4F9775C68F173F6C8926BDB6CC2CA66B399DCDB8A5E9B059DED1DC8CFCBC19F4FBF8B5F1C7F114F3FFE9FF8D52F5EC2B58C4FD0DBDD24127B2CD027B6F8FC61C64E5BFF58C4A70820E2813D40B5F9D85CA75581DCCFD74FCB226D65DB9AEBD0DA54453FEC40D86F23119C02219F0D1D2D35B8F8F98738F9FA09BCF5C6EBC8BC9C014347BBF8ADDBE510952393E078658F60F21E971B368B55EC0DF81A7B8B8C6926CD5EC41EC5E398341365C24CDC62E91131DDD85087AB5F66E0AD37FF80977EF61C8EBFF80C4EBDF93B145ECF80A5B309C3613792E4BD519A236FEF6DDDCD22B78D0D07B1B634497C575402B007A4C049914B490E0DCE9AD333E388C507E0B05BD1DC40DBE4BA0AF4F6749110BD34591B06C30E0C47DDE833B5E2EA17E7F0DB5FBE82E3CF3F8B53EF9CA4BD4409FAFA6802EC155E9F88635E9A0C0683B0A4BDB76F172C1493E5ACCD9E64B3F509C24C9EC7F26F6A6859BE74F13C7EFDCB57F1C4A3DFC7534F3C82B74EFE06A5C5D7C56E96E7311AF560C06B11DF37CC64FD7A5D29F41D8DE2BBC3E61AD50154FDF2B2CF09715700910738145219522E8FFCC597BF1A7101C1252627243B116A6EAA45434325ED0D9AC852264403BD182441462871B2E295C53771F20FBFC6938F3D82E32FFD14972E5C1416F752ECB205BBBABA0429695926C7D7F47ABD38B7F498C57DAE444B4B8BF1D1871FE0BF7EFE327EFCA347F1FC4F9EC4A9B75F17B58ACF6BA690F251C8B8E9BC873CB41DDDED3568A92D85EE76014C865612EC339496145268CF8BAA707191BF4AAF0A7EBBA5B0427E6F93A0865826A9E53272757555949A23A32484C382A6E61AE8EA4A61D493102E13067C568299628EF6F81197D85E7FFAC1BBF8C9538FE37F7EFF5BE45CBF86AECE7611B3269399B2B5090642B7B1076D1436ECD65595E5C8BAFC05FEFBF727F0D80F1EC1BF7FE75FF1C2B34FE2E3F7DF41637589486423F100799E1B6E67376DBBEBC81865A8AE2E44216DE4F2F36EA0FC76313ADA9BD1EF75A29EBCD660E84A95C8D3BBFB837D023079B500079D2B3962132B2B4B985F2021C6E2707BFAD0D4A8435D4D192D8F0DF0D2A4588488DF425E61C550C8014FAF1ED72E7F8E975F7C0EBF79EDE7B8F0E9A75457D451E6EE21AB77223BFB064E9E7C033F7BFE19FCE03FBE831F3EF23DBCF6CA71645CF814FAF63AC4820E24A94609BB2DE835B6A08DF291AEAA04A545376979CBA45DEB151417E7A0B6AE522C811C4ABC4C466915E17DC00225F5A5A50511DAD2A08C03FF3224BC4284477AAF907F0A5B595BC62C2D9BA3C921B8DC7D6869D1519C1693856BE0732B1EC121C1E1C1B1E9779A907FF5224EBCF632CEBCFD062E9CFB10CF3DFD18BEFB6FFF829F3EF328DE7BFB776237CA5FA713036E11D3FCC9DDD2D920DCBAA62C1FA585D9C8CFB9262C7DBBEC9610DF4C6BBEBDCF0CBF8F42900A355E69B89E60D2ABABCB776C8F250E158007715FDD0A504FF976BB43426C616965113373D3181E89098F686DAD258F28A1D5A05E589F8907489048BF59EC381364513B65E5FA8A7C94175D53D6684F8F102CE435892FCC2D7525A82ECB16DF258B72B25094771D65C5B9A8AE2A436B4B03913610690BAD365C9D06293F0D6272621473E4E66B2B14E3FC694DCE3705B5F51924803CD289B01FFC03F5B904F7F9C19C5844B2A45523393644F1E7405B6B036AAB4B69F5A81219D965EB109FD6431E03E2212BC613FD54645102A3B031EBEB515B5580A2FC2BC8BD7189701905B95705695D4D393A3B5A046987D326363811B274823FBA8E27313F3F2B2CADDEFBAB5BF55CD5F7EE5900EDC3D4E74C9EC1D7768558A12A6F764284869FAAAECE8E6611B3D5E50568A184D5D25842CBE92D34E88A50753B07C505590AE9EC2F909FFF25AACA15D7D677B5C16235C2E9B40BD2E170509096FBFB959595D48752E5FDEAF9C8F9A5839C6B9A10D024C514F68F49DD4B3D48FD60F9C1811FCE5BCFB905FE30318ED1D1610469FDEFEA6CA5D028C7ED921C64657C86EB5F5E10357A71E14DE87465B4143611E16E517370B9EBF753594DB503EFEB93C911F1C1436671F5C70D2D61F5FCEE864305109BA5DD7B87433D099E1427CAE5D525B296F215873F950F464322599DFFEC6311CF6E579FA8363D6EBBF09660A81F838311223D2CBE33CECCF1F7BE85DDA54B42FD2E897473BA1BEE92040F877CE141EAF37579CED662CBF172C46B3113FAE8A3B368A2FD83A82BF8D33889C3F1CCC5CA3CB9B7B4346770696DF93C09F53CD4F7B4D70FC25712E020A49B10830561321C1AFC39BBB2B252C436272F4E6272ADE61CC27F2562A4B3B4FA1DDAF60E1C743D85BFBB00729212F29ADA1BA410B2CF5696317D90A5E535ED7579EDFF8BAFC503B45093574F5C5A573D563B4E425ED78EFDAAB82F0248A809A423A7EE6B71D0F5AF8AFB2AC0B711771160FF727874FC63FCFE1F4680A387C0BDBD9F04D00E947D2DB4F70FEB6B71D8786D5F8BC3C66BFB5AA41F9F4600F52035B4F70FEB6BA1BD7F585F0BEDFDC3FA5A68EF2BE7AA10E0439EA7031F47E96BC1C751FA5AF07194BE167C68FB77FDEFF25AC8E35EFB5AC8E35EFB5AC8E35EFB5AC8637FFF2E02C8E39FBBFF508054FBC01E0F0548B50FECF1800B00FC1F2CF4D4DA99A2CB760000000049454E44AE426082, 1.8)
SET IDENTITY_INSERT [dbo].[LoaiGhe] OFF
SET IDENTITY_INSERT [dbo].[LoaiKhachHang] ON 

INSERT [dbo].[LoaiKhachHang] ([Id], [HeSo], [Ten]) VALUES (1, 1, N'Khách hàng thường')
INSERT [dbo].[LoaiKhachHang] ([Id], [HeSo], [Ten]) VALUES (2, 0.9, N'Khách hàng quen')
INSERT [dbo].[LoaiKhachHang] ([Id], [HeSo], [Ten]) VALUES (3, 0.6, N'Người già, trẻ em')
INSERT [dbo].[LoaiKhachHang] ([Id], [HeSo], [Ten]) VALUES (4, 0.3, N'Người tàn tật')
SET IDENTITY_INSERT [dbo].[LoaiKhachHang] OFF
INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [GioiTinh], [NgaySinh], [NgayVaoLam], [CMND], [DiaChi], [DienThoai], [Email], [MatKhau], [PhongBanID]) VALUES (N'Admin', N'Đinh Văn Nam', 1, CAST(N'1990-06-05' AS Date), CAST(N'2015-06-07 07:54:39.500' AS DateTime), N'250766584', N'Quang Trung - Gò Vấp', N'0902496785', N'namdv0312@gmail.com', N'c4ca4238a0b923820dcc509a6f75849b', N'ADMIN')
INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [GioiTinh], [NgaySinh], [NgayVaoLam], [CMND], [DiaChi], [DienThoai], [Email], [MatKhau], [PhongBanID]) VALUES (N'NV01', N'Đinh Trung Phong', 1, CAST(N'1994-06-26' AS Date), CAST(N'2015-06-26 22:42:07.747' AS DateTime), NULL, NULL, NULL, NULL, N'c4ca4238a0b923820dcc509a6f75849b', N'BH')
INSERT [dbo].[NhanVien] ([Id], [TenNhanVien], [GioiTinh], [NgaySinh], [NgayVaoLam], [CMND], [DiaChi], [DienThoai], [Email], [MatKhau], [PhongBanID]) VALUES (N'NV02', N'Đinh Thuý Nga', 0, CAST(N'1994-06-26' AS Date), CAST(N'2015-06-26 22:55:40.130' AS DateTime), NULL, NULL, NULL, NULL, N'c4ca4238a0b923820dcc509a6f75849b', N'KT')
INSERT [dbo].[PhongBan] ([Id], [TenPhongBan], [RuleChuyenTau], [RuleNhanSu], [RuletBanVe], [RuleLichTrinh], [RuleBaoCao], [RuleQuanTri]) VALUES (N'ADMIN', N'Quản trị CSDL', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PhongBan] ([Id], [TenPhongBan], [RuleChuyenTau], [RuleNhanSu], [RuletBanVe], [RuleLichTrinh], [RuleBaoCao], [RuleQuanTri]) VALUES (N'BH', N'Phòng bán hàng', 0, 0, 1, 1, 0, 0)
INSERT [dbo].[PhongBan] ([Id], [TenPhongBan], [RuleChuyenTau], [RuleNhanSu], [RuletBanVe], [RuleLichTrinh], [RuleBaoCao], [RuleQuanTri]) VALUES (N'KT', N'Phòng kế  toán', 0, 1, 0, 0, 1, 0)
SET IDENTITY_INSERT [dbo].[TuyenDuong] ON 

INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (1, 2, 400, 12)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (2, 3, 500, 13)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (3, 4, 300, 14)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (4, 5, 450, 15)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (5, 6, 600, 16)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (2, 5, 300, 20)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (6, 5, 200, 26)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (5, 4, 200, 27)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (4, 3, 200, 28)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (3, 2, 200, 29)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (2, 1, 200, 30)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (6, 12, 300, 31)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (12, 13, 200, 32)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (13, 14, 150, 33)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (6, 13, 200, 34)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (14, 12, 100, 35)
INSERT [dbo].[TuyenDuong] ([GaTauDauId], [GaTauCuoiId], [KhoangCach], [Id]) VALUES (12, 15, 250, 36)
SET IDENTITY_INSERT [dbo].[TuyenDuong] OFF
/****** Object:  Index [IX_LichTrinh_TuyenDuong]    Script Date: 27/06/2015 18:50:59 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_LichTrinh_TuyenDuong] ON [dbo].[LichTrinh_TuyenDuong]
(
	[LichTrinhId] ASC,
	[TuyenDuongId] ASC,
	[ThuTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGiaoDich_GiaoDich] FOREIGN KEY([GiaoDichId])
REFERENCES [dbo].[GiaoDich] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietGiaoDich] CHECK CONSTRAINT [FK_ChiTietGiaoDich_GiaoDich]
GO
ALTER TABLE [dbo].[ChiTietGiaoDich]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietGiaoDich_LichTrinh_TuyenDuong] FOREIGN KEY([LichTrinhTuyenDuongId])
REFERENCES [dbo].[LichTrinh_TuyenDuong] ([Id])
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[ChiTietGiaoDich] CHECK CONSTRAINT [FK_ChiTietGiaoDich_LichTrinh_TuyenDuong]
GO
ALTER TABLE [dbo].[ChiTietGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGiaoDich_LoaiGhe] FOREIGN KEY([LoaiGheId])
REFERENCES [dbo].[LoaiGhe] ([Id])
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[ChiTietGiaoDich] CHECK CONSTRAINT [FK_ChiTietGiaoDich_LoaiGhe]
GO
ALTER TABLE [dbo].[DoanTau_LoaiGhe]  WITH CHECK ADD  CONSTRAINT [FK_DoanTau_LoaiGhe_DoanTau] FOREIGN KEY([DoanTauId])
REFERENCES [dbo].[DoanTau] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DoanTau_LoaiGhe] CHECK CONSTRAINT [FK_DoanTau_LoaiGhe_DoanTau]
GO
ALTER TABLE [dbo].[DoanTau_LoaiGhe]  WITH CHECK ADD  CONSTRAINT [FK_DoanTau_LoaiGhe_LoaiGhe] FOREIGN KEY([LoaiGheId])
REFERENCES [dbo].[LoaiGhe] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DoanTau_LoaiGhe] CHECK CONSTRAINT [FK_DoanTau_LoaiGhe_LoaiGhe]
GO
ALTER TABLE [dbo].[GiaoDich]  WITH NOCHECK ADD  CONSTRAINT [FK_GiaoDich_KhachHang] FOREIGN KEY([KhachHangId])
REFERENCES [dbo].[KhachHang] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[GiaoDich] CHECK CONSTRAINT [FK_GiaoDich_KhachHang]
GO
ALTER TABLE [dbo].[GiaoDich]  WITH NOCHECK ADD  CONSTRAINT [FK_GiaoDich_NhanVien] FOREIGN KEY([NhanVienId])
REFERENCES [dbo].[NhanVien] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[GiaoDich] CHECK CONSTRAINT [FK_GiaoDich_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKhachHang] FOREIGN KEY([LoaiKhachHangId])
REFERENCES [dbo].[LoaiKhachHang] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKhachHang]
GO
ALTER TABLE [dbo].[LichTrinh]  WITH CHECK ADD  CONSTRAINT [FK_LichTrinh_DoanTau] FOREIGN KEY([DoanTauId])
REFERENCES [dbo].[DoanTau] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinh] CHECK CONSTRAINT [FK_LichTrinh_DoanTau]
GO
ALTER TABLE [dbo].[LichTrinh_TuyenDuong]  WITH CHECK ADD  CONSTRAINT [FK_LichTrinh_TuyenDuong_LichTrinh1] FOREIGN KEY([LichTrinhId])
REFERENCES [dbo].[LichTrinh] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinh_TuyenDuong] CHECK CONSTRAINT [FK_LichTrinh_TuyenDuong_LichTrinh1]
GO
ALTER TABLE [dbo].[LichTrinh_TuyenDuong]  WITH CHECK ADD  CONSTRAINT [FK_LichTrinh_TuyenDuong_TuyenDuong] FOREIGN KEY([TuyenDuongId])
REFERENCES [dbo].[TuyenDuong] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichTrinh_TuyenDuong] CHECK CONSTRAINT [FK_LichTrinh_TuyenDuong_TuyenDuong]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([PhongBanID])
REFERENCES [dbo].[PhongBan] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[TuyenDuong]  WITH CHECK ADD  CONSTRAINT [FK_TuyenDuong_GaTau] FOREIGN KEY([GaTauDauId])
REFERENCES [dbo].[GaTau] ([Id])
GO
ALTER TABLE [dbo].[TuyenDuong] CHECK CONSTRAINT [FK_TuyenDuong_GaTau]
GO
ALTER TABLE [dbo].[TuyenDuong]  WITH CHECK ADD  CONSTRAINT [FK_TuyenDuong_GaTau1] FOREIGN KEY([GaTauCuoiId])
REFERENCES [dbo].[GaTau] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TuyenDuong] CHECK CONSTRAINT [FK_TuyenDuong_GaTau1]
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
         Begin Table = "LichTrinh"
            Begin Extent = 
               Top = 78
               Left = 268
               Bottom = 208
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DoanTau"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "GiaoDich"
            Begin Extent = 
               Top = 18
               Left = 525
               Bottom = 248
               Right = 783
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ChiTietGiaoDich"
            Begin Extent = 
               Top = 6
               Left = 821
               Bottom = 196
               Right = 1055
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
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DoanhThu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'= 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DoanhThu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_DoanhThu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[19] 2[12] 3) )"
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
         Begin Table = "DoanTau"
            Begin Extent = 
               Top = 198
               Left = 722
               Bottom = 328
               Right = 908
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LichTrinh"
            Begin Extent = 
               Top = 203
               Left = 24
               Bottom = 333
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "GiaoDich_1"
            Begin Extent = 
               Top = 2
               Left = 256
               Bottom = 280
               Right = 440
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ChiTietGiaoDich"
            Begin Extent = 
               Top = 12
               Left = 946
               Bottom = 202
               Right = 1164
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LoaiGhe"
            Begin Extent = 
               Top = 64
               Left = 732
               Bottom = 194
               Right = 902
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NhanVien"
            Begin Extent = 
               Top = 88
               Left = 514
               Bottom = 305
               Right = 684
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "KhachHang"
            Begin Extent = 
               Top = 17
               Left = 13
               Bottom = 201
               Right = 196
            End
            Dis' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_GiaoDich'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'playFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 17
         Width = 284
         Width = 1725
         Width = 1230
         Width = 1695
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 2190
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_GiaoDich'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_GiaoDich'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[34] 4[15] 2[21] 3) )"
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
         Begin Table = "DoanTau"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 142
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LichTrinh"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 200
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LichTrinh_TuyenDuong"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 204
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TuyenDuong"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 136
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "GaTau"
            Begin Extent = 
               Top = 9
               Left = 891
               Bottom = 122
               Right = 1061
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "GaTau_1"
            Begin Extent = 
               Top = 184
               Left = 893
               Bottom = 297
               Right = 1063
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LoaiGhe"
            Begin Extent = 
               Top = 245
               Left = 442
               Bottom = 375
               Right = 612
            End
            Displ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_GiaVe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'ayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1830
         Width = 2265
         Width = 2280
         Width = 1770
         Width = 2190
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 2175
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_GiaVe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_GiaVe'
GO
USE [master]
GO
ALTER DATABASE [VeTau] SET  READ_WRITE 
GO
