--Testando o Script
--DECLARE @TipoCultura INT
--SET @TipoCultura = 1

--DECLARE @Municipio INT
--SET @Municipio = 1100015

--DECLARE @Ano INT
--SET @Ano = 2014

--SELECT * FROM Aquicultura
--WHERE IdTipoAquicultura = @TipoCultura AND IdMunicipio = @Municipio AND Ano = @Ano 

--Criação da Procedure
CREATE PROCEDURE sp_Questao_07
@TipoCultura INT,
@Municipio INT, 
@Ano INT
AS
BEGIN
	SELECT * FROM Aquicultura
	WHERE IdTipoAquicultura = @TipoCultura AND IdMunicipio = @Municipio AND Ano = @Ano 
END
GO

--Execução da Procedure
EXEC SP_Questao_07 1, 1100015, 2014
GO
