Create database db_QuanLyBanHangThietBiMayTinh
use db_QuanLyBanHangThietBiMayTinh
Go

create table tblNhomHang(
	sMaNhomHang nvarchar(10) primary key not null,
	sTenNhomHang nvarchar(50),
	sMoTa nvarchar(100)

)

Create table tblHangHoa(
	sMaHang nvarchar(10) primary key not null,
	sMaNhomHang nvarchar(10),
	sTenHang nvarchar(50),
	sMauSac nvarchar(50),
	sDacTinhKyThuat nvarchar(50)
)

ALTER TABLE tblHangHoa ADD CONSTRAINT FK_HANGHOA_NHOMHANG FOREIGN KEY (sMaNhomHang) REFERENCES tblNhomHang(sMaNhomHang)

Create table tblHoaDonNhapHang(
	sMaHoaDonNhap nvarchar(10) primary key not null,
	sMaNhanVien nvarchar(10),
	sMaNhaCungCap nvarchar(10),
	dNgayNhap date
)

ALTER TABLE tblHoaDonNhapHang ADD CONSTRAINT FK_HOADONNHAPHANG_NHANVIEN FOREIGN KEY (sMaNhanVien) REFERENCES tblNhanVien(sMaNhanVien),
CONSTRAINT FK_HOADONNHAPHANG_NHACUNGCAP FOREIGN KEY (sMaNhaCungCap) REFERENCES tblNhaCungCap(sMaNCC)


Create table tblHangNhap(
	sMaHang nvarchar(10) primary key not null,
	sMaHoaDonNhap nvarchar(10),
	sTenHang nvarchar(50),
	sMauSac nvarchar(50),
	sDacTinhKyThuat nvarchar(50)
)

ALTER TABLE tblHangNhap ADD CONSTRAINT FK_HANGNHAP_HOADONNHAPHANG FOREIGN KEY (sMaHoaDonNhap) REFERENCES tblHoaDonNhapHang(sMaHoaDonNhap)


Create table tblHangBan(
	sMaHangBan nvarchar(10) primary key not null,
	sMaHoaDonBan nvarchar(10),
	iSoLuong int,
	fGiaBan float,
	iThoiGianBanHanh int
)
ALTER TABLE tblHangBan ADD CONSTRAINT FK_HANGBAN_HOADONBANHANG FOREIGN KEY (sMaHoaDonBan) REFERENCES tblHoaDonBanHang(sMaHoaDonBan)



create table tblHoaDonBanHang(
	sMaHoaDonBan nvarchar(10) primary key not null,
	sMaNhanVien nvarchar(10),
	sTenKhachHang nvarchar(50),
	dThoiGianBan datetime,
	sTinhTrangThanhToan nvarchar(50)
)

ALTER TABLE tblHoaDonBanHang ADD CONSTRAINT FK_HOADONBANHANG_NHANVIEN FOREIGN KEY (sMaNhanVien) REFERENCES tblNhanVien(sMaNhanVien)


create table tblHangNhap_HangHoa(
	sMaHangNhap nvarchar(10) not null,
	sMaHangHoa nvarchar(10) not null,
)

ALTER TABLE tblHangNhap_HangHoa ADD CONSTRAINT PK_HNHH PRIMARY KEY(sMaHangNhap, sMaHangHoa),
CONSTRAINT FK_HNHH_HANGNHAP FOREIGN KEY (sMaHangNhap) REFERENCES tblHangNhap(sMaHang),
CONSTRAINT FK_HNHH_HANGHOA FOREIGN KEY (sMaHangHoa) REFERENCES tblHangHoa(sMaHang)

create table tblHangBan_HangHoa(
	sMaHangBan nvarchar(10) not null,
	sMaHangHoa nvarchar(10) not null,
)

ALTER TABLE tblHangBan_HangHoa ADD CONSTRAINT PK_HBHH PRIMARY KEY(sMaHangBan, sMaHangHoa),
CONSTRAINT FK_HBHH_HANGBAN FOREIGN KEY (sMaHangBan) REFERENCES tblHangBan(sMaHangBan),
CONSTRAINT FK_HBHH_HANGHOA FOREIGN KEY (sMaHangHoa) REFERENCES tblHangHoa(sMaHang)


create table tblNhanVien(
	sMaNhanVien nvarchar(10) primary key not null,
	sTenNhanVien nvarchar(50),
	bGioiTinh bit,
	dNgaySinh date,
	sDiaChi nvarchar(50),
	sSoDienThoai nvarchar(50)
)

create table tblNhaCungCap(
	sMaNCC nvarchar(10) primary key not null,
	sTenNCC nvarchar(50),
	sDiaChi nvarchar(50),
	sSoDienThoai nvarchar(50)
)

create table tblUser(
	sUserName varchar(50) primary key not null,
	sPassword varchar(50) not null
)

