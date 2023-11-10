create database Patron_Inyeccion_Dependencias
use Patron_Inyeccion_Dependencias

create table cliente(
ID int primary key identity (1,1) not null,
Nombre varchar (20),
Primer_Apellido varchar (20),
Segundo_Apellido varchar (20),
)

create table Producto(
ID int primary key identity (1,1) not null,
TipoProducto varchar (30) not null,
Precio money not null,
)


	



create table venta (
ID int primary key identity (1,1) not null,
Costo money,
Precio money,
Ganancia money,
)

