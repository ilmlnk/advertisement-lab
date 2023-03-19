import React from 'react';
import { useNavigate } from 'react-router-dom';
import ButtonRedirect from '../ButtonRedirect';

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
                imageClass="home-img"
                spanClass="control-button-span home-span"
                />

                {/* Button "Analytics" */}
                <ButtonRedirect 
                action={() => navigate("/analytics")}
                class="control-button analytics-button navigation-content" 
                text="Analytics"
                image={analyticsIcon}
                imageClass="analytics-img"
                spanClass="control-button-span analytics-span"
                />

                {/* Button "User Management" */}
                <ButtonRedirect 
                action={() => navigate("/user-management")}
                class="control-button user-management-button navigation-content" 
                text="User Management"
                image={userManagementIcon}
                imageClass="user-management-img"
                spanClass="control-button-span user-management-span"
                />

                {/* Button "Budget Management" */}
                <ButtonRedirect 
                action={() => navigate("/budget-management")}
                class="control-button budget-management-button navigation-content" 
                text="Budget Management"
                image={budgetManagementIcon}
                imageClass="budget-management-img"
                spanClass="control-button-span user-management-span"
                />

                {/* Button "Compliance Management" */}
                <ButtonRedirect 
                action={() => navigate("/compliance-management")}
                class="control-button compliance-management-button navigation-content" 
                text="Compliance Management"
                image={complianceManagementIcon}
                imageClass="compliance-management-img"
                spanClass="control-button-span compliance-management-span"
                />

                {/* Button "Command Chat" */}
                <ButtonRedirect 
                action={() => navigate("/command-chat")}
                class="control-button command-chat-button navigation-content" 
                text="Command Chat"
                image={commandChatIcon}
                imageClass="command-chat-img"
                spanClass="control-button-span command-chat-span"
                />

                {/* Button "Customer Support" */}
                <ButtonRedirect 
                action={() => navigate("/customer-support")}
                class="control-button customer-support-button navigation-content" 
                text="Customer Support"
                image={customerSupportIcon}
                imageClass="customer-support-img"
                spanClass="control-button-span customer-support-span"
                />
            </div>

            <footer className='navigation-footer'>
                <div className='navigation-footer-container'>
                    <div className='navigation-footer-content navigation-content'>
                        <img 
                        className='user-profile-image' 
                        src={currentUserIcon}/>
                        <div className='control-panel'>
                            <span className='control-username'>User</span>
                            <button className='user-button'>Dark Mode</button>
                            <button className='user-button'>Settings</button>
                            <button className='user-button'>Log Out</button>
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