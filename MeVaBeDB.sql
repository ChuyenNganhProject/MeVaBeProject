CREATE DATABASE MeVaBeDB
GO
USE MeVaBeDB
GO
CREATE TABLE HangThanhVien (
    maHang VARCHAR(10) PRIMARY KEY,
    tenHang NVARCHAR(100),
    mucTieuBatDau DECIMAL(18,2),
    mucTieuKetThuc DECIMAL(18,2),
    ghiChu NVARCHAR(255)
);
GO
CREATE TABLE KhachHang (
    maKhachHang VARCHAR(20) PRIMARY KEY,
    tenKhachHang NVARCHAR(100),
    soDienThoai VARCHAR(15) UNIQUE,
	diemTichLuy DECIMAL(18,2),
    maHang VARCHAR(10),
    CONSTRAINT FK_KH_HTV FOREIGN KEY (maHang) REFERENCES HangThanhVien(maHang)
);
GO
CREATE TABLE LoaiNhanVien (
    maLoaiNhanVien VARCHAR(10) PRIMARY KEY,
    tenLoaiNhanVien NVARCHAR(100)
);
GO
CREATE TABLE NhanVien (
    maNhanVien VARCHAR(50) PRIMARY KEY,
    maLoaiNhanVien VARCHAR(10),
    tenNhanVien NVARCHAR(50),
    ngaySinh DATE,
    diaChi NVARCHAR(255),
    soDienThoai VARCHAR(15),
    tenDangNhap NVARCHAR(255) UNIQUE,
    matKhau NVARCHAR(255),
    luongCoBan INT,
    ngayVaoLam DATE,
    CONSTRAINT FK_NV_LoaiNV FOREIGN KEY (maLoaiNhanVien) REFERENCES LoaiNhanVien(maLoaiNhanVien)
);
GO
CREATE TABLE NhaCungCap (
    maNhaCungCap VARCHAR(10) PRIMARY KEY,
    tenNhaCungCap NVARCHAR(100),
    soDienThoai VARCHAR(15),
    diaChi NVARCHAR(255),
    email NVARCHAR(255)
);
GO
CREATE TABLE LoaiSanPham (
    maLoaiSanPham VARCHAR(10) PRIMARY KEY,
    tenLoaiSanPham NVARCHAR(100)
);

--CREATE TABLE LuaTuoi (
--    maLuaTuoi VARCHAR(10) PRIMARY KEY,
--    doTuoi INT
--);
GO
CREATE TABLE SanPham (
    maSanPham VARCHAR(50) PRIMARY KEY,
    maLoaiSanPham VARCHAR(10),
    tenSanPham NVARCHAR(100),
    donGiaBan DECIMAL(18, 2),
	donGiaSale DECIMAL(18, 2),
    soLuong INT,
    ngaySanXuat DATE,
    hanSuDung DATE,
    hinhAnh NVARCHAR(255),
    trangThai NVARCHAR(50),
    FOREIGN KEY (maLoaiSanPham) REFERENCES LoaiSanPham(maLoaiSanPham)
);

--CREATE TABLE SanPham_NhaCungCap (
--    maSanPham VARCHAR(50),
--    maNhaCungCap VARCHAR(10),
--    donGiaNhap DECIMAL(18, 2),       
--    PRIMARY KEY (maSanPham, maNhaCungCap),
--    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham),
--    FOREIGN KEY (maNhaCungCap) REFERENCES NhaCungCap(maNhaCungCap)
--);

--CREATE TABLE ChiTietLuaTuoi (
--    maSanPham VARCHAR(50),
--    maLuaTuoi VARCHAR(10),
--    PRIMARY KEY (maSanPham, maLuaTuoi),
--    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham),
--    FOREIGN KEY (maLuaTuoi) REFERENCES LuaTuoi(maLuaTuoi)
--);

--CREATE TABLE TonKho (
--    maSanPham VARCHAR(50) PRIMARY KEY,
--    soLuongTon INT,
--    ngayCapNhat DATE,
--    soLuongToiThieu INT,
--    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
--);
GO
CREATE TABLE HoaDon (
    maHoaDon VARCHAR(50) PRIMARY KEY,
    maKhachHang VARCHAR(20),
    maNhanVien VARCHAR(50),
    ngayLap DATETIME,
	tienDuocGiam DECIMAL(18,2),
    tongTienSauGiam DECIMAL(18, 2),
	tongTien DECIMAL(18, 2),
    trangThai BIT,
    FOREIGN KEY (maKhachHang) REFERENCES KhachHang(maKhachHang),
    FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);
