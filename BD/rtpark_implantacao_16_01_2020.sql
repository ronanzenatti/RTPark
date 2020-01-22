-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 16-Jan-2020 às 16:54
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.3.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `rtpark`
--
CREATE DATABASE IF NOT EXISTS `rtpark` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `rtpark`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `idcliente` int(10) UNSIGNED NOT NULL,
  `nome` varchar(191) NOT NULL,
  `tipo_pessoa` char(1) NOT NULL,
  `doc_fed` varchar(18) DEFAULT NULL,
  `doc_est` varchar(18) DEFAULT NULL,
  `dt_nasc` date DEFAULT NULL,
  `rua` varchar(150) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cep` varchar(10) DEFAULT NULL,
  `telefones` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`idcliente`, `nome`, `tipo_pessoa`, `doc_fed`, `doc_est`, `dt_nasc`, `rua`, `numero`, `bairro`, `cidade`, `estado`, `cep`, `telefones`, `email`) VALUES
(1, 'RONAN ADRIEL ZENATTI', 'F', '355.936.478-79', '41.324.990-6', '1988-02-25', 'RUA DOS LAVRADORES', '302', 'CENTRO', 'BORACÉIA', 'SP', '17.270-032', '(14) 9 8157-5657 / 9 9800-4511', 'ronanzenatti@gmail.com');

-- --------------------------------------------------------

--
-- Estrutura da tabela `config_movimento`
--

DROP TABLE IF EXISTS `config_movimento`;
CREATE TABLE `config_movimento` (
  `idconfig` int(10) UNSIGNED NOT NULL,
  `idestabelecimento` int(10) UNSIGNED NOT NULL,
  `cobranca_padrao` int(10) UNSIGNED NOT NULL,
  `imprime_entrada` char(1) NOT NULL DEFAULT 'P',
  `imprime_saida` char(1) NOT NULL DEFAULT 'P',
  `imprime_end` tinyint(1) UNSIGNED NOT NULL DEFAULT 1,
  `imprime_telefones` tinyint(1) UNSIGNED NOT NULL DEFAULT 0,
  `imprime_cnpj` tinyint(1) UNSIGNED NOT NULL DEFAULT 1,
  `fatura_excedente` char(1) NOT NULL DEFAULT 'P'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `config_movimento`
--

INSERT INTO `config_movimento` (`idconfig`, `idestabelecimento`, `cobranca_padrao`, `imprime_entrada`, `imprime_saida`, `imprime_end`, `imprime_telefones`, `imprime_cnpj`, `fatura_excedente`) VALUES
(1, 1, 1, 'S', 'S', 1, 1, 1, 'I');

-- --------------------------------------------------------

--
-- Estrutura da tabela `contratos`
--

DROP TABLE IF EXISTS `contratos`;
CREATE TABLE `contratos` (
  `idcontrato` int(10) UNSIGNED NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `idcliente` int(10) UNSIGNED NOT NULL,
  `idservico` int(10) UNSIGNED DEFAULT NULL,
  `tipo_pagamento` char(1) NOT NULL,
  `vencimento` tinyint(2) UNSIGNED DEFAULT NULL,
  `dt_inicio` date NOT NULL,
  `dt_fim` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `estabelecimentos`
--

DROP TABLE IF EXISTS `estabelecimentos`;
CREATE TABLE `estabelecimentos` (
  `idestabelecimento` int(10) UNSIGNED NOT NULL,
  `nome` varchar(255) NOT NULL,
  `cnpj` varchar(18) DEFAULT NULL,
  `rua` varchar(150) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `complemento` varchar(50) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cep` varchar(10) DEFAULT NULL,
  `telefones` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `vagas_carro` int(3) UNSIGNED DEFAULT 0,
  `vagas_moto` int(3) UNSIGNED DEFAULT 0,
  `vagas_outros` int(3) UNSIGNED NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `estabelecimentos`
--

