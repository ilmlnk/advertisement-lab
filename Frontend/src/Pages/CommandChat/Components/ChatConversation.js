import React from "react";
import { Avatar, Flex } from "@chakra-ui/react";
import { ChatBubble } from "./ChatBubble";

const ChatConversation = ({ userState }) => {
  const messages = [
    { id: 1, sender: "user", text: "Hello!" },
    { id: 2, sender: "bot", text: "Hi there!" },
    { id: 3, sender: "user", text: "How are you?" },
    { id: 4, sender: "bot", text: "I'm good, thanks!" },
  ];

  return (
    <Flex direction="column" width="885px">
      {messages.map((message) => (
        <ChatBubble
          key={message.id}
          sender={message.sender}
          text={message.text}
        />
      ))}
    </Flex>
  );
};

export default ChatConversation;
