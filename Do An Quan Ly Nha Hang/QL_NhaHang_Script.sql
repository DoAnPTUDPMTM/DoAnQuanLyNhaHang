USE [QL_NhaHang]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ban](
	[MaBan] [varchar](5) NOT NULL,
	[TenBan] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon] [varchar](10) NULL,
	[MaThucDon] [varchar](10) NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaChiTietPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuNhap] [varchar](10) NULL,
	[MaNguyenLieu] [varchar](10) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GoiMon]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GoiMon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaBan] [varchar](5) NULL,
	[MaThucDon] [varchar](10) NULL,
	[TenThucDon] [nvarchar](100) NULL,
	[Gia] [float] NULL,
	[SoLuong] [int] NULL,
	[ThoiGian] [datetime] NULL,
	[ThanhTien] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [varchar](10) NOT NULL,
	[NgayTao] [date] NULL,
	[MaBan] [varchar](5) NULL,
	[MaNhanVien] [varchar](10) NULL,
	[MaKhachHang] [varchar](10) NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [varchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](100) NULL,
	[SoDienThoai] [varchar](15) NULL,
	[DiaChi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiThucDon]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiThucDon](
	[MaLoaiThucDon] [varchar](10) NOT NULL,
	[TenLoaiThucDon] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ManHinh]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ManHinh](
	[MaManHinh] [varchar](10) NOT NULL,
	[TenManHinh] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNguyenLieu] [varchar](10) NOT NULL,
	[TenNguyenLieu] [nvarchar](100) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [varchar](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DienThoai] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[TenDangNhap] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomTaiKhoan]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhomTaiKhoan](
	[MaNhomTaiKhoan] [varchar](10) NOT NULL,
	[TenNhomTaiKhoan] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhomTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaNhomTaiKhoan] [varchar](10) NOT NULL,
	[MaManHinh] [varchar](10) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_PhanQuyen_MaNhomTaiKhoan_MaManHinh] PRIMARY KEY CLUSTERED 
