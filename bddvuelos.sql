/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     08/08/2023 14:51:15                          */
/*==============================================================*/

create database bddvuelos;
go
use bddvuelos;
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_AEROPUERTOS') and o.name = 'FK_TAB_AERO_REFERENCE_TAB_CIUD')
alter table TAB_AEROPUERTOS
   drop constraint FK_TAB_AERO_REFERENCE_TAB_CIUD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_CIUDADES') and o.name = 'FK_TAB_CIUD_REFERENCE_TAB_PAIS')
alter table TAB_CIUDADES
   drop constraint FK_TAB_CIUD_REFERENCE_TAB_PAIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PLAZAS') and o.name = 'FK_TAB_PLAZ_REFERENCE_TAB_TARJ')
alter table TAB_PLAZAS
   drop constraint FK_TAB_PLAZ_REFERENCE_TAB_TARJ
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PLAZAS') and o.name = 'FK_TAB_PLAZ_REFERENCE_TAB_RESE')
alter table TAB_PLAZAS
   drop constraint FK_TAB_PLAZ_REFERENCE_TAB_RESE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_RESERVACIONES') and o.name = 'FK_TAB_RESE_REFERENCE_TAB_CLIE')
alter table TAB_RESERVACIONES
   drop constraint FK_TAB_RESE_REFERENCE_TAB_CLIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_RESERVACIONES') and o.name = 'FK_TAB_RESE_REFERENCE_TAB_VUEL')
alter table TAB_RESERVACIONES
   drop constraint FK_TAB_RESE_REFERENCE_TAB_VUEL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_TARJETAS_EMBARQUE') and o.name = 'FK_TAB_TARJ_REFERENCE_TAB_VUEL')
alter table TAB_TARJETAS_EMBARQUE
   drop constraint FK_TAB_TARJ_REFERENCE_TAB_VUEL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_TARJETAS_EMBARQUE') and o.name = 'FK_TAB_TARJ_REFERENCE_TAB_CLIE')
alter table TAB_TARJETAS_EMBARQUE
   drop constraint FK_TAB_TARJ_REFERENCE_TAB_CLIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_USUARIOS') and o.name = 'FK_TAB_USUA_REFERENCE_TAB_ROLE')
alter table TAB_USUARIOS
   drop constraint FK_TAB_USUA_REFERENCE_TAB_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_VUELOS') and o.name = 'FK_TAB_VUEL_REFERENCE_TAB_AERO1')
alter table TAB_VUELOS
   drop constraint FK_TAB_VUEL_REFERENCE_TAB_AERO1
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_VUELOS') and o.name = 'FK_TAB_VUEL_REFERENCE_TAB_AERO')
alter table TAB_VUELOS
   drop constraint FK_TAB_VUEL_REFERENCE_TAB_AERO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_AEROPUERTOS')
            and   type = 'U')
   drop table TAB_AEROPUERTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_CIUDADES')
            and   type = 'U')
   drop table TAB_CIUDADES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_CLIENTES')
            and   type = 'U')
   drop table TAB_CLIENTES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PAISES')
            and   type = 'U')
   drop table TAB_PAISES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PLAZAS')
            and   type = 'U')
   drop table TAB_PLAZAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_RESERVACIONES')
            and   type = 'U')
   drop table TAB_RESERVACIONES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_ROLES')
            and   type = 'U')
   drop table TAB_ROLES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_TARJETAS_EMBARQUE')
            and   type = 'U')
   drop table TAB_TARJETAS_EMBARQUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_USUARIOS')
            and   type = 'U')
   drop table TAB_USUARIOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_VUELOS')
            and   type = 'U')
   drop table TAB_VUELOS
go

/*==============================================================*/
/* Table: TAB_AEROPUERTOS                                       */
/*==============================================================*/
create table TAB_AEROPUERTOS (
   ID_AEROPUERTO        integer              identity,
   ID_CIUDAD            integer              null,
   CODIGO_AEROPUERTO    varchar(10)          null,
   NOMBRE_AEROPUERTO    varchar(50)          null,
   constraint PK_TAB_AEROPUERTOS primary key (ID_AEROPUERTO)
)
go

/*==============================================================*/
/* Table: TAB_CIUDADES                                          */
/*==============================================================*/
create table TAB_CIUDADES (
   ID_CIUDAD            integer              identity,
   ID_PAIS              integer              null,
   CIUDAD               varchar(50)          null,
   constraint PK_TAB_CIUDADES primary key (ID_CIUDAD)
)
go

/*==============================================================*/
/* Table: TAB_CLIENTES                                          */
/*==============================================================*/
create table TAB_CLIENTES (
   ID_CLIENTE           integer              identity,
   NRO_IDENTIFICACION   varchar(10)          null,
   NOMBRES              varchar(30)          null,
   APELLIDOS            varchar(30)          null,
   DIRECCION            varchar(50)          null,
   TELEFONO             varchar(10)          null,
   NRO_TARJETA          varchar(13)          null,
   constraint PK_TAB_CLIENTES primary key (ID_CLIENTE)
)
go

/*==============================================================*/
/* Table: TAB_PAISES                                            */
/*==============================================================*/
create table TAB_PAISES (
   ID_PAIS              integer              identity,
   PAIS                 varchar(50)          null,
   constraint PK_TAB_PAISES primary key (ID_PAIS)
)
go

