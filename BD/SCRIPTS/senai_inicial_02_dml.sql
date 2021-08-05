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
VALUES	('Inform�tica', 0, 10),
		('M�sica', 0, 12.6),
		('Matem�tica', 1, 8),
		('F�sica', 1, 8),
		('Biologia', 2, 8.3),
		('Qu�mica', 2, 10);
GO

INSERT INTO TiposEquipamentos(titulo)
VALUES	('Laptop'),
		('Mob�lia'),
		('Modelo'),
		('Instrumento Musical'),
		('Laborat�rio');
GO

INSERT INTO Equipamentos(idTipoEquipamento, nomeEquipamento, nomeMarca, descricao, numeroPatrimonio, numeroSerie, situacao)
VALUES	(1, 'Notebook i7', 'Dell', 'Notebook para uso acad�mico', 13200001, 20210704001, 1), -- 1 (true) e 0 (false)
		(1, 'Notebook i7', 'Dell', 'Notebook para uso acad�mico', 13200002, 20210704002, 0),
		(1, 'Notebook i7', 'Dell', 'Notebook para uso acad�mico', 13200003, 20210704003, 1),
		(2, 'Cadeira de Escrit�rio', 'Finora', 'Cadeira para uso dos professores e/ou alunos', 13200004, 20210704004, 1),
		(2, 'Cadeira de Escrit�rio', 'Finora', 'Cadeira para uso dos professores e/ou alunos', 13200005, 20210704005, 0),
		(2, 'Cadeira de Escrit�rio', 'Finora', 'Cadeira para uso dos professores e/ou alunos', 13200006, 20210704006, 0),
		(3, 'Esqueleto Anat�mico', 'COSIM', 'Esqueleto anat�mico para o uso nas aulas de biologia', 13200007, 20210704007, 1),
		(4, 'Viol�o', 'Yamaha', 'Viol�o para o uso nas aulas de m�sica', 13200008, 20210704008, 0),
		(5, 'Tubo de Ensaio', 'Laborglas', 'Tubo de ensaio para o uso nas aulas de qu�mica', 13200009, 20210704009, 0),
		(5, 'Tubo de Ensaio', 'Laborglas', 'Tubo de ensaio para o uso nas aulas de qu�mica', 13200010, 20210704010, 1);
GO

INSERT INTO SalasEquipamentos(idSala, idEquipamento, dataEntrada)
VALUES	(1, 1, '29/07/2021'),
		(1, 2, '29/07/2021'),
		(1, 3, '29/07/2021'),
		(2, 8, '30/07/2021'),
		(3, 4, '20/07/2021'),
		(4, 5, '22/07/2021'),
		(4, 6, '22/07/2021'),
		(5, 7, '25/07/2021'),
		(6, 9, '30/07/2021'),
		(6, 10, '30/07/2021');
GO