
create database TTCM
go
use TTCM
go
create table sanPham (
maSP nvarchar(50) primary key,
tenSP nvarchar(50),
gia float,
anh image,
soLuong int,
thongSo nvarchar(50),
maLoai nvarchar(50),
maHang nvarchar (50)
)
go
create table nhomSP(
maLoai nvarchar(50) primary key,
tenLoai nvarchar(50)
)
go
create table HangSP(
maHang nvarchar(50) primary key,
tenHang nvarchar(50)
)
go
create table chiTietSP(
maSP nvarchar(50),
soSerial nvarchar(50),
color nvarchar(50),
primary key (maSP,soSerial)
)
go
create table nhaCungCap(
maNCC nvarchar(50) primary key,
tenNCC nvarchar(50),
email nvarchar(50),
diaChi nvarchar(50),
sdt nvarchar(50)
)
go
create table khachHang(
maKH nvarchar(50) primary key,
tenKH nvarchar(50),
gioiTinh nvarchar(50) check ( gioiTinh in (N'Nam',N'Nữ')),
ngSinh date,
email nvarchar(50),
diaChi nvarchar(50),
sdt nvarchar(50)
)
go
create table nhanVien(
maNV nvarchar(50) primary key,
tenNV nvarchar(50),
gioiTinh nvarchar(50) check ( gioiTinh in (N'Nam',N'Nữ')),
ngSinh date,
ngVaoLam date,
email nvarchar(50),
diaChi nvarchar(50),
sdt nvarchar(50),
passWords nvarchar(50), 
maCV nvarchar(50),
tendn nvarchar(50)
)
go
create table congViec(
maCV nvarchar(50) primary key,
tenCV nvarchar(50),
bacLuong float
)
go
create table hoadDonNhap(
maHDN nvarchar(50) primary key,
maNV nvarchar(50),
maNCC nvarchar(50),
ngayNhap date default getdate(),
tongTien float,
trangThai nvarchar(50),
)
--alter table hoadDonNhap add ngayNhap date default getdate()
go
create table chiTietHDN(
--maCTHDN nvarchar(50) primary key,
maHDN nvarchar(50),
maSP nvarchar(50),
donGia float,
soLuong int,
thanhTien float,
primary key(maHDN,maSP)
)
go
create table hoadDonXuat(
maHDX nvarchar(50) primary key,
maNV nvarchar(50),
maKH nvarchar(50),
ngayBan date default getdate(),
giamGia int default 0,
tongTien float,
trangThai nvarchar(50),

)

--alter table hoadDonXuat add giamGia int default 0
go
create table chiTietHDX(
--machiTietHDX nvarchar(50) primary key,
maHDX nvarchar(50),
maSP nvarchar(50),
donGia float,
soLuong int,
thanhTien float,
primary key(maHDX,maSP)
)
go
use TTCM
create table GioHang
(
	magio int identity  primary key,
	makh nvarchar(50)
)
go
create table CTGio(
	maCTG int identity primary key,
	magio int ,
	masp nvarchar(50),
	soluong int,
	donGia float,
	thanhTien float

)
go 
create table PhieuNhap(
	maphieu nvarchar(50) primary key,
	manv nvarchar(50),
	ngLapPhieu date
)
go
create table CTPhieuNhap(
	maphieu nvarchar(50),
	masp nvarchar(50),
	sl int

	primary key (maphieu, masp)
)

go
alter table nhanVien add foreign key(maCV) references congViec(maCV)
go
alter table hoadDonNhap add foreign key (maNCC) references nhaCungCap (maNCC)
go
alter table hoadDonNhap add foreign key (maNV) references nhanVien(maNV)
go
alter table hoadDonXuat add foreign key (maKH) references khachHang(maKH)
go
alter table hoadDonXuat add foreign key (maNV) references nhanVien(maNV)
go
alter table sanPham add foreign key (maLoai) references nhomSP (maLoai)
go
alter table Sanpham add foreign key (mahang) references HangSP (maHang)
go
alter table chiTietHDN add foreign key (maSP) references sanPham(maSP)
go
alter table chiTietHDN add foreign key (maHDN) references hoadDonNhap(maHDN)
go
alter table chiTietHDX add foreign key (maSP) references sanPham(maSP)
go
alter table chiTietHDX add foreign key (maHDX) references hoadDonXuat(maHDX)
go
alter table chiTietSP add foreign key (maSP) references sanPham(maSP)

