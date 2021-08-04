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
	andar INT NOT NULL,
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
	nomeMarca VARCHAR(100) NOT NULL,
	descricao VARCHAR(200) NOT NULL,
	numeroPatrimonio INT UNIQUE NOT NULL,
	numeroSerie INT UNIQUE NOT NULL,
	situacao BIT NOT NULL
);
GO

CREATE TABLE SalasEquipamentos(
	idSala INT FOREIGN KEY REFERENCES Salas(idSala),
	idEquipamento INT FOREIGN KEY REFERENCES Equipamentos(idEquipamento)
);
GO