-----------  Tạo thủ tục -------------

	Create proc sp_GetUser
as
begin
	select * from tblUser
	end
-------------
Create proc sp_AddNhanVien
@sMaNV nvarchar(10),
@sTenNV nvarchar(50),
@bGioiTinh bit,
@dNgaySinh date,
@sDiaChi nvarchar(50),
@sSoDienThoai nvarchar(50)
as
begin 
	insert into tblNhanVien 
	values (@sMaNV, @sTenNV, @bGioiTinh, @dNgaySinh, @sDiaChi, @sSoDienThoai)
end



Create proc sp_GettAllNhanVien
as
begin
	select * from tblNhanVien
	end



Create proc sp_DeleteNhanVien
@manv nvarchar(10)
as
begin
	DELETE FROM tblNhanVien
	WHERE sMaNhanVien = @manv
end


Create proc sp_EditNhanVien
@sMaNV nvarchar(10),
@sTenNV nvarchar(50),
@bGioiTinh bit,
@dNgaySinh date,
@sDiaChi nvarchar(50),
@sSoDienThoai nvarchar(50)
as
begin
	UPDATE tblNhanVien
SET sTenNhanVien = @sTenNV , bGioiTinh= @bGioiTinh, dNgaySinh= @dNgaySinh, @sDiaChi= @sDiaChi, sSoDienThoai= @sSoDienThoai
WHERE sMaNhanVien = @sMaNV
end

--------
create proc sp_AddHangHoa

@mahang nvarchar(10),
@manhomhang nvarchar(10),
@tenhang nvarchar(50),
@mausac nvarchar(50),
@dactinh nvarchar(50)
as
begin
	insert into tblHangHoa
	values (@mahang, @manhomhang,  @tenhang, @mausac, @dactinh)
end


CREATE proc sp_GetAllHangHoa
as 
begin
select sMaHang, sTenHang, sTenNhomHang, sMauSac, sDacTinhKyThuat from tblHangHoa inner join tblNhomHang on tblHangHoa.sMaNhomHang= tblNhomHang.sMaNhomHang

end


Create proc sp_DeleteHangHoa
@mahang nvarchar(10)
as
begin
	DELETE FROM tblHangHoa
	WHERE sMaHang = @mahang
end


CREATE proc sp_EditHangHoa
@mahang nvarchar(10),
@manhomhang nvarchar(10),
@tenhang nvarchar(50),
@mausac nvarchar(50),
@dactinh nvarchar(50)
as
begin


	UPDATE tblHangHoa
SET sMaNhomHang = @manhomhang , sTenHang= @tenhang, sMauSac= @mausac, sDacTinhKyThuat= @dactinh
WHERE sMaHang = @mahang
end

---------------
create proc sp_AddNhomHang
@ma nvarchar(10),
@ten nvarchar(50),
@mota nvarchar(100)
as
begin
	insert into tblNhomHang
	values( @ma, @ten, @mota)
end



create proc sp_GetNhomHang
as
begin
select *from tblNhomHang
end



create proc sp_DeleteNhomHang
@ma nvarchar(10)
as
begin
	delete from tblNhomHang where sMaNhomHang=@ma
	end



CREATE proc sp_EditNhomHang
@ma nvarchar(10),
@ten nvarchar(50),
@mota nvarchar(100)
as
begin
	update tblNhomHang
	set  sTenNhomHang=@ten, sMoTa=@mota
	where sMaNhomHang= @ma
end

-----------------
Create proc sp_AddHangBan
@mahd nvarchar(10),
@mahb nvarchar(10),
@soluong int,
@giaban float,
@thoigianbaohanh int
as
begin
	insert into tblHangBan
	values (@mahb, @mahd,  @soluong, @giaban, @thoigianbaohanh)
end

create proc sp_AddHangNhap

@mahang nvarchar(10),
@mahoadon nvarchar(10),
@ten nvarchar(50),
@mausac nvarchar(50),
@dactinh nvarchar(50)
as
begin
	insert into tblHangNhap
	values (@mahang, @mahoadon,  @ten, @mausac, @dactinh)
end

create proc sp_AddHoaDonBanHang

@mahoadon nvarchar(10),
@manv nvarchar(10),
@tenkh nvarchar(50),
@thoigianban date,
@tinhtrang nvarchar(50)
as
begin
	insert into tblHoaDonBanHang
	values (@mahoadon, @manv,  @tenkh, @thoigianban, @tinhtrang)
end

create proc sp_AddHoaDonNhap

@mahoadon nvarchar(10),
@manv nvarchar(10),
@mancc nvarchar(10),
@ngaynhap date
as
begin
	insert into tblHoaDonNhapHang
	values (@mahoadon, @manv,  @mancc, @ngaynhap)
end

create proc sp_AddNCC

