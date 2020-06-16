create table if not exists transacciones(
	IdTransaccion INT  AUTO_INCREMENT,
    propietario varchar(40) not null,
    Cuenta_retirar varchar(40) not null,
    Banco_retirar varchar(40) not null,
    Mon_retirar int not null,
    GTM int not null,
    Saldo_retiro int not null,
    Cuenta_ingreso varchar(40),
    Banco_ingreso varchar(40),
    Saldo_ingresar int not null,
     PRIMARY KEY (IdTransaccion)
    
)engine=innodb

select * from transacciones

truncate transacciones