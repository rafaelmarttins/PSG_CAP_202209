--Desafio 019 - Desenvolva um método que solicite a entrada de um número e calcule se o número
--é par ou ímpar.

--DECLARE @Numero INT
--SET @Numero = 1000
--BEGIN
--	IF 
--	(@Numero % 2 = 0)
--	PRINT 'O número ' + CONVERT(VARCHAR,@Numero) + CONVERT(VARCHAR(max), ' é par.')
--	ELSE 
--	PRINT 'O número ' + CONVERT(VARCHAR,@Numero) + CONVERT(VARCHAR(max), ' é impar.')
--END
--GO

CREATE PROCEDURE SP_Desafio_019
@Numero INT
AS 
BEGIN
	IF 
	(@Numero % 2 = 0)
	PRINT 'O número ' + CONVERT(VARCHAR,@Numero) + CONVERT(VARCHAR(max), ' é par.')
	ELSE 
	PRINT 'O número ' + CONVERT(VARCHAR,@Numero) + CONVERT(VARCHAR(max), ' é impar.')
END
GO

EXEC SP_Desafio_019 5
GO

