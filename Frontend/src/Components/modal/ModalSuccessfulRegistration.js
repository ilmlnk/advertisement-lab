import React from "react";
import "./SuccessfulRegistrationStyle.css";
import {
    Alert,
    AlertIcon,
    AlertTitle,
    AlertDescription,
  } from '@chakra-ui/react'

const ModalSuccessfulRegistration = () => {
  return (
    <Alert
      status="success"
      variant="subtle"
      flexDirection="column"
      alignItems="center"
      justifyContent="center"
      textAlign="center"
      height="200px"
    >
      <AlertIcon boxSize="40px" mr={0} />
      <AlertTitle mt={4} mb={1} fontSize="lg">
        Successful registration!
      </AlertTitle>
      <AlertDescription maxWidth="sm">
        Now you can enter your account.
      </AlertDescription>
    </Alert>
  );
};

export default ModalSuccessfulRegistration;
