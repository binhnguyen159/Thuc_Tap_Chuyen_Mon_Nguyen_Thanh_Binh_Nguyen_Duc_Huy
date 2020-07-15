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

create proc select_SP
as begin
select s.maSP,s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
from sanPham s, nhomSP n, HangSP h
where n.maLoai=s.maLoai and h.maHang=s.maHang
end

go
create proc updateSP(
@maSP nvarchar(50),
@tenSP nvarchar(50),
@gia float,
@anh image,
@maLoai nvarchar(50),
@maHang nvarchar(50))
as begin
update sanPham set 
	tenSP = @tenSP, 
	gia = @gia,
	anh = @anh,
	maLoai = @maLoai, 
	maHang = @maHang 
	where maSP=@maSP
end
go
create proc deleteSP(@maSP nvarchar(50))
as begin
delete sanPham where maSP=@maSP
end

-- Thêm, sửa, xóa khách hàng
--Thêm
go
create proc KH_Ins (
@ma nvarchar(50), @ten nvarchar(50),
@gt nvarchar(50), @ns date, @ema nvarchar(50),
@dc nvarchar(50), @sdt nvarchar(50)
) as begin
insert into khachHang values (@ma,@ten,@gt,@ns,@ema,@dc,@sdt) 
end
--xoa
go
create proc KH_Del (@ma nvarchar(50)) 
as begin
delete khachHang where maKH = @ma
end
--sua
go
create proc KH_Up (
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
go
create proc KH_Sel as
begin
select * from khachHang
end
--Thêm, sửa, xóa nhân viên
--Thống kê danh sách nhân viên
go
create proc NV_Sel as
begin
select * from nhanVien
end
--Thêm
go
create proc NV_Ins (
@ma nvarchar(50), @ten nvarchar(50),
@gt nvarchar(50), @ns date, @nvl date, 
@ema nvarchar(50), @dc nvarchar(50), @sdt nvarchar(50)
) as begin
insert into nhanVien values (@ma, @ten, @gt, @ns, @nvl, @ema, @dc, @sdt,null,null,null)
end
--Xóa
go
create proc NV_Del (@ma nvarchar(50)) 
as begin
delete nhanVien where maNV = @ma
end
--Sửa
go
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
go
create proc ACC_Sel as
begin
	select maNV, tenNV, ngSinh, tendn from nhanVien
end
go
--Thêm
create proc ACC_Add (@ma nvarchar(50), @dn nvarchar(50),@pass nvarchar(50))
as begin
	update nhanVien set tendn = @dn, passWords = @pass where maNV = @ma
end
go
--Sửa
create proc ACC_Up (@ma nvarchar(50),@pass nvarchar(50)) as
begin
	update nhanVien set passWords = @pass where maNV = @ma
end
go
--Xóa
create proc ACC_Del (@ma nvarchar(50)) as
begin
	update nhanVien set passWords = null, tendn = null where maNV = @ma
end
select maNV,tendn,passWords from nhanVien
--FindID
go
create proc ACC_FindID (@ma nvarchar(50)) as
begin
	select maNV, tenNV, ngSinh, tendn from nhanVien where maNV like '%' + @ma + '%'
end
--Find tên đăng nhập
go
create proc ACC_FindTenDN (@tdn nvarchar(50)) as
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
create proc select_detailCart (@maGio int)
as begin
select CTGio.masp,sanPham.tenSP,sanPham.anh,sanPham.gia,CTGio.soLuong,CTGio.maCTG from CTGio,sanPham
where CTGio.masp=sanPham.maSP and CTGio.magio=@maGio
end
go



go
create proc selectTotalPrice 
as begin 
select SUM(thanhTien) as 'a' from CTGio 
end
go
use TTCM
go

alter proc insert_cart(@maGio int,@maSP nvarchar(50),@soLuong int,@donGia float,@thanhTien float)
as begin
if(not exists(select * from CTGio where masp=@maSP))
	begin
		insert into CTGio values (@maGio,@maSP,@soLuong,@donGia,@thanhTien)
	end
else
	begin
		update CTGio set soluong=soluong+@soLuong where masp=@maSP
	end
end

--create proc insert_cart(@maGio int,@maSP nvarchar(50),@soLuong int,@donGia float,@thanhTien float)
--	 begin 
--		if(not exists(select * from CTGio where masp=@maSP))
--			begin
--		insert into CTGio values (@maGio,@maSP,@soLuong,@donGia,@thanhTien)
--	end
--else
--	begin
--		update CTGio set soluong=soluong+@soLuong where masp=@maSP
--	end
--end
go
create proc update_SoLuongGio (@maCTGio int ,@soLuong int,@thanhTien float)
as begin
update CTGio set soluong=@soLuong,thanhTien=@thanhTien where maCTG=@maCTGio
end
go

--exec update_SoLuongGio 1, 10

go
--exec insert_cart 1,N'sp6',5
go
 create proc delete_CTcart(@maCTG int)
 as begin
 delete CTGio where maCTG=@maCTG
 end
 --NHÀ CUNG CẤP
 --Load
 go
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
 create proc NCC_FindiD (@ma nvarchar(50)) as
 begin
	select * from nhaCungCap where maNCC like '%'+@ma+'%'
 end
 go
 --Tìm theo tên
  create proc NCC_FindName(@name nvarchar(50)) as
 begin
	select * from nhaCungCap where tenNCC like  N'%'+@name+N'%'
 end
 go
 --Tìm theo địa chỉ
  create proc NCC_FindAddress (@address nvarchar(50)) as
 begin
	select * from nhaCungCap where diaChi like N'%'+@address+N'%'
 end
 go

 create proc selectCTGio(@maGio int)
 as begin
 select * from CTGio where magio=@maGio
 end
 go

 create proc cthdx_insert(@maHDX nvarchar(50),@maSP nvarchar(50),@donGia float,@soLuong int,@thanhTien float)
 as begin
 insert into chiTietHDX values (@maHDX,@maSP,@donGia,@soLuong,@thanhTien)
 end 

 go 
 create proc hdx_select
 as begin
 select * from hoadDonXuat,khachHang,nhanVien 
 where hoadDonXuat.maKH=khachHang.maKH and hoadDonXuat.maNV=nhanVien.maNV
 end
 go
 use TTCM
 go
create proc bill_search(@a nvarchar(50))
as begin
select kh.maKH,kh.tenKH,kh.email,kh.sdt,hdx.maHDX,hdx.ngayBan,hdx.tongTien,hdx.trangThai, nv.tenNV
from khachHang kh, hoadDonXuat hdx ,nhanVien nv
where CONCAT(kh.maKH,kh.tenKH,kh.email,kh.sdt,hdx.maHDX,hdx.ngayBan,hdx.tongTien,hdx.trangThai, nv.tenNV)like '%'+@a+'%' and hdx.maKH = kh.maKH and hdx.maNV=nv.maNV
group by kh.maKH,kh.tenKH,kh.email,kh.sdt,hdx.maHDX,hdx.ngayBan,hdx.tongTien,hdx.trangThai, nv.tenNV
end
go

create proc khachHang_search(@tenKH nvarchar(50))
as begin
select maKH,tenKH from khachHang
where CONCAT(maKH,tenKH) like '%' +@tenKH+'%'
end

--PHIẾU NHẬP
--Thêm
go
create proc PN_Ins (@ma nvarchar(50), @manv nvarchar(50), @ng date) as
begin
	insert into PhieuNhap values (@ma,@manv,@ng)
end
go
--Xóa
create proc PN_Del (@ma nvarchar(50)) as
begin
	delete PhieuNhap where maphieu = @ma
end
go
--Sửa
--create proc PN_Up (@ma nvarchar(50), @manv nvarchar(50), @ng date) as
--begin
--	update PhieuNhap set where maphieu= --(@ma,@manv,@ng)
--end

go
alter proc hdx_insert(
@maHDX nvarchar(50),@maNV nvarchar(50),@maKH nvarchar(50),@tongTien float,@trangThai nvarchar(50),@ngayBan date,@giamGia int)
as begin
insert into hoadDonXuat values (@maHDX,@maNV,@maKH,@tongTien,@trangThai,@ngayBan,@giamGia)
end

go
create proc insert_gioHang(@maKh nvarchar(50))
as begin
insert into GioHang values (@maKh)
end
go
--create proc insert_cthdx(@maHDX nvarchar(50),@maSP nvarchar(50),@soLuong int,@donGia float,@thanhTien float)
--as begin
--if(not exists(select * from CTGio where masp=@maSP))
--	begin
--		insert into CTGio values (@maHDX,@maSP,@soLuong,@donGia,@thanhTien)
--	end
--else
--	begin
--		update CTGio set soluong=soluong+@soLuong where masp=@maSP
--	end
--end
use TTCM

go
alter proc delete_cart(@maGio int)
as begin
delete CTGio where CTGio.magio=@maGio
delete GioHang where GioHang.magio=@maGio
end
go


create proc update_status_hoadon(@maHDX nvarchar(50),@status nvarchar(50))
as begin
update hoadDonXuat set trangThai=@status where maHDX=@maHDX
end

go
create proc ThemTongTienXuat(@MaHDX nvarchar(50))
as begin
declare @sum float
set @sum= (select SUM(ct.soLuong*ct.thanhTien) as 'tongTien'
			from chiTietHDX ct,hoadDonXuat hd
			where ct.maHDX=hd.maHDX and hd.maHDX=@MaHDX)
update hoadDonXuat set tongTien=@sum where maHDX=@MaHDX
end
go
-- san pham select
alter proc Product_select
as begin
select sanPham.maSP,sanPham.tenSP,sanPham.gia,nhomSP.tenLoai from sanPham,nhomSP
where sanPham.maLoai=nhomSP.maLoai
end
go
 alter proc bill_info (@maHdx nvarchar(50))
 as begin
 select hdx.maHDX,hdx.ngayBan,hdx.tongTien,hdx.trangThai,hdx.maKH,hdx.maNV,hdx.giamGia,
		kh.tenKH,kh.email,kh.diaChi,kh.sdt,
		nv.tenNV,nv.sdt,
		sp.tenSP,sp.thongSo,sp.gia,
		ctHD.soLuong,ctHD.thanhTien,ctHD.maSP
 from hoadDonXuat hdx,khachHang kh,nhanVien nv,sanPham sp,chiTietHDX ctHD
 where hdx.maKH=kh.maKH and hdx.maNV=nv.maNV
		and hdx.maHDX=ctHD.maHDX and ctHD.maSP=sp.maSP and hdx.maHDX=@maHdx
 end
 go
 exec  bill_info N'hdx000003'
 go
 create proc update_soluong(@maSP nvarchar(50),@soLuong int)
 as begin
 update sanPham set soLuong=@soLuong where maSP=@maSP
 end
