USE T_Peoples;

SELECT idFuncionario, nome, sobrenome FROM Funcionarios;

-- Buscar os funcionários através do nome 
SELECT idFuncionario, nome, sobrenome FROM Funcionarios
WHERE nome = 'Tadeu';

-- Buscar os funcionarios trazendo seus nomes completos 
SELECT idFuncionario, CONCAT (nome,' ', sobrenome) AS [nomes completos]
FROM Funcionarios;

-- Buscar os funcionarios de froma ordenada (A-Z)
SELECT idFuncionario, nome, sobrenome FROM Funcionarios
ORDER BY nome ASC;

-- Buscar os funcionarios de froma ordenada (Z-A)
SELECT idFuncionario, nome, sobrenome FROM Funcionarios
ORDER BY nome DESC;