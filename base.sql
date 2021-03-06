create table PRODUTO(
ID_PRODUTO INT NOT NULL,
NOME VARCHAR(255) NOT NULL,
CODIGO INT NOT NULL,
ESTOQUE INT NOT NULL
)

create table USUARIO(
ID_USUARIO INT NOT NULL,
NOME VARCHAR(255) NOT NULL
)

create table VENDEDOR(
ID_VENDEDOR INT NOT NULL,
NOME VARCHAR(255) NOT NULL
)

create table FORMA_PAGAMENTO(
ID_FORMAPAGAMENTO INT NOT NULL,
NOME VARCHAR(255) NOT NULL
)

create table PEDIDO_STATUS(
ID_PEDIDOSTATUS INT NOT NULL,
NOME VARCHAR(255) NOT NULL,
primary KEY (ID_PEDIDOSTATUS)
)

ALTER TABLE forma_pagamento ADD PRIMARY KEY (ID_FORMAPAGAMENTO);
-- para todas as tabelas

create table PEDIDO(
ID_PEDIDO INT NOT NULL,
USUARIO_ID INT NOT NULL,
VENDEDOR_ID INT NOT NULL,
FORMAPAGAMENTO_ID INT NOT NULL,
PRIMARY KEY (ID_PEDIDO),
foreign KEY (USUARIO_ID) references usuario(ID_USUARIO),
foreign KEY (VENDEDOR_ID) references vendedor(ID_VENDEDOR),
foreign KEY (FORMAPAGAMENTO_ID) references forma_pagamento(ID_FORMAPAGAMENTO)
)

create table PEDIDO_PRODUTO(
ID_PEDIDOPRODUTO INT NOT NULL,
QUANTIDADE NUMERIC NOT NULL,
VALOR NUMERIC NOT null,
PEDIDO_ID INT NOT NULL,
PRODUTO_ID INT NOT NULL,
primary key (ID_PEDIDOPRODUTO),
foreign KEY (PEDIDO_ID) references pedido(ID_PEDIDO),
foreign KEY (PRODUTO_ID) references produto(ID_PRODUTO)
)






