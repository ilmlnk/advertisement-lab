import { Box, Flex, Text, Avatar } from "@chakra-ui/react";

export const ChatBubble = ({ sender, text }) => {
  return (
    <Flex justifyContent={sender === "user" ? "flex-end" : "flex-start"}>
      {sender !== "user" && <Avatar mr={2}/>}
      <Box
        p={3}
        borderRadius="md"
        bg={sender === "user" ? "blue.500" : "gray.200"}
        color={sender === "user" ? "white" : "black"}
        maxWidth="80%"
      >
        <Text>{text}</Text>
      </Box>
      {sender === "user" && <Avatar ml={2} />}
    </Flex>
  );
};
