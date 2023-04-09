import React, { useState, useEffect } from 'react';
import axios from 'axios';
import localStorage from 'local-storage';
import { useNavigate } from 'react-router-dom';
import './loginStyle.css';
import loginIllustration from '../../Images/login-illustration.png';
import Footer from '../../Components/footer/Footer';
import logo from '../../Images/logo_transparent.png';
import Loader from '../../Components/Loader';

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
        <div className='login-container'>
            <header className='login-header'>
                <div className='login-header-content'>
                    <img 
                    src={logo}
                    className='login-logo'/>
                    <h1 className='login-title'>AdReach</h1>
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