/*
Se quiere listar los datos de las distintas funciones de los ultimos 6 meses junto con la cantidad de entradas vendidas. 
Solo se muestran las funciones con peliculas que tienen una duracion mayor de la promedio.
*/

SELECT f.id_funcion 'Función Nro.', titulo 'Película', genero 'Género', duracion 'Duración', s.id_sala 'Sala Nro', descripcion 'Tipo Sala',
	   FORMAT(Hora, 'HH') 'Horario (hs)', COUNT(e.id_entrada) 'Cant. Entradas Vendidas'
FROM Funciones f 
	 join Peliculas p on p.id_pelicula = f.id_pelicula
	 join Salas s on s.id_sala = f.id_sala
	 join Tipos_Sala ts on ts.id_tipo_sala = s.id_tipo_sala
	 join Entradas e on e.id_funcion = f.id_funcion
	 join Ventas v on v.id_venta = e.id_venta
WHERE MONTH(v.fecha) > MONTH(GETDATE()) - 6
GROUP BY f.id_funcion, titulo, genero, duracion, s.id_sala, descripcion, FORMAT(Hora, 'HH')
HAVING duracion > (SELECT AVG(duracion)
				   FROM Peliculas p2)

/*
Se quiere listar las 
*/


/*
--En una misma tabla, se quiere saber cuáles son las películas más populares según el número de reservas, 
--de aquellas peliculas que su forma de pago sea en efectivo y por otro lado las peliculas que no tuvieron
--mucho éxito en los ultimos 4 meses, sin contar el mes actual
*/

SELECT p.titulo Titulo, COUNT(r.id_reserva) 'Cant. de Reservas', 'Mas populares' 'Observación'
FROM Reservas r 
	 join Funciones f on r.id_funcion = f.id_funcion
	 join Peliculas p on p.id_pelicula = f.id_pelicula
	 join Entradas e on e.id_funcion = f.id_funcion
	 join Formas_Pago fp on fp.id_forma_pago = e.id_forma_pago
WHERE fp.descripcion = 'Efectivo'
UNION
SELECT p2.titulo, COUNT(r2.id_reserva), 'Menos populares'
FROM Reservas r2
	 join Funciones f2 on r2.id_funcion = f2.id_funcion
	 join Peliculas p2 on p2.id_pelicula = f2.id_pelicula
	 join Entradas e2 on e2.id_funcion = f2.id_funcion
GROUP BY 1
ORDER BY 3 DESC


/*
Se quiere listar el precio total de entradas vendidas
*/

SELECT 
FROM Ventas v
	 join Entradas e on e.id_entrada


--Emitir un listado que muestre, por mes y por vendedores, la cantidad de entradas vendidas,
--el total por vendedor y el promedio de montos diarios, para las peliculas clasificadas 
--para mayores de edad donde el total de ventas por vendedor sea mayor o igual a $2000.
Select year(v.fecha) Año, month(v.fecha) Mes, 
		ve.nombre+' '+ve.apellido Vendedor,
		count(e.id_entrada) 'Cantidad de entradas vendidas',
		sum(pre_unitario) 'Total entradas',
		avg(pre_unitario) 'Promedio precios'
from Entradas e JOIN Ventas v on e.id_venta = v.id_venta
		JOIN Vendedores ve on ve.id_vendedor= v.id_vendedor
		JOIN Funciones f on f.id_funcion = e.id_funcion
		JOIN Peliculas p on p.id_pelicula = f.id_pelicula
where p.clasificacion= 'APT'
and	month(v.fecha)=month(getdate()) 
and year(v.fecha)=year(getdate())
group by year(v.fecha), month(v.fecha), ve.nombre+' '+ve.apellido
having 2000 <=	(select (sum(e.pre_unitario))
			     from Ventas v 
				  join Vendedores ve1 on ve1.id_vendedor = v.id_vendedor
			      join Entradas e on e.id_venta = v.id_venta
				 where ve1.id_vendedor=v.id_vendedor)


--En una misma tabla, se quiere saber cuáles son las películas más populares según el número de reservas, 
--de aquellas peliculas que su forma de pago sea en efectivo y por otro lado las peliculas que no tuvieron
--mucho éxito en los ultimos 4 meses, sin contar el mes actual
SELECT p.titulo Titulo, COUNT(r.id_reserva) Reservas, 'Más populares' 'Observación'
FROM Reservas r 
	 join Funciones f on r.id_reserva= f.id_funcion
	 join Peliculas p on f.id_pelicula=p.id_pelicula
	 join Entradas e  on e.id_funcion= f.id_funcion
	 join Formas_Pago fp on fp.id_forma_pago= e.id_forma_pago
