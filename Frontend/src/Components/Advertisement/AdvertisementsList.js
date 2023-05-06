import React, { useState, useEffect } from 'react';

const AdvertisementsList = () => {
  const [advertisements, setAdvertisements] = useState([]);

  return (
    <div>
      <ul>
        {advertisements.map((advertisement) => (
            <li key={advertisement.id}>
                <div>
                    <h2>{advertisement.name}</h2>
                    <span>{advertisement.description}</span>
                    <span>{advertisement.price}</span>
                </div>
            </li>
        ))}
      </ul>
    </div>
  );
}

export default AdvertisementsList;
