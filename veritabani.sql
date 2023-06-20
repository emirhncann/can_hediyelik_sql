CREATE DEFINER=`root`@`localhost` PROCEDURE `can_MusteriEkle`(
id varchar(64),
ad varchar(64),
soy varchar(64),
tel varchar(25),
mail varchar(250),
adr varchar(250)
)
BEGIN
INSERT INTO can_musteriler
VALUES (id, ad, soy, tel, mail, adr);
END