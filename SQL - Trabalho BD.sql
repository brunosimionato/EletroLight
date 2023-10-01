CREATE DATABASE ELETROLIGHT
GO

USE ELETROLIGHT
GO


CREATE TABLE Usuario (
	id_usuario INT IDENTITY(1, 1),
	usuario NVARCHAR(50) UNIQUE NOT NULL,
	senha NVARCHAR(10) NOT NULL,
	CONSTRAINT PK_id_usuario PRIMARY KEY (id_usuario)
);
GO

INSERT INTO Usuario (usuario, senha)
VALUES ('bruno', '0')
GO


CREATE TABLE Cliente (
    id_cliente INT IDENTITY(1, 1),
    nome NVARCHAR(100) NOT NULL,
    cpf NVARCHAR(14) UNIQUE NOT NULL,
    rg NVARCHAR(10) UNIQUE NOT NULL,
    cep NVARCHAR(9) NOT NULL,
    endereco NVARCHAR(100) NOT NULL,
    cidade NVARCHAR(50) NOT NULL,
    uf NVARCHAR(2) NOT NULL,
    telefone NVARCHAR(15),
    email NVARCHAR(100),
    CONSTRAINT PK_id_cliente PRIMARY KEY (id_cliente)
);
GO

INSERT INTO Cliente (nome, cpf, rg, cep, endereco, cidade, uf, telefone, email) 
VALUES	('Marina Oliveira', '045.789.321-45', '2087654321', '12345-678', 'Avenida das Palmeiras', 'São Paulo', 'SP', '(11) 98765-4321', 'marina.oliveira@gmail.com'),
		('Pedro Santos', '098.765.432-20', '3456789013', '54321-679', 'Rua das Flores', 'Rio de Janeiro', 'RJ', '(21) 98765-4322', 'pedro.santos@gmail.com'),
		('Ana Pereira', '078.321.456-88', '5432109877', '87654-322', 'Rua da Praia', 'Porto Alegre', 'RS', '(51) 98765-4323', 'ana.pereira@gmail.com'),
		('Lucas Oliveira', '056.234.567-36', '6789012346', '45678-902', 'Avenida Central', 'Salvador', 'BA', '(71) 98765-4324', 'lucas.oliveira@gmail.com'),
		('Mariana Silva', '034.567.890-85', '9876543211', '78901-235', 'Rua dos Coqueiros', 'Fortaleza', 'CE', '(85) 98765-4325', 'mariana.silva@gmail.com'),
		('João Silva', '123.456.789-82', '0123456780', '01234-568', 'Rua Principal', 'Belo Horizonte', 'MG', '(31) 98765-4326', 'joao.silva@gmail.com'),
		('Amanda Carolina', '098.765.432-59', '3456789014', '54321-680', 'Rua das Flores', 'Curitiba', 'PR', '(41) 98765-4327', 'amanda.carolina@gmail.com'),
		('Carlos Drumound', '034.567.890-14', '9876543212', '78901-236', 'Avenida Central', 'Recife', 'PE', '(81) 98765-4328', 'carlos.drumound@gmail.com'),
		('Larissa Pereira', '045.789.321-78', '2087654322', '12345-679', 'Rua da Praia', 'Brasília', 'DF', '(61) 98765-4329', 'larissa.pereira@gmail.com'),
		('Rafael Lolu', '056.234.567-71', '6789012347', '45678-903', 'Avenida dos Ipês', 'Florianópolis', 'SC', '(48) 98765-4330', 'rafael.lolu@gmail.com'),
		('Juliana Martins', '078.321.456-00', '5432109870', '87654-323', 'Rua das Palmeiras', 'Natal', 'RN', '(84) 98765-4331', 'juliana.martins@gmail.com'),
		('Roberto Ferreira', '045.789.321-32', '2087654323', '12345-680', 'Avenida dos Pássaros', 'Goiânia', 'GO', '(62) 98765-4332', 'roberto.ferreira@gmail.com'),
		('Patricia Vaz', '034.567.890-51', '9876543213', '78901-237', 'Rua das Cerejeiras', 'Vitória', 'ES', '(27) 98765-4333', 'patricia.vaz@gmail.com'),
		('Paulo Jose', '056.234.567-86', '6789012348', '45678-904', 'Avenida das Flores', 'Maceió', 'AL', '(82) 98765-4334', 'paulo.jose@gmail.com'),
		('Carolina Ferraz', '045.789.321-33', '2087654324', '12345-681', 'Rua dos Lírios', 'Recife', 'PE', '(81) 98765-4335', 'carolina.ferraz@gmail.com');
