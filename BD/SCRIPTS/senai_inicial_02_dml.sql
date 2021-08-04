-- DML

USE INICIAL_3DT;
GO


INSERT INTO TiposUsuarios(permissao)
VALUES	('Administrador'),
		('Professor');
GO

INSERT INTO Usuarios(idTipoUsuario, email, senha)
VALUES	(1, 'adm@adm.com', 'adm123'),
		(2, 'paulo@gmail.com', 'paulo123'),
		(2, 'pri@gmail.com', 'pri123');
GO

INSERT INTO Salas(nomeSala, andar, metragem)
VALUES	('Informática', 0, 10),
		('Música', 0, 12),
		('Matemática', 1, 8),
		('Física', 1, 8),
		('Biologia', 2, 8),
		('Química', 2, 10);
GO

INSERT INTO TiposEquipamentos(titulo)
VALUES	('Cadeira'),
		('Mesa'),
		('Computador'),
		('Notebook'),
		('Projetor'),
		('Mapa'),
		('Tubo de Ensaio'),
		('Violão'),
		('Microfone'),
		('Televisão'),
		('Mouse');
GO

INSERT INTO Equipamentos(