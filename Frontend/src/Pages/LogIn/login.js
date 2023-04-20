import React, { useState, useEffect } from 'react';
import axios from 'axios';
import localStorage from 'local-storage';
import { useNavigate, useHistory } from 'react-router-dom';
import './loginStyle.css';
import loginIllustration from '../../Images/login-illustration.png';
import Footer from '../../Components/footer/Footer';
import logo from '../../Images/logo_transparent.png';
import Loader from '../../Components/Loader';
import './loginStyle.css'

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
        try {
            const response = axios.post('https://localhost:50555/api/User/login', {
                username,
                password
            })
            if (response.status === 200) {
                navigate("/admin");
            }
        } catch (error) {
            console.error(error);
        }
    }

    return (
        <div className='login-container'>
            <header className='login-header'>
                <div className='login-header-content'>
                    <img 
                    src={logo}
                    onClick={() => navigate("/")}
                    className='login-logo'/>
                    <h1 
                    onClick={() => navigate("/")}
                    className='login-title'>AdReach</h1>
                </div>
            </header>
            <div className='login-form-container'>
                <h2 className='login-form-title'>Set your advertisements to the next level</h2>
                <p className='login-form-text'>Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua.</p>
                <img 
                className='login-illustration'
                src={loginIllustration}/>
                <form className='login-form'>
                    <div className='login-textfields'>
                        <input 
                        className='username-textfield login-textfield'
                        placeholder='E-mail or username'/>
                        <input 
                        className='password-textfield login-textfield'
                        type='password'
                        placeholder='Password'/>
                    </div>
                    <button type='submit' 
                    className='login-button login-submit-button'
                    onClick={handleLogin}>Sign In</button>
                </form>
                <button
                className='login-button sign-up-button'
                onClick={() => navigate("/registration")}>Sign Up</button>
                {loading && <Loader/>}
            </div>
            <Footer/>
        </div>
    );
}

export default Login;