GO


CREATE TABLE Categoria (
	id_categoria INT IDENTITY(1, 1),
	descricao NVARCHAR(50) UNIQUE NOT NULL,
	CONSTRAINT PK_id_categoria PRIMARY KEY (id_categoria)
);
GO

INSERT INTO Categoria (descricao)
VALUES  ('Lampada'),
		('Fios e Cabos'),
		('Tomadas e Interruptores'),
		('Disjuntores'),
		('Conectores e Emendas'),
		('Ferramentas Elétricas'),
		('Automação Residencial');
GO


CREATE TABLE Fornecedor (
	id_fornecedor INT IDENTITY(1, 1),
	nome NVARCHAR(50) UNIQUE NOT NULL,
	cnpj NVARCHAR(18) UNIQUE NOT NULL,
	cep NVARCHAR(9) NOT NULL,
	endereco NVARCHAR(100) NOT NULL,
	cidade NVARCHAR(50),
	uf NVARCHAR(2),
	telefone NVARCHAR(15),
	email NVARCHAR(100),
	CONSTRAINT PK_id_fornecedor PRIMARY KEY (id_fornecedor)
);
GO

INSERT INTO Fornecedor (nome, cnpj, cep, endereco, cidade, uf, telefone, email)
VALUES  ('JC Eletricidade', '55.666.777/0001-88', '12325-678', 'Rua Conceicao - 23', 'Anapalis', 'GO', '(62) 99999-0000', 'JC@eletricidade.com'),
		('Pezzi', '55.666.150/0001-20', '98765-123', 'Rua Amaral - 89', 'Florianopolis', 'SC', '(56) 99985-2589', 'pezzisolucoes@pezzi.com'),
		('EletroMega', '44.555.666/0001-33', '45678-901', 'Avenida das Indústrias - 123', 'São Paulo', 'SP', '(11) 98765-4321', 'contato@eletromega.com.br'),
		('MegaFios', '55.666.777/0001-22', '78901-234', 'Rua dos Eletricistas - 456', 'Rio de Janeiro', 'RJ', '(21) 98765-4321', 'contato@megafios.com'),
		('Luz&Lar', '11.222.333/0001-44', '23456-789', 'Travessa das Lâmpadas - 789', 'Curitiba', 'PR', '(41) 98765-4321', 'contato@luzelar.com.br'),
		('EletroMix', '22.333.444/0001-55', '34567-890', 'Avenida das Conexões - 901', 'Fortaleza', 'CE', '(85) 98765-4321', 'contato@eletromix.com');
GO


CREATE TABLE Produto (
	id_produto INT IDENTITY(1, 1),
	produto NVARCHAR(50) NOT NULL,
	valor MONEY NOT NULL,
	quantidade INT NOT NULL CHECK (quantidade >0),
	id_fornecedor INT NOT NULL,
	id_categoria INT NOT NULL,
	CONSTRAINT PK_id_produto PRIMARY KEY (id_produto),
	CONSTRAINT FK_id_fornecedor FOREIGN KEY (id_fornecedor) REFERENCES Fornecedor,
	CONSTRAINT FK_id_categoria FOREIGN KEY (id_categoria) REFERENCES Categoria
);
GO

