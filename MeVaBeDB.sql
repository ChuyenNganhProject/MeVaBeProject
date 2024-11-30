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
	diemTichLuy DECIMAL(18, 2),
	ngayCapNhatDiem DATE,
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
GO
CREATE TABLE HoaDon (
    maHoaDon VARCHAR(50) PRIMARY KEY,
    maKhachHang VARCHAR(20),
    maNhanVien VARCHAR(50),
    ngayLap DATETIME,
    tongTien DECIMAL(18, 2),
	tienDuocGiam DECIMAL(18, 2),
	tongTienSauGiam DECIMAL(18, 2),
    trangThai BIT,
	hinhThucTra NVARCHAR(50),
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
    maUuDai VARCHAR(10) PRIMARY KEY,
    tenUuDai NVARCHAR(100),
    phanTramGiam DECIMAL(5, 2) CHECK (phanTramGiam >= 0 AND phanTramGiam <= 100), 
	maHang VARCHAR(10),
	FOREIGN KEY (maHang) REFERENCES HangThanhVien(maHang) ON DELETE CASCADE
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
    ngayLap DATETIME,
	ngayCapNhat DATETIME,
	soLuong INT,	
    tongTien DECIMAL(18, 2),
	trangThai NVARCHAR(20),
	trangThaiXacNhan NVARCHAR(20),
	ghiChu NVARCHAR(255),
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
    ngayBatDau DATETIME,
    ngayKetThuc DATETIME,
    trangThai NVARCHAR(50)
);
GO
CREATE TABLE KhuyenMaiSanPham (
    maKhuyenMai VARCHAR(50),
    maSanPham VARCHAR(50),
    phanTramGiam DECIMAL(18, 2),
	soLuongToiDa INT,
    trangThai NVARCHAR(50),
    PRIMARY KEY (maKhuyenMai, maSanPham),
    FOREIGN KEY (maKhuyenMai) REFERENCES KhuyenMai(maKhuyenMai),
    FOREIGN KEY (maSanPham) REFERENCES SanPham(maSanPham)
);
GO
CREATE TABLE PhieuGiaoHang (
    maPhieuGiao VARCHAR(50) PRIMARY KEY,
	maNhanVien VARCHAR(50),
	khachHangNhan NVARCHAR(50),
	soDienThoai VARCHAR(15),
	DiaChiGiaoHang NVARCHAR(255) NOT NULL,
    ngayGiaoDuKien	 DATE,
    chiPhi DECIMAL(18, 2),
    tinhTrang NVARCHAR(50) DEFAULT N'Chưa giao'
	FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);
GO

CREATE TABLE ChiTietPhieuGiaoHang(
	maPhieuGiao VARCHAR(50),
    maHoaDon VARCHAR(50),
    maSanPham VARCHAR(50),
    soLuong INT,
    donGia DECIMAL(18, 2),
    tongTien DECIMAL(18, 2),
    PRIMARY KEY (maPhieuGiao, maHoaDon, maSanPham),
    FOREIGN KEY (maPhieuGiao) REFERENCES PhieuGiaoHang(maPhieuGiao),
    FOREIGN KEY (maHoaDon, maSanPham) REFERENCES ChiTietHoaDonSanPham(maHoaDon, maSanPham)
)
GO
CREATE TABLE PhieuNhap (
    maPhieuNhap VARCHAR(50) PRIMARY KEY,
	maPhieuDat VARCHAR(50),
	maNhanVien VARCHAR(50),
    ngayNhap DATETIME,
	soLan INT,
	tongTien DECIMAL(18,2),
	FOREIGN KEY (maPhieuDat) REFERENCES PhieuDat(maPhieuDat),
	FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien)
);
GO
CREATE TABLE ChiTietPhieuNhap (
    maPhieuNhap VARCHAR(50),
    maSanPham VARCHAR(50),
	maPhieuDat VARCHAR(50),
    soLuong INT,	
    donGia DECIMAL(18,2),
	ngaySanXuat DATE,
	hanSuDung DATE,
	tongTien DECIMAL(18,2),
    PRIMARY KEY (maPhieuDat, maSanPham, maPhieuNhap),
    FOREIGN KEY (maPhieuNhap) REFERENCES PhieuNhap(maPhieuNhap),
    FOREIGN KEY (maPhieuDat,maSanPham) REFERENCES ChiTietPhieuDat(maPhieuDat,maSanPham)
);
GO
CREATE TABLE QuyenHeThong(
	maQuyen VARCHAR(10) PRIMARY KEY,
	tenQuyen NVARCHAR(50)
);
GO
CREATE TABLE ChiTietQuyenCuaLoaiNhanVien(
	maLoaiNhanVien VARCHAR(10),
	maQuyen VARCHAR(10),
	ngayCapQuyen DATE,
	PRIMARY KEY (maLoaiNhanVien, maQuyen),
    FOREIGN KEY (maLoaiNhanVien) REFERENCES LoaiNhanVien(maLoaiNhanVien),
    FOREIGN KEY (maQuyen) REFERENCES QuyenHeThong(maQuyen)
);
GO
ALTER TABLE SanPham
ADD CONSTRAINT SoLuongDefault DEFAULT 0 FOR soLuong

