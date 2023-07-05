import {
  Box,
  Flex,
  VStack,
  Text,
  ChakraProvider,
  Avatar,
  Button,
  Heading,
  AvatarBadge,
  HStack,
  Input,
} from "@chakra-ui/react";
import "./ChatSidebarStyle.css";
import ChatNavbar from "../ChatNavbar/ChatNavbar";
import ChatSearch from "../ChatSearch/ChatSearch";

const ChatSidebar = () => {
  return (
    <div className="sidebar">
      <ChatNavbar />
      <ChatSearch/>
    </div>
  );
};

export default ChatSidebar;
