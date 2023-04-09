import React from "react";
import './SuccessfulRegistrationStyle.css';


const ModalSuccessfulRegistration = () => {
    return (
        <div className="modal-registration">
            <div className="modal-registration-container">
                <h2 className="modal-registration-title">Successful registration!</h2>
                <span className="modal-registration-text">Now you can enter your account :)</span>
            </div>
        </div>
    );
}

export default ModalSuccessfulRegistration;