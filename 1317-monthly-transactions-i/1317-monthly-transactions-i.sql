/* Write your T-SQL query statement below */
SELECT 
    FORMAT(trans_date, 'yyyy-MM') AS month, 
    country, 
    COUNT(id) AS trans_count,
    COUNT(CASE WHEN state = 'approved' THEN id END) AS approved_count, 
    COALESCE(SUM(amount),0) AS trans_total_amount,
    COALESCE(SUM(CASE WHEN state = 'approved' THEN amount END), 0) AS approved_total_amount
FROM 
    transactions
GROUP BY 
    FORMAT(trans_date, 'yyyy-MM'), 
    country;
