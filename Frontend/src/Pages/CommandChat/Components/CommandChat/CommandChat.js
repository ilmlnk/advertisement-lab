import React, { useState } from "react";
import {
  Box,
  Flex,
  Input,
  IconButton,
  Divider,
  VStack,
  Avatar,
  Text,
  useColorModeValue,
  Heading,
  HStack,
} from "@chakra-ui/react";
import { useRef } from "react";
import { useEffect } from "react";
import { HubConnectionBuilder } from '@microsoft/signalr';
import ChatConversation from "../ChatConversation/ChatConversation";
import ChatSidebar from "../ChatSidebar/ChatSidebar";
import './CommandChatStyle.css';

const CommandChat = () => {
  const [connection, setConnection] = useState(null);
  const [chat, setChat] = useState([]);
  const latestChat = useRef(null);

  latestChat.current = chat;

  useEffect(() => {
    const newConnection = new HubConnectionBuilder()
                              .withUrl('https://localhost:50555/hubs/chat')
                              .withAutomaticReconnect()
                              .build();

    setConnection(newConnection);
  }, []);

  useEffect(() => {
    if (connection) {
      connection.start()
                .then(result => {
                  console.log('Connected!');

                  connection.on('ReceiveMessage', message => {
                    const updatedChat = [...latestChat.current];
                    updatedChat.push(message);

                    setChat(updatedChat);
                  });
                })
                .catch(e => console.log('Connection failed: ', e));
    }
  }, [connection]);

  const sendMessage = async (user, message) => {
    const chatMessage = {
      user: user,
      message: message
    };

    if (connection.connectionStarted) {
      try {
        await connection.send('SendMessage', chatMessage);
      }
      catch (e) {
        console.log(e);
      }
    } else {
      alert('No connection to server yet.');
    }
  };

  return (
    <div className="home">
      <div className='container'>
        <ChatSidebar/>
        <ChatConversation/>
      </div>
    </div>

  );
};

export default CommandChat;
