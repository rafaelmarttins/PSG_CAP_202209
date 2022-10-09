--Testando o Script
--DECLARE @Municipio INT
--SET @Municipio = 1100023

--DECLARE @Ano INT
--SET @Ano = 2014

--SELECT * FROM Aquicultura
--WHERE IdMunicipio = @Municipio AND Ano = @Ano AND Producao IS NOT NULL

--Criação da Procedure
CREATE PROCEDURE sp_Questao_08
@Municipio INT, 
@Ano INT
AS
BEGIN
	SELECT * FROM Aquicultura
	WHERE IdMunicipio = @Municipio AND Ano = @Ano AND Producao IS NOT NULL
END
GO

--Execução da Procedure
EXEC SP_Questao_08 1100023, 2014
GO
