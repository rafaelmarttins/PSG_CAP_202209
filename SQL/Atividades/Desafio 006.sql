--Desafio 006 - Escreva um programa que leia um valor em metros e o exiba convertido em
--cent�metros e mil�metros.
DECLARE @Metro NUMERIC(10,2)
SET @Metro = 3
PRINT 'Metros' + ' ' + CONVERT(VARCHAR(MAX),@Metro) + ' '+ 'Cent�metros' + ' ' + CONVERT(VARCHAR(MAX), @Metro * 100) + ' '+ 'Mil�metros' + ' ' + CONVERT(Varchar(MAX), @Metro *1000)

CREATE PROCEDURE SP_Desafio_006
@Metro NUMERIC(10,2)
AS
	PRINT 'Metros' + ' ' + CONVERT(VARCHAR(MAX),@Metro) 
	PRINT 'Cent�metros' + ' ' + CONVERT(VARCHAR(MAX), @Metro * 100)
	PRINT 'Mil�metros' + ' ' + CONVERT(Varchar(MAX), @Metro *1000)

EXEC SP_Desafio_006 5
