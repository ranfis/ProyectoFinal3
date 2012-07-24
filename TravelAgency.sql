SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

DROP SCHEMA IF EXISTS `TravelAgency` ;
CREATE SCHEMA IF NOT EXISTS `TravelAgency` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
USE `TravelAgency` ;

-- -----------------------------------------------------
-- Table `TravelAgency`.`Rol`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `TravelAgency`.`Rol` ;

CREATE  TABLE IF NOT EXISTS `TravelAgency`.`Rol` (
  `codigo` VARCHAR(8) NOT NULL ,
  `descripcion` VARCHAR(45) NULL ,
  PRIMARY KEY (`codigo`) ,
  UNIQUE INDEX `descripcion_UNIQUE` (`descripcion` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TravelAgency`.`Usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `TravelAgency`.`Usuario` ;

CREATE  TABLE IF NOT EXISTS `TravelAgency`.`Usuario` (
  `nusuario` VARCHAR(16) NOT NULL ,
  `clave` VARCHAR(45) NOT NULL ,
  `rol` VARCHAR(8) NOT NULL ,
  `nombre` VARCHAR(45) NOT NULL ,
  `apellido` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`nusuario`) ,
  INDEX `FK_Usuario_Rol` (`rol` ASC) ,
  CONSTRAINT `FK_Usuario_Rol`
    FOREIGN KEY (`rol` )
    REFERENCES `TravelAgency`.`Rol` (`codigo` )
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TravelAgency`.`Agencia`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `TravelAgency`.`Agencia` ;

CREATE  TABLE IF NOT EXISTS `TravelAgency`.`Agencia` (
  `codigo` VARCHAR(8) NOT NULL ,
  `descripcion` VARCHAR(45) NOT NULL ,
  `telefono` VARCHAR(13) NOT NULL ,
  `direccion` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`codigo`) ,
  UNIQUE INDEX `telefono_UNIQUE` (`telefono` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TravelAgency`.`Reservacion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `TravelAgency`.`Reservacion` ;

CREATE  TABLE IF NOT EXISTS `TravelAgency`.`Reservacion` (
  `codigo` VARCHAR(8) NOT NULL ,
  `vuelo` VARCHAR(8) NOT NULL ,
  `agencia` VARCHAR(8) NOT NULL ,
  `precio` DOUBLE NOT NULL ,
  `clase` VARCHAR(45) NOT NULL ,
  `estado` TINYINT NULL DEFAULT 0 ,
  `cliente` VARCHAR(16) NOT NULL ,
  `asiento` VARCHAR(3) NULL ,
  PRIMARY KEY (`codigo`) ,
  INDEX `FK_Reservacion_Agencia` (`agencia` ASC) ,
  INDEX `FK_Reservacion_Cliente` (`cliente` ASC) ,
  CONSTRAINT `FK_Reservacion_Agencia`
    FOREIGN KEY (`agencia` )
    REFERENCES `TravelAgency`.`Agencia` (`codigo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Reservacion_Cliente`
    FOREIGN KEY (`cliente` )
    REFERENCES `TravelAgency`.`Usuario` (`nusuario` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
