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
	PRINT @Preco - @Preco * @Desconto / 100 
END

EXEC SP_Desafio_010 20

