CREATE DATABASE MeVaBeDB
go

USE MeVaBeDB
go

CREATE TABLE HangThanhVien (
    maHang VARCHAR(10) PRIMARY KEY,
    tenHang NVARCHAR(100),
    mucTieuDauTu INT,
    mucTieuKetThuc INT,
    ghiChu NVARCHAR(255)
);

CREATE TABLE KhachHang (
    maKhachHang VARCHAR(20) PRIMARY KEY,
    tenKhachHang NVARCHAR(100),
    soDienThoai VARCHAR(15),
    diaChi NVARCHAR(255),
    email NVARCHAR(255),
    maHang VARCHAR(10),
    CONSTRAINT FK_KH_HTV FOREIGN KEY (maHang) REFERENCES HangThanhVien(maHang)
);

CREATE TABLE LoaiNhanVien (
    maLoaiNhanVien VARCHAR(10) PRIMARY KEY,
    tenLoaiNhanVien NVARCHAR(100)
);

CREATE TABLE NhanVien (
    maNhanVien VARCHAR(50) PRIMARY KEY,
    maLoaiNhanVien VARCHAR(10),
    tenNhanVien NVARCHAR(50),
    ngaySinh DATE,
    diaChi NVARCHAR(255),
    soDienThoai VARCHAR(15),
    tenDangNhap NVARCHAR(255),
    matKhau NVARCHAR(255),
    luongCoBan INT,
    ngayVaoLam DATE,
    CONSTRAINT FK_NV_LoaiNV FOREIGN KEY (maLoaiNhanVien) REFERENCES LoaiNhanVien(maLoaiNhanVien)
);

CREATE TABLE NhaCungCap (
    maNhaCungCap VARCHAR(10) PRIMARY KEY,
    tenNhaCungCap NVARCHAR(100),
    soDienThoai VARCHAR(15),
    diaChi NVARCHAR(255),
    email NVARCHAR(255)
);

CREATE TABLE LoaiSanPham (
    maLoaiSanPham VARCHAR(10) PRIMARY KEY,
    tenLoaiSanPham NVARCHAR(100)
);

CREATE TABLE ThuongHieu (
    maThuongHieu VARCHAR(10) PRIMARY KEY,
    tenThuongHieu NVARCHAR(100)
);

CREATE TABLE LuaTuoi (
    maLuaTuoi VARCHAR(10) PRIMARY KEY,
    doTuoi INT
);

CREATE TABLE SanPham (
    maSanPham VARCHAR(50) PRIMARY KEY,
    maLoaiSanPham VARCHAR(10),
    maThuongHieu VARCHAR(10),
    tenSanPham NVARCHAR(100),
    donGiaNhap DECIMAL(18, 2),
    donGiaBan DECIMAL(18, 2),
	donGiaSale DECIMAL(18, 2),
    soLuong INT,
    ngaySanXuat DATE,
    hanSuDung DATE,
    hinhAnh NVARCHAR(255),
    trangThai NVARCHAR(50),
    FOREIGN KEY (maLoaiSanPham) REFERENCES LoaiSanPham(maLoaiSanPham),
    FOREIGN KEY (maThuongHieu) REFERENCES ThuongHieu(maThuongHieu)
);

CREATE TABLE ChiTietLuaTuoi (
    maSanPham VARCHAR(50),
    maLuaTuoi VARCHAR(10),
    PRIMARY KEY (maSanPham, maLuaTuoi),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham),
    FOREIGN KEY (maLuaTuoi) REFERENCES LuaTuoi(maLuaTuoi)
);

CREATE TABLE TonKho (
    maSanPham VARCHAR(50) PRIMARY KEY,
    soLuongTon INT,
    ngayCapNhat DATE,
    soLuongToiThieu INT,
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);

CREATE TABLE HoaDon (
    maHoaDon VARCHAR(50) PRIMARY KEY,
    maKhachHang VARCHAR(20),
    maNhanVien VARCHAR(50),
    ngayLap DATE,
    tongTien DECIMAL(18, 2),
    trangThai BIT,
    FOREIGN KEY (maKhachHang) REFERENCES KhachHang(maKhachHang),
    FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);

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

CREATE TABLE UuDaiThanhVien (
    maUuDai INT PRIMARY KEY,
    tenUuDai NVARCHAR(50),
    giaTriUuDai DECIMAL(5, 2),
    maLoaiSanPham VARCHAR(10),
	maHang VARCHAR(10),
    FOREIGN KEY (maLoaiSanPham) REFERENCES LoaiSanPham(maLoaiSanPham),
	FOREIGN KEY (maHang) REFERENCES HangThanhVien(maHang)
);

CREATE TABLE GoiSanPham (
    maGoiSanPham VARCHAR(50) PRIMARY KEY,
    tenGoiSanPham NVARCHAR(100),
    donGia DECIMAL(18, 2),
    soLuong INT,
    hinhAnh NVARCHAR(255)
);

