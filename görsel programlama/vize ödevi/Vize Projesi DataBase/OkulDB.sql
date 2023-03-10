USE [OkulDB]
GO
/****** Object:  Table [dbo].[derstablo]    Script Date: 6.12.2022 20:18:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[derstablo](
	[dersid] [smallint] IDENTITY(1,1) NOT NULL,
	[dersadi] [varchar](30) NULL,
	[derskredisi] [varchar](30) NULL,
	[dersokulyonetimid] [smallint] NULL,
 CONSTRAINT [PK_tbl_ders] PRIMARY KEY CLUSTERED 
(
	[dersid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrenciderstablo]    Script Date: 6.12.2022 20:18:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenciderstablo](
	[ogrencidersid] [smallint] IDENTITY(1,1) NOT NULL,
	[ogrencidersdersid] [smallint] NULL,
	[ogrencidersogrenciid] [smallint] NULL,
 CONSTRAINT [PK_tbl_ogrenciders] PRIMARY KEY CLUSTERED 
(
	[ogrencidersid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrencilertablo]    Script Date: 6.12.2022 20:18:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrencilertablo](
	[ogrenciid] [smallint] IDENTITY(1,1) NOT NULL,
	[ogrenciadsoyad] [varchar](50) NULL,
	[ogrencikayittarih] [datetime] NULL,
	[ogrencidogumtarih] [datetime] NULL,
	[ogrencibolum] [varchar](50) NULL,
	[ogrencino] [varchar](11) NULL,
 CONSTRAINT [PK_tbl_ogrenciler] PRIMARY KEY CLUSTERED 
(
	[ogrenciid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[okulyonetimtablo]    Script Date: 6.12.2022 20:18:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[okulyonetimtablo](
	[yonetimid] [smallint] IDENTITY(1,1) NOT NULL,
	[yonetimadsoyad] [varchar](30) NULL,
	[yonetimgorevi] [varchar](30) NULL,
	[yonetimtipi] [nchar](10) NULL,
 CONSTRAINT [PK_tbl_okulyonetim] PRIMARY KEY CLUSTERED 
(
	[yonetimid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[derstablo] ON 

INSERT [dbo].[derstablo] ([dersid], [dersadi], [derskredisi], [dersokulyonetimid]) VALUES (1, N'Programlama Temelleri', N'15', 3)
INSERT [dbo].[derstablo] ([dersid], [dersadi], [derskredisi], [dersokulyonetimid]) VALUES (2, N'Denizcilik', N'7', 6)
INSERT [dbo].[derstablo] ([dersid], [dersadi], [derskredisi], [dersokulyonetimid]) VALUES (3, N'Php', N'10', 3)
INSERT [dbo].[derstablo] ([dersid], [dersadi], [derskredisi], [dersokulyonetimid]) VALUES (4, N'Java', N'13', 1)
SET IDENTITY_INSERT [dbo].[derstablo] OFF
GO
SET IDENTITY_INSERT [dbo].[ogrenciderstablo] ON 

INSERT [dbo].[ogrenciderstablo] ([ogrencidersid], [ogrencidersdersid], [ogrencidersogrenciid]) VALUES (1, 1, 3)
INSERT [dbo].[ogrenciderstablo] ([ogrencidersid], [ogrencidersdersid], [ogrencidersogrenciid]) VALUES (2, 2, 1)
INSERT [dbo].[ogrenciderstablo] ([ogrencidersid], [ogrencidersdersid], [ogrencidersogrenciid]) VALUES (3, 3, 3)
INSERT [dbo].[ogrenciderstablo] ([ogrencidersid], [ogrencidersdersid], [ogrencidersogrenciid]) VALUES (4, 1, 8)
SET IDENTITY_INSERT [dbo].[ogrenciderstablo] OFF
GO
SET IDENTITY_INSERT [dbo].[ogrencilertablo] ON 

INSERT [dbo].[ogrencilertablo] ([ogrenciid], [ogrenciadsoyad], [ogrencikayittarih], [ogrencidogumtarih], [ogrencibolum], [ogrencino]) VALUES (1, N'Eralp Çolak', CAST(N'2022-12-06T18:02:05.403' AS DateTime), CAST(N'2000-03-17T12:12:12.000' AS DateTime), N'Elektronik', N'199')
INSERT [dbo].[ogrencilertablo] ([ogrenciid], [ogrenciadsoyad], [ogrencikayittarih], [ogrencidogumtarih], [ogrencibolum], [ogrencino]) VALUES (3, N'Eren Tekirdağ', CAST(N'2022-12-06T18:02:05.403' AS DateTime), CAST(N'1999-02-12T08:23:23.000' AS DateTime), N'Muhendislik', N'123')
INSERT [dbo].[ogrencilertablo] ([ogrenciid], [ogrenciadsoyad], [ogrencikayittarih], [ogrencidogumtarih], [ogrencibolum], [ogrencino]) VALUES (8, N'Erkan Kandemir', CAST(N'2022-12-06T18:02:05.403' AS DateTime), CAST(N'2002-07-23T07:45:12.000' AS DateTime), N'Elektronik', N'777')
INSERT [dbo].[ogrencilertablo] ([ogrenciid], [ogrenciadsoyad], [ogrencikayittarih], [ogrencidogumtarih], [ogrencibolum], [ogrencino]) VALUES (9, N'Mete Başaran', CAST(N'2022-12-06T18:02:05.403' AS DateTime), CAST(N'2001-09-26T06:21:43.000' AS DateTime), N'Muhendislik', N'324')
INSERT [dbo].[ogrencilertablo] ([ogrenciid], [ogrenciadsoyad], [ogrencikayittarih], [ogrencidogumtarih], [ogrencibolum], [ogrencino]) VALUES (10, N'İrem Seven', CAST(N'2022-12-06T18:02:05.403' AS DateTime), CAST(N'2002-07-27T05:32:43.000' AS DateTime), N'Elektronik', N'352')
INSERT [dbo].[ogrencilertablo] ([ogrenciid], [ogrenciadsoyad], [ogrencikayittarih], [ogrencidogumtarih], [ogrencibolum], [ogrencino]) VALUES (11, N'Eray Karadeniz', CAST(N'2022-12-06T18:02:05.403' AS DateTime), CAST(N'2001-09-17T18:01:19.000' AS DateTime), N'Muhendislik', N'277')
SET IDENTITY_INSERT [dbo].[ogrencilertablo] OFF
GO
SET IDENTITY_INSERT [dbo].[okulyonetimtablo] ON 

INSERT [dbo].[okulyonetimtablo] ([yonetimid], [yonetimadsoyad], [yonetimgorevi], [yonetimtipi]) VALUES (1, N'Tuğkan Gönültaş', N'Yazılım', N'12        ')
INSERT [dbo].[okulyonetimtablo] ([yonetimid], [yonetimadsoyad], [yonetimgorevi], [yonetimtipi]) VALUES (2, N'Cantuğ Özsoy', N'Sosyal Bilgiler', N'12        ')
INSERT [dbo].[okulyonetimtablo] ([yonetimid], [yonetimadsoyad], [yonetimgorevi], [yonetimtipi]) VALUES (3, N'Gürhan Karadeniz', N'Müdür Yardımcısı', N'12        ')
INSERT [dbo].[okulyonetimtablo] ([yonetimid], [yonetimadsoyad], [yonetimgorevi], [yonetimtipi]) VALUES (4, N'Beren Saat', N'Matematik', N'11        ')
INSERT [dbo].[okulyonetimtablo] ([yonetimid], [yonetimadsoyad], [yonetimgorevi], [yonetimtipi]) VALUES (5, N'Kibariye Karadeniz', N'Matematik', N'11        ')
INSERT [dbo].[okulyonetimtablo] ([yonetimid], [yonetimadsoyad], [yonetimgorevi], [yonetimtipi]) VALUES (6, N'Feyyaz Yiğit', N'Yazılım', N'12        ')
INSERT [dbo].[okulyonetimtablo] ([yonetimid], [yonetimadsoyad], [yonetimgorevi], [yonetimtipi]) VALUES (9, N'Egemen Karadeniz', N'Müdür', N'11        ')
INSERT [dbo].[okulyonetimtablo] ([yonetimid], [yonetimadsoyad], [yonetimgorevi], [yonetimtipi]) VALUES (10, N'Sezer Ababays', N'Siyasal Bilimler', N'12        ')
INSERT [dbo].[okulyonetimtablo] ([yonetimid], [yonetimadsoyad], [yonetimgorevi], [yonetimtipi]) VALUES (11, N'Alara Karakılıç', N'Matematik', N'11        ')
SET IDENTITY_INSERT [dbo].[okulyonetimtablo] OFF
GO
ALTER TABLE [dbo].[derstablo]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ders_tbl_okulyonetim] FOREIGN KEY([dersokulyonetimid])
REFERENCES [dbo].[okulyonetimtablo] ([yonetimid])
GO
ALTER TABLE [dbo].[derstablo] CHECK CONSTRAINT [FK_tbl_ders_tbl_okulyonetim]
GO
ALTER TABLE [dbo].[ogrenciderstablo]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ogrenciders_tbl_ders] FOREIGN KEY([ogrencidersdersid])
REFERENCES [dbo].[derstablo] ([dersid])
GO
ALTER TABLE [dbo].[ogrenciderstablo] CHECK CONSTRAINT [FK_tbl_ogrenciders_tbl_ders]
GO
ALTER TABLE [dbo].[ogrenciderstablo]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ogrenciders_tbl_ogrenciler1] FOREIGN KEY([ogrencidersogrenciid])
REFERENCES [dbo].[ogrencilertablo] ([ogrenciid])
GO
ALTER TABLE [dbo].[ogrenciderstablo] CHECK CONSTRAINT [FK_tbl_ogrenciders_tbl_ogrenciler1]
GO
