import React from "react";
import {
  Box,
  Flex,
  Heading,
  Stat,
  StatLabel,
  StatNumber,
  StatHelpText,
  StatArrow,
  Divider,
} from "@chakra-ui/react";

const AnalyticsPage = () => {
  return (
    <Box p={4}>
      <Heading mb={4}>Analytics</Heading>
      <Flex justifyContent="space-between" mb={4}>
        <Stat>
          <StatLabel>Visitors</StatLabel>
          <StatNumber>10,000</StatNumber>
          <StatHelpText>
            <StatArrow type="increase" />
            25%
          </StatHelpText>
        </Stat>
        <Stat>
          <StatLabel>Revenue</StatLabel>
          <StatNumber>$50,000</StatNumber>
          <StatHelpText>
            <StatArrow type="decrease" />
            10%
          </StatHelpText>
        </Stat>
        <Stat>
          <StatLabel>Conversion Rate</StatLabel>
          <StatNumber>5%</StatNumber>
          <StatHelpText>
            <StatArrow type="increase" />
            2%
          </StatHelpText>
        </Stat>
      </Flex>
      <Divider />
      <Flex mt={4}>
        <Box flex="1">
          <Heading size="md" mb={2}>
            Page Views
          </Heading>
          {/* Вставьте график или другую информацию об аналитике */}
        </Box>
        <Box flex="1" ml={4}>
          <Heading size="md" mb={2}>
            Users
          </Heading>
          {/* Вставьте график или другую информацию об аналитике */}
        </Box>
      </Flex>
    </Box>
  );
};

export default AnalyticsPage;
