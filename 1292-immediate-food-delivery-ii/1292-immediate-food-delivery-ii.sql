/* Write your T-SQL query statement below */
with New as (
    select 
        distinct customer_id, 
        min(order_date) as order_date, 
        min(customer_pref_delivery_date) as customer_pref_delivery_date
    from Delivery
    group by customer_id
)

select
round(sum(iif(order_date=customer_pref_delivery_date, 100.0, 0)) / count(order_date), 2)
as immediate_percentage
from New