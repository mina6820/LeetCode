# Write your MySQL query statement below

select contest_id, round( count(user_id) * 100.0 / (select count(user_id) from users) ,2) As percentage
from register
group by contest_id
order by percentage desc, contest_id;