GO
CREATE TABLE PhieuDoiHang (
    maPhieuDoi VARCHAR(50) PRIMARY KEY,
    maHoaDon VARCHAR(50),
    maKhachHang VARCHAR(20),
    maNhanVien VARCHAR(50),
    ngayDoi DATE,
    trangThai BIT,
    FOREIGN KEY (maHoaDon) REFERENCES HoaDon(maHoaDon),
    FOREIGN KEY (maKhachHang) REFERENCES KhachHang(maKhachHang),
    FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);
GO
CREATE TABLE ChiTietPhieuDoiHang (
    maPhieuDoi VARCHAR(50),
    maSanPham VARCHAR(50),
    soLuong INT,
    donGia DECIMAL(18, 2),
    tongTien DECIMAL(18, 2),
    PRIMARY KEY (maPhieuDoi, maSanPham),
    FOREIGN KEY (maPhieuDoi) REFERENCES PhieuDoiHang(maPhieuDoi),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);
GO
CREATE TABLE UuDaiThanhVien (
    maUuDai INT PRIMARY KEY,
    tenUuDai NVARCHAR(50),
    giaTriUuDai DECIMAL(5, 2),
	maHang VARCHAR(10),
	FOREIGN KEY (maHang) REFERENCES HangThanhVien(maHang)
);
GO
CREATE TABLE GoiSanPham (
    maGoiSanPham VARCHAR(50) PRIMARY KEY,
    tenGoiSanPham NVARCHAR(100),
    donGia DECIMAL(18, 2),
    soLuong INT,
    hinhAnh NVARCHAR(255)
);
GO
CREATE TABLE ChiTietGoiSanPham (
    maGoiSanPham VARCHAR(50),
    maSanPham VARCHAR(50),
    donGia DECIMAL(18, 2),
    soLuong INT,
    PRIMARY KEY (maGoiSanPham, maSanPham),
    FOREIGN KEY (maGoiSanPham) REFERENCES GoiSanPham(maGoiSanPham),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);
GO
CREATE TABLE ChiTietHoaDonSanPham (
    maHoaDon VARCHAR(50),
    maSanPham VARCHAR(50),
    soLuong INT,
    donGia DECIMAL(18, 2),
    tongTien DECIMAL(18, 2),
    PRIMARY KEY (maHoaDon, maSanPham),
    FOREIGN KEY (maHoaDon) REFERENCES HoaDon(maHoaDon),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);
GO
CREATE TABLE PhieuDat (
    maPhieuDat VARCHAR(50) PRIMARY KEY,
    maNhanVien VARCHAR(50),
	maNhaCungCap VARCHAR(10),
    ngayLap DATE,
	ngayCapNhat DATE,
	soLuong INT,
    tongTien DECIMAL(18, 2),
	trangThai NVARCHAR(20),
    FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien),
	FOREIGN KEY (maNhaCungCap) REFERENCES NhaCungCap(maNhaCungCap)
);
GO
CREATE TABLE ChiTietPhieuDat (
    maPhieuDat VARCHAR(50),
    maSanPham VARCHAR(50),	
    soLuongDat INT,
	soLuongNhan INT,
    donGia DECIMAL(18, 2),
    tongTien DECIMAL(18, 2),
    PRIMARY KEY (maPhieuDat, maSanPham),
    FOREIGN KEY (maPhieuDat) REFERENCES PhieuDat(maPhieuDat),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);
GO
CREATE TABLE PhieuThanhLy (
    maThanhLy VARCHAR(50) PRIMARY KEY,
    maNhanVien VARCHAR(50),
    lyDo NVARCHAR(255),
    ngayThanhLy DATE,
    tongTien DECIMAL(18, 2),
    FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);
