import React, { useState, useEffect } from 'react';
import axios from 'axios';
import localStorage from 'local-storage';
import { useNavigate } from 'react-router-dom';
import './loginStyle.css'
import logInIllustration from '../../Images/loginIllustration.svg';
import logo from '../../Images/logo2.png';

export const AuthHeader = () => {
    axios.interceptors.request.use(
        config => {
            const apiKey = localStorage.get("api_key");
            if (apiKey) {
                config.headers['Authorization'] = 'Bearer ' + apiKey
            }
            return config
        },
        error => {
            Promise.reject(error);
        }
    )
}

export const getUserId = () => {
    let token = localStorage.get("api_key");
    let base64Url = token.split('.')[1];
    let base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
    let jsonPayload = decodeURIComponent(window.atob(base64).split('').map(function (c) {
        return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
    }).join(''));

    return JSON.parse(jsonPayload)["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"];
}

export const getUserFullName = () => {
    let token = localStorage.get("api_key");
    let base64Url = token.split('.')[1];

}

const Login = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [loading, setLoading] = useState(false);
    const navigate = useNavigate();

    const handleLogin = () => {
        setLoading(true);
        axios.post('/api/User/login', {
            username,
            password
        })
        .then(res => {
            localStorage.set("api_key", res.data);
            setLoading(false);
            navigate("/admin");
        })
    }

    return (
        <body>
        <nav className="headBar">
            <div className="container">
                <a href="#">
                    <img src={logo}/>
                </a>
            </div>
        </nav>
        <div className="content">
            <img src={logInIllustration}/>
            <div className="leftSide">
                <div className="welcomeText">
                    <h1>Set your advertisements to the next level</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit.
                        Minima quis corporis quos distinctio cupiditate ullam hic, excepturi ratione deleniti
                        nam</p><br/>
                </div>
                <div className="loginForms">
                    <input type="text" id="login" placeholder="Login or e-mail"/><br/><br/>
                    <input type="password" id="password" placeholder="Password"/><br/><br/>
                </div>
                <div className="buttons">
                    <a href="#" className="logInButton">Log in</a><br/><br/>
                    <a href="#" className="signUpButton">SignUp</a>
                </div>
            </div>
        </div>
        <div className="footer">
            <div className="footerContent">
                <ul className="menuColumn">
                    <h3>AdReach</h3>
                    <li><a href="#">Terms of Use</a></li>
                    <li><a href="#">Join our Team</a></li>
                </ul>
                <ul className="menuColumn">
                    <h3>Products</h3>
                    <li><a href="#">Telegram channels Catalogue</a></li>
                    <li><a href="#">WhatsApp channels Catalogue</a></li>
                    <li><a href="#">Viber channels Catalogue</a></li>
                    <li><a href="#">Instagram profiles Catalogue</a></li>
                </ul>
                <ul className="menuColumn">
                    <h3>Community</h3>
                    <li><a href="#">Blog</a></li>
                    <li><a href="#">Groups</a></li>
                    <li><a href="#">Our Telegram Channel</a></li>
                    <li><a href="#">Service Reviews</a></li>
                </ul>
                <ul className="menuColumn">
                    <h3>Help</h3>
                    <li><a href="#">FAQ</a></li>
                    <li><a href="#">Support Bot</a></li>
                    <li><a href="#">Report us</a></li>
                </ul>
            </div>
        </div>
    </body>
    );
}

export default Login;