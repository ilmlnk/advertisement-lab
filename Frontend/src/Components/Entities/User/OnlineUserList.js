import React from "react";
import { Box, Heading, Grid, Center } from "@chakra-ui/react";
import User from "./User";
import { useState } from "react";
import {
  Modal,
  ModalOverlay,
  ModalContent,
  ModalHeader,
  ModalBody,
  ModalFooter,
  Button,
  Text,
  Divider,
} from "@chakra-ui/react";

const OnlineUserList = ({ onlineUsers }) => {
  const [selectedUser, setSelectedUser] = useState(null);

  const handleOpenModal = (user) => {
    setSelectedUser(user);
  };

  const handleCloseModal = () => {
    setSelectedUser(null);
  };

  return (
    <Box p="2em">
      <Box>
        <Heading mb="1em">Online Users</Heading>
        {onlineUsers.length > 0 ? (
          <Grid templateColumns="repeat(3, 1fr)" gap={4}>
            {onlineUsers.slice(0, 9).map((block) => (
              <User
                key={block}
                user={selectedUser}
                onOpenModal={handleOpenModal}
              />
            ))}
          </Grid>
        ) : (
          <Box textAlign="center" mt="2em">
            <Heading>No data</Heading>
          </Box>
        )}

        {onlineUsers.length > 0 ? (
          <Center>
            <Button mt="2em" colorScheme="blue">
              Show all users
            </Button>
          </Center>
        ) : (
          <Center>
            <Button mt="2em" colorScheme="blue">
              Refresh
            </Button>
          </Center>
        )}
      </Box>

      {selectedUser && (
        <Modal isOpen={selectedUser !== null} onClose={handleCloseModal}>
          <ModalOverlay />
          <ModalContent>
            <ModalHeader>Header</ModalHeader>
            <Divider />
            <ModalBody>
              <Box>
                <Heading>Description</Heading>
                <Text>Lorem ipsum.</Text>
              </Box>
              <Divider />
              <Box>
                <Heading>Price</Heading>
                <Text>Price</Text>
              </Box>
              <Divider />
              <Box>
                <Heading>Example</Heading>
                <Text>Location</Text>
              </Box>
            </ModalBody>
            <ModalFooter>
              <Button colorScheme="blue" onClick={handleCloseModal}>
                Close
              </Button>
            </ModalFooter>
          </ModalContent>
        </Modal>
      )}
    </Box>
  );
};

export default OnlineUserList;
