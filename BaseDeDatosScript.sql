alter table TIENE
   drop constraint FK_TIENE_TIENE_CONSORCI;

alter table TIENE
   drop constraint FK_TIENE_TIENE2_ABOGADO;

drop table ABOGADO cascade constraints;

drop table CONSORCIO cascade constraints;

drop index TIENE2_FK;

drop index TIENE_FK;

drop table TIENE cascade constraints;

create table ABOGADO 
(
   ABO_ID               INTEGER              not null,
   ABO_NOMBRE           VARCHAR2(30)         not null,
   ABO_APELLIDO         VARCHAR2(30)         not null,
   ABO_TIPOABOGADO      VARCHAR2(30)         not null,
   ABO_NUMCASOSGANADOS  VARCHAR2(30)         not null,
   constraint PK_ABOGADO primary key (ABO_ID)
);

create table CONSORCIO 
(
   CON_NIT              INTEGER              not null,
   CON_NOMBRE           VARCHAR2(30)         not null,
   CON_ANOFUNDACION     INTEGER              not null,
   constraint PK_CONSORCIO primary key (CON_NIT)
);

create table TIENE 
(
   CON_NIT              INTEGER              not null,
   ABO_ID               INTEGER              not null,
   FECHAINICIO          DATE                 not null,
   FECHAFIN             DATE,
   constraint PK_TIENE primary key (CON_NIT, ABO_ID)
);

create index TIENE_FK on TIENE (
   CON_NIT ASC
);

create index TIENE2_FK on TIENE (
   ABO_ID ASC
);

alter table TIENE
   add constraint FK_TIENE_TIENE_CONSORCI foreign key (CON_NIT)
      references CONSORCIO (CON_NIT);

alter table TIENE
   add constraint FK_TIENE_TIENE2_ABOGADO foreign key (ABO_ID)
      references ABOGADO (ABO_ID);
      
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (1003423, 'Pablo', 'Restrepo', 'penalista', 'mas de 20');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (4234352, 'Santiago', 'Agredo', 'penalista', 'mas de 20');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (9876786, 'Alonso', 'Ruiz', 'penalista', '0 a 3');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (4563456, 'Andres', 'Vallejo', 'civil', '4 a 10');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (1234253, 'Jose', 'Jaramillo', 'penalista', 'mas de 20');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (6567546, 'Juan', 'Gomez', 'civil', 'mas de 20');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (3456456, 'Pedro', 'Calle', 'penalista', '11 a 20');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (8876646, 'Carlos', 'Bravo', 'civil', '0 a 3');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (4435645, 'Mario', 'Vega', 'penalista', 'mas de 20');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (7643566, 'Joan', 'Serna', 'civil', '11 a 20');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (5345553, 'Sebastian', 'Ruiz', 'penalista', 'mas de 20');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (4453553, 'Brayan', 'Paz', 'civil', '0 a 3');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (4435533, 'Esteban', 'Serna', 'penalista', 'mas de 20');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (9787899, 'Daniel', 'Mosquera', 'civil', '4 a 10');
INSERT INTO abogado (ABO_ID, ABO_NOMBRE, ABO_APELLIDO, ABO_TIPOABOGADO, ABO_NUMCASOSGANADOS) VALUES (8866777, 'Maria', 'Mera', 'penalista', '11 a 20');

INSERT INTO consorcio (CON_NIT, CON_NOMBRE, CON_ANOFUNDACION) VALUES (123, 'Consorsios SA', 2016);
INSERT INTO consorcio (CON_NIT, CON_NOMBRE, CON_ANOFUNDACION) VALUES (321, 'Consorsio America', 2020);
INSERT INTO consorcio (CON_NIT, CON_NOMBRE, CON_ANOFUNDACION) VALUES (213, 'Consorsio La Paz', 2017);
INSERT INTO consorcio (CON_NIT, CON_NOMBRE, CON_ANOFUNDACION) VALUES (132, 'Consorsio Popayan', 2019);












