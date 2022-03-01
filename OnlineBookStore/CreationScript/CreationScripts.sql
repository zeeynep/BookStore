USE [db_a75067_sanemyildiz]
GO

/****** Object:  Table [dbo].[Books]    Script Date: 6/4/2021 8:50:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books](
	[Name] [nvarchar](50) NOT NULL,
	[Author] [nvarchar](50) NOT NULL,
	[Publisher] [nvarchar](50) NOT NULL,
	[Page_Number] [nvarchar](50) NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
	[Cover] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NULL,
	[ID] [nvarchar](50) NULL,
	[ImagePath] [nvarchar](100) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 6/4/2021 8:50:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Adress] [nvarchar](200) NULL,
	[EMail] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[ImagePath] [nvarchar](100) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Magazines]    Script Date: 6/4/2021 8:50:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Magazines](
	[Name] [nvarchar](50) NOT NULL,
	[Issue] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
	[Id] [int] NOT NULL,
	[ImagePath] [nvarchar](100) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Music_CDs]    Script Date: 6/4/2021 8:50:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Music_CDs](
	[Name] [nvarchar](50) NOT NULL,
	[Singer] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
	[Id] [int] NOT NULL,
	[ImagePath] [nvarchar](50) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[OrderList]    Script Date: 6/4/2021 8:50:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderList](
	[OrderNumber] [nvarchar](50) NULL,
	[OrderTime] [nvarchar](50) NULL,
	[OrderTotalPrice] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ShoppingCart]    Script Date: 6/4/2021 8:50:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ShoppingCart](
	[ProductName] [nvarchar](50) NULL,
	[Price] [nvarchar](10) NULL,
	[Amount] [nvarchar](10) NULL,
	[Username] [nvarchar](50) NULL,
	[ProductType] [nvarchar](50) NULL,
	[OrderNo] [nvarchar](10) NULL
) ON [PRIMARY]
GO

