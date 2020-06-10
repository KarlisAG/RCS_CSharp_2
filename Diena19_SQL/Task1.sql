USE students;

CREATE TABLE student
(
studentID INT NOT NULL AUTO_INCREMENT,
studentName varchar (20) NOT NULL, 
studentSurname varchar(20) NOT NULL,
studentCourse INT NOT NULL,
primary key (studentID)
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

SELECT studentID, studentName, studentSurname, studentCourse
FROM student
WHERE studentName = "Janis";

SELECT studentName, studentID
FROM student
WHERE studentCourse = 1 OR studentCourse = 2;