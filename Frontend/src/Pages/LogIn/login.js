import React, { useState, useEffect } from 'react';
import axios from 'axios';
import localStorage from 'local-storage';
import { useNavigate } from 'react-router-dom';

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
        axios.post('https://localhost:8080/api/user/login', {
            username,
            password
        })
        .then(res => {
            localStorage.set("api_key", res.data);
            setLoading(false);
            navigate("/admin");
        })
    }
}