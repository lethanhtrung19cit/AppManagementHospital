create database QLBV
create table BenhNhan
(
	MaBN int identity primary key,
	HoTen nvarchar(30),
	GioiTinh nvarchar(3),
	NgaySinh date,
	CMND char(14),
	NgheNghiep nvarchar(30),
	DiaChi nvarchar(30),
	MaBaoHiemYT char(20),
)