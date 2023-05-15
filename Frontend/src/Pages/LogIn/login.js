import React, { useState } from "react";
import axios from "axios";
import localStorage from "local-storage";
import { useNavigate } from "react-router-dom";
import loginIllustration from "../../Images/login-illustration.png";
import Footer from "../../Components/footer/Footer";
import logo from "../../Images/logo_transparent.png";
import Loader from "../../Components/Loader/Loader";
import { Fade } from "@chakra-ui/react";
import PopupError from "../../Components/PopupError/PopupError";

import {
  Box,
  Button,
  Checkbox,
  Container,
  Divider,
  FormControl,
  FormLabel,
  Heading,
  HStack,
  Input,
  Stack,
  Text,
} from "@chakra-ui/react";

import { OAuthButtonGroup } from "./Group/OAuthButtonGroup";
import { PasswordField } from "./Group/PasswordField";
import { Logo } from "./Group/Logo";

import UserFormHeader from "../Registration/UserFormHeader";
import { FailedAuthentication } from "./Group/FailedAuthentication";

const Login = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [loading, setLoading] = useState(false);

  const [loginError, setLoginError] = useState(false);

  {
    /* Google authentication */
  }
  const [loggedIn, setLoggedIn] = useState(false);
  const [userData, setUserData] = useState({});

  const navigate = useNavigate();

  const handleSubmit = () => {
    setLoading(true);

    const data = {
      username: username,
      password: password,
    };

    axios
      .post("https://localhost:50555/api/UserAccount/login", data)
      .then((response) => {
        console.log(response.data);
        setLoading(false);
        const navigationLink = '/admin/' + response.data.id
        navigate(navigationLink);
      })
      .catch((error) => {
        setLoginError(true);
        console.error(error);
        setLoading(false);
      });
  };

  return (
    <>
      <UserFormHeader link="/main" />
      <Container
        maxW="lg"
        py={{
          base: "12",
          md: "24",
        }}
        px={{
          base: "0",
          sm: "8",
        }}
      >
        {loginError && <FailedAuthentication />}
        <Stack spacing="8">
          <Stack spacing="6">
            <Logo />
            <Stack
              spacing={{
                base: "2",
                md: "3",
              }}
              textAlign="center"
            >
              <Heading
                size={{
                  base: "xs",
                  md: "sm",
                }}
              >
                Log in to your account
              </Heading>
              <HStack spacing="1" justify="center">
                <Text color="muted">Don't have an account?</Text>
                <Button
                  onClick={() => navigate("/registration")}
                  variant="link"
                  colorScheme="blue"
                >
                  Sign Up
                </Button>
              </HStack>
            </Stack>
          </Stack>
          <Box
            py={{
              base: "0",
              sm: "8",
            }}
            px={{
              base: "4",
              sm: "10",
            }}
            bg={{
              base: "transparent",
              sm: "bg-surface",
            }}
            boxShadow={{
              base: "none",
              sm: "md",
            }}
            borderRadius={{
              base: "none",
              sm: "xl",
            }}
          >
            <Stack spacing="6">
              <Stack spacing="5">
                <FormControl onSubmit={handleSubmit}>
                  <FormLabel htmlFor="username">Username</FormLabel>
                  <Input
                    id="username"
                    value={username}
                    onChange={(event) => setUsername(event.target.value)}
                    type="username"
                  />
                </FormControl>
                <PasswordField
                  id="password"
                  value={password}
                  onChange={(event) => setPassword(event.target.value)}
                  type="password"
                />
              </Stack>
              <HStack justify="space-between">
                <Checkbox defaultChecked>Remember me</Checkbox>
                <Button
                  onClick={() => navigate("/forgot")}
                  variant="link"
                  colorScheme="blue"
                  size="sm"
                >
                  Forgot password?
                </Button>
              </HStack>
              <Stack spacing="6">
                <Button
                  onClick={() => handleSubmit()}
                  type="submit"
                  bg={"blue.400"}
                  color={"white"}
                  w="full"
                  _hover={{
                    bg: "blue.500",
                  }}
                >
                  Sign In
                </Button>
                <HStack>
                  <Divider />
                  <Text fontSize="sm" whiteSpace="nowrap" color="muted">
                    or continue with
                  </Text>
                  <Divider />
                </HStack>
                <OAuthButtonGroup />
              </Stack>
            </Stack>
          </Box>
        </Stack>
        {loading && <Loader />}
      </Container>
      <Footer />
    </>
  );
};

export default Login;
