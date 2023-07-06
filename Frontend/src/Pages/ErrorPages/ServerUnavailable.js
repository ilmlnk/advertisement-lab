import React from "react";
import { Box, Text, Button } from "@chakra-ui/react";

const ServerUnavailablePage = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={5}>
        Server is not available
      </Text>
      <Button colorScheme="blue" onClick={() => window.location.reload()}>
        Refresh
      </Button>
    </Box>
  );
}

export default ServerUnavailablePage;