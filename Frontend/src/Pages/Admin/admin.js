import React, { useState } from 'react';
import Header from '../../Components/header/Header';
import Navigation from '../../Components/navigation/Navigation';
import OnlineUsersList from '../../Components/OnlineUsersList';
import OnlineUsersModalWindow from '../../Components/OnlineUsersModalWindow';
import Layout from '../Layout/layout';

const Admin = () => {
    const [isOpenUserModal, setIsOpenUserModal] = useState(false);


    return (
        <Layout>
            <Header />
            <Navigation />
            <div className='admin-content'>
                <h1>Orders</h1>
                <div>

                </div>

                <button>Create new order</button>

                <div>
                    <h1>Recent Activity</h1>
                    <span 
                    onClick={() => setIsOpenUserModal(true)}
                    >
                        See all
                    </span>

                    <OnlineUsersList/> {/* show 6 online users */}
                    {isOpenUserModal && <OnlineUsersModalWindow/>}
                </div>

                <h1>Tasks</h1>
                <div>

                </div>

                <button>Create new task</button>
            </div>
        </Layout>
    );
}

export default Admin;