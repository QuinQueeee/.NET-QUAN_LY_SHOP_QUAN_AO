USE [master]
GO
/****** Object:  Database [QL_SHOPTHOITRANG]    Script Date: 12/12/2023 9:58:34 AM ******/
CREATE DATABASE [QL_SHOPTHOITRANG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_SHOPTHOITRANG_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.QUIN\MSSQL\DATA\QL_SHOPTHOITRANG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_SHOPTHOITRANG_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.QUIN\MSSQL\DATA\QL_SHOPTHOITRANG.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_SHOPTHOITRANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET  MULTI_USER 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_SHOPTHOITRANG', N'ON'
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET QUERY_STORE = OFF
GO
USE [QL_SHOPTHOITRANG]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 12/12/2023 9:58:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHD] [char](10) NOT NULL,
	[MaSP] [char](10) NOT NULL,
	[SLuong] [int] NULL,
	[ThanhTien] [float] NULL,
	[TenSP] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 12/12/2023 9:58:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaSP] [char](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[GiaNhap] [float] NULL,
	[GiaXuat] [float] NULL,
	[KieuDang] [nvarchar](4) NULL,
	[TinhTrang] [nvarchar](20) NULL,
	[NgayNhap] [date] NULL,
	[SoLuong] [int] NULL,
	[DaBan] [int] NULL,
	[ChatLieu] [nvarchar](20) NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/12/2023 9:58:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [char](10) NOT NULL,
	[NgayMua] [date] NULL,
	[MaKH] [char](10) NULL,
	[MaNV] [char](10) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/12/2023 9:58:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[SDT] [char](11) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[GTinh] [nvarchar](4) NULL,
	[NGSinh] [date] NULL,
	[Email] [char](30) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/12/2023 9:58:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[SDT] [char](11) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[GTinh] [nvarchar](4) NULL,
	[NGSinh] [date] NULL,
	[TenDangNhap] [char](20) NULL,
	[Password] [char](10) NULL,
	[Email] [char](30) NULL,
	[RoleID] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 12/12/2023 9:58:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[RoleID] [int] NOT NULL,
	[RoleName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD001     ', N'SP007     ', 1, 450000, N'Khoác kaki', 450000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD002     ', N'SP002     ', 2, 360000, N'Áo thun', 180000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD003     ', N'SP006     ', 2, 600000, N'Short jeans', 300000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD004     ', N'SP001     ', 3, 750000, N'Áo polo ', 250000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD005     ', N'SP006     ', 2, 600000, N'Short jeans', 300000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD006     ', N'SP003     ', 2, 600000, N'Quần tây', 300000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD007     ', N'SP003     ', 2, 600000, N'Quần tây', 300000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD008     ', N'SP001     ', 5, 1250000, N'Áo polo ', 250000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD009     ', N'SP001     ', 1, 250000, N'Áo polo ', 250000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD010     ', N'SP001     ', 1, 250000, N'Áo polo ', 250000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD010     ', N'SP003     ', 1, 300000, N'Quần tây', 300000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD011     ', N'SP002     ', 1, 180000, N'Áo thun', 180000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD011     ', N'SP008     ', 1, 250000, N'Khoác hoodie nữ', 250000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD012     ', N'SP007     ', 1, 450000, N'Khoác kaki', 450000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD012     ', N'SP008     ', 1, 250000, N'Khoác hoodie nữ', 250000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD013     ', N'SP002     ', 1, 180000, N'Áo thun', 180000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD013     ', N'SP005     ', 1, 350000, N'Quần cargo ', 350000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD014     ', N'SP001     ', 1, 250000, N'Áo polo ', 250000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD014     ', N'SP003     ', 1, 300000, N'Quần tây', 300000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD015     ', N'SP002     ', 1, 180000, N'Áo thun', 180000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaSP], [SLuong], [ThanhTien], [TenSP], [DonGia]) VALUES (N'HD015     ', N'SP009     ', 2, 400000, N'Áo khóac', 200000)
