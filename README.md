SELECT p.name, c.name  
FROM product p  
LEFT JOIN category c ON p.category_id = c.id
