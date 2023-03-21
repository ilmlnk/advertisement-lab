import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import ButtonRedirect from '../ButtonRedirect';
import Icon from 'react-icons-kit';
import { NavLink } from 'react-router-dom';

import {cog} from 'react-icons-kit/fa/cog';
import {moon} from 'react-icons-kit/iconic/moon';
import {exit} from 'react-icons-kit/icomoon/exit';

import './NavigationStyle.css';

import homeIcon from '../../Images/home.png';
import analyticsIcon from '../../Images/Chart.png';
import userManagementIcon from '../../Images/User_cicrle_duotone_line.png';
import budgetManagementIcon from '../../Images/Paper.png';
import complianceManagementIcon from '../../Images/Check_ring.png';
import commandChatIcon from '../../Images/Chat_alt_2.png';
import customerSupportIcon from '../../Images/Favorite_fill.png';
import currentUserIcon from '../../Images/Active_user.png';

const Navigation = () => {

    const navigate = useNavigate();
    const [isOnPage, setIsOnPage] = useState(false);

    const handleNavigation = () => {
        setIsOnPage(true);
    }

    return (
    <>
    <div className='navigation-container'>
        <nav className='navigation-bar'>
            <h2 className='navigation-title'>Menu</h2>
            <div className='control-buttons'>
                {/* Button "Home" */}
                    <ButtonRedirect 
                    action={() => navigate("/admin")}
                    class="control-button home-button navigation-content" 
                    text="Main" 
                    image={homeIcon}
                    imageClass="home-img redirect-button-img"
                    spanClass="control-button-span home-span"
                    />

                {/* Button "Analytics" */}
                    <ButtonRedirect 
                    action={() => navigate("/analytics")}
                    class="control-button analytics-button navigation-content" 
                    text="Analytics"
                    image={analyticsIcon}
                    imageClass="analytics-img redirect-button-img"
                    spanClass="control-button-span analytics-span"
                    />

                {/* Button "User Management" */}
                    <ButtonRedirect 
                    action={() => navigate("/user-management")}
                    class="control-button user-management-button navigation-content" 
                    text="User Management"
                    image={userManagementIcon}
                    imageClass="user-management-img redirect-button-img"
                    spanClass="control-button-span user-management-span"
                    />

                {/* Button "Budget Management" */}
                    <ButtonRedirect 
                    action={() => navigate("/budget-management")}
                    class="control-button budget-management-button navigation-content" 
                    text="Budget Management"
                    image={budgetManagementIcon}
                    imageClass="budget-management-img redirect-button-img"
                    spanClass="control-button-span user-management-span"
                    />

                {/* Button "Compliance Management" */}
                    <ButtonRedirect 
                    action={() => navigate("/compliance-management")}
                    class="control-button compliance-management-button navigation-content" 
                    text="Compliance Management"
                    image={complianceManagementIcon}
                    imageClass="compliance-management-img redirect-button-img"
                    spanClass="control-button-span compliance-management-span"
                    />

                {/* Button "Command Chat" */}
                    <ButtonRedirect 
                    action={() => navigate("/command-chat")}
                    class="control-button command-chat-button navigation-content" 
                    text="Command Chat"
                    image={commandChatIcon}
                    imageClass="command-chat-img redirect-button-img"
                    spanClass="control-button-span command-chat-span"
                    />

                {/* Button "Customer Support" */}
                    <ButtonRedirect 
                    action={() => navigate("/customer-support")}
                    class="control-button customer-support-button navigation-content" 
                    text="Customer Support"
                    image={customerSupportIcon}
                    imageClass="customer-support-img redirect-button-img"
                    spanClass="control-button-span customer-support-span"
                    />
            </div>

            <footer className='navigation-footer'>
                <div className='navigation-footer-container'>
                    <div className='navigation-footer-content navigation-content'>
                        <div>
                            <img 
                            className='user-profile-image' 
                            src={currentUserIcon}/>
                            <span className='control-username'>User</span>
                        </div>
                        <div className='control-panel'>
                            <button className='user-button dark-mode-button'>
                                <Icon
                                className='user-button-icon dark-mode-icon' 
                                size={20}
                                icon={moon}/>
                            </button>
                            <button className='user-button settings-button'>
                                <Icon 
                                className='user-button-icon settings-icon' 
                                size={20}
                                icon={cog}/>
                            </button>
                            <button className='user-button exit-button'>
                                <Icon className='user-button-icon exit-icon' 
                                size={20}
                                icon={exit}/>
                            </button>
                        </div>
                    </div>
                </div>
            </footer>
        </nav>
    </div>
    </>
    );
}


export default Navigation;