import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import { Box } from "@chakra-ui/react";
import UserFormHeader from "../Registration/UserFormHeader";
import { SmallCloseIcon } from "@chakra-ui/icons";
import { MdCheckCircle } from "react-icons/md";
import Loader from "../../Components/Loader/Loader";
import DropZone from "../Registration/DragAndDropFile";
import Footer from "../../Components/footer/Footer";
import ModalSuccessfulRegistration from "../../Components/modal/ModalSuccessfulRegistration";

import {
    Alert,
    AlertIcon,
    InputRightElement,
    Button,
    Flex,
    FormControl,
    FormLabel,
    Heading,
    Input,
    Stack,
    useColorModeValue,
    Avatar,
    AvatarBadge,
    IconButton,
    Center,
    InputGroup,
    List,
    ListItem,
    ListIcon,
    OrderedList,
    UnorderedList,
    useDisclosure,
  } from "@chakra-ui/react";
  
  import {
    Modal,
    ModalOverlay,
    ModalContent,
    ModalHeader,
    ModalFooter,
    ModalBody,
    ModalCloseButton,
  } from "@chakra-ui/react";

const JoinOurTeam = () => {
    const navigate = useNavigate();
  const { isOpen, onOpen, onClose } = useDisclosure();

  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [isAdmin, setIsAdmin] = useState(true);
  const [userName, setUserName] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [successfulRegistration, setSuccessfulRegistration] = useState(false);

  const [loading, setLoading] = useState(false);

  const [showPassword, setShowPassword] = useState(false);
  const [showConfirmPassword, setShowConfirmPassword] = useState(false);

  const handlePasswordClick = () => setShowPassword(!showPassword);
  const handleConfirmPasswordClick = () =>
    setShowConfirmPassword(!showConfirmPassword);

  const handleSubmit = (event) => {
    event.preventDefault();
    <ModalSuccessfulRegistration />;
    console.log({
      firstName,
      lastName,
      email,
      userName,
      password,
      confirmPassword,
    });
  };

  const handleSignUp = (event) => {
    event.preventDefault();

    setLoading(true);

    fetch("https://localhost:50555/api/UserAccount/register", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({
        firstName,
        lastName,
        isAdmin,
        email,
        userName,
        password,
      }),
    })
      .then((response) => {
        if (!response.ok) {
          throw new Error("Registration failed!");
        }
        return response.json();
      })
      .then(() => {
        setSuccessfulRegistration(true);
      })
      .catch((error) => {
        setLoading(false);
        console.error("Registration failed", error);
      });
  };

  return (
    <>
      <UserFormHeader link="/main" />
      <Flex
        minH={"100vh"}
        align={"center"}
        justify={"center"}
        bg={useColorModeValue("gray.50", "gray.800")}
      >
        <Stack
          spacing={4}
          w={"full"}
          maxW={"80vh"}
          bg={useColorModeValue("white", "gray.700")}
          rounded={"xl"}
          boxShadow={"lg"}
          p={12}
          my={12}
        >
          <Heading lineHeight={1.1} fontSize={{ base: "2xl", sm: "3xl" }}>
            Registration Form
          </Heading>

          <FormControl id="userName">
            <FormLabel>User Icon</FormLabel>
            <Stack direction={["column", "row"]} spacing={6}>
              <Center>
                <Avatar size="xl" src="https://bit.ly/sage-adebayo">
                  <AvatarBadge
                    as={IconButton}
                    size="sm"
                    rounded="full"
                    top="-10px"
                    colorScheme="red"
                    aria-label="remove Image"
                    icon={<SmallCloseIcon />}
                  />
                </Avatar>
              </Center>
              <Stack>
                <Center w="full">
                  <Button colorScheme="teal" onClick={onOpen} w="full">
                    Change Icon
                  </Button>
                </Center>
              </Stack>
            </Stack>
          </FormControl>

          <FormControl id="firstName" isRequired>
            <FormLabel>First Name</FormLabel>
            <Input
              placeholder="Input your first name"
              _placeholder={{ color: "gray.500" }}
              type="text"
            />
          </FormControl>

          <FormControl id="middleName">
            <FormLabel>Middle Name</FormLabel>
            <Input
              placeholder="Input your middle name"
              _placeholder={{ color: "gray.500" }}
              type="text"
            />
          </FormControl>

          <FormControl id="lastName" isRequired>
            <FormLabel>Last Name</FormLabel>
            <Input
              placeholder="Input your last name"
              _placeholder={{ color: "gray.500" }}
              type="text"
            />
          </FormControl>

          <FormControl id="userName" isRequired>
            <FormLabel>Username</FormLabel>
            <Input
              placeholder="Input your username"
              _placeholder={{ color: "gray.500" }}
              pattern="[a-zA-Z0-9]+"
              type="text"
            />
            {/* username validation */}
            <Box borderRadius={6} p={5} mt={2} spacing={4}>
              <Alert borderRadius={6}>
                <List spacing={3}>
                  <ListItem>
                    <ListIcon as={MdCheckCircle} color="green.500" />
                    Contains from 3 to 30 symbols
                  </ListItem>
                  <ListItem>
                    <ListIcon as={MdCheckCircle} color="green.500" />
                    Contains letters, underscore
                  </ListItem>
                  <ListItem>
                    <ListIcon as={MdCheckCircle} color="green.500" />
                    Unique username
                  </ListItem>
                </List>
              </Alert>
            </Box>

            {/* username uniqueness validation */}
          </FormControl>
          <FormControl id="email" isRequired>
            <FormLabel>Email Address</FormLabel>
            <Input
              placeholder="your-email@example.com"
              _placeholder={{ color: "gray.500" }}
              type="email"
            />
            <Alert borderRadius={6} mt={2} status="error">
              <AlertIcon />
              Incorrect email
            </Alert>
          </FormControl>
          <FormControl id="password" isRequired>
            <FormLabel>Password</FormLabel>
            <InputGroup size="md">
              <Input
                pr="4.5rem"
                type={showPassword ? "text" : "password"}
                placeholder="Input your password"
                _placeholder={{ color: "gray.500" }}
              />
              <InputRightElement width="4.5rem">
                <Button h="1.75rem" size="sm" onClick={handlePasswordClick}>
                  {showPassword ? "Hide" : "Show"}
                </Button>
              </InputRightElement>
            </InputGroup>
            <Box borderRadius={6} p={5} mt={2} spacing={4}>
              <Alert borderRadius={6}>
                <List spacing={3}>
                  <ListItem>
                    <ListIcon as={MdCheckCircle} color="green.500" />
                    Contains at least 8 symbols
                  </ListItem>
                  <ListItem>
                    <ListIcon as={MdCheckCircle} color="green.500" />
                    Contains at least one number
                  </ListItem>
                  <ListItem>
                    <ListIcon as={MdCheckCircle} color="green.500" />
                    Contains at least one special symbol (!, @, #, *, ^, &, %,
                    $)
                  </ListItem>
                </List>
              </Alert>
            </Box>
          </FormControl>
          <FormControl id="confirmPassword" isRequired>
            <FormLabel>Confirm Password</FormLabel>
            <InputGroup size="md">
              <Input
                pr="4.5rem"
                type={showConfirmPassword ? "text" : "password"}
                placeholder="Confirm your password"
                _placeholder={{ color: "gray.500" }}
              />
              <InputRightElement width="4.5rem">
                <Button
                  h="1.75rem"
                  size="sm"
                  onClick={handleConfirmPasswordClick}
                >
                  {showConfirmPassword ? "Hide" : "Show"}
                </Button>
              </InputRightElement>
            </InputGroup>
            <Alert borderRadius={6} mt={2} status="error">
              <AlertIcon />
              Passwords do not match
            </Alert>
          </FormControl>
          <Stack spacing={6} direction={["column", "row"]}>
            <Button
            onClick={() => {
              setLoading(true);
            }}
              bg={"blue.400"}
              color={"white"}
              w="full"
              _hover={{
                bg: "blue.500",
              }}
            >
              Sign Up
            </Button>
          </Stack>
        </Stack>
      {loading && <Loader/>}
      </Flex>


      <Modal isOpen={isOpen} onClose={onClose}>
        <ModalOverlay />
        <ModalContent>
          <ModalHeader>Modal Title</ModalHeader>
          <ModalCloseButton />
          <ModalBody>
            <DropZone></DropZone>
          </ModalBody>

          <ModalFooter>
            <Button colorScheme="blue" mr={3} onClick={onClose}>
              Close
            </Button>
            <Button variant="ghost">Secondary Action</Button>
          </ModalFooter>
        </ModalContent>
      </Modal>
      <Footer />
    </>
  );
}

export default JoinOurTeam;