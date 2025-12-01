SELECT *
FROM Employees
WHERE department_id = 50
  AND salary > 4000;

SELECT *
FROM Employees
WHERE department_id IN (20, 30);
