import React, { useEffect, useState } from 'react';
import io from 'socket.io-client';

//const socket = io("http://localhost:8080");

const OnlineUsersList = () => {
  const [users, setUsers] = useState([
    { id: 1, name: 'John', isOnline: true },
    { id: 2, name: 'Jane', isOnline: false },
    { id: 3, name: 'Bob', isOnline: true },
    { id: 4, name: 'Alice', isOnline: false },
    { id: 5, name: 'Mike', isOnline: true },
    { id: 6, name: 'Sara', isOnline: true }
  ]);

  /*useEffect(() => {
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
  }, []);*/

  return (
    <div>
      <div>
        <ul>
          {users
          .filter((user) => user.online)
          .slice(0, 6)
          .map((user) => (
              <li key={user.id}>
                <div>
                  <h2>{user.name}</h2>
                  {user.online && <span>Online</span>}
                  <button>Profile</button>
                  <button>Chat</button>
                </div>
              </li>
          ))}
        </ul>
      </div>
    </div>
  );
}

export default OnlineUsersList;