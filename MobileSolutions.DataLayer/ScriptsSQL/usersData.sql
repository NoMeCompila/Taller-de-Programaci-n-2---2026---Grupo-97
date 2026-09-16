USE MobileSolutionsDB;
GO

-- ==============================================================================
-- Script: usersData.sql
-- Descripción: Limpieza de registros y generación de 60 usuarios de prueba
--              - 30 Activos (status = 1)
--              - 30 Inactivos (status = 0)
--              - 70% Masculino (21 por grupo = 42 total)
--              - 20% Femenino  (6 por grupo = 12 total)
--              - 10% Otro      (3 por grupo = 6 total)
--              - Países: Argentina, Uruguay, Paraguay con sus localidades
--              - Todos mayores de edad
--              - Emails distribuidos entre @gmail.com, @hotmail.com y @yahoo.com
--              - DNI, Username y Email únicos
--              - Profile IDs válidos: 1 (Admin), 2 (Vendedor), 3 (Gerente)
-- ==============================================================================

SET NOCOUNT ON;

-- Desactivar temporalmente restricciones de FK si existen referencias
ALTER TABLE SaleHeader NOCHECK CONSTRAINT FK_SaleHeader_User;

-- Eliminar todos los usuarios existentes
DELETE FROM [User];

-- Reiniciar el contador de identidad
DBCC CHECKIDENT ('[User]', RESEED, 0);

-- Reactivar restricción FK
ALTER TABLE SaleHeader CHECK CONSTRAINT FK_SaleHeader_User;

-- ==============================================================================
-- Inserción de los 60 usuarios de prueba
-- ==============================================================================
INSERT INTO [User] (
    profile_id,
    name,
    lastname,
    dni,
    sex,
    username,
    password,
    email,
    phone,
    address,
    birth,
    nationality,
    locality,
    register_date,
    status
)
VALUES
-- ==============================================================================
-- 30 USUARIOS ACTIVOS (status = 1)
-- 21 Masculino, 6 Femenino, 3 Otro
-- ==============================================================================
-- 1 a 7: Argentina - Masculino
(1, 'Agustin', 'Romero', '34112201', 'Masculino', 'aromero01', 'Pass1234!', 'aromero01@gmail.com', '1145678901', 'Av. Corrientes 1420', '1989-04-12', 'Argentina', 'Buenos Aires', '2024-01-10 09:30:00', 1),
(2, 'Lucas', 'Fernandez', '35223302', 'Masculino', 'lfernandez02', 'Pass1234!', 'lfernandez02@hotmail.com', '3415678902', 'Pellegrini 850', '1990-08-25', 'Argentina', 'Rosario', '2024-01-11 10:15:00', 1),
(3, 'Mariano', 'Alvarez', '36334403', 'Masculino', 'malvarez03', 'Pass1234!', 'malvarez03@yahoo.com', '3515678903', 'Colon 340', '1991-11-05', 'Argentina', 'Cordoba', '2024-01-12 11:00:00', 1),
(2, 'Mateo', 'Diaz', '37445504', 'Masculino', 'mdiaz04', 'Pass1234!', 'mdiaz04@gmail.com', '2615678904', 'San Martin 120', '1993-02-18', 'Argentina', 'Mendoza', '2024-01-13 11:45:00', 1),
(2, 'Julian', 'Benitez', '38556605', 'Masculino', 'jbenitez05', 'Pass1234!', 'jbenitez05@hotmail.com', '3815678905', '24 de Septiembre 450', '1994-07-22', 'Argentina', 'San Miguel de Tucuman', '2024-01-14 12:30:00', 1),
(3, 'Joaquin', 'Torres', '39667706', 'Masculino', 'jtorres06', 'Pass1234!', 'jtorres06@yahoo.com', '2215678906', 'Calle 7 Nro 890', '1996-03-14', 'Argentina', 'La Plata', '2024-01-15 14:10:00', 1),
(2, 'Nicolas', 'Acosta', '40778807', 'Masculino', 'nacosta07', 'Pass1234!', 'nacosta07@gmail.com', '2235678907', 'Guemes 2340', '1997-12-03', 'Argentina', 'Mar del Plata', '2024-01-16 15:00:00', 1),

