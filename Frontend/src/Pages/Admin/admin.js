import React from 'react';
import Header from '../../Components/header/Header';
import Navigation from '../../Components/navigation/Navigation';
import Layout from '../Layout/layout';

const Admin = () => {
    return (
        <Layout>
            <Header />
            <Navigation />
            <div>
                <h1>Orders</h1>
                <div>

                </div>

                <button>Create new order</button>

                <h1>News</h1>
                <div>

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