--Desafio 003 – Crie um programa que leia dos números e tente mostrar a soma entre eles.
DECLARE @Numero1 INT
DECLARE @Numero2 INT
SET @Numero1 = 10
SET @Numero2 = 10
PRINT @Numero1 + @Numero2

CREATE PROCEDURE SP_Desafio_003
@Numero1 INT,
@Numero2 INT
AS
	PRINT 'A soma entre os dois números é:'+ ' ' + CONVERT(VARCHAR(MAX), @Numero1 + @Numero2)

EXEC SP_Desafio_003 10,10




