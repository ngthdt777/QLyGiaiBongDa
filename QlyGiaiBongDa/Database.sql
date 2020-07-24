Create database QLYGIAIBD


use QLYGIAIBD
set dateformat dmy


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



go
insert into DOIBONG values ('HAGL','Hoang Anh Gia Lai','Gia Lai','0','0','0','0')
insert into DOIBONG values ('HNFC','Ha Noi' ,'My Dinh','0','0','0','0')
insert into DOIBONG values ('HCMC','Tp.Ho Chi Minh' , 'SVD Thong Nhat', '0','0','0','0')

INSERT INTO DOIBONG values ('DTFC','Dong Thap','SVD Dong Thap','0','0','0','0')
INSERT INTO DOIBONG values ('AGFC','An Giang','SVD An Giang','0','0','0','0')
INSERT INTO DOIBONG values ('BDFC','Binh Dinh','SVD Quy Nhon','0','0','0','0')

go
create table BANTHANG
(
MaBanThang varchar(45) primary key not null ,
MaCauThu varchar(45),
LoaiBanThang varchar(45),
ThoiDiem varchar(45),
MaTranDau varchar(45),
)

-- Loai Loai Ban thang len combo box

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


go 

create Trigger CapNhatDiem on TRANDAU for INSERT, UPDATE
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

go



CREATE TRIGGER XOASCT ON CAUTHU FOR DELETE
AS
BEGIN
	DECLARE @madoi char(4);
	SELECT  @madoi=MaDoi FROM deleted
	UPDATE DOIBONG
	SET SOCAUTHU=SoCauThu-1
	WHERE MaDoi=@MADOI;
END

go


CREATE TRIGGER THEMSCT ON CAUTHU FOR insert
AS
BEGIN
	DECLARE @madoi char(4);
	SELECT  @madoi=MaDoi FROM inserted
	UPDATE DOIBONG
	SET SOCAUTHU=SoCauThu+1
	WHERE MaDoi=@MADOI;
END

