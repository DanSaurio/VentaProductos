CREATE DATABASE productos_pdv;

use productos_pdv;

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `precio` double NOT NULL,
  `cod_barras` varchar(20) NOT NULL,
  `imagen` text NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `presentacion` enum('CAJA','KILO','LITRO','PIEZA') NOT NULL

) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `nombre`,  `descripcion`, `precio`,`cod_barras`, `imagen`,`marca`,`presentacion`) VALUES
(1, 'Maruchan Habanero Rebelde' ,'Maruchan limón camarón habanero', 16.5, '123123123', '123123','Maruchan','PIEZA');


use productos_pdv;

CREATE TABLE `usuarios` (
  `id` int(255) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `imagen` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `usuarios` (`id`, `nombre`, `Correo`, `password`, `imagen`) VALUES
(0, 'Admin', 'Admin@uhtermosillo.edu.mx', 'admin123', '1231235');


Create table ventas(id int(11),fecha_hora varchar(255),monto double,cajero_id int(11));
Create table ventas_detalles(venta_id int(11),producto_id int(11),cantidad int(20));