SET IDENTITY_INSERT Departamento ON

INSERT INTO Departamento(DepartamentoId, Descricao)
	SELECT deptoid , nome FROM RAW_Departamentos

SET IDENTITY_INSERT Departamento OFF
GO

SELECT * FROM Departamento
