USE MobileSolutionsDB;
GO

-- ==============================================================================
-- Script: customersData.sql
-- Descripción: Verificación, limpieza y generación de 60 clientes de prueba
--              - 30 Activos (status = 1)
--              - 30 Inactivos (status = 0)
--              - 70% Masculino (21 por grupo = 42 total)
--              - 20% Femenino  (6 por grupo = 12 total)
--              - 10% Otro      (3 por grupo = 6 total)
--              - Países: Argentina, Uruguay, Paraguay con sus localidades
--              - Todos mayores de edad (cumplen CHK_Customer_Birth)
--              - Emails distribuidos entre @gmail.com, @hotmail.com y @yahoo.com
--              - DNI y Email únicos (cumplen UQ_Customer_DNI y UQ_Customer_Email)
--              - 2 clientes con phone y address en NULL, para ejercitar el
--                manejo de nulos del DAL (IsDBNull) y del modelo (string?)
--              - Rango de DNI 20000001-20000060, chosen para no chocar con el
--                rango 34112201-93101160 usado en usersData.sql
-- ==============================================================================

SET NOCOUNT ON;

-- ==============================================================================
-- Chequeo previo: ¿hay clientes cargados en la base?
-- ==============================================================================
SELECT COUNT(*) AS [Clientes Actuales] FROM Customer;
GO

-- ==============================================================================
-- Limpieza condicional: borra y reinicia el id SOLO si hay registros
-- ==============================================================================
IF EXISTS (SELECT 1 FROM Customer)
BEGIN
    PRINT 'Se detectaron clientes en la base. Iniciando limpieza...';

    -- Desactivar temporalmente la FK de SaleHeader para permitir el borrado
    ALTER TABLE SaleHeader NOCHECK CONSTRAINT FK_SaleHeader_Customer;

    -- Eliminar todos los clientes existentes
    DELETE FROM Customer;

    -- Reiniciar el contador de identidad
    DBCC CHECKIDENT ('Customer', RESEED, 0);

    -- Reactivar la restricción FK
    ALTER TABLE SaleHeader CHECK CONSTRAINT FK_SaleHeader_Customer;

    PRINT 'Limpieza completada. Contador de identity reiniciado en 0.';
END
ELSE
BEGIN
    PRINT 'La tabla Customer ya estaba vacia. Se reinicia el contador por las dudas.';

    -- Aunque este vacia, asegura que el identity arranque en 1
    DBCC CHECKIDENT ('Customer', RESEED, 0);
END
GO

-- ==============================================================================
-- Verificacion: la tabla debe quedar vacia antes de insertar
-- ==============================================================================
SELECT 
    COUNT(*)          AS [Registros Restantes],
    CASE WHEN COUNT(*) = 0 
         THEN 'OK: tabla vacia' 
         ELSE 'ERROR: la tabla no quedo vacia' 
    END               AS [Estado de Limpieza]
FROM Customer;
GO

