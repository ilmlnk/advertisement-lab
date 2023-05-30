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
import { AiOutlineSend } from "react-icons/ai";
import { ChatSidebar } from "./ChatSidebar";
import { ChatBubble } from "./ChatBubble";
import ChatConversation from "./ChatConversation";

const CommandChat = () => {
  const users = ["User 1", "User 2", "User 3", "User 4", "User 5"];

  const [newMessage, setNewMessage] = useState("");
  const boxBg = useColorModeValue("white !important", "#111c44 !important");
  const flexBg = useColorModeValue("white !important", "#0e1736 !important");

  return (
    <Box bg={boxBg} height="100vh" mb="2em">
      <Flex direction="column" bg={flexBg} borderRadius="md" height="100%">
        <HStack>
          <ChatSidebar />
          <ChatConversation />
        </HStack>
      </Flex>
    </Box>
  );
};

export default CommandChat;
