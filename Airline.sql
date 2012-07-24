SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

CREATE SCHEMA IF NOT EXISTS `Airline` DEFAULT CHARACTER SET utf8 ;
USE `Airline` ;

-- -----------------------------------------------------
-- Table `Airline`.`Avion`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Airline`.`Avion` (
  `codigo` VARCHAR(8) NOT NULL ,
  `descripcion` VARCHAR(45) NOT NULL ,
  `capacidad` INT NOT NULL ,
  PRIMARY KEY (`codigo`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Airline`.`Aerolinea`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Airline`.`Aerolinea` (
  `codigo` VARCHAR(8) NOT NULL ,
  `descripcion` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`codigo`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Airline`.`Aeropuerto`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Airline`.`Aeropuerto` (
  `codigo` VARCHAR(8) NOT NULL ,
  `descripcion` VARCHAR(45) NOT NULL ,
  `ciudad` VARCHAR(45) NOT NULL ,
  `pais` VARCHAR(45) NOT NULL ,
  `direccion` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`codigo`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Airline`.`Vuelo`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Airline`.`Vuelo` (
  `codigo` VARCHAR(8) NOT NULL ,
  `aerolinea` VARCHAR(8) NOT NULL ,
  `origen` VARCHAR(8) NOT NULL ,
  `destino` VARCHAR(8) NOT NULL ,
  `avion` VARCHAR(8) NOT NULL ,
  `salida` DATETIME NOT NULL ,
  `llegada` DATETIME NOT NULL ,
  `estado` TINYINT NULL DEFAULT 0 ,
  PRIMARY KEY (`codigo`) ,
  INDEX `FK_Vuelo_Avion` (`avion` ASC) ,
  INDEX `FK_Vuelo_Aerolinea` (`aerolinea` ASC) ,
  INDEX `FK_Vuelo_AeropuertoOrigen` (`destino` ASC) ,
  INDEX `FK_Vuelo_AeropuertoDestino` (`origen` ASC) ,
  CONSTRAINT `FK_Vuelo_Avion`
    FOREIGN KEY (`avion` )
    REFERENCES `Airline`.`Avion` (`codigo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Vuelo_Aerolinea`
    FOREIGN KEY (`aerolinea` )
    REFERENCES `Airline`.`Aerolinea` (`codigo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Vuelo_AeropuertoOrigen`
    FOREIGN KEY (`destino` )
    REFERENCES `Airline`.`Aeropuerto` (`codigo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Vuelo_AeropuertoDestino`
    FOREIGN KEY (`origen` )
    REFERENCES `Airline`.`Aeropuerto` (`codigo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Airline`.`Clases`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Airline`.`Clases` (
  `codigo` VARCHAR(8) NOT NULL ,
  `descripcion` VARCHAR(45) NULL ,
  PRIMARY KEY (`codigo`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Airline`.`Configuracion`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Airline`.`Configuracion` (
  `avion` VARCHAR(8) NOT NULL ,
  `clase` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`avion`, `clase`) ,
  INDEX `FK_Configuracion_Avion` (`avion` ASC) ,
  INDEX `FK_Configuracion_Clase` (`clase` ASC) ,
  CONSTRAINT `FK_Configuracion_Avion`
    FOREIGN KEY (`avion` )
    REFERENCES `Airline`.`Avion` (`codigo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Configuracion_Clase`
    FOREIGN KEY (`clase` )
    REFERENCES `Airline`.`Clases` (`codigo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
