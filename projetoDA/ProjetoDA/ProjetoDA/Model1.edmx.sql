
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/29/2020 13:07:54
-- Generated from EDMX file: C:\Users\jafcu\source\repos\27 cunha\ProjetoDA\ProjetoDA\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [projetoDA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CasaArrendavel_inherits_Casa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Casa_CasaArrendavel] DROP CONSTRAINT [FK_CasaArrendavel_inherits_Casa];
GO
IF OBJECT_ID(N'[dbo].[FK_CasaArrendavelArrendamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArrendamentoSet] DROP CONSTRAINT [FK_CasaArrendavelArrendamento];
GO
IF OBJECT_ID(N'[dbo].[FK_CasaVendavel_inherits_Casa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Casa_CasaVendavel] DROP CONSTRAINT [FK_CasaVendavel_inherits_Casa];
GO
IF OBJECT_ID(N'[dbo].[FK_CasaVendavelVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venda] DROP CONSTRAINT [FK_CasaVendavelVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteArrendamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArrendamentoSet] DROP CONSTRAINT [FK_ClienteArrendamento];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteCasa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Casa] DROP CONSTRAINT [FK_ClienteCasa];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venda] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_LimpezaCasa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Limpeza] DROP CONSTRAINT [FK_LimpezaCasa];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoLimpeza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servico] DROP CONSTRAINT [FK_ServicoLimpeza];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ArrendamentoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArrendamentoSet];
GO
IF OBJECT_ID(N'[dbo].[Casa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Casa];
GO
IF OBJECT_ID(N'[dbo].[Casa_CasaArrendavel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Casa_CasaArrendavel];
GO
IF OBJECT_ID(N'[dbo].[Casa_CasaVendavel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Casa_CasaVendavel];
GO
IF OBJECT_ID(N'[dbo].[Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cliente];
GO
IF OBJECT_ID(N'[dbo].[Limpeza]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Limpeza];
GO
IF OBJECT_ID(N'[dbo].[Servico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servico];
GO
IF OBJECT_ID(N'[dbo].[Venda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Venda];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cliente'
CREATE TABLE [dbo].[Cliente] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Nif] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Casa'
CREATE TABLE [dbo].[Casa] (
    [IdCasa] int IDENTITY(1,1) NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [Andar] nvarchar(max)  NOT NULL,
    [Area] decimal(18,0)  NOT NULL,
    [NumeroAssoalhada] decimal(18,0)  NOT NULL,
    [NumeroWC] decimal(18,0)  NOT NULL,
    [NumeroPisos] decimal(18,0)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Cliente_IdCliente] int  NOT NULL
);
GO

-- Creating table 'ArrendamentoSet'
CREATE TABLE [dbo].[ArrendamentoSet] (
    [IdArrendamento] int IDENTITY(1,1) NOT NULL,
    [InicioContrato] datetime  NOT NULL,
    [DuracaoMeses] int  NOT NULL,
    [Renovavel] bit  NOT NULL,
    [CasaArrendavel_IdCasa] int  NULL,
    [Arrendatario_IdCliente] int  NOT NULL
);
GO

-- Creating table 'Limpeza'
CREATE TABLE [dbo].[Limpeza] (
    [IdLimpeza] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Casa_IdCasa] int  NULL
);
GO

-- Creating table 'Servico'
CREATE TABLE [dbo].[Servico] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Valor] float  NOT NULL,
    [Unidades] int  NOT NULL,
    [Limpeza_IdLimpeza] int  NULL
);
GO

-- Creating table 'Venda'
CREATE TABLE [dbo].[Venda] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [DataVenda] datetime  NOT NULL,
    [ValorNegociado] float  NOT NULL,
    [ComissaoNegociada] float  NOT NULL,
    [Comprador_IdCliente] int  NOT NULL,
    [CasaVendavel_IdCasa] int  NOT NULL
);
GO

-- Creating table 'Casa_CasaArrendavel'
CREATE TABLE [dbo].[Casa_CasaArrendavel] (
    [ValorBaseMes] float  NOT NULL,
    [Comissao] float  NOT NULL,
    [IdCasa] int  NOT NULL
);
GO

-- Creating table 'Casa_CasaVendavel'
CREATE TABLE [dbo].[Casa_CasaVendavel] (
    [ValorBaseVenda] float  NOT NULL,
    [ValorComissao] float  NOT NULL,
    [IdCasa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdCasa] in table 'Casa'
ALTER TABLE [dbo].[Casa]
ADD CONSTRAINT [PK_Casa]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- Creating primary key on [IdArrendamento] in table 'ArrendamentoSet'
ALTER TABLE [dbo].[ArrendamentoSet]
ADD CONSTRAINT [PK_ArrendamentoSet]
    PRIMARY KEY CLUSTERED ([IdArrendamento] ASC);
GO

-- Creating primary key on [IdLimpeza] in table 'Limpeza'
ALTER TABLE [dbo].[Limpeza]
ADD CONSTRAINT [PK_Limpeza]
    PRIMARY KEY CLUSTERED ([IdLimpeza] ASC);
GO

-- Creating primary key on [IdServico] in table 'Servico'
ALTER TABLE [dbo].[Servico]
ADD CONSTRAINT [PK_Servico]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [PK_Venda]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdCasa] in table 'Casa_CasaArrendavel'
ALTER TABLE [dbo].[Casa_CasaArrendavel]
ADD CONSTRAINT [PK_Casa_CasaArrendavel]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- Creating primary key on [IdCasa] in table 'Casa_CasaVendavel'
ALTER TABLE [dbo].[Casa_CasaVendavel]
ADD CONSTRAINT [PK_Casa_CasaVendavel]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CasaArrendavel_IdCasa] in table 'ArrendamentoSet'
ALTER TABLE [dbo].[ArrendamentoSet]
ADD CONSTRAINT [FK_CasaArrendavelArrendamento]
    FOREIGN KEY ([CasaArrendavel_IdCasa])
    REFERENCES [dbo].[Casa_CasaArrendavel]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasaArrendavelArrendamento'
CREATE INDEX [IX_FK_CasaArrendavelArrendamento]
ON [dbo].[ArrendamentoSet]
    ([CasaArrendavel_IdCasa]);
GO

-- Creating foreign key on [Cliente_IdCliente] in table 'Casa'
ALTER TABLE [dbo].[Casa]
ADD CONSTRAINT [FK_ClienteCasa]
    FOREIGN KEY ([Cliente_IdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCasa'
CREATE INDEX [IX_FK_ClienteCasa]
ON [dbo].[Casa]
    ([Cliente_IdCliente]);
GO

-- Creating foreign key on [Casa_IdCasa] in table 'Limpeza'
ALTER TABLE [dbo].[Limpeza]
ADD CONSTRAINT [FK_LimpezaCasa]
    FOREIGN KEY ([Casa_IdCasa])
    REFERENCES [dbo].[Casa]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LimpezaCasa'
CREATE INDEX [IX_FK_LimpezaCasa]
ON [dbo].[Limpeza]
    ([Casa_IdCasa]);
GO

-- Creating foreign key on [Limpeza_IdLimpeza] in table 'Servico'
ALTER TABLE [dbo].[Servico]
ADD CONSTRAINT [FK_ServicoLimpeza]
    FOREIGN KEY ([Limpeza_IdLimpeza])
    REFERENCES [dbo].[Limpeza]
        ([IdLimpeza])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoLimpeza'
CREATE INDEX [IX_FK_ServicoLimpeza]
ON [dbo].[Servico]
    ([Limpeza_IdLimpeza]);
GO

-- Creating foreign key on [Comprador_IdCliente] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([Comprador_IdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Venda]
    ([Comprador_IdCliente]);
GO

-- Creating foreign key on [CasaVendavel_IdCasa] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [FK_CasaVendavelVenda]
    FOREIGN KEY ([CasaVendavel_IdCasa])
    REFERENCES [dbo].[Casa_CasaVendavel]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasaVendavelVenda'
CREATE INDEX [IX_FK_CasaVendavelVenda]
ON [dbo].[Venda]
    ([CasaVendavel_IdCasa]);
GO

-- Creating foreign key on [Arrendatario_IdCliente] in table 'ArrendamentoSet'
ALTER TABLE [dbo].[ArrendamentoSet]
ADD CONSTRAINT [FK_ClienteArrendamento]
    FOREIGN KEY ([Arrendatario_IdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteArrendamento'
CREATE INDEX [IX_FK_ClienteArrendamento]
ON [dbo].[ArrendamentoSet]
    ([Arrendatario_IdCliente]);
GO

-- Creating foreign key on [IdCasa] in table 'Casa_CasaArrendavel'
ALTER TABLE [dbo].[Casa_CasaArrendavel]
ADD CONSTRAINT [FK_CasaArrendavel_inherits_Casa]
    FOREIGN KEY ([IdCasa])
    REFERENCES [dbo].[Casa]
        ([IdCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCasa] in table 'Casa_CasaVendavel'
ALTER TABLE [dbo].[Casa_CasaVendavel]
ADD CONSTRAINT [FK_CasaVendavel_inherits_Casa]
    FOREIGN KEY ([IdCasa])
    REFERENCES [dbo].[Casa]
        ([IdCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------