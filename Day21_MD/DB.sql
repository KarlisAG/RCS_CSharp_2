USE university;

CREATE TABLE students
(
studentId INT PRIMARY KEY AUTO_INCREMENT,
studentName varchar (255) NOT NULL,
studentSurname varchar (255) NOT NULL,
studentCourse INT NOT NULL
);

INSERT INTO students (studentName, studentSurname, studentCourse)
VALUES ("Karlis", "Gribulis", 3),
("Marija", "Soldatenko", 1);

INSERT INTO students(studentName, studentSurname, studentCourse)
VALUES ("Janis", "Berzins", 1),
("Janis", "Berzins", 2),
("Janis", "Berzins", 2),
("Sandis", "Berzins", 2),
("Sandis", "Ozolins", 1),
("Janis", "Ozolins", 3),
("Janis", "Berzins", 3);

DROP TABLE students;

SELECT * FROM students;