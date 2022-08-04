-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 04-Ago-2022 às 03:15
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `controle`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `estacionamento`
--

CREATE TABLE `estacionamento` (
  `Id` int(11) NOT NULL,
  `Id_Vaga` int(11) NOT NULL,
  `Id_Veiculo` int(11) NOT NULL,
  `Valor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `vaga`
--

CREATE TABLE `vaga` (
  `id` int(11) NOT NULL,
  `Situacao` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `vaga`
--

INSERT INTO `vaga` (`id`, `Situacao`) VALUES
(1, 0),
(2, 0),
(3, 0),
(4, 0),
(5, 0),
(6, 0),
(7, 0),
(8, 0),
(9, 0),
(10, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculos`
--

CREATE TABLE `veiculos` (
  `Id` int(11) NOT NULL,
  `Placa` varchar(200) DEFAULT NULL,
  `Modelo` varchar(250) NOT NULL,
  `Entrada` timestamp NOT NULL DEFAULT current_timestamp(),
  `Saida` timestamp NULL DEFAULT NULL,
  `ID_Placa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `veiculos`
--

INSERT INTO `veiculos` (`Id`, `Placa`, `Modelo`, `Entrada`, `Saida`, `ID_Placa`) VALUES
(14, '', '', '2022-08-03 23:36:54', '2022-08-04 00:46:16', 0),
(15, '', '', '2022-08-03 23:36:57', '2022-08-04 00:46:16', 0),
(16, '123214', 'carro', '2022-08-03 23:54:44', '2022-08-04 00:41:22', 0),
(17, '2314', '1234', '2022-08-03 23:56:08', NULL, 0),
(18, '214241', '3124', '2022-08-03 23:57:56', NULL, 0),
(19, '3214', 'kaio12', '2022-08-04 00:36:59', NULL, 0),
(20, '6666', 'gugu', '2022-08-04 00:39:34', '2022-08-04 00:39:49', 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `estacionamento`
--
ALTER TABLE `estacionamento`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `vaga` (`Id_Vaga`),
  ADD KEY `id veiculo` (`Id_Veiculo`);

--
-- Índices para tabela `vaga`
--
ALTER TABLE `vaga`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `veiculos`
--
ALTER TABLE `veiculos`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `estacionamento`
--
ALTER TABLE `estacionamento`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de tabela `veiculos`
--
ALTER TABLE `veiculos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `estacionamento`
--
ALTER TABLE `estacionamento`
  ADD CONSTRAINT `id veiculo` FOREIGN KEY (`Id_Veiculo`) REFERENCES `veiculos` (`Id`),
  ADD CONSTRAINT `vaga` FOREIGN KEY (`Id_Vaga`) REFERENCES `vaga` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
