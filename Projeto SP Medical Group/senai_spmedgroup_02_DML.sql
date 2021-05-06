USE SpMedGroup;

INSERT INTO	tipoUsuarios (tituloTipoUsuario)
VALUES	('Administrador')
		   ,('Medico')
		   ,('Paciente');

INSERT INTO Usuarios (idTipoUsuario, NomeUsuario, Email, Senha)
VALUES				(3,'Thiago','thiago@email.com','thiago123')
					,(3,'Ordilei','ordilei@email.com','ordilei123')
					,(2,'Paulo','paulo@email.com','paulo123')
					,(3,'Tsukamoto','tsukamoto@gmail.com','tsukamoto123')
					,(2,'Caique','caique@email.com','caique123')
					,(3,'Nobru','nobru@gmail.com','nobru123')
					,(1,'Saulo','saulo.adm@gmail.com','saulo123')
					,(3,'Alok','alok@email.com','alok123')
					,(3,'Neymar','neymar@gmail.com','neymar123')
					,(3,'Edukof','edukof@gmail.com','edukof123')
					,(2,'Frajola','frajola@gmail.com','frajola123')
					,(2,'Rick','rick@email.com','rick123');

INSERT INTO Especialidades (nomeEspecialide)
VALUES						 ('Acupuntura')
							,('Anestesiologia')
							,('Angiologia')
							,('Cardiologia')
							,('Cirurgia Cardiovascular')
							,('Cirurgia da Mão')
							,('Cirurgia do Aparelho Digestivo')
							,('Cirurgia Geral')
							,('Cirurgia Pediátrica')
							,('Cirurgia Plástica')
							,('Cirurgia Torácica')
							,('Cirurgia Vascular')
							,('Dermatologia')
							,('Radioterapia')
							,('Urologia')
							,('Pediatria')
							,('Psiquiatria');
				

INSERT INTO Pacientes (idUsuario,Nome, Datanascimento, Telefone, Rg, Cpf, Endereco)
VALUES					 (1,'thiago','12/09/1988','55115681660','107321208','5847380801','Vila da folha, 878')
						,(2,'ordilei','20/03/1985','55118268625','494183925','51771011858','Rua glock, 364')
						,(4,'tsukamoto','05/12/1991','55118147561','452362799','90614961874','Rua uzi, 30')
						,(6,'nobru','01/05/1993','55118740136','232210512','84768688802','rua março, 25')
						,(8,'alok','16/07/1996','55110586286','431571521','53643524803','rua cadeirante,02')
						,(9,'neymar','05/02/1992','55110387643','140659389','25230937823','rua bala, 802');

INSERT INTO Situacao (Situacao)
VALUES				('Agendada')
					,('Realizada')
					,('Cancelada');


INSERT INTO Clinicas (NomeFantasia, Cnpj, RazaoSocial, Endereco, HorarioAbertura, HorarioFechamento)
VALUES				('Clinica senai', '7023810401', 'SP Medical Grop', 'Av.Barão Limeira, 532,  São Paulo, SP', '05:00', '20:00' );


INSERT INTO Medicos ( idClinica, idUsuario, idEspecialidade,NomeMedico,Crm)
VALUES				(1,1,17,'Ricardo Lemos','10359-SP')
					,(1,2,6,'Roberto Possarle','74114-SP')
					,(1,3,10,'Helena Strada','94710-SP');

INSERT INTO  Consultas (idPaciente, idSituacao, idMedico, horaConsulta, dataConsulta, descricao)
VALUES					(1,3,2, '07:00','07/07/2021','')
						,(2,1,3,'09:30','29/12/2021','')
						,(3,3,2,'10:00','16/01/2021','')
						,(4,2,1,'13:00','11/09/2021','')
						,(5,1,2,'14:45','25/05/2021','')
						,(6,2,1,'15:00','19/03/2021','');