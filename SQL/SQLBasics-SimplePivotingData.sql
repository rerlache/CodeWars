/*
https://www.codewars.com/kata/58126aa90ea99769e7000119

For this challenge you need to PIVOT data. You have two tables, products and details. Your task is to pivot the rows in products to produce a table of products which have rows of their detail. Group and Order by the name of the Product.

Tables and relationship below:

You must use the CROSSTAB statement to create a table that has the schema as below:

CROSSTAB table.
* name
* good
* ok
* bad
Compare your table to the expected table to view the expected results.

more info can be found here: https://www.postgresql.org/docs/9.2/static/tablefunc.html
*/

-- solution source: https://medium.com/jen-li-chen-in-data-science/codewars-sql-d0e38dc934cf

CREATE EXTENSION tablefunc;

SELECT *
FROM    crosstab(
    'SELECT p.name, detail, COUNT(d.id)
    FROM products p
    JOIN details d
    ON p.id = d.product_id
    GROUP BY p.name, d.detail
    ORDER BY 1,2'
)
AS ct(name text, bad bigint, good bigint, ok bigint)