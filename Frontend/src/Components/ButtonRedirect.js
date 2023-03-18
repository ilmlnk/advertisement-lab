import React from "react";
import { useNavigate } from "react-router-dom";


const ButtonRedirect = (props) => {
    const navigate = useNavigate();

    return (
        <button onClick={props.action} className={props.class}>
            <img className={props.imageClass} src={props.image} />
            <span className={props.spanClass}>{props.text}</span>
        </button>
    )
}

export default ButtonRedirect;