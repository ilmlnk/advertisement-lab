import React, { useEffect, useState } from "react";

import './HeaderStyle.css';
import logo from '../../Images/logo_transparent.png';

const useCurrentCallback = (callback) => {
    const reference = React.useRef();
    reference.current = callback;
    return (...args) => {
      return reference.current?.(...args);
    };
  };

const Header = () => {
    const currentDate = new Date();
    const [time, setTime] = React.useState("");

    const currentCallback = useCurrentCallback(() => {
        const date = new Date();
        setTime(date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds());
    });

    React.useEffect(() => {
        const handle = setInterval(currentCallback, 100);
        return () => clearInterval(handle);
    }, []);

    return (
        <div className="header-container">
            <header className="header">
                <div className="header-content">
                    <img className="header-logo" src={logo}/>
                    <p>Time: { time }</p>
                    <p>Date: { currentDate.getDate() + "/" + (currentDate.getMonth() + 1) + "/" + currentDate.getFullYear() }</p>
                </div>
            </header>
        </div>
    );

}

export default Header;