GO
INSERT [dbo].[HANGHOA] ([MaSP], [TenSP], [GiaNhap], [GiaXuat], [KieuDang], [TinhTrang], [NgayNhap], [SoLuong], [DaBan], [ChatLieu]) VALUES (N'SP001     ', N'Áo polo ', 150000, 250000, N'Nam', N'Còn Hàng', CAST(N'2023-10-01' AS Date), 9, 11, N'Thun')
INSERT [dbo].[HANGHOA] ([MaSP], [TenSP], [GiaNhap], [GiaXuat], [KieuDang], [TinhTrang], [NgayNhap], [SoLuong], [DaBan], [ChatLieu]) VALUES (N'SP002     ', N'Áo thun', 100000, 180000, N'Nữ', N'Còn Hàng', CAST(N'2023-10-13' AS Date), 15, 5, N'Cotton')
INSERT [dbo].[HANGHOA] ([MaSP], [TenSP], [GiaNhap], [GiaXuat], [KieuDang], [TinhTrang], [NgayNhap], [SoLuong], [DaBan], [ChatLieu]) VALUES (N'SP003     ', N'Quần tây', 200000, 300000, N'Nam', N'Còn Hàng', CAST(N'2023-09-20' AS Date), 14, 6, N'Thun lạnh')
INSERT [dbo].[HANGHOA] ([MaSP], [TenSP], [GiaNhap], [GiaXuat], [KieuDang], [TinhTrang], [NgayNhap], [SoLuong], [DaBan], [ChatLieu]) VALUES (N'SP004     ', N'Áo sơ mi', 200000, 300000, N'Nữ', N'Còn Hàng', CAST(N'2023-11-22' AS Date), 20, 0, N'Lụa')
INSERT [dbo].[HANGHOA] ([MaSP], [TenSP], [GiaNhap], [GiaXuat], [KieuDang], [TinhTrang], [NgayNhap], [SoLuong], [DaBan], [ChatLieu]) VALUES (N'SP005     ', N'Quần cargo ', 250000, 350000, N'Nữ', N'Còn Hàng', CAST(N'2023-11-22' AS Date), 19, 1, N'Kaki')
INSERT [dbo].[HANGHOA] ([MaSP], [TenSP], [GiaNhap], [GiaXuat], [KieuDang], [TinhTrang], [NgayNhap], [SoLuong], [DaBan], [ChatLieu]) VALUES (N'SP006     ', N'Short jeans', 150000, 300000, N'Nam', N'Còn Hàng', CAST(N'2023-10-31' AS Date), 16, 4, N'Jean')
INSERT [dbo].[HANGHOA] ([MaSP], [TenSP], [GiaNhap], [GiaXuat], [KieuDang], [TinhTrang], [NgayNhap], [SoLuong], [DaBan], [ChatLieu]) VALUES (N'SP007     ', N'Khoác kaki', 250000, 450000, N'Nam', N'Còn Hàng', CAST(N'2023-12-04' AS Date), 19, 2, N'Kaki')
INSERT [dbo].[HANGHOA] ([MaSP], [TenSP], [GiaNhap], [GiaXuat], [KieuDang], [TinhTrang], [NgayNhap], [SoLuong], [DaBan], [ChatLieu]) VALUES (N'SP008     ', N'Khoác hoodie nữ', 150000, 250000, N'Nữ', N'Còn Hàng', CAST(N'2023-11-25' AS Date), 18, 2, N'Nỉ bông')
INSERT [dbo].[HANGHOA] ([MaSP], [TenSP], [GiaNhap], [GiaXuat], [KieuDang], [TinhTrang], [NgayNhap], [SoLuong], [DaBan], [ChatLieu]) VALUES (N'SP009     ', N'Áo khóac', 100000, 200000, N'Nam', N'Còn Hàng', CAST(N'2023-11-09' AS Date), 18, 2, N'Kaki')
GO
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD001     ', CAST(N'2023-12-01' AS Date), N'KH001     ', N'NV006     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD002     ', CAST(N'2023-12-05' AS Date), N'KH003     ', N'NV004     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD003     ', CAST(N'2023-12-06' AS Date), N'KH008     ', N'NV001     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD004     ', CAST(N'2023-12-06' AS Date), N'KH009     ', N'NV008     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD005     ', CAST(N'2023-12-07' AS Date), N'KH011     ', N'NV006     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD006     ', CAST(N'2023-12-07' AS Date), N'KH004     ', N'NV002     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD007     ', CAST(N'2023-12-09' AS Date), N'KH001     ', N'NV001     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD008     ', CAST(N'2023-12-12' AS Date), N'KH001     ', N'NV001     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD009     ', CAST(N'2023-12-12' AS Date), N'KH001     ', N'NV001     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD010     ', CAST(N'2023-12-12' AS Date), N'KH001     ', N'NV001     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD011     ', CAST(N'2023-12-12' AS Date), N'KH001     ', N'NV001     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD012     ', CAST(N'2023-12-12' AS Date), N'KH003     ', N'NV004     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD013     ', CAST(N'2023-12-12' AS Date), N'KH010     ', N'NV002     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD014     ', CAST(N'2023-12-12' AS Date), N'KH004     ', N'NV001     ')
INSERT [dbo].[HOADON] ([MaHD], [NgayMua], [MaKH], [MaNV]) VALUES (N'HD015     ', CAST(N'2023-12-12' AS Date), N'KH001     ', N'NV001     ')
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH001     ', N'Trần Diễm Hằng', N'0582783350 ', N'Quận 12, TP Hồ Chí Minh', N'Nữ', CAST(N'2003-05-29' AS Date), N'tdhangdesigner@gmail.com      ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH002     ', N'Lê Văn Hoàng', N'0897828919 ', N'Tân Phú, TP. HCM', N'Nam', CAST(N'2001-06-08' AS Date), N'vanhoang@gmail.com            ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH003     ', N'Nguyễn Thị Thảo', N'0357987423 ', N'Tây Thạnh, Tân Phú', N'Nữ', CAST(N'1989-07-14' AS Date), N'henguyen89@gmail.com          ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH004     ', N'Trần Gia Đạt', N'0789657820 ', N'Nguyễn Sơn Hà, Phường 5', N'Nam', CAST(N'2003-03-13' AS Date), N'trangiadat2003@gmail.com      ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH005     ', N'Phạm Nguyên Thảo', N'0579273561 ', N'Nhà Bè, Quận 7', N'Nữ', CAST(N'2003-09-27' AS Date), N'thaopham@gmail.com            ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH006     ', N'Võ Vĩnh Tường', N'0879678564 ', N'TP. HCM', N'Nam', CAST(N'1997-06-05' AS Date), N'vinhtuong@gmail.com           ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH007     ', N'Trần Ngọc Thi', N'0786245728 ', N'Lê Hồng Phong, Quận 10', N'Nữ', CAST(N'1989-08-27' AS Date), N'huutinh777@gmail.com          ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH008     ', N'Lê Nghĩa', N'0987627836 ', N'Lê Lai, Quận 1', N'Nam', CAST(N'2000-02-08' AS Date), N'nghiale@gmail.com             ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH009     ', N'Tống Văn Bửu', N'0789654765 ', N'Lê Văn Linh, Quận 7', N'Nam', CAST(N'1990-05-31' AS Date), N'tvbuu@gmail.com               ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH010     ', N'Vũ Thị Thơi', N'0987675425 ', N'Tân Hương, Tân Phú', N'Nữ', CAST(N'1991-03-19' AS Date), N'thoivu@gmail.com              ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [SDT], [DiaChi], [GTinh], [NGSinh], [Email]) VALUES (N'KH011     ', N'Trần Nhật Quỳnh', N'0837918721 ', N'Hồ Chí Minh', N'Nữ', CAST(N'2003-05-21' AS Date), N'quynhtran@gmail.com           ')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [DiaChi], [GTinh], [NGSinh], [TenDangNhap], [Password], [Email], [RoleID]) VALUES (N'NV001     ', N'Trần Thị Hòa', N'0782951753 ', N'Lê Duẩn, Bến Nghé, Q1', N'Nữ', CAST(N'1987-06-23' AS Date), N'thihoa              ', N'123       ', N'hoathitran@gmail.com          ', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [DiaChi], [GTinh], [NGSinh], [TenDangNhap], [Password], [Email], [RoleID]) VALUES (N'NV002     ', N'Trần Trí Đức', N'0723965745 ', N'Thủ Dầu Một, Bình Dương', N'Nữ', CAST(N'1998-06-22' AS Date), N'triduc              ', N'duc123    ', N'triduc98@gmail.com            ', 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [DiaChi], [GTinh], [NGSinh], [TenDangNhap], [Password], [Email], [RoleID]) VALUES (N'NV003     ', N'La Hoàng Thơ', N'0928645783 ', N'Lê Trọng Tấn, Tân Phú', N'Nữ', CAST(N'2005-06-10' AS Date), N'hoangtho            ', N'hoangtho  ', N'lahoangtho@gmail.com          ', 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [DiaChi], [GTinh], [NGSinh], [TenDangNhap], [Password], [Email], [RoleID]) VALUES (N'NV004     ', N'Nguyễn Trí', N'0274812738 ', N'Thủ Đức', N'Nam', CAST(N'1996-06-22' AS Date), N'tringuyen           ', N'456       ', N'tringuyen@gmail.com           ', 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [DiaChi], [GTinh], [NGSinh], [TenDangNhap], [Password], [Email], [RoleID]) VALUES (N'NV006     ', N'Nguyễn Thị Tuyết Nga', N'0895765478 ', N'Tân Phú', N'Nữ', CAST(N'2003-06-08' AS Date), N'nganguyen           ', N'nganga    ', N'tuyetnga@gmail.com            ', 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [DiaChi], [GTinh], [NGSinh], [TenDangNhap], [Password], [Email], [RoleID]) VALUES (N'NV007     ', N'Hoàng Văn Khải', N'0987625436 ', N'Quận 2', N'Nam', CAST(N'1990-02-19' AS Date), N'khaihoang123        ', N'khai192   ', N'vankhaihoang@gmail.com        ', 2)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SDT], [DiaChi], [GTinh], [NGSinh], [TenDangNhap], [Password], [Email], [RoleID]) VALUES (N'NV008     ', N'Hoàng Tuấn Hùng', N'0982937181 ', N'Tân Kỳ Tân Quý, Tân Phú', N'Nam', CAST(N'2002-06-12' AS Date), N'hth                 ', N'hth123    ', N'hth@gmail.com                 ', 2)
GO
INSERT [dbo].[PHANQUYEN] ([RoleID], [RoleName]) VALUES (1, N'Quản lí')
INSERT [dbo].[PHANQUYEN] ([RoleID], [RoleName]) VALUES (2, N'Nhân viên')
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HANGHOA] FOREIGN KEY([MaSP])
REFERENCES [dbo].[HANGHOA] ([MaSP])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_PHANQUYEN] FOREIGN KEY([RoleID])
REFERENCES [dbo].[PHANQUYEN] ([RoleID])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_PHANQUYEN]
GO
USE [master]
GO
ALTER DATABASE [QL_SHOPTHOITRANG] SET  READ_WRITE 
GO
