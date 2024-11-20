CREATE DATABASE DB_POE_FINAL;
USE DB_POE_FINAL

--TABLA DE CLIENTES 
CREATE TABLE CLIENTES(
	ID_CLIENTE INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE_CLIENTE VARCHAR(15) NOT NULL,
	APELLIDO_CLIENTE VARCHAR(15) NOT NULL,
	CEDULA_CLIENTE VARCHAR(10)NOT NULL, 
	NUMERO_CLIENTE VARCHAR(10) NOT NULL,
	DIRECCION_CLIENTE VARCHAR(200) NOT NULL
	
);

SELECT * FROM CLIENTES

DROP TABLE CLIENTES

INSERT INTO CLIENTES(NOMBRE_CLIENTE,APELLIDO_CLIENTE,CEDULA_CLIENTE,NUMERO_CLIENTE,DIRECCION_CLIENTE)
VALUES('Juan','Perez','0956732036','0912365478','La alborada 8 etapa ');


--Procedimiento de cliente------
GO
CREATE PROCEDURE SP_GET_ALL_CLIENTE
AS
BEGIN
	SELECT * FROM CLIENTES
END
GO

--crear los clientes nuevos----------
GO
CREATE PROCEDURE SP_CREAR_CLIENTE(
@n_cliente VARCHAR (15),
@a_cliente VARCHAR (15),
@c_cliente VARCHAR(10),
@num_cliente VARCHAR (10),
@d_cliente VARCHAR(200)
)
AS
BEGIN
INSERT INTO CLIENTES(NOMBRE_CLIENTE,APELLIDO_CLIENTE,CEDULA_CLIENTE,NUMERO_CLIENTE,DIRECCION_CLIENTE)
VALUES(@n_cliente,@a_cliente,@c_cliente,@num_cliente,@d_cliente);
END
GO

--Eliminar clientes
GO
CREATE PROCEDURE SP_ELIMINAR_CLIENTE
    @ID_CLIENTE INT
AS
BEGIN
    DELETE FROM CLIENTES
    WHERE ID_CLIENTE = @ID_CLIENTE;
END
GO

-------Obtener nombre de cliente
GO
CREATE PROCEDURE SP_GET_NOMBRE_CLIENTE
AS
BEGIN
	SELECT ID_CLIENTE, NOMBRE_CLIENTE FROM CLIENTES
END
GO

-------------------------TABLA NUEVA---------------------
---------CELULAR

CREATE TABLE EQUIPOSCELULARES(
	ID_EQUIPO INT IDENTITY(1,1) PRIMARY KEY,
	MODELO_EQUIPO VARCHAR(50) NOT NULL,
	MARCA_EQUIPO VARCHAR(50) NOT NULL,
	DETALLE_EQUIPO VARCHAR(255) NOT NULL,
	CLIENTE_ID INT NOT NULL,
	CONSTRAINT FK_EQUIPOS_CLIENTES FOREIGN KEY (CLIENTE_ID) 
	REFERENCES CLIENTES(ID_CLIENTE) 
	ON DELETE CASCADE
);
--------------
SELECT * FROM EQUIPOSCELULARES

DROP TABLE EQUIPOSCELULARES

INSERT INTO EQUIPOSCELULARES(MODELO_EQUIPO,MARCA_EQUIPO,DETALLE_EQUIPO,CLIENTE_ID)
VALUES('iPhone 10','Apple','bater�a da�ada',1);

--PROCEDIMIENTO DE CREAR CELULAR
CREATE PROCEDURE SP_CREAR_CELULARR(
    @modelo VARCHAR(50),
    @marca VARCHAR(50),
    @detalle VARCHAR(255),
    @cliente_id INT
)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM CLIENTES WHERE ID_CLIENTE = @cliente_id)
    BEGIN
        INSERT INTO EQUIPOSCELULARES(MODELO_EQUIPO, MARCA_EQUIPO, DETALLE_EQUIPO, CLIENTE_ID)
        VALUES(@modelo, @marca, @detalle, @cliente_id);
    END
    ELSE
    BEGIN
        RAISERROR ('El CLIENTE_ID no existe.', 16, 1);
    END
END;
GO

--Eliminar celulares
GO
CREATE PROCEDURE SP_ELIMINAR_CELULAR
    @ID_EQUIPO INT
AS
BEGIN
    DELETE FROM EQUIPOSCELULARES
    WHERE ID_EQUIPO = @ID_EQUIPO;
END
GO

EXEC SP_ELIMINAR_CELULAR @ID_EQUIPO = 2;


-----Procedimiento de celulares
GO
CREATE PROCEDURE SP_GET_ALL_CELULAR
	@ID_CLIENTE INT
AS
BEGIN
	SELECT ID_EQUIPO, MODELO_EQUIPO, MARCA_EQUIPO, DETALLE_EQUIPO, CLIENTE_ID
	FROM EQUIPOSCELULARES
	WHERE CLIENTE_ID = @ID_CLIENTE;
END;

---ESTO ES PARA MOSTRAR EL CELULAR CUANDO SE ELIGE EL NOMBRE DEL DUE�O EN EL MANTENIMIENTO
GO
CREATE PROCEDURE SP_CELULAR_CLIENTE
    @CLIENTE_ID INT
AS
BEGIN
    SELECT CLIENTE_ID, CONCAT(MARCA_EQUIPO, ' ', MODELO_EQUIPO) AS DESCRIPCION_CELL
    FROM EQUIPOSCELULARES
    WHERE CLIENTE_ID = @CLIENTE_ID
