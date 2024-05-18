/* Write your T-SQL query statement below */
-- SELECT COALESCE(e.employee_id, s.employee_id) AS employee_id
-- FROM Employees AS e
-- FULL OUTER JOIN Salaries AS s ON e.employee_id = s.employee_id
-- WHERE e.name IS NULL OR s.salary IS NULL
-- ORDER BY employee_id;


select employee_id from Employees 
where employee_id Not In (select employee_id from Salaries)

union

select employee_id from Salaries
where employee_id Not in (select employee_id from Employees)
order by employee_id