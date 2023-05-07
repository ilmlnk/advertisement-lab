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

import "./LoginStyle.css";

const Login = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [loading, setLoading] = useState(false);
  const [showErrorPopup, setShowErrorPopup] = useState(false);
  const [errorMessage, setErrorMessage] = useState("");

  const navigate = useNavigate();

  const handleCloseErrorPopup = () => {
    setShowErrorPopup(false);
  };

  const handleLogin = (event) => {
    event.preventDefault();

    setLoading(true);

    fetch("https://localhost:50555/api/UserAccount/login", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ username, password }),
    })
      .then((response) => {
        if (!response.ok) {
          throw new Error("Authentication failed!");
        }
        return response.json();
      })
      .then(() => {
        navigate("/admin");
      })
      .catch((error) => {
        setLoading(false);
        setShowErrorPopup(true);
        console.error("Login failed", error);
      });
  };

  return (
    <>
      <Container
    maxW="lg"
    py={{
      base: '12',
      md: '24',
    }}
    px={{
      base: '0',
      sm: '8',
    }}
  >
    <Stack spacing="8">
      <Stack spacing="6">
        <Logo />
        <Stack
          spacing={{
            base: '2',
            md: '3',
          }}
          textAlign="center"
        >
          <Heading
            size={{
              base: 'xs',
              md: 'sm',
            }}
          >
            Log in to your account
          </Heading>
          <HStack spacing="1" justify="center">
            <Text color="muted">Don't have an account?</Text>
            <Button variant="link" colorScheme="blue">
              Sign up
            </Button>
          </HStack>
        </Stack>
      </Stack>
      <Box
        py={{
          base: '0',
          sm: '8',
        }}
        px={{
          base: '4',
          sm: '10',
        }}
        bg={{
          base: 'transparent',
          sm: 'bg-surface',
        }}
        boxShadow={{
          base: 'none',
          sm: 'md',
        }}
        borderRadius={{
          base: 'none',
          sm: 'xl',
        }}
      >
        <Stack spacing="6">
          <Stack spacing="5">
            <FormControl>
              <FormLabel htmlFor="email">Email</FormLabel>
              <Input id="email" type="email" />
            </FormControl>
            <PasswordField />
          </Stack>
          <HStack justify="space-between">
            <Checkbox defaultChecked>Remember me</Checkbox>
            <Button variant="link" colorScheme="blue" size="sm">
              Forgot password?
            </Button>
          </HStack>
          <Stack spacing="6">
            <Button variant="primary">Sign in</Button>
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
  </Container>
      <Footer />
    </>
  );
};

export default Login;
