import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import PopupError from "../../Components/PopupError/PopupError";
import './registrationStyle.css';
import Footer from "../../Components/footer/Footer";
import ModalSuccessfulRegistration from "../../Components/modal/ModalSuccessfulRegistration";
import logo from '../../Images/logo_transparent.png';
import registrationIllustration from '../../Images/registration_illustration.png';
import Loader from "../../Components/Loader";

const Registration = () => {
    const navigate = useNavigate();

    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [email, setEmail] = useState("");
    const [isAdmin, setIsAdmin] = useState(true);
    const [userName, setUserName] = useState("");
    const [password, setPassword] = useState("");
    const [confirmPassword, setConfirmPassword] = useState("");


    const [emailError, setEmailError] = useState("");
    const [loading, setLoading] = useState(false);

    {/* Refreshing state of the form */}

    {/* User Registration Handle */}

    const handleSubmit = (event) => {
        event.preventDefault();
        <ModalSuccessfulRegistration/>
        console.log({ firstName, lastName, email, userName, password, confirmPassword });
      };

    const handleSignUp = (event) => {
        event.preventDefault();

        setLoading(true);

        fetch('https://localhost:50555/api/UserAccount/register', {
            method: 'POST',
            headers: {'Content-Type': 'application/json'},
            body: JSON.stringify({
                firstName,
                lastName,
                isAdmin,
                email,
                userName,
                password
        })
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Registration failed!');
            }
            return response.json();
        })
        .then(() => {
            navigate('/admin');
        })
        .catch(error => {
            setLoading(false);
            console.error('Registration failed', error);
        })
    }

    return (
        <div className="registration-container">
            <header className="registration-header">
                <div className="registration-header-content">
                    <img 
                    onClick={() => navigate("/")}
                    className="registration-header-logo" 
                    src={logo}/>
                    <h1 
                    onClick={() => navigate("/")}
                    className="registration-header-title">AdReach</h1>
                </div>
            </header>

            <div className="registration-content">
                <h1 className="registration-title">Sign Up</h1>
                <img
                className="registration-illustration"
                src={registrationIllustration}/>
                <form 
                className="registration-form"
                onSubmit={handleSubmit}>

                {/* First Name block */}
                <div className="first-name-block user-data-block">
                    {/* Input field First Name */}
                    <input
                    className="first-name-textfield textfield"
                    type="text"
                    id="firstName"
                    name="firstName"
                    value={firstName}
                    placeholder="First Name"
                    onChange={(e) => setFirstName(e.target.value)}
                    />
                </div>

                {/* Last Name block */}
                <div className="last-name-block user-data-block"> 
                    <input
                    className="last-name-textfield textfield"
                    type="text"
                    id="lastName"
                    name="lastName"
                    value={lastName}
                    placeholder="Last Name"
                    onChange={(e) => setLastName(e.target.value)}
                    />
                </div>


                {/* Email block */}
                <div className="email-block user-data-block"> 
                    <input
                    className="email-textfield textfield"
                    type="text"
                    id="email"
                    name="email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                    placeholder="Email"
                    />
                </div>

                {/* Username block */}
                <div className="username-block user-data-block">
                    <input
                    type="text"
                    id="username"
                    name="username"
                    value={userName}
                    className="textfield"
                    onChange={(e) => setUserName(e.target.value)}
                    placeholder="Username"
                    />
                </div>

                {/* Password block */}
                <div className="user-data-block">
                    <input
                    type="password"
                    id="password"
                    name="password"
                    value={password}
                    className="textfield"
                    onChange={(e) => setPassword(e.target.value)}
                    placeholder="Password"
                    />
                </div>

                {/* Confirm Password block */}
                <div className="user-data-block">
                    <input
                    type="password"
                    id="password"
                    name="password"
                    value={confirmPassword}
                    className="textfield"
                    placeholder="Confirm Password"
                    onChange={(e) => setConfirmPassword(e.target.value)}
                    />
                </div>
            <button 
            className="submit-registration-button"
            onClick={handleSignUp} 
            type="submit">Next</button>
            {loading && <Loader/>}
            </form>
            </div>
            <Footer/>
        </div>
    );
}

export default Registration;