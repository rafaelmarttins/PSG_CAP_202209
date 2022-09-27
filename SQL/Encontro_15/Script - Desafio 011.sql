--Faça um programa que leia o salário de um funcionário, e mostre seu novo salário,
--com 15% de aumento.

--DECLARE @Salario FLOAT
--SET @Salario = 4251.00
--BEGIN
--	DECLARE @Aumento NUMERIC(10,2)
--	DECLARE @NovoSalario NUMERIC(10,2) 
--	SET @Aumento = 0.15
--	SET @NovoSalario = @Salario * @Aumento + @Salario
--	BEGIN
--	PRINT 'Salário sem aumento: '+ CONVERT(VARCHAR(MAX), @Salario)
--	PRINT 'Novo salário com aumento: ' + CONVERT(VARCHAR(MAX), @NovoSalario)
--	END
--END
--GO

CREATE PROCEDURE SP_Desafio_011
@Salario FLOAT
AS
BEGIN
	DECLARE @Aumento NUMERIC(10,2)
	DECLARE @NovoSalario NUMERIC(10,2) 
	SET @Aumento = 0.15
	SET @NovoSalario = @Salario * @Aumento + @Salario
	BEGIN
	PRINT 'Salário sem aumento: '+ CONVERT(VARCHAR(MAX), @Salario)
	PRINT 'Novo salário com aumento: ' + CONVERT(VARCHAR(MAX), @NovoSalario)
	END
END
GO

EXEC SP_Desafio_011 1241.42
GO

