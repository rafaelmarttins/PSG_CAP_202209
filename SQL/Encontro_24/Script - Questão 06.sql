--Testando o Script
--DECLARE @Municipio INT
--SET @Municipio = 1100015

--DECLARE @Ano INT
--SET @Ano = 2014

--SELECT * FROM Aquicultura
--WHERE IdMunicipio = @Municipio AND Ano = @Ano

--Criação da Procedure
CREATE PROCEDURE sp_Questao_06
@Municipio INT, 
@Ano INT
AS
BEGIN
	SELECT * FROM Aquicultura
	WHERE IdMunicipio = @Municipio AND Ano = @Ano
END
GO

--Execução da Procedure
EXEC SP_Questao_06 1100015, 2014
GO