-- 8 a 14: Uruguay - Masculino
(3, 'Diego', 'Silva', '41889908', 'Masculino', 'dsilva08', 'Pass1234!', 'dsilva08@hotmail.com', '099123408', '18 de Julio 1020', '1988-06-17', 'Uruguay', 'Montevideo', '2024-01-17 15:40:00', 1),
(2, 'Gaston', 'Pereira', '42990009', 'Masculino', 'gpereira09', 'Pass1234!', 'gpereira09@yahoo.com', '098123409', 'Gorlero 650', '1989-09-30', 'Uruguay', 'Punta del Este', '2024-01-18 16:20:00', 1),
(2, 'Sebastian', 'Rodriguez', '43101110', 'Masculino', 'srodriguez10', 'Pass1234!', 'srodriguez10@gmail.com', '097123410', 'Uruguay 430', '1991-01-15', 'Uruguay', 'Salto', '2024-01-19 17:00:00', 1),
(2, 'Rodrigo', 'Morales', '44212211', 'Masculino', 'rmorales11', 'Pass1234!', 'rmorales11@hotmail.com', '096123411', '19 de Abril 112', '1992-05-24', 'Uruguay', 'Paysandu', '2024-01-20 09:10:00', 1),
(3, 'Martin', 'Suarez', '45323312', 'Masculino', 'msuarez12', 'Pass1234!', 'msuarez12@yahoo.com', '095123412', 'Sarandi 780', '1993-10-11', 'Uruguay', 'Rivera', '2024-01-21 10:00:00', 1),
(2, 'Federico', 'Rios', '46434413', 'Masculino', 'frios13', 'Pass1234!', 'frios13@gmail.com', '094123413', 'General Artigas 560', '1995-04-05', 'Uruguay', 'Maldonado', '2024-01-22 10:45:00', 1),
(2, 'Bruno', 'Castro', '47545514', 'Masculino', 'bcastro14', 'Pass1234!', 'bcastro14@hotmail.com', '093123414', 'Rambla Costanera 210', '1996-08-19', 'Uruguay', 'Ciudad de la Costa', '2024-01-23 11:30:00', 1),

-- 15 a 21: Paraguay - Masculino
(1, 'Carlos', 'Gimenez', '48656615', 'Masculino', 'cgimenez15', 'Pass1234!', 'cgimenez15@yahoo.com', '0981112215', 'Palma 540', '1987-03-29', 'Paraguay', 'Asuncion', '2024-01-24 12:15:00', 1),
(2, 'Esteban', 'Caballero', '49767716', 'Masculino', 'ecaballero16', 'Pass1234!', 'ecaballero16@gmail.com', '0982112216', 'Av. San Blas 1300', '1990-12-14', 'Paraguay', 'Ciudad del Este', '2024-01-25 13:00:00', 1),
(2, 'Victor', 'Villalba', '50878817', 'Masculino', 'vvillalba17', 'Pass1234!', 'vvillalba17@hotmail.com', '0983112217', 'Mariscal Estigarribia 890', '1992-07-08', 'Paraguay', 'San Lorenzo', '2024-01-26 14:20:00', 1),
(3, 'Hugo', 'Ayala', '51989918', 'Masculino', 'hayala18', 'Pass1234!', 'hayala18@yahoo.com', '0984112218', 'General Aquino 320', '1993-11-28', 'Paraguay', 'Luque', '2024-01-27 15:10:00', 1),
(2, 'Raul', 'Vera', '52090019', 'Masculino', 'rvera19', 'Pass1234!', 'rvera19@gmail.com', '0985112219', 'Costanera San Jose 150', '1995-02-16', 'Paraguay', 'Encarnacion', '2024-01-28 16:00:00', 1),
(2, 'Hernan', 'Duarte', '53101120', 'Masculino', 'hduarte20', 'Pass1234!', 'hduarte20@hotmail.com', '0986112220', 'Defensores del Chaco 420', '1997-06-01', 'Paraguay', 'Capiata', '2024-01-29 16:50:00', 1),
(1, 'Gustavo', 'Bogado', '54212221', 'Masculino', 'gbogado21', 'Pass1234!', 'gbogado21@yahoo.com', '0987112221', 'Av. Curupayty 230', '1998-09-15', 'Paraguay', 'Fernando de la Mora', '2024-01-30 17:30:00', 1),

