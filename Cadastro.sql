
CREATE DATABASE Cadastro

USE Cadastro

CREATE TABLE Cadastro
(
	C_Funcionario INT PRIMARY KEY IDENTITY (1,1),
	Funcionario VARCHAR (30) NOT NULL,
	bloco VARCHAR (30) NOT NULL,
        data  VARCHAR (10) NOT NULL,
        servico VARCHAR (30) NOT NULL
	
)
