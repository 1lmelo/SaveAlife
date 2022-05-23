CREATE DATABASE SaveDb;

CREATE TABLE covid (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	country VARCHAR(100),
	cases INT,
	confirmed INT,
	deaths INT,
	recovered INT,
	updated_at DATE
);

INSERT INTO covid(country,cases,confirmed,deaths,recovered,updated_at) VALUES
 ('Canada',1299,1328,19,10,'2020-03-21T23:43:02.000Z')
,('Maldives',13,13,0,0,'2020-03-15T18:20:18.000Z')
,('Lithuania',97,99,1,1,'2020-03-22T02:13:18.000Z')
,('Cambodia',52,53,0,1,'2020-03-21T17:43:03.000Z')
,('Ethiopia',9,9,0,0,'2020-03-20T14:13:11.000Z')
,('Argentina',151,158,4,3,'2020-03-21T15:13:44.000Z')
,('Bolivia',19,19,0,0,'2020-03-21T12:43:08.000Z')
,('Cameroon',27,27,0,0,'2020-03-21T12:43:08.000Z')
,('Burkina Faso',56,64,3,5,'2020-03-22T02:13:18.000Z')
,('Bahrain',184,310,1,125,'2020-03-22T02:43:03.000Z')
,('Saudi Arabia',376,392,0,16,'2020-03-21T14:43:03.000Z')
,('Cape Verde',1,1,0,0,'2020-03-21T23:43:02.000Z')
,('Slovenia',382,383,1,0,'2020-03-21T14:43:03.000Z')
,('Guatemala',16,17,1,0,'2020-03-21T21:13:14.000Z')
,('Bosnia and Herzegovina',90,93,1,2,'2020-03-21T17:43:03.000Z')
,('Kuwait',149,176,0,27,'2020-03-21T12:13:19.000Z')
,('Germany',22041,22364,84,239,'2020-03-22T02:13:13.000Z')
,('Spain',21990,25496,1381,2125,'2020-03-22T01:43:02.000Z')
,('Liberia',3,3,0,0,'2020-03-21T12:43:08.000Z')
,('Congo (Kinshasa)',22,23,1,0,'2020-03-21T12:43:08.000Z')
,('Pakistan',725,733,3,5,'2020-03-22T01:43:02.000Z')
,('Oman',40,52,0,12,'2020-03-21T12:43:08.000Z');

SELECT * FROM covid;
