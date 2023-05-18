import React from "react";

import {
  Avatar,
  AvatarGroup,
  Box,
  Flex,
  Button,
  Icon,
  Image,
  Text,
  useColorModeValue,
  List,
  ListItem,
  ListIcon,
  Modal,
  ModalOverlay,
  ModalContent,
  ModalHeader,
  ModalCloseButton,
  ModalBody,
  ModalFooter,
} from "@chakra-ui/react";

import { IoEllipsisHorizontalSharp } from "react-icons/io5";
import { MdTimer, MdVideoLibrary } from "react-icons/md";
import { BiCalendar, BiLabel } from "react-icons/bi";

{
  /* 
  Task:
  - Id
  - Name
  - Topic
  - Description
  - Status
  - Priority
  - Due Date
  - Created At
  - Assigned To
  - Tags
  - Comments
*/
}

const Task = ({ task, onOpenModal }, props) => {
  const boxBg = useColorModeValue("white !important", "#111c44 !important");
  const secondaryBg = useColorModeValue("gray.50", "whiteAlpha.100");
  const mainText = useColorModeValue("gray.800", "white");
  const iconBox = useColorModeValue("gray.100", "whiteAlpha.200");
  const iconColor = useColorModeValue("brand.200", "white");

  const handleClick = () => {
    onOpenModal(task);
  };

  return (
    <Flex
      borderRadius="20px"
      bg={boxBg}
      h="345px"
      w={{ base: "315px", md: "345px" }}
      direction="column"
    >
      <Box p="20px">
        <Flex w="100%" mb="10px">
          <Image src="https://i.ibb.co/ZWxRPRq/Venus-Logo.png" me="auto" />
          <Button
            w="38px"
            h="38px"
            align="center"
            justify="center"
            borderRadius="12px"
            me="12px"
            bg={iconBox}
            onClick={handleClick}
            cursor="pointer"
          >
            <Icon
              w="24px"
              h="24px"
              as={IoEllipsisHorizontalSharp}
              color={iconColor}
            />
          </Button>
        </Flex>
        <Box>
          {/* Task Name */}
          <Text fontWeight="600" color={mainText} w="100%" fontSize="2xl">
            Create Dashboard
          </Text>
          {/* Task Type */}
          <Flex alignItems="center">
            <BiLabel size={24} />
            <Text ml={2}>Task Type</Text>
          </Flex>
          {/* Deadline */}
          <Flex alignItems="center" mt={2}>
            <BiCalendar size={24} />
            <Text ml={2}>Up to month</Text>
          </Flex>
          {/* Assigned To */}
          <Box mt={2}>
            <Text>Assigned to</Text>
            <AvatarGroup
              size="sm"
              max={3}
              color={iconColor}
              fontSize="9px"
              fontWeight="700"
            >
              <Avatar src="https://i.ibb.co/CmxNdhQ/avatar1.png" />
              <Avatar src="https://i.ibb.co/cFWc59B/avatar2.png" />
              <Avatar src="https://i.ibb.co/vLQJVFy/avatar3.png" />
              <Avatar src={props.userEntity} />
            </AvatarGroup>
            <Text>{props.userEntity}</Text>
          </Box>
        </Box>
      </Box>
      <Flex
        bg={secondaryBg}
        w="100%"
        p="20px"
        borderBottomLeftRadius="inherit"
        borderBottomRightRadius="inherit"
        height="100%"
        direction="column"
      >
        <List>
          <ListItem>
            <Flex alignItems="start">
              <BiCalendar size={20} />
              <Text
                fontSize="sm"
                color="gray.500"
                lineHeight="24px"
                pe="40px"
                fontWeight="500"
                mb="auto"
                ml={2}
              >
                You have the
              </Text>
            </Flex>
          </ListItem>
        </List>
      </Flex>
    </Flex>
  );
};

export const TaskModal = ({ isOpen, onClose, task }) => {
  return (
    <Modal isOpen={isOpen} onClose={onClose}>
      <ModalOverlay />
      <ModalContent>
        <ModalHeader>{task.name}</ModalHeader>
        <ModalCloseButton />
        <ModalBody>{/* Add content here for the task modal */}</ModalBody>
        <ModalFooter>
          <Button colorScheme="blue" onClick={onClose}>
            Close
          </Button>
        </ModalFooter>
      </ModalContent>
    </Modal>
  );
};

export default Task;
