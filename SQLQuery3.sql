CREATE TABLE TroCap (
    MaTroCap INT IDENTITY(1,1) PRIMARY KEY,
    TenTroCap NVARCHAR(50),
    MaNhanVien INT,
    SoTienTrCap DECIMAL(18,2),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE KhauTru (
    MaKhauTru INT IDENTITY(1,1) PRIMARY KEY,
    TenKhauTru NVARCHAR(50),
    MaNhanVien INT,
    SoTienKhauTru DECIMAL(18,2),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

SELECT * FROM TroCap