import React from "react";
import {
  Box,
  Text,
  Flex,
  Stack,
  Circle,
  Button,
  Heading,
} from "@chakra-ui/react";

const Instruction = () => {
  return (
    <Box mr={20} ml={20} mt={10}>
      <Heading textAlign="center">How this platform is working</Heading>
      <Flex mt={10} direction={["column", "row"]} justify="space-between">
        <StepsBlock steps={[1, 2, 3]} />
        <StepsBlock steps={[4, 5, 6]} />
      </Flex>

      <Button mt={10}>Create project</Button>
    </Box>
  );
};

function StepsBlock({ steps }) {
  return (
    <Stack spacing={6}>
      {steps.map((step) => (
        <Step key={step} number={step} text={getStepText(step)} />
      ))}
    </Stack>
  );
}

function Step({ number, text }) {
  return (
    <Flex align="center">
      <Circle size={8} bg="blue.500" color="white" fontWeight="bold" mr={2}>
        {number}
      </Circle>
      <Text>{text}</Text>
    </Flex>
  );
}

function getStepText(step) {
  switch (step) {
    case 1:
      return "Create your account";
    case 2:
      return "Choose your matching channels";
    case 3:
      return "Replenish the balance";
    case 4:
      return "Create a post with a picture and a link";
    case 5:
      return "Channel owner publishes a post and sends a link for verification";
    case 6:
      return "You can download the placement report";
    default:
      return "";
  }
}

export default Instruction;
