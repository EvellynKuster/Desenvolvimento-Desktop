CREATE DATABASE IF NOT EXISTS multapps_dev;
USE multapps_dev;

CREATE TABLE IF NOT EXISTS  categoria(
	id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(250) NOT NULL,
    data_criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP NOT NULL,
    data_alteracao TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    status ENUM ('inativo', 'ativo', 'excluido') NOT NULL,
    
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS  produto(
	id INT NOT NULL AUTO_INCREMENT,
	categoria_id INT NOT NULL,
    nome VARCHAR(250) NOT NULL,
    preco DECIMAL NOT NULL,
    quantidade_estoque INT NOT NULL,
    data_criacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP NOT NULL,
    data_alteracao TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    status ENUM ('inativo', 'ativo', 'excluido') NOT NULL,
    
    PRIMARY KEY(id),
    FOREIGN KEY (categoria_id) REFERENCES categoria(id)
);