INSERT INTO Produto (produto, valor, quantidade, id_categoria, id_fornecedor)
VALUES  ('Toamada 3X3', 20.90, 20, 1, 1),
		('Interruptor', 15.50, 25, 2, 2),
		('Lâmpada LED 20W', 18.90, 30, 1, 3),
		('Fio Flexível 2.5mm', 2.75, 100, 2, 4),
		('Tomada 2P+T', 12.20, 40, 3, 5),
		('Disjuntor 20A', 8.60, 20, 4, 6),
		('Conector de Emenda Rápida', 1.50, 200, 5, 1),
		('Chave de Fenda Phillips', 6.30, 50, 6, 2),
		('Interruptor Paralelo', 9.80, 35, 2, 3),
		('Fio Flexível 1.5mm', 1.90, 80, 2, 4),
		('Automação para Iluminação', 35.50, 15, 7, 5),
		('Ferramenta de Corte Diagonal', 12.90, 30, 6, 6),
		('Disjuntor 40A', 12.30, 15, 4, 1),
		('Lâmpada LED 15W', 15.90, 25, 1, 2),
		('Interruptor Paralelo Simples', 6.70, 40, 3, 3),
		('Fio Flexível 4mm', 3.50, 75, 2, 4),
		('Tomada 2P', 8.90, 30, 3, 5),
		('Ferramenta de Teste de Voltagem', 9.50, 20, 6, 6),
		('Conector de Derivação', 1.20, 100, 5, 1),
		('Luminária de Teto LED', 29.90, 10, 1, 2),
		('Chave de Fenda de Precisão', 4.20, 50, 6, 3),
		('Plug Macho 2P+T', 5.80, 45, 3, 4),
		('Disjuntor 63A', 18.50, 18, 4, 5),
		('Fio Flexível 6mm', 5.20, 60, 2, 6);
GO


CREATE TABLE Pedido (
	id_pedido INT IDENTITY(1, 1),
	id_cliente INT NOT NULL,
	cpf NVARCHAR(14) NOT NULL,
	id_produto INT NOT NULL,
	quantidade INT NOT NULL CHECK (quantidade >0),
	data DATE,
	valor_unitario MONEY,
	valor_total MONEY,
	CONSTRAINT PK_id_pedido PRIMARY KEY (id_pedido),
	CONSTRAINT FK_id_cliente FOREIGN KEY (id_cliente) REFERENCES Cliente (id_cliente),
	CONSTRAINT FK_id_produto FOREIGN KEY (id_produto) REFERENCES Produto (id_produto)
);
GO

INSERT INTO Pedido (id_cliente, cpf, id_produto, quantidade, data, valor_unitario, valor_total)
VALUES (1, '045.789.321-45', 1, 5, '2023-09-30', 20.90, 104.50),
       (2, '098.765.432-20', 2, 8, '2023-09-29', 15.50, 124.00),
       (3, '078.321.456-88', 3, 10, '2023-09-28', 18.90, 189.00),
       (4, '056.234.567-36', 4, 3, '2023-09-27', 2.70, 8.10),
       (5, '034.567.890-85', 5, 15, '2023-09-26', 12.50, 187.50),
       (6, '123.456.789-82', 6, 2, '2023-09-25', 8.60, 17.20),
       (7, '098.765.432-59', 7, 6, '2023-09-24', 1.50, 9.00),
       (8, '034.567.890-14', 8, 4, '2023-09-23', 6.30, 25.20),
       (9, '045.789.321-78', 9, 7, '2023-09-22', 9.80, 68.60),
       (10, '056.234.567-71', 10, 1, '2023-09-21', 1.90, 1.90),
       (11, '078.321.456-00', 11, 12, '2023-09-20', 35.50, 426.00),
       (12, '045.789.321-32', 12, 9, '2023-09-19', 12.90, 116.11),
       (13, '034.567.890-51', 13, 5, '2023-09-18', 12.30, 61.50),
       (14, '056.234.567-86', 14, 8, '2023-09-17', 15.90, 127.20),
       (15, '045.789.321-33', 15, 10, '2023-09-16', 6.70, 67.00),
       (6, '123.456.789-82', 16, 3, '2023-09-15', 3.30, 9.90),
       (7, '098.765.432-59', 17, 15, '2023-09-14', 8.90, 133.50),
       (9, '045.789.321-78', 18, 2, '2023-09-13', 9.50, 19.00),
       (3, '078.321.456-88', 19, 6, '2023-09-12', 1.20, 7.20),
       (14, '056.234.567-86', 20, 4, '2023-09-11', 29.90, 119.60),
       (14, '056.234.567-86', 21, 7, '2023-09-10', 4.20, 29.40),
	   (6, '123.456.789-82', 22, 3, '2023-09-28', 5.80, 17.40),
	   (9, '045.789.321-78', 23, 7, '2023-09-02', 18.50, 129.50),
       (10, '056.234.567-71', 24, 1, '2023-09-09', 5.20, 5.20);
