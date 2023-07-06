import { Box, useColorMode, List, Img, Button, Text } from "@chakra-ui/react";

const LaunchTable = () => {
  const { colorMode } = useColorMode();

  return (
    <Box
      bg={colorMode === "dark" ? "gray.900" : "gray.50"}
      flex="1"
      flexDir="column"
      font="manrope"
      items="start"
      justify="start"
      px={["120px", "5"]}
      py={["50px"]}
      w="full"
    >
      <Box
        flex="1"
        flexDir={["column", "row"]}
        gap={["10px", "100px"]}
        items="start"
        justify="start"
        maxW={["1200px"]}
        mx="auto"
        w="full"
      >
        <List
          className="md:flex-1 sm:flex-col flex-row md:gap-10 gap-[100px] grid sm:grid-cols-1 md:grid-cols-2 grid-cols-3 w-[73%] md:w-full"
          orientation="horizontal"
        >
          <Box
            display="flex"
            flexDir="column"
            gap="18px"
            items="start"
            justify="start"
            w="full"
          >
            <Button
              className="md:h-8"
              bg={colorMode === "dark" ? "whiteAlpha.700" : "gray.200"}
              flex="1"
              h={["60px"]}
              items="center"
              justify="center"
              p="3.5"
              rounded="50%"
              shadow="base"
              w={["60px"]}
            >
              <Img className="h-8" src="images/img_clock.svg" alt="clock" />
            </Button>
            <Box
              display="flex"
              flexDir="column"
              gap="3.5"
              items="start"
              justify="start"
              w="full"
            >
              <Text
                fontWeight="extrabold"
                className="sm:text-4xl md:text-[42px] text-[46px] text-gray.900"
                tracking="-0.92px"
                w="full"
              >
                $15.4M
              </Text>
              <Text
                fontWeight="semibold"
                lineHeight="140.00%"
                color="blueGray.600"
                fontSize="xl"
                tracking="-0.40px"
              >
                <>
                  Owned from
                  <br />
                  Properties transactions
                </>
              </Text>
            </Box>
          </Box>
          <Box
            display="flex"
            flexDir="column"
            gap="18px"
            items="start"
            justify="start"
            w="full"
          >
            <Button
              className="md:h-8"
              bg={colorMode === "dark" ? "whiteAlpha.700" : "gray.200"}
              flex="1"
              h={["60px"]}
              items="center"
              justify="center"
              p="3.5"
              rounded="50%"
              shadow="base"
              w={["60px"]}
            >
              <Img
                className="h-8"
                src="images/img_arrowdown.svg"
                alt="arrowdown"
              />
            </Button>
            <Box
              display="flex"
              flexDir="column"
              gap="3.5"
              items="start"
              justify="start"
              w="full"
            >
              <Text
                fontWeight="extrabold"
                className="sm:text-4xl md:text-[42px] text-[46px] text-gray.900"
                tracking="-0.92px"
                w="full"
              >
                25K+
              </Text>
              <Text
                fontWeight="semibold"
                lineHeight="140.00%"
                maxW={["225px", "full"]}
                color="blueGray.600"
                fontSize="xl"
                tracking="-0.40px"
              >
                Properties for Buy & sell Successfully
              </Text>
            </Box>
          </Box>
          <Box
            display="flex"
            flexDir="column"
            gap="18px"
            items="start"
            justify="start"
            w="full"
          >
            <Button
              className="md:h-8"
              bg={colorMode === "dark" ? "whiteAlpha.700" : "gray.200"}
              flex="1"
              h={["60px"]}
              items="center"
              justify="center"
              p="3.5"
              rounded="50%"
              shadow="base"
              w={["60px"]}
            >
              <Img className="h-8" src="images/img_reply.svg" alt="reply" />
            </Button>
            <Box
              display="flex"
              flexDir="column"
              gap="3.5"
              items="start"
              justify="start"
              w="full"
            >
              <Text
                fontWeight="extrabold"
                className="sm:text-4xl md:text-[42px] text-[46px] text-gray.900"
                tracking="-0.92px"
                w="full"
              >
                500
              </Text>
              <Text
                fontWeight="semibold"
                lineHeight="140.00%"
                maxW={["225px", "full"]}
                color="blueGray.600"
                fontSize="xl"
                tracking="-0.40px"
              >
                <>
                  Daily completed <br />
                  transactions
                </>
              </Text>
            </Box>
          </Box>
        </List>
        <Box
          display="flex"
          flexDir="column"
          gap="18px"
          items="start"
          justify="start"
          w="full"
        >
          <Button
            className="md:h-8"
            bg={colorMode === "dark" ? "whiteAlpha.700" : "gray.200"}
            flex="1"
            h={["60px"]}
            items="center"
            justify="center"
            p="3.5"
            rounded="50%"
            shadow="base"
            w={["60px"]}
          >
            <Img
              className="h-8"
              src="images/img_checkmark.svg"
              alt="checkmark"
            />
          </Button>
          <Box
            display="flex"
            flexDir="column"
            gap="3.5"
            items="start"
            justify="start"
            w="full"
          >
            <Text
              fontWeight="extrabold"
              className="sm:text-4xl md:text-[42px] text-[46px] text-gray.900"
              tracking="-0.92px"
              w="full"
            >
              600+
            </Text>
            <Text
              fontWeight="semibold"
              color="blueGray.600"
              fontSize="xl"
              tracking="-0.40px"
              w="full"
            >
              Regular Clients
            </Text>
          </Box>
        </Box>
      </Box>
    </Box>
  );
};


export default LaunchTable;
