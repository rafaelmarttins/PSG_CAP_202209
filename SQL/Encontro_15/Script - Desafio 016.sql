--Desafio 016 – o mesmo professor quer sortear um dos seus alunos para apagar o quadro. Faça um
--programa que ajude ele, lendo o nome deles e escrevendo o nome do escolhido.

--DECLARE @Nomes TABLE(
--	Codigo INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
--	Nome VARCHAR(MAX) NOT NULL
--)

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

--BEGIN
--	DECLARE @Valores INT 
--	SELECT @Valores = COUNT(*) FROM @Nomes
--	DECLARE @Id INT 
--	SET @Id = FLOOR(RAND() * (@Valores + 1))

--	WHILE @Id = 0 
--BEGIN
--	SET @Id = FLOOR(RAND() * (@Valores + 1))
--END
--	SELECT Nome AS 'Nome Escolhido para apagar o quadro!' FROM @Nomes WHERE Codigo = @Id
--END
--GO


CREATE PROCEDURE SP_Desafio_016
AS
BEGIN
	DECLARE @Nomes TABLE(
	Codigo INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Nome VARCHAR(MAX) NOT NULL
)

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

BEGIN
	DECLARE @Valores INT 
	SELECT @Valores = COUNT(*) FROM @Nomes
	DECLARE @Id INT 
	SET @Id = FLOOR(RAND() * (@Valores + 1))
END
	WHILE @Id = 0 
BEGIN
	SET @Id = FLOOR(RAND() * (@Valores + 1))
END
	SELECT Nome AS 'Nome Escolhido para apagar o quadro!' FROM @Nomes WHERE Codigo = @Id
END
GO

EXEC SP_Desafio_016
GO
