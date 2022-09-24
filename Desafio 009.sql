--Desafio 009 - Faça um programa que leia a largura e a altura de uma parede em metros, e calcule
--a sua área e a quantidade de tinta necessária para pintá-la, sabendo que cada litro de tinta pinta
--uma área de 2 metros quadrados.
DECLARE @Largura FLOAT
DECLARE @Altura FLOAT
SET @Largura = 5
SET @Altura = 5
PRINT 'É necessário' + ' ' + CONVERT(VARCHAR(MAX), @Largura * @Altura / 2) + ('L de tinta para pintar a parede.')

CREATE PROCEDURE SP_Desafio_009
@Largura FLOAT,
@Altura FLOAT
AS
PRINT 'É necessário' + ' ' + CONVERT(VARCHAR(MAX), @Largura * @Altura / 2) + ('L de tinta para pintar a parede.')

EXEC SP_DESAFIO_009 3.5, 2

