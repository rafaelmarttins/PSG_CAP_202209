--Desafio 009 - Fa�a um programa que leia a largura e a altura de uma parede em metros, e calcule
--a sua �rea e a quantidade de tinta necess�ria para pint�-la, sabendo que cada litro de tinta pinta
--uma �rea de 2 metros quadrados.
DECLARE @Largura FLOAT
DECLARE @Altura FLOAT
SET @Largura = 5
SET @Altura = 5
PRINT '� necess�rio' + ' ' + CONVERT(VARCHAR(MAX), @Largura * @Altura / 2) + ('L de tinta para pintar a parede.')

CREATE PROCEDURE SP_Desafio_009
@Largura FLOAT,
@Altura FLOAT
AS
PRINT '� necess�rio' + ' ' + CONVERT(VARCHAR(MAX), @Largura * @Altura / 2) + ('L de tinta para pintar a parede.')

EXEC SP_DESAFIO_009 3.5, 2

