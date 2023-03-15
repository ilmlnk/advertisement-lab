import React from 'react';
import ButtonRedirect from '../ButtonRedirect';


const Navigation = () => {
    return (
    <>
    <div className='navigation-container'>
        <nav className='navigation-bar'>
            <div className='control-buttons'>
                <ButtonRedirect class="control-button " text="Main"/>
                <ButtonRedirect class="control-button " text="Analytics"/>
                <ButtonRedirect class="control-button " text="User Management"/>
                <ButtonRedirect class="control-button " text="Budget Management"/>
                <ButtonRedirect class="control-button " text="Compliance Management"/>
            </div>
        </nav>
    </div>
    </>
    );
}


export default Navigation;