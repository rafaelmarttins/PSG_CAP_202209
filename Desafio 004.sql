--Desafio 004 - Crie um programa que leia um n�mero e mostre o seu dobro, seu triplo e sua raiz
--quadrada.
DECLARE @Valor INT
SET @Valor = 8
PRINT(@Valor * 2)
PRINT(@Valor * 3)
PRINT SQRT(@Valor)

CREATE PROCEDURE SP_Desafio_004
@Valor INT
AS
	PRINT 'O Dobro �:' + ' ' + CONVERT(VARCHAR(MAX), (@Valor * 2))
	PRINT 'O Triplo �:' + ' ' + CONVERT(VARCHAR(MAX), (@Valor * 3))
	PRINT 'A Raiz Quadrada �:' + ' ' + CONVERT(VARCHAR(MAX),SQRT(@Valor))

EXEC SP_Desafio_004	10

