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
    tongTien DECIMAL(18, 2),
	tienDuocGiam DECIMAL(18, 2),
	tongTienSauGiam DECIMAL(18, 2),
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


INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP001', N'Đồ chơi, học tập');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP002', N'Vitamin - sức khỏe');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP003', N'Thời trang - phụ kiện');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP004', N'Giặt xả quần áo');
INSERT INTO LoaiSanPham (maLoaiSanPham, tenLoaiSanPham) VALUES ('LSP005', N'Thực phẩm chế biến');
 
GO
SET DATEFORMAT DMY
-- LSP006: Đồ chơi, học tập
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP001', 'LSP001', N'Robot nhảy múa và xoay chong chóng có nhạc đèn', 215000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Robot_nhay_mua_YN382700_C407.jpg', N'Còn hàng'),
('SP002', 'LSP001', N'Bộ mô hình xe, máy bay và biển báo', 175000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Bo_mohinhxe_maybay_va_bien_bao_HW24031178_C407.jpg', N'Còn hàng'),
('SP003', 'LSP001', N'Thú bông capybara cầm lá cây ngộ nghĩnh', 185000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Thu_bong_capybara_cam_la_cay_ngo_nghinh_C407.jpg', N'Còn hàng'),
('SP004', 'LSP001', N'Bộ đồ chơi nhà tắm', 99000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Bo_đo_choi_nha_tam_9pcs_JS048059.jpg', N'Còn hàng'),
('SP005', 'LSP001', N'Bảng vẽ học tập và bàn chơi cờ', 285000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Bangve_hoctap_va_ban_choi_co_JS028150.jpg', N'Còn hàng'),
('SP006', 'LSP001', N'Xe lắc cao cấp có nhạc đèn', 765000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Xe_lac_cao_cap_co_nhac_den_QT8068.jpg', N'Còn hàng'),
('SP007', 'LSP001', N'Xe chòi chân, thăng bằng 4 bánh Animo', 565000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Xe_choi_chan_thang_bang_4_banh_Animo_M5910.jpg', N'Còn hàng'),
('SP008', 'LSP001', N'Túi xách nhập vai bán kem hình gấu ngộ nghĩnh', 145000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Tui_xach_nhap_vai_ban_kem_hinh_gau_ngo_nghinh_21pcs_CY369198.jpg', N'Còn hàng'),
('SP009', 'LSP001', N'Gối ôm thú bông chó con tinh nghịch (xanh)', 199000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Goi_om_thu_bong_cho_con_tinh_nghich_xanh.jpg', N'Còn hàng'),
('SP010', 'LSP001', N'Gặm nướu silicone hình thú Animo (Hình gà con) (Vàng)', 149000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/Gam_nuou_silicone_hinh_thu_Animo_Hinh_ga_con_Vang.jpg', N'Còn hàng')

-- LSP007: Vitamin - sức khỏe
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP011', 'LSP002', N'Thực phẩm bảo vệ sức khoẻ Herbs of Gold Ginkgo Biloba 6000', 450000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/herbs_of_gold_ginkgo_biloba_6000.jpg', N'Còn hàng'),
('SP012', 'LSP002', N'Thực phẩm bảo vệ sức khoẻ VITAMIN D3 K2 Drops M-SMARTY', 195000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/vitamin_d3_k2_drops_m_smarty.jpg', N'Còn hàng'),
('SP013', 'LSP002', N'Thực phẩm bổ sung thạch Calci trẻ em NFood hương đào', 175000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/calci_tre_em_nfood_huong_dao.jpg', N'Còn hàng'),
('SP014', 'LSP002', N'Thực phẩm bổ sung thạch hồng sâm trẻ em NFood', 175000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/thach_hong_sam_tre_em_nfood.jpg', N'Còn hàng'),
('SP015', 'LSP002', N'Thạch sữa non trẻ em NFood (hương dâu)', 175000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/thach_sua_non_tre_em_nfood_huong_dau.jpg', N'Còn hàng'),
('SP016', 'LSP002', N'Men vi sinh Synteract Baby Drops Oil 10mL', 345000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/men_vi_sinh_synteract_baby_drops_oil_10ml.jpg', N'Còn hàng'),
('SP017', 'LSP002', N'Bioamicus Vitamin K2D3', 330000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/bioamicus_vitamin_k2d3.jpg', N'Còn hàng'),
('SP018', 'LSP002', N'Thực phẩm bảo vệ sức khỏe WELLBABY MULTI-VITAMIN LIQUID', 420000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/wellbaby_multi_vitamin_liquid.jpg', N'Còn hàng'),
('SP019', 'LSP002', N'Siro Tăng Đề Kháng Bé GADOPAX FORTE', 279000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/siro_tang_de_khang_be_gadopax_forte.jpg', N'Còn hàng'),
('SP020', 'LSP002', N'Biolizin', 295000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/biolizin.jpg', N'Còn hàng')

-- LSP008: Thời trang - phụ kiện
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP021', 'LSP003', N'Ba lô trẻ em Space Animo A2307_MN013 (Xanh)', 299000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/balo_tre_em_space_animo_a2307_mn013_xanh.jpg', N'Còn hàng'),
('SP022', 'LSP003', N'Ba lô bé gái hình thỏ Animo A2307_MN016 (Hồng)', 249000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/balo_be_gai_hinh_tho_animo_a2307_mn016_hong.jpg', N'Còn hàng'),
('SP023', 'LSP003', N'Ba lô bé trai hình vũ trụ Animo A2307_MN015 (Xanh)', 249000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/balo_be_trai_hinh_vu_tru_animo_a2307_mn015_xanh.jpg', N'Còn hàng'),
('SP024', 'LSP003', N'Sandal bé trai cao cấp Animo A2301_JK014', 259000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/sandal_be_trai_cao_cap_animo_a2301_jk014.jpg', N'Còn hàng'),
('SP025', 'LSP003', N'Giày tập đi chút chít Animo BG A2408_MN023', 229000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/giay_tap_di_chut_chit_animo_bg_a2408_mn023.jpg', N'Còn hàng'),
('SP026', 'LSP003', N'Ba lô bé trai con hà mã Animo A2307_MN017 (Xanh)', 249000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/balo_be_trai_con_ha_ma_animo_a2307_mn017_xanh.jpg', N'Còn hàng'),
('SP027', 'LSP003', N'Giày bé gái phát sáng Animo A2207_JK047', 269000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/giay_be_gai_phat_sang_animo_a2207_jk047.jpg', N'Còn hàng'),
('SP028', 'LSP003', N'Giày tập đi Animo A2204_MN004', 165000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/giay_tap_di_animo_a2204_mn004.jpg', N'Còn hàng'),
('SP029', 'LSP003', N'Đầm bé gái Hoa và Bướm Animo VD1223056', 259000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dam_be_gai_hoa_va_buom_animo_vd1223056.jpg', N'Còn hàng'),
('SP030', 'LSP003', N'Giày bé gái búp bê Animo A2205_MN001', 269000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/giay_be_gai_bup_be_animo_a2205_mn001.jpg', N'Còn hàng')

-- LSP009: Giặt xả quần áo
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP031', 'LSP004', N'Nước xả vải Hàn Quốc ConCung Gentle Care hương tươi mát, chai 3L', 185000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_xa_vai_hanquoc_concung_gentle_care_huong_tuoi_mat_chai_3l.jpg', N'Còn hàng'),
('SP032', 'LSP004', N'Nước Giặt OMO Matic Cửa trên túi 4kg', 209000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_giat_omo_matic_4kg.jpg', N'Còn hàng'),
('SP033', 'LSP004', N'Dung dịch xả quần áo D-nee 3L/2,8L Tím', 215000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dung_dich_xa_quan_ao_d_nee_tim.jpg', N'Còn hàng'),
('SP034', 'LSP004', N'Nước xả Downy Hương Huyền bí túi 3L', 241000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_xa_downy_huong_huyen_bi_tui_3l.jpg', N'Còn hàng'),
('SP035', 'LSP004', N'Nước giặt Ariel hương Downy túi 3.2kg', 236500, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_giat_ariel_huong_downy_tui_3_2kg.jpg', N'Còn hàng'),
('SP036', 'LSP004', N'Nước giặt xả MaxKleen hương sớm mai túi 3.8kg', 210000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_giat_xa_maxkleen_huong_som_mai_tui_3_8kg.jpg', N'Còn hàng'),
('SP037', 'LSP004', N'Nước xả Downy Hương nắng mai túi 3L', 236500, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_xa_downy_huong_nang_mai_tui_3l.jpg', N'Còn hàng'),
('SP038', 'LSP004', N'Nước xả vải Comfort Đậm đặc Hương nước hoa thiên nhiên Bella túi 3.2L', 219000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/nuoc_xa_vai_comfort_dam_dac_bella.jpg', N'Còn hàng')
-- LSP010: Thực phẩm chế biến
INSERT INTO SanPham (maSanPham,maLoaiSanPham,tenSanPham,donGiaBan,soLuong,ngaySanXuat,hanSuDung,hinhAnh,trangThai)
VALUES 
('SP039', 'LSP005', N'Rong biển hữu cơ tách muối cho bé BeBecook', 135000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/rong_bien_huu_co_tach_muoi_cho_be_bebecook.jpg', N'Còn hàng'),
('SP040', 'LSP005', N'Dầu Sachi Nguyên Chất Thuyền Xưa Ăn Dặm Cho Con 65ml', 96000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dau_sachi_nguyen_chat_thuyen_xua.jpg', N'Còn hàng'),
('SP041', 'LSP005', N'Dầu mè dinh dưỡng - Thuyền Xưa ăn dặm cho con', 55000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dau_me_thuyen_xua_an_dam.jpg', N'Còn hàng'),
('SP042', 'LSP005', N'Yến mạch ăn liền Primal 200g', 59000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/yen_mach_an_lien_primal.jpg', N'Còn hàng'),
('SP043', 'LSP005', N'Yến mạch Úc Primal nguyên cán 200g', 59000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/yen_mach_uc_primal_nguyen_can.jpg', N'Còn hàng'),
('SP044', 'LSP005', N'Dầu hạt cải nhãn hiệu Simply 1L', 79000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/dau_hat_cai_simply.jpg', N'Còn hàng'),
('SP045', 'LSP005', N'Mì nui trứng Egg Pasta hình chữ cái ABC 90g', 74000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/mi_nui_trung_egg_pasta.jpg', N'Còn hàng'),
('SP046', 'LSP005', N'Rong biển Rắc cơm Hàn Quốc BADAONE vị Truyền thống', 65000, 250, '2024-01-01', '4/2/2025', 'PicSanPham/rong_bien_rac_com_badaone.jpg', N'Còn hàng')

INSERT INTO HangThanhVien (maHang, tenHang, mucTieuBatDau, mucTieuKetThuc, ghiChu)
VALUES 
('MEMBER', N'Thành viên thường', 0, 9999999, N'Không yêu cầu chi tiêu cụ thể'),
('VIPGOLD', N'VIP GOLD', 10000000, 39999999, N'Yêu cầu chi tiêu từ 10-40 triệu trong 1 năm'),
('VIPDIAMOND', N'VIP DIAMOND', 40000000, NULL, N'Chi tiêu 40 triệu hoặc thêm 30 triệu từ VIP GOLD');

-- Thêm dữ liệu vào bảng UuDaiThanhVien
INSERT INTO UuDaiThanhVien (maUuDai, tenUuDai, phanTramGiam, maHang)
VALUES 
    ('UD001', N'Giảm giá 10% toàn bộ sản phẩm', 10, 'VIPGOLD'),
	('UD002', N'Giảm giá 15% toàn bộ sản phẩm', 15, 'VIPDIAMOND')
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

SELECT * FROM SanPham

CREATE PROCEDURE XoaPhieuDat_Proc @maPhieuDat VARCHAR(50)
AS
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
