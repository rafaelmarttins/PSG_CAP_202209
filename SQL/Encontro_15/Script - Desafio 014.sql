--Desafio 014 – um professor quer armazenas o nome dos seus alunos para realizar algumas tarefas.
--Faça um programa que ajude ele, lendo o nome deles e escrevendo todos os nomes
--armazenados.

--DECLARE @Nomes  
--TABLE(NOME VARCHAR(MAX) NOT NULL)

--INSERT INTO @Nomes VALUES
--	('Rafael'),
--	('Luiz'),
--	('Bruno'),
--	('Marlon'),
--	('Renato'),
--	('Jéssica'),
--	('Ronie'),
--	('Gérson')

--SELECT * FROM @Nomes

CREATE PROCEDURE SP_Desafio_014
AS
BEGIN
	DECLARE @Nomes TABLE(NOME VARCHAR(MAX) NOT NULL)
	
	INSERT INTO @Nomes VALUES
	('Rafael'),
	('Luiz'),
	('Bruno'),
	('Marlon'),
	('Renato'),
	('Jéssica'),
	('Ronie'),
	('Gérson')

	SELECT * FROM @Nomes
END 
GO

EXEC SP_Desafio_014
GO
