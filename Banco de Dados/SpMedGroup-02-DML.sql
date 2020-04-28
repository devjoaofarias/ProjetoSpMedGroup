USE SpMedGroup_Joao;
GO

SELECT * FROM Usuario
SELECT * FROM Prontuario
SELECT * FROM Consulta
SELECT * FROM Clinica
SELECT * FROM Medico
SELECT * FROM Administrador
SELECT * FROM Especialidade
SELECT * FROM Cidade
SELECT * FROM Estado
SELECT * FROM TipoUsuario
SELECT * FROM Situacao

INSERT INTO Estado (NomeEstado)
VALUES ('São Paulo');

INSERT INTO Cidade (IdEstado, NomeCidade)
VALUES (1, 'Sao Paulo');

INSERT INTO TipoUsuario (Titulo)
VALUES ('Administrador'), ('Paciente'), ('Médico');

INSERT INTO Situacao (NomeSituacao)
VALUES ('Confirmada'), ('Pendente'), ('Cancelada'), ('Realizada');

INSERT INTO Clinica (IdCidade, NomeClinica, Cnpj, Cep, Logradouro, Bairro, HorarioInicial, HorarioFinal)
VALUES (1, 'SpMedGroup1', '86400902000130', '01202001', 'Av. Alameda Barão de Limeira, 539', 'Santa Cecilia', '08:00', '18:00');

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

INSERT INTO Usuario (IdTipoUsuario, Nome, Email, Senha, Telefone, Rg, Cpf, Cep, Logradouro, Bairro)
VALUES (3, 'Ricardo Lemos', 'ricardo.lemos@spmedicalgroup', '123123', '11 1212-1212', '123123321', '11122233300', '01202001','Av. Barão Limeira, 532', 'Santa Cecilia');

INSERT INTO Usuario (IdTipoUsuario, Nome, Email, Senha, Telefone, Rg, Cpf, Cep, Logradouro, Bairro)
VALUES (3, 'Roberto Possarle', 'roberto.possarle@spmedicalgroup.com.br', '321321', '11 32323232', '321321321', '33322211100', '01202001','Av. Barão Limeira, 532','Santa Cecilia'), 
(3, 'Helena Strada', 'helena.souza@spmedicalgroup.com.br', '333333', '11 33333333', '33333333', '33333333333', '01202001','Av. Barão Limeira, 532','Santa Cecilia'),
(2, 'Ligia', 'ligia@gmail.com', '111111', '11 34567654', '435225435', '94839859000', '05678366','Rua Estado de Israel, 240', 'Centro'),
(2, 'Alexandre', 'alexandre@gmail.com', '111111', '11 987656543', '326543457', '73556944057', '01310200', 'Av. Paulista, 1578', 'Bela Vista'),
(2, 'Fernando', 'fernando@gmail.com', '222222', '11 972084453', '546365253', '16839338002', '04029200', 'Av. Ibirapuera, 2927', 'Indianópolis'),
(2, 'Henrique', 'henrique@gmail.com', '555555', '11 34566543', '543663625', '14332654765', '06402030', 'Rua Vitória, 120', 'Vila Jorge'),
(2, 'Joao', 'joao@hotmail.com', '666666', '11 76566377', '325444441', '91305348010', '09405380','Rua Ver. Geraldo de Camargo, 66', 'Santa Luzia'),
(2, 'Bruno', 'bruno@gmail.com', '777777', '11 954368769', '545662667', '79799299004', '04524001', 'Av. Alameda dos Arapanés, 945', 'Indianópolis'),
(2, 'Mariana', 'mariana@outlook.com', '888888', '' ,'545662668', '13771913039', '06407140', 'Rua Sao Antonio, 232', 'Vila Universal'),
(1, 'Carol', 'carol@gmail.com', '545454', '11 54545454', '545454556', '12323233421', '04022000', 'Rua Estado de Israel, 17', 'Centro'),
(1, 'Saulo', 'saulo@gmail.com', '767676', '11 7676-676', '736432784', '32356236267', '04022000', 'Rua Estado de Israel 1700', 'Centro');

INSERT INTO Medico (IdEspecialidade, IdClinica, IdUsuario, Crm)
VALUES (2, 1, 1, '54256-SP'), (16, 1, 2,'54452-SP'), (17, 1, 3,'65463-SP');

INSERT INTO Administrador (IdClinica, IdUsuario)
VALUES (1, 11) , (1, 12);

INSERT INTO Prontuario (IdUsuario, IdClinica, Altura, Peso, DataNascimento)
VALUES (4, 1, '1,60', '54', '13/10/1983'), (5, 1, '1,80', '75', '23/07/2001'),
(6, 1, '1,87', '65', '10/10/1978'), (7, 1, '1,92', '103', '13/10/1985'), 
(8, 1, '1,43', '58', '27/08/1975'), (9, 1, '1,50', '50', '21/03/1972'),
(10, 1, '1,22', '39', '05/03/2018');

INSERT INTO Consulta (IdClinica, IdProntuario, IdMedico, IdSituacao, DataConsulta, Descricao)
VALUES (1, 6, 1, 4, '20/01/2020 15:00', 'Ressonancia'),(1, 1, 2, 3, '06/01/2020 10:00', 'Exame de Rotina'),
(1, 2, 2, 4, '07/02/2020 11:00', 'Ressonancia'),(1, 5, 2, 4, '06/02/2018 10:00', 'Ressonancia'), 
(1, 3, 1, 3, '07/02/2019 11:00', 'Ressonancia'),(1, 4, 3, 1, '08/03/2020 15:00', 'Ressonancia'),
(1, 7, 1, 1, '09/03/2020', 'Exame de Rotina');

