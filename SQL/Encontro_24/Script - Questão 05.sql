--Criação da View Aquicultura não exibindo o código do Tipo de Aquicultura, apenas a descrição.
CREATE VIEW vw_Aquicultura
AS
SELECT	Aquicultura.IdAquicultura, 
		Aquicultura.Ano, 
		Aquicultura.IdMunicipio, 
		TipoAquicultura.Descricao, 
		Aquicultura.Producao, 
		Aquicultura.ValorProducao, 
		Aquicultura.ProporcaoValorProducao, 
		Aquicultura.Moeda
FROM Aquicultura 
INNER JOIN TipoAquicultura ON Aquicultura.IdTipoAquicultura = TipoAquicultura.IdTipoAquicultura
GO
