import React from "react";
import {
  Box,
  Heading,
  Grid,
  Button,
  Avatar,
  Flex,
  Text,
  useColorModeValue,

} from "@chakra-ui/react";

import { FiMoreHorizontal, FiMessageCircle } from "react-icons/fi";

const User = ({ user, onOpenModal, ...props}) => {
  const blocks = [1, 2, 3, 4, 5, 6, 7, 8, 9];
  let boxBg = useColorModeValue("white !important", "#111c44 !important");
  
  const handleClick = () => {
    onOpenModal(user);
  }

  return (
    <Box
      bg={boxBg}
      width="22em"
      height="100px"
      borderRadius="md"
      p={4}
      display="flex"
      alignItems="center"
      justifyContent="space-between"
    >
      <Flex alignItems="center">
        <Avatar name={props.name} src={props.avatarUrl} size="md" />
        <Box ml={4}>
          <Heading size="md" mb={2}>Username</Heading>
          <Text fontSize="xs">Online</Text>
        </Box>
      </Flex>
      <Button colorScheme="gray" onClick={handleClick}>
        <FiMoreHorizontal />
      </Button>
    </Box>
  );
};

export default User;
