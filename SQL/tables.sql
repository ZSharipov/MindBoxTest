CREATE TABLE `category` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `category_name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `product_name` varchar(45) NOT NULL,
  `product_category` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_Category_idx` (`product_category`),
  CONSTRAINT `FK_Category` FOREIGN KEY (`product_category`) REFERENCES `category` (`id`)
);
