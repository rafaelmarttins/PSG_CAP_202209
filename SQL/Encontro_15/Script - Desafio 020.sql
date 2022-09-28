--Desafio 020 - Desenvolva um método que permita a entrada do nome do usuário e exiba
--- Imprima a frase “Olá meu nome é: {nome recebido}”.
--- O nome com todas as letras maiúsculas e minúsculas.
--- Quantas letras ao todo (sem considerar espaços).
--- Quantas letras tem o primeiro nome.

--DECLARE @Nome VARCHAR(MAX)
--SET @Nome = 'Rafael Gemelli Martins       '
--BEGIN
--	PRINT 'Olá meu nome é: ' + TRIM(@Nome)
--	PRINT 'Nome maiúsculo: ' + TRIM(UPPER(@Nome))
--	PRINT 'Nome minúsculo: ' + TRIM(LOWER(@Nome))
--	PRINT 'Total de letras do seu nome: ' + CONVERT(VARCHAR,(LEN(REPLACE(@Nome,' ',''))))
--	PRINT 'Total de letras do primeiro nome: ' + CONVERT(VARCHAR, (LEN(SUBSTRING(@Nome, 1, CHARINDEX(' ', @Nome)))))
--END
--GO

CREATE PROCEDURE SP_Desafio_020
@Nome VARCHAR(MAX)
AS
BEGIN
	PRINT 'Olá meu nome é: ' + TRIM(@Nome)
	PRINT 'Nome maiúsculo: ' + TRIM(UPPER(@Nome))
	PRINT 'Nome minúsculo: ' + TRIM(LOWER(@Nome))
	PRINT 'Total de letras do seu nome: ' + CONVERT(VARCHAR,(LEN(REPLACE(@Nome,' ',''))))
	PRINT 'Total de letras do primeiro nome: ' + CONVERT(VARCHAR, (LEN(SUBSTRING(@Nome, 1, CHARINDEX(' ', @Nome)))))
END
GO

EXEC SP_Desafio_020 'Rafael Gemelli Martins          '
GO
