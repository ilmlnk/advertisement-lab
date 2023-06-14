import React, { useState } from "react";
import "./CreateOrderStyle.css";

const CreateOrderModalWindow = () => {
  const [isOpen, setIsOpen] = useState(false);
  const [selectedItem, setSelectedItem] = useState("");

  const handleToggle = () => {
    setIsOpen(true);
  };

  const handleSelect = (item) => {
    setSelectedItem(item);
    setIsOpen(false);
  };

  return (
    <div className="order-modal-container">
      <div className="order-modal-content">
        <h2>Create New Order</h2>

        <input
          className="name-text-field text-field"
          placeholder="Input name"
        ></input>

        <textarea
          className="description-text-area text-field"
          placeholder="Input description"
        ></textarea>

        <input
          className="price-text-area text-field"
          placeholder="Input price"
        ></input>

        <button onClick={handleToggle}>
          {selectedItem || "Choose channel"}
        </button>

        {isOpen && (
          <ul className="advertisement-channels-list">
            <li className="" onClick={() => handleSelect("Facebook")}>
              Facebook
            </li>

            <li className="" onClick={() => handleSelect("Instagram")}>
              Instagram
            </li>

            <li className="" onClick={() => handleSelect("Telegram")}>
              Telegram
            </li>

            <li className="" onClick={() => handleSelect("WhatsApp")}>
              WhatsApp
            </li>

            <li className="" onClick={() => handleSelect("Viber")}>
              Viber
            </li>
          </ul>
        )}
        <input
          className="text-field"
          placeholder="Input username"
          value="User"
        ></input>

        <button className="modal-close-button">&times;</button>
      </div>
    </div>
  );
};

export default CreateOrderModalWindow;
