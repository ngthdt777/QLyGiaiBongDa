Create database QLGBDVDQG

use QLGBDVDQG
go 



create table Dangnhap
( 
 taikhoan varchar(45),
 matkhau varchar(45),
)


create table DOIBONG
(
MaDoi varchar(45) primary key not null,
TenDoi varchar(45),
SanNha varchar(45),
SoCauThu int,
)

go

-- tạo bảng cầu thủ
create table CAUTHU
(
MaCauThu varchar(45) primary key not null,
TenCauThu varchar(45),
NgaySinh Datetime,
MaLoaiCauThu varchar(45),
GhiChu varchar(45),
MaDoi varchar(45),
)


-- Xoa khoa ngoai cau thu


go 


drop table LOAICAUTHU
-- tạo bảng loại cầu thủ


Create table LOAICAUTHU
(
MaLoaiCauThu varchar(45), 
TenLoaiCauThu varchar(45),
)


-- tạo bảng bàn thắng
create table BANTHANG
(
MaBanThang varchar(45) primary key not null ,
MaCauThu varchar(45),
MaLoaiBanThang varchar(45),
ThoiDiem varchar(45),
MaTranDau varchar(45),
)

go



-- tạo bảng trận đấu
create table TRANDAU
(
MaTranDau varchar(45) primary key not null ,
DoiChuNha varchar(45),
DoiKhach varchar(45),
NgayThiDau datetime,
GioThiDau time,
SanThiDau varchar(45),
TySo varchar(10),
MaVongDau varchar(45),

)


insert TRANDAU values ('Vong1LD' , 'BinhDuong' , 'LongAn' , '01-01-2020 ' , '4:00' , 'Tan An' , '30', 'Vong1' )
insert TRANDAU values ('Vong2LD' , 'KhanhHoa' , 'HaNoi' , '02-01-2020 ' , '4:20' , 'Hang Day' , '2-1', 'Vong2' )
insert TRANDAU values ('Vong3LD','Lam','Bao','18-11-2020','4:20','UIT','2-3','Vong4')
insert BANTHANG values ('00A' , '1001' , 'A' , '69p' , 'Vong1LD')
insert BANTHANG values ('00A' , '1001' , 'C' , '72p' , 'Vong1LD')
insert BANTHANG values ('00A' , '1001' , 'B' , '90p' , 'Vong1LD')


go

-- tạo bảng vòng đấu
create table VONGDAU 
(
MaVongDau varchar(45) primary key not null ,
TenVongDau varchar(45),
)
 INSERT into VONGDAU values ('VB','VB')
 INSERT into VONGDAU values ('VMS','Vong16')
 INSERT into VONGDAU values ('TK','TuKet')
 INSERT into VONGDAU values ('BK','BanKet')
 INSERT into VONGDAU values ('CK','ChungKet')
go

-- tạo bản tham số
create table THAMSO 
(
idThamSo int,
TuoiToiThieu int,
TuoiToiDa int,
SoCauThuToiThieu int,
SoCauThuToiDa int,
SoCauThuNuocNgoaiToiDa int,
ThoiDiemGhiBanToiDa int,
DiemSoThang int,
DiemSoHoa int,
DiemSoThua int,
ThuTuUuTienXepHang int,
SoLuongLoaiBanThang int,
)

go


-- tạo liên kết khóa ngoại cho các bảng

alter table BANTHANG add constraint fk_MaCauThu foreign key (MaCauThu) references CAUTHU(MaCauThu)
alter table BANTHANG add constraint fk_MaTranDau foreign key (MaTranDau) references TranDau(MaTranDau)
alter table TRANDAU add constraint fk_MaVongDau foreign key (MaTranDau) references VONGDAU(MaVongDau)
alter table BANTHANG add constraint fk_MaLoaiBanThang foreign key (MaLoaiBanThang) references LOAIBANTHANG(MaLoaiBanThang)

-- tạo các ràng buộc theo các yêu cầu

-- YÊU CẦU 1


-- Quy định về tuổi cầu thủ
alter table THAMSO add  constraint check_Sotuoi Check ( TuoiToiThieu >= 16 and TuoiToiDa <= 40 )

go 

-- Quy định về loại cầu thủ
alter table LOAICAUTHU add constraint check_LoaiCauThu check ( TenLoaiCauThu = ' Trong nước ' or TenLoaiCauThu = ' Nước Ngoài ' ) 

go 

-- Quy định về số cầu thủ trong đội
alter table THAMSO add  constraint check_SoCauThu Check ( SoCauThuToiThieu >= 15 and SoCauThuToiDa <= 22 and SoCauThuNuocNgoaiToiDa <= 3 )

go

