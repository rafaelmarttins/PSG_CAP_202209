--Criação da Tabela
CREATE TABLE TipoAquicultura(
	IdTipoAquicultura BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(100) NOT NULL
)
GO

--Inserção de dados na Tabela TipoAquicultura
SET IDENTITY_INSERT TipoAquicultura ON
GO

INSERT INTO TipoAquicultura(IdTipoAquicultura, Descricao)

	SELECT DISTINCT Id_Tipo_Aquicultura, Descricao_Tipo_Aquicultura 
	FROM RAW_Aquicultura_Brasil_Municipios

SET IDENTITY_INSERT TipoAquicultura OFF
GO

--Selecionar dados de um banco de dados
SELECT * FROM TipoAquicultura	
