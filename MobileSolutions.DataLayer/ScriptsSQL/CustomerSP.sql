USE MobileSolutionsDB;
GO

-- Customer Table Store Procedures
-- ============================================================================
-- 1. OBTENER TODOS LOS CLIENTES ACTIVOS (sp_GetActiveCustomers)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetActiveCustomers
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.customer_id     AS customer_id,
        c.name            AS Nombre,
        c.lastname        AS Apellido,
        c.dni             AS DNI,
        c.sex             AS Sexo,
        c.birth           AS [Fecha Nacimiento],
        c.email           AS Email,
        c.phone           AS Telefono,
        c.address         AS Direccion,
        c.nationality     AS Nacionalidad,
        c.locality        AS Localidad,
        c.register_date   AS RegisterDate
    FROM Customer AS c
    WHERE c.status = 1
    ORDER BY c.lastname ASC, c.name ASC;
END;
GO

-- ============================================================================
-- 2. OBTENER TODOS LOS CLIENTES INACTIVOS (sp_GetInactiveCustomers)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetInactiveCustomers
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.customer_id     AS customer_id,
        c.name            AS Nombre,
        c.lastname        AS Apellido,
        c.dni             AS DNI,
        c.sex             AS Sexo,
        c.birth           AS [Fecha Nacimiento],
        c.email           AS Email,
        c.phone           AS Telefono,
        c.address         AS Direccion,
        c.nationality     AS Nacionalidad,
        c.locality        AS Localidad,
        c.register_date   AS RegisterDate
    FROM Customer AS c
    WHERE c.status = 0
    ORDER BY c.lastname ASC, c.name ASC;
END;
GO

-- ============================================================================
-- 3. CREAR UN NUEVO CLIENTE (sp_CreateCustomer)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_CreateCustomer
    @name           VARCHAR(100),
    @lastname       VARCHAR(100),
    @dni            VARCHAR(8),
    @sex            VARCHAR(10),
    @email          VARCHAR(100),
    @phone          VARCHAR(15) = NULL,
    @address        VARCHAR(100) = NULL,
    @birth          DATE,
    @nationality    VARCHAR(100),
    @locality       VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Validación: El cliente debe ser mayor de 18 años
    IF @birth > DATEADD(YEAR, -18, GETDATE())
    BEGIN
        RAISERROR('El cliente debe ser mayor de 18 años.', 16, 1);
        RETURN;
    END

    -- Validar que los campos obligatorios no vengan vacíos, nulos ni con puros espacios
    IF ISNULL(LTRIM(RTRIM(@name)), '') = '' 
       OR ISNULL(LTRIM(RTRIM(@lastname)), '') = '' 
       OR ISNULL(LTRIM(RTRIM(@dni)), '') = '' 
       OR ISNULL(LTRIM(RTRIM(@sex)), '') = ''
       OR ISNULL(LTRIM(RTRIM(@email)), '') = ''
       OR ISNULL(LTRIM(RTRIM(@nationality)), '') = ''
       OR ISNULL(LTRIM(RTRIM(@locality)), '') = ''
       OR @birth IS NULL
    BEGIN
        RAISERROR('Los campos obligatorios no pueden estar vacíos o contener solo espacios.', 16, 1);
        RETURN;
    END

    INSERT INTO Customer (
        name, lastname, dni, sex, email, 
        phone, address, birth, nationality, 
        locality, register_date, status
    )
    VALUES (
        @name, @lastname, @dni, @sex, @email, 
        @phone, @address, @birth, @nationality, 
        @locality, GETDATE(), 1
    );

    -- Retorna el ID autogenerado para el nuevo cliente
    SELECT SCOPE_IDENTITY() AS NewCustomerId;
END;
GO

-- ============================================================================
-- 4. MODIFICAR UN CLIENTE EXISTENTE (sp_UpdateCustomer)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_UpdateCustomer
    @customer_id    INT,
    @name           VARCHAR(100),
    @lastname       VARCHAR(100),
    @dni            VARCHAR(8),
    @sex            VARCHAR(10),
    @email          VARCHAR(100),
    @phone          VARCHAR(15) = NULL,
    @address        VARCHAR(100) = NULL,
    @birth          DATE,
    @nationality    VARCHAR(100),
    @locality       VARCHAR(100)
