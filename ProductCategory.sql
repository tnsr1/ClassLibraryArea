select p.Name [�����], pc.Name [���������]
from [Product] p
	left join [ProductCategory] pc on pc.[ProductID] = p.ProductSubcategoryID
	left join [Category] c on c.CategoryID = pc.CategoryID