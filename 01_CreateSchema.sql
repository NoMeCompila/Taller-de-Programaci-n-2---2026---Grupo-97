-- 1. Tabla de Perfiles / Roles
CREATE TABLE Profile (
    profile_id INT IDENTITY(1,1) NOT NULL,
    description VARCHAR(100) NOT NULL,
    status BIT NOT NULL DEFAULT 1,
    CONSTRAINT PK_Profile PRIMARY KEY (profile_id),
    CONSTRAINT UQ_Profile_Description UNIQUE (description) 
);
