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
alter proc updateSP(
@maSP nvarchar(50),
@tenSP nvarchar(50),
@gia float,
@anh image,
@ts nvarchar(1000),
@maLoai nvarchar(50),
@maHang nvarchar(50))
as begin
update sanPham set 
	tenSP = @tenSP, 
	gia = @gia,
	anh = @anh,
	thongSo = @ts,
	maLoai = @maLoai, 
	maHang = @maHang 
	where maSP=@maSP
end
go

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
create proc hdx_insert(
@maHDX nvarchar(50),@maNV nvarchar(50),@maKH nvarchar(50),@tongTien float,@trangThai nvarchar(50),@ngayBan date,@giamGia int)
as begin
insert into hoadDonXuat values (@maHDX,@maNV,@maKH,@ngayBan,@giamGia,@tongTien,@trangThai)
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

 
 go
 alter proc thongKeDoanhThu
 as begin
	drop  table if exists tam
	create table tam (thang int primary key,tien decimal)
	declare @tongTien decimal,@i int =1
	while (@i<13)
		begin
			insert into tam values (@i,0)
			set @i=@i+1
		end
	set @i=1
	while(@i<13)
		begin
		declare @count int =0 
			select @count=count(*) from hoadDonXuat where DATEPart(MONTH,ngayBan)=@i and DATEPART(YEAR,ngayBan)=DATEPART(YEAR,GETDATE())
			if(@count>0)
				begin
					select @tongTien=SUM(tongTien) from hoadDonXuat where DATEPart(MONTH,ngayBan)=@i and DATEPART(YEAR,ngayBan)=DATEPART(YEAR,GETDATE())
				end
			else
				begin 
					set @tongTien=0
				end
			update tam set tien=@tongTien where thang=@i
			set @i=@i+1
		end
		select N'Month '+CAST (thang as nvarchar(2)) as [thang],tien  from tam
 end

 go 


-- go
-- create proc mathuoc_banchaytrongthang 
--as begin

--select  t.TEN as [Tên sản phẩm],t.SOLO as [Số lô],sum(ct.SOLUONG) as [SL đã bán]
--from HOADON hd, CT_HD CT, SANPHAM t
--where CT.MATHUOC = t.MATHUOC and hd.MAHD = ct.MAHD and datepart(m, hd.ngay) = datepart (m, getdate())  and hd.status !=0
--group by ct.MATHUOC, t.TEN,t.SOLO
--order by [SL đã bán] desc -- giảm dần // asc tăng dần 

--end
--go

--CREATE proc mathuoc_banchaytrongthang
--as begin
--declare @date date
--select @date = CAST(info.value('invoiceIssuedDate[1]','date') as date) from Invoice
--cross apply Invoice.InvoiceInfo.nodes('/invoice/invoiceData') as XMLdata(info)
--where Invoice.status !=0 and datepart(YEAR, CAST(info.value('invoiceIssuedDate[1]','date') as date)) = datepart (YEAR, getdate()) 
--	and datepart(m, CAST(info.value('invoiceIssuedDate[1]','date') as date)) = datepart (m, getdate())

--select  t.TEN as [Tên sản phẩm],t.SOLO as [Số lô],sum(CAST(info.value('quantity[1]','int')*info.value('exchangeValue[1]','int') as int)) as [SL đã bán]
--from SANPHAM t,Invoice
--cross apply Invoice.InvoiceInfo.nodes('/invoice/invoiceData/items/item') as XMLdata(info)
--where info.value('itemCode[1]','nvarchar(max)') = t.MATHUOC and 
--	datepart(m, @date) = datepart (m, getdate())  and Invoice.status !=0 and t.statusDelete = 1
--	and datepart(YEAR, @date) = datepart (YEAR, getdate())
--group by t.TEN,t.SOLO
--order by [SL đã bán] desc -- giảm dần // asc tăng dần 

--end
go
alter proc find_most_product_sale (@startDay date,@endDay date)
 as begin
	select sp.maSP, sp.tenSP, SUM(cthdx.soLuong) as 'a'
	from hoadDonXuat hdx, chiTietHDX cthdx, sanPham sp
	where hdx.maHDX = cthdx.maHDX and sp.maSP = cthdx.maSP and hdx.trangThai = 'Priced'  
	and hdx.ngayBan >= @startDay and hdx.ngayBan <= @endDay
	group by sp.maSP, sp.tenSP
	order by sp.maSP asc
 end
 exec find_most_product_sale '2020/07/18','2020/07/17'

 go
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
create proc HSP_Find (@ma nvarchar(50), @ten nvarchar(50)) as
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
--tìm theo id hoặc name
create PROC	NSP_Find (@ma nvarchar(50),@ten nvarchar(50)) as
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
create proc SP_Page (@from int, @to int)
as begin
	select * from (
		select  s.maSP, Row_number() over (order by s.masp) as rownum, s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
		from sanPham s, nhomSP n, HangSP h
		where n.maLoai=s.maLoai and h.maHang=s.maHang
	) as TableRow 
	where TableRow.rownum between @from  and @to
