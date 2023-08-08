-- Insert sample data into TAB_PAISES
INSERT INTO TAB_PAISES (PAIS)
VALUES
    ('Argentina'),
    ('Brazil'),
    ('Chile');

-- Insert sample data into TAB_CIUDADES
INSERT INTO TAB_CIUDADES (ID_PAIS, CIUDAD)
VALUES
    (1, 'Buenos Aires'),
    (2, 'Rio de Janeiro'),
    (3, 'Santiago');

-- Insert sample data into TAB_AEROPUERTOS
INSERT INTO TAB_AEROPUERTOS (ID_CIUDAD, CODIGO_AEROPUERTO, NOMBRE_AEROPUERTO)
VALUES
    (1, 'EZE', 'Ministro Pistarini Airport'),
    (2, 'GIG', 'Rio de Janeiro-Galeão International Airport'),
    (3, 'SCL', 'Arturo Merino Benítez International Airport');

-- Insert sample data into TAB_CLIENTES
INSERT INTO TAB_CLIENTES (NRO_IDENTIFICACION, NOMBRES, APELLIDOS, DIRECCION, TELEFONO, NRO_TARJETA)
VALUES
    ('1050116621', 'Diego', 'Cacuango', 'Av.Atahualpa', '098183170', '1234567890123');
    
-- Insert sample data into TAB_ROLES
INSERT INTO TAB_ROLES (ROL)
VALUES
    ('Administrator');
   

   -- Insert sample data into TAB_USUARIOS
INSERT INTO TAB_USUARIOS (ID_ROL, NOMBRE_USUARIO, APELLIDO_USUARIO, USUARIO, CLAVE)
VALUES
    (1, 'Diego', 'Cacuango', 'admin', 'admin'),
    (1, 'Alexander', 'Pabon', 'admin1', 'admin1');


	INSERT INTO TAB_TARJETAS_EMBARQUE (ID_CLIENTE, ID_VUELO)
VALUES
   (1, 1),
   (1, 1),
   (3, 2);

	-- Insertar datos en la tabla TAB_VUELOS
INSERT INTO TAB_VUELOS (ID_VUELO ,ID_AEROPUERTO_LLEGADA, ID_AEROPUERTO_SALIDA, CODIGO_VUELO, FECHA_SALIDA, FECHA_LLEGADA, PRECIO)
VALUES
   (1, 2, 'VUELO001', '2023-08-08 08:00:00', '2023-08-08 10:00:00', 150.00);
   


