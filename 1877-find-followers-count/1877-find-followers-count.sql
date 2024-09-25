/* Write your T-SQL query statement below */

select user_id, Count(follower_id)As followers_count
from Followers
Group by user_id
order by user_id Asc