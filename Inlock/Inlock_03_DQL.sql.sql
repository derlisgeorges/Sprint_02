USE Inlock;

SELECT * FROM TiposDeUsuario;
SELECT * FROM Usuario;
SELECT * FROM Estudios;
SELECT * FROM Jogos;

SELECT email AS Usuarios FROM Usuario;
SELECT nomeEstudio AS Estudios FROM Estudios;
SELECT nomeJogo AS Jogos FROM Jogos;

SELECT Jogos.nomeJogo AS Jogos , Estudios.nomeEstudio AS Estudios FROM Jogos
INNER JOIN Estudios
ON Jogos.IdJogo = Estudios.IdEstudio

SELECT Estudios.nomeEstudio AS Estudio ,Jogos.nomeJogo AS Jogos FROM Estudios
FULL OUTER JOIN Jogos
ON Estudios.IdEstudio = Jogos.IdJogo