-- ==============================================================================
-- Insercion de los 60 clientes de prueba
-- ==============================================================================
INSERT INTO Customer (
    name,
    lastname,
    dni,
    sex,
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
-- 30 CLIENTES ACTIVOS (status = 1)
-- 21 Masculino, 6 Femenino, 3 Otro
-- ==============================================================================
-- 1 a 7: Argentina - Masculino
('Agustin',        'Miranda',    '20000001', 'Masculino', 'amiranda01@gmail.com',     '1145671201', 'Av. Santa Fe 1840',         '1989-04-12', 'Argentina', 'Buenos Aires',          '2024-01-10 09:30:00', 1),
('Lucas',          'Cabrera',    '20000002', 'Masculino', 'lcabrera02@hotmail.com',   '3415671202', 'Pellegrini 850',             '1990-08-25', 'Argentina', 'Rosario',               '2024-01-11 10:15:00', 1),
('Mariano',        'Peralta',    '20000003', 'Masculino', 'mperalta03@yahoo.com',     '3515671203', 'Colon 340',                  '1991-11-05', 'Argentina', 'Cordoba',               '2024-01-12 11:00:00', 1),
('Mateo',          'Ibarra',     '20000004', 'Masculino', 'mibarra04@gmail.com',      '2615671204', 'San Martin 120',             '1993-02-18', 'Argentina', 'Mendoza',               '2024-01-13 11:45:00', 1),
('Julian',         'Sosa',       '20000005', 'Masculino', 'jsosa05@hotmail.com',       '3815671205', '24 de Septiembre 450',      '1994-07-22', 'Argentina', 'San Miguel de Tucuman', '2024-01-14 12:30:00', 1),
('Joaquin',        'Ojeda',      '20000006', 'Masculino', 'jojeda06@yahoo.com',       '2215671206', 'Calle 7 Nro 890',           '1996-03-14', 'Argentina', 'La Plata',               '2024-01-15 14:10:00', 1),
-- Cliente sin telefono ni direccion: ejercita IsDBNull + string?
('Nicolas',        'Villalba',   '20000007', 'Masculino', 'nvillalba07@gmail.com',    NULL,          NULL,                        '1997-12-03', 'Argentina', 'Mar del Plata',          '2024-01-16 15:00:00', 1),

-- 8 a 14: Uruguay - Masculino
('Diego',          'Aguirre',    '20000008', 'Masculino', 'daguirre08@hotmail.com',   '0993211208', '18 de Julio 1020',          '1988-06-17', 'Uruguay',   'Montevideo',            '2024-01-17 15:40:00', 1),
('Gaston',         'Benitez',    '20000009', 'Masculino', 'gbenitez09@yahoo.com',     '0983211209', 'Gorlero 650',               '1989-09-30', 'Uruguay',   'Punta del Este',        '2024-01-18 16:20:00', 1),
('Sebastian',      'Ramos',      '20000010', 'Masculino', 'sramos10@gmail.com',       '0973211210', 'Uruguay 430',               '1991-01-15', 'Uruguay',   'Salto',                 '2024-01-19 17:00:00', 1),
('Rodrigo',        'Molina',     '20000011', 'Masculino', 'rmolina11@hotmail.com',    '0963211211', '19 de Abril 112',           '1992-05-24', 'Uruguay',   'Paysandu',              '2024-01-20 09:10:00', 1),
('Martin',         'Ortiz',      '20000012', 'Masculino', 'mortiz12@yahoo.com',       '0953211212', 'Sarandi 780',               '1993-10-11', 'Uruguay',   'Rivera',                '2024-01-21 10:00:00', 1),
('Federico',       'Luna',       '20000013', 'Masculino', 'fluna13@gmail.com',        '0943211213', 'General Artigas 560',       '1995-04-05', 'Uruguay',   'Maldonado',             '2024-01-22 10:45:00', 1),
('Bruno',          'Sandoval',   '20000014', 'Masculino', 'bsandoval14@hotmail.com',  '0933211214', 'Rambla Costanera 210',      '1996-08-19', 'Uruguay',   'Ciudad de la Costa',    '2024-01-23 11:30:00', 1),

-- 15 a 21: Paraguay - Masculino
('Carlos',         'Maidana',    '20000015', 'Masculino', 'cmaidana15@yahoo.com',     '0981111215', 'Palma 540',                 '1987-03-29', 'Paraguay',  'Asuncion',              '2024-01-24 12:15:00', 1),
('Esteban',        'Vega',       '20000016', 'Masculino', 'evega16@gmail.com',        '0982111216', 'Av. San Blas 1300',         '1990-12-14', 'Paraguay',  'Ciudad del Este',       '2024-01-25 13:00:00', 1),
('Victor',         'Escobar',    '20000017', 'Masculino', 'vescobar17@hotmail.com',   '0983111217', 'Mariscal Estigarribia 890', '1992-07-08', 'Paraguay',  'San Lorenzo',           '2024-01-26 14:20:00', 1),
('Hugo',           'Avalos',     '20000018', 'Masculino', 'havalos18@yahoo.com',      '0984111218', 'General Aquino 320',        '1993-11-28', 'Paraguay',  'Luque',                 '2024-01-27 15:10:00', 1),
('Raul',           'Aquino',     '20000019', 'Masculino', 'raquino19@gmail.com',      '0985111219', 'Costanera San Jose 150',    '1995-02-16', 'Paraguay',  'Encarnacion',           '2024-01-28 16:00:00', 1),
('Hernan',         'Duarte',     '20000020', 'Masculino', 'hduarte20@hotmail.com',    '0986111220', 'Defensores del Chaco 420',  '1997-06-01', 'Paraguay',  'Capiata',               '2024-01-29 16:50:00', 1),
('Gustavo',        'Lescano',    '20000021', 'Masculino', 'glescano21@yahoo.com',     '0987111221', 'Av. Curupayty 230',         '1998-09-15', 'Paraguay',  'Fernando de la Mora',   '2024-01-30 17:30:00', 1),

-- 22 a 27: Femenino (2 Argentina, 2 Uruguay, 2 Paraguay)
('Camila',         'Rivero',     '20000022', 'Femenino',  'crivero22@gmail.com',      '1165431222', 'Santa Fe 2100',             '1992-04-18', 'Argentina', 'Buenos Aires',          '2024-01-31 09:20:00', 1),
('Valentina',      'Paz',        '20000023', 'Femenino',  'vpaz23@hotmail.com',       '3516541223', 'Bv. San Juan 780',          '1994-08-09', 'Argentina', 'Cordoba',               '2024-02-01 10:10:00', 1),
('Florencia',      'Barrios',    '20000024', 'Femenino',  'fbarrios24@yahoo.com',     '0996541224', 'Bulevar Artigas 1430',     '1990-11-27', 'Uruguay',   'Montevideo',            '2024-02-02 11:00:00', 1),
('Lucia',          'Alderete',   '20000025', 'Femenino',  'aalderete25@gmail.com',    '0986541225', 'Av. Roosevelt 900',         '1995-01-30', 'Uruguay',   'Punta del Este',        '2024-02-03 11:50:00', 1),
('Adriana',        'Melgarejo',  '20000026', 'Femenino',  'amelgarejo26@hotmail.com', '0981651226', 'Yegros 670',               '1989-05-14', 'Paraguay',  'Asuncion',              '2024-02-04 12:40:00', 1),
('Patricia',       'Irala',      '20000027', 'Femenino',  'pirala27@yahoo.com',       '0982651227', 'Av. Pioneros del Este 450', '1993-10-03', 'Paraguay',  'Ciudad del Este',       '2024-02-05 13:30:00', 1),

-- 28 a 30: Otro (1 Argentina, 1 Uruguay, 1 Paraguay)
('Alex',           'Quiroga',    '20000028', 'Otro',      'aquiroga28@gmail.com',     '3417651328', 'Cordoba 1500',              '1994-03-21', 'Argentina', 'Rosario',               '2024-02-06 14:15:00', 1),
('Sam',            'Robledo',    '20000029', 'Otro',      'srobledo29@hotmail.com',   '0977651329', 'Calle Real 230',            '1996-07-12', 'Uruguay',   'Colonia del Sacramento','2024-02-07 15:00:00', 1),
('Robin',          'Zarate',     '20000030', 'Otro',      'rzarate30@yahoo.com',      '0983761330', '14 de Mayo 380',            '1997-12-08', 'Paraguay',  'San Lorenzo',           '2024-02-08 15:50:00', 1),

-- ==============================================================================
-- 30 CLIENTES INACTIVOS (status = 0)
-- 21 Masculino, 6 Femenino, 3 Otro
-- ==============================================================================
-- 31 a 37: Argentina - Masculino
('Ignacio',        'Cerda',      '20000031', 'Masculino', 'icerda31@gmail.com',       '1154321131', 'Av. de Mayo 650',           '1986-02-11', 'Argentina', 'Buenos Aires',          '2023-05-10 09:00:00', 0),
('Maximiliano',    'Funes',      '20000032', 'Masculino', 'mfunes32@hotmail.com',     '3414321132', 'Bv. Orono 1120',            '1988-07-19', 'Argentina', 'Rosario',               '2023-05-11 10:10:00', 0),
('Facundo',        'Leiva',      '20000033', 'Masculino', 'fleiva33@yahoo.com',       '3514321133', 'Chacabuco 430',              '1990-10-04', 'Argentina', 'Cordoba',               '2023-05-12 11:20:00', 0),
('Gonzalo',        'Paniagua',   '20000034', 'Masculino', 'gpaniagua34@gmail.com',    '2614321134', 'Las Heras 780',             '1991-12-22', 'Argentina', 'Mendoza',               '2023-05-13 12:30:00', 0),
('Ezequiel',       'Toledo',     '20000035', 'Masculino', 'etoledo35@hotmail.com',    '3814321135', 'Crisostomo Alvarez 210',    '1993-04-15', 'Argentina', 'San Miguel de Tucuman', '2023-05-14 13:40:00', 0),
('Leandro',        'Garay',      '20000036', 'Masculino', 'lgaray36@yahoo.com',       '2214321136', 'Calle 50 Nro 640',          '1995-09-08', 'Argentina', 'La Plata',               '2023-05-15 14:50:00', 0),
-- Cliente sin telefono ni direccion: ejercita IsDBNull + string?
('Damian',         'Alcaraz',    '20000037', 'Masculino', 'dalcaraz37@gmail.com',     NULL,          NULL,                        '1996-11-29', 'Argentina', 'Mar del Plata',          '2023-05-16 15:30:00', 0),

-- 38 a 44: Uruguay - Masculino
('Alvaro',         'Pineyro',    '20000038', 'Masculino', 'apineyro38@hotmail.com',   '0993210138', 'Agraciada 2840',            '1985-08-14', 'Uruguay',   'Montevideo',            '2023-06-01 09:15:00', 0),
('Enzo',           'Bianchi',    '20000039', 'Masculino', 'ebianchi39@yahoo.com',     '0983210139', 'Calle 20 Nro 340',          '1987-11-03', 'Uruguay',   'Punta del Este',        '2023-06-02 10:25:00', 0),
('Emiliano',       'Ferrari',    '20000040', 'Masculino', 'eferrari40@gmail.com',     '0973210140', 'Brasil 890',                '1989-01-20', 'Uruguay',   'Salto',                 '2023-06-03 11:35:00', 0),
('Franco',         'Rinaldi',    '20000041', 'Masculino', 'frinaldi41@hotmail.com',   '0963210141', 'Leandro Gomez 510',         '1992-06-18', 'Uruguay',   'Paysandu',              '2023-06-04 12:45:00', 0),
('Joaquin',        'Modino',     '20000042', 'Masculino', 'jmodino42@yahoo.com',      '0953210142', 'Ceballos 410',              '1994-03-07', 'Uruguay',   'Rivera',                '2023-06-05 14:00:00', 0),
('Pablo',          'Valentin',   '20000043', 'Masculino', 'pvalentin43@gmail.com',    '0943210143', 'Joaquin de Viana 620',      '1995-07-25', 'Uruguay',   'Maldonado',             '2023-06-06 15:10:00', 0),
('Alfonso',        'Techera',    '20000044', 'Masculino', 'atechera44@hotmail.com',   '0933210144', 'Av. Giannattasio km 22',    '1997-10-12', 'Uruguay',   'Ciudad de la Costa',    '2023-06-07 16:20:00', 0),

-- 45 a 51: Paraguay - Masculino
('Marcos',         'Sanabria',   '20000045', 'Masculino', 'msanabria45@yahoo.com',    '0981998445', 'Estrella 450',              '1988-04-03', 'Paraguay',  'Asuncion',              '2023-07-10 09:40:00', 0),
('Rolando',        'Balbuena',   '20000046', 'Masculino', 'rbalbuena46@gmail.com',    '0982998446', 'Av. Monsenor Rodriguez 800','1990-09-17', 'Paraguay',  'Ciudad del Este',       '2023-07-11 10:50:00', 0),
('Nestor',         'Arredondo',  '20000047', 'Masculino', 'narredondo47@yahoo.com',   '0983998447', 'Espana 710',                '1991-12-05', 'Paraguay',  'San Lorenzo',           '2023-07-12 11:30:00', 0),
('Cesar',          'Carrizano',  '20000048', 'Masculino', 'ccarrizano48@hotmail.com', '0984998448', 'Coronel Oviedo 280',        '1993-05-22', 'Paraguay',  'Luque',                 '2023-07-13 13:10:00', 0),
('Guillermo',      'Mereles',    '20000049', 'Masculino', 'gmereles49@gmail.com',     '0985998449', 'Tomas Romero Pereira 540', '1994-08-30', 'Paraguay',  'Encarnacion',           '2023-07-14 14:00:00', 0),
('Ramon',          'Insfran',    '20000050', 'Masculino', 'rinsfran50@yahoo.com',     '0986998450', 'Ruta 2 km 18',              '1996-01-14', 'Paraguay',  'Capiata',               '2023-07-15 15:15:00', 0),
('Osvaldo',        'Recalde',    '20000051', 'Masculino', 'orecalde51@gmail.com',     '0987998451', 'Mariscal Lopez 950',        '1997-04-28', 'Paraguay',  'Fernando de la Mora',   '2023-07-16 16:30:00', 0),

-- 52 a 57: Femenino (2 Argentina, 2 Uruguay, 2 Paraguay)
('Mariana',        'Bogado',     '20000052', 'Femenino',  'mbogado52@gmail.com',      '1148765452', 'Av. Cabildo 2450',          '1991-03-08', 'Argentina', 'Buenos Aires',          '2023-08-01 09:30:00', 0),
('Solange',        'Maciel',     '20000053', 'Femenino',  'smaciel53@hotmail.com',    '3514876453', 'Av. Rafael Nunez 4100',     '1993-06-19', 'Argentina', 'Cordoba',               '2023-08-02 10:45:00', 0),
('Romina',         'Yonema',     '20000054', 'Femenino',  'ryonema54@yahoo.com',      '0994876454', 'Colonia 1320',              '1990-09-11', 'Uruguay',   'Montevideo',            '2023-08-03 11:40:00', 0),
('Daniela',        'Espinola',   '20000055', 'Femenino',  'despinola55@gmail.com',    '0984876455', 'Espana 520',                '1995-12-02', 'Uruguay',   'Maldonado',             '2023-08-04 13:00:00', 0),
('Leticia',        'Candia',     '20000056', 'Femenino',  'lcandia56@hotmail.com',    '0981487656', 'Chile 390',                 '1989-02-27', 'Paraguay',  'Asuncion',              '2023-08-05 14:20:00', 0),
('Gladys',         'Servin',     '20000057', 'Femenino',  'gservin57@yahoo.com',      '0982487657', 'Av. Peru 830',              '1992-08-16', 'Paraguay',  'Ciudad del Este',       '2023-08-06 15:35:00', 0),

-- 58 a 60: Otro (1 Argentina, 1 Uruguay, 1 Paraguay)
('Morgan',         'Yanes',      '20000058', 'Otro',      'myanes58@gmail.com',       '3413876558', 'Mitre 760',                 '1993-01-25', 'Argentina', 'Rosario',               '2023-08-07 16:10:00', 0),
('Ariel',          'Troche',     '20000059', 'Otro',      'atroche59@hotmail.com',    '0973876559', '18 de Julio 640',           '1994-05-18', 'Uruguay',   'Salto',                 '2023-08-08 17:00:00', 0),
('Taylor',         'Monges',     '20000060', 'Otro',      'tmonges60@yahoo.com',      '0983387660', 'General Diaz 210',          '1996-10-31', 'Paraguay',  'Luque',                 '2023-08-09 17:45:00', 0);
GO

-- ==============================================================================
-- Verificacion de resumen: por estado y por sexo
-- ==============================================================================
SELECT 
    status                                                AS [Estado],
    CASE status WHEN 1 THEN 'Activos' ELSE 'Inactivos' END AS [Descripcion],
    COUNT(*)                                              AS [Cantidad],
    SUM(CASE WHEN sex = 'Masculino' THEN 1 ELSE 0 END)    AS [Masculinos],
    SUM(CASE WHEN sex = 'Femenino'  THEN 1 ELSE 0 END)    AS [Femeninos],
    SUM(CASE WHEN sex = 'Otro'      THEN 1 ELSE 0 END)    AS [Otros],
    SUM(CASE WHEN phone IS NULL OR address IS NULL THEN 1 ELSE 0 END) AS [Con Datos Null]
FROM Customer
GROUP BY status
ORDER BY status DESC;
GO

-- ==============================================================================
-- Verificacion de integridad: debe devolver 0 filas si todo esta bien
-- ==============================================================================
SELECT 
    c.customer_id,
    c.dni,
    c.email,
    'DNI con menos de 8 caracteres' AS [Problema]
FROM Customer AS c
WHERE LEN(c.dni) < 8
UNION ALL
SELECT c.customer_id, c.dni, c.email, 'Email sin formato valido'
FROM Customer AS c
WHERE c.email NOT LIKE '%_@_%.%'
UNION ALL
SELECT c.customer_id, c.dni, c.email, 'Menor de 18 anos'
FROM Customer AS c
WHERE c.birth > DATEADD(YEAR, -18, CAST(GETDATE() AS DATE))
UNION ALL
SELECT c.customer_id, c.dni, c.email, 'Sexo no permitido'
FROM Customer AS c
WHERE c.sex NOT IN ('Masculino', 'Femenino', 'Otro');
GO

-- ==============================================================================
-- Verificacion de que el identity quedo correctamente reiniciado
-- ==============================================================================
SELECT 
    MIN(customer_id) AS [Id Minimo],
    MAX(customer_id) AS [Id Maximo],
    COUNT(*)         AS [Total Clientes],
    CASE 
        WHEN MIN(customer_id) = 1 AND MAX(customer_id) = 60 AND COUNT(*) = 60 
        THEN 'OK: ids del 1 al 60, identity reiniciado correctamente'
        ELSE 'REVISAR: el identity no quedo como se esperaba'
    END              AS [Estado del Identity]
FROM Customer;
GO

-- ==============================================================================
-- Listado de clientes activos (mismo criterio de orden que sp_GetActiveCustomers)
-- ==============================================================================
SELECT 
    c.customer_id, c.name AS [Nombre], c.lastname AS [Apellido], c.dni AS [DNI],
    c.sex AS [Sexo], c.birth AS [Fecha Nacimiento], c.email AS [Email],
    c.phone AS [Telefono], c.address AS [Direccion],
    c.nationality AS [Nacionalidad], c.locality AS [Localidad]
FROM Customer AS c
WHERE c.status = 1
ORDER BY c.lastname ASC, c.name ASC;
GO

-- ==============================================================================
-- Listado de clientes inactivos (mismo criterio de orden que sp_GetInactiveCustomers)
-- ==============================================================================
SELECT 
    c.customer_id, c.name AS [Nombre], c.lastname AS [Apellido], c.dni AS [DNI],
    c.sex AS [Sexo], c.birth AS [Fecha Nacimiento], c.email AS [Email],
    c.phone AS [Telefono], c.address AS [Direccion],
    c.nationality AS [Nacionalidad], c.locality AS [Localidad]
FROM Customer AS c
WHERE c.status = 0
ORDER BY c.lastname ASC, c.name ASC;
GO
