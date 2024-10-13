/* Write your T-SQL query statement below */

With Cnt AS
(
    SELECT COUNT(*) AS ProductCount
    FROM Product
)

select customer_id
from customer
group by customer_id
having count(DISTINCT product_key) = (select ProductCount from Cnt)