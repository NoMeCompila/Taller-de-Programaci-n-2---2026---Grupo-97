USE MobileSolutionsDB;
GO

-- User Table Store Procedures

-- sp_GetActiveUsers: Get Active Users
CREATE OR ALTER PROCEDURE sp_GetActiveUsers
AS
BEGIN
    SET NOCOUNT ON;  -- desactiva el conteo de filas afectadas para mejorar el rendimiento y evitar resultados innecesarios

    SELECT 
        Usuarios.user_id       AS user_id,
        Usuarios.profile_id    AS profile_id,
        Perfiles.description   AS Perfil,
        Usuarios.name          AS Nombre,
        Usuarios.lastname      AS Apellido,
        Usuarios.username      AS Usuario,
        Usuarios.dni           AS DNI,
        Usuarios.sex           AS Sexo,
        Usuarios.birth         AS [Fecha Nacimiento],
        Usuarios.email         AS Email,
        Usuarios.phone         AS Telefono,
        Usuarios.address       AS Direccion,
        Usuarios.nationality   AS Nacionalidad,
        Usuarios.locality      AS Localidad
    FROM [User] AS Usuarios
    INNER JOIN Profile AS Perfiles 
        ON Usuarios.profile_id = Perfiles.profile_id
    WHERE Usuarios.status = 1
    ORDER BY Usuarios.lastname ASC, Usuarios.name ASC;
END;
GO

----------

CREATE OR ALTER PROCEDURE sp_GetInactiveUsers
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Usuarios.user_id       AS user_id,
        Usuarios.profile_id    AS profile_id,
        Perfiles.description   AS Perfil,
        Usuarios.name          AS Nombre,
        Usuarios.lastname      AS Apellido,
        Usuarios.username      AS Usuario,
        Usuarios.dni           AS DNI,
        Usuarios.sex           AS Sexo,
        Usuarios.birth         AS [Fecha Nacimiento],
        Usuarios.email         AS Email,
        Usuarios.phone         AS Telefono,
        Usuarios.address       AS Direccion,
        Usuarios.nationality   AS Nacionalidad,
        Usuarios.locality      AS Localidad
    FROM [User] AS Usuarios
    INNER JOIN Profile AS Perfiles 
        ON Usuarios.profile_id = Perfiles.profile_id
    WHERE Usuarios.status = 0
    ORDER BY Usuarios.lastname ASC, Usuarios.name ASC;
END;
GO


--------- devolver mensaje de error en caso de que devuelva alguno

CREATE OR ALTER PROCEDURE sp_CreateUser
    @profile_id     INT,
    @name           VARCHAR(100),
    @lastname       VARCHAR(100),
    @dni            VARCHAR(8),
    @sex            VARCHAR(10),
    @username       VARCHAR(100),
    @password       VARCHAR(255),
    @email          VARCHAR(100),
    @phone          VARCHAR(15) = NULL,
    @address        VARCHAR(100) = NULL,
    @birth          DATE,
    @nationality    VARCHAR(100),
    @locality       VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [User] (
        profile_id, name, lastname, dni, sex, username, 
        password, email, phone, address, birth, nationality, 
        locality, register_date, status
    )
    VALUES (
        @profile_id, @name, @lastname, @dni, @sex, @username, 
        @password, @email, @phone, @address, @birth, @nationality, 
        @locality, GETDATE(), 1
    );

    -- Retorna el ID autogenerado
    SELECT SCOPE_IDENTITY() AS NewUserId;
END;
GO


-----


CREATE OR ALTER PROCEDURE sp_UpdateUser
    @user_id        INT,
    @profile_id     INT,
    @name           VARCHAR(100),
    @lastname       VARCHAR(100),
    @dni            VARCHAR(8),
    @sex            VARCHAR(10),
    @username       VARCHAR(100),
    @email          VARCHAR(100),
    @phone          VARCHAR(15) = NULL,
    @address        VARCHAR(100) = NULL,
    @birth          DATE,
    @nationality    VARCHAR(100),
    @locality       VARCHAR(100),
    @password       VARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT OFF;

    UPDATE [User]
    SET 
        profile_id   = @profile_id,
        name         = @name,
        lastname     = @lastname,
        dni          = @dni,
        sex          = @sex,
        username     = @username,
        email        = @email,
        phone        = @phone,
        address      = @address,
        birth        = @birth,
        nationality  = @nationality,
        locality     = @locality,
        password     = ISNULL(@password, password)
    WHERE user_id = @user_id;
END;
GO



----


CREATE OR ALTER PROCEDURE sp_DeleteUser
    @user_id INT
AS
BEGIN
    SET NOCOUNT OFF;

    UPDATE [User]
    SET status = 0
    WHERE user_id = @user_id;
END;
GO

-- Falta agregar la Alta lógica para reactivar un usuario, si es necesario. 