GO
CREATE TABLE ChiTietPhieuThanhLy (
    maThanhLy VARCHAR(50),
    maSanPham VARCHAR(50),
    soLuong INT,
    giaThanhLy DECIMAL(18, 2),
    PRIMARY KEY (maThanhLy, maSanPham),
    FOREIGN KEY (maThanhLy) REFERENCES PhieuThanhLy(maThanhLy),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);
GO
CREATE TABLE KhuyenMai (
    maKhuyenMai VARCHAR(50) PRIMARY KEY,
    tenKhuyenMai NVARCHAR(100),
    moTa NVARCHAR(255),
    ngayBatDau DATE,
    ngayKetThuc DATE,
    trangThai BIT
);
GO
CREATE TABLE KhuyenMaiSanPham (
    maKhuyenMai VARCHAR(50),
    maSanPham VARCHAR(50),
    phanTramGiam DECIMAL(18, 2),
    trangThai BIT,
    PRIMARY KEY (maKhuyenMai, maSanPham),
    FOREIGN KEY (maKhuyenMai) REFERENCES KhuyenMai(maKhuyenMai),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);
GO
CREATE TABLE PhieuGiaoHang (
    maPhieuGiao VARCHAR(50) PRIMARY KEY,
    maHoaDon VARCHAR(50),
    ngayGiaoDuKien DATE,
    chiPhi DECIMAL(18, 2),
    tinhTrang BIT,
    FOREIGN KEY (maHoaDon) REFERENCES HoaDon(maHoaDon)
);
--GO
--CREATE TABLE ChiTietPhieuGiaoHang (
--    maPhieuGiao VARCHAR(50),
--    maSanPham VARCHAR(50),
--    soLuong INT,
--    donGia DECIMAL(18, 2),
--    tongTien DECIMAL(18, 2),
--    PRIMARY KEY (maPhieuGiao, maSanPham),
--    FOREIGN KEY (maPhieuGiao) REFERENCES PhieuGiaoHang(maPhieuGiao),
--    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
--);
GO
CREATE TABLE PhieuNhap (
    maPhieuNhap VARCHAR(50) PRIMARY KEY,
	maPhieuDat VARCHAR(50),
    ngayNhap DATE,
	soLan INT,
	tongTien DECIMAL(18,2),
	FOREIGN KEY (maPhieuDat) REFERENCES PhieuDat(maPhieuDat)
);
GO
CREATE TABLE ChiTietPhieuNhap (
    maPhieuNhap VARCHAR(50),
    maSanPham VARCHAR(50),
	maPhieuDat VARCHAR(50),
    soLuong INT,
    donGia DECIMAL(18,2),
	tongTien DECIMAL(18,2),
    PRIMARY KEY (maPhieuDat, maSanPham, maPhieuNhap),
    FOREIGN KEY (maPhieuNhap) REFERENCES PhieuNhap(maPhieuNhap),
    FOREIGN KEY (maPhieuDat,maSanPham) REFERENCES ChiTietPhieuDat(maPhieuDat,maSanPham)
);
GO
ALTER TABLE PhieuDat
ADD CONSTRAINT NgayCapNhatCheck CHECK( ngayLap <= ngayCapNhat)

ALTER TABLE PhieuDat
ADD CONSTRAINT TrangThaiDefault DEFAULT N'Chưa duyệt' FOR trangThai

ALTER TABLE PhieuDat
ADD CONSTRAINT TongTienDefault DEFAULT 0 FOR tongTien

