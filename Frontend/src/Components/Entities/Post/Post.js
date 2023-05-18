import React, { useState } from "react";
import {
  Card,
  CardHeader,
  CardBody,
  CardFooter,
  Avatar,
  Box,
  Flex,
  IconButton,
  Text,
  Heading,
  Image,
  Button,
  Popover,
  PopoverTrigger,
  PopoverContent,
  PopoverArrow,
  PopoverCloseButton,
  PopoverBody,
  HStack,
  Modal,
  ModalOverlay,
  ModalContent,
  ModalHeader,
  ModalCloseButton,
  ModalBody,
  Textarea,
  ModalFooter
} from "@chakra-ui/react";

import { BiLike, BiChat, BiShare } from "react-icons/bi";

const Post = ({ publication }) => {
  const [isCommentModalOpen, setCommentModalOpen] = useState(false);

  const handleCommentButtonClick = () => {
    setCommentModalOpen(true);
  };

  const handleCloseCommentModal = () => {
    setCommentModalOpen(false);
  };

  return (
    <Card maxW="xl" mt="3em">
      <CardHeader>
        <Flex spacing="4">
          <Flex flex="1" gap="4" alignItems="center" flexWrap="wrap">
            <Avatar name="Segun Adebayo" src="https://bit.ly/sage-adebayo" />

            <Box>
              <Heading size="sm">{}</Heading>
              <Text>Creator, Chakra UI</Text>
            </Box>
          </Flex>
          <IconButton
            variant="ghost"
            colorScheme="gray"
            aria-label="See menu"
          />
          {/*
          import { BsThreeDotsVertical } from "react-bootstrap";
          icon={<BsThreeDotsVertical />} 
          */}
        </Flex>
      </CardHeader>
      <CardBody>
        <Text>
          With Chakra UI, I wanted to sync the speed of development with the
          speed of design. I wanted the developer to be just as excited as the
          designer to create a screen.
        </Text>
      </CardBody>
      <Image
        objectFit="cover"
        src="https://images.unsplash.com/photo-1531403009284-440f080d1e12?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1770&q=80"
        alt="Chakra UI"
      />

      <CardFooter
        justify="space-between"
        flexWrap="wrap"
        sx={{
          "& > button": {
            minW: "136px",
          },
        }}
      >
        <Popover>
          <PopoverTrigger>
            <Button flex="1" variant="ghost" leftIcon={<BiLike />}>
              Like
            </Button>
          </PopoverTrigger>
          <PopoverContent p="1em">
            <PopoverArrow />
            <PopoverBody>
              <HStack spacing="1em">
                <Button variant="ghost" leftIcon={<BiLike />} size="sm">
                  Like Option 1
                </Button>
                <Button variant="ghost" leftIcon={<BiLike />} size="sm">
                  Like Option 2
                </Button>
                <Button variant="ghost" leftIcon={<BiLike />} size="sm">
                  Like Option 3
                </Button>
                {/* Add more buttons for different like options */}
              </HStack>
            </PopoverBody>
          </PopoverContent>
        </Popover>
        <Button flex="1" variant="ghost" onClick={handleCommentButtonClick} leftIcon={<BiChat />}>
          Comment
        </Button>
        <Button flex="1" variant="ghost" leftIcon={<BiShare />}>
          Share
        </Button>
      </CardFooter>

      <Modal isOpen={isCommentModalOpen} onClose={handleCloseCommentModal}>
        <ModalOverlay />
        <ModalContent>
          <ModalHeader>Add a Comment</ModalHeader>
          <ModalCloseButton />
          <ModalBody>
            <Textarea placeholder="Write your comment..." />
          </ModalBody>
          <ModalFooter>
            <Button colorScheme="blue" mr={3}>
              Post
            </Button>
            <Button variant="ghost" onClick={handleCloseCommentModal}>
              Cancel
            </Button>
          </ModalFooter>
        </ModalContent>
      </Modal>
    </Card>
  );
};

export default Post;
