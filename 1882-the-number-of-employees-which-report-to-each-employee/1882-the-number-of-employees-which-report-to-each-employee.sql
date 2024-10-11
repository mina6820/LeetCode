/* Write your T-SQL query statement below */

select E1.employee_id, E1.name,Count(E2.reports_to) As reports_count,round(avg(e2.age*1.00),0) As average_age
from Employees As E1 Inner Join Employees As E2 ON E1.employee_id = E2.reports_to
Group by E1.employee_id, E1.name
order by e1.employee_id