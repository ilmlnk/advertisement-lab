import React, { useContext, useState } from 'react';
import Header from '../../Components/header/Header';
import Navigation from '../../Components/navigation/Navigation';
import OnlineUsersList from '../../Components/OnlineUsersList';
import OnlineUsersModalWindow from '../../Components/modal/OnlineUsersModalWindow';
import Layout from '../Layout/layout';
import CreateOrderModalWindow from '../../Components/modal/CreateOrderModalWindow';
import './adminStyle.css';
import { ModalContext, ModalProvider } from '../../Contexts/ModalContext';
import ModalOpenButton from '../../Components/ModalOpenButton';
import CreateTaskModalWindow from '../../Components/modal/CreateTaskModalWindow';
import {plusSquareO} from 'react-icons-kit/fa/plusSquareO'
import Icon from 'react-icons-kit';
import Footer from '../../Components/footer/Footer';

const Admin = () => {
    const [isOpenUserModal, setIsOpenUserModal] = useState(false);
    // const { openModal } = useContext(ModalContext);

    {/**
    * "User" відображає інформацію про користувача, включаючи його ID, ім'я, прізвище та статус онлайн.
    * @param {object} props - пропси, що містять інформацію про користувача.
    * @param {number} props.id - унікальний ідентифікатор користувача.
    * @param {string} props.name - ім'я користувача.
    * @param {string} props.surname - прізвище користувача.
    * @param {boolean} props.isOnline - статус користувача (онлайн/офлайн).
    * */
    }
    const users = [
        { id: 1, name: 'John', surname: 'Doe', isOnline: true },
        { id: 2, name: 'Jane', surname: 'Smith', isOnline: false },
        { id: 3, name: 'Bob', surname: 'Johnson', isOnline: true },
        { id: 4, name: 'Alice', surname: 'Brown', isOnline: false },
        { id: 5, name: 'Mike', surname: 'Davis', isOnline: true },
        { id: 6, name: 'Sara', surname: 'Wilson', isOnline: true }
      ];

      {/** 
    "Task" відображає інформацію про завдання, включаючи його ID, назву, опис, ім'я користувача, та статус виконання.
    * @param {object} props - пропси, що містять інформацію про завдання.
    * @param {number} props.id - унікальний ідентифікатор завдання.
    * @param {string} props.name - назва завдання.
    * @param {string} props.description - опис завдання.
    * @param {string} props.username - ім'я користувача, якому призначено завдання.
    * @param {boolean} props.isCompleted - статус завдання (виконане/не виконане).
    *   */
    }

      const tasks = [
        { id: 1, name: 'Task 1', description: 'Description 1', username: 'User 1', isCompleted: false },
        { id: 2, name: 'Task 2', description: 'Description 2', username: 'User 2', isCompleted: true },
        { id: 3, name: 'Task 3', description: 'Description 3', username: 'User 3', isCompleted: false },
        { id: 4, name: 'Task 4', description: 'Description 4', username: 'User 4', isCompleted: true },
        { id: 5, name: 'Task 5', description: 'Description 5', username: 'User 5', isCompleted: false },
        { id: 6, name: 'Task 6', description: 'Description 6', username: 'User 6', isCompleted: true }
      ];

      {/** 
     /**
        "Order" відображає інформацію про замовлення, включаючи його ID, назву, опис, ціну, рекламний канал та ім'я користувача.

        @param {object} props - пропси, що містять інформацію про замовлення.
        @param {number} props.id - унікальний ідентифікатор замовлення.
        @param {string} props.name - назва товару.
        @param {string} props.description - опис товару.
        @param {number} props.price - ціна товару.
        @param {string} props.advertisementChannel - рекламний канал, за допомогою якого було здійснене замовлення.
        @param {string} props.username - ім'я користувача, який здійснив замовлення.
    */}

      const orders = [
        { 
          id: 1, 
          name: 'Order 1', 
          description: 'Description 1', 
          price: 10.0, 
          advertisementChannel: 'Facebook', 
          username: 'User 1'
        },
        { 
          id: 2, 
          name: 'Order 2', 
          description: 'Description 2', 
          price: 20.0, 
          advertisementChannel: 'Google Ads', 
          username: 'User 2'
        },
        { 
          id: 3, 
          name: 'Order 3', 
          description: 'Description 3', 
          price: 30.0, 
          advertisementChannel: 'Twitter', 
          username: 'User 3'
        },
        { 
          id: 4, 
          name: 'Order 4', 
          description: 'Description 4', 
          price: 40.0, 
          advertisementChannel: 'LinkedIn Ads', 
          username: 'User 4'
        },
        { 
          id: 5, 
          name: 'Order 5', 
          description: 'Description 5', 
          price: 50.0, 
          advertisementChannel: 'Instagram', 
          username: 'User 5'
        },
        { 
          id: 6, 
          name: 'Order 6', 
          description: 'Description 6', 
          price: 60.0, 
          advertisementChannel: 'Snapchat', 
          username: 'User 6'
        }
      ];



    return (
        <Layout>
            <div className='admin-content'>
                <div className='orders-list-container'>
                <h1 className='orders-title container-title'>Orders</h1>
                <button className='see-all-orders-button see-all-button'>See all &rarr;</button>
                <div className='orders-list-blocks'>
                    <ul className='orders-marked-list'>
                        {orders
                        .map((order) => (
                            <li className='orders-mark' key={order.id}>
                                <div className='order-block'>
                                  <div className='order-block-content'>
                                    <h2 className='order-title order-text'>{order.name}</h2>
                                    <div className='order-characteristics'>
                                      <div className='order-characteristic-block'>
                                        <label className='order-label'>Description</label>
                                        <span className='order-description order-text'>{order.description}</span>
                                      </div>
                                      <div className='order-characteristic-block'>
                                        <label className='order-label'>Price</label>
                                        <span className='order-price order-text'>{order.price}$</span>
                                      </div>
                                      <div className='order-characteristic-block'>
                                        <label className='order-label'>Channel</label>
                                        <span className='order-advertisement-channel order-text'>{order.advertisementChannel}</span>
                                      </div>
                                      <div className='order-characteristic-block'>
                                        <label className='order-label'>User</label>
                                        <span className='order-username order-text'>{order.username}</span>
                                      </div>
                                    </div>
                                    </div>
                                </div>
                            </li>
                        ))}
                        </ul>
                </div>
                </div>

                {/* <OrdersList/> */}

                <button 
                onClick={() => setIsOpenUserModal(true)} 
                className='create-order-button'
                >
                  <Icon 
                  className='create-order-icon' 
                  size={40} 
                  icon={plusSquareO}/>
                  <span className='create-order-span'>Create new order</span>
                </button>
                { isOpenUserModal && <CreateOrderModalWindow/> }

                <div className='recent-activity-container'>
                    <h1 className='container-title recent-activity-title'>Recent Activity</h1>
                    <button className='see-all-button'>See All &rarr;</button>

                    {/*<OnlineUsersList/>*/} {/* show the latest 6 online users */}
                    <div className='online-user-blocks'>
                        <ul className='online-user-list'>
                        {users
                        .map((user) => (
                            <li className='online-user-mark' key={user.id}>
                                <div className='online-user-block'>
                                  <h2 className='online-user-fullname'>{user.name} {user.surname}</h2>
                                  <span className='online-user-status'>{user.isOnline ? "Online" : "Offline"}</span>
                                  <button className='online-user-profile'>Profile</button>
                                  <button className='online-user-chat'>Chat</button>
                                </div>
                            </li>
                        ))}
                        </ul>
                    </div>
                    
                </div>

                <h1 className='container-title'>Tasks</h1>
                <button className='see-all-button'>See All &rarr;</button>

                {/* <TasksList/> */}
                <div>
                    <ul>
                        {tasks
                        .map((task) => (
                            <li key={task.id}>
                                <div>
                                    <h2>{task.name}</h2>
                                    <span>{task.description}</span>
                                    <span>{task.username}</span>
                                    {task.isCompleted ? <span>Completed</span> : <span>Not Completed</span>}
                                </div>
                            </li>
                        ))}
                        </ul>
                </div>

                <button 
                    onClick={() => setIsOpenUserModal(true)} 
                    className='create-task-button'
                    >
                      <span>Create new task</span>
                    </button>
                    { isOpenUserModal && <CreateTaskModalWindow/> }
            </div>
        </Layout>
    );
}

export default Admin;