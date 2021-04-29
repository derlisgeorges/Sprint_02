USE SENAI_HROADS;

SELECT * FROM Personagem;

SELECT idHabilidades ,Descricao, idTipoHabilidades FROM Habilidades;

SELECT * FROM TiposDeHabilidades;

--Selecionar todos as classes
SELECT Classes.Descricao, Habilidades.Descricao FROM Classes
INNER JOIN HabiliClasses
ON Classes.idClasses = HabiliClasses.idClasses
INNER JOIN Habilidades
ON Habilidades.idHabilidades = HabiliClasses.idHabilidades;

--Selecionar somente o nome das classes
SELECT Classes.Descricao FROM Classes;

SELECT * FROM Classes;

--Atualizar o nome do personagem Fer8 para Fer7
UPDATE Personagem
SET Nome = 'Fear7'
WHERE idPersonagem = 3;

--Atualizar o nome da classe de Necromante para Necromancer								
UPDATE Classes
SET Descricao = 'Necromancer'
WHERE idClasses = 5;

--Selecionar todos os personagens
SELECT Nome FROM Personagem;

--Selecionar todas as habilidades
SELECT Habilidades.Descricao FROM Habilidades;

--Realizar a contagem de quantas habilidades estão cadastradas
SELECT COUNT(DISTINCT Habilidades.Descricao) FROM Habilidades;

--Selecionar somente os id’s das habilidades classificando-os por ordem crescente
SELECT idHabilidades FROM Habilidades;

--Selecionar todos os tipos de habilidades
SELECT * FROM Habilidades

--Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte
SELECT Habilidades.Descricao, TiposDeHabilidades.Descricao FROM Habilidades
INNER JOIN TiposDeHabilidades
ON Habilidades.idHabilidades = TiposDeHabilidades.idTipoHabilidades;

--Selecionar todos os personagens e suas respectivas classes
SELECT Personagem.Nome, Personagem.Classe FROM Personagem;

--Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens)
SELECT Classes.Descricao, Personagem.Nome FROM Classes
LEFT JOIN Personagem
ON Classes.idClasses = Personagem.idPersonagem;

--Selecionar todas as classes e suas respectivas habilidades;
SELECT Classes.Descricao, Habilidades.Descricao FROM Classes
LEFT JOIN Habilidades
ON Classes.idClasses = Habilidades.idHabilidades;

--Selecionar todas as habilidades e suas classes (somente as que possuem correspondência)
SELECT Classes.Descricao, Habilidades.Descricao FROM Classes
INNER JOIN HabiliClasses
ON Classes.idClasses = HabiliClasses.idClasses
INNER JOIN Habilidades
ON Habilidades.idHabilidades = HabiliClasses.idHabilidades
WHERE Habilidades.Descricao <> 'NULL';