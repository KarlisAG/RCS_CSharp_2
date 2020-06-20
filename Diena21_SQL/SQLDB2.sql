CREATE TABLE departments(
departmentId INT PRIMARY KEY AUTO_INCREMENT,
departmentName VARCHAR(30) NOT NULL
);

INSERT INTO departments(departmentName)
VALUES ("Engineering"),
	   ("HR"),
       ("Marketing");
       
SELECT * FROM departments;

ALTER TABLE employees
ADD departmentId INT NOT NULL;

ALTER TABLE employees
ADD FOREIGN KEY (departmentId) REFERENCES departments(departmentId);

SELECT * FROM employees;

SELECT employees.employeeName, employees.employeeLastName, departments.departmentName
FROM employees, departments
WHERE employees.departmentId = departments.departmentId;

DROP TABLE departments;


CREATE TABLE jobs(
jobId INT PRIMARY KEY AUTO_INCREMENT,
jobTitle VARCHAR(100) NOT NULL,
minSalary INT NOT NULL,
maxSalary INT NOT NULL
);

SELECT * FROM jobs;

INSERT INTO jobs (jobTitle, minSalary, maxSalary)
VALUES ("Software Engineer", 1000, 4000),
	   ("Marketing specialist,", 800, 3000),
       ("Project manager", 1500, 4500);
       
SELECT minSalary, maxSalary
FROM employees
INNER JOIN jobs
ON jobs.jobId = employees.jobId
WHERE jobs.jobId = 1;

SELECT minSalary, maxSalary
FROM jobs
WHERE jobsId = 1;
       
ALTER TABLE employees
ADD salary INT NOT NULL;

UPDATE employees
SET salary = 2200
WHERE employeeId = 3;

ALTER TABLE employees
ADD jobId INT NOT NULL;

UPDATE employees
SET jobId = 3
WHERE employeeId = 3;

ALTER TABLE employees
ADD FOREIGN KEY (jobId) REFERENCES jobs(jobId);

SELECT employees.employeeName, employees.employeeLastName, jobs.jobTitle, departments.departmentName
FROM employees
INNER JOIN jobs
ON jobs.jobId = employees.jobId
INNER JOIN departments
ON departments.departmentId = employees.employeeId
WHERE departments.departmentId = 1;