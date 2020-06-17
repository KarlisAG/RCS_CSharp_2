USE ofiss;

CREATE TABLE employees
( 
employeeId INT,
employeeName varchar(20),
employeeLastName varchar(20) 
);

DROP TABLE employees;


ALTER TABLE employees
MODIFY COLUMN employeeId INT PRIMARY KEY AUTO_INCREMENT; 


INSERT INTO employees ( employeeName, employeeLastName)
VALUES ("Juris", "Berzins"),
("Anete", "Cauna");

INSERT INTO employees(employeeName, employeeLastName)
VALUES("Karl", "Markss"),
("Maris", "Pagals");

SELECT employeeName, employeeLastName 
FROM employees
WHERE employeeId = 1;

SELECT * FROM employees;