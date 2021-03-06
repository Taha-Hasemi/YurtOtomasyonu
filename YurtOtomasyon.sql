USE [master]
GO
/****** Object:  Database [YurtOtomasyonu]    Script Date: 3.08.2021 21:08:30 ******/
CREATE DATABASE [YurtOtomasyonu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YurtOtomasyonu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEVELOPER\MSSQL\DATA\YurtOtomasyonu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'YurtOtomasyonu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEVELOPER\MSSQL\DATA\YurtOtomasyonu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [YurtOtomasyonu] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YurtOtomasyonu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ARITHABORT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YurtOtomasyonu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YurtOtomasyonu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YurtOtomasyonu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YurtOtomasyonu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET RECOVERY FULL 
GO
ALTER DATABASE [YurtOtomasyonu] SET  MULTI_USER 
GO
ALTER DATABASE [YurtOtomasyonu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YurtOtomasyonu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YurtOtomasyonu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YurtOtomasyonu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [YurtOtomasyonu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [YurtOtomasyonu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'YurtOtomasyonu', N'ON'
GO
ALTER DATABASE [YurtOtomasyonu] SET QUERY_STORE = OFF
GO
USE [YurtOtomasyonu]
GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 3.08.2021 21:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolumler](
	[BolumID] [tinyint] IDENTITY(1,1) NOT NULL,
	[BolumAd] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borclar]    Script Date: 3.08.2021 21:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borclar](
	[OgrID] [int] NULL,
	[OgrAd] [varchar](20) NULL,
	[OgrSoyad] [varchar](20) NULL,
	[OgrKalanBorc] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giderler]    Script Date: 3.08.2021 21:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giderler](
	[OdemeID] [smallint] IDENTITY(1,1) NOT NULL,
	[Elektirik] [int] NULL,
	[Su] [int] NULL,
	[DogalGaz] [int] NULL,
	[Internet] [int] NULL,
	[Gida] [int] NULL,
	[Personel] [int] NULL,
	[Diger] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kasa]    Script Date: 3.08.2021 21:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kasa](
	[OdeyenOgrID] [int] NULL,
	[OdemeAy] [varchar](10) NULL,
	[OdemeMiktar] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 3.08.2021 21:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odalar](
	[OdaID] [tinyint] IDENTITY(1,1) NOT NULL,
	[OdaNo] [char](3) NULL,
	[OdaKapasite] [char](1) NULL,
	[OdaAktif] [char](1) NULL,
	[OdaDurum] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 3.08.2021 21:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[OgrID] [int] IDENTITY(1,1) NOT NULL,
	[OgrAd] [varchar](20) NULL,
	[OgrSoyad] [varchar](30) NULL,
	[OgrTc] [char](11) NULL,
	[OgrTelefon] [varchar](20) NULL,
	[OgrDogum] [varchar](10) NULL,
	[OgrBolum] [varchar](50) NULL,
	[OgrMail] [varchar](50) NULL,
	[OgrOdaNo] [char](3) NULL,
	[OgrVeliAdSoyad] [varchar](50) NULL,
	[OgrVeliTelefon] [varchar](20) NULL,
	[OgrVeliAdres] [varchar](200) NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[OgrID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 3.08.2021 21:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[PersonelID] [tinyint] IDENTITY(1,1) NOT NULL,
	[PersonelAdSoyad] [varchar](50) NULL,
	[PersonelDepartman] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yoneticiler]    Script Date: 3.08.2021 21:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yoneticiler](
	[YoneticiID] [tinyint] IDENTITY(1,1) NOT NULL,
	[YoneticiAd] [varchar](20) NULL,
	[YoneticiSifre] [varchar](20) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bolumler] ON 

INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (1, N'Bilgisayar Mühendisligi')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (2, N'Elektronik Mühendisligi')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (3, N'Otomotiv Mühendisligi')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (4, N'Mekatronik Mühendisligi')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (5, N'Yazilim Mühendisligi')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (6, N'Edebiyat')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (7, N'Sosyal Bilimler')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (8, N'Matematik')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (9, N'Tip')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (10, N'Dis Hekimligi')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (11, N'Veterinerlik')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (12, N'Muhasebe')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (13, N'Isletme')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (14, N'Su Urunleri')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (15, N'Yabanci Diller')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (16, N'Cografya')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (17, N'Bilgisayar Ogretmenligi')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (18, N'Brans Ogretmenlikleri')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (19, N'Konservatuar')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (20, N'Uluslararasi iliskiler')
INSERT [dbo].[Bolumler] ([BolumID], [BolumAd]) VALUES (23, N'Hukuk')
SET IDENTITY_INSERT [dbo].[Bolumler] OFF
GO
INSERT [dbo].[Borclar] ([OgrID], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (4, N'Aslan', N'Kaya', 2200)
INSERT [dbo].[Borclar] ([OgrID], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (6, N'Ahmet', N'Bas', 2000)
INSERT [dbo].[Borclar] ([OgrID], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (1, N'Ali', N'Boz', 3000)
INSERT [dbo].[Borclar] ([OgrID], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (2, N'Kizil', N'Aslan', 3000)
INSERT [dbo].[Borclar] ([OgrID], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (3, N'Ali', N'Bas', 3000)
INSERT [dbo].[Borclar] ([OgrID], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (4, N'Ahmet', N'Aydin', 3000)
INSERT [dbo].[Borclar] ([OgrID], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (5, N'Mesut', N'Boz', 3000)
INSERT [dbo].[Borclar] ([OgrID], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (6, N'Merve', N'Dinç', 3000)
INSERT [dbo].[Borclar] ([OgrID], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (7, N'Mehmet', N'Aslan', 3000)
GO
SET IDENTITY_INSERT [dbo].[Giderler] ON 

INSERT [dbo].[Giderler] ([OdemeID], [Elektirik], [Su], [DogalGaz], [Internet], [Gida], [Personel], [Diger]) VALUES (1, 300, 300, 400, 500, 200, 500, 100)
INSERT [dbo].[Giderler] ([OdemeID], [Elektirik], [Su], [DogalGaz], [Internet], [Gida], [Personel], [Diger]) VALUES (2, 200, 300, 400, 200, 400, 500, 100)
SET IDENTITY_INSERT [dbo].[Giderler] OFF
GO
INSERT [dbo].[Kasa] ([OdeyenOgrID], [OdemeAy], [OdemeMiktar]) VALUES (6, N'2021-7', 300)
INSERT [dbo].[Kasa] ([OdeyenOgrID], [OdemeAy], [OdemeMiktar]) VALUES (4, N'2021-7', 500)
INSERT [dbo].[Kasa] ([OdeyenOgrID], [OdemeAy], [OdemeMiktar]) VALUES (6, N'2021-7', 500)
INSERT [dbo].[Kasa] ([OdeyenOgrID], [OdemeAy], [OdemeMiktar]) VALUES (6, N'2021-8', 200)
INSERT [dbo].[Kasa] ([OdeyenOgrID], [OdemeAy], [OdemeMiktar]) VALUES (4, N'2021-8', 300)
GO
SET IDENTITY_INSERT [dbo].[Odalar] ON 

INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (1, N'101', N'1', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (2, N'102', N'1', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (3, N'103', N'1', N'1', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (4, N'104', N'1', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (5, N'105', N'1', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (6, N'201', N'2', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (7, N'202', N'2', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (8, N'203', N'2', N'1', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (9, N'204', N'2', N'2', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (10, N'205', N'2', N'1', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (11, N'301', N'3', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (12, N'302', N'3', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (13, N'303', N'3', N'2', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (14, N'304', N'3', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (15, N'305', N'3', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (16, N'401', N'4', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (17, N'402', N'4', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (18, N'403', N'4', N'0', 1)
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (19, N'404', N'4', N'0', 1)
SET IDENTITY_INSERT [dbo].[Odalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (1, N'Ali', N'Boz', N'12345678901', N'0930 112 8412', N'Jan  1 200', N'Mekatronik Mühendisligi', N'aliboz@gmail.com', N'103', N'Mehmet Boz', N'0930 115 7812', N'deneme')
INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (2, N'Kizil', N'Aslan', N'12345678902', N'0940 527 6611', N'Apr  2 200', N'Yazilim Mühendisligi', N'kaslan@gmail.com', N'303', N'Mahsun Aslan', N'0495 134 1751', N'deneme')
INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (3, N'Ali', N'Bas', N'12345678941', N'0940 512 2511', N'Mar  5 200', N'Dis Hekimligi', N'alibas@gmail.com', N'303', N'Mahsun bas', N'0235 132 6372', N'deneme')
INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (4, N'Ahmet', N'Aydin', N'16739216723', N'0916 826 1251', N'Jul  4 199', N'Otomotiv Mühendisligi', N'ahmetaydin', N'205', N'Aslan Aydin', N'0940 114 1467', N'deneme')
INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (5, N'Mesut', N'Boz', N'17841671901', N'0957 239 2751', N'Dec 24 200', N'Yazilim Mühendisligi', N'mesutboz@gmail.com', N'204', N'Esad Boz', N'0960 247 2576', N'deneme')
INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (6, N'Merve', N'Dinç', N'23682769825', N'0916 782 6728', N'Jun 17 200', N'Bilgisayar Ogretmenligi', N'mervedinc@gmail.com', N'204', N'Ahmet dinç', N'0915 178 7165', N'deneme')
INSERT [dbo].[Ogrenci] ([OgrID], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (7, N'Mehmet', N'Aslan', N'90762396789', N'0922 772 4756', N'Jul 15 200', N'Isletme', N'mehmetaslan@gmail.com', N'203', N'Polat Aslan', N'0915 786 1736', N'deneme')
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([PersonelID], [PersonelAdSoyad], [PersonelDepartman]) VALUES (1, N'Mehmet Yücedag', N'Müdür')
INSERT [dbo].[Personel] ([PersonelID], [PersonelAdSoyad], [PersonelDepartman]) VALUES (2, N'Mesut Öztürk', N'Yönetici')
INSERT [dbo].[Personel] ([PersonelID], [PersonelAdSoyad], [PersonelDepartman]) VALUES (3, N'Ahmet Tunali', N'Asci')
INSERT [dbo].[Personel] ([PersonelID], [PersonelAdSoyad], [PersonelDepartman]) VALUES (4, N'Emine Günes', N'Temizlik Görevlisi')
INSERT [dbo].[Personel] ([PersonelID], [PersonelAdSoyad], [PersonelDepartman]) VALUES (6, N'Atakan Bulut', N'Güvenlik')
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Yoneticiler] ON 

INSERT [dbo].[Yoneticiler] ([YoneticiID], [YoneticiAd], [YoneticiSifre]) VALUES (1, N'aslan', N'1234')
INSERT [dbo].[Yoneticiler] ([YoneticiID], [YoneticiAd], [YoneticiSifre]) VALUES (2, N'alikaya', N'yamamaya')
INSERT [dbo].[Yoneticiler] ([YoneticiID], [YoneticiAd], [YoneticiSifre]) VALUES (3, N'ahmetbas', N'boru123')
INSERT [dbo].[Yoneticiler] ([YoneticiID], [YoneticiAd], [YoneticiSifre]) VALUES (4, N'mehmetsert', N'kartal123')
SET IDENTITY_INSERT [dbo].[Yoneticiler] OFF
GO
ALTER TABLE [dbo].[Borclar] ADD  CONSTRAINT [DF_Borclar_OgrKalanBorc]  DEFAULT ((3000)) FOR [OgrKalanBorc]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_OdaAktif]  DEFAULT ((0)) FOR [OdaAktif]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_OdaDurum]  DEFAULT ((1)) FOR [OdaDurum]
GO
USE [master]
GO
ALTER DATABASE [YurtOtomasyonu] SET  READ_WRITE 
GO