/*==============================================================*/
/* Table: TAB_PLAZAS                                            */
/*==============================================================*/
create table TAB_PLAZAS (
   ID_PLAZA             integer              identity,
   ID_RESERVACION       integer              null,
   ID_TARJETA           integer              null,
   NRO_PLANTA           integer              null,
   FILA_ASIENTO         integer              null,
   COLUMNA_ASIENTO      integer              null,
   ASIGNADO_TARJETA     char(2)              null,
   constraint PK_TAB_PLAZAS primary key (ID_PLAZA)
)
go

/*==============================================================*/
/* Table: TAB_RESERVACIONES                                     */
/*==============================================================*/
create table TAB_RESERVACIONES (
   ID_RESERVACION       integer              identity,
   ID_CLIENTE           integer              null,
   ID_VUELO             integer              null,
   FECHA                date                 null,
   SUBTOTAL             numeric(8,2)         null,
   IVA                  numeric(8,2)         null,
   TOTAL                numeric(8,2)         null,
   constraint PK_TAB_RESERVACIONES primary key (ID_RESERVACION)
)
go

/*==============================================================*/
/* Table: TAB_ROLES                                             */
/*==============================================================*/
create table TAB_ROLES (
   ID_ROL               int                  identity,
   ROL                  varchar(30)          null,
   constraint PK_TAB_ROLES primary key (ID_ROL)
)
go

/*==============================================================*/
/* Table: TAB_TARJETAS_EMBARQUE                                 */
/*==============================================================*/
create table TAB_TARJETAS_EMBARQUE (
   ID_TARJETA_EMBARQUE  integer              identity,
   ID_CLIENTE           integer              null,
   ID_VUELO             integer              null,
   constraint PK_TAB_TARJETAS_EMBARQUE primary key (ID_TARJETA_EMBARQUE)
)
go

/*==============================================================*/
/* Table: TAB_USUARIOS                                          */
/*==============================================================*/
create table TAB_USUARIOS (
   ID_USUARIO           int                  identity,
   ID_ROL               int                  null,
   NOMBRE_USUARIO       varchar(30)          null,
   APELLIDO_USUARIO     varchar(30)          null,
   USUARIO              varchar(30)          null,
   CLAVE                varchar(30)          null,
   constraint PK_TAB_USUARIOS primary key (ID_USUARIO)
)
go

/*==============================================================*/
/* Table: TAB_VUELOS                                            */
/*==============================================================*/
create table TAB_VUELOS (
   ID_VUELO             integer              identity,
   ID_AEROPUERTO_LLEGADA integer              null,
   ID_AEROPUERTO_SALIDA integer              null,
   CODIGO_VUELO         varchar(50)          null,
   FECHA_SALIDA         datetime             null,
   FECHA_LLEGADA        datetime             null,
   PRECIO               numeric(8,2)         null,
   constraint PK_TAB_VUELOS primary key (ID_VUELO)
)
go

alter table TAB_AEROPUERTOS
   add constraint FK_TAB_AERO_REFERENCE_TAB_CIUD foreign key (ID_CIUDAD)
      references TAB_CIUDADES (ID_CIUDAD)
go

alter table TAB_CIUDADES
   add constraint FK_TAB_CIUD_REFERENCE_TAB_PAIS foreign key (ID_PAIS)
      references TAB_PAISES (ID_PAIS)
go

alter table TAB_PLAZAS
   add constraint FK_TAB_PLAZ_REFERENCE_TAB_TARJ foreign key (ID_TARJETA)
      references TAB_TARJETAS_EMBARQUE (ID_TARJETA_EMBARQUE)
go

alter table TAB_PLAZAS
   add constraint FK_TAB_PLAZ_REFERENCE_TAB_RESE foreign key (ID_RESERVACION)
      references TAB_RESERVACIONES (ID_RESERVACION)
go

alter table TAB_RESERVACIONES
   add constraint FK_TAB_RESE_REFERENCE_TAB_CLIE foreign key (ID_CLIENTE)
      references TAB_CLIENTES (ID_CLIENTE)
go

alter table TAB_RESERVACIONES
   add constraint FK_TAB_RESE_REFERENCE_TAB_VUEL foreign key (ID_VUELO)
      references TAB_VUELOS (ID_VUELO)
go

alter table TAB_TARJETAS_EMBARQUE
   add constraint FK_TAB_TARJ_REFERENCE_TAB_VUEL foreign key (ID_VUELO)
      references TAB_VUELOS (ID_VUELO)
go

alter table TAB_TARJETAS_EMBARQUE
   add constraint FK_TAB_TARJ_REFERENCE_TAB_CLIE foreign key (ID_CLIENTE)
      references TAB_CLIENTES (ID_CLIENTE)
go

alter table TAB_USUARIOS
   add constraint FK_TAB_USUA_REFERENCE_TAB_ROLE foreign key (ID_ROL)
      references TAB_ROLES (ID_ROL)
go

alter table TAB_VUELOS
   add constraint FK_TAB_VUEL_REFERENCE_TAB_AERO1 foreign key (ID_AEROPUERTO_LLEGADA)
      references TAB_AEROPUERTOS (ID_AEROPUERTO)
go

alter table TAB_VUELOS
   add constraint FK_TAB_VUEL_REFERENCE_TAB_AERO foreign key (ID_AEROPUERTO_SALIDA)
      references TAB_AEROPUERTOS (ID_AEROPUERTO)
go