-- YÊU CẦU 2
-- YÊU CẦU 3

-- Quy định về bàn thắng và thời điểm ghi bàn
alter table LOAIBANTHANG add constraint check_LoaiBanThang Check ( MaLoaiBanThang = 'A' or MaLoaiBanThang = 'B' or MaLoaiBanThang = 'C')
alter table THAMSO add constraint check_ThoiDiemGhiBan Check ( ThoiDiemGhiBanToiDa >= 0 and ThoiDiemGhiBanToiDa <= 90)

INSERT INTO Dangnhap(taikhoan,matkhau)
 VALUES('ADMIN','ADMIN')

 go

 ----------------INSERT DOIBONG-------------------------------
 insert into DOIBONG(MaDoi, TenDoi, SanNha, SoCauThu) values ( 1, 'Long An', 'Tan An ', 5)
 insert into DOIBONG values ( 2, 'HoChiMinh', 'Thong Nhat', 5)
 insert into DOIBONG values ( 3, 'Binh Duong', 'Go Dau ', 6)
 insert into DOIBONG values (7,'Hoang Anh Gia Lai','Gia Lai', '10')
 insert into DOIBONG values (6,'Ha Noi' ,'My Dinh', '10')
 INSERT into DOIBONG values (8, 'Tp.Ho Chi Minh' , 'SVD Thong Nhat', '10')

 go



 ------------------INSERT CAUTHU-----------------------------
 insert into CAUTHU values ( '1003', 'Tran Thanh Lam', '18-07-2000', 'TrongNuoc' , 'Thi Dau 3 nam' , '1')
 insert into CAUTHU values ( '1004', 'Tran Quoc Thang', '01-01-2000', 'NgoaiNuoc' , 'Thi Dau 6 nam' , '1')
 insert into CAUTHU values ( '1001', 'Luong Duy Bao', '2000-01-01', 'TrongNuoc ' , 'Thi Dau 10 nam' , '2')
 insert into CAUTHU values ( '1002', 'Luong Duy Bao', '2000-01-02', 'NgoaiNuoc' , 'Thi Dau 2 nam' , '3')
 insert into CAUTHU values ( '1005', 'Nguyen Thanh Det', '2000-01-02', 'TrongNuoc' , 'Thi Dau 10000 nam' , '1')

 insert into CAUTHU values ( '7001', 'Tran Buu Ngoc', '26-02-1991', 'TrongNuoc' , 'Thi Dau 5 nam' , '7')
 insert into CAUTHU values ( '7002', 'Nguyen Canh Anh', '11-01-2000', 'TrongNuoc' , 'Thi Dau 2 nam' , '7')
 insert into CAUTHU values ( '7003', 'Nguyen Huu Anh Tai', '27-02-1996', 'TrongNuoc' , 'Thi Dau 2 nam' , '7')
 insert into CAUTHU values ( '7004', 'Au Duong Quan', '30-04-1998', 'TrongNuoc' , 'Thi Dau 3 nam' , '7')
 insert into CAUTHU values ( '7005', 'Luong Xuan Truong', '13-06-1995', 'TrongNuoc' , 'Thi Dau 4 nam' , '7')
 insert into CAUTHU values ( '7006', 'Nguyen Phong Hong Duy', '18-02-1998', 'TrongNuoc' , 'Thi Dau 1 nam' , '7')     --------HOANG ANH GIA LAI-----------
 insert into CAUTHU values ( '7007', 'Tran Minh Vuong', '19-08-1999', 'TrongNuoc' , 'Thi Dau 2 nam' , '7')
 insert into CAUTHU values ( '7008', 'Nguyen Van Toan', '12-04-1996', 'TrongNuoc' , 'Thi Dau 2 nam' , '7')
 insert into CAUTHU values ( '7009', 'Nguyen Huu Canh', '01-01-1998', 'TrongNuoc' , 'Thi Dau 3 nam' , '7')
 insert into CAUTHU values ( '7010', 'Nguyen Thanh Dat', '10-07-2000', 'TrongNuoc' , 'Thi Dau 3 nam' , '7') 

 insert into CAUTHU values ( '6001', 'Bui Tan Truong', '19-02-1986', 'TrongNuoc' , 'Thi Dau 5 nam' , '6')
 insert into CAUTHU values ( '6002', 'Nguyen Van Dung', '1-04-1994', 'TrongNuoc' , 'Thi Dau 2 nam' , '6')
 insert into CAUTHU values ( '6003', 'Dau Van Toan', '2-4-1984', 'TrongNuoc' , 'Thi Dau 2 nam' , '6')
 insert into CAUTHU values ( '6004', 'Manh Ngoc Ha', '23-04-1998', 'TrongNuoc' , 'Thi Dau 3 nam' , '6')
 insert into CAUTHU values ( '6005', 'Nguyen Van Quyet', '13-06-1995', 'TrongNuoc' , 'Thi Dau 4 nam' , '6')           ------------HA NOI-------------------
 insert into CAUTHU values ( '6006', 'Moses Oloya', '8-03-1998', 'NgoaiNuoc' , 'Thi Dau 1 nam' , '6')
 insert into CAUTHU values ( '6007', 'Lebron James', '19-03-1995', 'NgoaiNuoc' , 'Thi Dau 2 nam' , '6')
 insert into CAUTHU values ( '6008', 'Giannis Harden', '12-12-1999', 'NgoaiNuoc' , 'Thi Dau 2 nam' , '6')
 insert into CAUTHU values ( '6009', 'Pham Duc Huy', '23-11-2000', 'TrongNuoc' , 'Thi Dau 3 nam' , '6')
 insert into CAUTHU values ( '6010', 'Nguyen Thanh Cong', '10-08-2000', 'TrongNuoc' , 'Thi Dau 3 nam' , '6') 
 

 insert into CAUTHU values ( '8001', 'Nguyen Thanh Thang', '14-12-1988', 'TrongNuoc' , 'Thi Dau 10 nam' , '8')
 insert into CAUTHU values ( '8002', 'Ngo Tung Quoc', '27-01-1988', 'TrongNuoc' , 'Thi Dau 5 nam' , '8')
 insert into CAUTHU values ( '8003', 'Nguyen Tang Tien', '31-01-1994', 'TrongNuoc' , 'Thi Dau 3 nam' , '8')
 insert into CAUTHU values ( '8004', 'Ngo Viet Phu', '13-06-1999', 'TrongNuoc' , 'Thi Dau 2 nam' , '8')
 insert into CAUTHU values ( '8005', 'Sam Ngoc Duc', '11-12-1995', 'TrongNuoc' , 'Thi Dau 5 nam' , '8')            ------------Tp. Ho Chi Minh------------------
 insert into CAUTHU values ( '8006', 'Tran Thanh Binh', '10-09-1989', 'TrongNuoc' , 'Thi Dau 8 nam' , '8')
 insert into CAUTHU values ( '8007', 'Seo Yonh Duk', '19-09-1994', 'NgoaiNuoc' , 'Thi Dau 6 nam' , '8')
 insert into CAUTHU values ( '8008', 'Ngo Hoang Thinh', '17-07-1993', 'TrongNuoc' , 'Thi Dau 5 nam' , '8')
 insert into CAUTHU values ( '8009', 'Do Van Thuan', '15-005-2000', 'TrongNuoc' , 'Thi Dau 1 nam' , '8')
 insert into CAUTHU values ( '8010', 'Vo Huy Toan', '23-01-1999', 'TrongNuoc' , ' Thi Dau 1 nam ' , '8')





 -------------------------------INSERT TRANDAU-----------------------------------------

