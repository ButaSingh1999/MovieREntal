USE [VideoRentalDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[ReleaseDate] [datetime] NULL,
	[RentalCost] [decimal](18, 2) NULL,
	[Genre] [nvarchar](255) NULL,
	[Plot] [nvarchar](255) NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RentedMovieId] [int] IDENTITY(1,1) NOT NULL,
	[MovieId] [int] NULL,
	[CustId] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovies] PRIMARY KEY CLUSTERED 
(
	[RentedMovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[RentedMoviesView]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RentedMoviesView]
AS
SELECT        dbo.Customer.CustId, dbo.Customer.FirstName, dbo.Customer.LastName, dbo.Customer.Address, dbo.Customer.Phone, dbo.Movie.MovieId, dbo.Movie.Title, dbo.Movie.ReleaseDate, dbo.Movie.RentalCost, dbo.Movie.Genre, 
                         dbo.Movie.Plot, dbo.RentedMovies.RentedMovieId, dbo.RentedMovies.DateRented, dbo.RentedMovies.DateReturned
FROM            dbo.Customer INNER JOIN
                         dbo.RentedMovies ON dbo.Customer.CustId = dbo.RentedMovies.CustId INNER JOIN
                         dbo.Movie ON dbo.RentedMovies.MovieId = dbo.Movie.MovieId

GO
/****** Object:  View [dbo].[CountofMovies]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CountofMovies]
AS
SELECT dbo.Movie.Title, dbo.Movie.Genre, COUNT(dbo.RentedMovies.RentedMovieId) AS Count
FROM     dbo.Movie INNER JOIN
                  dbo.RentedMovies ON dbo.Movie.MovieId = dbo.RentedMovies.MovieId
GROUP BY dbo.Movie.Title, dbo.Movie.Genre
GO
/****** Object:  View [dbo].[GroupByGenre]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GroupByGenre]
AS
SELECT Genre, COUNT(Genre) AS GenreCount
FROM     dbo.Movie
GROUP BY Genre
GO
/****** Object:  View [dbo].[MaxMovies]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MaxMovies]
AS
SELECT MAX(RentedMovieId) AS MaxMovies
FROM     dbo.RentedMovies
GO
/****** Object:  View [dbo].[MinMovies]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MinMovies]
AS
SELECT MIN(RentedMovieId) AS MinMovies
FROM     dbo.RentedMovies
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (1, N'Arshdeep', N'Kaur', N'51 Frederick Drive, Dinsdale', N'0097767557')
INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (2, N'Sahil', N'Malhi', N'98 Duke Street', N'0877656765')
INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (3, N'Sehajnoor', N'Malhi', N'14 Sefton Street, Chartwell', N'0897856454')
INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (4, N'Sukhamandeep', N'Singh', N'31 Boundary Road, Claudelands', N'0975467878')
INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (5, N'Gurnoor', N'Malhi', N'22 Nixon Street, Hamilton East', N'0998876755')
INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (6, N'Gurmeet ', N'Toor ', N'72 Lyon Street, Frankton', N'0288672532')
INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (7, N'Sanampreet', N'Khaira', N'51 Campbell. Frankton', N'0787286756')
INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (8, N'Gursimarn', N'Sidhu', N'42 Moonlight, Rototuna', N'0114576535')
INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (9, N'Amandeep', N'Bajwa', N'21 Ellicott, Dinsdale', N'0228677564')
INSERT [dbo].[Customer] ([CustId], [FirstName], [LastName], [Address], [Phone]) VALUES (10, N'Sunil', N'Garg', N'31 Sefton Street, Chartwell', N'0975643435')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Movie] ON 

INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (3002, N'Honest Thief', CAST(N'2020-11-11T00:00:00.000' AS DateTime), CAST(5.00 AS Decimal(18, 2)), N'Action & adventure', N'In Honest Thief , filmmaker Mark Williams , tells the story of a career bank robber intent on turning himself in for the sake of love, who gets caught up in a violent conflict with two crooked FBI agents intent on stealing his money.')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (6014, N'Greenland', CAST(N'2020-12-23T00:00:00.000' AS DateTime), CAST(5.00 AS Decimal(18, 2)), N'Action', N'A family fights for survival as a planet-killing comet races to Earth. John Garrity (Gerard Butler), his estranged wife Allison (Morena Baccarin), and young son Nathan make a perilous journey to their only hope for sanctuary.')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (6015, N'Lassie Come Home', CAST(N'2014-06-05T00:00:00.000' AS DateTime), CAST(2.00 AS Decimal(18, 2)), N'Family', N'12-year-old Florian and his beloved dog Lassie live in an idyllic village in the German countryside. When Florian''s father loses his job, the family have to move into a small apartment where there are no dogs allowed.')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (7002, N'Rams (2020)', CAST(N'2004-06-22T00:00:00.000' AS DateTime), CAST(2.00 AS Decimal(18, 2)), N'Comedy', N'Brothers Colin and Les have been fighting for decades. Both are award-winning sheep farmers but when disaster strikes and disease threatens their flocks, will they be able to work together to save their sheep, their legacy, and their community.')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (7003, N'Jumanji: The Next Level', CAST(N'2015-03-12T00:00:00.000' AS DateTime), CAST(2.00 AS Decimal(18, 2)), N'Action & adventure', N'In Jumanji:The Next Level, the gang is back (Dwayne Johnson, Jack Black, Kevin Hart and Karen Gillan) but the game has changed. As they return to Jumanji to rescue one of their own, they discover that nothing is as they expect.')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (8002, N'ABCD', CAST(N'2013-04-13T00:00:00.000' AS DateTime), CAST(2.00 AS Decimal(18, 2)), N'Dance', N'fanisty')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (8003, N'IT Chapter 2', CAST(N'2015-09-19T00:00:00.000' AS DateTime), CAST(2.00 AS Decimal(18, 2)), N'Horror', N'Because every 27 years evil revisits the town of Derry, Maine, “IT Chapter Two” brings the characters—who’ve long since gone their separate ways—back together as adults, nearly three decades after the events of the first film.')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (9002, N'YAMLA PAGLA DEEWANA', CAST(N'2016-10-24T00:00:00.000' AS DateTime), CAST(5.00 AS Decimal(18, 2)), N'Drama', N'Yamla Pagla Deewana is a family drama of a man in search of his estranged family. Paramveer Singh Dhillon (Sunny), an upright and honest man working as a loan recovery agent in a bank stays')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (9003, N'Badal', CAST(N'2014-07-04T00:00:00.000' AS DateTime), CAST(2.00 AS Decimal(18, 2)), N'Drama', N'Badal (Bobby Deol) is a victim of the 1984 riots, brought up by a terrorist (Ashish Vidyarthi). Badal lives with the sole aim of exterminating a police cop Rana (Ashutosh Rana) now the DGP')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (9004, N'Hotel Mumbai', CAST(N'2019-10-24T00:00:00.000' AS DateTime), CAST(5.00 AS Decimal(18, 2)), N'Comedy', N' The primary target of this attack was the renowned Taj Mahal Palace Hotel. Based on true accounts of this terrifying assault, HOTEL MUMBAI brings together the guests and staff of the luxurious hotel')
INSERT [dbo].[Movie] ([MovieId], [Title], [ReleaseDate], [RentalCost], [Genre], [Plot]) VALUES (9005, N'Veer-Zaara', CAST(N'2012-01-10T00:00:00.000' AS DateTime), CAST(2.00 AS Decimal(18, 2)), N'Darma', N'Squadron Leader Veer Pratap Singh (Shahrukh Khan) is a rescue pilot with the Indian Air Force. In the line of duty he comes across a stranded Zaara (Preity Zinta)... a girl from Pakistan who has come to India to fulfill her surrogate mothers dying wish.')
SET IDENTITY_INSERT [dbo].[Movie] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

INSERT [dbo].[RentedMovies] ([RentedMovieId], [MovieId], [CustId], [DateRented], [DateReturned]) VALUES (1, 3002, 2, CAST(N'2021-02-18T15:58:56.460' AS DateTime), CAST(N'2021-02-18T16:23:35.563' AS DateTime))
INSERT [dbo].[RentedMovies] ([RentedMovieId], [MovieId], [CustId], [DateRented], [DateReturned]) VALUES (2, 6015, 4, CAST(N'2021-02-18T15:59:09.587' AS DateTime), NULL)
INSERT [dbo].[RentedMovies] ([RentedMovieId], [MovieId], [CustId], [DateRented], [DateReturned]) VALUES (1002, 6014, 6, CAST(N'2021-02-18T16:23:09.430' AS DateTime), CAST(N'2021-02-24T17:00:48.340' AS DateTime))
INSERT [dbo].[RentedMovies] ([RentedMovieId], [MovieId], [CustId], [DateRented], [DateReturned]) VALUES (2002, 8003, 5, CAST(N'2021-02-24T17:00:23.750' AS DateTime), NULL)
INSERT [dbo].[RentedMovies] ([RentedMovieId], [MovieId], [CustId], [DateRented], [DateReturned]) VALUES (2003, 9005, 6, CAST(N'2021-02-24T17:00:35.570' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK_RentedMovies_RentedMovies] FOREIGN KEY([RentedMovieId])
REFERENCES [dbo].[RentedMovies] ([RentedMovieId])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK_RentedMovies_RentedMovies]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllCustomer]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetAllCustomer]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Customer;
END

GO
/****** Object:  StoredProcedure [dbo].[spGetAllRentedVideo]    Script Date: 06/07/20216.30.36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetAllRentedVideo]  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    -- Select statements for procedure here  
    Select * from RentedMovies  
END  

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Movie"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 267
               Right = 254
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RentedMovies"
            Begin Extent = 
               Top = 8
               Left = 430
               Bottom = 261
               Right = 634
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CountofMovies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'CountofMovies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Movie"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 239
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GroupByGenre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GroupByGenre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "RentedMovies"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 200
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MaxMovies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MaxMovies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "RentedMovies"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 486
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MinMovies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MinMovies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Customer"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Movie"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "RentedMovies"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RentedMoviesView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RentedMoviesView'
GO
