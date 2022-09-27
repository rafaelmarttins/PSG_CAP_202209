--Desafio 015 – o mesmo professor quer agora, além de exibir, ordenar a lista. Faça um programa
--que ajude ele, lendo o nome deles e escrevendo todos os nomes armazenados, de forma
--ordenada.

--DECLARE @Nomes TABLE(Nome VARCHAR(MAX) NOT NULL)

--INSERT INTO @Nomes VALUES
--	('Daniel'),
--	('Renato'),
--	('Amanda'),
--	('Rafael'),
--	('Luiz'),
--	('Bruno'),
--	('Marlon'),
--	('Aline'),
--	('Jéssica'),
--	('Ronie'),
--	('Gérson')

--SELECT * FROM @Nomes ORDER BY Nome
--GO

CREATE PROCEDURE SP_Desafio_015
AS
BEGIN
	DECLARE @Nomes TABLE(Nome VARCHAR(MAX) NOT NULL)

	INSERT INTO @Nomes VALUES 
	('Daniel'),
	('Renato'),
	('Amanda'),
	('Rafael'),
	('Luiz'),
	('Bruno'),
	('Marlon'),
	('Aline'),
	('Jéssica'),
	('Ronie'),
	('Gérson')

	SELECT * FROM @Nomes
	ORDER BY Nome	
END
GO

EXEC SP_Desafio_015 
GO