end
go
ex
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

go
exec SP_page 1, 50
go
create proc SP_Find (@from int, @to int, @data nvarchar(50))
as begin
	select * from (
		select s.maSP,Row_number() over (order by s.masp) as rownum,s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
		from sanPham s, nhomSP n, HangSP h
		where n.maLoai=s.maLoai and h.maHang=s.maHang and (
			dbo.fuConvertToUnsign1(s.maSP)  like N'%' + dbo.fuConvertToUnsign1(@data) + N'%' 
			or dbo.fuConvertToUnsign1(s.tenSP) like '%' + dbo.fuConvertToUnsign1(@data)  + '%'  
			--or dbo.fuConvertToUnsign1(h.tenHang) like N'%' +  dbo.fuConvertToUnsign1(@data) + N'%' 
			--or dbo.fuConvertToUnsign1(n.tenLoai) like N'%' + dbo.fuConvertToUnsign1(@data) + N'%'
			)
	) as TableRow
	where TableRow.rownum between @from  and @to
end
go

create proc SP_Find_Data (@data nvarchar(50)) as
begin
	select s.maSP,s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
	from sanPham s, nhomSP n, HangSP h
	where n.maLoai=s.maLoai and h.maHang=s.maHang and (
		dbo.fuConvertToUnsign1(s.maSP)  like N'%' + dbo.fuConvertToUnsign1(@data) + N'%' 
		or dbo.fuConvertToUnsign1(s.tenSP) like '%' + dbo.fuConvertToUnsign1(@data)  + '%'  
		--or dbo.fuConvertToUnsign1(h.tenHang) like N'%' +  dbo.fuConvertToUnsign1(@data) + N'%' 
		--or dbo.fuConvertToUnsign1(n.tenLoai) like N'%' + dbo.fuConvertToUnsign1(@data) + N'%'
		)
end
go
CREATE proc SP_Page_Find_NSP (@from int, @to int, @ten nvarchar(50))
as begin
	select * from (
		select  s.maSP, Row_number() over (order by s.masp) as rownum, s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
		from sanPham s, nhomSP n, HangSP h
		where n.maLoai=s.maLoai and h.maHang=s.maHang and (n.tenLoai = @ten)
	) as TableRow
	where TableRow.rownum between @from  and @to
end
go

---start here
create proc SP_Page_Find_NSP_HSP_Name (@from int, @to int, @ten1 nvarchar(50), @ten2 nvarchar(50), @name nvarchar(50))
as begin
	select * from (
		select  s.maSP, Row_number() over (order by s.masp) as rownum, s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
		from sanPham s, nhomSP n, HangSP h
		where n.maLoai=s.maLoai and h.maHang=s.maHang and (n.tenLoai = @ten1 and h.tenHang = @ten2) and s.tenSP like '%' + @name + '%'
	) as TableRow
	where TableRow.rownum between @from  and @to
end
go
create proc SP_Page_Find_NSP_Name (@from int, @to int, @ten nvarchar(50),@name nvarchar(50))
as begin
	select * from (
		select  s.maSP, Row_number() over (order by s.masp) as rownum, s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
		from sanPham s, nhomSP n, HangSP h
		where n.maLoai=s.maLoai and h.maHang=s.maHang and (n.tenLoai = @ten) and s.tenSP like '%' + @name + '%'
	) as TableRow
	where TableRow.rownum between @from  and @to
end
go
create proc SP_Page_Find_NSP_HSP (@from int, @to int, @ten1 nvarchar(50), @ten2 nvarchar(50))
as begin
	select * from (
		select  s.maSP, Row_number() over (order by s.masp) as rownum, s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
		from sanPham s, nhomSP n, HangSP h
		where n.maLoai=s.maLoai and h.maHang=s.maHang and (n.tenLoai = @ten1 and h.tenHang = @ten2)
	) as TableRow
	where TableRow.rownum between @from  and @to
end
go
create proc Hang_in_Group (@loai nvarchar(50)) as
begin
	select distinct h.tenHang from HangSP h, sanPham s, nhomSP n
	where h.maHang = s.maHang and n.maLoai=s.maLoai and n.tenLoai = @loai
