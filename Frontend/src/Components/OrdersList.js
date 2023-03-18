import React, { useState, useEffect } from 'react';

const OrdersList = () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    async function fetchProducts() {
      const response = await fetch('/api/products');
      const data = await response.json();
      setProducts(data);
    }

    fetchProducts();
  }, []);

  return (
    <div>
      <ul>
        {products.map(product => (
        <div>
            <li key={product.id}>
                {product.name} - {product.price}$
            </li>
          </div>
        ))}
      </ul>
    </div>
  );
}

export default OrdersList;