where fp.id_forma_pago = 1
union
select p2.titulo, COUNT(r2.id_reserva), 'Menos populares'
from Funciones f2 
	 join Reservas r2 on r2.id_reserva= f2.id_funcion
	 join Peliculas p2 on f2.id_pelicula=p2.id_pelicula
	 join Entradas e2  on e2.id_funcion = f2.id_funcion
	 join Ventas v2 on v2.id_venta = e2.id_venta
	 where datediff(month, v2.fecha,getdate()) between 1 and 3
	 where month(v2.fecha) > MONTH(getdate()) - 4
GROUP BY 
ORDER BY 3 DESC;

--se quiere conocer la forma de pago utilizada por los clientes, en que peliculas, 
--su clasificacion, los datos del cliente y que sus mail empiezen de la f a la l,
--el mes pasado y que se agrupen por esa forma de pago y que el total cobrado 
--sea mayor al promedio cobrado

select descripcion 'Forma de Pago', titulo 'Pelicula', clasificacion, 
	   nombre'Nombre del cliente', contacto 'Mail' 
from Formas_Pago fp join Entradas e on e.id_forma_pago=fp.id_forma_pago
					join funciones f on e.id_funcion=f.id_funcion
					join Peliculas p on p.id_pelicula=f.id_pelicula
					join Ventas v on v.id_venta=e.id_venta
					join Clientes c on v.id_cliente=c.id_cliente
where contacto like '[f-l]%'
group by descripcion, titulo, clasificacion, nombre,contacto
having sum(pre_unitario)>(select avg(pre_unitario)
							from Entradas e1)


--Se crea un procedimiento que sirve para conocer las ventas del cine entre los años que se ingresan por variable.
--En esto se desea conocer  el total obtenido, el vendedor y sus datos y el nombre de la pelicula.
--Las ventas tienen que estar discriminadas por mes y vendedor y este a su vez tiene 
--que haber conseguido mas de $800 en total
create procedure SP_VENTAS_AÑO
@año1 int,
@año2 int
as 
begin
select month(fecha) mes,v.id_vendedor,vp.nombre ,vp.apellido,year(fecha) Año,
sum(pre_unitario)'Total obtenido', titulo
from ventas v join Vendedores vp on v.id_vendedor=vp.id_vendedor
			  join Entradas e on v.id_venta=e.id_venta
			  join Funciones f on e.id_funcion=f.id_funcion
			  join Peliculas p on f.id_pelicula=p.id_pelicula
where year(fecha) between @año1 and @año2
group by month(fecha),v.id_vendedor,vp.nombre,vp.apellido,titulo,year(fecha)
having sum(pre_unitario) > 800
end

/*
Se quiere obtener una lista de funciones en salas de cine, junto con el nombre de los clientes que han adquirido entradas para esas funciones, donde los 
clientes tienen nombres que comienzan con una letra entre 'A' y 'L'. 
Se deben incluir solo las compras realizadas en el primer semestre del año actual mostrando la cantidad de entradas compradas. 
Solo se deben incluir las funciones para las cuales se ha cumplido la condición de que un cliente haya realizado más de 6 compras de entradas
*/

SELECT S.id_sala 'Sala', F.id_funcion 'Funcion', C.nombre 'Cliente', COUNT(E.id_entrada) 'Cantidad entradas'
FROM Funciones F
JOIN Salas S ON F.id_sala = S.id_sala
JOIN Entradas E ON F.id_funcion = E.id_funcion
JOIN Ventas V ON E.id_venta = V.id_venta
JOIN Clientes C ON V.id_cliente = C.id_cliente
WHERE C.nombre LIKE '[A-L]%'
  AND YEAR(V.fecha) = YEAR(GETDATE())
  AND MONTH(V.fecha) BETWEEN 1 AND 6
GROUP BY S.id_sala, F.id_funcion, C.nombre
HAVING COUNT(DISTINCT V.id_venta) > 6;

/*
Se quiere obtener una lista de clientes junto con la fecha de su primera y última venta en las salas 1 y 3, el importe total 
facturado por cliente para los años que oscilan entre 2018 y 2022, asegurandose que el importe promedio facturado por ese cliente 
sea menor que el importe promedio total de todas sus compras. La consulta debe ordenar los resultados por cliente y año de la venta.
*/

SELECT 
    C.id_cliente 'Id Cliente',
    C.nombre 'Cliente',
    MIN(V.fecha) 'Primera Venta',
    MAX(V.fecha) 'Ultima Venta',
    YEAR(V.fecha) 'Año',
    SUM(E.pre_unitario) 'Importe total'
FROM Ventas V
	 JOIN Entradas E ON V.id_venta = E.id_venta
	 JOIN Clientes C ON V.id_cliente = C.id_cliente
	 JOIN Funciones F ON E.id_funcion = F.id_funcion
	 JOIN Salas S ON F.id_sala = S.id_sala
WHERE S.id_sala IN (1, 3)
      AND YEAR(V.fecha) BETWEEN 2018 AND 2023
GROUP BY C.id_cliente, C.nombre, YEAR(V.fecha)
HAVING AVG(E.pre_unitario) < (SELECT AVG(E2.pre_unitario)
							  FROM Entradas E2)
