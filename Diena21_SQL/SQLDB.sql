USE ofice;

CREATE TABLE employees
( 
employeeId INT,
employeeName varchar(20),
employeeLastName varchar(20) 
);

DROP TABLE employees;


ALTER TABLE employees
MODIFY COLUMN employeeId INT PRIMARY KEY AUTO_INCREMENT; 

INSERT INTO employees(employeeName, employeeLastName, departmentID, salary, jobID)
VALUES("Karl", "Markss", 1, 2000, 1),
("Maris", "Pagals", 2, 1500, 2),
("Anete", "Cauna", 3, 2500, 3);

SELECT employeeName, employeeLastName 
FROM employees
WHERE employeeId = 1;

SELECT * FROM employees;