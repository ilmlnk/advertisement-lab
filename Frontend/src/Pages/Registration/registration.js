import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import PopupError from "../../Components/PopupError/PopupError";
import Footer from "../../Components/footer/Footer";
import ModalSuccessfulRegistration from "../../Components/modal/ModalSuccessfulRegistration";
import logo from "../../Images/logo_transparent.png";
import registrationIllustration from "../../Images/registration_illustration.png";
import Loader from "../../Components/Loader/Loader";

import "./RegistrationStyle.css";

import {
  InputRightElement,
  Button,
  Flex,
  FormControl,
  FormLabel,
  Heading,
  Input,
  Stack,
  useColorModeValue,
  HStack,
  Avatar,
  AvatarBadge,
  IconButton,
  Center,
  InputGroup,
} from "@chakra-ui/react";
import { SmallCloseIcon } from "@chakra-ui/icons";

const Registration = () => {
  const navigate = useNavigate();

  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [isAdmin, setIsAdmin] = useState(true);
  const [userName, setUserName] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");

  const [emailError, setEmailError] = useState("");
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
        navigate("/admin");
      })
      .catch((error) => {
        setLoading(false);
        console.error("Registration failed", error);
      });
  };

  return (
    <div>
      <Flex
        minH={"100vh"}
        align={"center"}
        justify={"center"}
        bg={useColorModeValue("gray.50", "gray.800")}
      >
        <Stack
          spacing={4}
          w={"full"}
          maxW={"70vh"}
          bg={useColorModeValue("white", "gray.700")}
          rounded={"xl"}
          boxShadow={"lg"}
          p={6}
          my={12}
        >
          <Heading lineHeight={1.1} fontSize={{ base: "2xl", sm: "3xl" }}>
            User Profile Edit
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
              <Center w="full">
                <Button w="full">Change Icon</Button>
              </Center>
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
              type="text"
            />
          </FormControl>
          <FormControl id="email" isRequired>
            <FormLabel>Email Address</FormLabel>
            <Input
              placeholder="your-email@example.com"
              _placeholder={{ color: "gray.500" }}
              type="email"
            />
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
          </FormControl>
          <Stack spacing={6} direction={["column", "row"]}>
            <Button
              bg={"red.400"}
              color={"white"}
              w="full"
              _hover={{
                bg: "red.500",
              }}
            >
              Cancel
            </Button>
            <Button
              bg={"blue.400"}
              color={"white"}
              w="full"
              _hover={{
                bg: "blue.500",
              }}
            >
              Submit
            </Button>
          </Stack>
        </Stack>
      </Flex>
      <Footer />
    </div>
  );
};

export default Registration;
