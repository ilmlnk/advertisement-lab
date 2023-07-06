import React from "react";
import { Box, Icon, Stack, Text, VStack } from "@chakra-ui/react";
import {
  FaHome,
  FaUserFriends,
  FaBell,
  FaCaretDown,
} from "react-icons/fa";

const PublicationSidebar = () => {
  return (
    <Box bg="gray.200" w="64" py="6" px="4" shadow="md">
      <VStack spacing="6" align="start">
        <Stack spacing="1" align="center">
          <Icon as={FaHome} boxSize="6" color="gray.600" />
          <Text fontSize="sm">Home</Text>
        </Stack>
        <Stack spacing="1" align="center">
          <Icon as={FaUserFriends} boxSize="6" color="gray.600" />
          <Text fontSize="sm">Friends</Text>
        </Stack>
        <Stack spacing="1" align="center">
          <Icon boxSize="6" color="gray.600" />
          <Text fontSize="sm">Messenger</Text>
        </Stack>
        <Stack spacing="1" align="center">
          <Icon as={FaBell} boxSize="6" color="gray.600" />
          <Text fontSize="sm">Notifications</Text>
        </Stack>
      </VStack>
      <Box mt="auto" py="4">
        <Stack spacing="1" align="center">
          <Icon as={FaCaretDown} boxSize="4" color="gray.600" />
          <Text fontSize="xs" color="gray.600">
            Account
          </Text>
        </Stack>
      </Box>
    </Box>
  );
};

export default PublicationSidebar;