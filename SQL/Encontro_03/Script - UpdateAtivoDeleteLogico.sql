
UPDATE Cliente 
SET Ativo = 0, DataAlteracao = GETDATE() 
WHERE Codigo = 6

INSERT INTO Cliente(Nome,Documento,Telefone,Email,Endereco) // Inserindo cliente Barrabás na tabela Cliente para fins de conhecimento, para realizar o script UPDATE.
VALUES
('Barrabás','987','125496251','barrabas@teste.com','Rua x, n. 13')

UPDATE Cliente 
SET Ativo = 0, DataAlteracao = GETDATE(), DataExclusao = GETDATE() // Adicionado DataAlteracao e DataExclusao para o Cliente Barrabás.
WHERE Codigo = 9

UPDATE Cliente 
SET Ativo = 1, DataAlteracao = GETDATE(), DataExclusao = NULL // Reativando o Cliente Barrabás, e alterando DataExclusao como nulo.
WHERE Codigo = 9
