CREATE DATABASE T_Peoples;

USE T_Peoples;

CREATE TABLE Funcionarios
(
	idFuncionario INT PRIMARY KEY IDENTITY 
	,nome VARCHAR (250) NOT NULL 
	,sobrenome VARCHAR (250) NOT NULL
);