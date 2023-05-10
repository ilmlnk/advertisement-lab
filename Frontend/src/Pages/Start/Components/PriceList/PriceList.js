import React from "react";

import {
  ChakraProvider,
  Box,
  Flex,
  Grid,
  GridItem,
  Text,
  Heading,
  useColorMode,
  Card,
} from "@chakra-ui/react";

function PriceList() {
  const { colorMode } = useColorMode();

  return (
    <Box mt={10} mx="auto" maxW="1200px">
      <Grid
        templateColumns={["1fr", "1fr 1fr", "1fr 1fr 1fr"]}
        gap={6}
        bg={colorMode === "dark" ? "gray.800" : "white"}
        p={4}
        rounded="md"
      >
        <GridItem>
          <PriceItem
            title="Basic"
            price="$9.99/month"
            features={["Feature 1", "Feature 2", "Feature 3"]}
          />
        </GridItem>
        <GridItem>
          <PriceItem
            title="Pro"
            price="$19.99/month"
            features={["Feature 1", "Feature 2", "Feature 3", "Feature 4"]}
          />
        </GridItem>
        <GridItem>
          <PriceItem
            title="Premium"
            price="$29.99/month"
            features={[
              "Feature 1",
              "Feature 2",
              "Feature 3",
              "Feature 4",
              "Feature 5",
            ]}
          />
        </GridItem>
      </Grid>
    </Box>
  );
}

function PriceItem({ title, price, features }) {
  return (
    <Card p={4} rounded="md" padding={10} height="350">
      <Text fontSize="xl" fontWeight="bold" mb={2}>
        {title}
      </Text>
      <Text fontSize="2xl" fontWeight="bold" mb={4}>
        {price}
      </Text>
      <ul>
        {features.map((feature, index) => (
          <li key={index}>{feature}</li>
        ))}
      </ul>
    </Card>
  );
}

export default PriceList;
