

/****** Object:  Table [dbo].[Polina_Department]    Script Date: 12/21/2015 2:03:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Polina_Department](
	[Department_id] [int] IDENTITY(1,1) NOT NULL,
	[Department_name] [varchar](50) NOT NULL,
	[Department_phone] [varchar](50) NULL,
 CONSTRAINT [PK__TableName] PRIMARY KEY CLUSTERED 
(
	[Department_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


