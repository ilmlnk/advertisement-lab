import React from "react";

import Footer from "../../Components/footer/Footer";

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

import { FailedAuthentication } from "./Group/FailedAuthentication";

import UserFormHeader from "../Registration/UserFormHeader";

const ForgotPasswordPage = () => {
  return (
    <>
      <UserFormHeader link="/login" />
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
        <Stack spacing="8">
          <Stack spacing="6">
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
                Forgot password
              </Heading>
              <HStack spacing="1" justify="center">
                <Text color="muted">
                  Write down your e-mail to receive recovery code
                </Text>
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
                <FormControl>
                  <FormLabel htmlFor="email">Email</FormLabel>
                  <Input id="email" type="email" />
                </FormControl>
              </Stack>
              <Stack spacing="6">
                <Button
                  type="submit"
                  bg={"blue.400"}
                  color={"white"}
                  w="full"
                  _hover={{
                    bg: "blue.500",
                  }}
                >
                  Send
                </Button>
              </Stack>
            </Stack>
          </Box>
        </Stack>
      </Container>
      <Footer />
    </>
  );
};

export default ForgotPasswordPage;
