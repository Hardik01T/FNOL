USE [Fnol]
GO

/****** Object:  Table [dbo].[Involed_Party]    Script Date: 11/30/2022 4:32:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Involed_Party](
	[Id] [int] NOT NULL,
	[Frist_Name] [varchar](50) NULL,
	[Last_Name] [varchar](max) NULL,
	[Insurance_Provider] [varchar](max) NULL,
	[Year] [int] NULL,
	[Model] [nchar](10) NULL,
	[Policy_Number] [int] NULL,
	[Phone_Number] [nchar](10) NULL,
 CONSTRAINT [PK__Involed___3214EC074AACEC27] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


