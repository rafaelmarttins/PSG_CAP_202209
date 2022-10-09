--Testando o Script
--DECLARE @TipoCultura INT
--SET @TipoCultura = 21

--DECLARE @Municipio INT
--SET @Municipio = 4211876

--DECLARE @Ano INT
--SET @Ano = 2014

--SELECT * FROM Aquicultura
--WHERE IdTipoAquicultura = @TipoCultura AND IdMunicipio = @Municipio AND Ano = @Ano AND Producao IS NOT NULL

--Criação da Procedure
CREATE PROCEDURE sp_Questao_09
@TipoCultura INT,
@Municipio INT, 
@Ano INT
AS
BEGIN
	SELECT * FROM Aquicultura
	WHERE IdTipoAquicultura = @TipoCultura AND IdMunicipio = @Municipio AND Ano = @Ano AND Producao IS NOT NULL
END
GO

--Execução da Procedure
EXEC SP_Questao_09 21, 4211876, 2014
GO