insert into TRANDAU values ('VB001' , 'Hoang Anh Gia Lai' , 'Ha Noi' , '01-01-2020 ' , '4:00' , 'Gia Lai' , '30', 'VB' )
insert into TRANDAU values ('VB002' , 'Hoang Anh Gia Lai' , 'Tp.Ho Chi Minh' , '03-01-2020 ' , '5:00' , 'Gia Lai' , '12', 'VB' )
insert into TRANDAU values ('VB003' , 'Ha Noi' , 'Hoang Anh Gia Lai' , '05-01-2020 ' , '7:00' , 'My Dinh' , '11', 'VB' )
insert into TRANDAU values ('VB004' , 'Ha Noi' , 'Tp.Ho Chi Minh' , '06-01-2020 ' , '3:00' , 'My Dinh ' , '21', 'VB' )
insert into TRANDAU values ('VB005' , 'Tp.Ho Chi Minh' , 'Ha Noi' , '10-01-2020 ' , '5:00' , 'SVD Thong Nhat' , '00', 'VB' )
insert into TRANDAU values ('VB006' , 'Tp.Ho Chi Minh' , 'Hoang Anh Gia Lai' , '11-01-2020 ' , '7:00' , 'SVD Thong Nhat' , '2-1', 'VB' )


----------------------------------INSERT BANTHANG-----------------------------------------

insert into BANTHANG values ('0001' , '7004' , 'B' , '4:05' , 'VB001')
insert into BANTHANG values ('0002' , '7004' , 'C' , '4:32' , 'VB001')
insert into BANTHANG values ('0003' , '7001' , 'C' , '4:78' , 'VB001')

