DECLARAR VARIÁVEL
DECLARE @VALOR INT

ATRIBUIR VALOR
SET @VALOR = 0

IF..ELSE
SET @VALOR = 20
IF (@VALOR <= 10)
BEGIN
	PRINT('EXEMPLO')
END
ELSE
BEGIN
	PRINT('MAL EXEMPLO')
END
GO

WHILE DO
SET @VALOR = 0
WHILE (@VALOR <> 20)
BEGIN
	SET @VALOR = @VALOR + 1
	PRINT('Valor = ' + CONVERT(VARCHAR,@VALOR))
END
GO

CASE
SET @VALOR = 2
DECLARE @EXIBIR VARCHAR(MAX)
SET @EXIBIR = CASE
	WHEN @VALOR = 1 THEN 'Valor(1) = ' + CONVERT(VARCHAR,@VALOR)
	WHEN @VALOR = 2 THEN 'Valor(2) = ' + CONVERT(VARCHAR,@VALOR)
	ELSE 'Valor(3) = ' + CONVERT(VARCHAR,@VALOR)
END
PRINT @EXIBIR
GO

SELECT @VALOR = COUNT(*) FROM Cliente 
PRINT (CONVERT(VARCHAR,@VALOR))
GO

DECLARE @DataTeste DATETIME
SET @DataTeste = CONVERT(datetime, '01-09-2022')
DECLARE @DataAtual DATETIME
SET @DataAtual = GETDATE()

IF (@DataTeste > @DataAtual)
BEGIN
	PRINT('A data teste é maior que a data atual.')
END
ELSE
BEGIN
	PRINT('A data atual é maior que a data teste.')
END
GO


