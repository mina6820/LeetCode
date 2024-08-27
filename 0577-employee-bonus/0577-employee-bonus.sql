/* Write your T-SQL query statement below */

select name,bonus
from Employee left outer join Bonus
on Employee.empId = Bonus.empId
where bonus < 1000 OR bonus IS NULL