CREATE TABLE ChiTietGoiSanPham (
    maGoiSanPham VARCHAR(50),
    maSanPham VARCHAR(50),
    donGia DECIMAL(18, 2),
    soLuong INT,
    PRIMARY KEY (maGoiSanPham, maSanPham),
    FOREIGN KEY (maGoiSanPham) REFERENCES GoiSanPham(maGoiSanPham),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);

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

CREATE TABLE PhieuNhap (
    maPhieuNhap VARCHAR(50) PRIMARY KEY,
    maNhanVien VARCHAR(50),
    maNhaCungCap VARCHAR(10),
    ngayLap DATE,
    tongTien DECIMAL(18, 2),
    FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien),
    FOREIGN KEY (maNhaCungCap) REFERENCES NhaCungCap(maNhaCungCap)
);

CREATE TABLE ChiTietPhieuNhap (
    maPhieuNhap VARCHAR(50),
    maSanPham VARCHAR(50),
    soLuong INT,
    donGia DECIMAL(18, 2),
    tongTien DECIMAL(18, 2),
    lanNhap INT,
    PRIMARY KEY (maPhieuNhap, maSanPham),
    FOREIGN KEY (maPhieuNhap) REFERENCES PhieuNhap(maPhieuNhap),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);

CREATE TABLE PhieuThanhLy (
    maThanhLy VARCHAR(50) PRIMARY KEY,
    maNhanVien VARCHAR(50),
    lyDo NVARCHAR(255),
    ngayThanhLy DATE,
    tongTien DECIMAL(18, 2),
    FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);

CREATE TABLE ChiTietPhieuThanhLy (
    maThanhLy VARCHAR(50),
    maSanPham VARCHAR(50),
    soLuong INT,
    giaThanhLy DECIMAL(18, 2),
    PRIMARY KEY (maThanhLy, maSanPham),
    FOREIGN KEY (maThanhLy) REFERENCES PhieuThanhLy(maThanhLy),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);

CREATE TABLE KhuyenMai (
    maKhuyenMai VARCHAR(50) PRIMARY KEY,
    tenKhuyenMai NVARCHAR(100),
    moTa NVARCHAR(255),
    ngayBatDau DATE,
    ngayKetThuc DATE,
    trangThai BIT
);

CREATE TABLE KhuyenMaiSanPham (
    maKhuyenMai VARCHAR(50),
    maSanPham VARCHAR(50),
    phanTramGiam DECIMAL(18, 2),
    trangThai BIT,
    PRIMARY KEY (maKhuyenMai, maSanPham),
    FOREIGN KEY (maKhuyenMai) REFERENCES KhuyenMai(maKhuyenMai),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);

CREATE TABLE PhieuGiaoHang (
    maPhieuGiao VARCHAR(50) PRIMARY KEY,
    maHoaDon VARCHAR(50),
    ngayGiaoDuKien DATE,
    chiPhi DECIMAL(18, 2),
    tinhTrang BIT,
    FOREIGN KEY (maHoaDon) REFERENCES HoaDon(maHoaDon)
);

CREATE TABLE ChiTietPhieuGiaoHang (
    maPhieuGiao VARCHAR(50),
    maSanPham VARCHAR(50),
    soLuong INT,
    donGia DECIMAL(18, 2),
    tongTien DECIMAL(18, 2),
    PRIMARY KEY (maPhieuGiao, maSanPham),
    FOREIGN KEY (maPhieuGiao) REFERENCES PhieuGiaoHang(maPhieuGiao),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);

ALTER TABLE NhanVien
ADD CONSTRAINT UQ_tenDangNhap UNIQUE (tenDangNhap);

INSERT INTO LoaiNhanVien (maLoaiNhanVien, tenLoaiNhanVien) 
VALUES 
('QL', N'Quản Lý'),
('NVBH', N'Nhân Viên Bán Hàng'),
('NVK', N'Nhân Viên Kho');

INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV001', 'QL', N'Phạm Minh Nhật', '2003-11-19', N'254 Đường NVC, TP.HCM', '0775945228', 'minhnhat', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 20000000, '2024-10-01')
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV002', 'QL', N'Đặng Hoàng Phúc', '2003-12-06', N'123 Đường NK, TP.HCM', '0888005346', 'hoangphuc', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 20000000, '2024-10-01')
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV003', 'QL', N'Trương Thị Quí', '2003-01-19', N'123 Đường ABC, TP.HCM', '0901234567', 'truongqui', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 20000000, '2024-10-01');

INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV004', 'NVBH', N'Phạm Minh Nhật', '2003-11-19', N'254 Đường NVC, TP.HCM', '0775945228', 'nvbhminhnhat', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', '1911'), 2), 20000000, '2024-10-01');

