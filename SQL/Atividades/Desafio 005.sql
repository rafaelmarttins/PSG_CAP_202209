--Desafio 005 - Desenvolva um programa que leia as duas notas de um aluno, calcule e mostre a
--sua m�dia.
DECLARE @Nota1 FLOAT
DECLARE @Nota2 FLOAT
SET @Nota1 = 7.5
SET @Nota2 = 4.2
PRINT((@NOTA1 +@NOTA2)/2)

CREATE PROCEDURE SP_Desafio_005
@Nota1 FLOAT,
@Nota2 FLOAT
AS
	PRINT 'A m�dia do aluno �:'+ ' ' + CONVERT(VARCHAR(MAX), ((@NOTA1 +@NOTA2)/2))

EXEC SP_Desafio_005 5, 8