GO


CREATE TABLE PedidoExcluido (
	id_pedido_excluido INT IDENTITY(1, 1),
	id_pedido INT NOT NULL,
    cliente NVARCHAR(100) NOT NULL,
	cpf NVARCHAR(14) NOT NULL,
	produto NVARCHAR(50) NOT NULL,
	quantidade INT NOT NULL CHECK (quantidade >0),
	data DATE DEFAULT GETDATE(),
	valor_unitario MONEY,
	valor_total MONEY,
);
GO

INSERT INTO PedidoExcluido (id_pedido, cliente, cpf, produto, quantidade, data, valor_unitario, valor_total)
VALUES	(25, 'Marina Oliveira', '045.789.321-45', 'Toamada 3X3', 2, '2023-09-09', 20.90, 41.80),
		(26, 'Pedro Santos', '098.765.432-20', 'Automação para Iluminação', 3, '2023-09-08', 35.50, 106.50),
		(27, 'Ana Pereira','078.321.456-88', 'Ferramenta de Corte Diagonal', 1, '2023-09-07', 12.90, 12.90),
		(28, 'Marina Oliveira', '056.234.567-36', 'Toamada 3X3', 4, '2023-09-06', 20.90, 83.60),
		(29, 'Marina Oliveira', '045.789.321-45', 'Lâmpada LED 20W', 5, '2023-09-04', 18.90, 94.50),
		(30, 'Amanda Carolina','098.765.432-59', 'Fio Flexível 2.5mm', 10, '2023-09-03', 2.70, 27.00),
		(31, 'Patricia Vaz','034.567.890-51', 'Fio Flexível 2.5mm', 3, '2023-09-03', 2.70, 8.10),
		(32, 'Pedro Santos','098.765.432-20', 'Disjuntor 63A', 1, '2023-09-07', 18.50, 18.50),
		(33, 'Lucas Oliveira', '056.234.567-36', 'Chave de Fenda de Precisão', 4, '2023-09-06', 4.20, 16.80),
		(34, 'Mariana Silva', '034.567.890-85', 'Tomada 2P', 5, '2023-09-04', 8.90, 44.50),
		(35, 'Carlos Drumound','034.567.890-14', 'Interruptor Paralelo Simples', 2, '2023-09-03', 6.70, 13.40),
		(36, 'Juliana Martins','078.321.456-00', 'Plug Macho 2P+T', 1, '2023-09-03', 5.80, 5.80),
		(39, 'Paulo Jose','056.234.567-86', 'Ferramenta de Corte Diagonal', 2, '2023-09-03', 12.90, 25.80),
		(40, 'Carolina Ferraz','045.789.321-33', 'Chave de Fenda Phillips', 1, '2023-09-03', 6.30, 6.30);
GO


-- TRIGGER PARA PREENCHER A TABELA DE PEDIDOS EXCLUIDOS --
CREATE TRIGGER TriggerPedidoExcluido
ON Pedido
AFTER DELETE
AS
BEGIN
    INSERT INTO PedidoExcluido (id_pedido, cliente, cpf, produto, quantidade, data, valor_unitario, valor_total)
    SELECT
        d.id_pedido,
        c.nome,
        d.cpf,
        p.produto,
        d.quantidade,
        GETDATE(),
        d.valor_unitario,
        d.valor_total
    FROM
        deleted d
    INNER JOIN Cliente c ON c.id_cliente = d.id_cliente
    INNER JOIN Produto p ON p.id_produto = d.id_produto;
END;
GO

------------------------------------------------------------------------------------------


-- FORM USUÁRIOS --
-- Botão Incluir Usuário --
CREATE PROCEDURE IncluirUsuario
    @usuario NVARCHAR(50),
    @senha NVARCHAR(10)
