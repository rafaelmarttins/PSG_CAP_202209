--Desafio 006 - Escreva um programa que leia um valor em metros e o exiba convertido em
--centímetros e milímetros.
DECLARE @Metro NUMERIC(10,2)
SET @Metro = 3
PRINT 'Metros' + ' ' + CONVERT(VARCHAR(MAX),@Metro) + ' '+ 'Centímetros' + ' ' + CONVERT(VARCHAR(MAX), @Metro * 100) + ' '+ 'Milímetros' + ' ' + CONVERT(Varchar(MAX), @Metro *1000)

CREATE PROCEDURE SP_Desafio_006
@Metro NUMERIC(10,2)
AS
	PRINT 'Metros' + ' ' + CONVERT(VARCHAR(MAX),@Metro) 
	PRINT 'Centímetros' + ' ' + CONVERT(VARCHAR(MAX), @Metro * 100)
	PRINT 'Milímetros' + ' ' + CONVERT(Varchar(MAX), @Metro *1000)

EXEC SP_Desafio_006 5
