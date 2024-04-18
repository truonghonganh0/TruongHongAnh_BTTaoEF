use master
go
drop database if exists DatabaseFirst
go
create database DatabaseFirst
go
use DatabaseFirst

go
-- Tao bang Khoa
CREATE TABLE Khoa (
    MaKhoa INT PRIMARY KEY,
    TenKhoa NVARCHAR(MAX)
);

go
-- Them du lieu mau vao bang Khoa
INSERT INTO Khoa (MaKhoa, TenKhoa)
VALUES
    (1, 'CNS'),
    (2, 'SPKT'),
    (3, 'CK');

go
-- Tao bang Lop
CREATE TABLE Lop (
    MaLop INT PRIMARY KEY,
    TenLop NVARCHAR(MAX)
);

go
-- Them du lieu mau vao bang Lop
INSERT INTO Lop (MaLop, TenLop)
VALUES
    (1, '21T3'),
    (2, '21T2'),
    (3, '22T3'),
    (4, '22T2');

go
-- Tao bang SinhVien
CREATE TABLE SinhVien (
    MaSinhVien INT PRIMARY KEY,
    HoTen NVARCHAR(MAX),
    Age INT,
    LopMaLop INT FOREIGN KEY REFERENCES Lop(MaLop),
    KhoaMaKhoa INT FOREIGN KEY REFERENCES Khoa(MaKhoa)
);

go
-- Them du lieu mau vao bang SinhVien
INSERT INTO SinhVien (MaSinhVien, HoTen, Age, LopMaLop, KhoaMaKhoa)
VALUES
    (1, 'Tran Van A', 19, 1, 1),
    (2, 'Nguyen Van B', 20, 2, 1),
    (3, 'Le Van C', 21, 1, 1),
    (4, 'Ho Thi D', 22, 2, 2),
    (5, 'Duong Van E', 23, 2, 2);