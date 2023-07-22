SELECT p.Name, c.Name
FROM dbo.ProductsCategories as pc
RIGHT JOIN dbo.Products as p ON pc.ProductId = p.Id
LEFT JOIN dbo.Categories as c ON pc.CategoryId = c.Id