-- 22 a 27: Femenino (2 Argentina, 2 Uruguay, 2 Paraguay)
(2, 'Camila', 'Gomez', '55323322', 'Femenino', 'cgomez22', 'Pass1234!', 'cgomez22@gmail.com', '1165432122', 'Santa Fe 2100', '1992-04-18', 'Argentina', 'Buenos Aires', '2024-01-31 09:20:00', 1),
(3, 'Valentina', 'Lopez', '56434423', 'Femenino', 'vlopez23', 'Pass1234!', 'vlopez23@hotmail.com', '3516543223', 'Bv. San Juan 780', '1994-08-09', 'Argentina', 'Cordoba', '2024-02-01 10:10:00', 1),
(2, 'Florencia', 'Martinez', '57545524', 'Femenino', 'fmartinez24', 'Pass1234!', 'fmartinez24@yahoo.com', '099654324', 'Bulevar Artigas 1430', '1990-11-27', 'Uruguay', 'Montevideo', '2024-02-02 11:00:00', 1),
(2, 'Lucia', 'Vidal', '58656625', 'Femenino', 'lvidal25', 'Pass1234!', 'lvidal25@gmail.com', '098654325', 'Av. Roosevelt 900', '1995-01-30', 'Uruguay', 'Punta del Este', '2024-02-03 11:50:00', 1),
(1, 'Adriana', 'Nunez', '59767726', 'Femenino', 'anunez26', 'Pass1234!', 'anunez26@hotmail.com', '0981654326', 'Yegros 670', '1989-05-14', 'Paraguay', 'Asuncion', '2024-02-04 12:40:00', 1),
(2, 'Patricia', 'Franco', '60878827', 'Femenino', 'pfranco27', 'Pass1234!', 'pfranco27@yahoo.com', '0982654327', 'Av. Pioneros del Este 450', '1993-10-03', 'Paraguay', 'Ciudad del Este', '2024-02-05 13:30:00', 1),

-- 28 a 30: Otro (1 Argentina, 1 Uruguay, 1 Paraguay)
(2, 'Alex', 'Herrera', '61989928', 'Otro', 'aherrera28', 'Pass1234!', 'aherrera28@gmail.com', '3417654328', 'Cordoba 1500', '1994-03-21', 'Argentina', 'Rosario', '2024-02-06 14:15:00', 1),
(2, 'Sam', 'Mendez', '62090029', 'Otro', 'smendez29', 'Pass1234!', 'smendez29@hotmail.com', '097765429', 'Calle Real 230', '1996-07-12', 'Uruguay', 'Colonia del Sacramento', '2024-02-07 15:00:00', 1),
(3, 'Robin', 'Cardozo', '63101130', 'Otro', 'rcardozo30', 'Pass1234!', 'rcardozo30@yahoo.com', '0983765430', '14 de Mayo 380', '1997-12-08', 'Paraguay', 'San Lorenzo', '2024-02-08 15:50:00', 1),

-- ==============================================================================
-- 30 USUARIOS INACTIVOS (status = 0)
-- 21 Masculino, 6 Femenino, 3 Otro
-- ==============================================================================
-- 31 a 37: Argentina - Masculino
(2, 'Ignacio', 'Perez', '64212231', 'Masculino', 'iperez31', 'Pass1234!', 'iperez31@gmail.com', '1154321031', 'Av. de Mayo 650', '1986-02-11', 'Argentina', 'Buenos Aires', '2023-05-10 09:00:00', 0),
(2, 'Maximiliano', 'Ruiz', '65323332', 'Masculino', 'mruiz32', 'Pass1234!', 'mruiz32@hotmail.com', '3414321032', 'Bv. Orono 1120', '1988-07-19', 'Argentina', 'Rosario', '2023-05-11 10:10:00', 0),
(1, 'Facundo', 'Castro', '66434433', 'Masculino', 'fcastro33', 'Pass1234!', 'fcastro33@yahoo.com', '3514321033', 'Chacabuco 430', '1990-10-04', 'Argentina', 'Cordoba', '2023-05-12 11:20:00', 0),
(2, 'Gonzalo', 'Moran', '67545534', 'Masculino', 'gmoran34', 'Pass1234!', 'gmoran34@gmail.com', '2614321034', 'Las Heras 780', '1991-12-22', 'Argentina', 'Mendoza', '2023-05-13 12:30:00', 0),
(3, 'Ezequiel', 'Ortiz', '68656635', 'Masculino', 'eortiz35', 'Pass1234!', 'eortiz35@hotmail.com', '3814321035', 'Crisostomo Alvarez 210', '1993-04-15', 'Argentina', 'San Miguel de Tucuman', '2023-05-14 13:40:00', 0),
(2, 'Leandro', 'Sosa', '69767736', 'Masculino', 'lsosa36', 'Pass1234!', 'lsosa36@yahoo.com', '2214321036', 'Calle 50 Nro 640', '1995-09-08', 'Argentina', 'La Plata', '2023-05-15 14:50:00', 0),
(2, 'Damian', 'Flores', '70878837', 'Masculino', 'dflores37', 'Pass1234!', 'dflores37@gmail.com', '2234321037', 'Alberti 1950', '1996-11-29', 'Argentina', 'Mar del Plata', '2023-05-16 15:30:00', 0),

