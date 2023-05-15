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
} from "@chakra-ui/react";
import { AiOutlineSend } from "react-icons/ai";

const Chat = () => {
  const [messages, setMessages] = useState([]);
  const [newMessage, setNewMessage] = useState("");

  const handleSendMessage = () => {
    if (newMessage.trim() === "") {
      return;
    }

    const message = {
      id: Date.now(),
      text: newMessage,
      sender: "user",
    };

    setMessages((prevMessages) => [...prevMessages, message]);
    setNewMessage("");
  };

  return (
    <Box p={4} bg="gray.200" height="100vh">
      <Flex direction="column" bg="white" borderRadius="md" height="100%">
        <Box flex="1" overflowY="auto" p={4}>
          <VStack spacing={4} alignItems="flex-start">
            {messages.map((message) => (
              <Flex key={message.id} alignItems="center">
                {message.sender === "user" ? (
                  <Avatar
                    size="sm"
                    name="User"
                    src="https://placekitten.com/32/32"
                  />
                ) : (
                  <Avatar
                    size="sm"
                    name="Bot"
                    src="https://placekitten.com/32/32"
                  />
                )}
                <Text ml={2}>{message.text}</Text>
              </Flex>
            ))}
          </VStack>
        </Box>
        <Divider />
        <Flex p={2}>
          <Input
            flex="1"
            placeholder="Введите сообщение..."
            value={newMessage}
            onChange={(e) => setNewMessage(e.target.value)}
          />
          <IconButton
            ml={2}
            colorScheme="teal"
            aria-label="Send"
            icon={<AiOutlineSend />}
            onClick={handleSendMessage}
          />
        </Flex>
      </Flex>
    </Box>
  );
};

export default Chat;