@ma nvarchar(10),
@ten nvarchar(50),
@diachi nvarchar(50),
@sodienthoai nvarchar(50)
as
begin
	insert into tblNhaCungCap
	values (@ma, @ten,  @diachi, @sodienthoai)
end

Create proc sp_DeleteHangBan
@mahb nvarchar(10)
as
begin
	DELETE FROM tblHangBan
	WHERE sMaHangBan=@mahb 
end

Create proc sp_DeleteHangNhap
@mahang nvarchar(10)
as
begin
	DELETE FROM tblHangNhap
	WHERE sMaHang=@mahang 
end

Create proc sp_DeleteHoaDonBan
@mahoadon nvarchar(10)
as
begin
	DELETE FROM tblHoaDonBanHang
	WHERE sMaHoaDonBan=@mahoadon
end

Create proc sp_DeleteHoaDonNhap
@mahoadon nvarchar(10)
as
begin
	DELETE FROM tblHoaDonNhapHang
	WHERE sMaHoaDonNhap=@mahoadon
end

Create proc sp_DeleteNCC
@ma nvarchar(10)
as
begin
	DELETE FROM tblNhaCungCap
	WHERE sMaNCC=@ma 
end

create proc sp_EditHangBan
@mahd nvarchar(10),
@mahb nvarchar(10),
@soluong int,
@giaban float,
@thoigianbaohanh int
as
begin
	UPDATE tblHangBan
SET sMaHoaDonBan=@mahd, iSoLuong=@soluong, fGiaBan=@giaban --iThoiGianBanHanh=thoigianbaohanh
WHERE sMaHangBan= @mahb 
end

create proc sp_EditHangNhap
@mahang nvarchar(10),
@mahoadon nvarchar(10),
@ten nvarchar(50),
@mausac nvarchar(50),
@dactinh nvarchar(50)
as
begin
	UPDATE tblHangNhap
SET sDacTinhKyThuat=@dactinh, sMaHoaDonNhap=@mahoadon, sTenHang=@ten, sMauSac=@mausac
WHERE sMaHang=@mahang 
end

create proc sp_EditHoaDonBanHang
@mahoadon nvarchar(10),
@manv nvarchar(10),
@tenkh nvarchar(50),
@thoigianban date,
@tinhtrang nvarchar(50)
as
begin
	UPDATE tblHoaDonBanHang
SET sMaNhanVien=@manv, sTenKhachHang=@tenkh, dThoiGianBan=@thoigianban, sTinhTrangThanhToan=@tinhtrang
WHERE sMaHoaDonBan=@mahoadon
end

create proc sp_EditHoaDonNhap
@mahoadon nvarchar(10),
@manv nvarchar(10),
@mancc nvarchar(10),
@ngaynhap date
as
begin
	UPDATE tblHoaDonNhapHang
SET sMaNhanVien=@manv, sMaNhaCungCap=@mancc, dNgayNhap=@ngaynhap
WHERE sMaHoaDonNhap=@mahoadon
end

create proc sp_EditNCC
@ma nvarchar(10),
@ten nvarchar(50),
@diachi nvarchar(50),
@sodienthoai nvarchar(50)
as
begin
	UPDATE tblNhaCungCap
SET sTenNCC=@ten, sDiaChi=@diachi, sSoDienThoai=@sodienthoai
WHERE sMaNCC=@ma 
end

create proc sp_GetAllHangBan
as 
begin
select * from tblHangBan
end

create proc sp_GetAllHangNhap
as 
begin
select *  from tblHangNhap
end

create proc sp_GetAllHoaDonBanHang
as 
begin
select sMaHoaDonBan, sTenNhanVien, sTenKhachHang, dThoiGianBan, sTinhTrangThanhToan
from tblHoaDonBanHang inner join tblNhanVien 
on tblHoaDonBanHang.sMaNhanVien=tblNhanVien.sMaNhanVien 
end

create proc [dbo].[sp_GetAllHoaDonNhapHang]
as 
begin
--select sMaHang, sTenHang, sTenNhomHang, sMauSac, sDacTinhKyThuat from tblHangHoa inner join tblNhomHang on tblHangHoa.sMaNhomHang= tblNhomHang.sMaNhomHang
select tblHoaDonNhapHang.sMaHoaDonNhap,  tblNhanVien.sTenNhanVien, tblNhaCungCap.sTenNCC, tblHoaDonNhapHang.dNgayNhap
from tblHoaDonNhapHang inner join tblNhanVien on tblHoaDonNhapHang.sMaNhanVien= tblNhanVien.sMaNhanVien
						inner join tblNhaCungCap on tblHoaDonNhapHang.sMaNhaCungCap= tblNhaCungCap.sMaNCC

end

create proc sp_GetAllNCC
as 
begin
select * from tblNhaCungCap
end