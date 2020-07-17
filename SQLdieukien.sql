-- Câu lệnh SQL điều kiện

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