ALTER TABLE SanPham
ADD CONSTRAINT NgaySanXuat_HanSuDung_CK CHECK( ngaySanXuat <= hanSuDung)

ALTER TABLE PhieuDat
ADD CONSTRAINT NgayCapNhatCheck CHECK( ngayLap <= ngayCapNhat)

ALTER TABLE PhieuDat
ADD CONSTRAINT TrangThaiDefault DEFAULT N'Chưa duyệt' FOR trangThai

ALTER TABLE PhieuDat
ADD CONSTRAINT TongTienDefault DEFAULT 0 FOR tongTien

ALTER TABLE ChiTietPhieuDat
ADD CONSTRAINT SoLuongNhanDefault DEFAULT 0 FOR soLuongNhan

ALTER TABLE ChiTietPhieuNhap
ADD CONSTRAINT NgaySanXuatCK CHECK( ngaySanXuat <= hanSuDung)
GO
INSERT INTO QuyenHeThong (maQuyen,tenQuyen) 
VALUES 
	('Q0001',N'Quyền quản lý khách hàng'),
	('Q0002',N'Quyền quản lý hạng thành viên'),
	('Q0003',N'Quyền quản lý loại nhân viên'),
	('Q0004',N'Quyền quản lý nhân viên'),
	('Q0005',N'Quyền quản lý nhà cung cấp'),
	('Q0006',N'Quyền quản lý loại sản phẩm'),
	('Q0007',N'Quyền quản lý sản phẩm'),
	('Q0008',N'Quyền quản lý chương trình khuyến mãi'),
	('Q0009',N'Quyền quản lý đặt hàng'),
	('Q0010',N'Quyền quản lý nhập hàng'),
	('Q0011',N'Quyền duyệt đơn đặt hàng'),
	('Q0012',N'Quyền thống kê'),
	('Q0013',N'Quyền bán hàng'),
	('Q0014',N'Quyền lập phiếu đổi trả hàng'),
	('Q0015',N'Quyền lập phiếu thanh lý'),
	('Q0016',N'Quyền lập phiếu giao hàng')
GO

INSERT INTO LoaiNhanVien (maLoaiNhanVien, tenLoaiNhanVien) 
VALUES 
    (N'LNV001', N'Quản Lý'),
    (N'LNV002', N'Nhân Viên Bán Hàng'),
    (N'LNV003', N'Nhân Viên Kho')
GO
SET DATEFORMAT DMY
INSERT INTO ChiTietQuyenCuaLoaiNhanVien(maLoaiNhanVien,maQuyen,ngayCapQuyen) 
VALUES
	('LNV001','Q0001','21/11/2024'),
	('LNV001','Q0002','21/11/2024'),
	('LNV001','Q0003','21/11/2024'),
	('LNV001','Q0004','21/11/2024'),
	('LNV001','Q0005','21/11/2024'),
	('LNV001','Q0006','21/11/2024'),
	('LNV001','Q0007','21/11/2024'),
	('LNV001','Q0008','21/11/2024'),
	('LNV001','Q0009','21/11/2024'),
	('LNV001','Q0010','21/11/2024'),
	('LNV001','Q0011','21/11/2024'),
	('LNV001','Q0012','21/11/2024'),
	('LNV001','Q0013','21/11/2024'),
	('LNV002','Q0001','21/11/2024'),
	('LNV002','Q0013','21/11/2024'),
	('LNV002','Q0014','21/11/2024'),
	('LNV003','Q0009','21/11/2024'),
	('LNV003','Q0010','21/11/2024'),
	('LNV003','Q0006','21/11/2024'),
	('LNV003','Q0007','21/11/2024')
