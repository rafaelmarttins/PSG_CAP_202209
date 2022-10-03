--Desafio 021 - Crie uma procedure que liste os funcionários pelo nome, utilizando as 3 primeiras letras do nome. 
--Por exemplo, procure todos funcionários cujo nome comece com as letras MAR.

--DECLARE @BuscaNome CHAR(3)
--SET @BuscaNome = 'MAR'
	 
--DECLARE @Dados INT
--SELECT @Dados = COUNT(*) FROM Funcionario WHERE Nome LIKE @BuscaNome + '%'

--IF (@Dados = 0)
--BEGIN
--	PRINT('Não há nenhum funcionário(a) cujo nome comece com ' +@BuscaNome)
--END
--ELSE
--BEGIN
--	SELECT * FROM Funcionario
--	WHERE Nome LIKE @BuscaNome + '%'  
--	ORDER BY Nome
--END
--GO

CREATE PROCEDURE SP_Desafio_021
@BuscaNome CHAR(3)
AS
BEGIN
	DECLARE @Dados INT
	SELECT @Dados = COUNT(*) FROM Funcionario WHERE Nome LIKE @BuscaNome + '%'

	IF (@Dados = 0)
	BEGIN
		PRINT('Não há nenhum funcionário(a) cujo nome comece com ' + @BuscaNome)
	END
	ELSE
	BEGIN
		SELECT * FROM Funcionario
		WHERE Nome LIKE @BuscaNome + '%'  
		ORDER BY Nome
	END 
END
GO

EXEC SP_Desafio_021 'Mar'
GO
