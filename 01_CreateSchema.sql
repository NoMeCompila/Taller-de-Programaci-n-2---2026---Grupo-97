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
