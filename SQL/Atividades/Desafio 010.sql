--Desafio 010 - Fa�a um programa que leia o pre�o de um produto, e mostre seu novo pre�o, com
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
	PRINT 'Pre�o sem desconto: ' + CONVERT(VARCHAR(MAX), @Preco)
	PRINT 'Novo pre�o com desconto �: ' + CONVERT(VARCHAR(MAX), @Preco - @Preco * @Desconto / 100)
END

EXEC SP_Desafio_010 2


