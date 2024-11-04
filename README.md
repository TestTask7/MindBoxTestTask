# Вопрос №2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Если исходить из постановки задачи, мы имеем всего 2 таблицы. Значит, связь многие ко многим реализована в одной из таблиц. Предположим, что каждая запись в таблице Products содержит неуникальное поле ProductId, а каждая запись в таблице Categories содержит неуникальное поле CategoryId. Также, мы имеем столбец CategoryId в таблице Products, который указывает на соответствующую запись в таблице Categories. Тогда запрос будет выглядеть следующим образом:

```
SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN Categories c 
ON p.CategoryId = c.CategoryId;
```

Но, если выполнить нормализацию данных, мы получим смежную таблицу ProductsCategories, а ProductID и CategoryID будут уникальными ключами для таблиц Products и Categories.
Тогда запрос будет выглядеть следующим образом:

```
SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductsCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
```