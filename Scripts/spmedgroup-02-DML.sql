USE SpMedGroup

SELECT * FROM Clinica
SELECT * FROM Administrador
SELECT * FROM Usuario
SELECT * FROM Medico
SELECT * FROM Prontuario
SELECT * FROM Consulta
SELECT * FROM TipoUsuario
SELECT * FROM Especialidade

INSERT INTO Clinica (Endereco, Cnpj, HorarioFuncionamento)
VALUES ('Avenida Alarameda Barão de Limeira, 539', '86400902000130', 'Das 8 ás 18');

INSERT INTO TipoUsuario (Titulo)
VALUES ('Administrador'), ('Paciente'), ('Médico');

INSERT INTO Usuario (IdTipoUsuario, Nome, Email, Senha, Telefone, Rg, Cpf, Endereco)
VALUES (3, 'Ricardo Lemos', 'ricardo.lemos@spmedicalgroup', '123123', '11 1212-1212', '123123321', '11122233300', 'Av. Barão Limeira, 532, São Paulo, SP');

INSERT INTO Usuario (IdTipoUsuario, Nome, Email, Senha, Telefone, Rg, Cpf, Endereco)
VALUES (3, 'Roberto Possarle', 'roberto.possarle@spmedicalgroup.com.br', '321321', '11 32323232', '321321321', '33322211100', 'Av. Barão Limeira, 532, São Paulo, SP'), 
(3, 'Helena Strada', 'helena.souza@spmedicalgroup.com.br', '333333', '11 33333333', '33333333', '33333333333', 'Av. Barão Limeira, 532, São Paulo, SP'),
(2, 'Ligia', 'ligia@gmail.com', '111111', '11 34567654', '435225435', '94839859000', 'Rua Estado de Israel 240, São Paulo, Estado de São Paulo, 04022-000'),
(2, 'Alexandre', 'alexandre@gmail.com', '111111', '11 987656543', '326543457', '73556944057', 'Av. Paulista, 1578 - Bela Vista, São Paulo - SP, 01310-200'),
(2, 'Fernando', 'fernando@gmail.com', '222222', '11 972084453', '546365253', '16839338002', 'Av. Ibirapuera - Indianópolis, 2927,  São Paulo - SP, 04029-200'),
(2, 'Henrique', 'henrique@gmail.com', '555555', '11 34566543', '543663625', '14332654765', 'R. Vitória, 120 - Vila Sao Jorge, Barueri - SP, 06402-030'),
(2, 'Joao', 'joao@hotmail.com', '666666', '11 76566377', '325444441', '91305348010', 'R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeirão Pires - SP, 09405-380'),
(2, 'Bruno', 'bruno@gmail.com', '777777', '11 954368769', '545662667', '79799299004', 'Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001'),
(2, 'Mariana', 'mariana@outlook.com', '888888', '' ,'545662668', '13771913039', 'R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140'),
(1, 'Carol', 'carol@gmail.com', '545454', '11 54545454', '545454556', '12323233421', 'Rua Estado de Israel 17, São Paulo, Estado de São Paulo, 04022-000'),
(1, 'Saulo', 'saulo@gmail.com', '767676', '11 7676-676', '736432784', '32356236267', 'Rua Estado de Israel 1700, São Paulo, Estado de São Paulo, 04022-000')

INSERT INTO Administrador (IdClinica, IdUsuario)
VALUES (1, 11),(1, 12);

INSERT INTO Especialidade (Titulo)
VALUES ('Acupuntura'),
('Anestesiologia'),
('Angiologia'),
('Cardiologia'),
('Cirurgia Cardiovascular'),
('Cirurgia da Mão'),
('Cirurgia do Aparelho Digestivo'),
('Cirurgia Geral'),
('Cirurgia Pediátrica'),
('Cirurgia Plástica'),
('Cirurgia Torácica'),
('Cirurgia Vascular'),
('Dermatologia'),
('Radioterapia'),
('Urologia'),
('Pediatria'),
('Psiquiatria');

INSERT INTO Medico (IdEspecialidade, IdClinica, IdUsuario, Crm)
VALUES (2, 1, 1, '54256-SP'), (16, 1, 2, '54452-SP'), (17, 1, 3, '65463-SP');

INSERT INTO Prontuario (IdUsuario, IdClinica, Altura, Peso, DataNascimento)
VALUES (3, 1, '1,60', '54', '13/10/1983'), (4, 1, '1,80', '75', '23/07/2001'), (5, 1, '1,87', '65', '10/10/1978'), (6, 1, '1,92', '103', '13/10/1985'), (7, 1, '1,43', '58', '27/08/1975'), (8, 1, '1,50', '50', '21/03/1972'), (9, 1, '1,22', '39', '05/03/2018');

INSERT INTO Consulta (IdProntuario, IdMedico, DataConsulta, Descricao, Situacao)
VALUES (7, 3, '20/01/2020 15:00', 'Ressonancia', 'Realizada')

INSERT INTO Consulta (IdProntuario, IdMedico, DataConsulta, Descricao, Situacao)
VALUES (2, 4, '06/01/2020 10:00', 'Exame de Rotina', 'Cancelada'), (3, 4, '07/02/2020 11:00', 'Ressonancia', 'Realizada'), (6, 4, '06/02/2018 10:00', 'Ressonancia', 'Realizada'), (4, 3, '07/02/2019 11:00', 'Ressonancia', 'Cancelada'), (5, 5, '08/03/2020 15:00', 'Ressonancia', 'Agendada') , (8, 3, '09/03/2020', 'Exame de Rotina', 'Agendada');
