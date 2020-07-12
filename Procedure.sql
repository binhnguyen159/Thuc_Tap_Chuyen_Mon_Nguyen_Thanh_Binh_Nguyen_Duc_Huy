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
exec select_SP
go


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
go
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
go
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
go
--Thêm
go
create proc NV_Ins (
@ma nvarchar(50), @ten nvarchar(50),
@gt nvarchar(50), @ns date, @nvl date, 
@ema nvarchar(50), @dc nvarchar(50), @sdt nvarchar(50)
) as begin
insert into nhanVien values (@ma, @ten, @gt, @ns, @nvl, @ema, @dc, @sdt,null,null,null)
end
go
--Xóa
go
create proc NV_Del (@ma nvarchar(50)) 
as begin
delete nhanVien where maNV = @ma
end
go
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
go
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
--select maNV,tendn,passWords from nhanVien
--FindID
go
create proc ACC_FindID (@ma nvarchar(50)) as
begin
	select maNV, tenNV, ngSinh, tendn from nhanVien where maNV like '%' + @ma + '%'
end
go
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
alter proc insert_cart(@maGio int,@maKH nvarchar,@maSP nvarchar(50),@soLuong int,@donGia float,@thanhTien float)
as begin
if(not exists(select * from GioHang where magio=@maGio))
	begin 
		insert into GioHang values (@maKH)
	end
else if(not exists(select * from CTGio where masp=@maSP))

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
 go
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

create proc SP_Filter_Group (@loai nvarchar(50)) as
begin
	select s.maSP,s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
	from sanPham s, nhomSP n, HangSP h
	where n.maLoai=s.maLoai and h.maHang=s.maHang and n.tenLoai = @loai
end
go
--exec SP_Filter_Group N'Tai nghe'
go 
create proc SP_Filter_Gr_Br (@loai nvarchar(50), @hang nvarchar(50)) as
begin
	select s.maSP,s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
	from sanPham s, nhomSP n, HangSP h
	where n.maLoai=s.maLoai and h.maHang=s.maHang and n.tenLoai = @loai and h.tenHang = @hang
end
go
create proc SP_Filter_Brand (@hang nvarchar(50)) as
begin
	select s.maSP,s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
	from sanPham s, nhomSP n, HangSP h
	where n.maLoai=s.maLoai and h.maHang=s.maHang and h.tenHang = @hang
end
go
create proc SP_Find_id (@ma nvarchar(50)) as
begin
	select s.maSP,s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
	from sanPham s, nhomSP n, HangSP h
	where n.maLoai=s.maLoai and h.maHang=s.maHang and s.maSP = @ma
end
go
--NHÓM SẢN PHẨM
--tìm theo id hoặc name
alter PROC	NSP_Find (@ma nvarchar(50),@ten nvarchar(50)) as
begin
	if (@ma is not null and @ten is not null)
	begin
		select * from nhomSP where maLoai like '%' + @ma + '%' and tenLoai like '%' + @ten + '%'
	end
	else if(@ten is null)
	begin
		select * from nhomSP where maLoai like '%' + @ma + '%'
	end
	else if (@ma is null)
	begin
		select * from nhomSP where tenLoai like '%' + @ten + '%'
	end
end
go
--load
create proc NSP_Sel as
begin
	select * from nhomSP
end
go
--Thêm
create proc NSP_Add (@ma nvarchar(50),@ten nvarchar(50)) as
begin
	insert into nhomSP values (@ma,@ten)
end
go
--Xóa
create proc NSP_Del (@ma nvarchar(50)) as
begin
	delete nhomSP where maLoai = @ma
end
go
--Sửa
create proc NSP_Up (@ma nvarchar(50),@ten nvarchar(50)) as
begin
	update nhomSP set tenLoai = @ten where maLoai = @ma
end
go
--HÃNG SẢNG PHẨM
--Tìm kiếm theo id, name
alter proc HSP_Find (@ma nvarchar(50), @ten nvarchar(50)) as
begin
	if (@ma is not null and @ten is not null)
	begin
		select * from HangSP where maHang like '%' + @ma + '%' and tenHang like '%' + @ten + '%'
	end
	else if(@ten is null)
	begin
		select * from HangSP where maHang like '%' + @ma + '%'
	end
	else if (@ma is null)
	begin
		select * from HangSP where tenHang like '%' + @ten + '%'
	end
end
go
--load
create proc HSP_Sel as
begin
	select * from HangSP
end
go
--thêm
create proc HSP_Ins (@ma nvarchar(50), @ten nvarchar(50)) as
begin
	insert into HangSP values (@ma, @ten)
end
go
--xóa
create proc HSP_Del (@ma nvarchar(50)) as
begin
	delete HangSP where maHang = @ma
end
go
--sửa
create proc HSP_Up (@ma nvarchar(50), @ten nvarchar(50)) as
begin
	Update HangSP set tenHang = @ten where maHang = @ma
end
go
go
create proc hdx_insert(
@maHDX nvarchar(50),@maNV nvarchar(50),@maKH nvarchar(50),@tongTien float,@trangThai nvarchar(50),@ngayBan date)
as begin
insert into hoadDonXuat values (@maHDX,@maNV,@maKH,@tongTien,@trangThai,@ngayBan)
end

go
create proc insert_gioHang(@maKh nvarchar(50))
as begin
insert into GioHang values (@maKh)
end
