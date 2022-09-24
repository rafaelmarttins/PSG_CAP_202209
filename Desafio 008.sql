--Desafio 008 - Crie um programa que leia o quanto uma pessoa tem na carteira e mostre quantos
--dólares ela pode comprar.
--Considere US$ 1,00 = R$ 5,00
DECLARE @Valor FLOAT
SET @Valor = 44
PRINT @Valor / 5.00	

CREATE PROCEDURE SP_Desafio_008
@Valor FLOAT
AS
PRINT 'Você pode comprar'+ ' ' + CONVERT(VARCHAR(MAX), @Valor / 5.00) + ' ' + ('Dólares.')

EXEC SP_Desafio_008 10

