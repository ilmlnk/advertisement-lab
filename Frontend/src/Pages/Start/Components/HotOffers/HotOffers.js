import { Fragment } from "react";
import React from "react";
import {
  Box,
  List,
  Card,
  CardBody,
  CardFooter,
  ListItem,
  Icon,
  Divider,
  Text,
  Heading,
  Center,
  Img,
  Button,
  useColorMode,
} from "@chakra-ui/react";

import LandingPageCard from "../../../../Components/LandingPageCard";

const FeaturedProperties = () => {
  const { colorMode } = useColorMode();
  const landingPageCardPropList = [
    {},
    { image: "images/img_image_1.png" },
    { image: "images/img_image_2.png" },
    { image: "images/img_image_3.png" },
    { image: "images/img_image_4.png" },
    { image: "images/img_image_5.png" },
  ];

  return (
    <Box
      bg={colorMode === "dark" ? "gray.900" : "gray.50"}
      flexDir="column"
      font="manrope"
      items="center"
      justify="center"
      px={["120px", "5"]}
      w="full"
    >
      <Box
        flexDir="column"
        gap={["60px"]}
        items="start"
        justify="start"
        maxW={["1200px"]}
        mx="auto"
        w="full"
      >
        <Box flexDir="column" gap="6" items="start" justify="start" w="full">
          <Box
            flexDir={["column", "row"]}
            gap={["10", "100"]}
            items="center"
            justify="between"
            w="full"
          >
            <Text
              fontWeight="extrabold"
              className="sm:text-4xl md:text-[34px] text-[32px] text-gray-900 tracking-[-0.72px] w-auto"
            >
              Featured Properties
            </Text>
            <Button
              bg="transparent"
              cursor="pointer"
              className="flex items-center justify-center min-w-[124px]"
              rightIcon={
                <Img
                  className="h-6 mb-[3px] ml-2"
                  src="images/img_arrowright.svg"
                  alt="arrow_right"
                />
              }
            >
              <Text
                fontWeight="bold"
                className="text-left text-lg text-orange-A700"
              >
                Explore All
              </Text>
            </Button>
          </Box>
          <Box
            flexDir={["column", "row"]}
            gap={["2.5"]}
            items="start"
            justify="start"
            w="full"
          >
            <Button
              bg="transparent"
              cursor="pointer"
              fontWeight="bold"
              minW={["159px"]}
              textAlign="center"
              color={colorMode === "dark" ? "gray.400" : "gray.900"}
              fontSize="lg"
            >
              Resident Property
            </Button>
            <Button
              bg="transparent"
              cursor="pointer"
              fontWeight="bold"
              minW={["186px"]}
              textAlign="center"
              color={colorMode === "dark" ? "gray.400" : "gray.900"}
              fontSize="lg"
            >
              Commercial Property
            </Button>
            <Button
              bg="transparent"
              cursor="pointer"
              fontWeight="bold"
              minW={["164px"]}
              textAlign="center"
              color={colorMode === "dark" ? "gray.400" : "gray.900"}
              fontSize="lg"
            >
              Industrial Property
            </Button>
            <Button
              bg="transparent"
              cursor="pointer"
              fontWeight="bold"
              minW={["180px"]}
              textAlign="center"
              color={colorMode === "dark" ? "gray.400" : "gray.900"}
              fontSize="lg"
            >
              Agriculture Property
            </Button>
          </Box>
        </Box>
        <Box flexDir="column" items="start" justify="start" w="full">
          <Box
            gap={["5", "100"]}
            gridTemplateColumns={["1fr", "repeat(2, 1fr)", "repeat(3, 1fr)"]}
            justify="center"
            minH="auto"
            w="full"
          >
            {landingPageCardPropList.map((props, index) => (
              <Fragment key={`LandingPageCard${index}`}>
                <LandingPageCard
                  className="flex flex-1 flex-col h-full items-start justify-start w-full"
                  {...props}
                />
              </Fragment>
            ))}
          </Box>
        </Box>
      </Box>
    </Box>
  );
};

export default FeaturedProperties;
