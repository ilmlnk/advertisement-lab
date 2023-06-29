import React, { useState } from "react";
import {
  Box,
  Flex,
  Heading,
  Text,
  Input,
  Textarea,
  Button,
  VStack,
  Divider,
} from "@chakra-ui/react";

const CustomerSupport = () => {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [message, setMessage] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
    setName("");
    setEmail("");
    setMessage("");
  };

  return (
    <Box p={4}>
      <Heading mb={4}>Customer Support</Heading>
      <Box bg="white" p={4} borderRadius="md">
        <form onSubmit={handleSubmit}>
          <VStack spacing={4} alignItems="flex-start">
            <Flex flexDirection="column" width="100%">
              <Text>Name:</Text>
              <Input
                value={name}
                onChange={(e) => setName(e.target.value)}
                placeholder="Enter your name"
              />
            </Flex>
            <Divider width="100%" />
            <Flex flexDirection="column" width="100%">
              <Text>Email:</Text>
              <Input
                value={email}
                onChange={(e) => setEmail(e.target.value)}
                placeholder="Enter your email"
              />
            </Flex>
            <Divider width="100%" />
            <Flex flexDirection="column" width="100%">
              <Text>Message:</Text>
              <Textarea
                value={message}
                onChange={(e) => setMessage(e.target.value)}
                placeholder="Enter your message"
              />
            </Flex>
            <Divider width="100%" />
            <Button type="submit" colorScheme="teal">
              Submit
            </Button>
          </VStack>
        </form>
      </Box>
    </Box>
  );
};

export default CustomerSupport;
