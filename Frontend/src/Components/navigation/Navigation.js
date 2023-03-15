import React from 'react';
import ButtonRedirect from '../ButtonRedirect';
import './NavigationStyle.css';

import home from '../../Images/home.png';


const Navigation = () => {
    return (
    <>
    <div className='navigation-container'>
        <nav className='navigation-bar'>
            <div className='control-buttons'>
                <ButtonRedirect class="control-button " text="Main" image={home}/>
                <ButtonRedirect class="control-button " text="Analytics"/>
                <ButtonRedirect class="control-button " text="User Management"/>
                <ButtonRedirect class="control-button " text="Budget Management"/>
                <ButtonRedirect class="control-button " text="Compliance Management"/>
                <ButtonRedirect class="control-button " text="Command Chat"/>
                <ButtonRedirect class="control-button " text="Customer Support"/>
            </div>
        </nav>
    </div>
    </>
    );
}


export default Navigation;