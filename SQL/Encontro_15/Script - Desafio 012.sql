--Desafio 012 – escreva um programa que converta uma temperatura digitada em graus celsius
--para fahrenheit.

--DECLARE @Celsius FLOAT
--SET @Celsius= 42
--BEGIN
--	DECLARE @Fahrenheit FLOAT
--	DECLARE @Conversao FLOAT
--	SET @Conversao = (9 * @Celsius / 5) + 32
--	BEGIN
--	PRINT 'Temperatura em Celsius: '+ CONVERT(VARCHAR(MAX), @Celsius)
--	PRINT 'Temperatura convertida em Fahrenheit: ' + CONVERT(VARCHAR(MAX), @Conversao)
--	END
--END
--GO

CREATE PROCEDURE SP_Desafio_012
@Celsius FLOAT
AS
BEGIN
	DECLARE @Fahrenheit FLOAT
	DECLARE @Conversao FLOAT
	SET @Conversao = (9 * @Celsius / 5) + 32
	BEGIN
	PRINT 'Temperatura em Celsius: '+ CONVERT(VARCHAR(MAX), @Celsius)
	PRINT 'Temperatura convertida em Fahrenheit: ' + CONVERT(VARCHAR(MAX), @Conversao)
	END
END
GO

EXEC SP_Desafio_012 42
GO
