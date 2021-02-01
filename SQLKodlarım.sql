--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select *from Customers where City ='Berlin'--where şart --büyük küçük harf ayırt etmez SQL
Select  *from Products where CategoryID=1  or CategoryID=3
Select  *from Products where CategoryID=1  and UnitPrice>=10

Select *from Products order by UnitPrice desc   --order by sıralama ---asc artan(asendimg) ---desc(descending)

Select *from Products where CategoryID=1 order by UnitPrice desc 

Select count(*) from Products --Ürün adedi
Select COUNT(*) from Products where CategoryID=1

Select categoryId ,count(*) from Products group by CategoryID --hangi kategoride kaç adet ürün var

Select categoryId ,count(*) from Products where UnitPrice >20 --ilk where çalışır (yani birim fiyatı 20 den yüksek  adedi 10 dan küçük olanlar)
 group by CategoryID having count(*)<10


select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName --Birleştirme tablo
from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10

--DTO Data Transformation object

select * from Products p inner join [Order Details] od --ürünü  ve detelisti olanlar
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID= od.OrderID

select * from Customers c left join Orders  o  --Solda olup sağda olmaylarıda getir
on c.CustomerID=o.CustomerID
where o.CustomerID is null