end
go
create proc SP_Page_Filter_Amount (@from int, @to int)
as begin
	select * from (
		select  s.maSP, Row_number() over (order by s.masp) as rownum, s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
		from sanPham s, nhomSP n, HangSP h
		where n.maLoai=s.maLoai and h.maHang=s.maHang and (s.soLuong < 10)
	) as TableRow
	where TableRow.rownum between @from  and @to
end
go

create proc SP_Page_Filter_NSP_Amount (@from int, @to int, @ten1 nvarchar(50))
as begin
	select * from (
		select  s.maSP, Row_number() over (order by s.masp) as rownum, s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
		from sanPham s, nhomSP n, HangSP h
		where n.maLoai=s.maLoai and h.maHang=s.maHang and s.soLuong < 10 and n.tenLoai = @ten1
	) as TableRow
	where TableRow.rownum between @from  and @to
end
go
create proc SP_Page_Filter_NSP_HSP_Amount (@from int, @to int, @ten1 nvarchar(50), @ten2 nvarchar(50))
as begin
	select * from (
		select  s.maSP, Row_number() over (order by s.masp) as rownum, s.tenSP,s.anh,s.gia,s.soLuong,n.tenLoai,h.tenHang
		from sanPham s, nhomSP n, HangSP h
		where n.maLoai=s.maLoai and h.maHang=s.maHang and s.soLuong < 10 and n.tenLoai = @ten1 and h.tenHang = @ten2
	) as TableRow
	where TableRow.rownum between @from  and @to
end
go

create proc HDN_Ins (
	@ma nvarchar(50), 
	@manv nvarchar(50), 
	@mancc nvarchar(50),
	@ngNhap date,
	@tTien float,
	@tThai nvarchar(50)) as
begin
	insert into hoadDonNhap values (@ma,@manv,@mancc,@tTien,@tThai,@ngNhap)
end
go
--xóa
create proc HDN_Del(@ma nvarchar(50)) as
begin
	delete chiTietHDN where maHDN = @ma
	delete hoadDonNhap where maHDN = @ma
end
go
--Sửa
create proc HDN_Up (@ma nvarchar(50), @tThai nvarchar(50)) as
begin
	update hoadDonNhap set trangThai = @tThai where maHDN = @ma
end
go
--Load
create proc HDN_Sel as
begin
	select hdn.maHDN, hdn.ngayNhap,ncc.tenNCC,nv.tenNV,hdn.tongTien,hdn.trangThai from hoadDonNhap hdn, nhanVien nv, nhaCungCap ncc
	where hdn.maNCC = ncc.maNCC and hdn.maNV=nv.maNV
end
go
--load
create proc HDN_Sel_Date (@d1 date, @d2 date) as
begin
	select hdn.maHDN, hdn.ngayNhap,ncc.tenNCC,nv.tenNV,hdn.tongTien,hdn.trangThai from hoadDonNhap hdn, nhanVien nv, nhaCungCap ncc
	where hdn.maNCC = ncc.maNCC and hdn.maNV=nv.maNV and --hdn.ngayNhap<='2020-07-15' and hdn.ngayNhap>='2020-07-15'
	hdn.ngayNhap>=@d1 and hdn.ngayNhap<=@d2
end
go
create trigger CTHDN_Ins_tr 
	 on chiTietHDN after insert as
begin
	declare @mahd nvarchar(50), @masp nvarchar(50),  @tt float, @sl int, @gia float
	select @mahd = maHDN, @masp = maSP, 
			@sl = soLuong, @gia=donGia from inserted
	set @tt = @sl*@gia
	update sanPham set soLuong +=@sl where maSP = @masp
	update chiTietHDN set thanhTien = @tt where maHDN = @mahd and maSP = @masp
	update hoadDonNhap set tongTien = (
		select SUM(thanhTien) from chiTietHDN where maHDN = @mahd
	) where maHDN = @mahd
end
go
--delete chiTietHDN

--Xóa
create trigger CTHDN_Del_tr
	on chitiethdn for delete as
begin
	declare @mahd nvarchar(50), @masp nvarchar(50),
			@sl int, @gia float
	select @mahd = maHDN, @masp = maSP, @sl = soLuong, @gia = donGia from deleted
	update sanPham set soLuong -= @sl where maSP = @masp
	
	if ((select COUNT(*) as a from chiTietHDN where maHDN = @mahd)=0)
	begin
		update hoadDonNhap set tongTien = 0 where maHDN = @mahd
	end
	update hoadDonNhap set tongTien = (
		select SUM(thanhTien) from chiTietHDN where maHDN = @mahd
	) where maHDN=@mahd
