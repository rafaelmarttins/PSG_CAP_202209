--Desafio 008 - Crie um programa que leia o quanto uma pessoa tem na carteira e mostre quantos
--d�lares ela pode comprar.
--Considere US$ 1,00 = R$ 5,00
DECLARE @Valor FLOAT
SET @Valor = 44
PRINT @Valor / 5.00	

CREATE PROCEDURE SP_Desafio_008
@Valor FLOAT
AS
PRINT 'Voc� pode comprar'+ ' ' + CONVERT(VARCHAR(MAX), @Valor / 5.00) + ' ' + ('D�lares.')

EXEC SP_Desafio_008 10

