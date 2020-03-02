use music
go
CREATE TABLE Album(
 id varchar(4),
 artist varchar(255) not null,
 title varchar(255) not null,
 releasedata DATE,
 Primary key(id)
);
create table Tracks(
    id int identity(1,1),
    title varchar(255),
    lenght time,
    album varchar(4),
    url varchar(30),
    PRIMARY KEY(id),
    foreign key(album) references Album(id)
);