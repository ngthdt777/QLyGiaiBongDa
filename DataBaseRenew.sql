Create database QLGBDVDQG1

use QLGBDVDQG1


create table DANGNHAP
( 
 TaiKhoan varchar(45),
 MatKhau varchar(45),
)
go
INSERT INTO DANGNHAP(TaiKhoan,MatKhau)
 VALUES('ADMIN','ADMIN')
go
create table CAUTHU
(
MaCauThu varchar(45) primary key not null,
TenCauThu varchar(45),
NgaySinh Datetime,
LoaiCauThu varchar(45),
ThoiGianThiDau varchar(45),
TinhTrang varchar(45),
MaDoi char(4),
)
go
 set dateformat dmy
go
 insert into CAUTHU values ( 'HA01', 'Tran Buu Ngoc', '26-02-1991', 'Trong Nuoc' , 'Thi Dau 5 nam','Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA03', 'Nguyen Canh Anh', '11-01-2000', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA04', 'Nguyen Huu Anh Tai', '27-02-1996', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA05', 'Au Duong Quan', '30-04-1998', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA06', 'Luong Xuan Truong', '13-06-1995', 'Trong Nuoc' , 'Thi Dau 4 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA07', 'Nguyen Phong Hong Duy', '18-02-1998', 'Trong Nuoc' , 'Thi Dau 1 nam' ,'Khoe manh' , 'HAGL')     --------HOANG ANH GIA LAI-----------
 insert into CAUTHU values ( 'HA08', 'Tran Minh Vuong', '19-08-1999', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA09', 'Nguyen Van Toan', '12-04-1996', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA10', 'Nguyen Huu Canh', '01-01-1998', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA11', 'Nguyen Thanh Dat', '10-07-2000', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh' , 'HAGL') 

 insert into CAUTHU values ( 'HN01', 'Bui Tan Truong', '19-02-1986', 'TrongNuoc' , 'Thi Dau 5 nam','Khoe manh' ,  'HNFC')
 insert into CAUTHU values ( 'HN02', 'Nguyen Van Dung', '1-04-1994', 'TrongNuoc' , 'Thi Dau 2 nam','Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN03', 'Dau Van Toan', '2-4-1984', 'TrongNuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HA05', 'Manh Ngoc Ha', '23-04-1998', 'TrongNuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN04', 'Nguyen Van Quyet', '13-06-1995', 'TrongNuoc' , 'Thi Dau 4 nam' ,'Khoe manh', 'HNFC')           ------------HA NOI-------------------
 insert into CAUTHU values ( 'HN06', 'Moses Oloya', '8-03-1998', 'NgoaiNuoc' , 'Thi Dau 1 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN07', 'Lebron James', '19-03-1995', 'NgoaiNuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN08', 'Giannis Harden', '12-12-1999', 'NgoaiNuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN09', 'Pham Duc Huy', '23-11-2000', 'TrongNuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN10', 'Nguyen Thanh Cong', '10-08-2000', 'TrongNuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'HNFC') 



 insert into CAUTHU values ( 'SG01', 'Nguyen Thanh Thang', '14-12-1988', 'TrongNuoc' , 'Thi Dau 10 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG02', 'Ngo Tung Quoc', '27-01-1988', 'TrongNuoc' , 'Thi Dau 5 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG03', 'Nguyen Tang Tien', '31-01-1994', 'TrongNuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG04', 'Ngo Viet Phu', '13-06-1999', 'TrongNuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG05', 'Sam Ngoc Duc', '11-12-1995', 'TrongNuoc' , 'Thi Dau 5 nam' ,'Khoe manh', 'HCMC')            ------------Tp. Ho Chi Minh------------------
 insert into CAUTHU values ( 'SG06', 'Tran Thanh Binh', '10-09-1989', 'TrongNuoc' , 'Thi Dau 8 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG07', 'Seo Yonh Duk', '19-09-1994', 'NgoaiNuoc' , 'Thi Dau 6 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG08', 'Ngo Hoang Thinh', '17-07-1993', 'TrongNuoc' , 'Thi Dau 5 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG09', 'Do Van Thuan', '15-005-2000', 'TrongNuoc' , 'Thi Dau 1 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG10', 'Vo Huy Toan', '23-01-1999', 'TrongNuoc' , ' Thi Dau 1 nam ' ,'Khoe manh', 'HCMC')
go
create table DOIBONG
(
MaDoi  char(4) primary key not null,
TenDoi varchar(45),
SanNha varchar(45),
SoCauThu int ,
DiemSo int ,
BanThang int,
BanThua int,

)

select * from DOIBONG
delete from DOIBONG
drop table DOIBONG
go
 insert into DOIBONG values ('HAGL','Hoang Anh Gia Lai','Gia Lai','5','0','0','0')
 insert into DOIBONG values ('HNFC','Ha Noi' ,'My Dinh','5','0','0','0')
 insert into DOIBONG values ('HCMC','Tp.Ho Chi Minh' , 'SVD Thong Nhat', '5','0','0','0')

go
create table BANTHANG
(
MaBanThang varchar(45) primary key not null ,
MaCauThu varchar(45),
LoaiBanThang varchar(45),
ThoiDiem varchar(45),
MaTranDau varchar(45),
)

select *from BANTHANG

select LoaiBanThang from BANTHANG
group by LoaiBanThang



update BANTHANG set ThoiDiem ='6:36' where MaBanThang= '0006'

go
insert into BANTHANG values ('0001' , 'HA05' , 'TrucTiep' , '4:05' , 'VB001')
insert into BANTHANG values ('0002' , 'HA05' , 'Penalty' , '4:32' , 'VB001')
insert into BANTHANG values ('0003' , 'HA05' , 'TrucTiep' , '4:78' , 'VB001')

insert into BANTHANG values ('0004' , 'SG10' , 'TrucTiep' , '5:30 ' , 'VB002')
insert into BANTHANG values ('0005' , 'SG10' , 'DaPhat' , '5:35 ' , 'VB002')
insert into BANTHANG values ('0006' , 'SG10' , 'DaPhat' , '6:10 ' , 'VB002')

insert into BANTHANG values ('0007' , 'SG10' , 'TrucTiep' , '7:21' , 'VB003')
insert into BANTHANG values ('0008' , 'SG10' , 'DaPhat' , '8:26' , 'VB003')

insert into BANTHANG values ('0009' , 'HA11' , 'DaPhat' , '3:30' , 'VB004')
insert into BANTHANG values ('0010' , 'HA11' , 'DaPhat' , '3:50' , 'VB004')
insert into BANTHANG values ('0011' , 'HA11' , 'TrucTiep' , '4:18' , 'VB004')

insert into BANTHANG values ('0012' , 'SG03' , 'TrucTiep' , '7:07' , 'VB006')
insert into BANTHANG values ('0013' , 'SG03' , 'Penalty' , '7:49' , 'VB006')
insert into BANTHANG values ('0014' , 'SG03' , 'DaPhat' , '8:30' , 'VB006')
go

create table TRANDAU
(
MaTranDau varchar(45) primary key not null ,
DoiChuNha char(4),
DoiKhach  char(4),
NgayThiDau datetime,
GioThiDau time,
SanThiDau varchar(45),
TySo varchar(10),
MaVongDau varchar(45),
BANTHANGDN int,
BANTHANGKH int,
)

insert into TRANDAU values ('VB001' , 'HAGL' , 'HCMC' , '03-01-2020 ' , '5:00' , 'Gia Lai' , '31', 'VB','3','1' )
insert into TRANDAU values ('VB002' , 'HAGL' , 'HCMC' , '03-01-2020 ' , '5:00' , 'Gia Lai' , '14', 'VB','1','4' )
insert into TRANDAU values ('VB003' , 'HAGL' , 'HCMC' , '03-01-2020 ' , '5:00' , 'Gia Lai' , '11', 'VB','1','1' )
insert into TRANDAU values ('VB004' , 'HAGL' , 'HCMC' , '03-01-2020 ' , '5:00' , 'Gia Lai' , '33', 'VB','3','3' )

delete from TRANDAU
select* from TRANDAU

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

create Table LOAIBANTHANG
(
LOAIBANTHANG varchar(45)
)

INSERT into LOAIBANTHANG values ('TrucTiep')
INSERT into LOAIBANTHANG values ('Penalty')
INSERT into LOAIBANTHANG values ('DaPhat')

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

alter Trigger CapNhatDiem on TRANDAU for INSERT, UPDATE
as 
BEGIN
    declare @madk char(4),
			@madn char(4),
			@BTDN int,
			@BTDK int
    select @madk = DoiKhach, @madn = DoiChuNha, @BTDN = BANTHANGDN, @BTDK = BANTHANGKH from inserted 
    update DOIBONG  
	SET BanThang= @BTDN+ BanThang
	where MaDoi=@madn 
	update DOIBONG  
	SET BanThua= @BTDK + BanThua
	where MaDoi=@madn 
	

--bbb
	update DOIBONG  
	SET BanThang=@BTDK +BanThang
	where MaDoi=@madk
	 update DOIBONG  
	SET BanThua =@BTDN +BanThua
	where MaDoi=@madk
	--//doinha win
	if (SELECT BANTHANGDN from  inserted)
	 > (SELECT BANTHANGKH from inserted)
	update DOIBONG
	SET DiemSo=DiemSo+3
	WHERE MaDoi=@madn 

	-- doikhach win
	else if (SELECT BANTHANGDN from  inserted)
	 < (SELECT BANTHANGKH from inserted)
	update DOIBONG
	SET DiemSo=DiemSo+3
	WHERE MaDoi=@madk 
	-- hoa
    else 
	update DOIBONG
	SET DiemSo=DiemSo+1
	WHERE (MaDoi=@madn OR MaDoi=@madk)
	PRINT N'1'

END




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

SELECT MaCauThu,TenCauThu,DATEDIFF(YY,NgaySinh,GETDATE()) AS [AGE],LoaiCauThu,TenDoi,ThoiGianThiDau,TinhTrang FROM CAUTHU,DOIBONG where MaCauThu is not null and TenCauThu is not null and LoaiCauThu is not null 
	and DOIBONG.TenDoi is not null and ThoiGianThiDau='Thi dau 5 nam' and TinhTrang='Khoe manh'
	and DATEDIFF(YY,NgaySinh,GETDATE()) >18 and DATEDIFF(YY,NgaySinh,GETDATE()) <30
GROUP BY MaCauThu,TenCauThu,NgaySinh,LoaiCauThu,TenDoi,ThoiGianThiDau,TinhTrang




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

UPDATE TRANDAU SET TySo = '33' where MaTranDau='VB001'


insert into BANGXEPHANG(MaDoi) values (7)
insert into BANGXEPHANG(MaDoi) values (6)
insert into BANGXEPHANG(MaDoi) values (8)






