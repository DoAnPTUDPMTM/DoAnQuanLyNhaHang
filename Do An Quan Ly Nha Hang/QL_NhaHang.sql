CREATE DATABASE QL_NhaHang
GO
USE QL_NhaHang
GO
/*---------------- Bảng Nhân Viên ---------------*/
CREATE TABLE NhanVien
(
	MaNhanVien VARCHAR(10) PRIMARY KEY,
	TenNhanVien NVARCHAR(100),
	NgaySinh DateTime,
	GioiTinh NVARCHAR(10),
	DienThoai VARCHAR(15),
	Email VARCHAR(100),
	DiaChi NVARCHAR(100)
)
GO
/* Thêm nhân viên */
insert into NhanVien values
(N'NV00000001',N'Nguyễn Văn Tuấn','09/09/1987','Nam','0905123456','',N'Huế'),
(N'NV00000002',N'Hồ Thị Bình','09/09/1992',N'Nữ','0905123456','',N'Hà Nội'),
(N'NV00000003',N'Ngô Văn Sơn','09/09/1993','Nam','0905123456','',N'Hải Phòng'),
(N'NV00000004',N'Trần Ngọc Anh','09/09/1989',N'Nữ','0905123456','',N'Đà Nẵng')

GO

/*---------------- Bảng Bàn ---------------*/
CREATE TABLE Ban
(
	MaBan VARCHAR(5) PRIMARY KEY,
	TenBan NVARCHAR(100),
	TrangThai NVARCHAR(100)
)
/* Thêm Bàn */
insert into Ban values
			('BAN01',N'Bàn 1',N'Đã có khách'),
			('BAN02',N'Bàn 2',N'Đã có khách'),
			('BAN03',N'Bàn 3',N'Còn trống')
insert into Ban values ('Ban04',N'Bàn 4', N'Còn trống')
insert into Ban values ('Ban05',N'Bàn 5', N'Còn trống')
insert into Ban values ('Ban06',N'Bàn 6', N'Còn trống')
insert into Ban values ('Ban07',N'Bàn 7', N'Còn trống')
insert into Ban values ('Ban08',N'Bàn 8', N'Còn trống')
GO
/*----------- Bảng Loại Thực Đơn -----------*/
CREATE TABLE LoaiThucDon
(
	MaLoaiThucDon VARCHAR(10) PRIMARY KEY,
	TenLoaiThucDon NVARCHAR(100)
)
/* Thêm Loại Thực Đơn */
insert into LoaiThucDon (MaLoaiThucDon,TenLoaiThucDon) values
('LTD01','Cafe'),
('LTD02',N'Sữa'),
('LTD03',N'LipTon - Trà'),
('LTD04',N'Nước đóng chai'),
('LTD05',N'Nước đóng lon'),
('LTD06',N'Sinh tố'),
('LTD07',N'Tráng miệng'),
('LTD08',N'Điểm tâm')
GO
insert into LoaiThucDon (MaLoaiThucDon,TenLoaiThucDon) values ('LTD09',N'Cơm')
insert into LoaiThucDon (MaLoaiThucDon,TenLoaiThucDon) values ('LTD10',N'Canh')
insert into LoaiThucDon (MaLoaiThucDon,TenLoaiThucDon) values ('LTD11',N'Bánh bao')
insert into LoaiThucDon (MaLoaiThucDon,TenLoaiThucDon) values ('LTD12',N'Hải sản')
GO
/*----------- Bảng Thực Đơn -----------*/
CREATE TABLE ThucDon
(
	MaThucDon VARCHAR(10) PRIMARY KEY,
	MaLoaiThucDon VARCHAR(10) foreign key references LoaiThucDon(MaLoaiThucDon),
	TenThucDon NVARCHAR(100),
	Gia FLOAT,
	TrangThai NVARCHAR(100)
)
/* Thêm Thực Đơn */
insert into ThucDon(MaThucDon,MaLoaiThucDon,TenThucDon,Gia,TrangThai)values
				('TD001','LTD01',N'Cafe đen',6000,'Còn hàng'),
				('TD002','LTD01',N'Cafe Sữa',7000,'Còn hàng'),
				('TD003','LTD01',N'Cafe sài gòn',9000,'Còn hàng')

