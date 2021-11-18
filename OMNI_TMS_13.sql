DROP DATABASE IF EXISTS `OMNI_TMS_13`;

CREATE DATABASE `OMNI_TMS_13`;
USE `OMNI_TMS_13`;

DROP TABLE IF EXISTS `orders`;

CREATE TABLE `orders`
(
`orderID` int(255) NOT NULL,
`orderSubmissionDate` date NOT NULL,
`orderCompletionDate` date DEFAULT NULL,
`orderStatus` varchar(15) NOT NULL,
`jobType` varchar(15) NOT NULL,
`quantity` int NOT NULL,
`originCity` varchar(15) NOT NULL,
`destinationCity` varchar(15) NOT NULL,
`vanType` varchar(15) NOT NULL,
`customerID` int NOT NULL,
`invoiceID` int DEFAULT NULL,
PRIMARY KEY (`orderID`)/*,
KEY `customerID` (`customerID`),
KEY `invoiceID` (`invoiceID`),
CONSTRAINT `orders_constraint1` FOREIGN KEY (`customerID`) REFERENCES `customers` (`customerID`),
CONSTRAINT `orders_constraint2` FOREIGN KEY (`invoiceID`) REFERENCES `invoices` (`invoiceID`)*/
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert  into `orders`(`orderID`,`orderSubmissionDate`,`orderCompletionDate`,`orderStatus`,`jobType`,`quantity`,`originCity`,`destinationCity`,`vanType`,`customerID`,`invoiceID`) values 

(123, '2021-01-01', NULL, 'OK', 'BIG_JOB', 69, 'Waterloo', 'Toronto', 'BIGASS_VAN', 132, 321)