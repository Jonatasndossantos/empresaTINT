create database tintCSharp;
use tintCSharp;

create table pessoa(
	codigo int not null primary key,
    nome varchar(150) not null,
    telefone varchar(13) not null,
    endereco varchar(150) not null
)engine = InnoDB;

select * from pessoa;