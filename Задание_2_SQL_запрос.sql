SELECT nameProduct as Товар, nameCategory as Категория FROM Products
JOIN ProductCard ON Products.idProduct = ProductCard.IdProduct
JOIN Categories ON Categories.idCategory = ProductCard.IdCategory
UNION SELECT nameProduct as Товар, 'Без категории' as Категория FROM Products
JOIN ProductCard ON Products.idProduct = ProductCard.IdProduct
WHERE ProductCard.IdCategory IS NULL