INSERT INTO `estabelecimentos` (`idestabelecimento`, `nome`, `cnpj`, `rua`, `numero`, `complemento`, `bairro`, `cidade`, `estado`, `cep`, `telefones`, `email`, `vagas_carro`, `vagas_moto`, `vagas_outros`) VALUES
(1, 'ESTACIONAMENTO - CENTER PARK', '28.260.515/0001-40', 'RUA ARAUJO LEITE', '14-08', NULL, 'CENTRO', 'BAURU', 'SP', '17.015-340', '(14) 9 9182-2630', 'centerparkbauru@gmail.com', 45, 15, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `faturamento`
--

DROP TABLE IF EXISTS `faturamento`;
CREATE TABLE `faturamento` (
  `idfatura` int(10) UNSIGNED NOT NULL,
  `idcontrato` int(10) UNSIGNED NOT NULL,
  `referencia` varchar(7) NOT NULL,
  `lancamento` datetime NOT NULL,
  `vencimento` date NOT NULL,
  `pagamento` date DEFAULT NULL,
  `baixa` datetime DEFAULT NULL,
  `subtotal` decimal(12,2) NOT NULL,
  `juros` decimal(10,2) DEFAULT NULL,
  `multa` decimal(10,2) DEFAULT NULL,
  `desconto` decimal(12,2) DEFAULT NULL,
  `total` decimal(12,2) NOT NULL,
  `tipo_desconto` char(1) DEFAULT NULL,
  `texto` mediumtext DEFAULT NULL,
  `cancelamento` datetime DEFAULT NULL,
  `valor_cancelado` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fat_mov`
--

DROP TABLE IF EXISTS `fat_mov`;
CREATE TABLE `fat_mov` (
  `idfatmov` int(10) UNSIGNED NOT NULL,
  `idfatura` int(10) UNSIGNED NOT NULL,
  `idmovimento` int(10) UNSIGNED NOT NULL,
  `situacao` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `financeiro`
--

DROP TABLE IF EXISTS `financeiro`;
CREATE TABLE `financeiro` (
  `idfinanceiro` int(10) UNSIGNED NOT NULL,
  `idestabelecimento` int(10) UNSIGNED NOT NULL,
  `idfuncionario` int(10) UNSIGNED NOT NULL,
  `descricao` varchar(191) DEFAULT NULL,
  `idmovimento` int(10) UNSIGNED DEFAULT NULL,
  `idfatura` int(10) UNSIGNED DEFAULT NULL,
  `dh_lancamento` datetime NOT NULL,
  `tipo_lancamento` char(1) NOT NULL,
  `id_forma_pagamento` int(10) UNSIGNED NOT NULL,
  `fat_excedente` char(1) DEFAULT NULL,
  `numero_recibo` int(10) UNSIGNED DEFAULT NULL,
  `sub_total` decimal(12,2) NOT NULL,
  `excedente` decimal(12,2) DEFAULT NULL,
  `desconto` decimal(12,2) DEFAULT NULL,
  `total` decimal(12,2) NOT NULL,
  `dinheiro` decimal(12,2) NOT NULL,
  `troco` decimal(12,2) DEFAULT NULL,
  `multa` decimal(10,2) DEFAULT NULL,
  `juros` decimal(10,2) DEFAULT NULL,
  `dh_cancelamento` datetime DEFAULT NULL,
  `motivo_cancelamento` varchar(191) DEFAULT NULL,
  `valor_cancelado` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `forma_pagamento`
--

DROP TABLE IF EXISTS `forma_pagamento`;
CREATE TABLE `forma_pagamento` (
  `idforma` int(10) UNSIGNED NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `taxa` decimal(10,2) UNSIGNED NOT NULL,
  `idestabelecimento` int(10) UNSIGNED NOT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `forma_pagamento`
--

INSERT INTO `forma_pagamento` (`idforma`, `descricao`, `taxa`, `idestabelecimento`, `ativo`) VALUES
(1, 'DINHEIRO', '0.00', 1, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

DROP TABLE IF EXISTS `funcionarios`;
CREATE TABLE `funcionarios` (
  `idfuncionario` int(10) UNSIGNED NOT NULL,
  `nome` varchar(191) NOT NULL,
  `cpf` varchar(15) DEFAULT NULL,
  `rg` varchar(15) DEFAULT NULL,
  `dt_nasc` date DEFAULT NULL,
  `rua` varchar(150) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cep` varchar(10) DEFAULT NULL,
  `telefones` varchar(50) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `salario` decimal(12,2) DEFAULT NULL,
  `usuario` varchar(25) NOT NULL,
  `senha` varchar(191) NOT NULL,
  `tipo` char(1) NOT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`idfuncionario`, `nome`, `cpf`, `rg`, `dt_nasc`, `rua`, `numero`, `bairro`, `cidade`, `estado`, `cep`, `telefones`, `email`, `salario`, `usuario`, `senha`, `tipo`, `ativo`) VALUES
(1, 'ADMINISTRADOR DO SISTEMA', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'SP', NULL, NULL, NULL, '0.00', 'admin', 'WVdSdGFXND0=', 'A', 1),
(2, 'USUARIO PADRAO', NULL, NULL, NULL, NULL, NULL, NULL, 'BAURU', 'SP', NULL, NULL, NULL, '0.00', 'usuario', 'TVRJeg==', 'U', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `movimentos`
--

DROP TABLE IF EXISTS `movimentos`;
CREATE TABLE `movimentos` (
  `idmovimento` int(10) UNSIGNED NOT NULL,
  `dh_entrada` datetime NOT NULL,
  `dh_saida` datetime DEFAULT NULL,
  `placa` varchar(10) NOT NULL,
  `tipo_veiculo` char(1) NOT NULL,
  `veiculo` varchar(100) DEFAULT NULL,
  `vaga` int(10) UNSIGNED NOT NULL,
  `idservico` int(10) UNSIGNED NOT NULL,
  `idfuncionario` int(10) UNSIGNED NOT NULL,
  `idcontrato` int(10) UNSIGNED DEFAULT NULL,
  `permanencia` int(10) UNSIGNED DEFAULT NULL,
  `excedente` int(10) UNSIGNED DEFAULT NULL,
  `periodos` int(10) UNSIGNED DEFAULT NULL,
  `doc_fed` varchar(18) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `servicos`
--

DROP TABLE IF EXISTS `servicos`;
CREATE TABLE `servicos` (
  `idservico` int(10) UNSIGNED NOT NULL,
  `descricao` varchar(150) NOT NULL,
  `tipo_cobranca` char(1) NOT NULL,
  `quantidade` int(10) UNSIGNED NOT NULL,
  `valor_carro` decimal(12,2) NOT NULL,
  `valor_moto` decimal(12,2) NOT NULL,
  `valor_outros` decimal(12,2) NOT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `servicos`
--

INSERT INTO `servicos` (`idservico`, `descricao`, `tipo_cobranca`, `quantidade`, `valor_carro`, `valor_moto`, `valor_outros`, `ativo`) VALUES
(1, 'ATÉ 1/2 HORA', 'I', 30, '2.00', '2.00', '2.00', 1),
(2, 'HORA NORMAL', 'H', 1, '4.00', '3.00', '4.00', 1),
(3, 'MENSAL 1/2 PERIODO', 'M', 1, '80.00', '50.00', '80.00', 1),
(4, 'MENSAL 1 PERIODO', 'M', 1, '130.00', '50.00', '130.00', 1),
(5, 'DIARIA NORMAL', 'D', 1, '20.00', '10.00', '20.00', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculos_clientes`
--

DROP TABLE IF EXISTS `veiculos_clientes`;
CREATE TABLE `veiculos_clientes` (
  `idvc` int(10) UNSIGNED NOT NULL,
  `idcliente` int(10) UNSIGNED NOT NULL,
  `placa` varchar(10) NOT NULL,
  `veiculo` varchar(100) NOT NULL,
  `tipo` char(1) DEFAULT NULL,
  `ativo` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `veiculos_clientes`
--

INSERT INTO `veiculos_clientes` (`idvc`, `idcliente`, `placa`, `veiculo`, `tipo`, `ativo`) VALUES
(1, 1, 'GHZ-4245', 'FORD KA', 'C', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idcliente`);

--
-- Índices para tabela `config_movimento`
--
ALTER TABLE `config_movimento`
  ADD PRIMARY KEY (`idconfig`),
  ADD KEY `fk_estabelecimentos_config` (`idestabelecimento`),
  ADD KEY `fk_servCarro_config` (`cobranca_padrao`);

--
-- Índices para tabela `contratos`
--
ALTER TABLE `contratos`
  ADD PRIMARY KEY (`idcontrato`),
  ADD KEY `fk_clientes_contratos_idx` (`idcliente`);

--
-- Índices para tabela `estabelecimentos`
--
ALTER TABLE `estabelecimentos`
  ADD PRIMARY KEY (`idestabelecimento`);

--
-- Índices para tabela `faturamento`
--
ALTER TABLE `faturamento`
  ADD PRIMARY KEY (`idfatura`),
  ADD KEY `fk_convenio_faturamento_idx` (`idcontrato`);

--
-- Índices para tabela `fat_mov`
--
ALTER TABLE `fat_mov`
  ADD PRIMARY KEY (`idfatmov`),
  ADD KEY `fk_movimento_idx` (`idmovimento`),
  ADD KEY `fk_faturamento_idx` (`idfatura`);

--
-- Índices para tabela `financeiro`
--
ALTER TABLE `financeiro`
  ADD PRIMARY KEY (`idfinanceiro`),
  ADD KEY `fk_estabelecimentos_financeiro_idx` (`idestabelecimento`),
  ADD KEY `fk_funcionarios_financeiro_idx` (`idfuncionario`),
  ADD KEY `fk_forma_financeiro` (`id_forma_pagamento`);

--
-- Índices para tabela `forma_pagamento`
--
ALTER TABLE `forma_pagamento`
  ADD PRIMARY KEY (`idforma`),
  ADD KEY `fk_estabelecimento_formas` (`idestabelecimento`);

--
-- Índices para tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`idfuncionario`);

--
-- Índices para tabela `movimentos`
--
ALTER TABLE `movimentos`
  ADD PRIMARY KEY (`idmovimento`),
  ADD KEY `fk_servicos_movimentos_idx` (`idservico`),
  ADD KEY `fk_funcionarios_movimentos_idx` (`idfuncionario`);

--
-- Índices para tabela `servicos`
--
ALTER TABLE `servicos`
  ADD PRIMARY KEY (`idservico`);

--
-- Índices para tabela `veiculos_clientes`
--
ALTER TABLE `veiculos_clientes`
  ADD PRIMARY KEY (`idvc`),
  ADD KEY `fk_clientes_vc_idx` (`idcliente`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `idcliente` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `config_movimento`
--
ALTER TABLE `config_movimento`
  MODIFY `idconfig` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `contratos`
--
ALTER TABLE `contratos`
  MODIFY `idcontrato` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `estabelecimentos`
--
ALTER TABLE `estabelecimentos`
  MODIFY `idestabelecimento` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `financeiro`
--
ALTER TABLE `financeiro`
  MODIFY `idfinanceiro` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `forma_pagamento`
--
ALTER TABLE `forma_pagamento`
  MODIFY `idforma` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `idfuncionario` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `movimentos`
--
ALTER TABLE `movimentos`
  MODIFY `idmovimento` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `servicos`
--
ALTER TABLE `servicos`
  MODIFY `idservico` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `veiculos_clientes`
--
ALTER TABLE `veiculos_clientes`
  MODIFY `idvc` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `config_movimento`
--
ALTER TABLE `config_movimento`
  ADD CONSTRAINT `fk_estabelecimentos_config` FOREIGN KEY (`idestabelecimento`) REFERENCES `estabelecimentos` (`idestabelecimento`),
  ADD CONSTRAINT `fk_servCarro_config` FOREIGN KEY (`cobranca_padrao`) REFERENCES `servicos` (`idservico`);

--
-- Limitadores para a tabela `contratos`
--
ALTER TABLE `contratos`
  ADD CONSTRAINT `fk_clientes_contratos` FOREIGN KEY (`idcliente`) REFERENCES `clientes` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `financeiro`
--
ALTER TABLE `financeiro`
  ADD CONSTRAINT `fk_estabelecimentos_financeiro` FOREIGN KEY (`idestabelecimento`) REFERENCES `estabelecimentos` (`idestabelecimento`) ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_forma_financeiro` FOREIGN KEY (`id_forma_pagamento`) REFERENCES `forma_pagamento` (`idforma`) ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_funcionarios_financeiro` FOREIGN KEY (`idfuncionario`) REFERENCES `funcionarios` (`idfuncionario`) ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `forma_pagamento`
--
ALTER TABLE `forma_pagamento`
  ADD CONSTRAINT `fk_estabelecimento_formas` FOREIGN KEY (`idestabelecimento`) REFERENCES `estabelecimentos` (`idestabelecimento`) ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `movimentos`
--
ALTER TABLE `movimentos`
  ADD CONSTRAINT `fk_funcionarios_movimentos` FOREIGN KEY (`idfuncionario`) REFERENCES `funcionarios` (`idfuncionario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_servicos_movimentos` FOREIGN KEY (`idservico`) REFERENCES `servicos` (`idservico`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `veiculos_clientes`
--
ALTER TABLE `veiculos_clientes`
  ADD CONSTRAINT `fk_clientes_vc` FOREIGN KEY (`idcliente`) REFERENCES `clientes` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