-- 38 a 44: Uruguay - Masculino
(1, 'Alvaro', 'Ramos', '71989938', 'Masculino', 'aramos38', 'Pass1234!', 'aramos38@hotmail.com', '099321038', 'Agraciada 2840', '1985-08-14', 'Uruguay', 'Montevideo', '2023-06-01 09:15:00', 0),
(2, 'Enzo', 'Barrios', '72090039', 'Masculino', 'ebarrios39', 'Pass1234!', 'ebarrios39@yahoo.com', '098321039', 'Calle 20 Nro 340', '1987-11-03', 'Uruguay', 'Punta del Este', '2023-06-02 10:25:00', 0),
(3, 'Emiliano', 'Figueroa', '73101140', 'Masculino', 'efigueroa40', 'Pass1234!', 'efigueroa40@gmail.com', '097321040', 'Brasil 890', '1989-01-20', 'Uruguay', 'Salto', '2023-06-03 11:35:00', 0),
(2, 'Franco', 'Paz', '74212241', 'Masculino', 'fpaz41', 'Pass1234!', 'fpaz41@hotmail.com', '096321041', 'Leandro Gomez 510', '1992-06-18', 'Uruguay', 'Paysandu', '2023-06-04 12:45:00', 0),
(2, 'Joaquin', 'Ribeiro', '75323342', 'Masculino', 'jribeiro42', 'Pass1234!', 'jribeiro42@yahoo.com', '095321042', 'Ceballos 410', '1994-03-07', 'Uruguay', 'Rivera', '2023-06-05 14:00:00', 0),
(2, 'Pablo', 'Santana', '76434443', 'Masculino', 'psantana43', 'Pass1234!', 'psantana43@gmail.com', '094321043', 'Joaquin de Viana 620', '1995-07-25', 'Uruguay', 'Maldonado', '2023-06-06 15:10:00', 0),
(3, 'Alfonso', 'Olivera', '77545544', 'Masculino', 'aolivera44', 'Pass1234!', 'aolivera44@hotmail.com', '093321044', 'Av. Giannattasio km 22', '1997-10-12', 'Uruguay', 'Ciudad de la Costa', '2023-06-07 16:20:00', 0),

-- 45 a 51: Paraguay - Masculino
(1, 'Marcos', 'Caceres', '78656645', 'Masculino', 'mcaceres45', 'Pass1234!', 'mcaceres45@yahoo.com', '0981998845', 'Estrella 450', '1988-04-03', 'Paraguay', 'Asuncion', '2023-07-10 09:40:00', 0),
(2, 'Rolando', 'Aquino', '79767746', 'Masculino', 'raquino46', 'Pass1234!', 'raquino46@gmail.com', '0982998846', 'Av. Monsenor Rodriguez 800', '1990-09-17', 'Paraguay', 'Ciudad del Este', '2023-07-11 10:50:00', 0),
(2, 'Nestor', 'Espinoza', '80878847', 'Masculino', 'nespinoza47', 'Pass1234!', 'nespinoza47@hotmail.com', '0983998847', 'Espana 710', '1991-12-05', 'Paraguay', 'San Lorenzo', '2023-07-12 11:30:00', 0),
(3, 'Cesar', 'Alcaraz', '81989948', 'Masculino', 'calcaraz48', 'Pass1234!', 'calcaraz48@yahoo.com', '0984998848', 'Coronel Oviedo 280', '1993-05-22', 'Paraguay', 'Luque', '2023-07-13 13:10:00', 0),
(2, 'Guillermo', 'Zarate', '82090049', 'Masculino', 'gzarate49', 'Pass1234!', 'gzarate49@gmail.com', '0985998849', 'Tomas Romero Pereira 540', '1994-08-30', 'Paraguay', 'Encarnacion', '2023-07-14 14:00:00', 0),
(2, 'Ramon', 'Saldivar', '83101150', 'Masculino', 'rsaldivar50', 'Pass1234!', 'rsaldivar50@hotmail.com', '0986998850', 'Ruta 2 km 18', '1996-01-14', 'Paraguay', 'Capiata', '2023-07-15 15:15:00', 0),
(1, 'Osvaldo', 'Coronel', '84212251', 'Masculino', 'ocoronel51', 'Pass1234!', 'ocoronel51@yahoo.com', '0987998851', 'Mariscal Lopez 950', '1997-04-28', 'Paraguay', 'Fernando de la Mora', '2023-07-16 16:30:00', 0),

