import React from "react";
import './PopupErrorStyle.css';

const PopupError = ({ show, onClose }) => {
    if (!show) {
        return null;
    }

    return (
        <div className="popup-error">
            <div className="popup-error-container">
                <header className="popup-error-header">
                    <h1 className="popup-error-title popup-error-text popup-error-header-element">Error!</h1>
                    <button 
                    onClick={onClose}
                    className="popup-error-close-button popup-error-header-element popup-error-button">⨯</button>
                </header>
                <div className="popup-error-body">
                    <p className="popup-error-description popup-error-text">An issue occurred with user authentication.</p>
                </div>
                <footer className="popup-error-footer">
                    <button 
                    onClick={onClose}
                    className="popup-error-ok-button popup-error-button">Ok</button>
                </footer>
            </div>
        </div>
    );
}

export default PopupError;