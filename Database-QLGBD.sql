Create database QLGBDVDQG

use QLGBDVDQG
go 

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
alter table CAUTHU add constraint fk_MaDoi foreign key (MaDoi) references DOIBONG(MaDoi)

-- Xoa khoa ngoai cau thu

alter table CAUTHU drop constraint fk_MaDoi  
go 


drop table LOAICAUTHU
-- tạo bảng loại cầu thủ
Create table LOAICAUTHU
(
MaLoaiCauThu varchar(45), 
TenLoaiCauThu varchar(45),
)
alter table CAUTHU add constraint fk_MaLoaiCauThu foreign key (MaLoaiCauThu) references LOAICAUTHU(MaLoaiCauThu)

Alter table CAUTHU drop constraint fk_MaLoaiCauThu
go

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

-- tạo bảng loại bàn thắng
create table LOAIBANTHANG
(
MaLoaiBanThang varchar(45) primary key not null ,
TenLoaiBanThang varchar(45),
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


insert TRANDAU values ('Vong1LD' , ' BinhDuong' , ' LongAn' , '01-01-2020 ' , '4:00' , ' Tan An' , ' 30', 'Vong1' )
insert TRANDAU values ('Vong2LD' , ' KhanhHoa' , ' HaNoi' , '02-01-2020 ' , '4:20' , ' Hang Day' , ' 2-1', 'Vong2' )

insert BANTHANG values ('00A' , ' 1001' , 'A' , ' 69p' , 'Vong1LD')
insert BANTHANG values ('00A' , ' 1001' , 'C' , ' 72p' , 'Vong1LD')
insert BANTHANG values ('00A' , ' 1001' , 'B' , ' 90p' , 'Vong1LD')

select TenCauThu, TenDoi, MaLoaiCauThu, COUNT(MaLoaiBanThang) as SOBANTHANG from DOIBONG, CAUTHU, BANTHANG 
where  DOIBONG.MaDoi= CAUTHU.MaDoi 
and CAUTHU.MaCauThu = '1001'
group by TenCauThu, TenDoi, MaLoaiCauThu, MaLoaiBanThang

go

-- tạo bảng vòng đấu
create table VONGDAU 
(
MaVongDau varchar(45) primary key not null ,
TenVongDau varchar(45),
)


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
 insert into DOIBONG(MaDoi, TenDoi, SanNha, SoCauThu) values ( 1, 'Long An', ' Tan An ', 5)
 insert into DOIBONG values ( 2, ' HoChiMinh', ' Thong Nhat', 5)
 insert into DOIBONG values ( 3, ' Binh Duong', ' Go Dau ', 6)
 insert into DOIBONG values (7,' Hoang Anh Gia Lai','Gia Lai', '10')
 insert into DOIBONG values (6,' Ha Noi' ,'My Dinh', '10')
 go

 insert into LOAICAUTHU values ( ' 001TN ' , ' Trong nước ')
 insert into LOAICAUTHU values ( ' 001NN'  , ' Nước Ngoài' )

 ------------------INSERT CAUTHU-----------------------------
 insert into CAUTHU values ( 1003, ' Tran Thanh Lam', '18-07-2000', ' TrongNuoc' , ' Thi Dau 3 nam ' , '1')
 insert into CAUTHU values ( 1004, ' Tran Quoc Thang', '01-01-2000', ' NgoaiNuoc' , ' Thi Dau 6 nam ' , '1')
 insert into CAUTHU values ( 1001, ' Luong Duy Bao', '2000-01-01', 'TrongNuoc ' , ' Thi Dau 10 nam ' , '2')
 insert into CAUTHU values ( 1002, ' Luong Duy Bao', '2000-01-02', ' NgoaiNuoc' , ' Thi Dau 2 nam ' , '3')
 insert into CAUTHU values ( 1005, ' Nguyen Thanh Det', '2000-01-02', ' TrongNuoC' , ' Thi Dau 10000 nam ' , '1')

 insert into CAUTHU values ( 7001, ' Tran Buu Ngoc', '26-02-1991', ' TrongNuoC' , ' Thi Dau 5 nam ' , '7')
 insert into CAUTHU values ( 7002, ' Nguyen Canh Anh', '11-01-2000', ' TrongNuoC' , ' Thi Dau 2 nam ' , '7')
 insert into CAUTHU values ( 7003, ' Nguyen Huu Anh Tai', '27-02-1996', ' TrongNuoC' , ' Thi Dau 2 nam ' , '7')
 insert into CAUTHU values ( 7004, ' Au Duong Quan', '30-04-1998', ' TrongNuoC' , ' Thi Dau 3 nam ' , '7')
 insert into CAUTHU values ( 7005, ' Luong Xuan Truong', '13-06-1995', ' TrongNuoC' , ' Thi Dau 4 nam ' , '7')
 insert into CAUTHU values ( 7006, ' Nguyen Phong Hong Duy', '18-02-1998', ' TrongNuoC' , ' Thi Dau 1 nam ' , '7')
 insert into CAUTHU values ( 7007, ' Tran Minh Vuong', '19-08-1999', ' TrongNuoC' , ' Thi Dau 2 nam ' , '7')
 insert into CAUTHU values ( 7008, ' Nguyen Van Toan', '12-04-1996', ' TrongNuoC' , ' Thi Dau 2 nam ' , '7')
 insert into CAUTHU values ( 7009, ' Nguyen Huu Canh', '01-01-1998', ' TrongNuoC' , ' Thi Dau 3 nam ' , '7')
 insert into CAUTHU values ( 7010, ' Nguyen Thanh Dat', '10-07-2000', ' TrongNuoC' , ' Thi Dau 3 nam ' , '7') 

 insert into CAUTHU values ( 6001, ' Bui Tan Truong', '19-02-1986', ' TrongNuoc' , ' Thi Dau 5 nam ' , '6')
 insert into CAUTHU values ( 6002, ' Nguyen Van Dung', '1-04-1994', ' TrongNuoc' , ' Thi Dau 2 nam ' , '6')
 insert into CAUTHU values ( 6003, ' Dau Van Toan', '2-4-1984', ' TrongNuoc' , ' Thi Dau 2 nam ' , '6')
 insert into CAUTHU values ( 6004, ' Manh Ngoc Ha', '23-04-1998', ' TrongNuoc' , ' Thi Dau 3 nam ' , '6')
 insert into CAUTHU values ( 6005, ' Nguyen Van Quyet', '13-06-1995', ' TrongNuoc' , ' Thi Dau 4 nam ' , '6')
 insert into CAUTHU values ( 6006, ' Moses Oloya', '8-03-1998', ' NgoaiNuoc' , ' Thi Dau 1 nam ' , '6')
 insert into CAUTHU values ( 6007, ' Lebron James', '19-03-1995', ' NgoaiNuoc' , ' Thi Dau 2 nam ' , '6')
 insert into CAUTHU values ( 6008, ' Giannis Harden', '12-12-1999', ' NgoaiNuoc' , ' Thi Dau 2 nam ' , '6')
 insert into CAUTHU values ( 6009, ' Pham Duc Huy', '23-11-2000', ' TrongNuoc' , ' Thi Dau 3 nam ' , '6')
 insert into CAUTHU values ( 6010, ' Nguyen Thanh Cong', '10-08-2000', ' TrongNuoc' , ' Thi Dau 3 nam ' , '6') 
 

  go

  delete from CAUTHU
 go 
 SELECT * FROM CAUTHU WHERE MaDoi='1'
 set dateformat dmy

 go

 alter table CAUTHU alter column NgaySinh date

 SELECT MaCauThu,TenCauThu,NgaySinh,TenLoaiCauThu,TenDoi FROM CAUTHU,DOIBONG,LOAICAUTHU
  WHERE CAUTHU.MaDoi=DOIBONG.MaDoi And LOAICAUTHU.MaLoaiCauThu=CAUTHU.MaLoaiCauThu

  INSERT INTO DOIBONG(MaDoi,TenDoi,SanNha,SoCauThu)
                        VALUES('" + Team.id + "', '" + Team.ten + "', '" + Team.ten_sannha + "', '" + Team.slgct + "')

SELECT * FROM CAUTHU