go
	


  --------HOANG ANH GIA LAI----------- 

 insert into CAUTHU values ( 'HA01', 'Tran Buu Ngoc', '26-02-1991', 'Trong Nuoc' , 'Thi Dau 5 nam','Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA02', 'Nguyen Canh Anh', '11-01-2000', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA03', 'Nguyen Huu Anh Tai', '27-02-1996', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA04', 'Au Duong Quan', '30-04-1998', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA05', 'Luong Xuan Truong', '13-06-1995', 'Trong Nuoc' , 'Thi Dau 4 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA06', 'Nguyen Phong Hong Duy', '18-02-1998', 'Trong Nuoc' , 'Thi Dau 1 nam' ,'Khoe manh' , 'HAGL')    
 insert into CAUTHU values ( 'HA07', 'Tran Minh Vuong', '19-08-1999', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA08', 'Nguyen Van Toan', '12-04-1996', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA09', 'Nguyen Huu Canh', '01-01-1998', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh' , 'HAGL')
 insert into CAUTHU values ( 'HA10', 'Nguyen Thanh Dat', '10-07-2000', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh' , 'HAGL') 


 ------------HA NOI-------------------

 insert into CAUTHU values ( 'HN01', 'Bui Tan Truong', '19-02-1986', 'Trong Nuoc' , 'Thi Dau 5 nam','Khoe manh' ,  'HNFC')
 insert into CAUTHU values ( 'HN02', 'Nguyen Van Dung', '1-04-1994', 'Trong Nuoc' , 'Thi Dau 2 nam','Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN03', 'Dau Van Toan', '2-4-1984', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN04', 'Manh Ngoc Ha', '23-04-1998', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN05', 'Nguyen Van Quyet', '13-06-1995', 'Trong Nuoc' , 'Thi Dau 4 nam' ,'Khoe manh', 'HNFC')          
 insert into CAUTHU values ( 'HN06', 'Moses Oloya', '8-03-1998', 'Ngoai Nuoc' , 'Thi Dau 1 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN07', 'Lebron James', '19-03-1995', 'Ngoai Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN08', 'Giannis Harden', '12-12-1999', 'Ngoai Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN09', 'Pham Duc Huy', '23-11-2000', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'HNFC')
 insert into CAUTHU values ( 'HN10', 'Nguyen Thanh Cong', '10-08-2000', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'HNFC') 

  ------------Tp. Ho Chi Minh------------------

 insert into CAUTHU values ( 'SG01', 'Nguyen Thanh Thang', '14-12-1988', 'Trong Nuoc' , 'Thi Dau 10 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG02', 'Ngo Tung Quoc', '27-01-1988', 'Trong Nuoc' , 'Thi Dau 5 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG03', 'Nguyen Tang Tien', '31-01-1994', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG04', 'Ngo Viet Phu', '13-06-1999', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG05', 'Sam Ngoc Duc', '11-12-1995', 'Trong Nuoc' , 'Thi Dau 5 nam' ,'Khoe manh', 'HCMC')            ------------Tp. Ho Chi Minh------------------
 insert into CAUTHU values ( 'SG06', 'Tran Thanh Binh', '10-09-1989', 'Trong Nuoc' , 'Thi Dau 8 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG07', 'Seo Yonh Duk', '19-09-1994', 'Ngoai Nuoc' , 'Thi Dau 6 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG08', 'Ngo Hoang Thinh', '17-07-1993', 'Trong Nuoc' , 'Thi Dau 5 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG09', 'Do Van Thuan', '15-005-2000', 'Trong Nuoc' , 'Thi Dau 1 nam' ,'Khoe manh', 'HCMC')
 insert into CAUTHU values ( 'SG10', 'Vo Huy Toan', '23-01-1999', 'Trong Nuoc' , ' Thi Dau 1 nam ' ,'Khoe manh', 'HCMC')

 
	--	 DONG THAP 

 insert into CAUTHU values ( 'DT01', 'Nguyen Van Buoc', '13-7-1985', 'Trong Nuoc' , 'Thi Dau 5 nam' ,'Khoe manh', 'DTFC')
 insert into CAUTHU values ( 'DT02', 'Nguyen Thanh Hien', '16-04-1993', 'Trong Nuoc' , 'Thi Dau 4 nam' ,'Lech vai', 'DTFC')
 insert into CAUTHU values ( 'DT03', 'Ho Truong Khang', '26-09-1994', 'Trong Nuoc' , 'Thi Dau 5 nam' ,'Khoe manh', 'DTFC')
 insert into CAUTHU values ( 'DT04', 'Tran Tuan Thanh', '14-1-1998', 'Trong Nuoc' , 'Thi Dau 1 nam' ,'Khoe manh', 'DTFC')
 insert into CAUTHU values ( 'DT05', 'Nguyen Tran Mila', '16-11-1989', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'DTFC')
 insert into CAUTHU values ( 'DT06', 'Nguyen Hoang Duy', '4-6-1999', 'Trong Nuoc' , 'Thi Dau 1 nam' ,'Khoe manh', 'DTFC')
 insert into CAUTHU values ( 'DT07', 'Vo Thanh Hau', '27-5-1999', 'Trong Nuoc' , 'Thi Dau 1 nam' ,'Khoe manh', 'DTFC')
 insert into CAUTHU values ( 'DT08', 'Ngo Duc Thang', '3-3-1986', 'Trong Nuoc' , 'Thi Dau 6 nam' ,'Khoe manh', 'DTFC')
 insert into CAUTHU values ( 'DT09', 'Le Tan Phi', '2-1-1995', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'DTFC')
 insert into CAUTHU values ( 'DT10', 'Mia Khalid', '26-02-1996', 'Ngoai Nuoc' , 'Thi Dau 5 nam' ,'Khoe manh', 'DTFC')

 
		-- AN GIANG

 insert into CAUTHU values ( 'AG01', 'Nguyen Manh Cuong', '03-09-1997', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'AGFC')
 insert into CAUTHU values ( 'AG02', 'Tran Gia Nam', '18-08-1996', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'AGFC')
 insert into CAUTHU values ( 'AG03', 'Nguyen Thanh Cong', '09-02-2001', 'Trong Nuoc' , 'Thi Dau 1 nam' ,'Khoe manh', 'AGFC')
 insert into CAUTHU values ( 'AG04', 'Vo Nguyen Phuong Duy', '28-08-1989', 'Trong Nuoc' , 'Thi Dau 6 nam' ,'Khoe manh', 'AGFC')
 insert into CAUTHU values ( 'AG05', 'Nguyen Phan The Lam', '07-05-1996', 'Trong Nuoc' , 'Thi Dau 3 nam' ,'Khoe manh', 'AGFC')
 insert into CAUTHU values ( 'AG06', 'Nguyen Van Trong', '03-03-1999', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'AGFC')
 insert into CAUTHU values ( 'AG07', 'Luong Thanh Sang', '31-7-1994', 'Trong Nuoc' , 'Thi Dau 6 nam' ,'Khoe manh', 'AGFC')
 insert into CAUTHU values ( 'AG08', 'Tony Stark', '29-05-1970', 'Ngoai Nuoc' , 'Thi Dau 20 nam' ,'Da chet', 'AGFC')
 insert into CAUTHU values ( 'AG09', 'Thor Thor', '08-08-1968', 'Ngoai Nuoc' , 'Thi Dau 24 nam' ,'Beo phi', 'AGFC')
 insert into CAUTHU values ( 'AG10', 'Captain Ameria', '04-07-1918', 'Ngoai Nuoc' , 'Thi Dau 36 nam' ,'Nghi huu', 'AGFC')


 --Binh Dinh


 insert into CAUTHU values ( 'BD01', 'Vo Doan Thuc Kha', '31-05-1991', 'Trong Nuoc' , 'Thi Dau 6 nam' ,'Khoe manh', 'BDFC')
 insert into CAUTHU values ( 'BD02', 'Nguyen Thai Son', '09-04-1993', 'Trong Nuoc' , 'Thi Dau 6 nam' ,'Khoe manh', 'BDFC')
 insert into CAUTHU values ( 'BD03', 'Nguyen Van Thang', '15-01-1990', 'Trong Nuoc' , 'Thi Dau 10 nam' ,'Khoe manh', 'BDFC')
 insert into CAUTHU values ( 'BD04', 'Nguyen Xuan Kien', '04-01-2000', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'BDFC')
 insert into CAUTHU values ( 'BD05', 'Phan Duc Le', '17-10-1993', 'Trong Nuoc' , 'Thi Dau 7 nam' ,'Khoe manh', 'BDFC')
 insert into CAUTHU values ( 'BD06', 'Bui Van Hieu', '31-05-1992', 'Trong Nuoc' , 'Thi Dau 6 nam' ,'Khoe manh', 'BDFC')
 insert into CAUTHU values ( 'BD07', 'Huynh Van Thanh', '10-02-1999', 'Trong Nuoc' , 'Thi Dau 7 nam' ,'Khoe manh', 'BDFC')
 insert into CAUTHU values ( 'BD08', 'Tran Hoang Son', '31-03-1990', 'Trong Nuoc' , 'Thi Dau 10 nam' ,'Lech vai phai', 'BDFC')
 insert into CAUTHU values ( 'BD09', 'Le Hoang Thien', '21-12-2001', 'Trong Nuoc' , 'Thi Dau 2 nam' ,'Khoe manh', 'BDFC')
 insert into CAUTHU values ( 'BD10', 'Thanos', '01-01-1990', 'Ngoai Nuoc' , 'Thi Dau 100 nam' ,'Rat khoe manh', 'BDFC')
------------------------------------------------TRAN DAU-----------------------------







-- BAN THANG BAN DAU







-- Tran Dau Ban Dau

insert into TRANDAU values ('VB001' , 'HAGL' , 'HCMC' , '03-01-2020 ' , '5:00' , 'Gia Lai' , '30', 'VB','3','0' )

	insert into BANTHANG values ('0001' , 'HA05' , 'TrucTiep' , '23' , 'VB001')
	insert into BANTHANG values ('0002' , 'HA05' , 'Penalty' , '48' , 'VB001')
	insert into BANTHANG values ('0003' , 'HA05' , 'TrucTiep' , '65' , 'VB001')

insert into TRANDAU values ('VB002' , 'HNFC' , 'HCMC' , '03-01-2020 ' , '5:00' , 'SVD Thong Nhat' , '03', 'VB','0','3' )

	insert into BANTHANG values ('0004' , 'SG10' , 'TrucTiep' , '48' , 'VB002')
	insert into BANTHANG values ('0005' , 'SG10' , 'DaPhat' , '50' , 'VB002')
	insert into BANTHANG values ('0006' , 'SG10' , 'DaPhat' , '75' , 'VB002')

insert into TRANDAU values ('VB003' , 'HAGL' , 'HCMC' , '03-01-2020 ' , '7:00' , 'Gia Lai' , '11', 'VB','1','1' )

	insert into BANTHANG values ('0007' , 'SG10' , 'TrucTiep' , '70' , 'VB003')
	insert into BANTHANG values ('0008' , 'SG10' , 'DaPhat' , '72' , 'VB003')

insert into TRANDAU values ('VB004' , 'HAGL' , 'HNFC' , '05-01-2020 ' , '3:00' , 'Gia Lai' , '30', 'VB','3','0' )
	
	insert into BANTHANG values ('0009' , 'HA11' , 'DaPhat' , '12' , 'VB004')
	insert into BANTHANG values ('0010' , 'HA11' , 'DaPhat' , '15' , 'VB004')
	insert into BANTHANG values ('0011' , 'HA11' , 'TrucTiep' , '30' , 'VB004')


insert into TRANDAU values ('VB005' , 'HNFC' , 'HCMC' , '07-01-2020 ' , '3:00' , 'My Dinh' , '00', 'VB','0','0' )


insert into TRANDAU values ('VB006' , 'HNFC' , 'HAGL' , '09-01-2020 ' , '5:00' , 'My Dinh' , '22', 'VB','2','2' )
	
	insert into BANTHANG values ('0012' , 'HA11' , 'DaPhat' , '5' , 'VB006')
	insert into BANTHANG values ('0013' , 'HA11' , 'TrucTiep' , '10' , 'VB006')
	insert into BANTHANG values ('0014' , 'HN05' , 'TrucTiep' , '24' , 'VB006')
	insert into BANTHANG values ('0015' , 'HN07' , 'TrucTiep' , '75' , 'VB006')

insert into TRANDAU values ('VB007' , 'DTFC' , 'AGFC' , '13-01-2020' , '4:00' , 'SVD Dong Thap' , '03', 'VB','0','3')

	insert into BANTHANG values ('0016' , 'AG09' , 'DaPhat' , '48' , 'VB007')
	insert into BANTHANG values ('0017' , 'AG08' , 'TrucTiep' , '55' , 'VB007')
	insert into BANTHANG values ('0018' , 'AG10' , 'TrucTiep' , '70' , 'VB007')

insert into TRANDAU values ('VB008' , 'DTFC' , 'BDFC' , '14-01-2020' , '5:00' , 'SVD Dong Thap' , '03', 'VB','0','3' )

	insert into BANTHANG values ('0019' , 'BD10' , 'TrucTiep' , '2' , 'VB008')
	insert into BANTHANG values ('0020' , 'BD10' , 'TrucTiep' , '35' , 'VB008')
	insert into BANTHANG values ('0021' , 'BD10' , 'TrucTiep' , '88' , 'VB008')

insert into TRANDAU values ('VB009' , 'AGFC' , 'BDFC' , '15-01-2020' , '5:00' , 'SVD An Giang' , '20', 'VB','2','0' )

	insert into BANTHANG values ('0022' , 'AG08' , 'TrucTiep' , '14' , 'VB009')
	insert into BANTHANG values ('0023' , 'AG08' , 'TrucTiep' , '79' , 'VB009')

insert into TRANDAU values ('VB010' , 'AGFC' , 'BDFC' , '16-01-2020' , '5:30' , 'SVD An Giang' , '11', 'VB','1','0' )

	insert into BANTHANG values ('0024' , 'AG09' , 'TrucTiep' , '54' , 'VB010')
	insert into BANTHANG values ('0025' , 'BD10' , 'TrucTiep' , '67' , 'VB010')

insert into TRANDAU values ('VB011' , 'BDFC' , 'AGFC' , '17-01-2020' , '6:00' , 'SVD Quy Nhon' , '20', 'VB','2','0' )

	insert into BANTHANG values ('0026' , 'BD10' , 'DaPhat' , '78' , 'VB011')
	insert into BANTHANG values ('0027' , 'BD10' , 'TrucTiep' , '90' , 'VB011')
	
insert into TRANDAU values ('VB012' , 'BDFC' , 'DTFC' , '18-01-2020' , '7:00' , 'SVD Quy Nhon' , '10', 'VB','1','0' )

	insert into BANTHANG values ('0028' , 'BD10' , 'TrucTiep' , '65' , 'VB012')

insert into TRANDAU values ('VB013' , 'HAGL' , 'AGFC' , '19-01-2020' , '7:30' , 'Gia Lai' , '11', 'VB','1','1' )

	insert into BANTHANG values ('0029' , 'AG08' , 'TrucTiep' , '35' , 'VB013')
	insert into BANTHANG values ('0030' , 'AG10' , 'TrucTiep' , '49' , 'VB013')

insert into TRANDAU values ('VB014' , 'HAGL' , 'DTFC' , '20-01-2020' , '4:00' , 'Gia Lai' , '00', 'VB','0','0' )
insert into TRANDAU values ('VB015' , 'HAGL' , 'BDFC' , '21-01-2020' , '4:00' , 'Gia Lai' , '02', 'VB','0','2' )

	insert into BANTHANG values ('0031' , 'BD10' , 'TrucTiep' , '18' , 'VB015')
	insert into BANTHANG values ('0032' , 'BD10' , 'TrucTiep' , '54' , 'VB015')

insert into TRANDAU values ('VB016' , 'HNFC' , 'BDFC' , '22-01-2020' , '4:30' , 'Gia Lai' , '00', 'VB','0','0' )
insert into TRANDAU values ('VB017' , 'HNFC' , 'AGFC' , '23-01-2020' , '5:30' , 'Gia Lai' , '02', 'VB','0','0' )

	insert into BANTHANG values ('0033' , 'AG07' , 'DaPhat' , '48' , 'VB017')
	insert into BANTHANG values ('0034' , 'AG08' , 'TrucTiep' , '72' , 'VB017')

insert into TRANDAU values ('VB018' , 'HNFC' , 'DTFC' , '24-01-2020' , '5:00' , 'Gia Lai' , '00', 'VB','0','0' )
insert into TRANDAU values ('VB019' , 'HCMC' , 'DTFC' , '25-01-2020' , '6:00' , 'Gia Lai' , '10', 'VB','1','0' )

	insert into BANTHANG values ('0035' , 'SG05' , 'Penalty' , '28' , 'VB019')

/*insert into TRANDAU values ('VB020' , 'HCMC' , 'AGFC' , '26-01-2020' , '7:00' , 'Gia Lai' , null, 'VB',null,null )
insert into TRANDAU values ('VB021' , 'HCMC' , 'BDFC' , '27-01-2020' , '5:30' , 'Gia Lai' , null, 'VB',null,null )
insert into TRANDAU values ('VB022' , 'AGFC' , 'HCMC' , '28-01-2020' , '4:00' , 'SVD An Giang' , null, 'VB',null,null)	
insert into TRANDAU values ('VB023' , 'BDFC' , 'HNFC' , '29-01-2020' , '4:30' , 'SVD Quy Nhon' , null, 'VB',null,null )
insert into TRANDAU values ('VB024' , 'AGFC' , 'HNFC' , '30-01-2020' , '4:00' , 'SVD An Giang' , null, 'VB',null,null )
insert into TRANDAU values ('VB025' , 'DTFC' , 'HCMC' , '02-02-2020' , '5:00' , 'SVD Dong Thap' , null, 'VB',null,null )
insert into TRANDAU values ('VB026' , 'BDFC' , 'HCMC' , '03-02-2020' , '6:00' , 'SVD Quy Nhon' , null, 'VB',null,null )


insert into TRANDAU values ('VB027' , 'AGFC' , 'HAGL' , '04-02-2020' , '6:00' , 'SVD An Giang' , null, 'VB',null,null )
insert into TRANDAU values ('VB028' , 'BDFC' , 'HAGL' , '05-02-2020' , '7:00' , 'SVD Quy Nhon' ,null, 'VB',null,null )
insert into TRANDAU values ('VB020' , 'DTFC' , 'HAGL' , '07-02-2020' , '4:00' , 'SVD Dong Thap' ,null, 'VB',null,null )
insert into TRANDAU values ('VB030' , 'DTFC' , 'HNFC' , '10-02-2020' , '6:00' , 'SVD Dong Thap' ,null, 'VB',null,null )
*/





