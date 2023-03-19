import React, { useEffect, useState } from "react";

import logo from '../../Images/logo_transparent.png';
import activeUserIcon from '../../Images/Active_user.png';
import { Icon } from 'react-icons-kit';
import { search } from 'react-icons-kit/icomoon/search';
import { bell } from 'react-icons-kit/fa/bell'

import './HeaderStyle.css';
import { useNavigate } from "react-router-dom";

const Header = () => {
    const navigate = useNavigate();

    return (
        <div className="header-container">
            <header className="header">
                <div className="header-content">
                    <img 
                    onClick={() => navigate("/admin")} 
                    className="header-logo" src={logo}/>

                    <div className="search-bar">
                        <input 
                        className="search-text-field" 
                        placeholder="Search"></input>
                        <button className="search-button">
                            <Icon size={22} icon={search}/>
                        </button>
                    </div>

                    <button className="notification-button">
                        <Icon
                        size={24}
                        icon={bell}/>
                    </button>
                </div>
            </header>
        </div>
    );

}

export default Header;