GO
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV001', 'LNV001', N'Phạm Minh Nhật', '2003-11-19', N'254 Đường NVC, TP.HCM', '0775945228', 'minhnhat', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 20000000, '2024-10-01')
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV002', 'LNV001', N'Đặng Hoàng Phúc', '2003-12-06', N'123 Đường NK, TP.HCM', '0888005346', 'hoangphuc', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 20000000, '2024-10-01')
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV003', 'LNV001', N'Trương Thị Quí', '2003-01-19', N'123 Đường ABC, TP.HCM', '0901234567', 'truongqui', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 20000000, '2024-10-01');
INSERT INTO NhanVien (maNhanVien, maLoaiNhanVien, tenNhanVien, ngaySinh, diaChi, soDienThoai, tenDangNhap, matKhau, luongCoBan, ngayVaoLam) 
VALUES ('NV004', 'LNV002', N'Phạm Minh Nhật', '2003-11-19', N'254 Đường NVC, TP.HCM', '0775945228', 'nvbhminhnhat', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', '1911'), 2), 20000000, '2024-10-01');
GO
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP001', N'Không rõ loại sản phẩm');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP002', N'Đồ chơi, học tập');		
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP003', N'Vitamin - sức khỏe');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP004', N'Thời trang - phụ kiện');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP005', N'Giặt xả quần áo');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP006', N'Thực phẩm chế biến');
GO
SET DATEFORMAT DMY
-- LSP002: Đồ chơi, học tập
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP000001', 'LSP002', N'Robot nhảy múa và xoay chong chóng có nhạc đèn', 215000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Robot_nhay_mua_YN382700_C407.jpg', N'Còn hàng'),
('SP000002', 'LSP002', N'Bộ mô hình xe, máy bay và biển báo', 175000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Bo_mohinhxe_maybay_va_bien_bao_HW24031178_C407.jpg', N'Còn hàng'),
('SP000003', 'LSP002', N'Thú bông capybara cầm lá cây ngộ nghĩnh', 185000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Thu_bong_capybara_cam_la_cay_ngo_nghinh_C407.jpg', N'Còn hàng'),
('SP000004', 'LSP002', N'Bộ đồ chơi nhà tắm', 99000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Bo_do_choi_nha_tam_9pcs_JS048059.jpg', N'Còn hàng'),
('SP000005', 'LSP002', N'Bảng vẽ học tập và bàn chơi cờ', 285000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Bangve_hoctap_va_ban_choi_co_JS028150.jpg', N'Còn hàng'),
('SP000006', 'LSP002', N'Xe lắc cao cấp có nhạc đèn', 765000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Xe_lac_cao_cap_co_nhac_den_QT8068.jpg', N'Còn hàng'),
('SP000007', 'LSP002', N'Xe chòi chân, thăng bằng 4 bánh Animo', 565000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Xe_choi_chan_thang_bang_4_banh_Animo_M5910.jpg', N'Còn hàng'),
('SP000008', 'LSP002', N'Túi xách nhập vai bán kem hình gấu ngộ nghĩnh', 145000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Tui_xach_nhap_vai_ban_kem_hinh_gau_ngo_nghinh_21pcs_CY369198.jpg', N'Còn hàng'),
('SP000009', 'LSP002', N'Gối ôm thú bông chó con tinh nghịch (xanh)', 199000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Goi_om_thu_bong_cho_con_tinh_nghich_xanh.jpg', N'Còn hàng'),
('SP000010', 'LSP002', N'Gặm nướu silicone hình thú Animo (Hình gà con) (Vàng)', 149000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Gam_nuou_silicone_hinh_thu_Animo_Hinh_ga_con_Vang.jpg', N'Còn hàng')
GO
-- LSP003: Vitamin - sức khỏe
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP000011', 'LSP003', N'Thực phẩm bảo vệ sức khoẻ Herbs of Gold Ginkgo Biloba 6000', 450000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/herbs_of_gold_ginkgo_biloba_6000.jpg', N'Còn hàng'),
('SP000012', 'LSP003', N'Thực phẩm bảo vệ sức khoẻ VITAMIN D3 K2 Drops M-SMARTY', 195000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/vitamin_d3_k2_drops_m_smarty.jpg', N'Còn hàng'),
('SP000013', 'LSP003', N'Thực phẩm bổ sung thạch Calci trẻ em NFood hương đào', 175000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/calci_tre_em_nfood_huong_dao.jpg', N'Còn hàng'),
('SP000014', 'LSP003', N'Thực phẩm bổ sung thạch hồng sâm trẻ em NFood', 175000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/thach_hong_sam_tre_em_nfood.jpg', N'Còn hàng'),
('SP000015', 'LSP003', N'Thạch sữa non trẻ em NFood (hương dâu)', 175000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/thach_sua_non_tre_em_nfood_huong_dau.jpg', N'Còn hàng'),
('SP000016', 'LSP003', N'Men vi sinh Synteract Baby Drops Oil 10mL', 345000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/men_vi_sinh_synteract_baby_drops_oil_10ml.jpg', N'Còn hàng'),
('SP000017', 'LSP003', N'Bioamicus Vitamin K2D3', 330000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/bioamicus_vitamin_k2d3.jpg', N'Còn hàng'),
('SP000018', 'LSP003', N'Thực phẩm bảo vệ sức khỏe WELLBABY MULTI-VITAMIN LIQUID', 420000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/wellbaby_multi_vitamin_liquid.jpg', N'Còn hàng'),
('SP000019', 'LSP003', N'Siro Tăng Đề Kháng Bé GADOPAX FORTE', 279000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/siro_tang_de_khang_be_gadopax_forte.jpg', N'Còn hàng'),
('SP000020', 'LSP003', N'Biolizin', 295000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/biolizin.jpg', N'Còn hàng')
GO
-- LSP004: Thời trang - phụ kiện
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP000021', 'LSP004', N'Ba lô trẻ em Space Animo A2307_MN013 (Xanh)', 299000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/balo_tre_em_space_animo_a2307_mn013_xanh.jpg', N'Còn hàng'),
('SP000022', 'LSP004', N'Ba lô bé gái hình thỏ Animo A2307_MN016 (Hồng)', 249000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/balo_be_gai_hinh_tho_animo_a2307_mn016_hong.jpg', N'Còn hàng'),
('SP000023', 'LSP004', N'Ba lô bé trai hình vũ trụ Animo A2307_MN015 (Xanh)', 249000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/balo_be_trai_hinh_vu_tru_animo_a2307_mn015_xanh.jpg', N'Còn hàng'),
('SP000024', 'LSP004', N'Sandal bé trai cao cấp Animo A2301_JK014', 259000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/sandal_be_trai_cao_cap_animo_a2301_jk014.jpg', N'Còn hàng'),
('SP000025', 'LSP004', N'Giày tập đi chút chít Animo BG A2408_MN023', 229000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/giay_tap_di_chut_chit_animo_bg_a2408_mn023.jpg', N'Còn hàng'),
('SP000026', 'LSP004', N'Ba lô bé trai con hà mã Animo A2307_MN017 (Xanh)', 249000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/balo_be_trai_con_ha_ma_animo_a2307_mn017_xanh.jpg', N'Còn hàng'),
('SP000027', 'LSP004', N'Giày bé gái phát sáng Animo A2207_JK047', 269000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/giay_be_gai_phat_sang_animo_a2207_jk047.jpg', N'Còn hàng'),
('SP000028', 'LSP004', N'Giày tập đi Animo A2204_MN004', 165000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/giay_tap_di_animo_a2204_mn004.jpg', N'Còn hàng'),
('SP000029', 'LSP004', N'Đầm bé gái Hoa và Bướm Animo VD1223056', 259000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dam_be_gai_hoa_va_buom_animo_vd1223056.jpg', N'Còn hàng'),
('SP000030', 'LSP004', N'Giày bé gái búp bê Animo A2205_MN001', 269000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/giay_be_gai_bup_be_animo_a2205_mn001.jpg', N'Còn hàng')
GO
-- LSP005: Giặt xả quần áo
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP000031', 'LSP005', N'Nước xả vải Hàn Quốc ConCung Gentle Care hương tươi mát, chai 3L', 185000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_xa_vai_hanquoc_concung_gentle_care_huong_tuoi_mat_chai_3l.jpg', N'Còn hàng'),
('SP000032', 'LSP005', N'Nước Giặt OMO Matic Cửa trên túi 4kg', 209000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_giat_omo_matic_4kg.jpg', N'Còn hàng'),
('SP000033', 'LSP005', N'Dung dịch xả quần áo D-nee 3L/2,8L Tím', 215000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dung_dich_xa_quan_ao_d_nee_tim.jpg', N'Còn hàng'),
('SP000034', 'LSP005', N'Nước xả Downy Hương Huyền bí túi 3L', 241000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_xa_downy_huong_huyen_bi_tui_3l.jpg', N'Còn hàng'),
('SP000035', 'LSP005', N'Nước giặt Ariel hương Downy túi 3.2kg', 236500, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_giat_ariel_huong_downy_tui_3_2kg.jpg', N'Còn hàng'),
('SP000036', 'LSP005', N'Nước giặt xả MaxKleen hương sớm mai túi 3.8kg', 210000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_giat_xa_maxkleen_huong_som_mai_tui_3_8kg.jpg', N'Còn hàng'),
('SP000037', 'LSP005', N'Nước xả Downy Hương nắng mai túi 3L', 236500, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_xa_downy_huong_nang_mai_tui_3l.jpg', N'Còn hàng'),
('SP000038', 'LSP005', N'Nước xả vải Comfort Đậm đặc Hương nước hoa thiên nhiên Bella túi 3.2L', 219000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_xa_vai_comfort_dam_dac_bella.jpg', N'Còn hàng')
GO
-- LSP006 Thực phẩm chế biến
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP000039', 'LSP006', N'Rong biển hữu cơ tách muối cho bé BeBecook', 135000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/rong_bien_huu_co_tach_muoi_cho_be_bebecook.jpg', N'Còn hàng'),
('SP000040', 'LSP006', N'Dầu Sachi Nguyên Chất Thuyền Xưa Ăn Dặm Cho Con 65ml', 96000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dau_sachi_nguyen_chat_thuyen_xua.jpg', N'Còn hàng'),
('SP000041', 'LSP006', N'Dầu mè dinh dưỡng - Thuyền Xưa ăn dặm cho con', 55000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dau_me_thuyen_xua_an_dam.jpg', N'Còn hàng'),
('SP000042', 'LSP006', N'Yến mạch ăn liền Primal 200g', 59000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/yen_mach_an_lien_primal.jpg', N'Còn hàng'),
('SP000043', 'LSP006', N'Yến mạch Úc Primal nguyên cán 200g', 59000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/yen_mach_uc_primal_nguyen_can.jpg', N'Còn hàng'),
('SP000044', 'LSP006', N'Dầu hạt cải nhãn hiệu Simply 1L', 79000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dau_hat_cai_simply.jpg', N'Còn hàng'),
('SP000045', 'LSP006', N'Mì nui trứng Egg Pasta hình chữ cái ABC 90g', 74000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/mi_nui_trung_egg_pasta.jpg', N'Còn hàng'),
('SP000046', 'LSP006', N'Rong biển Rắc cơm Hàn Quốc BADAONE vị Truyền thống', 65000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/rong_bien_rac_com_badaone.jpg', N'Còn hàng')
GO
INSERT INTO HangThanhVien (maHang, tenHang, mucTieuBatDau, mucTieuKetThuc, ghiChu)
VALUES 
    ('HTV001', N'Hạng Thường', 10000, 50000, N'Hạng dành cho khách hàng thường xuyên'),
    ('HTV002', N'Hạng Bạc', 50000, 200000, N'Hạng dành cho khách hàng VIP Bạc'),
    ('HTV003', N'Hạng Vàng', 200000, 500000, N'Hạng dành cho khách hàng VIP Vàng'),
    ('HTV004', N'Hạng Kim Cương', 500000, 1000000, N'Hạng dành cho khách hàng VIP Kim Cương');
GO
-- Thêm dữ liệu vào bảng UuDaiThanhVien
INSERT INTO UuDaiThanhVien (maUuDai, tenUuDai, phanTramGiam, maHang)
VALUES 
    ('UD001', N'Giảm giá 10% toàn bộ sản phẩm', 10, 'HTV003'),
	('UD002', N'Giảm giá 15% toàn bộ sản phẩm', 15, 'HTV004')
GO
INSERT INTO KhachHang (maKhachHang, tenKhachHang, soDienThoai,maHang)
VALUES
    ('KH000001', N'Nguyễn Văn A', '0912345678','HTV001'),
    ('KH000002', N'Lê Thị B', '0912345679','HTV001'),
    ('KH000003', N'Trần Văn C', '0912345680','HTV001');
GO
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC001',N'Nhà cung cấp sữa','0888003346',N'469/32 Nguyễn Kiệm','hoangPhuc@gmail.com')
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC002',N'Nhà cung cấp đồ chơi','0888003345',N'180 Hoa Lan','hoangMy@gmail.com')
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC003',N'Nhà cung cấp tã','0888003347',N'160 Lê Trọng Tấn','minhNhat@gmail.com')
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC004',N'Nhà cung cấp quần áo','0888003348',N'47 Hoa Lan','aiDo@gmail.com')
INSERT INTO NhaCungCap(maNhaCungCap,tenNhaCungCap,soDienThoai,diaChi,email) VALUES('NCC005',N'Nhà cung cấp thuốc','0888003349',N'360 Nguyễn Thái Sơn','khongBiet@gmail.com')
GO
SELECT * FROM SanPham
GO
CREATE PROCEDURE Xoa_LoaiSanPham @maLoaiSP VARCHAR(10)
AS
	UPDATE SanPham
	SET maLoaiSanPham = 'LSP001'
	WHERE maLoaiSanPham = @maLoaiSP

	DELETE LoaiSanPham WHERE maLoaiSanPham = @maLoaiSP
GO
CREATE PROCEDURE XoaPhieuDat_Proc @maPhieuDat VARCHAR(50)
AS
	--Xóa chi tiết phiếu đặt
	DELETE ChiTietPhieuDat WHERE maPhieuDat = @maPhieuDat
	--Xóa phiếu đặt
	DELETE PhieuDat WHERE maPhieuDat = @maPhieuDat
GO
CREATE TRIGGER trg_DeleteHoaDonOnKhachHangDelete
ON KhachHang
AFTER DELETE
AS
BEGIN
    -- Delete related records in DonHang
    DELETE FROM HoaDon
    WHERE maKhachHang IN (SELECT maKhachHang FROM deleted);
END;
GO
CREATE TRIGGER TRG_CapNhatTrangThaiSP ON SanPham
AFTER UPDATE, INSERT 
AS
BEGIN
	DECLARE @soLuong INT,@maSP VARCHAR(50)
	SELECT @soLuong = soLuong, @maSP = maSanPham FROM inserted
	IF(@soLuong=0)
		BEGIN
			UPDATE SanPham
			SET trangThai = N'Hết hàng' 
			WHERE maSanPham = @maSP
		END
END
GO
CREATE TRIGGER TRG_TaoPhieuNhap ON PhieuNhap
AFTER INSERT
AS
BEGIN
	DECLARE @maPD VARCHAR(50), @ngayLapPhieuNhap DATETIME, @ngayLapPhieuDat DATETIME, @trangThai NVARCHAR(20), @trangThaiXacNhan NVARCHAR(20)
	SELECT @maPD = maPhieuDat, @ngayLapPhieuNhap = ngayNhap FROM INSERTED
	SELECT @ngayLapPhieuDat = ngayLap, @trangThai = trangThai, @trangThaiXacNhan = trangThaiXacNhan FROM PhieuDat WHERE maPhieuDat = @maPD
	IF(@trangThai = N'Chưa duyệt' OR @trangThai = N'Không duyệt')
		ROLLBACK
	IF(@trangThai = N'Đã duyệt' AND @trangThaiXacNhan = N'Chưa chấp thuận')
		ROLLBACK
	IF(@ngayLapPhieuDat >= @ngayLapPhieuNhap)
		ROLLBACK
END
GO
ALTER TRIGGER TRG_TaoChiTietPhieuNhap ON ChiTietPhieuNhap
AFTER INSERT
AS
BEGIN
	DECLARE @maSP VARCHAR(50),@maPD VARCHAR(50), @soLuong INT, @ngaySanXuat DATE, @hanSuDung DATE
	SELECT @maSP = maSanPham, @maPD = maPhieuDat, @soLuong = soLuong, @ngaySanXuat = ngaySanXuat, @hanSuDung = hanSuDung FROM INSERTED

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
			--Cập nhật ngày sản xuất
			UPDATE SanPham
			SET ngaySanXuat = @ngaySanXuat
			WHERE maSanPham = @maSP
			--Cập nhật hạn sử dụng
			UPDATE SanPham
			SET hanSuDung = @hanSuDung
			WHERE maSanPham = @maSP
			--Cập nhật số lượng đã nhận
			UPDATE ChiTietPhieuDat
			SET soLuongNhan = soLuongNhan + @soLuong
			WHERE maSanPham = @maSP AND maPhieuDat = @maPD
		END
END
GO
CREATE TRIGGER TRG_ResetDiemTichLuySau1Nam
ON KhachHang
AFTER UPDATE
AS
BEGIN
	UPDATE KhachHang
	SET diemTichLuy = 0
	WHERE DATEDIFF(YEAR, ngayCapNhatDiem, GETDATE()) >= 1
END
GO
CREATE TRIGGER TRG_CapNhatSoLuongSanPhamSauKhiThanhToan
ON ChiTietHoaDonSanPham
AFTER INSERT
AS
BEGIN
    -- Cập nhật số lượng sản phẩm trong bảng SanPham
    UPDATE SanPham
    SET soLuong = SanPham.soLuong - i.soLuong
    FROM inserted i
    WHERE SanPham.maSanPham = i.maSanPham;
END;

GO
CREATE PROCEDURE sp_UpdateTrangThaiKhuyenMai
AS
BEGIN
    DECLARE @tgHienTai DATETIME = GETDATE();

    -- Cập nhật trạng thái của khuyến mãi, bỏ qua khuyến mãi đã có trạng thái 'Đã kết thúc'
    UPDATE KhuyenMai
	SET trangThai = N'Đang diễn ra'
	WHERE @tgHienTai >= ngayBatDau 
	  AND @tgHienTai <= ngayKetThuc 
	  AND (trangThai IS NULL OR trangThai NOT IN (N'Đã kết thúc'));

	UPDATE KhuyenMai
	SET trangThai = N'Chưa diễn ra'
	WHERE @tgHienTai < ngayBatDau
	  AND (trangThai IS NULL OR trangThai NOT IN (N'Đã kết thúc'));

	UPDATE KhuyenMai
	SET trangThai = N'Đã kết thúc'
	WHERE @tgHienTai > ngayKetThuc
	  AND (trangThai IS NULL OR trangThai NOT IN (N'Đã kết thúc'));


    -- Cập nhật trạng thái của KhuyenMaiSanPham khi KhuyenMai chuyển sang 'Đã kết thúc'
    UPDATE KhuyenMaiSanPham
    SET trangThai = N'Hết hiệu lực'
    WHERE maKhuyenMai IN (
        SELECT maKhuyenMai
        FROM KhuyenMai
        WHERE trangThai = N'Đã kết thúc'
    );

    -- Cập nhật trạng thái của KhuyenMaiSanPham khi KhuyenMai chuyển sang 'Đang diễn ra'
    UPDATE KhuyenMaiSanPham
    SET trangThai = N'Có hiệu lực'
    WHERE maKhuyenMai IN (
        SELECT maKhuyenMai
        FROM KhuyenMai
        WHERE trangThai = N'Đang diễn ra'
    );

    -- Cập nhật donGiaSale cho sản phẩm thuộc khuyến mãi đang diễn ra
    UPDATE SanPham
    SET donGiaSale = donGiaBan - (donGiaBan * kmsp.phanTramGiam / 100)
    FROM SanPham sp
    JOIN KhuyenMaiSanPham kmsp ON sp.maSanPham = kmsp.maSanPham
    JOIN KhuyenMai km ON kmsp.maKhuyenMai = km.maKhuyenMai
    WHERE km.trangThai = N'Đang diễn ra';

    -- Cập nhật donGiaSale của SanPham thành NULL khi KhuyenMai kết thúc
	UPDATE SanPham
	SET donGiaSale = NULL
	WHERE maSanPham IN (
    SELECT kmsp.maSanPham
    FROM KhuyenMaiSanPham kmsp
    LEFT JOIN KhuyenMai km ON kmsp.maKhuyenMai = km.maKhuyenMai
    WHERE kmsp.maSanPham = SanPham.maSanPham
      AND NOT EXISTS (
          SELECT 1
          FROM KhuyenMai km2
          JOIN KhuyenMaiSanPham kmsp2 ON km2.maKhuyenMai = kmsp2.maKhuyenMai
          WHERE km2.trangThai = N'Đang diễn ra'
            AND kmsp2.maSanPham = kmsp.maSanPham
      )
	);
END
GO

CREATE TRIGGER TRG_UpdateDonGiaSaleKhiDungThuCong
ON KhuyenMai
AFTER UPDATE
AS
BEGIN
	UPDATE SanPham
	SET donGiaSale = NULL
	FROM inserted i
	WHERE i.trangThai = N'Đã kết thúc'
END

SELECT * FROM SanPham
SELECT * FROM KhuyenMai
SELECT * FROM KhuyenMaiSanPham


GO
--CREATE TRIGGER trg_UpdateHangThanhVien
--ON HoaDon
--AFTER INSERT, UPDATE, DELETE
--AS
--BEGIN
--    DECLARE @maKhachHang VARCHAR(20);
--    DECLARE @tongChiTieu DECIMAL(18, 2);
--    DECLARE @maHangMoi VARCHAR(10);
--    DECLARE @mucTieuDauTu DECIMAL(18, 2);
--    DECLARE @mucTieuKetThuc DECIMAL(18, 2);
    
--    -- Lấy mã khách hàng từ hóa đơn đã thêm, sửa hoặc xóa
--    SELECT @maKhachHang = maKhachHang FROM inserted; -- Đối với INSERT và UPDATE
--    -- Trong trường hợp DELETE, lấy từ deleted
--    IF (@maKhachHang IS NULL)
--    BEGIN
--        SELECT @maKhachHang = maKhachHang FROM deleted;
--    END

--    -- Tính tổng chi tiêu của khách hàng dựa trên tất cả hóa đơn của họ (chỉ tính các hóa đơn đã hoàn tất)
--    SELECT @tongChiTieu = SUM(tongTien)
--    FROM HoaDon
--    WHERE maKhachHang = @maKhachHang AND trangThai = 1; -- Chỉ tính hóa đơn đã hoàn tất

--    -- Nếu tổng chi tiêu là NULL (không có hóa đơn hợp lệ), gán giá trị là 0
--    IF @tongChiTieu IS NULL
--    BEGIN
--        SET @tongChiTieu = 0;
--    END

--    -- Lấy thông tin các hạng thành viên từ bảng HangThanhVien
--    -- Kiểm tra nếu tổng chi tiêu nằm trong khoảng mục tiêu đầu tư và mục tiêu kết thúc của từng hạng thành viên
--    SELECT TOP 1 @maHangMoi = maHang
--    FROM HangThanhVien
--    WHERE @tongChiTieu >= mucTieuBatDau AND @tongChiTieu <= mucTieuKetThuc
--    ORDER BY mucTieuBatDau ASC; -- Lấy hạng phù hợp nhất từ đầu đến cuối (nếu có)

--    -- Nếu không có hạng nào trong phạm vi chi tiêu, chọn hạng đầu tiên hoặc cuối cùng
--    IF @maHangMoi IS NULL
--    BEGIN
--        -- Nếu tổng chi tiêu nhỏ hơn mức tiêu chí của hạng đầu tiên, gán hạng đầu tiên
--        SELECT TOP 1 @maHangMoi = maHang
--        FROM HangThanhVien
--        ORDER BY mucTieuBatDau ASC; -- Lấy hạng đầu tiên

--        -- Nếu tổng chi tiêu lớn hơn hoặc bằng mức tiêu chí cuối cùng, gán hạng cuối cùng
--        IF @tongChiTieu >= (SELECT MAX(mucTieuKetThuc) FROM HangThanhVien)
--        BEGIN
--            SELECT TOP 1 @maHangMoi = maHang
--            FROM HangThanhVien
--            ORDER BY mucTieuKetThuc DESC; -- Lấy hạng cuối cùng
--        END
--    END

--    -- Kiểm tra nếu hạng thành viên mới khác hạng cũ, thì cập nhật hạng thành viên cho khách hàng
--    IF @maHangMoi IS NOT NULL
--    BEGIN
--        -- Cập nhật hạng thành viên chỉ khi cần thiết (không ghi đè nếu hạng cũ đã đúng)
--        UPDATE KhachHang
--        SET maHang = @maHangMoi
--        WHERE maKhachHang = @maKhachHang AND maHang <> @maHangMoi;
--    END
--END;