insert into BANTHANG values ('0004' , '7004' , 'C' , '5:30 ' , 'VB002')
insert into BANTHANG values ('0005' , '8008' , 'C' , '5:35 ' , 'VB002')
insert into BANTHANG values ('0006' , '8008' , 'C' , '6:10 ' , 'VB002')

insert into BANTHANG values ('0007' , '7004' , 'C' , '7:21' , 'VB003')
insert into BANTHANG values ('0008' , '6005' , 'B' , '8:26' , 'VB003')

insert into BANTHANG values ('0009' , '7004' , 'C' , '3:30' , 'VB004')
insert into BANTHANG values ('0010' , '7003' , 'A' , '3:50' , 'VB004')
insert into BANTHANG values ('0011' , '8001' , 'C' , '4:18' , 'VB004')

insert into BANTHANG values ('0012' , '8001' , 'C' , '7:07' , 'VB006')
insert into BANTHANG values ('0013' , '8008' , 'C' , '7:49' , 'VB006')
insert into BANTHANG values ('0014' , '7004' , 'C' , '8:30' , 'VB006')


----------------------------------------------------------------------------------

--Hiển thị cầu thủ ghi bàn

select Count(DISTINCT MaBanThang) as 'Số Bàn Thắng'  from BANTHANG,CAUTHU
where BANTHANG.MaCauThu = '7004' group by MaBanThang,TenCauThu
 

select TenCauThu ,Count( MaBanThang) as 'Số Bàn Thắng' from BANTHANG, CAUTHU
where  BANTHANG.MaCauThu=CAUTHU.MaCauThu and    BANTHANG.MaCauThu = '7004' 
group by MaBanThang, TenCauThu





-- Hiển thị Vòng đấu 

select MaTranDau, DoiChuNha, DoiKhach, NgayThiDau, GioThiDau, SanThiDau, MaVongDau from TRANDAU

-- Hiển thị kết quả trận đấu

select * from TRANDAU


-- 



  go

 delete from CAUTHU
 go 
 SELECT * FROM CAUTHU WHERE MaDoi='1'


 set dateformat dmy



 go

alter table CAUTHU alter column NgaySinh date


go 

SELECT MaCauThu,TenCauThu,NgaySinh,TenLoaiCauThu,TenDoi FROM CAUTHU,DOIBONG,LOAICAUTHU
  WHERE CAUTHU.MaDoi=DOIBONG.MaDoi And LOAICAUTHU.MaLoaiCauThu=CAUTHU.MaLoaiCauThu

go

SELECT MaCauThu,TenCauThu,DATEDIFF(YY,NgaySinh,GETDATE()) AS [AGE],MaLoaiCauThu,TenDoi,GhiChu FROM CAUTHU,DOIBONG where MaCauThu is not null and TenCauThu is not null and MaLoaiCauThu is not null 
	and DOIBONG.TenDoi=' Ha Noi' and GhiChu is not null
	and DATEDIFF(YY,NgaySinh,GETDATE()) >18 and DATEDIFF(YY,NgaySinh,GETDATE()) <30

go

SELECT TenCauThu, DATEDIFF(YY,NgaySinh,GETDATE()) AS [AGE]
From CAUTHU

select CAST(DATEDIFF(YY,NgaySinh,GETDATE()) AS INT) from CAUTHU

select MaTranDau, DoiChuNha, DoiKhach,NgayThiDau,GioThiDau,SanThiDau,TenVongDau from TRANDAU,VONGDAU
where von='VB' and TRANDAU.MaVongDau = VONGDAU.MaVongDau


INSERT INTO TRANDAU(MaTranDau,DoiChuNha,DoiKhach,NgayThiDau,GioThiDau,SanThiDau,MaVongDau)
   VALUES('VB007','Ha Noi', 'Hoang Anh Gia Lai','01-01-2020',CONVERT(TIME, '4:00'),'My Dinh','VB')

  select  convert(time,'4:20')

  SELECT TenCauThu, TenDoi, MaLoaiCauThu, COUNT(BANTHANG.MaCauThu) as SOBANTHANG FROM DOIBONG, CAUTHU, BANTHANG, TRANDAU
  where DOIBONG.MaDoi = CAUTHU.MaDoi and CAUTHU.MaCauThu = BANTHANG.MaCauThu and BANTHANG.MaTranDau = TRANDAU.MaTranDau and TRANDAU.MaVongDau= 'VB'
  GROUP BY TenCauThu,TenDoi,MaLoaiCauThu


 UPDATE TRANDAU  SET TySo ='11'where MaTranDau='1'

  SELECT MaTranDau from TRANDAU where  NgayThiDau >'01-01-2020' and NgayThiDau <'03-01-2020'

UPDATE TRANDAU SET TySo = '33' where MaTranDau='VB004'