import React, { useState, useEffect } from 'react';

const TasksList = () => {

    {
    /** 
    Компонент "Task" відображає інформацію про завдання, включаючи його ID, назву, опис, ім'я користувача, та статус виконання.
    * @param {object} props - пропси, що містять інформацію про завдання.
    * @param {number} props.id - унікальний ідентифікатор завдання.
    * @param {string} props.name - назва завдання.
    * @param {string} props.description - опис завдання.
    * @param {string} props.username - ім'я користувача, якому призначено завдання.
    * @param {boolean} props.isCompleted - статус завдання (виконане/не виконане).
    * */
   }
  const [tasks, setTasks] = useState([]);

  useEffect(() => {
    async function fetchTasks() {
      const response = await fetch('/api/tasks');
      const data = await response.json();
      setTasks(data);
    }

    fetchTasks();
  }, []);

  return (
    <div>
      <ul>
        {tasks.map(task => (
            <li key={task.id}>
                <div>
                    <h2>{task.name}</h2>
                    <span>{task.description}</span>
                    <span>{task.username}</span>
                </div>
            </li>
        ))}
      </ul>
    </div>
  );
}

export default OrdersList;
