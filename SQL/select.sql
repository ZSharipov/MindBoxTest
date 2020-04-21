SELECT product_name, category_name 
FROM zafar.products p
LEFT JOIN zafar.category c on p.product_category=c.id;