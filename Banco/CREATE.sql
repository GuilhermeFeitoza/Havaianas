USE master
IF EXISTS(select * from sys.databases where name='Havaianas')
DROP DATABASE Havaianas
GO
CREATE DATABASE Havaianas
GO 
USE Havaianas




CREATE TABLE tbFuncionario(
	CodigoFunc				int		IDENTITY	PRIMARY KEY Not null,
	NomeFuncionario			Varchar(50),
	Sexo					Char(1)	,
    EmailFuncionario        VARCHAR(50),
	CpfFuncionario			VARCHAR(14),
    NascimentoFuncionario   DATETIME,
	StatusFuncionario		int,
	Logradouro				Varchar(100),
	CEP						Varchar(10),
	UF						char(2),
	Cidade					Varchar(80),
	Bairro					Varchar(80),
	Numero					Varchar(20),
	Complemento				Varchar(100),

)
INSERT INTO tbFuncionario VALUES('Breno','m','breno@gmail.com','12345678911','09/12/2000',1,'oficial','06435190','SP','Barueri','JdTupa','56','oficialdnv')

CREATE TABLE tbUsuario (
    CodigoUsuario       int    IDENTITY primary KEY Not null,
    NomeUsuario         VARCHAR(100)  not null,
    SenhaUsuario        VARCHAR(100),
    StatusUsuario       bit,
	CodigoFunc			int,

	CONSTRAINT FK_tbFunc_tbUsuario FOREIGN KEY (CodigoFunc) REFERENCES tbFuncionario (CodigoFunc) 
)
INSERT INTO tbUsuario VALUES  ('admin','123',1,1)

CREATE TABLE tbCliente (

	CodigoCliente       int PRIMARY KEY IDENTITY    not null,
    NomeCliente         VARCHAR(50)                 not null,
	Sexo				char(1),
	EmailCliente		Varchar(80),
	CpfCliente			Varchar(11),
	Telefone			Varchar(16),
    DataNascimento      DATETIME,
    StatusCliente       BIT,
   )
      

CREATE TABLE tbTipoTitulo(
	CodigoTitulo	Int		IDENTITY Primary Key not null,
	DescricaoTitulo	Varchar(100) not null,
	StatusTitulo bit,
)

CREATE TABLE tbLancamento(
	CodigoLancamento		Int		IDENTITY primary Key not null,
	CodigoTitulo			int	not null,
	DataVencimento			DATETIME not null,
	ValorTitulo				Decimal(7,2),
	StatusPagTitulo			bit,
	DataPagamento			DATETIME,
	ValorPagamento			Decimal(7,2),
	CodigoUsuario			Int,

	CONSTRAINT FK_tbUsuario_tbLancamento FOREIGN KEY (CodigoUsuario) REFERENCES dbo.tbUsuario(CodigoUsuario),
	CONSTRAINT FK_tbTipoTitulo_tbLancamento FOREIGN KEY (CodigoTitulo) REFERENCES dbo.tbTipoTitulo(CodigoTitulo)
)

CREATE TABLE tbCategoria(
	CategoriaID	int IDENTITY	primary key not null,
	Descricao			Varchar(80),
	StatusCategoria		int
)




CREATE TABLE tbProduto(
    CodigoProduto			INT       IDENTITY  PRIMARY KEY  not null,
	CategoriaID				int,
	NomeProduto				VARCHAR(50)                 not null,
    StatusProduto			BIT,
	PrecoProduto			Decimal(7,2),
	FotoDoProduto			Varchar(500),
	Tamanho					VARCHAR(10),
 

	
	CONSTRAINT FK_tbCategoria_Produto FOREIGN KEY (CategoriaID) REFERENCES dbo.tbCategoria (CategoriaID)
 )



CREATE TABLE DBO.tbVendedor(
    CodigoVendedor		INT          PRIMARY KEY   IDENTITY    not null,
    NomeVendedor		VARCHAR(50)						        not null,
    StatusVendedor		BIT,	
	CodigoFunc			int,

	CONSTRAINT FK_tbFunc_tbVendedor FOREIGN KEY (CodigoFunc) REFERENCES dbo.tbFuncionario (CodigoFunc)
 )
go


CREATE TABLE tbVenda(
	CodigoVenda int identity primary key,
	CodigoCliente int NULL,
	CodigoVendedor int,
	DataVenda datetime ,
	ValorTotal decimal(10,2),
	FormaPgto varchar(30),
	FormaPgto2 varchar(30),
	constraint fk_cli_venda foreign key (CodigoCliente) references tbCliente (CodigoCliente),
	constraint fk_func_venda foreign key (CodigoVendedor) references tbVendedor (CodigoVendedor)
		)
CREATE TABLE tbItem_Venda(
CodigoItem_Venda int identity ,
CodigoVenda int, 
CodigoProduto int ,
	constraint fk_venda_itemVenda foreign key (CodigoVenda) references tbVenda (CodigoVenda),
	constraint fk_produto_itemVenda foreign key (CodigoProduto) references tbProduto (CodigoProduto),
)



CREATE TABLE tbEstoque(
CodigoEstoque int primary key  identity ,
CodigoProduto int, 
QuantidadeAtual int,
constraint fk_prod_est foreign key (CodigoProduto) references tbProduto(CodigoProduto)
)


CREATE TABLE tbParcelamentoVenda(
CodigoDetalhe int primary key identity,
CodigoVenda int,
NumeroParcelas int,
constraint fk_ParcelaVenda foreign key (CodigoVenda) references tbVenda (CodigoVenda)
)


CREATE TABLE tbCupom(
Id int identity primary key ,
CodigoCupom varchar(50),
DataInicio DATETIME,
DataFim DATETIME,
ValorDesconto decimal(7,2),
StatusCupom bit ,
QuantidadeCupom int
)


CREATE TABLE tbCupom_cliente(
CodigoCupomCliente int identity primary key,
CodigoCupom int , 
CodigoCliente int ,
StatusCupomCliente bit,
constraint fk_cliente_cupom foreign key (CodigoCliente) references tbCliente (CodigoCliente)




)

CREATE TABLE tbMensagem(
CodigoMensagem int primary key identity,
Nome varchar(200),
Email varchar(100),
Assunto varchar(20),
Mensagem varchar(1000),
StatusMensagem bit,
Data Datetime,
Resposta varchar(1000)


)
INSERT INTO tbMensagem(
Nome ,
Email ,
Assunto,
Mensagem,
StatusMensagem ,
Data) VALUES ('Guilherme','guilherme@gmail.com','Elogio','Gostei muito do atendimento de vocês estão de parabens pelos funcionarios e pelo otimo atendimento',0,'05/10/2019' )

INSERT INTO tbMensagem(
Nome ,
Email ,
Assunto,
Mensagem,
StatusMensagem ,
Data,Resposta) VALUES ('Vinicius','vinici@gmail.com','Critica','Acho que deveriam treinar melhor os atendentes',1,'05/10/2019','Ok iremos melhorar' )



go
CREATE PROCEDURE BaixarCupom
@CodigoCupom char(20)
as
begin
update tbCupom set QuantidadeCupom =QuantidadeCupom-1 Where CodigoCupom=@CodigoCupom 
end




