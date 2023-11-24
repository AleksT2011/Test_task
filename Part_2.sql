-- Скрипт создания и заполнения таблиц

CREATE TABLE products(
ID BIGINT NOT NULL,
name VARCHAR(20)
);

CREATE TABLE categories(
ID BIGINT NOT NULL,
name VARCHAR(20)
);

CREATE TABLE products_categories(
ID BIGINT NOT NULL,
ID_products BIGINT NOT NULL,
ID_categories BIGINT NOT NULL
);

INSERT INTO products VALUES
(0,'product_0'),
(1,'product_1'),
(2,'product_2'),
(3,'product_3'),
(4,'product_4');

INSERT INTO categories VALUES
(0,'category_0'),
(1,'category_1'),
(2,'category_2'),
(3,'category_3'),
(4,'category_4');

INSERT INTO products_categories VALUES
(0,0,0),
(1,0,1),
(2,0,4),
(3,2,1),
(4,2,0),
(5,2,4),
(6,3,3),
(7,3,0),
(8,4,2),
(9,4,1),
(10,4,4),
(11,4,3),
(12,4,0);

-- Сам запрос
SELECT products.name, categories.name
FROM products_categories
RIGHT JOIN products
ON products_categories.ID_products = products.ID
LEFT JOIN categories
ON products_categories.ID_categories = categories.ID;