import React from "react";
import { Icon } from "react-icons-kit";
import {home} from 'react-icons-kit/fa/home'


const ButtonRedirect = (props) => {
    return (
        <button className={props.class}>
            <img src={props.image} />
            <span>{props.text}</span>
        </button>
    )
}

export default ButtonRedirect;