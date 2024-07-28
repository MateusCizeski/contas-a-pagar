CREATE TABLE Fornecedor (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    CNPJ VARCHAR(14) NOT NULL UNIQUE,
    Endereco TEXT
);

CREATE TABLE Fatura (
    Id SERIAL PRIMARY KEY,
    DataEmissao TIMESTAMP NOT NULL,
    DataVencimento TIMESTAMP NOT NULL,
    Valor DECIMAL(18, 2) NOT NULL,
    Descricao TEXT,
    CodigoFornecedor INT NOT NULL,
    FOREIGN KEY (CodigoFornecedor) REFERENCES Fornecedor(CodigoFornecedor)
);

CREATE TABLE contas_pagar.Metodo_Pagamento (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL
);

CREATE TABLE Pagamento (
    Id SERIAL PRIMARY KEY,
    DataPagamento TIMESTAMP NOT NULL,
    ValorPago DECIMAL(18, 2) NOT NULL,
    CodigoMetodoPagamento INT NOT NULL,
    FOREIGN KEY (CodigoMetodoPagamento) REFERENCES MetodoPagamento(CodigoMetodoPagamento)
);

CREATE TABLE FaturaPagamento (
    CodigoFatura INT NOT NULL,
    CodigoPagamento INT NOT NULL,
    PRIMARY KEY (CodigoFatura, CodigoPagamento),
    FOREIGN KEY (CodigoFatura) REFERENCES Fatura(CodigoFatura),
    FOREIGN KEY (CodigoPagamento) REFERENCES Pagamento(CodigoPagamento)
);

CREATE TABLE contas_pagar.Metodo_Pagamento (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL
);

ALTER TABLE contas_pagar.Pagamentos
ADD COLUMN Codigo_Metodo_Pagamento INT NOT NULL;

ALTER TABLE contas_pagar.Pagamentos
ADD CONSTRAINT FK_Pagamento_MetodoPagamento
FOREIGN KEY (Codigo_Metodo_Pagamento) REFERENCES contas_pagar.Metodo_Pagamento(Id);