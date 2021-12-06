
create table mytable(
	id integer not null primary key,
    lon numeric(18,15) not null,
    lat numeric(18,15) not null,
    ime varchar(100) not null,
    city varchar(100) not null,
    country varchar(100) not null,
    openinghours varchar(100),
    website varchar(100),
    phone varchar(100)
);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(23456, 42.0049430, 21.3924412,'Cineplexx','Skopje','Macedonia','10:00-00:00; Fr-Sa 10:00-01:00','https://www.cineplexx.mk/','+389 2 3074477');
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(35487, 41.9945277, 21.4351265,'Milenmium','Skopje','Macedonia','09:30-01:00','http://kinomilenium.mk','+389 2 3120389');
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(15486,41.99763, 21.43588,'Makedonska Filharmonija','Skopje','Macedonia',null,null,null);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(95453,41.99755, 21.43705,'Makedonska opera i balet','Skopje','Macedonia',null,'http://www.mob.com.mk/',null);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(85406,41.99859, 21.43236,'Makedonski naroden teatar','Skopje','Macedonia',null,null,null);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(45406,41.99799, 21.4395,'Nacionalna univerzitetska biblioteka','Skopje','Macedonia',null,null,null);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(65406,41.99457, 21.43123,'Teatar za deca i mladinci','Skopje','Macedonia',null,null,null);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(25406,41.99338, 21.43208,'Dom na ARM','Skopje','Macedonia',null,null,null);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(68406,41.99083, 21.42918,'Muzej na grad Skopje','Skopje','Macedonia',null,'http://www.mgs.org.mk/','+389 2 3114742');
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(38496,41.99641, 21.44278,'Mladinski kulturen centar','Skopje','Macedonia',null,null,null);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(15409,42.00265, 21.4358,'Muzej na Makedonija','Skopje','Makedonija',null,null,null);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(45406,42.00439, 21.43849,'Turski teatar','Skopje','Macedonia',null,null,null);
insert into mytable(id,lon,lat,ime,city,country,openinghours,website,phone) values(25403,42.00219, 21.40799,'Dramski teatar','Skopje','Macedonia',null,'https://dramskiteatar.com.mk/','+389 2 3063 452');
