--Desafio 023 - Crie uma procedure que liste os funcionários de determinado sexo.

--DECLARE @Sexo CHAR(1) 
--SET @Sexo = 'M'

--DECLARE @Dados INT
--SELECT @Dados = COUNT(*) FROM Funcionario WHERE Sexo = @Sexo

--IF (@Dados = 0)
--BEGIN
--	PRINT('Não há funcionario(a) com sexo informado !')
--END
--ELSE
--BEGIN
--	SELECT * FROM Funcionario
--	WHERE Sexo = @Sexo
--	ORDER BY Nome
--END
--GO

CREATE PROCEDURE SP_Desafio_023
@Sexo CHAR(1)
AS
BEGIN
	DECLARE @Dados INT
	SELECT @Dados = COUNT(*) FROM Funcionario WHERE Sexo = @Sexo

	IF (@Dados = 0)
	BEGIN
		PRINT('Não há funcionario(a) com sexo informado !')
	END
	ELSE
	BEGIN
		SELECT * FROM Funcionario
		WHERE Sexo = @Sexo
		ORDER BY Nome
	END
END
GO

EXEC SP_Desafio_023 'M'
GO

