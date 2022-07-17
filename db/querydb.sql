/*Creamos la base de datos net_core_api_db*/
CREATE DATABASE IF NOT EXISTS net_core_api_db;
USE net_core_api_db;
/*Creamos la tabla clientes*/
CREATE TABLE IF NOT EXISTS clientes(
    id_cliente INTEGER PRIMARY KEY auto_increment,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    telefono VARCHAR(50) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    ciudad VARCHAR(50) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    pais VARCHAR(50) NOT NULL,
    cp VARCHAR(50) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL
);
/*Insertamos datos del cliente*/
INSERT INTO clientes(
        nombre,
        apellido,
        email,
        telefono,
        direccion,
        ciudad,
        estado,
        pais,
        cp,
        created_at,
        updated_at
    )
VALUES(
        'Jimmy',
        'Mendoza',
        'j.mendoza@mail.com',
        '6666666',
        'Calle 321',
        'Lima',
        'SJL',
        'Peru',
        '12345',
        '2022-01-01 00:00:00',
        '2022-01-01 00:00:00'
    );
/*Mostramos la tabla clientes*/
SELECT *
FROM clientes;