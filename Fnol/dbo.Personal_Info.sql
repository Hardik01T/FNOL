USE [Fnol]
GO

/****** Object:  Table [dbo].[Personal_Info]    Script Date: 11/30/2022 4:32:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personal_Info](
	[First_Name] [nchar](10) NULL,
	[Last_Name] [nchar](10) NULL,
	[Policy_Type] [nchar](10) NULL,
	[Policy_Number] [int] NOT NULL,
	[Phone_Number] [nvarchar](max) NULL,
 CONSTRAINT [PK_Personal_Info] PRIMARY KEY CLUSTERED 
(
	[Policy_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


