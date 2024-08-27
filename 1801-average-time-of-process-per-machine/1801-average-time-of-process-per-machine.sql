/* Write your T-SQL query statement below */

select A1.machine_id, 
ROUND((SUM(a2.timestamp) - SUM(a1.timeStamp))/COUNT(a1.process_id),3) AS processing_time

From Activity A1 Join Activity A2 ON A1.machine_id = A2.machine_id

where A1.activity_type = 'start' AND A2.activity_type = 'end' 
Group by a1.machine_id,a1.activity_type,a2.machine_id,a2.activity_type