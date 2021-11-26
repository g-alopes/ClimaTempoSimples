USE [ClimaTempoSimples]
GO

/****** Object: Table [dbo].[Cidade] Script Date: 25/11/2021 21:56:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cidade] (
    [Id]       INT            NOT NULL,
    [Nome]     NVARCHAR (200) NOT NULL,
    [EstadoId] INT            NOT NULL
);