-- 52 a 57: Femenino (2 Argentina, 2 Uruguay, 2 Paraguay)
(2, 'Mariana', 'Castillo', '85323352', 'Femenino', 'mcastillo52', 'Pass1234!', 'mcastillo52@gmail.com', '1148765452', 'Av. Cabildo 2450', '1991-03-08', 'Argentina', 'Buenos Aires', '2023-08-01 09:30:00', 0),
(3, 'Solange', 'Maldonado', '86434453', 'Femenino', 'smaldonado53', 'Pass1234!', 'smaldonado53@hotmail.com', '3514876553', 'Av. Rafael Nunez 4100', '1993-06-19', 'Argentina', 'Cordoba', '2023-08-02 10:45:00', 0),
(2, 'Romina', 'Pons', '87545554', 'Femenino', 'rpons54', 'Pass1234!', 'rpons54@yahoo.com', '099487654', 'Colonia 1320', '1990-09-11', 'Uruguay', 'Montevideo', '2023-08-03 11:40:00', 0),
(2, 'Daniela', 'Tejera', '88656655', 'Femenino', 'dtejera55', 'Pass1234!', 'dtejera55@gmail.com', '098487655', 'Av. Espana 520', '1995-12-02', 'Uruguay', 'Maldonado', '2023-08-04 13:00:00', 0),
(1, 'Leticia', 'Barreto', '89767756', 'Femenino', 'lbarreto56', 'Pass1234!', 'lbarreto56@hotmail.com', '0981487656', 'Chile 390', '1989-02-27', 'Paraguay', 'Asuncion', '2023-08-05 14:20:00', 0),
(2, 'Gladys', 'Galeano', '90878857', 'Femenino', 'ggaleano57', 'Pass1234!', 'ggaleano57@yahoo.com', '0982487657', 'Av. Peru 830', '1992-08-16', 'Paraguay', 'Ciudad del Este', '2023-08-06 15:35:00', 0),

-- 58 a 60: Otro (1 Argentina, 1 Uruguay, 1 Paraguay)
(2, 'Morgan', 'Vargas', '91989958', 'Otro', 'mvargas58', 'Pass1234!', 'mvargas58@gmail.com', '3413876558', 'Mitre 760', '1993-01-25', 'Argentina', 'Rosario', '2023-08-07 16:10:00', 0),
(3, 'Ariel', 'Fagundez', '92090059', 'Otro', 'afagundez59', 'Pass1234!', 'afagundez59@hotmail.com', '097387659', '18 de Julio 640', '1994-05-18', 'Uruguay', 'Salto', '2023-08-08 17:00:00', 0),
(2, 'Taylor', 'Centurion', '93101160', 'Otro', 'tcenturion60', 'Pass1234!', 'tcenturion60@yahoo.com', '0983387660', 'General Diaz 210', '1996-10-31', 'Paraguay', 'Luque', '2023-08-09 17:45:00', 0);
GO

-- ==============================================================================
-- Verificación de resumen
-- ==============================================================================
SELECT 
    status AS [Estado],
    COUNT(*) AS [Cantidad],
    SUM(CASE WHEN sex = 'Masculino' THEN 1 ELSE 0 END) AS [Masculinos],
    SUM(CASE WHEN sex = 'Femenino' THEN 1 ELSE 0 END) AS [Femeninos],
    SUM(CASE WHEN sex = 'Otro' THEN 1 ELSE 0 END) AS [Otros]
FROM [User]
GROUP BY status;
GO

SELECT * FROM [User] WHERE status = 1 ORDER BY lastname ASC, name ASC;

SELECT * FROM [User] WHERE status = 0 ORDER BY lastname ASC, name ASC;