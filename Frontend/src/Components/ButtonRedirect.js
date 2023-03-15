import React from "react";
import { Icon } from "react-icons-kit";


const ButtonRedirect = (props) => {
    return (
        <button className={props.class}>
            { /* <Icon icon={props.iconName} /> */ }
            {props.text}
        </button>
    )
}

export default ButtonRedirect;