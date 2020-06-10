USE students;

CREATE TABLE student
(
studentName varchar (20) NOT NULL, 
studentSurname varchar(20) NOT NULL,
studentCourse INT NOT NULL
);

DROP TABLE student;

INSERT INTO student (studentName, studentSurname, studentCourse)
VALUES ("Juris", "Berzins", 2),
("Anete", "Cauna", 1),
("Karlis", "Gribulis", 3),
("Marija", "Soldatenko", 1),
("Sanita", "Steinberga", 3),
( "Janis", "Sprogis", 2);


SELECT * FROM student;

SELECT studentName, studentSurname, studentCourse
FROM student
WHERE studentName = "Janis";

SELECT studentName
FROM student
WHERE NOT studentCourse = 3;