AS
BEGIN
    INSERT INTO Usuario (usuario, senha)
    VALUES (@usuario, @senha);
END;
GO

-- Botão Consultar Usuário --
CREATE PROCEDURE ConsultarUsuario
    @id_usuario INT
AS
BEGIN
    SELECT *
    FROM Usuario
    WHERE id_usuario = @id_usuario;
END;
GO

-- Botão Excluir Usuario --
CREATE PROCEDURE ExcluirUsuario
    @id_usuario INT
AS
BEGIN
    DELETE FROM Usuario WHERE id_usuario = @id_usuario;
END;
GO

-- Botão Atualizar Usuario --
CREATE PROCEDURE AtualizarUsuario
    @id_usuario INT,
    @usuario NVARCHAR(50),
	@senha NVARCHAR(10)
AS
BEGIN
    UPDATE Usuario
    SET 
        usuario = @usuario,
		senha = @senha
    WHERE id_usuario = @id_usuario;
END;
GO



-- FORM CLIENTE --
------------------------------------------------------------------------------------------
-- Botão Incluir Cliente --
CREATE PROCEDURE IncluirCliente
    @nome NVARCHAR(100),
    @cpf NVARCHAR(14),
    @rg NVARCHAR(10),
    @cep NVARCHAR(9),
    @endereco NVARCHAR(100),
    @cidade NVARCHAR(50),
    @uf NVARCHAR(2),
    @telefone NVARCHAR(15),
    @email NVARCHAR(100)
AS
BEGIN
    INSERT INTO Cliente (nome, cpf, rg, cep, endereco, cidade, uf, telefone, email)
    VALUES (@nome, @cpf, @rg, @cep, @endereco, @cidade, @uf, @telefone, @email);
END;
GO

-- Botão Consultar Cliente --
CREATE PROCEDURE ConsultarCliente
    @nome NVARCHAR(100),
    @cpf NVARCHAR(14),
    @rg NVARCHAR(10)
AS
BEGIN
    SELECT * FROM Cliente
    WHERE (@nome IS NOT NULL AND nome = @nome)
       OR (@cpf IS NOT NULL AND cpf = @cpf)
       OR (@rg IS NOT NULL AND rg = @rg);
END;
GO

-- Botão Excluir Cliente --
CREATE PROCEDURE ExcluirCliente
    @id_cliente INT
AS
BEGIN
    DELETE FROM Cliente WHERE id_cliente = @id_cliente;
END;
GO

-- Botão Atualizar Cliente --
CREATE PROCEDURE AtualizarCliente
    @id_cliente INT,
    @nome NVARCHAR(100),
	@cpf NVARCHAR(14),
	@rg NVARCHAR(10),
    @cep NVARCHAR(9),
    @endereco NVARCHAR(100),
    @cidade NVARCHAR(50),
    @uf NVARCHAR(2),
    @telefone NVARCHAR(15),
    @email NVARCHAR(100)
AS
BEGIN
    UPDATE Cliente
    SET 
        nome = @nome,
		cpf = @cpf,
		rg = @rg,
        cep = @cep,
        endereco = @endereco,
        cidade = @cidade,
        uf = @uf,
        telefone = @telefone,
        email = @email
    WHERE id_cliente = @id_cliente;
END;
GO



-- FORM FORNECEDOR --
------------------------------------------------------------------------------------------
-- Botão Incluir Fornecedor --
CREATE PROCEDURE IncluirFornecedor
    @nome NVARCHAR(100),
    @cnpj NVARCHAR(18),
    @cep NVARCHAR(9),
    @endereco NVARCHAR(100),
    @cidade NVARCHAR(50),
    @uf NVARCHAR(2),
    @telefone NVARCHAR(15),
    @email NVARCHAR(100)
AS
BEGIN
    INSERT INTO Fornecedor(nome, cnpj, cep, endereco, cidade, uf, telefone, email)
    VALUES (@nome, @cnpj, @cep, @endereco, @cidade, @uf, @telefone, @email);
END;
GO

-- Botão Consultar Fornecedor --
CREATE PROCEDURE ConsultarFornecedor
    @nome NVARCHAR(100),
    @cnpj NVARCHAR(18)
