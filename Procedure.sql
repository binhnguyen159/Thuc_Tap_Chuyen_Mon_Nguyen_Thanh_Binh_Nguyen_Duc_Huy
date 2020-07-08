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
alter proc NV_Ins (
@ma nvarchar(50), @ten nvarchar(50),
@gt nvarchar(50), @ns date, @nvl date, 
@ema nvarchar(50), @dc nvarchar(50), @sdt nvarchar(50)
) as begin
insert into nhanVien values (@ma, @ten, @gt, @ns, @nvl, @ema, @dc, @sdt,null,null,null)
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

--<<<<<<< HEAD
--TÀI KHOẢN
--Thống kê danh sách
create proc ACC_Sel as
begin
	select maNV, tenNV, ngSinh, tendn from nhanVien
end
go
--Thêm
alter proc ACC_Add (@ma nvarchar(50), @dn nvarchar(50),@pass nvarchar(50))
as begin
	update nhanVien set tendn = @dn, passWords = @pass where maNV = @ma
end
go
--Sửa
alter proc ACC_Up (@ma nvarchar(50),@pass nvarchar(50)) as
begin
	update nhanVien set passWords = @pass where maNV = @ma
end
go
--Xóa
alter proc ACC_Del (@ma nvarchar(50)) as
begin
	update nhanVien set passWords = null, tendn = null where maNV = @ma
end
select maNV,tendn,passWords from nhanVien
--FindID
create proc ACC_FindID (@ma nvarchar(50)) as
begin
	select maNV, tenNV, ngSinh, tendn from nhanVien where maNV like '%' + @ma + '%'
end
--Find tên đăng nhập
alter proc ACC_FindTenDN (@tdn nvarchar(50)) as
begin
	select maNV, tenNV, ngSinh, tendn from nhanVien where tendn like '%' + @tdn + '%'
end
exec acc_findId N'1'
exec acc_FindTenDN N'h'
go
create proc select_cart(@maKH nvarchar(50))
as begin
select gh.magio,kh.tenKH from khachHang kh, GioHang gh
where gh.makh=kh.maKH and kh.maKH=@maKH
end
go
create proc select_detailCart(@maGio int)
as begin
select CTGio.masp,sanPham.tenSP,sanPham.anh,sanPham.gia,CTGio.soLuong,CTGio.maCTG from CTGio,sanPham
where CTGio.masp=sanPham.maSP and CTGio.magio=@maGio
end
go

use TTCM
go
create proc insert_cart(@maGio int,@maSP nvarchar(50),@soLuong int)
as begin 
insert into CTGio values (@maGio,@maSP,@soLuong)
end

go

create proc update_SoLuongGio (@maCTGio int ,@soLuong int)
as begin
update CTGio set soluong=@soLuong where maCTG=@maCTGio
end
go


--exec insert_cart 1,N'sp6',5
go
<<<<<<< HEAD
--đang suy nghĩ
 --create proc delete_CTcart(@maCTG int)
 --as begin
 --delete CTGio where maCTG=@maCTG
 --end
 --go
 --create proc insert_hdx(@maHDX nvarchar(50),
 --@maNV nvarchar(50),
 --@maKH nvarchar(50),
 --@ngayBan date,
 --@tongTien float,
 --@trangThai nvarchar(50))
 --as begin 
 --insert into hoadDonXuat values (@maHDX,@maKH,@maNV,@ngayBan,@tongTien,@trangThai)
 --end

 go
 --có dùng
-- create proc insert_ctHDX(@maHDX nvarchar(50),@maSP nvarchar(50),@donGia float,@soLuong int,@thanhTien float)
-- as begin
-- declare @bienTam int
-- set @bienTam=(select soLuong from chiTietHDX where maHDX=@maHDX and maSP=@maSP)
--	if(not exists(select * from chiTietHDX where maHDX=@maHDX and maSP=@maSP))
--		begin 
--			insert into chiTietHDX values(@maHDX,@maSP,@donGia,@soLuong,@thanhTien)
--		end
--	else
--		begin
--			update chiTietHDX set soLuong=@bienTam+@soLuong where maSP=@maSP and maHDX=@maHDX
--		end
--end
=======
 create proc delete_CTcart(@maCTG int)
 as begin
 delete CTGio where maCTG=@maCTG
 end
<<<<<<< HEAD
 --NHÀ CUNG CẤP
 --Load
 create proc NCC_Sel as
 begin
	select * from nhaCungCap
 end
 go
 --thêm
 create proc NCC_Ins (
 @ma nvarchar(50), @ten nvarchar(50),
 @email nvarchar(50),@dc nvarchar(50),
 @dt nvarchar(50)) as
 begin
	insert into nhaCungCap values(@ma,@ten,@email,@dc,@dt)
 end
 go
 --xóa
 create proc NCC_Del (@ma nvarchar(50)) as
 begin
	delete nhaCungCap where maNCC = @ma
 end
 go
 --Sửa
 create proc NCC_Up (
 @ma nvarchar(50), @ten nvarchar(50),
 @email nvarchar(50),@dc nvarchar(50),
 @dt nvarchar(50)
 ) as begin
	update nhaCungCap set tenNCC=@ten, email = @email,
							diaChi=@dc, sdt = @dt
						where maNCC = @ma
 end
 go
 --Tìm theo id
 alter proc NCC_FindiD (@ma nvarchar(50)) as
 begin
	select * from nhaCungCap where maNCC like '%'+@ma+'%'
 end
 go
 --Tìm theo tên
  alter proc NCC_FindName(@name nvarchar(50)) as
 begin
	select * from nhaCungCap where tenNCC like  N'%'+@name+N'%'
 end
 go
 --Tìm theo địa chỉ
  alter proc NCC_FindAddress (@address nvarchar(50)) as
 begin
	select * from nhaCungCap where diaChi like N'%'+@address+N'%'
 end
 go
 exec NCC_FindiD '1'
=======
-->>>>>>> d952e4b925ab4043c172fea4f06b8d2a06ab2067
>>>>>>> b8694212c370b8fd894c14f7bf024d3db0664a04
>>>>>>> 2884edc269d3f0f57d24ff296145e99126e69e0e
