--Desafio 013 – Escreva um programa que pergunte a quantidade de km percorridos por um carro
--alugado, e a quantidade de dias pelos quais ele foi alugado. Calcule o preço a pagar, sabendo
--que o carro custa R$ 60,00 por dia e R$ 0,15 por km rodado.

--DECLARE @KmPercorrido INT
--DECLARE @DiasAlugado INT
--SET @KmPercorrido = 4285
--SET @DiasAlugado = 10
--BEGIN
--	DECLARE @PrecoAPagar NUMERIC(10,2)
--	SET @PrecoAPagar = @KmPercorrido * 0.15 + @DiasAlugado * 60
--	PRINT 'Preço a pagar pelo uso do carro: ' + CONVERT(VARCHAR(MAX),@PrecoAPagar)
--END
--GO

CREATE PROCEDURE SP_Desafio_013
@KmPercorrido INT,
@DiasAlugado INT
AS
BEGIN
	DECLARE @PrecoAPagar NUMERIC(10,2)
	SET @PrecoAPagar = @KmPercorrido * 0.15 + @DiasAlugado * 60
	BEGIN
	PRINT 'Preço a pagar pelo uso do carro: ' + CONVERT(VARCHAR(MAX), @PrecoAPagar)
	END
END
GO

EXEC SP_Desafio_013 4285, 10
GO
