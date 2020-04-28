CREATE DATABASE SpMedGroup_Joao;
GO

USE SpMedGroup_Joao;
GO

CREATE TABLE Estado (
	IdEstado				INT PRIMARY KEY IDENTITY,
	NomeEstado				VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Cidade (
	IdCidade				INT PRIMARY KEY IDENTITY,
	IdEstado				INT FOREIGN KEY REFERENCES Estado(IdEstado),
	NomeCidade				VARCHAR(100) NOT NULL
);

CREATE TABLE Clinica (
	IdClinica				INT PRIMARY KEY IDENTITY,
	IdCidade				INT FOREIGN KEY REFERENCES Cidade(IdCidade) NOT NULL,
	NomeClinica				VARCHAR(100) NOT NULL,
	Cnpj					CHAR(14) UNIQUE NOT NULL,
	Cep						CHAR(8) UNIQUE NOT NULL,
	Logradouro				VARCHAR(100) NOT NULL,
	Bairro					VARCHAR(75) NOT NULL,
	HorarioInicial			VARCHAR(15) NOT NULL,
	HorarioFinal			VARCHAR(15) NOT NULL,
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
	Rg						CHAR(9) UNIQUE ,
	Cpf						CHAR(11) UNIQUE NOT NULL,
	Cep						CHAR(8),
	Logradouro				VARCHAR(100),
	Bairro					VARCHAR(50)
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
	Peso					VARCHAR(7)
);

CREATE TABLE Situacao (
	IdSituacao				INT PRIMARY KEY IDENTITY,
	NomeSituacao			VARCHAR(35)
);

CREATE TABLE Consulta (
	IdConsulta				INT PRIMARY KEY IDENTITY,
	IdClinica				INT FOREIGN KEY REFERENCES Clinica(IdClinica) NOT NULL,
	IdProntuario			INT FOREIGN KEY REFERENCES Prontuario(IdProntuario) NOT NULL,
	IdMedico				INT FOREIGN KEY REFERENCES Medico(IdMedico) NOT NULL,
	IdSituacao				INT FOREIGN KEY REFERENCES Situacao(IdSituacao) NOT NULL,
	DataConsulta			SMALLDATETIME NOT NULL,
	Descricao				VARCHAR(100),
);



