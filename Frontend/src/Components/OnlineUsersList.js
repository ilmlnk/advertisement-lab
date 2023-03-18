import React, { useEffect, useState } from 'react';
import io from 'socket.io-client';

const socket = io("http://localhost:8080");

const OnlineUsersList = () => {
  const [users, setUsers] = useState([]);

  useEffect(() => {
    socket.on('user connected', (user) => {
      setUsers((prevUsers) => [...prevUsers, user]);
    });

    socket.on('user disconnected', (userId) => {
      setUsers((prevUsers) => prevUsers.filter((user) => user.id !== userId));
    });

    return () => {
      socket.off('user connected');
      socket.off('user disconnected');
    };
  }, []);

  return (
    <div>
      <div>
        <ul>
          {users
          .filter((user) => user.online)
          .slice(0, 6)
          .map((user) => (
            <div>
              <li key={user.id}>
                {user.name} {user.online && <span>Online</span>}
              </li>
            </div>
          ))}
        </ul>
      </div>
    </div>
  );
}

export default OnlineUsersList;