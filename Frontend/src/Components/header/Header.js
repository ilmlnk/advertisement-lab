import React, { useEffect, useState } from "react";

import logo from '../../Images/logo_transparent.png';
import activeUserIcon from '../../Images/Active_user.png';

import './HeaderStyle.css';

const Header = () => {
    return (
        <div className="header-container">
            <header className="header">
                <div className="header-content">
                    <img className="header-logo" src={logo}/>
                    <div>
                        <input placeholder="Search"></input>
                        <button>Search</button>
                    </div>
                </div>
            </header>
        </div>
    );

}

export default Header;