USE ExameCAPDB
GO
CREATE TABLE Funcionario(
	CodigoFuncionario INT NOT NULL IDENTITY(1,1),
	Nome VARCHAR(MAX) NOT NULL,
	Email VARCHAR(MAX) NOT NULL,
	Telefone VARCHAR(MAX) NOT NULL,
	Usuario VARCHAR(MAX) NOT NULL,
	Senha VARCHAR(MAX) NOT NULL,
	Matricula VARCHAR(MAX) NOT NULL,
	ContaCorrente VARCHAR(MAX) NOT NULL,
	DataNascimento DATETIME NOT NULL,
	Situacao BIT NULL DEFAULT(1),
	CONSTRAINT PK_Funcionario PRIMARY KEY (CodigoFuncionario),
)
GO