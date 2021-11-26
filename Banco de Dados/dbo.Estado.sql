USE [ClimaTempoSimples]
GO

/****** Object: Table [dbo].[Estado] Script Date: 25/11/2021 21:57:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Estado] (
    [Id]   INT            NOT NULL,
    [Nome] NVARCHAR (200) NOT NULL,
    [UF]   NVARCHAR (2)   NOT NULL
);


