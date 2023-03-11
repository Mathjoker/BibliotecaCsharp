-- Gerando a tabela FUNCIONARIO
CREATE TABLE Funcionario
(
	ID INT PRIMARY KEY IDENTITY,
	NOME VARCHAR(100) NOT NULL,
	DATA_NASCIMENTO DATE NOT NULL,
	CPF VARCHAR(15) NOT NULL,
	EMAIL VARCHAR(25) NOT NULL,
	SENHA VARCHAR(25) NOT NULL,
	TELEFONE VARCHAR(12) NOT NULL,
	MATRICULA INT NOT NULL,
	CARGO VARCHAR(35) NOT NULL,
);