AS
BEGIN
    SELECT * FROM Fornecedor
    WHERE (@nome IS NOT NULL AND nome = @nome)
       OR (@cnpj IS NOT NULL AND cnpj = @cnpj);
END;
GO

-- Botão Excluir Fornecedor --
CREATE PROCEDURE ExcluirFornecedor
    @id_fornecedor INT
AS
BEGIN
    DELETE FROM Fornecedor WHERE id_fornecedor = @id_fornecedor;
END;
GO

-- Botão Atualizar Fornecedor --
CREATE PROCEDURE AtualizarFornecedor
    @id_fornecedor INT,
    @nome NVARCHAR(100),
	@cnpj NVARCHAR(18),
    @cep NVARCHAR(9),
    @endereco NVARCHAR(100),
    @cidade NVARCHAR(50),
    @uf NVARCHAR(2),
    @telefone NVARCHAR(15),
    @email NVARCHAR(100)
AS
BEGIN
    UPDATE Fornecedor
    SET 
        nome = @nome,
		cnpj = @cnpj,
        cep = @cep,
        endereco = @endereco,
        cidade = @cidade,
        uf = @uf,
        telefone = @telefone,
        email = @email
    WHERE id_fornecedor = @id_fornecedor;
END;
GO



-- FORM CATEGORIA --
------------------------------------------------------------------------------------------
-- Botão Incluir Categoria --
CREATE PROCEDURE IncluirCategoria
    @descricao NVARCHAR(50)
AS
BEGIN
    INSERT INTO Categoria (descricao)
    VALUES (@descricao)
END;
GO

-- Botão Consultar Categoria --
CREATE PROCEDURE ConsultarCategoria
    @id_categoria INT,
	@descricao NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Categoria
	WHERE	(@id_categoria IS NOT NULL AND id_categoria = @id_categoria)
			OR (@descricao IS NOT NULL AND descricao = @descricao);
END;
GO

-- Botão Excluir Categoria --
CREATE PROCEDURE ExcluirCategoria
     @id_categoria INT
AS
BEGIN
    DELETE FROM Categoria WHERE id_categoria = @id_categoria;
END;
GO

-- Botão Atualizar Categoria --
CREATE PROCEDURE AtualizarCategoria
    @id_categoria INT,
    @categoria NVARCHAR(50)
AS
BEGIN
    UPDATE Categoria
    SET 
        descricao = @categoria
    WHERE id_categoria = @id_categoria;
END;
GO



-- FORM PRODUTO --
------------------------------------------------------------------------------------------
-- Botão Incluir Produto --
CREATE PROCEDURE IncluirProduto 
    @produto NVARCHAR(50),
    @categoria NVARCHAR(50),
    @valor MONEY,
    @quantidade INT,
    @fornecedor NVARCHAR(50)
AS
BEGIN
    DECLARE @id_fornecedor INT
    DECLARE @id_categoria INT

    SELECT @id_fornecedor = id_fornecedor 
    FROM Fornecedor 
    WHERE nome = @fornecedor

    SELECT @id_categoria = id_categoria 
    FROM Categoria 
    WHERE descricao = @categoria

    INSERT INTO Produto (produto, valor, quantidade, id_fornecedor, id_categoria)
    VALUES (@produto, @valor, @quantidade, @id_fornecedor, @id_categoria)
END;
GO

-- Botão Consultar Produto --
CREATE PROCEDURE ConsultarProduto
    @produto NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Produto
	WHERE	(@produto IS NOT NULL AND produto = @produto)
END;
GO

-- Botão Excluir Produto
CREATE PROCEDURE ExcluirProduto
    @id_produto INT
AS
BEGIN
    DELETE FROM Produto WHERE id_produto = @id_produto;
END;
GO

-- Botão Atualizar Produto --
CREATE PROCEDURE AtualizarProduto 
    @id_produto INT,
    @produto NVARCHAR(50),
    @categoria NVARCHAR(50),
    @valor MONEY,
    @quantidade INT,
    @fornecedor NVARCHAR(50)
