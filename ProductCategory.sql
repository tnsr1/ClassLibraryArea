select p.Name [Товар], pc.Name [Категория]
from Product p
	left join ProductCategory pc on pc.ProductID = p.ProductID
	left join Category c on c.CategoryID = pc.CategoryID