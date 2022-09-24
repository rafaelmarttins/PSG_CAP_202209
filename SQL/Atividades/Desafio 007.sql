--Desafio 007 - Faça um programa que leia um número inteiro e mostre na sua tela a sua tabuada.
DECLARE @Valor TINYINT 
DECLARE @X TINYINT 
SET @Valor = 9
SET @X = 0
PRINT 'Taboada do' + ' '+ CONVERT(VARCHAR,@Valor) + '.'
WHILE (@X < 10)
BEGIN
    SET @X = @X + 1
    PRINT(CONVERT(VARCHAR,@Valor) +' x ' +CONVERT(VARCHAR,@X)) + ' = ' +CONVERT(VARCHAR(MAX), @Valor * @X)
END

CREATE PROCEDURE SP_Desafio_007
@Valor TINYINT,
@X TINYINT 
AS
PRINT 'Taboada do' + ' '+ CONVERT(VARCHAR,@Valor) + '.'
WHILE (@X < 10)
BEGIN
	SET @X = @X + 1
    PRINT(CONVERT(VARCHAR,@Valor) +' x ' +CONVERT(VARCHAR,@X)) + ' = ' +CONVERT(VARCHAR(MAX), @Valor * @X)
END

EXEC SP_Desafio_007 7, 0

DROP PROCEDURE SP_Desafio_007


