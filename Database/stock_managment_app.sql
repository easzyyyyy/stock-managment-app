-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 04 fév. 2022 à 13:29
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `stock_managment_app`
--

-- --------------------------------------------------------

--
-- Structure de la table `places`
--

DROP TABLE IF EXISTS `places`;
CREATE TABLE IF NOT EXISTS `places` (
  `id_place` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `address` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `country` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `city` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `area` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  PRIMARY KEY (`id_place`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `places`
--

INSERT INTO `places` (`id_place`, `name`, `address`, `country`, `city`, `area`, `price`) VALUES
(1, 'Business premises', '16 red horse street', 'France', 'Chambly', 487, 79),
(2, 'The great warehouse', '15 red horse street', 'Alaska', 'Ventcouvert', 146, 56),
(3, 'A bit too small', '78 mozart street', 'England', 'London', 15, 150),
(22, 'Here we are', '667 dans la place', 'Palaba', 'Spain', 56, 22);

-- --------------------------------------------------------

--
-- Structure de la table `products`
--

DROP TABLE IF EXISTS `products`;
CREATE TABLE IF NOT EXISTS `products` (
  `id_product` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `price` float NOT NULL,
  PRIMARY KEY (`id_product`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `products`
--

INSERT INTO `products` (`id_product`, `type`, `name`, `price`) VALUES
(1, 'food', 'banana', 1),
(2, 'food', 'water', 0.51),
(3, 'food', 'apple', 0.8),
(4, 'food', 'bread', 2.2),
(5, 'food', 'nutella', 5),
(6, 'food', 'pasta', 1.15),
(7, 'food', 'rice', 1.35),
(8, 'raw material', 'sand', 0.12),
(9, 'raw material', 'concrete', 0.29),
(10, 'electronic', 'smartphone', 250);

-- --------------------------------------------------------

--
-- Structure de la table `stocks`
--

DROP TABLE IF EXISTS `stocks`;
CREATE TABLE IF NOT EXISTS `stocks` (
  `id_stock` int(11) NOT NULL AUTO_INCREMENT,
  `id_place` int(11) NOT NULL,
  `id_product` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `last_arrival` date NOT NULL,
  `next_arrival` date DEFAULT NULL,
  PRIMARY KEY (`id_stock`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `stocks`
--

INSERT INTO `stocks` (`id_stock`, `id_place`, `id_product`, `amount`, `last_arrival`, `next_arrival`) VALUES
(1, 1, 1, 200, '2022-01-22', '2022-01-31'),
(2, 1, 2, 150, '2022-01-12', '2022-03-04'),
(3, 1, 4, 360, '2022-01-22', '2022-02-09'),
(4, 2, 1, 780, '2022-01-27', '2022-03-15'),
(5, 2, 5, 120, '2022-01-07', '2022-06-08'),
(17, 22, 10, 1000, '2022-02-04', '2022-02-25'),
(18, 2, 5, 456, '2022-02-03', '2022-02-18');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
