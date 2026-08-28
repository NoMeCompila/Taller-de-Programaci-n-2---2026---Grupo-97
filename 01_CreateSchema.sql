-- 1. Tabla de Perfiles / Roles
CREATE TABLE Profile (
    profile_id INT IDENTITY(1,1) NOT NULL,
    description VARCHAR(100) NOT NULL,
    status BIT NOT NULL DEFAULT 1,
    CONSTRAINT PK_Profile PRIMARY KEY (profile_id),
    CONSTRAINT UQ_Profile_Description UNIQUE (description) 
);

-- 2. Tabla de Tipos de Pago
CREATE TABLE PaymentType (
    payment_type_id INT IDENTITY(1,1) NOT NULL,
    description VARCHAR(100) NOT NULL,
    status BIT NOT NULL DEFAULT 1,
    CONSTRAINT PK_PaymentType PRIMARY KEY (payment_type_id),
    CONSTRAINT UQ_PaymentType_Description UNIQUE (description) 
);

-- 3. Tabla de Marcas
CREATE TABLE Brand (
    brand_id INT IDENTITY(1,1) NOT NULL,
    name VARCHAR(100) NOT NULL,
    status BIT NOT NULL DEFAULT 1,
    CONSTRAINT PK_Brand PRIMARY KEY (brand_id),
    CONSTRAINT UQ_Brand_Name UNIQUE (name) 
);

-- 4. Tabla de Clientes
CREATE TABLE Customer (
    customer_id INT IDENTITY(1,1) NOT NULL,
    name VARCHAR(100) NOT NULL,
    lastname VARCHAR(100) NOT NULL,
    dni VARCHAR(8) NOT NULL,
    sex VARCHAR(10) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone VARCHAR(15) NULL,
    address VARCHAR(100) NULL,
    birth DATE NOT NULL,
    nationality VARCHAR(100) NOT NULL,
    locality VARCHAR(100) NOT NULL,
    register_date DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    status BIT NOT NULL DEFAULT 1,
    CONSTRAINT PK_Customer PRIMARY KEY (customer_id),
    CONSTRAINT UQ_Customer_DNI UNIQUE (dni), 
    CONSTRAINT UQ_Customer_Email UNIQUE (email), 
    CONSTRAINT CHK_Customer_Sex CHECK (sex IN ('Masculino', 'Femenino', 'Otro')), 
    CONSTRAINT CHK_Customer_Birth CHECK (birth < CAST(GETDATE() AS DATE)), 
    CONSTRAINT CHK_Customer_Email CHECK (email LIKE '%_@_%.%') 
);