end
go
--Sửa
create trigger CTHDN_Up_tr on chitiethdn after update as
begin
	declare @mahd nvarchar(50), @masp nvarchar(50),
			@slc int, @slm int, @gia float,@tt float
	select @mahd=maHDN,@masp=maSP,
			@slm=soLuong,@gia=donGia from inserted
	select @slc = soluong from deleted
	set @tt = @slm * @gia
	update sanPham set soLuong = soLuong - @slc + @slm where maSP = @masp
	update chiTietHDN set thanhTien = @tt where maHDN = @mahd and maSP = @masp
	update hoadDonNhap set tongTien = (
		select SUM(thanhTien) from chiTietHDN where maHDN = @mahd
	) where maHDN = @mahd
end
go
create proc CTHDN_Ins (
	@mahd nvarchar(50), 
	@masp nvarchar(50), 
	@gia float, 
	@sl int, 
	@ttien float)
as 
begin 
	insert into chiTietHDN values (@mahd,@masp,@gia,@sl,@ttien)
end
go
--exec CTHDN_Ins N'HDN000001','SP000001',12, 3,0
--exec CTHDN_Ins N'HDN000001','SP000002',15, 15,0
--exec CTHDN_Ins N'HDN000002','SP000001',11, 11,0
--exec CTHDN_Ins N'HDN000002','SP000002',13, 13,0
--exec CTHDN_Del N'HDN000002',N'SP000002'
--exec CTHDN_Up N'HDN000002',N'SP000002',13,3
--delete chiTietHDN
--select * from sanPham
--select * from hoadDonNhap
--select * from chiTietHDN
go
--xóa
create proc CTHDN_Del (	@mahd nvarchar(50), 
						@masp nvarchar(50))
as begin
	delete chiTietHDN where maHDN = @mahd and maSP = @masp
end
go
--sửa
create proc CTHDN_Up (	@mahd nvarchar(50), 
						@masp nvarchar(50),
						@gia float, @sl int) as
begin
	update chiTietHDN set donGia = @gia, soLuong = @sl 
						where maHDN = @mahd and maSP = @masp
end
go
--load
create proc CTHDN_Sel (@ma nvarchar(50)) as 
begin
	select ct.maSP,sp.tenSP,ct.donGia,ct.soLuong, ct.thanhTien from chiTietHDN ct, sanPham sp
	where ct.maSP = sp.maSP and ct.maHDN = @ma
end
--exec CTHDN_Sel N'HDN000003'
go
create proc PV_Sel as
begin
	select nv.maNV, nv.tenNV, (select tenCV from congViec where congViec.maCV = nv.maCV) as 'tencv' from nhanVien nv
	-- where cv.maCV = nv.maCV and nv.maCV is null
end
go
--Thêm_Sửa
create proc PV_Ins_Up (@nv nvarchar(50), @cv nvarchar(50)) as
begin
	Update nhanVien set maCV = @cv where maNV = @nv
end
go
use TTCM
go
create proc phieuBaoHanh_insert (
@maPhieu nvarchar(50),
@maSP nvarchar(50),
@ngaylap date,
@ngayKetThuc date,
@trThai nvarchar(50),
@noiDung nvarchar(100)
)
as begin
insert into phieuBaoHanh values (@maPhieu,@maSP,@ngaylap,@ngayKetThuc,@trThai,@noiDung)
end
go
create proc phieuBaoHanh_update (
@maPhieu nvarchar(50),
@maSP nvarchar(50),
@ngaylap date,
@ngayKetThuc date,
@trThai nvarchar(50),
@noiDung nvarchar(100)
)
as begin
update phieuBaoHanh set maSP=@maSP,ngayKetThuc=@ngayKetThuc,trThai=@trThai,noiDung=@noiDung where maPhieu=@maPhieu
end
go
create proc Guarantee_info
as begin
select * from phieuBaoHanh bh,hoadDonXuat hd,chiTietHDX cthd,sanPham sp,khachHang kh
where bh.maSP=sp.maSP and cthd.maSP=sp.maSP and cthd.maHDX=hd.maHDX and hd.maKH=kh.maKH
end
go
create proc search_sp_by_bill(@maHD nvarchar(50))
as begin
select sp.maSP,sp.tenSP from sanPham sp, hoadDonXuat hd, chiTietHDX ct
where sp.maSP=ct.maSP and ct.maHDX=hd.maHDX and hd.maHDX=@maHD
end
go
exec search_sp_by_bill hdx000001