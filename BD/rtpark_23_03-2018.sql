-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 23, 2018 at 08:58 AM
-- Server version: 10.1.22-MariaDB
-- PHP Version: 7.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rtpark`
--
CREATE DATABASE IF NOT EXISTS `rtpark` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `rtpark`;

-- --------------------------------------------------------

--
-- Table structure for table `clientes`
--

CREATE TABLE `clientes` (
  `idcliente` int(10) UNSIGNED NOT NULL,
  `nome` varchar(191) NOT NULL,
  `tipo_pessoa` char(1) NOT NULL,
  `doc_fed` varchar(18) DEFAULT NULL,
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

-- --------------------------------------------------------

--
-- Table structure for table `config_movimento`
--

CREATE TABLE `config_movimento` (
  `idconfig` int(10) UNSIGNED NOT NULL,
  `idestabelecimento` int(10) UNSIGNED NOT NULL,
  `cobranca_padrao_carro` int(10) UNSIGNED NOT NULL,
  `cobranca_padrao_moto` int(10) UNSIGNED NOT NULL,
  `imprime_entrada` char(1) NOT NULL DEFAULT 'P',
  `imprime_saida` char(1) NOT NULL DEFAULT 'P',
  `imprime_end` char(1) NOT NULL DEFAULT 'S',
  `imprime_telefones` char(1) NOT NULL DEFAULT 'N',
  `imprime_cnpj` char(1) NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `contratos`
--

CREATE TABLE `contratos` (
  `idcontrato` int(10) UNSIGNED NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `idestabelecimento` int(10) UNSIGNED NOT NULL,
  `idcliente` int(10) UNSIGNED NOT NULL,
  `idservico` int(10) UNSIGNED DEFAULT NULL,
  `tipo_pagamento` char(1) NOT NULL,
  `vencimento` tinyint(2) UNSIGNED DEFAULT NULL,
  `dt_inicio` date NOT NULL,
  `dt_fim` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `estabelecimentos`
--

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
  `dt_inicio` date DEFAULT NULL,
  `dt_fim` date DEFAULT NULL,
  `vagas_carro` int(10) UNSIGNED DEFAULT NULL,
  `vagas_moto` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `faturamento`
--

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
  `texto` mediumtext,
  `cancelamento` datetime DEFAULT NULL,
  `valor_cancelado` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `fat_mov`
--

CREATE TABLE `fat_mov` (
  `idfatmov` int(10) UNSIGNED NOT NULL,
  `idfatura` int(10) UNSIGNED NOT NULL,
  `idmovimento` int(10) UNSIGNED NOT NULL,
  `situacao` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `financeiro`
--

CREATE TABLE `financeiro` (
  `idfinanceiro` int(10) UNSIGNED NOT NULL,
  `idestabelecimento` int(10) UNSIGNED NOT NULL,
  `idfuncionario` int(10) UNSIGNED NOT NULL,
  `descricao` varchar(191) DEFAULT NULL,
  `idmovimento` int(10) UNSIGNED DEFAULT NULL,
  `idfatura` int(10) UNSIGNED DEFAULT NULL,
  `dh_lancamento` datetime NOT NULL,
  `tipo_lancamento` char(1) NOT NULL,
  `forma_pagamento` int(10) UNSIGNED NOT NULL,
  `fat_excedente` char(1) NOT NULL,
  `numero_recibo` int(10) UNSIGNED DEFAULT NULL,
  `sub_total` decimal(12,2) NOT NULL,
  `excedente` decimal(12,2) DEFAULT NULL,
  `desconto` decimal(12,2) DEFAULT NULL,
  `total` decimal(12,2) NOT NULL,
  `dinheiro` decimal(12,2) DEFAULT NULL,
  `troco` decimal(12,2) DEFAULT NULL,
  `multa` decimal(10,2) DEFAULT NULL,
  `juros` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `forma_pagamento`
--

CREATE TABLE `forma_pagamento` (
  `idforma` int(10) UNSIGNED NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `taxa` decimal(10,2) UNSIGNED NOT NULL,
  `idestabelecimento` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `funcionarios`
--

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
  `ativo` bit(1) NOT NULL DEFAULT b'1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `movimentos`
--

CREATE TABLE `movimentos` (
  `idmovimento` int(10) UNSIGNED NOT NULL,
  `idestabelecimento` int(10) UNSIGNED NOT NULL,
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
  `periodos` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `servicos`
--

CREATE TABLE `servicos` (
  `idservico` int(10) UNSIGNED NOT NULL,
  `idestabelecimento` int(10) UNSIGNED NOT NULL,
  `descricao` varchar(150) NOT NULL,
  `tipo_cobranca` char(1) NOT NULL,
  `quantidade` int(10) UNSIGNED NOT NULL,
  `valor` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `veiculos_clientes`
--

CREATE TABLE `veiculos_clientes` (
  `idvc` int(10) UNSIGNED NOT NULL,
  `idcliente` int(10) UNSIGNED NOT NULL,
  `placa` varchar(10) NOT NULL,
  `veiculo` varchar(100) NOT NULL,
  `ativo` tinyint(4) NOT NULL DEFAULT '1',
  `dt_exclusao` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`idcliente`);

--
-- Indexes for table `config_movimento`
--
ALTER TABLE `config_movimento`
  ADD PRIMARY KEY (`idconfig`),
  ADD KEY `fk_estabelecimentos_config` (`idestabelecimento`),
  ADD KEY `fk_servCarro_config` (`cobranca_padrao_carro`),
  ADD KEY `fk_servMoto_config` (`cobranca_padrao_moto`);

--
-- Indexes for table `contratos`
--
ALTER TABLE `contratos`
  ADD PRIMARY KEY (`idcontrato`),
  ADD KEY `fk_estabelecimentos_contratos_idx` (`idestabelecimento`),
  ADD KEY `fk_clientes_contratos_idx` (`idcliente`);

--
-- Indexes for table `estabelecimentos`
--
ALTER TABLE `estabelecimentos`
  ADD PRIMARY KEY (`idestabelecimento`);

--
-- Indexes for table `faturamento`
--
ALTER TABLE `faturamento`
  ADD PRIMARY KEY (`idfatura`),
  ADD KEY `fk_convenio_faturamento_idx` (`idcontrato`);

--
-- Indexes for table `fat_mov`
--
ALTER TABLE `fat_mov`
  ADD PRIMARY KEY (`idfatmov`),
  ADD KEY `fk_movimento_idx` (`idmovimento`),
  ADD KEY `fk_faturamento_idx` (`idfatura`);

--
-- Indexes for table `financeiro`
--
ALTER TABLE `financeiro`
  ADD PRIMARY KEY (`idfinanceiro`),
  ADD KEY `fk_estabelecimentos_financeiro_idx` (`idestabelecimento`),
  ADD KEY `fk_funcionarios_financeiro_idx` (`idfuncionario`),
  ADD KEY `fk_forma_financeiro` (`forma_pagamento`);

--
-- Indexes for table `forma_pagamento`
--
ALTER TABLE `forma_pagamento`
  ADD PRIMARY KEY (`idforma`),
  ADD KEY `fk_estabelecimento_formas` (`idestabelecimento`);

--
-- Indexes for table `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`idfuncionario`);

