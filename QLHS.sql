USE QuanLyHocSinh
go

CREATE TABLE TaiKhoan(
	ID int identity(1,1) primary key,
	TenDangNhap varchar(255) not null,
	MatKhau nvarchar(255)
);

CREATE TABLE HocSinh(
	MaHS int primary key,
	TenHS nvarchar(255) not null,
	NgaySinh date not null,
	GioiTinh bit not null,
	NoiSinh nvarchar(255) not null,
	DanToc nvarchar(255) not null,
	TenGVCN nvarchar(255) not null,
	NgayNhapHoc date not null
);

CREATE TABLE GiaoVienChuNhiem(
	MaGV int primary key,
	TenGV nvarchar(255) not null,
	GioiTinh bit not null,
	NgaySinh date not null,
	QueQuan nvarchar(255) not null,
	DiaChi nvarchar(255) not null,
	SoDienThoai nvarchar(10) not null
);

CREATE TABLE MonHoc(
	MaMonHoc nvarchar(5) primary key,
	TenMonHoc nvarchar(255) not null,
	SoTiet int not null,

);
