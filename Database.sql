USE [Myassignment]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 4/2/2019 8:15:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Login](
	[UserId] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


USE [Myassignment]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 4/2/2019 8:15:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Login](
	[UserId] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


USE [Myassignment]
GO

/****** Object:  Table [dbo].[MapTable]    Script Date: 4/2/2019 8:17:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MapTable](
	[Place] [varchar](50) NOT NULL,
	[Latitude] [float] NOT NULL,
	[Longitude] [float] NOT NULL
) ON [PRIMARY]
GO


USE [Myassignment]
GO

/****** Object:  StoredProcedure [dbo].[getAll]    Script Date: 4/2/2019 8:18:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[getAll] 
AS

BEGIN

SELECT *

FROM  [Myassignment].[dbo].[Customer]

END
GO


