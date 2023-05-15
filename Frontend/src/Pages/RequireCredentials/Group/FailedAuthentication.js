import React from "react";
import {
  Alert,
  AlertIcon,
  AlertTitle,
  AlertDescription,
} from "@chakra-ui/react";

export const FailedAuthentication = () => {
  return (
    <Alert
    mb={6}
    borderRadius={6}
     status="error">
      <AlertIcon />
      <AlertTitle>Error</AlertTitle>
      <AlertDescription>
        Authentication is failed!
      </AlertDescription>
    </Alert>
  );
};

