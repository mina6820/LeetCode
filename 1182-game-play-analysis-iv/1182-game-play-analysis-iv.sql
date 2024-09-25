/* Write your T-SQL query statement below */
WITH New AS (
    SELECT player_id, MIN(event_date) AS first_day
    FROM Activity
    GROUP BY player_id
)

SELECT Round(cast(Count(*) as FLOAT) / (select count(Distinct player_id) from activity),2) as fraction
FROM Activity a
JOIN New n ON a.player_id = n.player_id
WHERE DATEDIFF(DAY, n.first_day,a.event_date) = 1;