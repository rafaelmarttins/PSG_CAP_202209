--Desafio 002 – Crie um programa que leia o dia, o mês e ano de nascimento de uma pessoa e
--mostre uma mensagem com a data formatada.

DECLARE @Dia INT
DECLARE @Mes INT
DECLARE @Ano INT 
SET @Dia = '10';
SET @Mes = '4';
SET @Ano = '2620';
PRINT('Data informada: ' +CONVERT(VARCHAR,@Dia) +'-' +CONVERT(VARCHAR,@Mes) +'-' +CONVERT(VARCHAR,@Ano))
GO

CREATE PROCEDURE SP_Desafio_002
@Dia INT,
@Mes INT,
@Ano INT 
AS
PRINT('Data informada: ' +CONVERT(VARCHAR,@Dia) +'-' +CONVERT(VARCHAR,@Mes) +'-' +CONVERT(VARCHAR,@Ano))

EXEC SP_Desafio_002 '16', '09', '1999'
