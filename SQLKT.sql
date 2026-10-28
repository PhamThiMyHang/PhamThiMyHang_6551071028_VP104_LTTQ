create database DuLieu_NhanSu;
use DuLieu_NhanSu;
create	table NhanVien 
(
	MaNhanVien nvarchar (10) primary key,
	TenNhanVien nText not null,
	LuongCoBan nvarchar(12) not null
);

insert into NhanVien 
values 
 (N'NV001', N'Nguyễn Văn A',N'8000000'),
 (N'NV002', N'Trần Thị B',N'7500000'),
 (N'NV003', N'Lê Văn C',N'9000000'),
 (N'NV004', N'Phạm Thị D',N'6800000'),
 (N'NV005', N'Hoàng Văn E',N'8200000');