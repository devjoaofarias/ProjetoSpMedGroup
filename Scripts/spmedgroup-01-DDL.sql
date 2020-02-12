CREATE DATABASE SpMedGroup

USE SpMedGroup

CREATE TABLE Clinica (
IdClinica				INT PRIMARY KEY IDENTITY,
Endereco				VARCHAR(150),
Cnpj					CHAR(14) NOT NULL,
HorarioFuncionamento	VARCHAR(15)
);

CREATE TABLE TipoUsuario (
IdTipoUsuario			INT PRIMARY KEY IDENTITY,
Titulo					VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE Especialidade (
IdEspecialidade			INT PRIMARY KEY IDENTITY,
Titulo					VARCHAR(50) UNIQUE
);

CREATE TABLE Usuario (
IdUsuario				INT PRIMARY KEY IDENTITY,
IdTipoUsuario			INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario),
Nome					VARCHAR(100) NOT NULL,
Email					VARCHAR(100) NOT NULL UNIQUE,
Senha					VARCHAR(20) NOT NULL,
Telefone				VARCHAR(30) NOT NULL,
Rg						CHAR(9) UNIQUE,
Cpf						CHAR(11) UNIQUE,
Endereco				VARCHAR(150)
);

CREATE TABLE Administrador (
IdAdministrador			INT PRIMARY KEY IDENTITY,
IdClinica				INT FOREIGN KEY REFERENCES Clinica(IdClinica),
IdUsuario				INT FOREIGN KEY REFERENCES Usuario(IdUsuario)
);

CREATE TABLE Medico (
IdMedico				INT PRIMARY KEY IDENTITY,
IdEspecialidade			INT FOREIGN KEY REFERENCES Especialidade(IdEspecialidade),
IdClinica				INT FOREIGN KEY REFERENCES Clinica(IdClinica),
IdUsuario				INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
Crm						VARCHAR(15) NOT NULL UNIQUE
);

CREATE TABLE Prontuario (
IdProntuario			INT PRIMARY KEY IDENTITY,
IdUsuario				INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
IdClinica				INT FOREIGN KEY REFERENCES Clinica(IdClinica),
Altura					VARCHAR(15),
DataNascimento			DATE NOT NULL,
Peso					VARCHAR(8)
);

CREATE TABLE Consulta (
IdConsulta				INT PRIMARY KEY IDENTITY,
IdProntuario			INT FOREIGN KEY REFERENCES Prontuario(IdProntuario),
IdMedico				INT FOREIGN KEY REFERENCES Medico(IdMedico),
DataConsulta			DATE NOT NULL,
Descricao				VARCHAR(100),
Situacao				VARCHAR(50) NOT NULL
);

SELECT * FROM Clinica
SELECT * FROM Administrador
SELECT * FROM Usuario
SELECT * FROM Medico
SELECT * FROM Prontuario
SELECT * FROM Consulta
SELECT * FROM TipoUsuario
SELECT * FROM Especialidade