SELECT nameProduct as �����, nameCategory as ��������� FROM Products
JOIN ProductCard ON Products.idProduct = ProductCard.IdProduct
JOIN Categories ON Categories.idCategory = ProductCard.IdCategory
UNION SELECT nameProduct as �����, '��� ���������' as ��������� FROM Products
JOIN ProductCard ON Products.idProduct = ProductCard.IdProduct
WHERE ProductCard.IdCategory IS NULL