END
GO

--------TABLA NUEVA-----------------
---- USER	

DROP TABLE USER_SESSION
CREATE TABLE USER_SESSION(
	ID_USER INT IDENTITY (1,1) PRIMARY KEY,
	USUARIO VARCHAR(10) NOT NULL,
	CONTRASENA VARCHAR(10) NOT NULL
);

SELECT * FROM USER_SESSION


--procedimiento para crear usuarios nuevos
GO
CREATE PROCEDURE SP_CREAR_USERS
@Usuario varchar(10),
@Contrasena varchar(10)
AS
BEGIN
	INSERT INTO USER_SESSION(USUARIO,CONTRASENA) VALUES (@Usuario, @Contrasena) 
END
GO

------------------------------------------------------------------------------
--IMPORTANTE: EJECUTAR ESTA LINEA PARA CREAR EL USUARIO NUEVO PARA INICIAR SESION
SP_CREAR_USERS 'PROYECTO',12345



--procedimiento que valida el usuario y contrase�a
GO
CREATE PROCEDURE SP_VALIDAR_USER
    @Usuario_u VARCHAR(10),
    @Contrasena_u VARCHAR(50)
AS
BEGIN
    SELECT COUNT(1) 
    FROM USER_SESSION 
    WHERE USUARIO = @Usuario_u AND CONTRASENA = @Contrasena_u
END
GO


------------TABLA NUEVA -----------------
--------- TECNICOS

CREATE TABLE TECNICOS(
	ID_TECNICO INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE_TECNICO VARCHAR(15) NOT NULL,
	APELLIDO_TECNICO VARCHAR(15) NOT NULL,
	CEDULA_TECNICO VARCHAR(10)NOT NULL, 
	NUMERO_TECNICO VARCHAR(10) NOT NULL,
	EXPERIENCIA_TECNICO VARCHAR(50) NOT NULL
);

SELECT * FROM TECNICOS

DROP TABLE TECNICOS

INSERT INTO TECNICOS(NOMBRE_TECNICO,APELLIDO_TECNICO,CEDULA_TECNICO,NUMERO_TECNICO,EXPERIENCIA_TECNICO)
VALUES('Juan','Perez','0956732036','0912365478','5 meses');

--procedimiento que obtiene los nombres
GO
CREATE PROCEDURE SP_GET_NOMBRE_TECNICO
AS
BEGIN
	SELECT ID_TECNICO, NOMBRE_TECNICO FROM TECNICOS
END
GO

--Procedimiento de tecnico 
GO
CREATE PROCEDURE SP_GET_ALL_TECNICO
AS
BEGIN
	SELECT * FROM TECNICOS
END
GO

--crear los tecnicos nuevos
GO
CREATE PROCEDURE SP_CREAR_TECNICO(
@n_tecnico VARCHAR (15),
@a_tecnico VARCHAR (15),
@c_tecnico VARCHAR(10),
@num_tecnico VARCHAR (10),
@ex_tecnico VARCHAR(50)
)
AS
BEGIN
INSERT INTO TECNICOS(NOMBRE_TECNICO,APELLIDO_TECNICO,CEDULA_TECNICO,NUMERO_TECNICO,EXPERIENCIA_TECNICO)
VALUES(@n_tecnico,@a_tecnico,@c_tecnico,@num_tecnico,@ex_tecnico);
END
GO

--eliminar los TECNICOS
GO
CREATE PROCEDURE SP_ELIMINAR_TECNICO
@n_tecnico VARCHAR (15),
@a_tecnico VARCHAR (15),
@c_tecnico VARCHAR(10),
@num_tecnico VARCHAR (10),
@ex_tecnico VARCHAR(50)
AS
BEGIN
SET NOCOUNT ON;
    DELETE FROM TECNICOS
    WHERE 
        NOMBRE_TECNICO = @n_tecnico AND
		APELLIDO_TECNICO = @a_tecnico AND
		CEDULA_TECNICO= @c_tecnico AND
		NUMERO_TECNICO=@num_tecnico AND
		EXPERIENCIA_TECNICO=@ex_tecnico;
END
GO


---------------TABLA NUEVA--------------------
------MANTENIMIENTO

CREATE TABLE MANTENIMIENTO(
	ID_MANTENIMIENTO INT IDENTITY(1,1) PRIMARY KEY,
	FECHA_MANTENIMIENTO DATETIME,
	DESCRIPCION VARCHAR(255),
	PRECIO FLOAT,
	REPUESTOS VARCHAR(MAX) --SE ALMACENA LA LISTA DE REPUESTOS SEPARADOS X UNA COMA
);

SELECT * FROM MANTENIMIENTO

DROP TABLE MANTENIMIENTO

--PROCEDIMIENTO DE CREAR MANTENIMIENTO
CREATE PROCEDURE SP_CREAR_MANTENIMIENTO
	@FECHA_MANTENIMIENTO DATETIME,
	@DESCRIPCION VARCHAR(255),
	@PRECIO FLOAT,
	@REPUESTOS VARCHAR(MAX)
AS
BEGIN
	INSERT INTO MANTENIMIENTO (FECHA_MANTENIMIENTO, DESCRIPCION, PRECIO, REPUESTOS)
	VALUES (@FECHA_MANTENIMIENTO, @DESCRIPCION, @PRECIO, @REPUESTOS);
END

DROP PROCEDURE SP_CREAR_MANTENIMIENTO;