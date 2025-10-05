CREATE DATABASE gestion_vehiculos;

/*para indicar con que base de datos vamos a trabajar, usamos: */
USE gestion_vehiculos;

/*---Tabla Tipo_Vehiculo---*/
create table Tipo_Vehiculo(
IdTipo int primary key,
NombreTipo varchar(25) unique not null
);

/*procedimiento almacenado para seleccionar todos los elementos de tipo vehiculo llamandolos atravez de NombreTipo*/
create proc listarTipoVehi
as
select*from Tipo_Vehiculo order by NombreTipo asc 
go

exec listarTipoVehi

/* registrar */
create proc regisTipoVehi(
@IdTipo int, 
@NombreTipo varchar (25)
)as insert into Tipo_Vehiculo values (@IdTipo,@NombreTipo)
go


exec regisTipoVehi 1, "Taxi"

/*actualizar*/
create proc ActReg(
@IdTipo int, 
@NombreTipo varchar (25)
)as update Tipo_Vehiculo set NombreTipo=@NombreTipo where IdTipo=@IdTipo

/*eliminar*/
create proc DeleteTipoVehi(
@IdTipo int
)as delete Tipo_Vehiculo where IdTipo=@IdTipo



/*---Tabla Tipo_Conductor---*/
create table Tipo_Conductor(
IdTipoCon int primary key,
NombreTipoCon varchar (25)
);

/*listar*/
create proc listarTipoCon
as select * from Tipo_Conductor order by IdTipoCon asc
go

/*registrar*/
create proc regisTipoCon(
@IdTipoCon int, 
@NombreTipoCon varchar (25)
)as insert into Tipo_Conductor values (@IdTipoCon,@NombreTipoCon)
go

exec regisTipoCon 1, "Taxista";

/*actualizar*/
create proc ActRegTipoC(
@IdTipoCon int, 
@NombreTipoCon varchar (25)
)as update Tipo_Conductor set NombreTipoCon=@NombreTipoCon where IdTipoCon=@IdTipoCon

/*eliminar*/
create proc DeleteTipoCon(
@IdTipoCon int
)as delete Tipo_Conductor where IdTipoCon=@IdTipoCon

/*---Tabla Vehiculo---*/
create table Vehiculo(
IdVehi int primary key,
Marca varchar(25),
Modelo varchar(25),
Matricula varchar(25),
Annio int,
IdTipo int,
constraint FK_IdTipo foreign key (IdTipo) references Tipo_Vehiculo(IdTipo)
);

/*listar*/
create proc listarVehiculo
as select v.IdVehi , v.Marca, v.Modelo, v.Matricula, v.Annio, t.NombreTipo from Vehiculo v join Tipo_Vehiculo t on v.IdTipo = t.IdTipo order by v.IdVehi asc;
go

/*insertar */
create proc insertVehiculo(
@IdVehi int,
@Marca varchar (25),
@Modelo varchar(25),
@Matricula varchar(25),
@Annio int,
@IdTipo int
) as insert into Vehiculo values (@IdVehi, @Marca, @Modelo, @Matricula, @Annio, @IdTipo)
go

/*actualizar */
create proc actVehiculo(
@IdVehi int, 
@Marca varchar (25),
@Modelo varchar(25),
@Matricula varchar(25),
@Annio int,
@IdTipo int
)as update Vehiculo set Marca=@Marca, Modelo=@Modelo, Matricula=@Matricula, Annio=@Annio, IdTipo=@IdTipo where IdVehi=@IdVehi

/*eliminar*/
create proc deleteVehiculo(
@IdVehi int
)as delete Vehiculo where IdVehi=@IdVehi

/*---Tabla Conductor---*/
create table Conductor(
IdConductor int primary key,
Nombre varchar(255),
IdVehi int,
IdTipoCon int,
constraint FK_IdVehiculo foreign key (IdVehi) references Vehiculo(IdVehi),
constraint FK_IdTipoCon foreign key (IdTipoCon) references Tipo_Conductor(IdTipoCon)
);

/*listar */
create proc listarConductor
as select c.IdConductor, c.Nombre, tc.NombreTipoCon, v.Matricula from Conductor c join Vehiculo v on c.IdVehi = v.IdVehi join Tipo_Conductor tc on c.IdTipoCon = tc.IdTipoCon order by c.IdConductor asc
go

/*insertar */
create proc insertConductor(
@IdConductor int,
@Nombre varchar(255),
@IdVehi int,
@IdTipoCon int
) as insert into Conductor values (@IdConductor, @Nombre, @IdVehi, @IdTipoCon)
go

/*actualizar */
create proc actConductor(
@IdConductor int,
@Nombre varchar(255),
@IdVehi int,
@IdTipoCon int
) as update Conductor set Nombre=@Nombre, IdVehi=@IdVehi, IdTipoCon=@IdTipoCon where IdConductor=@IdConductor

/*eliminar */
create proc deltConductor(
@IdConductor int
) as delete Conductor where IdConductor=@IdConductor
go

/*---Tabla Rutas---*/
create table Ruta(
IdRuta int primary key,
Estacion varchar(25),
IdVehi int,
constraint FK_IdVehi foreign key (IdVehi) references Vehiculo(IdVehi)
);

/*listar*/
create proc listarRuta
as select r.IdRuta, r.Estacion, v.Matricula from Ruta r join Vehiculo v on r.IdVehi = v.IdVehi order by r.IdRuta asc
go

/*insertar*/
create proc insertRuta(
@IdRuta int,
@Estacion varchar(25),
@IdVehi int
) as insert into Ruta values (@IdRuta, @Estacion, @IdVehi)
go

/*actualizar*/
create proc actRuta(
@IdRuta int,
@Estacion varchar(25),
@IdVehi int
) as update Ruta set Estacion=@Estacion, IdVehi=@IdVehi where IdRuta=@IdRuta

/*eliminar*/
create proc deltRuta(
@IdRuta int
) as delete Ruta where IdRuta=@IdRuta


/*---Tabla Contrato---*/
create table Contrato(
IdContrato int primary key,
IdVehi int,
IdConductor int,
constraint FK_IdVehic foreign key (IdVehi) references Vehiculo(IdVehi),
constraint FK_IdConductor foreign key (IdConductor) references Conductor(IdConductor)
)

/*listar*/
create proc listarContrato
as select c.IdContrato, v.Matricula, con.Nombre from Contrato c join Vehiculo v on c.IdVehi = v.IdVehi join Conductor con on c.IdConductor = con.IdConductor order by c.IdContrato asc
go

/*insertar*/
create proc insertContrato(
@IdContrato int,
@IdVehi int,
@IdConductor int
) as insert into Contrato values (@IdContrato, @IdVehi, @IdConductor)
go

/*actualizar*/
create proc actContrato(
@IdContrato int,
@IdVehi int
) as update Contrato set IdVehi=@IdVehi where IdContrato=@IdContrato

/*eliminar*/
alter proc deltContrato(@IdContrato int)
as delete Contrato where IdContrato=@IdContrato
go