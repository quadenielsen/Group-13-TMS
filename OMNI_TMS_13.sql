DROP DATABASE IF EXISTS `OMNI_TMS_13`;

CREATE DATABASE `OMNI_TMS_13`;
USE `OMNI_TMS_13`;

DROP TABLE IF EXISTS `orders`;

CREATE TABLE `orders`
(
`orderID` INT NOT NULL,
`orderSubmissionDate` DATE NOT NULL, /*year-month-day*/
`orderCompletionDate` DATE DEFAULT NULL, /*year-month-day*/
`orderStatus` VARCHAR(15) NOT NULL,
`jobType` VARCHAR(3) NOT NULL, /*"FTL" or "LTL"*/
`quantity` INT NOT NULL,
`originCity` VARCHAR(40) NOT NULL,
`destinationCity` VARCHAR(40) NOT NULL,
`vanType` VARCHAR(4) NOT NULL, /*"DRY" for dry and "REEF" for reefer*/
`customerID` INT NOT NULL,
`invoiceID` INT DEFAULT NULL,
PRIMARY KEY (`orderID`)/*,
KEY `customerID` (`customerID`),
KEY `invoiceID` (`invoiceID`),
CONSTRAINT `orders_constraint1` FOREIGN KEY (`customerID`) REFERENCES `customers` (`customerID`),
CONSTRAINT `orders_constraint2` FOREIGN KEY (`invoiceID`) REFERENCES `invoices` (`invoiceID`)*/
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert  into `orders`(`orderID`,`orderSubmissionDate`,`orderCompletionDate`,`orderStatus`,`jobType`,`quantity`,`originCity`,`destinationCity`,`vanType`,`customerID`,`invoiceID`) values 

(123, '2021-01-01', NULL, 'OK', 'BIG_JOB', 69, 'Waterloo', 'Toronto', 'BIGASS_VAN', 132, 321);

DROP TABLE IF EXISTS `carriers`;

CREATE TABLE `carriers`
(
`carrierID` INT NOT NULL,
`carrierName` VARCHAR(40) NOT NULL,
`FTLRate` DECIMAL(5,4) NOT NULL,
`LTLRate` DECIMAL(5,4) NOT NULL,
`reefCharge` DECIMAL(5,4) NOT NULL,
PRIMARY KEY (`carrierID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert  into `carriers`(`carrierID`,`carrierName`,`FTLRate`,`LTLRate`,`reefCharge`) values 

(1, 'Planet Express', 5.21, 0.3621, 0.08),
(2, 'Schooner\'s', 5.05, 0.3434, 0.07),
(3, 'Tillman Transport', 5.11, 0.3012, 0.09),
(4, 'We Haul', 5.2, 0, 0.065);

DROP TABLE IF EXISTS `cities`;

CREATE TABLE `cities`
(
`cityID` INT NOT NULL,
`cityName` VARCHAR(40) NOT NULL,
`cityProvince` VARCHAR(40) NOT NULL,
`cityCountry` VARCHAR(40) NOT NULL,
`kilometersToNextCityEast` INT DEFAULT NULL,
`timeToNextCityEast` DECIMAL(3,2) DEFAULT NULL,
`nextCityWest` INT DEFAULT NULL,
`nextCityEast` INT DEFAULT NULL,
PRIMARY KEY (`cityID`),
KEY `nextCityWest` (`cityID`),
KEY `nextCityEast` (`cityID`),
CONSTRAINT `cities_constraint1` FOREIGN KEY (`nextCityWest`) REFERENCES `cities` (`cityID`),
CONSTRAINT `cities_constraint2` FOREIGN KEY (`nextCityEast`) REFERENCES `cities` (`cityID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert  into `cities`(`cityID`,`cityName`,`cityProvince`,`cityCountry`,`kilometersToNextCityEast`,`timeToNextCityEast`,`nextCityWest`,`nextCityEast`) values 

(1, 'Windsor', 'Ontario', 'Canada', 191, 2.5, NULL, 2),
(2, 'London', 'Ontario', 'Canada', 128, 1.75, 1, 3),
(3, 'Hamilton', 'Ontario', 'Canada', 68, 1.25, 2, 4),
(4, 'Toronto', 'Ontario', 'Canada', 60, 1.3, 3, 5),
(5, 'Oshawa', 'Ontario', 'Canada', 134, 1.65, 4, 6),
(6, 'Belleville', 'Ontario', 'Canada', 82, 1.2, 5, 7),
(7, 'Kingston', 'Ontario', 'Canada', 196, 2.5, 6, 8),
(8, 'Ottawa', 'Ontario', 'Canada', NULL, NULL, 7, NULL);

DROP TABLE IF EXISTS `depots`;

CREATE TABLE `depots`
(
`carrierID` INT NOT NULL,
`cityID` INT NOT NULL,
`FTLAvailability` INT NOT NULL,
`LTLAvailability` INT NOT NULL,
PRIMARY KEY (`carrierID`, `cityID`),
KEY `carrierID` (`carrierID`),
KEY `cityID` (`cityID`),
CONSTRAINT `carrierDepots_constraint1` FOREIGN KEY (`carrierID`) REFERENCES `carriers` (`carrierID`),
CONSTRAINT `carrierDepots_constraint2` FOREIGN KEY (`cityID`) REFERENCES `cityID` (`cityID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert  into `orders`(`carrierID`,`cityID`,`FTLAvailability`,`LTLAvailability`) values 

(123, '2021-01-01', NULL, 'OK', 'BIG_JOB', 69, 'Waterloo', 'Toronto', 'BIGASS_VAN', 132, 321);