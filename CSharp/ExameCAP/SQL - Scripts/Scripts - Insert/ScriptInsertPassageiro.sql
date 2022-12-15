--SCRIPT DE INSERÇÃO DE FUNCIONARIO 
USE ExameCAPDB
GO
INSERT INTO [ExameCAPDB].[dbo].[Passageiro](NOME, Email, Telefone, Usuario, Senha, Documento, NumeroCartao, DataNascimento) 
SELECT  [Nome]
      ,[Email]
      ,[Telefone]
      ,[Usuario]
      ,[Senha]
      ,[Documento]
      ,[NumeroCartao]
      ,[DataNascimento]
  FROM [ExameCAPDB].[dbo].[RAW_InsertPassageiro]
GO

