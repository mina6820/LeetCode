/* Write your T-SQL query statement below */

With new as
(
    select num
    from mynumbers
    group by num
    having count(num) = 1
)
select Max(num) as num
from new