AS
BEGIN
    SET NOCOUNT OFF; -- Permite que ExecuteNonQuery() en C# reciba las filas afectadas

    -- Validación: El cliente debe ser mayor de 18 años
    IF @birth > DATEADD(YEAR, -18, GETDATE())
    BEGIN
        RAISERROR('El cliente debe ser mayor de 18 años.', 16, 1);
        RETURN;
    END

    -- Validar que los campos obligatorios no vengan vacíos, nulos ni con puros espacios
    IF ISNULL(LTRIM(RTRIM(@name)), '') = '' 
       OR ISNULL(LTRIM(RTRIM(@lastname)), '') = '' 
       OR ISNULL(LTRIM(RTRIM(@dni)), '') = '' 
       OR ISNULL(LTRIM(RTRIM(@sex)), '') = ''
       OR ISNULL(LTRIM(RTRIM(@email)), '') = ''
       OR ISNULL(LTRIM(RTRIM(@nationality)), '') = ''
       OR ISNULL(LTRIM(RTRIM(@locality)), '') = ''
       OR @birth IS NULL
    BEGIN
        RAISERROR('Los campos obligatorios no pueden estar vacíos o contener solo espacios.', 16, 1);
        RETURN;
    END

    UPDATE Customer
    SET 
        name        = @name,
        lastname    = @lastname,
        dni         = @dni,
        sex         = @sex,
        email       = @email,
        phone       = @phone,
        address     = @address,
        birth       = @birth,
        nationality = @nationality,
        locality    = @locality
    WHERE customer_id = @customer_id;
END;
GO

-- ============================================================================
-- 5. BORRADO LÓGICO DE UN CLIENTE (sp_DeleteCustomer)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_DeleteCustomer
    @customer_id INT
AS
BEGIN
    SET NOCOUNT OFF; -- Permite verificar el éxito con ExecuteNonQuery()

    -- Desactivar registro (soft-delete)
    UPDATE Customer
    SET status = 0
    WHERE customer_id = @customer_id;
END;
GO

-- ============================================================================
-- 6. REACTIVACION DE UN CLIENTE (sp_ReactivateCustomer)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_ReactivateCustomer
    @customer_id INT
AS
BEGIN
    SET NOCOUNT OFF; -- Permite verificar el éxito con ExecuteNonQuery()

    -- Reactivar registro
    UPDATE Customer
    SET status = 1
    WHERE customer_id = @customer_id;
END;
GO

-- ============================================================================
-- 7. BUSCAR CLIENTES ACTIVOS CON FILTRO DINÁMICO (sp_SearchActiveCustomers)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_SearchActiveCustomers
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Normaliza el término de búsqueda
    SET @SearchTerm = NULLIF(LTRIM(RTRIM(@SearchTerm)), '');

    SELECT 
        c.customer_id     AS customer_id,
        c.name            AS Nombre,
        c.lastname        AS Apellido,
        c.dni             AS DNI,
        c.sex             AS Sexo,
        c.birth           AS [Fecha Nacimiento],
        c.email           AS Email,
        c.phone           AS Telefono,
        c.address         AS Direccion,
        c.nationality     AS Nacionalidad,
        c.locality        AS Localidad,
        c.register_date   AS RegisterDate
    FROM Customer AS c
    WHERE 
        c.status = 1
        AND (
            @SearchTerm IS NULL 
            OR c.name         LIKE '%' + @SearchTerm + '%'
            OR c.lastname     LIKE '%' + @SearchTerm + '%'
            OR c.dni          LIKE '%' + @SearchTerm + '%'
            OR c.email        LIKE '%' + @SearchTerm + '%'
            OR c.phone        LIKE '%' + @SearchTerm + '%'
            OR c.locality     LIKE '%' + @SearchTerm + '%'
            OR c.nationality  LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY c.lastname ASC, c.name ASC;
END;
GO

-- ============================================================================
-- 8. BUSCAR CLIENTES INACTIVOS CON FILTRO DINÁMICO (sp_SearchInactiveCustomers)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_SearchInactiveCustomers
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Normaliza el término de búsqueda
    SET @SearchTerm = NULLIF(LTRIM(RTRIM(@SearchTerm)), '');

    SELECT 
        c.customer_id     AS customer_id,
        c.name            AS Nombre,
        c.lastname        AS Apellido,
        c.dni             AS DNI,
        c.sex             AS Sexo,
        c.birth           AS [Fecha Nacimiento],
        c.email           AS Email,
        c.phone           AS Telefono,
        c.address         AS Direccion,
        c.nationality     AS Nacionalidad,
        c.locality        AS Localidad,
        c.register_date   AS RegisterDate
    FROM Customer AS c
    WHERE 
        c.status = 0
        AND (
            @SearchTerm IS NULL 
            OR c.name         LIKE '%' + @SearchTerm + '%'
            OR c.lastname     LIKE '%' + @SearchTerm + '%'
            OR c.dni          LIKE '%' + @SearchTerm + '%'
            OR c.email        LIKE '%' + @SearchTerm + '%'
            OR c.phone        LIKE '%' + @SearchTerm + '%'
            OR c.locality     LIKE '%' + @SearchTerm + '%'
            OR c.nationality  LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY c.lastname ASC, c.name ASC;
END;
GO