CREATE TABLE Subcategoria(
    Codigo INT NOT NULL IDENTITY(1,1),
    CodigoCategoria INT NOT NULL,
    Descricao VARCHAR(MAX) NOT NULL,
    DataInsert DATETIME NOT NULL,
    CONSTRAINT PK_Subcategoria PRIMARY KEY (Codigo),
    CONSTRAINT FK_Subcategoria_Categoria FOREIGN KEY (CodigoCategoria) REFERENCES Categoria(Codigo) -- Boas práticas para o nome da FK da onde eu estou para onde eu vou.
)
GO
