-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 03 Oca 2023, 15:23:35
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `insan_kaynakları`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel_isci_bilgi`
--

CREATE TABLE `personel_isci_bilgi` (
  `personel_id` int(11) NOT NULL,
  `personel_ad` varchar(50) NOT NULL,
  `personel_soyad` varchar(50) NOT NULL,
  `personel_tel` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin5 COLLATE=latin5_turkish_ci;

--
-- Tablo döküm verisi `personel_isci_bilgi`
--

INSERT INTO `personel_isci_bilgi` (`personel_id`, `personel_ad`, `personel_soyad`, `personel_tel`) VALUES
(1, 'Ali', 'Çim', '034723'),
(2, 'Buse', 'Yiğit', '234455'),
(3, 'Beyza', 'Kaplan', '234567'),
(4, 'Sevim', 'Bayram', '235676'),
(6, 'Furkan', 'Göz', '213454'),
(7, 'Canan', 'Yücetan', '345651');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `personel_isci_bilgi`
--
ALTER TABLE `personel_isci_bilgi`
  ADD PRIMARY KEY (`personel_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `personel_isci_bilgi`
--
ALTER TABLE `personel_isci_bilgi`
  MODIFY `personel_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
