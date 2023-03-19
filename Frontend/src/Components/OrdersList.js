import React, { useState, useEffect } from 'react';

const OrdersList = () => {
  const [products, setProducts] = useState([]);

  /*useEffect(() => {
    async function fetchProducts() {
      const response = await fetch('/api/products');
      const data = await response.json();
      setProducts(data);
    }

    fetchProducts();
  }, []);*/

  return (
    <div>
      <ul>
        {products.map(product => (
            <li key={product.id}>
                <div>
                    <h2>{product.name}</h2>
                    <span>{product.description}</span>
                    <span>{product.price}</span>
                </div>
            </li>
        ))}
      </ul>
    </div>
  );
}

export default OrdersList;
