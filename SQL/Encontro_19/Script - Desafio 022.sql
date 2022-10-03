--Desafio 022 - Crie uma procedure que liste os funcionários que fazem aniversário em determinado ano.

--DECLARE @Ano INT
--SET @Ano = 1963

--DECLARE @Dados INT
--SELECT @Dados = COUNT(*) FROM Funcionario WHERE YEAR(DataNascimento) = @Ano

--IF (@Dados = 0)
--BEGIN
--	PRINT('Não há funcionários que fazem aniversário no ano informada !!')
--END
--ELSE
--BEGIN
--	SELECT * FROM Funcionario 
--	WHERE YEAR(DataNascimento) = @Ano
--	ORDER BY Nome
--END
--GO

CREATE PROCEDURE SP_Desafio_022
@Ano INT 
AS
BEGIN
	DECLARE @Dados INT
	SELECT @Dados = COUNT(*) FROM Funcionario WHERE YEAR(DataNascimento) = @Ano

	IF (@Dados = 0)
	BEGIN
		PRINT('Não há funcionários que fazem aniversário no ano informada !!')
	END
	ELSE
	BEGIN
		SELECT * FROM Funcionario 
		WHERE YEAR(DataNascimento) = @Ano
		ORDER BY Nome
	END
END
GO

EXEC SP_Desafio_022 1963
GO