AS
BEGIN
    DECLARE @id_fornecedor INT
    DECLARE @id_categoria INT

    SELECT @id_fornecedor = id_fornecedor 
    FROM Fornecedor 
    WHERE nome = @fornecedor

    SELECT @id_categoria = id_categoria 
    FROM Categoria 
    WHERE descricao = @categoria

    UPDATE Produto
    SET produto = @produto,
        valor = @valor,
        quantidade = @quantidade,
        id_fornecedor = @id_fornecedor,
        id_categoria = @id_categoria
    WHERE id_produto = @id_produto
END;
GO



-- FORM PEDIDO
------------------------------------------------------------------------------------------
-- Função para inserir o valor unitário com base no produto selecionado na combo box --
CREATE FUNCTION ObterValorUnitarioProduto (@produto NVARCHAR(100))
RETURNS MONEY
AS
BEGIN
    DECLARE @valor MONEY

    SELECT @valor = valor
    FROM Produto
    WHERE produto = @produto

    RETURN @valor
END;
GO

-- Função para inserir o valor total com base na quantidade e valor unitário do produto --
CREATE FUNCTION CalcularValorTotal (@quantidade INT, @valor_unitario MONEY)
RETURNS MONEY
AS
BEGIN
    DECLARE @valor_total MONEY
    SET @valor_total = @quantidade * @valor_unitario
    RETURN @valor_total
END;
GO

-- View para para preencher o Data Grid View e também o ReportViewer--
CREATE VIEW view_Pedido AS
SELECT 
    p.id_pedido,
    c.nome AS nome_cliente,
    p.cpf,
    pr.produto,
    p.quantidade,
    p.data,
    p.valor_unitario,
    p.valor_total
FROM 
    Pedido p
JOIN 
    Cliente c ON p.id_cliente = c.id_cliente
JOIN 
    Produto pr ON p.id_produto = pr.id_produto;
GO

-- Botão Incluir Pedido --
CREATE PROCEDURE InserirPedido
    @cliente NVARCHAR(50),
	@cpf NVARCHAR(18),
    @produto NVARCHAR(50),
    @quantidade INT,
    @data DATE,
    @valor_unitario MONEY,
    @valor_total MONEY
AS
BEGIN
    DECLARE @id_cliente INT
    DECLARE @id_produto INT

    SELECT @id_cliente = id_cliente FROM Cliente WHERE nome = @cliente

    SELECT @id_produto = id_produto FROM Produto WHERE produto = @produto

    INSERT INTO Pedido (id_cliente, cpf, id_produto, quantidade, data, valor_unitario, valor_total)
    VALUES (@id_cliente, (SELECT cpf FROM Cliente WHERE id_cliente = @id_cliente), @id_produto, @quantidade, @data, @valor_unitario, @valor_total)
END
GO

-- Botão Consultar Pedido --
CREATE PROCEDURE ConsultarPedido
    @id_pedido int
AS
BEGIN
    SELECT * FROM Pedido
    WHERE id_pedido = @id_pedido;
END;
GO

-- Botão Excluir Pedido -- 
CREATE PROCEDURE ExcluirPedido
    @id_pedido INT
AS
BEGIN
    DELETE FROM Pedido WHERE id_pedido = @id_pedido;
END;
GO

-- Botão Atualizar Pedido --
CREATE PROCEDURE AtualizarPedido
    @cliente NVARCHAR(100),
	@id_pedido INT,
    @produto NVARCHAR(50),
    @quantidade INT,
    @data DATE,
	@valor_unitario MONEY,
	@valor_total MONEY
AS
BEGIN
    DECLARE @id_cliente INT
    DECLARE @id_produto INT

    SELECT @id_cliente = id_cliente 
    FROM Cliente
    WHERE nome = @cliente

    SELECT @id_produto = id_produto 
    FROM Produto 
    WHERE produto = @produto

	UPDATE Pedido
	SET id_cliente = @id_cliente,
		id_produto = @id_produto, 
		quantidade = @quantidade,
		data = @data,
		valor_unitario = @valor_unitario,
		valor_total = @valor_total
	WHERE id_pedido = @id_pedido
END;
GO
