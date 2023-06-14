import React from "react";
import axios from "axios";
import { useState, useEffect } from "react";
import { Box, Text } from "@chakra-ui/react";

const UsersFeed = () => {
  const [users, setUsers] = useState([]);

  useEffect(() => {
    const fetchUsers = async () => {
      try {
        const response = await axios.get(
          "https://localhost:50555/SystemUserController/users"
        );
        setUsers(response.data);
      } catch (error) {
        console.error("Error fetching users: ", error);
      }
    };
    fetchUsers();
  }, []);

  return (
    <Box>
      {users.map((user) => (
        <Box key={user.id} bg="gray.200" p={4} mb={4}>
          <Text>Name: {user.name}</Text>
          <Text>Email: {user.email}</Text>
          <Text>Username: {user.username}</Text>
        </Box>
      ))}
    </Box>
  );
};

export default UsersFeed;