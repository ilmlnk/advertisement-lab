import {
  Box,
  Text,
  Avatar,
  Heading,
  Stat,
  StatLabel,
  StatNumber,
  StatHelpText,
  StatArrow,
  StatGroup,
  CardHeader,
  CardBody,
  CardFooter,
  Card,
  Icon,
} from "@chakra-ui/react";
import { useState } from "react";
import React from "react";

const StartPageIntro = () => {
  const [stats, setStats] = useState({
    users: 1000,
    products: 6052,
    revenue: 785,
  });
  return (
    <>
      <Heading mt={10} textAlign="center">
        Placing advertisements in any channel in any messenger and social media
      </Heading>
      <Box display="block" justifyContent="space-around" mt={10} >
        <Box gap={6} maxW={600}>
          <Card borderRadius={10} padding={10}>
            <CardHeader>Collected Fees</CardHeader>
            <CardBody>£0.00</CardBody>
            <CardFooter>
              9.05%
            </CardFooter>
          </Card>
          <Card borderRadius={10} padding={10}>
            <CardHeader>Collected Fees</CardHeader>
            <CardBody>£0.00</CardBody>
            <CardFooter>
              9.05%
            </CardFooter>
          </Card>
          <Card borderRadius={10} padding={10}>
            <CardHeader>Collected Fees</CardHeader>
            <CardBody>£0.00</CardBody>
            <CardFooter>
              9.05%
            </CardFooter>
          </Card>
        </Box>
      </Box>
    </>
  );
};

export default StartPageIntro;
