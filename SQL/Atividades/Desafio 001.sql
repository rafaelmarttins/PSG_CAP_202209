--Desafio 001 - Crie um programa que leia o nome de uma pessoa e mostre uma mensagem de
--boas-vindas de acordo com o valor digitado.

DECLARE @Nome VARCHAR(MAX)
SET @Nome = 'Rafael'
PRINT @Nome + ' ' + 'Seja Bem Vindo(a)'

CREATE PROCEDURE SP_Desafio_001
@Nome VARCHAR(MAX)
AS
BEGIN
	PRINT 'Seja Bem Vindo(a)' + ' ' + @Nome + '.' 
END

EXEC SP_Desafio_001 'Rafael'

