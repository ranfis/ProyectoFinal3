Proyecto de Compra y Reservación de Boletos Aéreos. 
==============

```
Resumen:
El proyecto consiste en la elaboración de una aplicación para la compra y reservación de boletos aéreos 
para una agencia de viajes. La lógica para la compra o reservación consiste en que solo se pude generar 
estas operaciones sobre los vuelos que estén disponibles, un vuelo esta disponible si la fecha del mismo 
no ha expirado o existen asientes hábiles. La aplicación de reservaciones debe consumir un servicio que 
exponga y actualice el estatus de los vuelos por aerolínea (ver arquitectura). La aplicación para la 
aerolínea es la encargada de coordinar los vuelos y la misma es separada de la aplicación de reservaciones 
(Agencia de Viajes). La aplicación de la agencia de viajes debe permitir: Mantenimiento de clientes, facturación
 de los vuelos, reservaciones de vuelos (48 horas), lista de espera (se envía correo), cancelar reservas. 
 La aplicación de mantenimiento de los vuelos debe permitir: Registrar vuelos, registrar aerolínea y el registro
  de los aviones, esta aplicación no debe permitir 2 vuelos del mismo avión en un mismo horario o más de 3 vuelos 
  en el día. La agencia de viajes quiere que sus clientes finales pueda hacer las reservaciones vía su pagina 
  web, donde pueden seleccionar las fechas y la ruta del viaje, esta le muestre los viajes disponibles y pueda 
  reservar por esta vía utilizando un usuario previamente registrado.
```