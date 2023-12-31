USE [FACULTAD]
GO
/****** Object:  Table [ProyectoLUG].[Usuarios]    Script Date: 9/13/2023 7:36:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ProyectoLUG].[Usuarios](
	[idUsuario] [int] NOT NULL,
	[nombreUsuario] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [ProyectoLUG].[Usuarios] ([idUsuario], [nombreUsuario], [password]) VALUES (728882493, N'user', N'831c237928e6212bedaa4451a514ace3174562f6761f6a157a')
INSERT [ProyectoLUG].[Usuarios] ([idUsuario], [nombreUsuario], [password]) VALUES (1672213658, N'juan berterre', N'ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc')
INSERT [ProyectoLUG].[Usuarios] ([idUsuario], [nombreUsuario], [password]) VALUES (1861433805, N'marcos iannello', N'ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc')
GO