ALTER TABLE ChiTietPhieuDat
ADD CONSTRAINT SoLuongNhanDefault DEFAULT 0 FOR soLuongNhan
GO
INSERT INTO LoaiNhanVien (maLoaiNhanVien, tenLoaiNhanVien) 
VALUES 
('QL', N'Quản Lý'),
('NVBH', N'Nhân Viên Bán Hàng'),
('NVK', N'Nhân Viên Kho');
GO
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV001', 'QL', N'Phạm Minh Nhật', '2003-11-19', N'254 Đường NVC, TP.HCM', '0775945228', 'minhnhat', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 20000000, '2024-10-01')
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV002', 'QL', N'Đặng Hoàng Phúc', '2003-12-06', N'123 Đường NK, TP.HCM', '0888005346', 'hoangphuc', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 20000000, '2024-10-01')
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV003', 'QL', N'Trương Thị Quí', '2003-01-19', N'123 Đường ABC, TP.HCM', '0901234567', 'truongqui', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 20000000, '2024-10-01');
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV004', 'NVBH', N'Phạm Minh Nhật', '2003-11-19', N'254 Đường NVC, TP.HCM', '0775945228', 'nvbhminhnhat', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', '1911'), 2), 20000000, '2024-10-01');
GO
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP001', N'Đồ chơi trẻ em');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP002', N'Quần áo trẻ em');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP003', N'Sữa và thực phẩm dinh dưỡng');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP004', N'Đồ dùng học tập');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP005', N'Phụ kiện và đồ dùng cho mẹ');
GO
SET DATEFORMAT DMY
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP001','LSP001',N'Sản phẩm 1',CAST(100000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP002','LSP001',N'Sản phẩm 2',CAST(200000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP003','LSP001',N'Sản phẩm 3',CAST(300000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP004','LSP001',N'Sản phẩm 4',CAST(400000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP005','LSP001',N'Sản phẩm 5',CAST(500000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP006','LSP002',N'Sản phẩm 6',CAST(600000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP007','LSP002',N'Sản phẩm 7',CAST(700000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP008','LSP002',N'Sản phẩm 8',CAST(800000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP009','LSP002',N'Sản phẩm 9',CAST(900000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP010','LSP002',N'Sản phẩm 10',CAST(1000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP011','LSP003',N'Sản phẩm 11',CAST(2000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP012','LSP003',N'Sản phẩm 12',CAST(3000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP013','LSP003',N'Sản phẩm 13',CAST(4000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP014','LSP003',N'Sản phẩm 14',CAST(5000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP015','LSP003',N'Sản phẩm 15',CAST(6000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP016','LSP004',N'Sản phẩm 16',CAST(7000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP017','LSP004',N'Sản phẩm 17',CAST(8000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP018','LSP004',N'Sản phẩm 18',CAST(9000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP019','LSP004',N'Sản phẩm 19',CAST(10000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP020','LSP004',N'Sản phẩm 20',CAST(20000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP021','LSP005',N'Sản phẩm 21',CAST(30000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP022','LSP005',N'Sản phẩm 22',CAST(40000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai) VALUES('SP023','LSP005',N'Sản phẩm 23',CAST(50000000 AS DECIMAL(18,2)),100,'4/11/2024','4/2/2025','SP001.jfif',N'Còn hàng')
GO
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC001',N'Nhà cung cấp sữa','0888003346',N'469/32 Nguyễn Kiệm','hoangPhuc@gmail.com')
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC002',N'Nhà cung cấp đồ chơi','0888003345',N'180 Hoa Lan','hoangMy@gmail.com')
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC003',N'Nhà cung cấp tã','0888003347',N'160 Lê Trọng Tấn','minhNhat@gmail.com')
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC004',N'Nhà cung cấp quần áo','0888003348',N'47 Hoa Lan','aiDo@gmail.com')
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC005',N'Nhà cung cấp thuốc','0888003349',N'360 Nguyễn Thái Sơn','khongBiet@gmail.com')
GO
INSERT INTO PhieuDat(maPhieuDat,maNhaCungCap,maNhanVien,ngayLap,soLuong,tongTien,trangThai) VALUES('PD000000001','NCC001','NV001','11/11/2024',2,0,0)

INSERT INTO PhieuDat(maPhieuDat,maNhaCungCap,maNhanVien,ngayLap,soLuong,tongTien,trangThai) VALUES('PD000000002','NCC002','NV002','11/11/2024',2,0,0)
GO
INSERT INTO ChiTietPhieuDat(maPhieuDat,maSanPham,soLuongDat,donGia,tongTien) VALUES('PD000000001','SP001',100,1000000,100000000)
INSERT INTO ChiTietPhieuDat(maPhieuDat,maSanPham,soLuongDat,donGia,tongTien) VALUES('PD000000001','SP002',100,1000000,100000000)

INSERT INTO ChiTietPhieuDat(maPhieuDat,maSanPham,soLuongDat,donGia,tongTien) VALUES('PD000000002','SP003',100,1000000,100000000)
INSERT INTO ChiTietPhieuDat(maPhieuDat,maSanPham,soLuongDat,donGia,tongTien) VALUES('PD000000002','SP004',100,1000000,100000000)
GO
SET DATEFORMAT DMY
INSERT INTO PhieuNhap(maPhieuNhap,maPhieuDat,ngayNhap,tongTien,soLan) VALUES ('PN000000001','PD000000001','12/11/2024',0,1)
INSERT INTO PhieuNhap(maPhieuNhap,maPhieuDat,ngayNhap,tongTien,soLan) VALUES ('PN000000002','PD000000001','13/11/2024',0,2)
GO
INSERT INTO ChiTietPhieuNhap(maPhieuNhap,maPhieuDat,maSanPham,soLuong,donGia,tongTien) VALUES('PN000000001','PD000000001','SP001',10,1000000,10000000)
INSERT INTO ChiTietPhieuNhap(maPhieuNhap,maPhieuDat,maSanPham,soLuong,donGia,tongTien) VALUES('PN000000001','PD000000001','SP002',10,1000000,10000000)

INSERT INTO ChiTietPhieuNhap(maPhieuNhap,maPhieuDat,maSanPham,soLuong,donGia,tongTien) VALUES('PN000000002','PD000000001','SP001',50,1000000,50000000)
INSERT INTO ChiTietPhieuNhap(maPhieuNhap,maPhieuDat,maSanPham,soLuong,donGia,tongTien) VALUES('PN000000002','PD000000001','SP002',50,1000000,50000000)
GO
CREATE PROCEDURE XoaPhieuDat_Proc @maPhieuDat VARCHAR(50)
AS
	DECLARE @maSP VARCHAR(50), @maPN VARCHAR(50)
	--Xóa phiếu nhập
	DECLARE CS_DuyetPhieuNhap CURSOR
	FOR SELECT maPhieuNhap FROM PhieuNhap WHERE maPhieuDat = @maPhieuDat
	OPEN CS_DuyetPhieuNhap
	FETCH NEXT FROM CS_DuyetPhieuNhap INTO @maPN
	WHILE @@FETCH_STATUS = 0 
	BEGIN
		EXEC XoaPhieuNhap_Proc @maPN
		FETCH NEXT FROM CS_DuyetPhieuNhap INTO @maPN
	END
	CLOSE CS_DuyetPhieuNhap
	DEALLOCATE CS_DuyetPhieuNhap
	--Xóa chi tiết phiếu đặt
	DELETE ChiTietPhieuDat WHERE maPhieuDat = @maPhieuDat
	--Xóa phiếu đặt
	DELETE PhieuDat WHERE maPhieuDat = @maPhieuDat
GO
CREATE PROCEDURE XoaPhieuNhap_Proc @maPhieuNhap VARCHAR(50)
AS
	DECLARE @maSP VARCHAR(50), @maPD VARCHAR(50)
	SELECT @maPD = maPhieuDat FROM PhieuNhap WHERE maPhieuNhap = @maPhieuNhap
	--Xóa chi tiết phiếu nhập
	DECLARE CS_DuyetChiTietPhieuNhap CURSOR
	FOR SELECT maSanPham FROM ChiTietPhieuNhap WHERE maPhieuDat = @maPD
	OPEN CS_DuyetChiTietPhieuNhap
	FETCH NEXT FROM CS_DuyetChiTietPhieuNhap INTO @maSP
	WHILE @@FETCH_STATUS = 0 
	BEGIN
		DELETE ChiTietPhieuNhap WHERE maPhieuNhap = @maPhieuNhap AND maSanPham = @maSP	
		FETCH NEXT FROM CS_DuyetChiTietPhieuNhap INTO @maSP	
	END
	CLOSE CS_DuyetChiTietPhieuNhap
	DEALLOCATE CS_DuyetChiTietPhieuNhap
	--Xóa phiếu nhập
	DELETE PhieuNhap WHERE maPhieuNhap = @maPhieuNhap
GO
CREATE PROCEDURE XoaChiTietPhieuDat_Proc @maPhieuDat VARCHAR(50), @maSanPham VARCHAR(50)
AS
	DECLARE @maPN VARCHAR(50)
	DECLARE CS_DuyetChiTietPhieuNhap CURSOR 
	FOR SELECT maPhieuNhap FROM PhieuNhap WHERE maPhieuDat = @maPhieuDat
	OPEN CS_DuyetChiTietPhieuNhap
	FETCH NEXT FROM CS_DuyetChiTietPhieuNhap INTO @maPN
	WHILE @@FETCH_STATUS = 0
	BEGIN
		DELETE ChiTietPhieuNhap WHERE maPhieuNhap = @maPN AND maPhieuDat = @maPhieuDat AND maSanPham = @maSanPham
		FETCH NEXT FROM CS_DuyetChiTietPhieuNhap INTO @maPN
	END
	CLOSE CS_DuyetChiTietPhieuNhap
	DEALLOCATE CS_DuyetChiTietPhieuNhap
	DELETE ChiTietPhieuDat WHERE maPhieuDat = @maPhieuDat AND maSanPham = @maSanPham
GO
CREATE TRIGGER TRG_CapNhatTrangThaiSP ON SanPham
AFTER UPDATE
AS
BEGIN
	DECLARE @soLuong INT,@maSP VARCHAR(50)
	SELECT @soLuong = soLuong, @maSP = maSanPham FROM inserted
	IF(@soLuong=0)
		BEGIN
			UPDATE SanPham
			SET trangThai = 0 
			WHERE maSanPham = @maSP
		END
END
GO
CREATE TRIGGER TRG_ThemChiTietHoaDon ON ChiTietHoaDonSanPham
AFTER INSERT
AS
BEGIN
	DECLARE @maSP VARCHAR(50), @soLuong INT
	SELECT @maSP = maSanPham, @soLuong = soLuong FROM inserted
	--Cập nhật số lượng
	UPDATE SanPham
	SET soLuong = soLuong - @soLuong
	WHERE maSanPham = @maSP
END
GO
CREATE TRIGGER TRG_TaoPhieuNhap ON PhieuNhap
AFTER INSERT
AS
BEGIN
	DECLARE @maPD VARCHAR(50), @ngayLapPhieuNhap DATE, @ngayLapPhieuDat DATE, @trangThai BIT
	SELECT @maPD = maPhieuDat, @ngayLapPhieuNhap = ngayNhap FROM INSERTED
	SELECT @ngayLapPhieuDat = ngayLap, @trangThai = trangThai FROM PhieuDat WHERE maPhieuDat = @maPD
	IF(@trangThai = N'Chưa duyệt')
		ROLLBACK
	IF(@ngayLapPhieuDat >= @ngayLapPhieuNhap)
		ROLLBACK
END
GO
CREATE TRIGGER TRG_TaoChiTietPhieuNhap ON ChiTietPhieuNhap
AFTER INSERT
AS
BEGIN
	DECLARE @maSP VARCHAR(50),@maPD VARCHAR(50), @soLuong INT
	SELECT @maSP = maSanPham, @maPD = maPhieuDat, @soLuong = soLuong FROM INSERTED

	DECLARE @soLuongDaNhan INT, @soLuongDat INT
	SELECT @soLuongDaNhan = soLuongNhan, @soLuongDat = soLuongDat FROM ChiTietPhieuDat WHERE maSanPham = @maSP AND maPhieuDat = @maPD
	IF(@soLuongDaNhan + @soLuong > @soLuongDat)
		ROLLBACK
	ELSE
		BEGIN
			--Cập nhật số lượng mới
			UPDATE SanPham
			SET soLuong = soLuong + @soLuong
			WHERE maSanPham = @maSP
			--Cập nhật số lượng đã nhận
			UPDATE ChiTietPhieuDat
			SET soLuongNhan = soLuongNhan + @soLuong
			WHERE maSanPham = @maSP AND maPhieuDat = @maPD
		END
END
GO
CREATE TRIGGER TRG_SuaChiTietPhieuNhap ON ChiTietPhieuNhap
AFTER UPDATE
AS
BEGIN
	DECLARE @maSP VARCHAR(50),@maPD VARCHAR(50), @soLuongCu INT, @soLuongMoi INT
	SELECT @maSP = maSanPham,  @maPD = maPhieuDat, @soLuongMoi = soLuong FROM INSERTED
	SELECT @soLuongCu = soLuong FROM DELETED

	DECLARE @soLuongDaNhan INT, @soLuongDat INT
	SELECT @soLuongDaNhan = soLuongNhan, @soLuongDat = soLuongDat FROM ChiTietPhieuDat WHERE maSanPham = @maSP AND maPhieuDat = @maPD
	IF(@soLuongDaNhan + @soLuongMoi > @soLuongDat)
		ROLLBACK
	ELSE
		BEGIN
			--Cập nhật số lượng mới
			UPDATE SanPham
			SET soLuong = soLuong - @soLuongCu + @soLuongMoi
			WHERE maSanPham = @maSP
			--Cập nhật số lượng đã nhận
			UPDATE ChiTietPhieuDat
			SET soLuongNhan = soLuongNhan - @soLuongCu + @soLuongMoi
			WHERE maSanPham = @maSP AND maPhieuDat = @maPD
		END
END
GO
CREATE TRIGGER TRG_XoaChiTietPhieuNhap ON ChiTietPhieuNhap
AFTER DELETE
AS
BEGIN
	DECLARE @maSP VARCHAR(50),@maPD VARCHAR(50), @soLuongCu INT
	--DECLARE CS_DuyetChiTietPhieuNhapXoa CURSOR
	SELECT @maSP = maSanPham, @maPD = maPhieuDat, @soLuongCu = soLuong FROM DELETED
	--Cập nhật số lượng mới
	UPDATE SanPham
	SET soLuong = soLuong - @soLuongCu
	WHERE maSanPham = @maSP
	--Cập nhật số lượng đã nhận
	UPDATE ChiTietPhieuDat
	SET soLuongNhan = soLuongNhan - @soLuongCu
	WHERE maPhieuDat = @maPD AND maSanPham = @maSP
END
GO
CREATE TRIGGER TRG_CapNhatXoaPhieuDat ON PhieuDat
AFTER UPDATE ,DELETE
AS
BEGIN
	DECLARE @trangThai NVARCHAR(20)
	SELECT @trangThai = trangThai FROM deleted
	IF(@trangThai = N'Đã duyệt')
		ROLLBACK
END
GO
CREATE TRIGGER TRG_XoaChiTietPhieuDat ON ChiTietPhieuDat
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @maPD VARCHAR(50),@trangThai NVARCHAR(20)
	SELECT @maPD = maPhieuDat FROM deleted
	SELECT @trangThai = trangThai FROM PhieuDat WHERE maPhieuDat = @maPD
	IF(@trangThai = N'Đã duyệt')
		ROLLBACK
END
--CREATE TRIGGER TRG_CapNhatChiTietPhieuDat ON ChiTietPhieuDat
--AFTER UPDATE
--AS
--BEGIN
--	DECLARE @maPD VARCHAR(50), @dem INT = 0,@trangThai BIT, @soLuongSanPhamDat INT
--	SELECT @maPD = maPhieuDat FROM inserted
--	SELECT @soLuongSanPhamDat = soLuong FROM PhieuDat WHERE maPhieuDat = @maPD
--	DECLARE CS_DuyetChiTietPhieuDat CURSOR 
--	FOR SELECT trangThai FROM ChiTietPhieuDat WHERE maPhieuDat = @maPD
--	OPEN CS_DuyetChiTietPhieuDat
--	FETCH NEXT FROM CS_DuyetChiTietPhieuDat INTO @trangThai
--	WHILE @@FETCH_STATUS = 0
--	BEGIN
--		IF(@trangThai = 1)
--			SET @dem = @dem + 1
--		FETCH NEXT FROM CS_DuyetChiTietPhieuDat INTO @trangThai
--	END
--	CLOSE CS_DuyetChiTietPhieuDat
--	DEALLOCATE CS_DuyetChiTietPhieuDat
--	IF(@dem = @soLuongSanPhamDat)
--		BEGIN
--			UPDATE PhieuDat
--			SET trangThai = 1
--			WHERE maPhieuDat = @maPD
--		END
--	ELSE
--		BEGIN
--			UPDATE PhieuDat
--			SET trangThai = 0
--			WHERE maPhieuDat = @maPD
--		END
--END
