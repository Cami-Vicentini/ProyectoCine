-- Hacer DELETE de los registros que tienen id_butaca mayor a 35
-- delete from butacas where id_butaca > 35

--Agregar campo Numero(varchar)
ALTER TABLE Butacas
add numero varchar(5)

insert into Butacas(id_butaca, estado, id_sala) values(36,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(37,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(38,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(39,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(40,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(41,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(42,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(43,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(44,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(45,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(46,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(47,'Libre', 1)
insert into Butacas(id_butaca, estado, id_sala) values(48,'Libre', 1)



--						SALA 1 

update Butacas set numero =  '1-A' where id_butaca = 1
update Butacas set numero =  '1-B' where id_butaca = 2
update Butacas set numero =  '1-C' where id_butaca = 3
update Butacas set numero =  '1-D' where id_butaca = 4
update Butacas set numero =  '1-E' where id_butaca = 5
update Butacas set numero =  '1-F' where id_butaca = 6
update Butacas set numero =  '1-G' where id_butaca = 7
update Butacas set numero =  '1-H' where id_butaca = 8

update Butacas set numero =  '2-A' where id_butaca = 9
update Butacas set numero =  '2-B' where id_butaca = 10
update Butacas set numero =  '2-C' where id_butaca = 11
update Butacas set numero =  '2-D' where id_butaca = 12
update Butacas set numero =  '2-E' where id_butaca = 13
update Butacas set numero =  '2-F' where id_butaca = 14
update Butacas set numero =  '2-G' where id_butaca = 15
update Butacas set numero =  '2-H' where id_butaca = 16

update Butacas set numero =  '3-A' where id_butaca = 17
update Butacas set numero =  '3-B' where id_butaca = 18
update Butacas set numero =  '3-C' where id_butaca = 19
update Butacas set numero =  '3-D' where id_butaca = 20
update Butacas set numero =  '3-E' where id_butaca = 21
update Butacas set numero =  '3-F' where id_butaca = 22
update Butacas set numero =  '3-G' where id_butaca = 23
update Butacas set numero =  '3-H' where id_butaca = 24

update Butacas set numero =  '4-A' where id_butaca = 25
update Butacas set numero =  '4-B' where id_butaca = 26
update Butacas set numero =  '4-C' where id_butaca = 27
update Butacas set numero =  '4-D' where id_butaca = 28
update Butacas set numero =  '4-E' where id_butaca = 29
update Butacas set numero =  '4-F' where id_butaca = 30
update Butacas set numero =  '4-G' where id_butaca = 31
update Butacas set numero =  '4-H' where id_butaca = 32

update Butacas set numero =  '5-A' where id_butaca = 33
update Butacas set numero =  '5-B' where id_butaca = 34
update Butacas set numero =  '5-C' where id_butaca = 35
update Butacas set numero =  '5-D' where id_butaca = 36
update Butacas set numero =  '5-E' where id_butaca = 37
update Butacas set numero =  '5-F' where id_butaca = 38
update Butacas set numero =  '5-G' where id_butaca = 39
update Butacas set numero =  '5-H' where id_butaca = 40

update Butacas set numero =  '6-A' where id_butaca = 41
update Butacas set numero =  '6-B' where id_butaca = 42
update Butacas set numero =  '6-C' where id_butaca = 43
update Butacas set numero =  '6-D' where id_butaca = 44
update Butacas set numero =  '6-E' where id_butaca = 45
update Butacas set numero =  '6-F' where id_butaca = 46
update Butacas set numero =  '6-G' where id_butaca = 47
update Butacas set numero =  '6-H' where id_butaca = 48

--						SALA 2 

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (49, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (50, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (51, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (52, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (53, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (54, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (55, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (56, 2, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (57, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (58, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (59, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (60, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (61, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (62, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (63, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (64, 2, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (65, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (66, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (67, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (68, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (69, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (70, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (71, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (72, 2, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (73, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (74, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (75, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (76, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (77, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (78, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (79, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (80, 2, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (81, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (82, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (83, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (84, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (85, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (86, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (87, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (88, 2, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (89, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (90, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (91, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (92, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (93, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (94, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (95, 2, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (96, 2, 'Libre')

update Butacas set numero =  '1-A' where id_butaca = 49
update Butacas set numero =  '1-B' where id_butaca = 50
update Butacas set numero =  '1-C' where id_butaca = 51
update Butacas set numero =  '1-D' where id_butaca = 52
update Butacas set numero =  '1-E' where id_butaca = 53
update Butacas set numero =  '1-F' where id_butaca = 54
update Butacas set numero =  '1-G' where id_butaca = 55
update Butacas set numero =  '1-H' where id_butaca = 56

update Butacas set numero =  '2-A' where id_butaca = 57
update Butacas set numero =  '2-B' where id_butaca = 58
update Butacas set numero =  '2-C' where id_butaca = 59
update Butacas set numero =  '2-D' where id_butaca = 60
update Butacas set numero =  '2-E' where id_butaca = 61
update Butacas set numero =  '2-F' where id_butaca = 62
update Butacas set numero =  '2-G' where id_butaca = 63
update Butacas set numero =  '2-H' where id_butaca = 64

update Butacas set numero =  '3-A' where id_butaca = 65
update Butacas set numero =  '3-B' where id_butaca = 66
update Butacas set numero =  '3-C' where id_butaca = 67
update Butacas set numero =  '3-D' where id_butaca = 68
update Butacas set numero =  '3-E' where id_butaca = 69
update Butacas set numero =  '3-F' where id_butaca = 70
update Butacas set numero =  '3-G' where id_butaca = 71
update Butacas set numero =  '3-H' where id_butaca = 72

update Butacas set numero =  '4-A' where id_butaca = 73
update Butacas set numero =  '4-B' where id_butaca = 74
update Butacas set numero =  '4-C' where id_butaca = 75
update Butacas set numero =  '4-D' where id_butaca = 76
update Butacas set numero =  '4-E' where id_butaca = 77
update Butacas set numero =  '4-F' where id_butaca = 78
update Butacas set numero =  '4-G' where id_butaca = 79
update Butacas set numero =  '4-H' where id_butaca = 80

update Butacas set numero =  '5-A' where id_butaca = 81
update Butacas set numero =  '5-B' where id_butaca = 82
update Butacas set numero =  '5-C' where id_butaca = 83
update Butacas set numero =  '5-D' where id_butaca = 84
update Butacas set numero =  '5-E' where id_butaca = 85
update Butacas set numero =  '5-F' where id_butaca = 86
update Butacas set numero =  '5-G' where id_butaca = 87
update Butacas set numero =  '5-H' where id_butaca = 88

update Butacas set numero =  '6-A' where id_butaca = 89
update Butacas set numero =  '6-B' where id_butaca = 90
update Butacas set numero =  '6-C' where id_butaca = 91
update Butacas set numero =  '6-D' where id_butaca = 92
update Butacas set numero =  '6-E' where id_butaca = 93
update Butacas set numero =  '6-F' where id_butaca = 94
update Butacas set numero =  '6-G' where id_butaca = 95
update Butacas set numero =  '6-H' where id_butaca = 96

select * from Butacas

--				SALA 3

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (97, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (98, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (99, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (100, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (101, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (102, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (103, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (104, 3, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (105, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (106, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (107, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (108, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (109, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (110, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (111, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (112, 3, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (113, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (114, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (115, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (116, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (117, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (118, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (119, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (120, 3, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (121, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (122, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (123, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (124, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (125, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (126, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (127, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (128, 3, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (129, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (130, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (131, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (132, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (133, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (134, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (135, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (136, 3, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (137, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (138, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (139, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (140, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (141, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (142, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (143, 3, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (144, 3, 'Libre')

update Butacas set numero =  '1-A' where id_butaca = 97
update Butacas set numero =  '1-B' where id_butaca = 98
update Butacas set numero =  '1-C' where id_butaca = 99
update Butacas set numero =  '1-D' where id_butaca = 100
update Butacas set numero =  '1-E' where id_butaca = 101
update Butacas set numero =  '1-F' where id_butaca = 102
update Butacas set numero =  '1-G' where id_butaca = 103
update Butacas set numero =  '1-H' where id_butaca = 104

update Butacas set numero =  '2-A' where id_butaca = 105
update Butacas set numero =  '2-B' where id_butaca = 106
update Butacas set numero =  '2-C' where id_butaca = 107
update Butacas set numero =  '2-D' where id_butaca = 108
update Butacas set numero =  '2-E' where id_butaca = 109
update Butacas set numero =  '2-F' where id_butaca = 110
update Butacas set numero =  '2-G' where id_butaca = 111
update Butacas set numero =  '2-H' where id_butaca = 112

update Butacas set numero =  '3-A' where id_butaca = 113
update Butacas set numero =  '3-B' where id_butaca = 114
update Butacas set numero =  '3-C' where id_butaca = 115
update Butacas set numero =  '3-D' where id_butaca = 116
update Butacas set numero =  '3-E' where id_butaca = 117
update Butacas set numero =  '3-F' where id_butaca = 118
update Butacas set numero =  '3-G' where id_butaca = 119
update Butacas set numero =  '3-H' where id_butaca = 120

update Butacas set numero =  '4-A' where id_butaca = 121
update Butacas set numero =  '4-B' where id_butaca = 122
update Butacas set numero =  '4-C' where id_butaca = 123
update Butacas set numero =  '4-D' where id_butaca = 124
update Butacas set numero =  '4-E' where id_butaca = 125
update Butacas set numero =  '4-F' where id_butaca = 126
update Butacas set numero =  '4-G' where id_butaca = 127
update Butacas set numero =  '4-H' where id_butaca = 128

update Butacas set numero =  '5-A' where id_butaca = 129
update Butacas set numero =  '5-B' where id_butaca = 130
update Butacas set numero =  '5-C' where id_butaca = 131
update Butacas set numero =  '5-D' where id_butaca = 132
update Butacas set numero =  '5-E' where id_butaca = 133
update Butacas set numero =  '5-F' where id_butaca = 134
update Butacas set numero =  '5-G' where id_butaca = 135
update Butacas set numero =  '5-H' where id_butaca = 136

update Butacas set numero =  '6-A' where id_butaca = 137
update Butacas set numero =  '6-B' where id_butaca = 138
update Butacas set numero =  '6-C' where id_butaca = 139
update Butacas set numero =  '6-D' where id_butaca = 140
update Butacas set numero =  '6-E' where id_butaca = 141
update Butacas set numero =  '6-F' where id_butaca = 142
update Butacas set numero =  '6-G' where id_butaca = 143
update Butacas set numero =  '6-H' where id_butaca = 144

--				SALA 4

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (145, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (146, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (147, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (148, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (149, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (150, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (151, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (152, 4, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (153, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (154, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (155, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (156, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (157, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (158, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (159, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (160, 4, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (161, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (162, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (163, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (164, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (165, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (166, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (167, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (168, 4, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (169, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (170, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (171, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (172, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (173, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (174, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (175, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (176, 4, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (177, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (178, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (179, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (180, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (181, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (182, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (183, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (184, 4, 'Libre')

INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (185, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (186, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (187, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (188, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (189, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (190, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (191, 4, 'Libre')
INSERT INTO Butacas(id_butaca, id_sala, estado)
VALUES (192, 4, 'Libre')

update Butacas set numero =  '1-A' where id_butaca = 145
update Butacas set numero =  '1-B' where id_butaca = 146
update Butacas set numero =  '1-C' where id_butaca = 147
update Butacas set numero =  '1-D' where id_butaca = 148
update Butacas set numero =  '1-E' where id_butaca = 149
update Butacas set numero =  '1-F' where id_butaca = 150
update Butacas set numero =  '1-G' where id_butaca = 151
update Butacas set numero =  '1-H' where id_butaca = 152

update Butacas set numero =  '2-A' where id_butaca = 153
update Butacas set numero =  '2-B' where id_butaca = 154
update Butacas set numero =  '2-C' where id_butaca = 155
update Butacas set numero =  '2-D' where id_butaca = 156
update Butacas set numero =  '2-E' where id_butaca = 157
update Butacas set numero =  '2-F' where id_butaca = 158
update Butacas set numero =  '2-G' where id_butaca = 159
update Butacas set numero =  '2-H' where id_butaca = 160

update Butacas set numero =  '3-A' where id_butaca = 161
update Butacas set numero =  '3-B' where id_butaca = 162
update Butacas set numero =  '3-C' where id_butaca = 163
update Butacas set numero =  '3-D' where id_butaca = 164
update Butacas set numero =  '3-E' where id_butaca = 165
update Butacas set numero =  '3-F' where id_butaca = 166
update Butacas set numero =  '3-G' where id_butaca = 167
update Butacas set numero =  '3-H' where id_butaca = 168

update Butacas set numero =  '4-A' where id_butaca = 169
update Butacas set numero =  '4-B' where id_butaca = 170
update Butacas set numero =  '4-C' where id_butaca = 171
update Butacas set numero =  '4-D' where id_butaca = 172
update Butacas set numero =  '4-E' where id_butaca = 173
update Butacas set numero =  '4-F' where id_butaca = 174
update Butacas set numero =  '4-G' where id_butaca = 175
update Butacas set numero =  '4-H' where id_butaca = 176

update Butacas set numero =  '5-A' where id_butaca = 177
update Butacas set numero =  '5-B' where id_butaca = 178
update Butacas set numero =  '5-C' where id_butaca = 179
update Butacas set numero =  '5-D' where id_butaca = 180
update Butacas set numero =  '5-E' where id_butaca = 181
update Butacas set numero =  '5-F' where id_butaca = 182
update Butacas set numero =  '5-G' where id_butaca = 183
update Butacas set numero =  '5-H' where id_butaca = 184

update Butacas set numero =  '6-A' where id_butaca = 185
update Butacas set numero =  '6-B' where id_butaca = 186
update Butacas set numero =  '6-C' where id_butaca = 187
update Butacas set numero =  '6-D' where id_butaca = 188
update Butacas set numero =  '6-E' where id_butaca = 189
update Butacas set numero =  '6-F' where id_butaca = 190
update Butacas set numero =  '6-G' where id_butaca = 191
update Butacas set numero =  '6-H' where id_butaca = 192

