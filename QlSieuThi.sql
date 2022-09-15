go
create database QuanLySieuThi
go
use QuanLySieuThi
go
create table TaiKhoan(
	matk int identity primary key,
	tendangnhap varchar(30) not null,
	tenhienthi nvarchar(100)not null,
	Matkhau nvarchar(1000) not null,
	LoaiTK int not null,
	
)
go
create table LoaiHang
(
	MaLoaiHang int identity	primary key,
	TenLoaiHang nvarchar(50) not null
)
go
create table NhaCungCap(
	MaNCC int identity primary key,
	TenNCC nvarchar(100) not null
)
go
alter table NhaCungCap
add DiaChi nvarchar(50),
	Sdt varchar(20);
go
create table HangHoa
(
	MaHang int identity	primary key,
	TenHang nvarchar(50)not null,
	Gia float not null,
	GiaKM float ,
	Soluongconkho float not null default 0,
	LoaiHang int ,
	NhaCC int ,
	foreign key (LoaiHang) references LoaiHang(MaLoaiHang),
	foreign key (NhaCC) references NhaCungCap(MaNCC)
)
go
Create table NhanVien
(
	MaNV int identity primary key,
	TenNV nvarchar(50) not null,
	SDT varchar(20) not null,
	DiaChi nvarchar(70),
	Luong float not null,
)
go
alter table TaiKhoan add MaNV int
go
alter table TaiKhoan add constraint fk_MaNV
	foreign key (MaNV) references NhanVien(MaNV)

go
Create table HoaDon
(
	MaHoaDon int identity primary key,
	MaNV int ,
	Ngay date not null default GetDate(),
	tongbill float,
	foreign key (MaNV) references NhanVien(MaNV)
	)
go
alter table HoaDon add constraint Tongbill default (0) for tongbill
go
Create table BanHang
(
	MaHoaDon int,
	MaHang int,
	soluong float not null,
	foreign key (MaHoaDon) references HoaDon(MaHoaDon),
	foreign key (MaHang) references HangHoa(MaHang)
)
go 
create table KhuyenMai(
	MaKM int identity primary key,
	MaHang int,
	MucGiam int not null,
	NgayHetHan date not null,
	foreign key (MaHang) references HangHoa(MaHang)
)
go
insert into LoaiHang values (N'Đồ gia dụng')
insert into LoaiHang values (N'Thực phẩm')
insert into LoaiHang values (N'Đồ ăn nhanh')
insert into LoaiHang values (N'Rau củ quả')
insert into LoaiHang values (N'Tẩy rửa')
insert into LoaiHang values (N'Thời trang')
insert into LoaiHang values (N'Đồ dùng cá nhân')
insert into LoaiHang values (N'Nước uống')
go
insert into NhanVien values(N'Nguyễn Văn An','0352025979',N'01 Võ Văn Ngân,Tp Thủ Đức',10000000);
insert into NhanVien values(N'Nguyễn Thị Thắm','0337892651',N'01 Nguyễn Văn Bá,Tp Thủ Đức',7000000);
insert into NhanVien values(N'Trần Thị Thu','0986278926',N'135 Đỗ Xuân Hợp,Tp Thủ Đức',6500000);
insert into NhanVien values(N'Bùi Tiến Đạt','0367829762',N'29/2 đường 05,Tp Thủ Đức',5500000);
go 
insert into TaiKhoan values('Admin',N'Nguyễn Văn An','12345',0,1)
insert into TaiKhoan values('Staff1',N'Nhân viên','1234',1,2)
insert into TaiKhoan values('Staff2',N'Nhân viên','1234',1,3)
insert into TaiKhoan values('Staff3',N'Nhân viên','1234',1,4)
go
insert into NhaCungCap values(N'Công ty Đồ Ăn Liền',N'189 Phạm Văn Đồng,Gò Vấp,TP.HCM','0989866554')
insert into NhaCungCap values(N'Công ty Thực Phẩm',N'232 Kha Vạn Cân,TP.Thủ Đức','0852728362')
insert into NhaCungCap values(N'Công ty Rau củ quả',N'22 Đỗ Xuân Hợp,Tp Thủ Đức','0357829167')
insert into NhaCungCap values(N'Công ty Điện dụng',N'199 Phạm Văn Đồng,Gò Vấp,TP.HCM','015243628')
insert into NhaCungCap values(N'Công ty Giặt tẩy',N'189 Phan Văn Trị,Gò Vấp,TP.HCM','0977947944')
insert into NhaCungCap values(N'Công ty Đồ Cá Nhân',N'123 Cộng Hòa,Tân Bình,TP.HCM','0966283622')
insert into NhaCungCap values(N'Công ty Thời Trang',N'22 Hoàng Diệu 2,Tp.Thủ Đức','083678282')
insert into NhaCungCap values(N'Công ty Nước giải khát',N'29/2 đường số 5,Tăng Nhơn Phú B,Tp.Thủ Đức','0638763822')
go
insert into HangHoa values(N'Máy hút bụi',5000000,null,default,1,4)
insert into HangHoa values(N'Máy giặt',4000000,null,default,1,4)
insert into HangHoa values(N'Tủ lạnh',6000000,null,default,1,4)
insert into HangHoa values(N'Đùi gà',40000,null,default,2,2)
insert into HangHoa values(N'Thịt heo',50000,null,default,2,2)
insert into HangHoa values(N'Cá',45000,null,default,2,2)
insert into HangHoa values(N'Mì tôm',4000,null,default,3,1)
insert into HangHoa values(N'Kem',7000,null,default,3,1)
insert into HangHoa values(N'Cháo',5000,null,default,3,1)
insert into HangHoa values(N'Táo',40000,null,default,4,3)
insert into HangHoa values(N'Dưa hấu',15000,null,default,4,3)
insert into HangHoa values(N'Cam',20000,null,default,4,3)
insert into HangHoa values(N'Rau',10000,null,default,4,3)
insert into HangHoa values(N'Cà rốt',15000,null,default,4,3)
insert into HangHoa values(N'Bột giặt',50000,null,default,5,5)
insert into HangHoa values(N'Nước xả',40000,null,default,5,5)
insert into HangHoa values(N'Nước rửa chén',22000,null,default,5,5)
insert into HangHoa values(N'Áo thun',100000,null,default,6,7)
insert into HangHoa values(N'Quần Jean',300000,null,default,6,7)
insert into HangHoa values(N'Túi xách',200000,null,default,6,7)
insert into HangHoa values(N'Sữa rửa mặt',70000,null,default,7,6)
insert into HangHoa values(N'Bàn chải đánh răng',30000,null,default,7,6)
insert into HangHoa values(N'Dao cạo râu',32000,null,default,7,6)
insert into HangHoa values(N'Pepsi',10000,null,default,8,8)
insert into HangHoa values(N'Nước khoáng',5000,null,default,8,8)
insert into HangHoa values(N'Sting',11000,null,default,8,8)