ORDER BY C.nombre,'Año';

/*
Se quiere listar los peliculas junto con el total de dinero recaudado, solo se tendrán en cuenta las peliculas con clasificacion ATP
*/

SELECT titulo Titulo, genero Genero, director Director, idioma Idioma, 
	   duracion Duracion, clasificacion Clasificacion,
	   sum(e.pre_unitario) 'Total $ recaudado',
	   max(v.fecha) 'Ultima venta'
FROM Peliculas p
	 join Funciones f on f.id_pelicula = p.id_pelicula
	 join Entradas e on e.id_funcion = f.id_funcion
	 join Ventas v on v.id_venta = e.id_venta
GROUP BY titulo, genero, director, idioma, duracion, clasificacion



SELECT * FROM Funciones
SELECT * FROM Peliculas



SELECT p.titulo Titulo, SUM(p.id_pelicula), 'Más populares' 'Observación'
FROM Peliculas p join Funciones f on p.id_pelicula = f.id_pelicula
				 join Detalles_Factura d on d.id_detalle = f.id_detalle
				 join Facturas fa on fa.id_factura = d.id_factura
				 join Reservas r on r.id_reserva = d.id_detalle
				 join Formas_Pago fp on fp.id_forma_pago = d.id_forma_pago		
WHERE fp.id_forma_pago = 1
UNION
SELECT p.titulo, SUM(p.id_pelicula), 'Menos populares'
from Peliculas p join Funciones f on p.id_pelicula = f.id_pelicula
				 join Detalles_Factura d on d.id_detalle = f.id_detalle
				 join Facturas fa on fa.id_factura = d.id_factura
WHERE datediff(month,fa.fecha,getdate()) BETWEEN 1 AND 3
GROUP BY p.titulo
ORDER BY 3 DESC;



--En una misma tabla, se quiere saber cuáles son las películas más populares según el número de reservas, 
--de aquellas peliculas que su forma de pago sea en efectivo y por otro lado las peliculas que no tuvieron
--mucho éxito en los ultimos 4 meses, sin contar el mes actual

SELECT titulo Titulo, SUM(p.id_pelicula), 'Más populares' 'Observación'
FROM Peliculas p join Funciones f on p.id_pelicula=f.id_pelicula
				 join Entradas e on e.id_funcion = f.id_funcion
				 join Ventas v on v.id_venta = e.id_venta
				 join Reservas r on r.id_funcion = f.id_funcion
				 join Formas_Pago fp on fp.id_forma_pago = e.id_forma_pago		
WHERE fp.id_forma_pago = 1
UNION ALL
SELECT p2.titulo, SUM(p2.id_pelicula), 'Menos populares'
from Peliculas p2 join Funciones f2 on p2.id_pelicula = f2.id_pelicula
				 join Entradas e2 on e2.id_funcion = f2.id_funcion
				 join Ventas v2 on v2.id_venta = e2.id_venta
WHERE datediff(month, v2.fecha, getdate()) BETWEEN 1 AND 3
GROUP BY 1
ORDER BY 3 DESC;

SELECT * FROM Reservas


SELECT p.titulo Titulo, COUNT(r.id_reserva) Reservas, 'Más populares' 'Observación'
FROM Reservas r join Funciones f on r.id_reserva= f.id_funcion
				join Peliculas p on f.id_pelicula=p.id_pelicula
				join Detalles_Factura d on d.id_detalle= p.id_detalle
				join Formas_Pago fp on fp.id_forma_pago=d.id_forma_pago
where fp.id_forma_pago = 1
union
select p.titulo, COUNT(r.id_reserva), 'Menos populares'
from Funciones f join Reservas r on r.id_reserva= f.id_funcion
				join Peliculas p on f.id_pelicula=p.id_pelicula
				join Detalles_Factura d on d.id_detalle=p.id_detalle
				join Facturas fa on fa.id_factura=d.id_detalle
where datediff(month,fa.fecha,getdate()) between 1 and 3
GROUP BY p.titulo
ORDER BY 3 DESC;

/*
Se quiere listar la informacion de las distintas funciones junto con su recaudacion en efectivo de los últimos 6 meses
*/

SELECT f.id_funcion 'Función Nro', p.titulo 'Película', s.id_sala 'Nro Sala', COUNT(*) 'Cant. Entradas',
	   SUM(e.pre_unitario) 'Total', 'Efectivo' 'Total recaudado en:'
FROM Entradas e 
	 join Ventas v on v.id_venta = e.id_venta
	 join Formas_Pago fp on fp.id_forma_pago = e.id_forma_pago
	 join Funciones f on f.id_funcion = e.id_funcion
	 join Peliculas p on p.id_pelicula = f.id_pelicula
	 join Salas s on s.id_sala = f.id_sala
WHERE descripcion = 'Efectivo'
GROUP BY f.id_funcion, p.titulo, s.id_sala


