import React from "react";
import { Spinner, Center, Box } from "@chakra-ui/react";

const Loader = () => {
  return (
    <Box
      position="fixed"
      top="0"
      left="0"
      width="100vw"
      height="100vh"
      backgroundColor="rgba(0,0,0,0.5)"
      display="flex"
      justifyContent="center"
      alignItems="center"
      zIndex="9999"
      backdropFilter="blur(3px)"
    >
      <Spinner
        thickness="4px"
        speed="0.65s"
        emptyColor="gray.200"
        color="blue.500"
        size="xl"
      />
    </Box>
  );
};

export default Loader;
