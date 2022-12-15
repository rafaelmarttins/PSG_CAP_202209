--SCRIPT DE INSERÇÃO DE BILHETE 
USE ExameCAPDB
GO
INSERT INTO [ExameCAPDB].[dbo].[Bilhete](NumeroBilhete, Assento) 
	SELECT [NumeroBilhete]
		  ,[Assento]
	  FROM [ExameCAPDB].[dbo].[RAW_InsertBilhete]
GO
