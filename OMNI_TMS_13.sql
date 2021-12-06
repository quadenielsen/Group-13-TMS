DROP DATABASE IF EXISTS `OMNI_TMS_13`;

CREATE DATABASE `OMNI_TMS_13`;
USE `OMNI_TMS_13`;



DROP TABLE IF EXISTS `carriers`;

CREATE TABLE `carriers`
(
`carrierName` VARCHAR(40) NOT NULL,
`FTLRate` DECIMAL(5,4) NOT NULL,
`LTLRate` DECIMAL(5,4) NOT NULL,
`reefCharge` DECIMAL(5,4) NOT NULL,
PRIMARY KEY (`carrierName`),
CHECK (`carrierName` != ""),
CHECK (`FTLRate` >= 0),
CHECK (`LTLRate` >= 0),
CHECK (`reefCharge` >= 0)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert  into `carriers`(`carrierName`,`FTLRate`,`LTLRate`,`reefCharge`) values 

('Planet Express', 5.21, 0.3621, 0.08),
('Schooner\'s', 5.05, 0.3434, 0.07),
('Tillman Transport', 5.11, 0.3012, 0.09),
('We Haul', 5.2, 0, 0.065);

DROP TABLE IF EXISTS `cities`;

CREATE TABLE `cities`
(
`cityID` INT NOT NULL AUTO_INCREMENT,
`cityName` VARCHAR(40) NOT NULL,
`cityProvince` VARCHAR(40) NOT NULL,
`cityCountry` VARCHAR(40) NOT NULL,
`kilometersToNextCityEast` INT DEFAULT NULL,
`timeToNextCityEast` DECIMAL(3,2) DEFAULT NULL,
`nextCityWest` INT DEFAULT NULL,
`nextCityEast` INT DEFAULT NULL,
PRIMARY KEY (`cityID`),
KEY `nextCityWest` (`nextCityWest`),
KEY `nextCityEast` (`nextCityEast`),
CONSTRAINT `cities_constraint1` FOREIGN KEY (`nextCityWest`) REFERENCES `cities` (`cityID`),
CONSTRAINT `cities_constraint2` FOREIGN KEY (`nextCityEast`) REFERENCES `cities` (`cityID`)

) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert  into `cities`(`cityID`,`cityName`,`cityProvince`,`cityCountry`,`kilometersToNextCityEast`,`timeToNextCityEast`,`nextCityWest`,`nextCityEast`) values 

(1, 'Windsor', 'Ontario', 'Canada', 191, 2.5, NULL, NULL),
(2, 'London', 'Ontario', 'Canada', 128, 1.75, 1, NULL),
(3, 'Hamilton', 'Ontario', 'Canada', 68, 1.25, 2, NULL),
(4, 'Toronto', 'Ontario', 'Canada', 60, 1.3, 3, NULL),
(5, 'Oshawa', 'Ontario', 'Canada', 134, 1.65, 4, NULL),
(6, 'Belleville', 'Ontario', 'Canada', 82, 1.2, 5, NULL),
(7, 'Kingston', 'Ontario', 'Canada', 196, 2.5, 6, NULL),
(8, 'Ottawa', 'Ontario', 'Canada', NULL, NULL, 7, NULL);

DROP TABLE IF EXISTS `orders`;

CREATE TABLE `orders`
(
`orderID` INT NOT NULL AUTO_INCREMENT,
`orderSubmissionDate` DATE NOT NULL, /*year-month-day*/
`orderCompletionDate` DATE DEFAULT NULL, /*year-month-day*/
`orderStatus` VARCHAR(15) NOT NULL,
`jobType` VARCHAR(3) NOT NULL, /*"FTL" or "LTL"*/
`quantity` INT NOT NULL,
`originCity` INT NOT NULL,
`destinationCity` INT NOT NULL,
`vanType` VARCHAR(4) NOT NULL, /*"DRY" for dry and "REEF" for reefer*/
`customerID` INT NOT NULL,
`invoiceID` INT DEFAULT NULL,
PRIMARY KEY (`orderID`),/*,
KEY `customerID` (`customerID`),
KEY `invoiceID` (`invoiceID`),
CONSTRAINT `orders_constraint1` FOREIGN KEY (`customerID`) REFERENCES `customers` (`customerID`),
CONSTRAINT `orders_constraint2` FOREIGN KEY (`invoiceID`) REFERENCES `invoices` (`invoiceID`)*/
KEY `customerID` (`customerID`),
KEY `invoiceID` (`invoiceID`),
CONSTRAINT `orders_constraint3` FOREIGN KEY (`originCity`) REFERENCES `cities` (`cityID`),
CONSTRAINT `orders_constraint4` FOREIGN KEY (`destinationCity`) REFERENCES `cities` (`cityID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `depots`;

CREATE TABLE `depots`
(
`carrierName` VARCHAR(40) NOT NULL,
`cityID` INT NOT NULL,
`FTLAvailability` INT NOT NULL,
`LTLAvailability` INT NOT NULL,
PRIMARY KEY (`carrierName`, `cityID`),
KEY `carrierName` (`carrierName`),
KEY `cityID` (`cityID`),
CONSTRAINT `carrierDepots_constraint1` FOREIGN KEY (`carrierName`) REFERENCES `carriers` (`carrierName`),
CONSTRAINT `carrierDepots_constraint2` FOREIGN KEY (`cityID`) REFERENCES `cities` (`cityID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert  into `depots`(`carrierName`,`cityID`,`FTLAvailability`,`LTLAvailability`) values 

/*Planet Express*/
('Planet Express', 1, 50, 640),
('Planet Express', 3, 50, 640),
('Planet Express', 5, 50, 640),
('Planet Express', 6, 50, 640),
('Planet Express', 8, 50, 640),

/*Schooner's*/
('Schooner\'s', 2, 18, 98),
('Schooner\'s', 4, 18, 98),
('Schooner\'s', 7, 18, 98),

/*Tillman Transport*/
('Tillman Transport', 1, 24, 35),
('Tillman Transport', 2, 18, 45),
('Tillman Transport', 3, 18, 45),

/*We Haul*/
('We Haul', 8, 11, 0),
('We Haul', 4, 11, 40);


DROP TABLE IF EXISTS `trips`;

CREATE TABLE `trips`
(
`carrierName` VARCHAR(40) NOT NULL,
`cityID` INT NOT NULL,
`orderID` INT NOT NULL,
`tripStatus` VARCHAR(40),
`shipmentQuantity` INT NOT NULL,
`timeToCompleteShipment` INT NOT NULL,
PRIMARY KEY (`carrierName`, `cityID`, `orderID`),
KEY `orderID` (`orderID`),
CONSTRAINT `trips_constraint1` FOREIGN KEY (`carrierName`) REFERENCES `depots` (`carrierName`),
CONSTRAINT `trips_constraint2` FOREIGN KEY (`cityID`) REFERENCES `depots` (`cityID`),
CONSTRAINT `trips_constraint3` FOREIGN KEY (`orderID`) REFERENCES `orders` (`orderID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