(
	[MaNhomTaiKhoan] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [varchar](10) NOT NULL,
	[NgayNhap] [date] NULL,
	[MaNhanVien] [varchar](10) NULL,
	[MaNhaCungCap] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](10) NOT NULL,
	[MatKhau] [varchar](100) NULL,
	[HoatDong] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoanNhomTaiKhoan]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoanNhomTaiKhoan](
	[TenDangNhap] [varchar](10) NOT NULL,
	[MaNhomTaiKhoan] [varchar](10) NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_TaiKhoanNhomTaiKhoan_TenDangNhap_MaNhomTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaNhomTaiKhoan] ASC,
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 8/12/2020 10:45:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThucDon](
	[MaThucDon] [varchar](10) NOT NULL,
	[MaLoaiThucDon] [varchar](10) NULL,
	[TenThucDon] [nvarchar](100) NULL,
	[Gia] [float] NULL,
	[TrangThai] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'BAN01', N'Bàn 1', N'Còn trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'BAN02', N'Bàn 2', N'Còn trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'BAN03', N'Bàn 3', N'Còn trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'BAN04', N'Bàn 4', N'Còn trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'BAN05', N'Bàn 5', N'Còn trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'BAN06', N'Bàn 6', N'Còn trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'BAN07', N'Bàn 7', N'Còn trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'BAN08', N'Bàn 8', N'Còn trống')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [TrangThai]) VALUES (N'BAN09', N'Bàn 9', N'Còn trống')
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (46, N'HD1', N'TD001', 1, 6000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (47, N'HD1', N'TD005', 1, 78000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (48, N'HD1', N'TD004', 3, 225000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (49, N'HD1', N'TD011', 1, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (50, N'HD2', N'TD001', 2, 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (51, N'HD2', N'TD019', 2, 64000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (52, N'HD3', N'TD001', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (53, N'HD3', N'TD019', 3, 96000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (54, N'HD4', N'TD001', 4, 24000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (55, N'HD5', N'TD001', 2, 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (56, N'HD5', N'TD019', 2, 64000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (57, N'HD6', N'TD001', 2, 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (58, N'HD6', N'TD002', 2, 14000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (59, N'HD7', N'TD001', 1, 6000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (60, N'HD8', N'TD001', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (61, N'HD8', N'TD002', 3, 21000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (62, N'HD9', N'TD009', 2, 70000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (63, N'HD9', N'TD004', 1, 75000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (64, N'HD9', N'TD007', 2, 68000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (66, N'HD10', N'TD001', 1, 6000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (67, N'HD10', N'TD004', 2, 150000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (68, N'HD10', N'TD006', 4, 280000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (69, N'HD11', N'TD001', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (70, N'HD11', N'TD003', 3, 27000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (71, N'HD11', N'TD004', 3, 225000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (72, N'HD12', N'TD001', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (73, N'HD12', N'TD012', 6, 210000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (74, N'HD12', N'TD004', 3, 225000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (75, N'HD12', N'TD008', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (76, N'HD12', N'TD011', 3, 150000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (77, N'HD12', N'TD023', 3, 1650000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (78, N'HD12', N'TD024', 3, 240000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (79, N'HD12', N'TD025', 3, 261000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (80, N'HD13', N'TD001', 1, 6000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (81, N'HD13', N'TD025', 35, 3045000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (82, N'HD13', N'TD008', 7, 42000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (83, N'HD14', N'TD025', 35, 3045000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (84, N'HD15', N'TD001', 1, 6000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (85, N'HD15', N'TD002', 1, 7000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (86, N'HD15', N'TD017', 1, 45000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (87, N'HD15', N'TD011', 40, 2000000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (88, N'HD16', N'TD001', 1, 6000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (89, N'HD16', N'TD019', 1, 32000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (90, N'HD16', N'TD004', 1, 75000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (91, N'HD18', N'TD001', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (92, N'HD18', N'TD003', 3, 27000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (93, N'HD19', N'TD001', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (94, N'HD19', N'TD008', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (95, N'HD20', N'TD001', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (96, N'HD20', N'TD019', 3, 96000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (97, N'HD20', N'TD004', 3, 225000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (98, N'HD21', N'TD001', 1, 6000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (99, N'HD22', N'TD001', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (100, N'HD23', N'TD002', 3, 21000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (101, N'HD24', N'TD001', 2, 12000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (102, N'HD25', N'TD003', 3, 27000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (103, N'HD25', N'TD002', 3, 21000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (104, N'HD25', N'TD001', 3, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (105, N'HD26', N'TD019', 4, 128000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (106, N'HD26', N'TD012', 4, 140000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (107, N'HD26', N'TD006', 4, 280000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (108, N'HD26', N'TD004', 4, 300000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (109, N'HD26', N'TD001', 4, 24000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (110, N'HD27', N'TD011', 2, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (111, N'HD27', N'TD006', 2, 140000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (112, N'HD27', N'TD030', 2, 64000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (113, N'HD27', N'TD031', 2, 90000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (114, N'HD27', N'TD032', 2, 68000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (115, N'HD28', N'TD019', 4, 128000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (116, N'HD28', N'TD004', 6, 450000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (117, N'HD28', N'TD006', 2, 140000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaThucDon], [SoLuong], [ThanhTien]) VALUES (118, N'HD28', N'TD030', 2, 64000)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhap] ON 

INSERT [dbo].[ChiTietPhieuNhap] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaNguyenLieu], [SoLuong]) VALUES (14, N'PN_6', N'NL_1', 7)
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhap] OFF
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD1', CAST(N'2020-08-01' AS Date), N'BAN06', N'NV00000001', NULL, 359000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD10', CAST(N'2020-08-01' AS Date), N'BAN07', N'NV00000006', NULL, 436000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD11', CAST(N'2020-08-01' AS Date), N'BAN06', N'NV00000006', NULL, 270000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD12', CAST(N'2020-08-01' AS Date), N'BAN01', N'NV00000006', NULL, 2772000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD13', CAST(N'2020-08-01' AS Date), N'BAN07', N'NV00000001', NULL, 3093000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD14', CAST(N'2020-08-01' AS Date), N'BAN01', N'NV00000006', NULL, 3045000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD15', CAST(N'2020-08-01' AS Date), N'BAN01', N'NV00000006', NULL, 2058000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD16', CAST(N'2020-08-01' AS Date), N'BAN08', N'NV00000001', NULL, 113000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD17', CAST(N'2020-08-05' AS Date), N'BAN07', N'NV00000001', NULL, 0)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD18', CAST(N'2020-08-05' AS Date), N'BAN07', N'NV00000001', NULL, 45000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD19', CAST(N'2020-08-05' AS Date), N'BAN01', N'NV00000001', NULL, 36000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD2', CAST(N'2020-08-01' AS Date), N'BAN07', N'NV00000001', NULL, 76000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD20', CAST(N'2020-08-05' AS Date), N'BAN06', N'NV00000006', NULL, 339000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD21', CAST(N'2020-08-05' AS Date), N'BAN01', N'NV00000001', NULL, 6000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD22', CAST(N'2020-08-05' AS Date), N'BAN01', N'NV00000001', NULL, 18000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD23', CAST(N'2020-08-05' AS Date), N'BAN01', N'NV00000001', NULL, 21000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD24', CAST(N'2020-08-05' AS Date), N'BAN01', N'NV00000001', NULL, 12000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD25', CAST(N'2020-08-05' AS Date), N'BAN01', N'NV00000001', NULL, 66000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD26', CAST(N'2020-08-05' AS Date), N'BAN01', N'NV00000001', NULL, 872000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD27', CAST(N'2020-08-08' AS Date), N'BAN04', N'NV00000001', NULL, 462000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD28', CAST(N'2020-08-12' AS Date), N'BAN07', N'NV00000001', NULL, 782000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD3', CAST(N'2020-08-01' AS Date), N'BAN01', N'NV00000001', NULL, 114000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD4', CAST(N'2020-08-01' AS Date), N'BAN01', N'NV00000001', NULL, 24000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD5', CAST(N'2020-08-01' AS Date), N'BAN01', N'NV00000001', NULL, 76000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD6', CAST(N'2020-08-01' AS Date), N'BAN07', N'NV00000001', NULL, 26000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD7', CAST(N'2020-08-01' AS Date), N'BAN01', N'NV00000001', NULL, 6000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD8', CAST(N'2020-08-01' AS Date), N'BAN07', N'NV00000004', NULL, 39000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayTao], [MaBan], [MaNhanVien], [MaKhachHang], [ThanhTien]) VALUES (N'HD9', CAST(N'2020-08-01' AS Date), N'BAN06', N'NV00000006', NULL, 213000)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi]) VALUES (N'KH00000001', N'Nguyễn Hoàng Tuấn', N'0978665412', N'Huế')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi]) VALUES (N'KH00000002', N'Đào Duy Từ', N'0978665412', N'Quảng Nam')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi]) VALUES (N'KH00000003', N'Trương Ngọc Ánh', N'0978665412', N'Phú Thọ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [DiaChi]) VALUES (N'KH00000004', N'Lê Lưu Ly', N'0978665412', N'Gia Lai')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD01', N'Cafe')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD02', N'Sữa')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD03', N'LipTon - Trà')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD04', N'Nước đóng chai')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD05', N'Nước đóng lon')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD06', N'Sinh tố')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD07', N'Tráng miệng')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD08', N'Điểm tâm')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD09', N'Cơm')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD10', N'Canh')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD11', N'Bánh bao')
INSERT [dbo].[LoaiThucDon] ([MaLoaiThucDon], [TenLoaiThucDon]) VALUES (N'LTD12', N'Hải sản')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF001', N'Người dùng')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF002', N'Nhóm người dùng')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF003', N'Màn hình chức năng')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF004', N'Thêm người dùng vào nhóm')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF005', N'Phân quyền')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF006', N'Quản lý nhân viên')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF007', N'Quản lý bàn')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF008', N'Quản lý thực đơn')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF009', N'Gọi món')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF010', N'Doanh thu')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF011', N'Quản lý hoá đơn')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF012', N'Nhà cung cấp')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF013', N'Phiếu nhập')
INSERT [dbo].[ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'SF014', N'Quản lý nguyên liệu')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_1', N'Gạo', 102)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_10', N'Muối', 6)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_11', N'Đường', 5)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_12', N'Dưa leo', 1)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_13', N'Thịt bò', 24)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_2', N'Cà chua', 32)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_3', N'Hành tây', 3)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_4', N'Hành lá', 5)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_5', N'Tỏi', 3)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_6', N'Trứng', 12)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_7', N'Tôm', 12)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_8', N'Thịt heo', 15)
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuong]) VALUES (N'NL_9', N'Bắp cải', 5)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [SoDienThoai], [DiaChi]) VALUES (N'NCC001', N'Kamereo LLP', N'0839443000', N'18/40 Nguyễn Cửu Vân, Quận Bình Thạnh, TP.HCM')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [SoDienThoai], [DiaChi]) VALUES (N'NCC002', N'San Hà Food', N'0239810082', N'Số 951 Tạ Quang Bửu, P. 6, Q. 8, Tp. Hồ Chí Minh (TPHCM), Việt Nam')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [SoDienThoai], [DiaChi]) VALUES (N'NCC003', N'Công Ty TNHH Lương Thực - Thực Phẩm Gia Hữu', N'0913691568', N'A2 Đường D, P. Tam Bình, Q. Thủ Đức Vựa B9-28 và B9-30 Chợ Đầu Mối Nông Sản Thủ Đức Tp. Hồ Chí Minh')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [SoDienThoai], [DiaChi]) VALUES (N'NCC004', N'Thực Phẩm Trường Thịnh - Công Ty TNHH Phân Phối Thực Phẩm Trường Thịnh', N'0938285624', N'Đường Nguyễn Văn Linh, P. 7, Q. 8, Tp. Hồ Chí Minh')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV00000001', N'Nguyễn Văn Tuấn', CAST(N'1987-09-09 00:00:00.000' AS DateTime), N'Nam', N'0905123456', N'nguyentuan@gmail.com', N'Huế', N'NV00000001')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV00000002', N'Hồ Thị Bình', CAST(N'1992-09-09 00:00:00.000' AS DateTime), N'Nữ', N'0905123456', N'hobinh@gmail.com', N'Hà Nội', N'NV00000002')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV00000003', N'Ngô Văn Sơn', CAST(N'1993-09-09 00:00:00.000' AS DateTime), N'Nam', N'0905123456', N'ngoson@gmail.com', N'Hải Phòng', N'NV00000003')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV00000004', N'Trần Ngọc Anh', CAST(N'1989-09-09 00:00:00.000' AS DateTime), N'Nữ', N'0905123456', N'trananh@gmail.com', N'Đà Nẵng', N'NV00000004')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV00000005', N'Hứa Tôn Đạt', CAST(N'1989-09-09 00:00:00.000' AS DateTime), N'Nam', N'0905123456', N'tondat@gmail.com', N'Đà Nẵng', N'NV00000005')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV00000006', N'Hứa Tôn Đạt', CAST(N'1999-02-16 00:00:00.000' AS DateTime), N'Nam', N'0789163351', N'huatondat@gmail.com', N'TP.HCM', N'NV00000006')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV00000007', N'Trần Văn Tiến', CAST(N'1993-03-24 00:00:00.000' AS DateTime), N'Nam', N'0798654351', N'nguyentuan@gmail.com', N'Vũng Tàu', N'NV00000007')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV00000011', N'Hứa Tôn Đạt', CAST(N'1999-02-16 00:00:00.000' AS DateTime), N'Nam', N'0789163351', N'huatondat@gmail.com', N'TP.HCM', N'NV00000011')
INSERT [dbo].[NhomTaiKhoan] ([MaNhomTaiKhoan], [TenNhomTaiKhoan], [GhiChu]) VALUES (N'NV', N'Nhân viên', NULL)
INSERT [dbo].[NhomTaiKhoan] ([MaNhomTaiKhoan], [TenNhomTaiKhoan], [GhiChu]) VALUES (N'QL', N'Quản lý', NULL)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF001', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF002', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF003', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF004', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF005', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF006', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF007', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF008', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF009', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF010', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF011', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF012', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF013', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'NV', N'SF014', 0)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF001', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF002', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF003', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF004', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF005', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF006', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF007', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF008', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF009', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF010', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF011', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF012', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF013', 1)
INSERT [dbo].[PhanQuyen] ([MaNhomTaiKhoan], [MaManHinh], [CoQuyen]) VALUES (N'QL', N'SF014', 1)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN_1', CAST(N'2020-07-28' AS Date), N'NV00000003', N'NCC004')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN_2', CAST(N'2020-08-08' AS Date), N'NV00000007', N'NCC001')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN_3', CAST(N'2020-08-08' AS Date), N'NV00000007', N'NCC001')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN_4', CAST(N'2020-08-08' AS Date), N'NV00000007', N'NCC001')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN_5', CAST(N'2020-08-08' AS Date), N'NV00000007', N'NCC001')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN_6', CAST(N'2020-08-08' AS Date), N'NV00000007', N'NCC004')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN_7', CAST(N'2020-08-08' AS Date), N'NV00000007', N'NCC004')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN_8', CAST(N'2020-08-08' AS Date), N'NV00000007', N'NCC004')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'admin', N'admin', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000001', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000002', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000003', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000004', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000005', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000006', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000007', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000008', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000009', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000010', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000011', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000012', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000013', N'nhanvien', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'NV00000014', N'nhanvien', 0)
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000002', N'NV', NULL)
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000003', N'NV', NULL)
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000004', N'NV', NULL)
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000005', N'NV', NULL)
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000006', N'NV', NULL)
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000007', N'NV', NULL)
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000008', N'NV', NULL)
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000009', N'NV', N'')
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000010', N'NV', N'')
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000012', N'NV', N'')
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000001', N'QL', NULL)
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000011', N'QL', N'')
INSERT [dbo].[TaiKhoanNhomTaiKhoan] ([TenDangNhap], [MaNhomTaiKhoan], [GhiChu]) VALUES (N'NV00000013', N'QL', N'')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD001', N'LTD01', N'Cafe đen', 6000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD002', N'LTD01', N'Cafe Sữa', 7000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD003', N'LTD01', N'Cafe sài gòn', 9000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD004', N'LTD09', N'Cơm chiên dương châu', 75000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD005', N'LTD09', N'Cơm chiên cá mặn', 78000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD006', N'LTD11', N'Bánh bao kim sa', 70000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD007', N'LTD11', N'Bánh bao thịt ( trứng muối )', 34000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD008', N'LTD04', N'Nước suối Dasani', 6000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD009', N'LTD06', N'Sinh tố dâu', 35000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD010', N'LTD04', N'Nước cam Twitter', 15000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD011', N'LTD12', N'Hàu nướng phô mai ( 5 con )', 50000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD012', N'LTD07', N'Rau câu dừa', 35000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD013', N'LTD05', N'Bia Tiger', 15000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD014', N'LTD05', N'Bia Sài Gòn', 12000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD015', N'LTD05', N'Bia Heineken', 22000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD016', N'LTD05', N'Bia 333', 17000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD017', N'LTD02', N'Sữa tươi trân châu đường đen', 45000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD018', N'LTD02', N'Trà sữa truyền thống', 38000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD019', N'LTD03', N'Hồng trà trân châu đen', 32000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD020', N'LTD03', N'Hồng trà tắc', 28000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD021', N'LTD03', N'Trà Lipton', 28000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD022', N'LTD03', N'Trà atiso', 28000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD023', N'LTD12', N'Tôm hùm nướng (con)', 550000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD024', N'LTD12', N'Nghêu hấp xả', 80000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD025', N'LTD12', N'Sò lông nướng', 87000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD026', N'LTD06', N'Sinh tố mãng cầu', 28000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD027', N'LTD08', N'Dimsum HongKong', 58000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD028', N'LTD08', N'Bánh cuốn tôm tươi', 62000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD029', N'LTD08', N'Xíu mại thịt cua', 58000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD030', N'LTD10', N'Canh rong biển', 32000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD031', N'LTD10', N'Canh bao tử heo hầm tiêu', 45000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD032', N'LTD10', N'Canh bắp cải nhồi thịt', 34000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD033', N'LTD12', N'Tôm hấp bia', 160000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD034', N'LTD12', N'Cua rang me', 210000, N'Còn hàng')
INSERT [dbo].[ThucDon] ([MaThucDon], [MaLoaiThucDon], [TenThucDon], [Gia], [TrangThai]) VALUES (N'TD035', N'LTD12', N'Cá dằm nướng', 180000, N'Còn hàng')
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaThucDon])
REFERENCES [dbo].[ThucDon] ([MaThucDon])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_NL_MaNguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_NL_MaNguyenLieu]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_PN_MaPhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_PN_MaPhieuNhap]
GO
ALTER TABLE [dbo].[GoiMon]  WITH CHECK ADD  CONSTRAINT [FK_GoiMon_Ban] FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[GoiMon] CHECK CONSTRAINT [FK_GoiMon_Ban]
GO
ALTER TABLE [dbo].[GoiMon]  WITH CHECK ADD  CONSTRAINT [FK_GoiMon_ThucDon] FOREIGN KEY([MaThucDon])
REFERENCES [dbo].[ThucDon] ([MaThucDon])
GO
ALTER TABLE [dbo].[GoiMon] CHECK CONSTRAINT [FK_GoiMon_ThucDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan_TenDangNhap] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan_TenDangNhap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap_MaNhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap_MaNhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien_MaNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien_MaNhanVien]
GO
ALTER TABLE [dbo].[TaiKhoanNhomTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanNhomTaiKhoan_TenDangNhap_TenDangNhap] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[TaiKhoanNhomTaiKhoan] CHECK CONSTRAINT [FK_TaiKhoanNhomTaiKhoan_TenDangNhap_TenDangNhap]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD FOREIGN KEY([MaLoaiThucDon])
REFERENCES [dbo].[LoaiThucDon] ([MaLoaiThucDon])
GO
