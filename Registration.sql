USE [Registration]
GO
/****** Object:  Table [dbo].[Registration_Master]    Script Date: 12/19/2017 4:50:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration_Master](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[Role] [int] NULL,
 CONSTRAINT [PK_Registration_Master] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role_Master]    Script Date: 12/19/2017 4:50:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role_Master](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role_Master] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Registration_Master] ON 

INSERT [dbo].[Registration_Master] ([ID], [FirstName], [LastName], [Email], [Password], [ContactNo], [Role]) VALUES (1, N'Jigar', N'Tanna', N'jigar@gmail.com', N'System123#', N'9727166524', 1)
SET IDENTITY_INSERT [dbo].[Registration_Master] OFF
SET IDENTITY_INSERT [dbo].[Role_Master] ON 

INSERT [dbo].[Role_Master] ([ID], [RoleName]) VALUES (1, N'User')
INSERT [dbo].[Role_Master] ([ID], [RoleName]) VALUES (2, N'Admin')
SET IDENTITY_INSERT [dbo].[Role_Master] OFF
