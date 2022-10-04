--CREATE TABLE Parcelamento(
--	ParcelaId BIGINT NOT NULL IDENTITY(1,1),
--	FuncionarioId BIGINT NOT NULL,
--	Sobrenome VARCHAR(MAX) NOT NULL,
--	Sexo CHAR(1) NOT NULL,
--	Valor DECIMAL NOT NULL,
--	Parcela INT NOT NULL,
--	ValorParcela NUMERIC(10,2) NULL
--	CONSTRAINT PK_Parcelamento PRIMARY KEY (ParcelaId)
--)


DECLARE @Parcela TABLE(
	ParcelaId BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FuncionarioId BIGINT NOT NULL,
	Sobrenome VARCHAR(MAX) NOT NULL,
	Sexo CHAR(1) NOT NULL,
	Valor NUMERIC(10,2) NOT NULL,
	Parcela INT NOT NULL,
	ValorParcela NUMERIC(10,2) NULL
)

DECLARE @FuncId BIGINT
DECLARE CursorParce CURSOR
	FOR SELECT FuncionarioId FROM Funcionario WHERE Sexo = 'F' AND Sobrenome LIKE 'MID%'

OPEN CursorParce
FETCH NEXT FROM CursorParce INTO @FuncId

DECLARE @Valor NUMERIC(10,2)
SET @Valor = 5236

DECLARE @NumeroParcela INT
SET @NumeroParcela = FLOOR(RAND() * (10 - 1 + 1)) + 1;

DECLARE @ValorParcela NUMERIC(10,2)
SET @ValorParcela = @Valor / @NumeroParcela


WHILE (@@FETCH_STATUS = 0)
BEGIN 

	INSERT INTO @Parcela(FuncionarioId, Sobrenome, Sexo, Valor, Parcela, ValorParcela)
		SELECT	FuncionarioId, Sobrenome, Sexo, @Valor, @NumeroParcela, @ValorParcela
		FROM Funcionario
		WHERE (FuncionarioId = @FuncId)
		
	FETCH NEXT FROM CursorParce INTO @FuncId
END
CLOSE CursorParce
DEALLOCATE CursorParce
SELECT * FROM @Parcela 
GO

