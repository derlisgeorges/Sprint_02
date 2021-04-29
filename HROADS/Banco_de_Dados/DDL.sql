-- Criar o banco de dados chamado

CREATE DATABASE SENAI_HROADS;

USE SENAI_HROADS;
-- Criar as tabelas no banco de dados

CREATE TABLE Personagem
(
	idPersonagem INT PRIMARY KEY IDENTITY
	,Nome VARCHAR(200)NOT NULL
	,Classe VARCHAR(200)NOT NULL
	,Vida VARCHAR(200)NOT NULL
	,Mana VARCHAR(200)NOT NULL
	,DataAtual VARCHAR(200)NOT NULL
	,DataDeCriacao VARCHAR(200)NOT NULL
);

CREATE TABLE TiposDeHabilidades
(
	idTipoHabilidades INT PRIMARY KEY IDENTITY
	,Descricao VARCHAR(250)NOT NULL
);

CREATE TABLE Habilidades
(
	idHabilidades INT PRIMARY KEY IDENTITY
	,idTipoHabilidades INT FOREIGN KEY REFERENCES TiposDeHabilidades (idTipoHabilidades)
	,Descricao VARCHAR(250)
);

CREATE TABLE Classes
(
	idClasses INT PRIMARY KEY IDENTITY
	,Descricao VARCHAR(250)NOT NULL
);

CREATE TABLE HabiliClasses
(
	idClasses INT FOREIGN KEY REFERENCES Classes (idClasses)
	,idHabilidades INT FOREIGN KEY REFERENCES Habilidades (idHabilidades)
	,Descricao VARCHAR(250)NOT NULL
);

CREATE TABLE TiposDeUsuario
(
	idTipoUsuario INT PRIMARY KEY IDENTITY,
	titulo VARCHAR(250)NOT NULL
);

CREATE TABLE Usuario
(
	idUsuario INT PRIMARY KEY IDENTITY,
	idTipoUsuario INT FOREIGN KEY REFERENCES TiposDeUsuario(IdTipoUsuario),
	email VARCHAR(250)NOT NULL,	
	senha VARCHAR(12)NOT NULL
);