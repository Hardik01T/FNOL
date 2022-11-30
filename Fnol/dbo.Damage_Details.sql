USE [Fnol]
GO

/****** Object:  Table [dbo].[Damage_Details]    Script Date: 11/30/2022 4:32:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Damage_Details](
	[Staring] [bit] NULL,
	[HOOD] [bit] NULL,
	[Front Bumper] [bit] NULL,
	[Front Passenger side fender] [bit] NULL,
	[Passenger door] [bit] NULL,
	[Rear assenger side quarter panel] [bit] NULL,
	[Rear bumper] [bit] NULL,
	[Rear/Trunk] [bit] NULL,
	[Driver door] [bit] NULL,
	[Undercarriage] [bit] NULL,
	[Policy_Number] [int] NOT NULL,
 CONSTRAINT [PK_Damage_Details] PRIMARY KEY CLUSTERED 
(
	[Policy_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


