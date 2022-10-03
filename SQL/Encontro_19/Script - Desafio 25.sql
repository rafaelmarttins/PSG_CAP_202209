--Desafio_025 - Crie uma procedure que busque e liste os funcionários que tenham as 3 letras determinadas no sobrenome. 
--Por exemplo, procure todos funcionários que tenham as letras SAN no sobrenome.

--DECLARE @LetrasSobrenome CHAR(3) 
--SET @LetrasSobrenome = 'San'

--SELECT * FROM Funcionario
--WHERE Sobrenome LIKE '%' + @LetrasSobrenome + '%'
--ORDER BY Nome, Sobrenome
--GO

CREATE PROCEDURE SP_Desafio_025
@LetrasSobrenome CHAR(3)
AS
BEGIN
	SELECT * FROM Funcionario
	WHERE Sobrenome LIKE '%'+ @LetrasSobrenome +'%'
	ORDER BY Nome, Sobrenome
END
GO

EXEC SP_Desafio_025 'San'
GO
