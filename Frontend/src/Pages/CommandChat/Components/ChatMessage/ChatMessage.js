import { Box, Flex, Text, Avatar } from "@chakra-ui/react";
import './ChatMessageStyle.css';

export const ChatMessage = () => {
  const date = new Date().getHours() + ':' + new Date().getMinutes() + ':' + new Date().getSeconds().toFixed();
  return (
    <div className="chatMessage">
      Message
    </div>
  );
};
