-- DDL

CREATE DATABASE INICIAL_3DT;
GO

USE INICIAL_3DT;
GO


CREATE TABLE TiposUsuarios(
	idTipoUsuario INT PRIMARY KEY IDENTITY,
	permissao VARCHAR(200) UNIQUE NOT NULL
);
GO

CREATE TABLE Usuarios(
	idUsuario INT PRIMARY KEY IDENTITY,
	idTipoUsuario INT FOREIGN KEY REFERENCES TiposUsuarios(idTipoUsuario),
	email VARCHAR(200) UNIQUE NOT NULL,
	senha VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Salas(
	idSala INT PRIMARY KEY IDENTITY,
	nomeSala VARCHAR(200) NOT NULL,
	andar NUMERIC(2) NOT NULL,
	metragem FLOAT NOT NULL
);
GO

CREATE TABLE TiposEquipamentos(
	idTipoEquipamento INT PRIMARY KEY IDENTITY,
	titulo VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Equipamentos(
	idEquipamento INT PRIMARY KEY IDENTITY,
	idTipoEquipamento INT FOREIGN KEY REFERENCES TiposEquipamentos(idTipoEquipamento),
	nomeEquipamento VARCHAR(200) NOT NULL,
	nomeMarca VARCHAR(100) NOT NULL,
	descricao VARCHAR(200) NOT NULL,
	numeroPatrimonio VARCHAR(10) UNIQUE NOT NULL,
	numeroSerie VARCHAR(15) UNIQUE NOT NULL,
	situacao BIT NOT NULL
);
GO

CREATE TABLE SalasEquipamentos(
	idSala INT FOREIGN KEY REFERENCES Salas(idSala),
	idEquipamento INT FOREIGN KEY REFERENCES Equipamentos(idEquipamento),
	dataEntrada DATE NOT NULL,
	dataSaida DATE
);
GO