go
insert into KhuyenMai values(2,20,'2022-06-05')
insert into KhuyenMai values(8,50,'2022-06-04')
insert into KhuyenMai values(18,50,'2022-06-22')
go
update HangHoa set GiaKM=Gia

go
create table The
(
	SDT varchar(20) primary key,
	TenKH nvarchar(50) not null,
	Tongtien float default 0,
	Hang nvarchar(20) default N'Không'
)
go 
create table NhapHang
(
	manhaphang int identity primary key,
	manv int, 
	mahang int,
	gianhap float,
	soluongnhap float,
	ngaynhap date,
	ngayhethan date,
	foreign key (mahang) references HangHoa(MaHang)
)
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

go
create proc LayThongTinNhapHang
AS 
begin 
select manv,HangHoa.MaHang,TenHang,gianhap,soluongnhap,ngaynhap,gianhap*soluongnhap as ThanhTien from HangHoa,NhapHang 
where HangHoa.MaHang=NhapHang.mahang and NhapHang.manhaphang= (select max(manhaphang) from NhapHang)
end;
Go
create proc ThongKe
as
begin
select BanHang.MaHang,HangHoa.TenHang,sum(BanHang.soluong) as soluongdaban from BanHang,HangHoa,HoaDon where BanHang.MaHang=HangHoa.MaHang and BanHang.MaHoaDon=HoaDon.MaHoaDon and Month(HoaDon.Ngay)=MONTH(Getdate()) and Year(HoaDon.Ngay)=YEAR(Getdate()) group by BanHang.MaHang,HangHoa.TenHang 
end;
go
create proc ThongKe2
@thang int,@nam int
as
begin
select BanHang.MaHang,HangHoa.TenHang,sum(BanHang.soluong) as soluongdaban from BanHang,HangHoa,HoaDon where BanHang.MaHang=HangHoa.MaHang and BanHang.MaHoaDon=HoaDon.MaHoaDon and Month(HoaDon.Ngay)=@thang and Year(HoaDon.Ngay)=@nam group by BanHang.MaHang,HangHoa.TenHang 
end;

