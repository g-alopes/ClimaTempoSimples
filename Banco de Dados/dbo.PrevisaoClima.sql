USE [ClimaTempoSimples]
GO

/****** Object: Table [dbo].[PrevisaoClima] Script Date: 25/11/2021 21:57:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PrevisaoClima] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [CidadeId]          INT            NOT NULL,
    [DataPrevisao]      DATE           NOT NULL,
    [Clima]             NVARCHAR (15)  NOT NULL,
    [TemperaturaMinima] NUMERIC (3, 1) NULL,
    [TemperaturaMaxima] NUMERIC (3, 1) NULL
);


