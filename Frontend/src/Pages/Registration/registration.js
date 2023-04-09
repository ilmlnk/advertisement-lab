import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import PopupError from "../../Components/PopupError";

const Registration = () => {
    const navigate = useNavigate();
    const [email, setEmail] = useState("");
    const [emailError, setEmailError] = useState("");
    const [loading, setLoading] = useState(false);

    {/* Data and credentials from form */}
    const [formData, setFormData] = useState({
        firstName: '',
        lastName: '',
        username: '',
        email: '',
        password: '',
        confirmPassword: ''
    });

    {/* Refreshing state of the form */}
    const onUpdateField = e => {
        const nextFormState = {
            ...form,
            [e.target.name]: e.target.value,
        };
        setFormData(nextFormState);
    }

    {/* User Registration Handle */}
    const handleSignUp = () => {
        if (firstName && lastName && username && email && password && confirmPassword) {
            if (password !== confirmPassword) {
                return (
                    <PopupError/>
                )
            }
            setLoading(true);
            axios.post('/api/User/register', {
                firstName,
                lastName,
                username,
                email,
                password,
            })
            .then(res => {
                setLoading(false);
                localStorage.set('api_key', res.data);
                navigate('/admin');
            })
            .catch((error) => {
                if (error.response.data.message) {
                    console.log(error.response.data.message);
                    return (
                        <PopupError/>
                    );
                }
            })
        } else {

        }
    }

    const handleChange = (event) => {
        const { name, value } = event.target;
        setFormData({ ...formData, [name]: value });
    }

    {/* Email */}

    const handleChangeEmail = (event) => {
        setEmail(event.target.value);
    }

    const validateEmail = (inputEmail) => {
        const re = /\S+@\S+\.\S+/;
        if (!re.test(inputEmail)) {
            return false;
        } else {
            return true;
        }
    }

    return (
        <div>
            <form onSubmit={handleSubmit}>

                {/* First Name block */}
                <div className="">
                    {/* Label First Name */}
                    <label 
                    className="" 
                    htmlFor="firstName">
                        First Name
                    </label>

                    {/* Input field First Name */}
                    <input
                    type="text"
                    id="firstName"
                    name="firstName"
                    value={formData.firstName}
                    onChange={handleChange}
                    />
                </div>

                {/* Last Name block */}
                <div className=""> 
                    <label>Last Name</label>
                    <input
                    type="text"
                    id="lastName"
                    name="lastName"
                    value={formData.lastName}
                    onChange={handleChange}
                    />
                </div>


                {/* Email block */}
                <div className=""> 
                    <label>Email</label>
                    <input
                    type="text"
                    id="email"
                    name="email"
                    value={email}
                    onChange={handleChange}
                    />

                    {validateEmail(email) ? (
                        <p style={{ color: 'green'}}>Valid email</p>
                    ) : (
                        <p style={{ color: 'red'}}>Invalid email</p>
                    )}
                </div>

                {/* Username block */}
                <div className="">
                    <label>Username</label>
                    <input
                    type="text"
                    id="username"
                    name="username"
                    value={username}
                    onChange={handleChange}
                    />
                </div>

                {/* Password block */}
                <div>
                    <label>Password</label>
                    <input
                    type="password"
                    id="password"
                    name="password"
                    value={password}
                    onChange={handleChange}
                    />
                </div>

                {/* Confirm Password block */}
                <div>
                    <label>Confirm Password</label>
                    <input
                    type="password"
                    id="password"
                    name="password"
                    value={password}
                    onChange={handleChange}
                    />
                </div>
            <button onClick={handleSignUp} type="submit">Next</button>
            { loading && <LoadingPopup/> }
            </form>

        </div>
    );
}

export default Registration;