CREATE DATABASE SpMedGroup;

USE SpMedGroup;

CREATE TABLE Clinicas
(
	idClinica INT PRIMARY KEY IDENTITY 
	,NomeFantasia VARCHAR (200) NOT NULL
	,Cnpj VARCHAR (200) NOT NULL
	,RazaoSocial VARCHAR (200) NOT NULL 
	,Endereco VARCHAR (200) NOT NULL 
	,HorarioAbertura TIME NOT NULL
	,HorarioFechamento TIME NOT NULL

);


CREATE TABLE tipoUsuarios
(
	idTipoUsuario INT PRIMARY KEY IDENTITY
	,tituloTipoUsuario VARCHAR (200) NOT NULL
);


CREATE TABLE Usuarios
(
	idUsuario	INT PRIMARY KEY IDENTITY
	,idTipoUsuario	INT FOREIGN KEY REFERENCES tipoUsuarios (idTipoUsuario)
	,NomeUsuario VARCHAR (200) NOT NULL
	,Email VARCHAR (200) NOT NULL 
	,Senha VARCHAR (200) NOT NULL
);


CREATE TABLE Pacientes
(
	idPaciente INT PRIMARY KEY IDENTITY	
	,idUsuario INT FOREIGN KEY REFERENCES Usuarios (idUsuario) 
	,Nome VARCHAR (200) NOT NULL 
	,DataNascimento VARCHAR (200) NOT NULL
	,Telefone VARCHAR (200) NOT NULL
	,Rg	VARCHAR (200) NOT NULL
	,Cpf VARCHAR (200) NOT NULL
	,Endereco VARCHAR (200) NOT NULL
);


CREATE TABLE Especialidades
(
	idEspecialidade INT PRIMARY KEY IDENTITY 
	,nomeEspecialide VARCHAR (200) NOT NULL

);


CREATE TABLE Situacao 
(
	IdSituacao INT PRIMARY KEY IDENTITY
	,Situacao VARCHAR (200) NOT NULL
);


CREATE TABLE Medicos
(
	idMedico INT PRIMARY KEY IDENTITY 
	,idClinica INT FOREIGN KEY REFERENCES Clinicas (idClinica)
	,idUsuario INT FOREIGN KEY REFERENCES Usuarios (idUsuario)
	,idEspecialidade INT FOREIGN KEY REFERENCES Especialidades (idEspecialidade) 
	,NomeMedico VARCHAR (200) NOT NULL 
	,Crm VARCHAR (100) NOT NULL
);


CREATE TABLE Consultas
(
	idConsulta INT PRIMARY KEY IDENTITY 
	,idPaciente INT FOREIGN KEY REFERENCES Pacientes (idPaciente)
	,idSituacao INT FOREIGN KEY REFERENCES Situacao	 (idSituacao)
	,idMedico INT FOREIGN KEY REFERENCES	Medicos  (idMedico)
	,horaConsulta VARCHAR(200) NOT NULL
	,dataConsulta DATE NOT NULL
);