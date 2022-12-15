--SCRIPT DE INSERÇÃO DE FUNCIONARIO 
USE ExameCAPDB
GO
INSERT INTO [ExameCAPDB].[dbo].[Funcionario](NOME, Email, Telefone, Usuario, Senha, Matricula, ContaCorrente, DataNascimento) 
	SELECT [nome]
		  ,[email]
		  ,[telefone]
		  ,[login]
		  ,[senha]
		  ,[matricula]
		  ,[ContaCorrente]
		  ,[datanascimento]
	  FROM [ExameCAPDB].[dbo].[RAW_InsertFuncionario]
GO
