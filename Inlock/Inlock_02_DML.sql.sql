USE Inlock;

INSERT INTO Usuario(idTipoUsuario, email, senha)
VALUES			   (1,'admin@admin.com','admin')
				   ,(2,'cliente@cliente.com','cliente')

INSERT INTO TiposDeUsuario(titulo)
VALUES					  ('Administrador')
						  ,('Cliente');

INSERT INTO Estudios(nomeEstudio)
VALUES				('Blizzard')
					,('Rockstar Studios')
					,('Square Enix');

INSERT INTO Jogos(IdEstudio, nomeJogo, descricao, dataLancamento, valor)
VALUES			 (1,'Diablo 3', 'é um jogo que contém bastante ação e é viciante, seja você um novato ou um fã', '15/05/2012', 'R$ 99,00')
				 ,(2,'Red Dead Redemption II', 'jogo eletrônico de ação-aventura western', '26/10/2018', 'R$ 120,00');