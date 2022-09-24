--Desafio 010 - Faça um programa que leia o preço de um produto, e mostre seu novo preço, com
--5% de desconto.
DECLARE @Preco FLOAT
DECLARE @Desconto FLOAT
SET @Preco = 20
SET @Desconto = 5.00
PRINT @Preco - @Preco * @Desconto / 100 

CREATE PROCEDURE SP_Desafio_010
@Preco FLOAT
AS
BEGIN
	DECLARE @Desconto FLOAT
	SET @Desconto = 5.00 
	PRINT 'Preço sem desconto: ' + CONVERT(VARCHAR(MAX), @Preco)
	PRINT 'Novo preço com desconto é: ' + CONVERT(VARCHAR(MAX), @Preco - @Preco * @Desconto / 100)
END

EXEC SP_Desafio_010 2


