-- -------------------------------------------------------------------------------------------
-- 				Insert para la BD SIC del Segundo Parcial Serie 3
-- -------------------------------------------------------------------------------------------

use SIC;

create table aplicacion(
pkId varchar(15) PRIMARY KEY, 
fkIdModulo varchar(15) NOT NULL,
nombre varchar(45) NOT NULL,
rutaChm varchar(180) NOT NULL,
rutaHtml varchar(180) NOT NULL,
estado varchar(1) NOT NULL
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `sic`.`aplicacion` (`pkId`, `fkIdModulo`, `nombre`, `rutaChm`, `rutaHtml`, `estado`) VALUES ('1', '1', 'Aplicacion 1', '1', '1', '1');

UPDATE sic.aplicacion SET rutaChm='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\2do parcial\\PrototipoIS2P2022\\PrototipoIS2P2022\\Componentes\\AyudaBDSIC\\AyudaBDSIC.chm',rutaHtml='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\2do parcial\\PrototipoIS2P2022\\PrototipoIS2P2022\\Componentes\\AyudaBDSIC\\Ayuda-para-BD-SIC.html' WHERE pkId='1';

INSERT INTO `sic`.`vendedores` (`codigo_vendedor`, `nombre_vendedor`, `direccion_vendedor`, `telefono_vendedor`, `nit_vendedor`, `estatus_vendedor`) VALUES ('1', 'Vendedor 1', 'Zona 1', '25896412', '1234567898', '1');
INSERT INTO `sic`.`clientes` (`codigo_cliente`, `nombre_cliente`, `direccion_cliente`, `nit_cliente`, `telefono_cliente`, `codigo_vendedor`, `estatus_cliente`) VALUES ('1', 'Cliente 1', 'Zona 6', '13549876', '62589741', '1', '1');
INSERT INTO `sic`.`marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES ('1', 'Marca 1', '1');
INSERT INTO `sic`.`lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES ('1', 'Linea 1', '1');
INSERT INTO `sic`.`bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES ('1', 'Bodega 1', '1');
INSERT INTO `sic`.`productos` (`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `existencia_producto`, `estatus_producto`) VALUES ('1', 'Producto1', '1', '1', '25', '1');
INSERT INTO `sic`.`existencias` (`codigo_bodega`, `codigo_producto`, `saldo_existencia`) VALUES ('1', '1', '12000');