--
-- Indexes for table `movimentos`
--
ALTER TABLE `movimentos`
  ADD PRIMARY KEY (`idmovimento`),
  ADD KEY `fk_servicos_movimentos_idx` (`idservico`),
  ADD KEY `fk_funcionarios_movimentos_idx` (`idfuncionario`),
  ADD KEY `fk_estabelecimento_movimentos_idx` (`idestabelecimento`);

--
-- Indexes for table `servicos`
--
ALTER TABLE `servicos`
  ADD PRIMARY KEY (`idservico`),
  ADD KEY `fk_estabelecimentos_servicos_idx` (`idestabelecimento`);

--
-- Indexes for table `veiculos_clientes`
--
ALTER TABLE `veiculos_clientes`
  ADD PRIMARY KEY (`idvc`),
  ADD KEY `fk_clientes_vc_idx` (`idcliente`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
  MODIFY `idcliente` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `config_movimento`
--
ALTER TABLE `config_movimento`
  MODIFY `idconfig` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `contratos`
--
ALTER TABLE `contratos`
  MODIFY `idcontrato` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `estabelecimentos`
--
ALTER TABLE `estabelecimentos`
  MODIFY `idestabelecimento` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `financeiro`
--
ALTER TABLE `financeiro`
  MODIFY `idfinanceiro` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `forma_pagamento`
--
ALTER TABLE `forma_pagamento`
  MODIFY `idforma` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `idfuncionario` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `movimentos`
--
ALTER TABLE `movimentos`
  MODIFY `idmovimento` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `servicos`
--
ALTER TABLE `servicos`
  MODIFY `idservico` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `veiculos_clientes`
--
ALTER TABLE `veiculos_clientes`
  MODIFY `idvc` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `config_movimento`
--
ALTER TABLE `config_movimento`
  ADD CONSTRAINT `fk_estabelecimentos_config` FOREIGN KEY (`idestabelecimento`) REFERENCES `estabelecimentos` (`idestabelecimento`),
  ADD CONSTRAINT `fk_servCarro_config` FOREIGN KEY (`cobranca_padrao_carro`) REFERENCES `servicos` (`idservico`),
  ADD CONSTRAINT `fk_servMoto_config` FOREIGN KEY (`cobranca_padrao_moto`) REFERENCES `servicos` (`idservico`);

--
-- Constraints for table `contratos`
--
ALTER TABLE `contratos`
  ADD CONSTRAINT `fk_clientes_contratos` FOREIGN KEY (`idcliente`) REFERENCES `clientes` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_estabelecimentos_contratos` FOREIGN KEY (`idestabelecimento`) REFERENCES `estabelecimentos` (`idestabelecimento`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `financeiro`
--
ALTER TABLE `financeiro`
  ADD CONSTRAINT `fk_estabelecimentos_financeiro` FOREIGN KEY (`idestabelecimento`) REFERENCES `estabelecimentos` (`idestabelecimento`) ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_forma_financeiro` FOREIGN KEY (`forma_pagamento`) REFERENCES `forma_pagamento` (`idforma`) ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_funcionarios_financeiro` FOREIGN KEY (`idfuncionario`) REFERENCES `funcionarios` (`idfuncionario`) ON UPDATE NO ACTION;

--
-- Constraints for table `forma_pagamento`
--
ALTER TABLE `forma_pagamento`
  ADD CONSTRAINT `fk_estabelecimento_formas` FOREIGN KEY (`idestabelecimento`) REFERENCES `estabelecimentos` (`idestabelecimento`) ON UPDATE NO ACTION;

--
-- Constraints for table `movimentos`
--
ALTER TABLE `movimentos`
  ADD CONSTRAINT `fk_estabelecimento_movimentos` FOREIGN KEY (`idestabelecimento`) REFERENCES `estabelecimentos` (`idestabelecimento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_funcionarios_movimentos` FOREIGN KEY (`idfuncionario`) REFERENCES `funcionarios` (`idfuncionario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_servicos_movimentos` FOREIGN KEY (`idservico`) REFERENCES `servicos` (`idservico`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `servicos`
--
ALTER TABLE `servicos`
  ADD CONSTRAINT `fk_estabelecimentos_servicos` FOREIGN KEY (`idestabelecimento`) REFERENCES `estabelecimentos` (`idestabelecimento`);

--
-- Constraints for table `veiculos_clientes`
--
ALTER TABLE `veiculos_clientes`
  ADD CONSTRAINT `fk_clientes_vc` FOREIGN KEY (`idcliente`) REFERENCES `clientes` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
