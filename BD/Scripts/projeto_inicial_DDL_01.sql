CREATE DATABASE Projeto_inicial
GO

USE Projeto_inicial
GO

CREATE TABLE TipoUsuario
(
	idTipoUsuario	INT PRIMARY KEY IDENTITY
	,nomeTipoUsuario	VARCHAR (50) NOT NULL
);
GO

CREATE TABLE Usuario
(
	idUsuario		INT PRIMARY KEY IDENTITY
	,idTipoUsuario	INT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario)
	,nomeUsuario	VARCHAR (50) NOT NULL
	,email			VARCHAR (100) NOT NULL UNIQUE
	,senha			VARCHAR (50)
);
GO

CREATE TABLE Sala
(
	idSala			INT PRIMARY KEY IDENTITY
	,nomeSala		VARCHAR (100) NOT NULL
	,metragem		VARCHAR (100) NOT NULL
	,andar			VARCHAR (50) NOT NULL
);
GO

CREATE TABLE Equipamento
(
	idEquipamento		INT PRIMARY KEY IDENTITY
	,nomeEquipamento	VARCHAR (100) NOT NULL
	,tipoEquipamento	VARCHAR (50)  NOT NULL
	,marca				VARCHAR (50)  NOT NULL
	,numeroDeSerie		VARCHAR (50)  NOT NULL
	,descricao			VARCHAR (250) NOT NULL
	,numeroPatrimonio	VARCHAR (50)  NOT NULL
	,estado				VARCHAR (50)
);
GO

CREATE TABLE ControleEquipamento
(
	idControleEquipamento	INT PRIMARY KEY IDENTITY
	,idSala					INT FOREIGN KEY REFERENCES Sala (idSala)
	,idEquipamento			INT FOREIGN KEY REFERENCES Equipamento (idEquipamento)
	,dataEntrada			DATE
	,dataSaida				DATE
);
GO