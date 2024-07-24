USE [master]
GO
/****** Object:  Database [QL_BANHANG]    Script Date: 6/17/2024 1:33:30 AM ******/
CREATE DATABASE [QL_BANHANG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_BANHANG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QL_BANHANG.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_BANHANG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QL_BANHANG_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QL_BANHANG] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_BANHANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_BANHANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_BANHANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_BANHANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_BANHANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_BANHANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_BANHANG] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_BANHANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_BANHANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_BANHANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_BANHANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_BANHANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_BANHANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_BANHANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_BANHANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_BANHANG] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_BANHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_BANHANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_BANHANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_BANHANG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_BANHANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_BANHANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_BANHANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_BANHANG] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_BANHANG] SET  MULTI_USER 
GO
ALTER DATABASE [QL_BANHANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_BANHANG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_BANHANG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_BANHANG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_BANHANG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_BANHANG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QL_BANHANG] SET QUERY_STORE = ON
GO
ALTER DATABASE [QL_BANHANG] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QL_BANHANG]
GO
/****** Object:  Table [dbo].[HANG]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANG](
	[MaHang] [int] IDENTITY(1,1) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGiaBan] [float] NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
	[HinhAnh] [varchar](400) NOT NULL,
	[GhiChu] [nvarchar](20) NOT NULL,
	[MaNV] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[DienThoai] [nvarchar](15) NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[Phai] [nvarchar](5) NOT NULL,
	[MaNV] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DienThoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[VaiTro] [tinyint] NOT NULL,
	[TinhTrang] [tinyint] NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HANG]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HANG] CHECK CONSTRAINT [FK_NHANVIEN_MaNV]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_MaNV_KH] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_NHANVIEN_MaNV_KH]
GO
/****** Object:  StoredProcedure [dbo].[CapNhatKhachHang]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục sửa khách hàng
CREATE   PROC [dbo].[CapNhatKhachHang]
	@DienThoai NVARCHAR(15),
    @TenKhachHang NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @Phai NVARCHAR(20)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		UPDATE KHACHHANG
		SET TenKhachHang = @TenKhachHang,
			DiaChi = @DiaChi,
			Phai = @Phai
		WHERE DienThoai = @DienThoai

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
        THROW;
	END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[CapNhatMatKhau]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Đổi mật khẩu sau khi sử dụng chức năng quên mật khẩu
CREATE   PROCEDURE [dbo].[CapNhatMatKhau]
    @Email NVARCHAR(50),
    @MatKhauMoi NVARCHAR(50)
AS
BEGIN
    UPDATE NHANVIEN   
    SET MatKhau = @MatKhauMoi
    WHERE Email = @Email;
END
select * from NHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[CapNhatSanPham]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục cập nhật sản phẩm
CREATE   PROC [dbo].[CapNhatSanPham]
	@MaHang INT,
    @TenHang NVARCHAR(50),
    @SoLuong INT,
    @DonGiaBan FLOAT,
    @DonGiaNhap FLOAT,
    @HinhAnh VARCHAR(400),
    @GhiChu NVARCHAR(20)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		UPDATE HANG
		SET TenHang = @TenHang,
			SoLuong = @SoLuong,
			DonGiaBan = @DonGiaBan,
			DonGiaNhap = @DonGiaNhap,
			HinhAnh = @HinhAnh,
			GhiChu = @GhiChu
		WHERE MaHang = @MaHang

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
        THROW;
	END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục đăng nhập
CREATE   PROC [dbo].[DangNhap]
    @Email NVARCHAR(50),
    @MatKhau NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem có bản ghi nào khớp với email và mật khẩu không
    IF EXISTS (SELECT 1 FROM NHANVIEN WHERE Email = @Email AND MatKhau = @MatKhau)
    BEGIN
        DECLARE @VaiTro TINYINT
        DECLARE @TinhTrang TINYINT

        SELECT @VaiTro = VaiTro,
               @TinhTrang = TinhTrang
        FROM NHANVIEN
        WHERE Email = @Email AND MatKhau = @MatKhau

        IF @TinhTrang = 0
        BEGIN
            PRINT N'Tài khoản không hoạt động.'
            RETURN -2; 
        END
        ELSE IF @VaiTro = 1
        BEGIN
            PRINT N'Quản lý.'
            RETURN 1; 
        END
        ELSE
        BEGIN
            PRINT N'Nhân viên.'
            RETURN 0; 
        END
    END
    ELSE
    BEGIN
        PRINT N'Tài khoản mật khẩu không chính xác.'
        RETURN -1; 
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[DoiMatKhau]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Đổi mật khẩu
CREATE   PROCEDURE [dbo].[DoiMatKhau]
    @Email NVARCHAR(50),
    @MatKhauCu NVARCHAR(50),
    @MatKhauMoi NVARCHAR(50),
    @NhapLaiMatKhauMoi NVARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN
        -- Kiểm tra xem email và mật khẩu cũ có khớp với thông tin trong cơ sở dữ liệu không
        IF EXISTS (
            SELECT 1
            FROM NHANVIEN
            WHERE Email = @Email AND MatKhau = @MatKhauCu
        )
        BEGIN
			-- Kiểm tra mật khẩu mới và nhập lại mật khẩu mới có khớp không
			IF @MatKhauMoi != @NhapLaiMatKhauMoi
			BEGIN
				PRINT N'Mật khẩu mới và nhập lại mật khẩu mới không khớp.'
				ROLLBACK TRANSACTION;
				RETURN -2;
			END
            -- Cập nhật mật khẩu mới
            UPDATE NHANVIEN
            SET MatKhau = @MatKhauMoi
            WHERE Email = @Email;

            COMMIT TRANSACTION;
            PRINT N'Đổi mật khẩu thành công.';
			RETURN 1;
        END
        ELSE
        BEGIN
            PRINT N'Email hoặc mật khẩu cũ không đúng.';
            ROLLBACK TRANSACTION;
			RETURN -1;
        END
    END
END
GO
/****** Object:  StoredProcedure [dbo].[HienThiKhachHang]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục hiển thị khách hàng
CREATE   PROC [dbo].[HienThiKhachHang]
AS
BEGIN
	SELECT DienThoai, TenKhachHang, DiaChi, Phai, MaNV FROM KHACHHANG;
END;
GO
/****** Object:  StoredProcedure [dbo].[HienThiNhanVien]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[HienThiNhanVien]
AS
BEGIN
	SELECT ID, MaNV, Email, TenNV, DiaChi, VaiTro, TinhTrang, MatKhau FROM NHANVIEN;
END;
GO
/****** Object:  StoredProcedure [dbo].[HienThiSanPham]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục hiển thị sản phẩm
CREATE   PROC [dbo].[HienThiSanPham]
AS
BEGIN
	SELECT MaHang, TenHang, SoLuong, DonGiaBan, DonGiaNhap, HinhAnh, GhiChu, MaNV FROM HANG
END;
GO
/****** Object:  StoredProcedure [dbo].[KiemTraTonTaiEmail]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Kiểm tra tồn tại của email
CREATE   PROCEDURE [dbo].[KiemTraTonTaiEmail]
    @Email NVARCHAR(50)
AS
BEGIN
     BEGIN TRAN
        IF EXISTS (
            SELECT 1
            FROM NHANVIEN
            WHERE Email = @Email
        )
        BEGIN
            -- Email tồn tại trong cơ sở dữ liệu
            PRINT 'Email tồn tại'
			COMMIT TRAN
			RETURN 1;
        END
        ELSE
        BEGIN
            -- Email không tồn tại trong cơ sở dữ liệu
            PRINT 'Email không tồn tại' 
			ROLLBACK TRAN;
			RETURN 0;
        END
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNV]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục Update nhân viên
CREATE   PROCEDURE [dbo].[SuaNV]
    @Email NVARCHAR(50),
    @TenNV NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @VaiTro TINYINT,
    @TinhTrang TINYINT,
    @MatKhau NVARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Kiểm tra mật khẩu không rỗng
        IF @MatKhau IS NULL OR LEN(@MatKhau) = 0
        BEGIN
            PRINT N'Mật khẩu không được để trống.';
            ROLLBACK TRANSACTION;
            RETURN;
        END
        
        -- Kiểm tra xem nhân viên có tồn tại không
        IF EXISTS (SELECT 1 FROM NHANVIEN WHERE Email = @Email)
        BEGIN
            -- Cập nhật thông tin của nhân viên
            UPDATE NHANVIEN
            SET 
                TenNV = @TenNV,
                DiaChi = @DiaChi,
                VaiTro = @VaiTro,
                TinhTrang = @TinhTrang,
                MatKhau = @MatKhau
            WHERE Email = @Email;

            PRINT N'Cập nhật thông tin nhân viên thành công.';
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT N'Không tìm thấy nhân viên với địa chỉ email đã cung cấp.';
            ROLLBACK TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        PRINT N'Có lỗi xảy ra: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[TimKiemKhachHang]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục tìm kiếm Khách hàng
CREATE   PROCEDURE [dbo].[TimKiemKhachHang]
    @thamsovao NVARCHAR(50)
AS
BEGIN
    SELECT DienThoai, TenKhachHang, DiaChi, Phai, MaNV
    FROM KHACHHANG
    WHERE DienThoai LIKE '%' + @thamsovao + '%'
       OR TenKhachHang LIKE '%' + @thamsovao + '%'
	   OR MaNV LIKE '%' + @thamsovao + '%'
END;
GO
/****** Object:  StoredProcedure [dbo].[TimKiemNhanVien]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục tìm kiếm nhân viên
CREATE   PROCEDURE [dbo].[TimKiemNhanVien]
    @thamsovao NVARCHAR(50)
AS
BEGIN
    SELECT MaNV, Email, TenNV, DiaChi, VaiTro, TinhTrang, MatKhau
    FROM NHANVIEN
    WHERE TenNV LIKE '%' + @thamsovao + '%'
       OR MaNV LIKE '%' + @thamsovao + '%'
       OR Email LIKE '%' + @thamsovao + '%'
END;
GO
/****** Object:  StoredProcedure [dbo].[TimKiemSanPham]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục tìm kiếm hàng
CREATE   PROCEDURE [dbo].[TimKiemSanPham]
    @thamsovao NVARCHAR(50)
AS
BEGIN
    SELECT MaHang, TenHang, SoLuong, DonGiaBan, DonGiaNhap, HinhAnh, GhiChu, MaNV
    FROM HANG
    WHERE MaHang LIKE '%' + @thamsovao + '%'
       OR MaNV LIKE '%' + @thamsovao + '%'
       OR TenHang LIKE '%' + @thamsovao + '%'
END;
GO
/****** Object:  StoredProcedure [dbo].[ThemHang]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục thêm Hàng
CREATE   PROCEDURE [dbo].[ThemHang]
    @TenHang NVARCHAR(50),
    @SoLuong INT,
    @DonGiaBan FLOAT,
    @DonGiaNhap FLOAT,
    @HinhAnh VARCHAR(400),
    @GhiChu NVARCHAR(20),
    @Email NVARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        DECLARE @MaNV NVARCHAR(20)

        -- Tìm mã nhân viên dựa trên email của người đăng nhập
        SELECT @MaNV = MaNV FROM NHANVIEN WHERE Email = @Email

        -- Chèn dữ liệu vào bảng HANG
        INSERT INTO HANG (TenHang, SoLuong, DonGiaBan, DonGiaNhap, HinhAnh, GhiChu, MaNV)
        VALUES (@TenHang, @SoLuong, @DonGiaBan, @DonGiaNhap, @HinhAnh, @GhiChu, @MaNV);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[ThemKhachHang]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục thêm Khách hàng
CREATE   PROCEDURE [dbo].[ThemKhachHang]
    @DienThoai NVARCHAR(15),
    @TenKhachHang NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @Phai NVARCHAR(5),
    @Email NVARCHAR(50)
AS
BEGIN
    DECLARE @MaNV NVARCHAR(20)

    -- Tìm mã nhân viên dựa trên email của người đăng nhập
    SELECT @MaNV = MaNV FROM NHANVIEN WHERE Email = @Email

    -- Thêm khách hàng mới vào bảng KHACHHANG
    INSERT INTO KHACHHANG (DienThoai, TenKhachHang, DiaChi, Phai, MaNV)
    VALUES (@DienThoai, @TenKhachHang, @DiaChi, @Phai, @MaNV)

    PRINT 'Thêm khách hàng thành công.'
END
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục thêm nhân viên
CREATE   PROCEDURE [dbo].[ThemNhanVien]
    @Email NVARCHAR(50),
    @TenNV NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @VaiTro TINYINT,
    @TinhTrang TINYINT,
    @MatKhau NVARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Kiểm tra định dạng email
        IF @Email NOT LIKE '%@gmail.com'
        BEGIN
            PRINT N'Email không đúng định dạng @gmail.com.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Kiểm tra email trùng lặp
        IF EXISTS (SELECT 1 FROM NHANVIEN WHERE Email = @Email)
        BEGIN
            PRINT N'Email đã tồn tại.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        DECLARE @MaNV NVARCHAR(20);

        -- Tạo mã nhân viên từ ID
        SET @MaNV = 'NV' + CAST((SELECT ISNULL(MAX(ID), 0) + 1 FROM NHANVIEN) AS NVARCHAR(20));

        -- Thêm nhân viên mới vào bảng NHANVIEN
        INSERT INTO NHANVIEN (MaNV, Email, TenNV, DiaChi, VaiTro, TinhTrang, MatKhau)
        VALUES (@MaNV, @Email, @TenNV, @DiaChi, @VaiTro, @TinhTrang, @MatKhau);

        PRINT 'Thêm nhân viên thành công.';
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        PRINT 'Có lỗi xảy ra: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[ThongKeSanPham]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục thống kê Sản phẩm
CREATE   PROC [dbo].[ThongKeSanPham]
	
AS
BEGIN
	SELECT A.MaNV, A.TenNV, B.TenHang, COUNT(B.MaHang) AS 'Số lượng sản phẩm nhập' FROM NHANVIEN A INNER JOIN HANG B ON A.MaNV = B.MaNV
	GROUP BY A.MaNV, A.TenNV, B.TenHang
END
GO
/****** Object:  StoredProcedure [dbo].[ThongKeTonKho]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục Thống kê SP tồn kho
CREATE   PROC [dbo].[ThongKeTonKho]
AS
BEGIN
	SELECT TenHang, SUM(SoLuong) AS 'Số lượng tồn' FROM HANG
	GROUP BY TenHang
END
GO
/****** Object:  StoredProcedure [dbo].[XoaKhachHang]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục xóa khách hàng
CREATE   PROCEDURE [dbo].[XoaKhachHang]
    @DienThoai NVARCHAR(15)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Kiểm tra xem sản phẩm có tồn tại không
        IF EXISTS (SELECT 1 FROM KHACHHANG WHERE DienThoai = @DienThoai)
        BEGIN
            -- Xóa nhân viên khỏi bảng NHANVIEN
            DELETE FROM KHACHHANG WHERE DienThoai = @DienThoai;
            PRINT N'Xóa Khách Hàng thành công.';
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT N'Không tìm thấy khách hàng với mã hàng đã cung cấp.';
            ROLLBACK TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        PRINT N'Có lỗi xảy ra: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[XoaNhanVien]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục xóa nhân viên
CREATE   PROCEDURE [dbo].[XoaNhanVien]
    @Email NVARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Kiểm tra xem nhân viên có tồn tại không
        IF EXISTS (SELECT 1 FROM NHANVIEN WHERE Email = @Email)
        BEGIN
            -- Xóa nhân viên khỏi bảng NHANVIEN
            DELETE FROM NHANVIEN WHERE Email = @Email;
            PRINT N'Xóa nhân viên thành công.';
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT N'Không tìm thấy nhân viên với Email đã cung cấp.';
            ROLLBACK TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        PRINT N'Có lỗi xảy ra: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[XoaSanPham]    Script Date: 6/17/2024 1:33:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục xóa sản phẩm
CREATE   PROCEDURE [dbo].[XoaSanPham]
    @MaHang INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Kiểm tra xem sản phẩm có tồn tại không
        IF EXISTS (SELECT 1 FROM HANG WHERE MaHang = @MaHang)
        BEGIN
            -- Xóa nhân viên khỏi bảng NHANVIEN
            DELETE FROM HANG WHERE MaHang = @MaHang;
            PRINT N'Xóa sản phẩm thành công.';
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT N'Không tìm thấy sản phẩm với mã hàng đã cung cấp.';
            ROLLBACK TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        PRINT N'Có lỗi xảy ra: ' + ERROR_MESSAGE();
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
USE [master]
GO
ALTER DATABASE [QL_BANHANG] SET  READ_WRITE 
GO
