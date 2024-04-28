SELECT product.name, category.name
FROM category
LEFT JOIN product ON category.code = product.code
