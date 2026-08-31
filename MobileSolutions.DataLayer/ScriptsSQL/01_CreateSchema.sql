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

-- 5. Tabla de Usuarios (Empleados/Vendedores)
CREATE TABLE [User] (
    user_id INT IDENTITY(1,1) NOT NULL,
    profile_id INT NOT NULL,
    name VARCHAR(100) NOT NULL,
    lastname VARCHAR(100) NOT NULL,
    dni VARCHAR(8) NOT NULL,
    sex VARCHAR(10) NOT NULL,
    username VARCHAR(100) NOT NULL,
    password VARCHAR(255) NOT NULL,
    email VARCHAR(100) NOT NULL, 
    phone VARCHAR(15) NULL,
    address VARCHAR(100) NULL,
    birth DATE NOT NULL,
    nationality VARCHAR(100) NOT NULL,
    locality VARCHAR(100) NOT NULL,
    register_date DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    status BIT NOT NULL DEFAULT 1,

    CONSTRAINT PK_User PRIMARY KEY (user_id), 
    CONSTRAINT FK_User_Profile FOREIGN KEY (profile_id) REFERENCES Profile(profile_id), 
    CONSTRAINT UQ_User_DNI UNIQUE (dni), 
    CONSTRAINT UQ_User_Username UNIQUE (username), 
    CONSTRAINT UQ_User_Email UNIQUE (email), 
    CONSTRAINT CHK_User_Sex CHECK (sex IN ('Masculino', 'Femenino', 'Otro')), 
    CONSTRAINT CHK_User_Birth CHECK (birth < CAST(GETDATE() AS DATE)),
    CONSTRAINT CHK_User_Email CHECK (email LIKE '%_@_%.%') 
);

-- 6. Tabla de Productos
CREATE TABLE Product (
    product_id INT IDENTITY(1,1) NOT NULL,
    brand_id INT NOT NULL,
    product_code VARCHAR(100) NOT NULL,
    name VARCHAR(100) NOT NULL,
    stock INT NOT NULL, 
    purchase_price DECIMAL(18, 2) NOT NULL,
    sale_price DECIMAL(18, 2) NOT NULL,
    status BIT NOT NULL DEFAULT 1,
    image VARCHAR(255) NULL,

    CONSTRAINT PK_Product PRIMARY KEY (product_id),
    CONSTRAINT FK_Product_Brand FOREIGN KEY (brand_id) REFERENCES Brand(brand_id),
    CONSTRAINT UQ_Product_Code UNIQUE (product_code), 
    CONSTRAINT  CHK_Product_Stock CHECK (stock >= 0),
    CONSTRAINT CHK_Product_PurchasePrice CHECK (purchase_price >= 0), 
    CONSTRAINT CHK_Product_SalePrice CHECK (sale_price >= purchase_price)
);

-- 7. Tabla Cabecera de Venta
CREATE TABLE SaleHeader (
    sale_id INT IDENTITY(1,1) NOT NULL,
    payment_type_id INT NOT NULL,
    customer_id INT NOT NULL,
    user_id INT NOT NULL,
    sale_number VARCHAR(100) NOT NULL,
    sale_date DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    total_sale DECIMAL(18, 2) NOT NULL,
    status BIT NOT NULL DEFAULT 1,

    CONSTRAINT PK_SaleHeader PRIMARY KEY (sale_id),
    CONSTRAINT FK_SaleHeader_PaymentType FOREIGN KEY (payment_type_id) REFERENCES PaymentType(payment_type_id),
    CONSTRAINT FK_SaleHeader_Customer FOREIGN KEY (customer_id) REFERENCES Customer(customer_id),
    CONSTRAINT FK_SaleHeader_User FOREIGN KEY (user_id) REFERENCES [User](user_id),
    CONSTRAINT UQ_SaleHeader_SaleNumber UNIQUE (sale_number), 
    CONSTRAINT CHK_SaleHeader_TotalSale CHECK (total_sale >= 0) 
);

-- 8. Tabla Detalle de Venta
CREATE TABLE SaleDetail (
    sale_detail_id INT IDENTITY(1,1) NOT NULL,
    sale_id INT NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(18, 2) NOT NULL,

    CONSTRAINT PK_SaleDetail PRIMARY KEY (sale_detail_id),
    CONSTRAINT FK_SaleDetail_SaleHeader FOREIGN KEY (sale_id) REFERENCES SaleHeader(sale_id),
    CONSTRAINT FK_SaleDetail_Product FOREIGN KEY (product_id) REFERENCES Product(product_id),
    CONSTRAINT CHK_SaleDetail_Quantity CHECK (quantity > 0), 
    CONSTRAINT CHK_SaleDetail_Price CHECK (price >= 0), 
    CONSTRAINT UQ_SaleDetail_Sale_Product UNIQUE (sale_id, product_id) 
);