GO
/*----------- Bảng Khách Hàng -----------*/
CREATE TABLE KhachHang
(
	MaKhachHang VARCHAR(10) PRIMARY KEY,
	TenKhachHang NVARCHAR(100),
	SoDienThoai VARCHAR(15),
	DiaChi NVARCHAR(100)
)
/* Thêm khách hàng */
insert into KhachHang values 
('KH00000001',N'Nguyễn Hoàng Tuấn','0978665412',N'Huế'),
('KH00000002',N'Đào Duy Từ','0978665412',N'Quảng Nam'),
('KH00000003',N'Trương Ngọc Ánh','0978665412',N'Phú Thọ'),
('KH00000004',N'Lê Lưu Ly','0978665412',N'Gia Lai')

/*----------- Bảng Hoá Đơn -----------*/
CREATE TABLE HoaDon
(
	MaHoaDon VARCHAR(10) PRIMARY KEY,
	NgayTao DATE,
	MaBan VARCHAR(5) foreign key references Ban(MaBan),
	MaNhanVien VARCHAR(10) foreign key references NhanVien(MaNhanVien),
	MaKhachHang VARCHAR(10) foreign key references KhachHang(MaKhachHang),
	ThanhTien FLOAT
)

/*----------- Bảng Chi Tiết Hoá Đơn -----------*/
CREATE TABLE ChiTietHoaDon
(
	MaChiTietHoaDon INT IDENTITY(1,1) PRIMARY KEY,
	MaHoaDon VARCHAR(10) foreign key references HoaDon(MaHoaDon),
	MaThucDon VARCHAR(10) foreign key references ThucDon(MaThucDon),
	SoLuong INT,
	ThanhTien FLOAT
)

/*----------- Bảng Tài Khoản -----------*/
CREATE TABLE TaiKhoan
(
	TenDangNhap VARCHAR(10) PRIMARY KEY,
	MatKhau VARCHAR(100),
	HoatDong BIT
)
insert into TaiKhoan(TenDangNhap,MatKhau,HoatDong) values ('admin','admin',1)
/*----------- Bảng Màn Hình -----------*/
CREATE TABLE ManHinh
(
	MaManHinh VARCHAR(10) PRIMARY KEY,
	TenManHinh NVARCHAR(100)
)

/*----------- Bảng Nhóm tài khoản -----------*/
CREATE TABLE NhomTaiKhoan
(
	MaNhomTaiKhoan VARCHAR(10) PRIMARY KEY,
	TenNhomTaiKhoan NVARCHAR(100)ERCR
	GhiChu NVARCHAR(100)
)

/*----------- Bảng Tài Khoản_Nhóm Tài Khoản -----------*/
CREATE TABLE TaiKhoanNhomTaiKhoan
(
	TenDangNhap VARCHAR(10),
	MaNhomTaiKhoan VARCHAR(10),
	GhiChu NVARCHAR(100),
	CONSTRAINT PK_TaiKhoanNhomTaiKhoan_TenDangNhap_MaNhomTaiKhoan PRIMARY KEY (TenDangNhap,MaNhomTaiKhoan)
)

CREATE TABLE PhanQuyen
(
	MaNhomTaiKhoan VARCHAR(10),
	MaManHinh VARCHAR(10),
	CoQuyen BIT,
	CONSTRAINT PK_PhanQuyen_MaNhomTaiKhoan_MaManHinh PRIMARY KEY (MaNhomTaiKhoan,MaManHinh)
)
/* ---------- Bảng Gọi Món ----------- */
CREATE TABLE GoiMon
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	MaBan VARCHAR(5),
	MaThucDon VARCHAR(10),
	TenThucDon NVARCHAR(100),
	Gia FLOAT,
	SoLuong int,
	ThoiGian DATETIME,
	ThanhTien DECIMAL,
	CONSTRAINT FK_GoiMon_Ban FOREIGN KEY (MaBan) REFERENCES Ban(MaBan),
	CONSTRAINT FK_GoiMon_ThucDon FOREIGN KEY (MaThucDon) REFERENCES ThucDon(MaThucDon)
)
INSERT INTO ManHinh VALUES (N'SF001', N'Người dùng')
INSERT INTO ManHinh VALUES (N'SF002', N'Nhóm người dùng')
INSERT INTO ManHinh VALUES (N'SF003', N'Màn hình chức năng')
INSERT INTO ManHinh VALUES (N'SF004', N'Thêm người dùng vào nhóm')
INSERT INTO ManHinh VALUES (N'SF005', N'Phân quyền')


INSERT INTO TaiKhoanNhomTaiKhoan VALUES (N'admin', N'admin', NULL)
INSERT INTO TaiKhoanNhomTaiKhoan VALUES (N'admin1', N'ND', NULL)
INSERT INTO NhomTaiKhoan VALUES (N'admin', N'Admin', NULL)
INSERT INTO NhomTaiKhoan VALUES (N'ND', N'Người dùng', NULL)
