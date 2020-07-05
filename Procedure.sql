use TTCM
go
create proc addSP( @maSP nvarchar(50),
@tenSP nvarchar(50),
@gia float,
@anh image,
@soLuong int,
@thongSo nvarchar(50),
@maLoai nvarchar(50),
@maHang nvarchar(50))
as begin 
insert into sanPham values (@maSP,@tenSP,@gia,@anh,@soLuong,@thongSo,@maLoai,@maHang)
end
go

alter proc select_SP
as begin
select * from sanPham,nhomSP where sanPham.maLoai=nhomSP.maLoai
end

go
alter proc updateSP(
@maSP nvarchar(50),
@tenSP nvarchar(50),
@gia float,
@anh image,
@maLoai nvarchar(50),
@maHang nvarchar(50)
)
as begin
update sanPham set tenSP=@tenSP,gia=@gia,anh=@anh,maLoai=@maLoai, maHang=@maHang where maSP=@maSP
end
go
create proc deleteSP(@maSP nvarchar(50))
as begin
delete sanPham where maSP=@maSP
end

<<<<<<< HEAD
-- Thêm, sửa, xóa khách hàng
--Thêm
create proc KH_Ins (
@ma nvarchar(50), @ten nvarchar(50),
@gt nvarchar(50), @ns date, @ema nvarchar(50),
@dc nvarchar(50), @sdt nvarchar(50)
) as begin
insert into khachHang values (@ma,@ten,@gt,@ns,@ema,@dc,@sdt) 
end
--xoa
create proc KH_Del (@ma nvarchar(50)) 
as begin
delete khachHang where maKH = @ma
end
--sua
alter proc KH_Up (
@ma nvarchar(50), @ten nvarchar(50),
@gt nvarchar(50), @ns date, @ema nvarchar(50),
@dc nvarchar(50), @sdt nvarchar(50)
) as
begin
	update khachHang set tenKH = @ten, gioiTinh = @gt, ngSinh = @ns,
							email = @ema, diaChi = @dc, sdt = @sdt
	where maKH=@ma
end
--Thống kê danh sách khách hàng
create proc KH_Sel as
begin
select * from khachHang
end
--Thêm, sửa, xóa nhân viên
--Thống kê danh sách nhân viên
create proc NV_Sel as
begin
select * from nhanVien
end
--Thêm
create proc NV_Ins (
@ma nvarchar(50), @ten nvarchar(50),
@gt nvarchar(50), @ns date, @nvl date, 
@ema nvarchar(50), @dc nvarchar(50), @sdt nvarchar(50)
) as begin
insert into nhanVien values (@ma, @ten, @gt, @ns, @nvl, @ema, @dc, @sdt,null,null)
end
--Xóa
create proc NV_Del (@ma nvarchar(50)) 
as begin
delete nhanVien where maNV = @ma
end
--Sửa
create proc NV_Up (
@ma nvarchar(50), @ten nvarchar(50),
@gt nvarchar(50), @ns date, @nvl date,
@ema nvarchar(50),
@dc nvarchar(50), @sdt nvarchar(50)
) as
begin
	update nhanVien set tenNV = @ten, gioiTinh = @gt, ngSinh = @ns,
						ngVaoLam = @nvl, email = @ema, diaChi = @dc, 
						sdt = @sdt
	where maNV=@ma
end
=======
<<<<<<< HEAD:SQLQuery2.sql
go
create proc addProvider(@maNCC nvarchar(50),
@tenNCC nvarchar(50),
@email nvarchar(50),
@diaChi nvarchar(50),
@sdt nvarchar(50))
as begin
insert into nhaCungCap values (@maNCC,@tenNCC,@email,@diaChi,@sdt)
end
go
create proc updateProvider(
@maNCC nvarchar(50),
@tenNCC nvarchar(50),
@email nvarchar(50),
@diaChi nvarchar(50),
@sdt nvarchar(50))
as begin
update nhaCungCap set tenNCC=@tenNCC,email=@email,diaChi=@diaChi,sdt=@sdt where maNCC=@maNCC
end
go
=======
>>>>>>> 46112605d9a90d3477e9a1c02785010c56ae5ceb:Procedure.sql
>>>>>>> 7b4a1af0456ed5ad8e845db50bc65898bf27069e
