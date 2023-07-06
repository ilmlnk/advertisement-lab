import {
  Box,
  Text,
  Image,
  Button,
  Input,
  useColorMode,
} from "@chakra-ui/react";
import { useState, useNavigate } from "react";
import React from "react";

const StartPageIntro = () => {
  const [stats, setStats] = useState({
    users: 1000,
    products: 6052,
    revenue: 785,
  });

  const { colorMode } = useColorMode();

  return (
    <>
      <Box
        display="flex"
        flexDir="column"
        alignItems="flex-start"
        justifyContent="flex-start"
        pl={[120]}
        py={[50]}
        w="full"
      >
        <Box
          display="flex"
          flexDir={{ base: "column", md: "row" }}
          gap={{ base: 10, md: 100 }}
          alignItems="center"
          justifyContent="flex-start"
          w="full"
        >
          <Box
            flex="1"
            display="flex"
            flexDir="column"
            gap={10}
            alignItems="flex-start"
            justifyContent="flex-start"
            w="full"
          >
            <Box
              display="flex"
              flexDir="column"
              gap={4}
              alignItems="flex-start"
              justifyContent="flex-start"
              w="full"
            >
              <Text
                className="leading-[140.00%] sm:text-4xl md:text-[42px] text-[46px] tracking-[-0.92px]"
                size="2xl"
                fontWeight="bold"
                color={colorMode === "dark" ? "white" : "gray.900"}
              >
                <>
                  Create your own advertisement
                  <br />
                  or you can place this advertisement and earn money!
                </>
              </Text>
              <Text
                className="leading-[180.00%] max-w-[610px] md:max-w-full text-gray-700 text-xl"
                size="lg"
                fontWeight="normal"
                color={colorMode === "dark" ? "white" : "gray.700"}
              >
                We helps businesses customize, automate and scale up their ad
                production and delivery.
              </Text>
            </Box>
            <Box
              bg={colorMode === "dark" ? "gray.800" : "white"}
              display="flex"
              flexDir="column"
              alignItems="flex-start"
              justifyContent="flex-start"
              p={6}
              px={[5]}
              rounded="lg"
              w="full"
            >
              <Box
                display="flex"
                flexDir="column"
                gap={[38]}
                alignItems="center"
                justifyContent="flex-start"
                w="full"
              >
                <Box
                  display={{ base: "flex", sm: "flex-col", md: "flex-row" }}
                  gap={4}
                  alignItems="center"
                  justifyContent="center"
                  w="full"
                >
                  <Button
                    bg={colorMode === "dark" ? "gray.900" : "gray.300"}
                    cursor="pointer"
                    fontWeight="bold"
                    py={3}
                    rounded="lg"
                    textAlign="center"
                    textTransform="uppercase"
                    color={colorMode === "dark" ? "white" : "gray.900"}
                    w="full"
                  >
                    Buy
                  </Button>
                  <Button
                    bg={colorMode === "dark" ? "gray.900" : "gray.300"}
                    cursor="pointer"
                    fontWeight="bold"
                    py={3}
                    rounded="lg"
                    textAlign="center"
                    color={colorMode === "dark" ? "white" : "gray.900"}
                    w="full"
                  >
                    Sell
                  </Button>
                  <Button
                    bg={colorMode === "dark" ? "gray.900" : "gray.300"}
                    cursor="pointer"
                    fontWeight="bold"
                    py={3}
                    rounded="lg"
                    textAlign="center"
                    color={colorMode === "dark" ? "white" : "gray.900"}
                    w="full"
                  >
                    Rent
                  </Button>
                </Box>
                <Box
                  display="flex"
                  flexDir="column"
                  gap={6}
                  alignItems="flex-start"
                  justifyContent="flex-start"
                  w="full"
                >
                  <Box
                    display="flex"
                    flexDir="column"
                    gap={5}
                    alignItems="flex-start"
                    justifyContent="flex-start"
                    w="full"
                  >
                    <Input
                      name="textfieldlarge"
                      placeholder="City/Street"
                      className="font-semibold p-0 placeholder:text-gray-600 text-gray-600 text-left text-lg w-full"
                      wrapClassName="bg-white-A700 border border-bluegray-100 border-solid flex pb-3.5 pt-5 px-4 rounded-[10px] w-full"
                      suffix={
                        <Image
                          mt="auto"
                          mb={["5px"]}
                          h={5}
                          ml={["35px"]}
                          src="../../../../Images/test.png"
                          alt="location"
                        />
                      }
                    />
                    <Input
                      name="textfieldlarge_One"
                      placeholder="Property Type"
                      className="font-semibold p-0 placeholder:text-gray-600 text-gray-600 text-left text-lg w-full"
                      wrapClassName="bg-white-A700 border border-bluegray-100 border-solid flex pb-3.5 pt-5 px-4 rounded-[10px] w-full"
                      suffix={
                        <Image
                          mt="auto"
                          mb={["5px"]}
                          h={5}
                          ml={["35px"]}
                          src="images/img_sort.svg"
                          alt="sort"
                        />
                      }
                    />
                    <Input
                      name="textfieldlarge_Two"
                      placeholder="Price Range"
                      className="font-semibold p-0 placeholder:text-gray-600 text-gray-600 text-left text-lg w-full"
                      wrapClassName="bg-white-A700 border border-bluegray-100 border-solid flex pb-3.5 pt-5 px-4 rounded-[10px] w-full"
                      suffix={
                        <Image
                          mt="auto"
                          mb={["5px"]}
                          h={5}
                          ml={["35px"]}
                          src="images/img_sort.svg"
                          alt="sort"
                        />
                      }
                    />
                  </Box>
                  <Button
                    bg={colorMode === "dark" ? "gray.900" : "gray.300"}
                    cursor="pointer"
                    fontWeight="bold"
                    py={[17]}
                    rounded="lg"
                    textAlign="center"
                    textTransform="uppercase"
                    color={colorMode === "dark" ? "white" : "gray.900"}
                    w="full"
                  >
                    Search
                  </Button>
                </Box>
              </Box>
            </Box>
          </Box>
          <Box
            flex={{ base: "none", md: 1 }}
            display="flex"
            flexDir="column"
            alignItems="center"
            justifyContent="flex-start"
            w={["47%", "full"]}
            md="full"
          >
            <Image
              className="h-[503px] md:h-auto object-cover w-full"
              src="/intro_photo.png"
              alt="image"
            />
          </Box>
        </Box>
      </Box>
    </>
  );
};

export default StartPageIntro;
