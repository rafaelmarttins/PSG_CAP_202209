--Criação da Tabela
CREATE TABLE Aquicultura(
	IdAquicultura BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Ano INT NOT NULL,
	IdMunicipio BIGINT NOT NULL,
	IdTipoAquicultura BIGINT NOT NULL,
	Producao INT NULL,
	ValorProducao INT NULL,
	ProporcaoValorProducao INT NULL,
	Moeda VARCHAR(50) NOT NULL,
	CONSTRAINT FK_Aquicultura_TipoAquicultura FOREIGN KEY (IdTipoAquicultura) REFERENCES TipoAquicultura(IdTipoAquicultura)
)
GO

--Inserção de dados na Tabela Aquicultura
SET IDENTITY_INSERT Aquicultura ON
GO

INSERT INTO Aquicultura (IdAquicultura, Ano, IdMunicipio, IdTipoAquicultura, Producao, ValorProducao, ProporcaoValorProducao, Moeda)
	SELECT Id_Aquicultura, Ano, Id_Municipio, Id_Tipo_Aquicultura, Producao, Valor_Producao, Proporcao_Valor_Producao, Moeda 
	FROM RAW_Aquicultura_Brasil_Municipios

SET IDENTITY_INSERT Aquicultura OFF
GO

--Selecionar dados de um banco de dados
SELECT * FROM Aquicultura 
