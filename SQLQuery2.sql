create proc addSP( @maSP nvarchar(50),
@tenSP nvarchar(50),
@gia float,
@anh image,
@soLuong int,
@thongSo nvarchar(50),
@maLoai nvarchar(50))
as begin 
insert into sanPham values (@maSP,@tenSP,@gia,@anh,@soLuong,@thongSo,@maLoai)
end
go

create proc select_SP
as begin
select * from sanPham,nhomSP where sanPham.maLoai=nhomSP.maLoai
end

go
create proc updateSP(
@maSP nvarchar(50),
@tenSP nvarchar(50),
@gia float,
@anh image,
@maLoai nvarchar(50)
)
as begin
update sanPham set tenSP=@tenSP,gia=@gia,anh=@anh,maLoai=@maLoai where maSP=@maSP
end
go
create proc deleteSP(@maSP nvarchar(50))
as begin
delete sanPham where maSP=@maSP
end

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