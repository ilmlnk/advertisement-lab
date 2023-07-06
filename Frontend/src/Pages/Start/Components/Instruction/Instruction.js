import { Box, Image, Text, Button } from "@chakra-ui/react";

const Instruction = () => {
  return (
    <Box
    mb="4em"
      display="flex"
      flexDir="column"
      fontFamily="manrope"
      alignItems="start"
      justifyContent="start"
      px={["120px"]}
      w="full"
    >
      <Box
        display="flex"
        flexDir={["column", "row"]}
        gap={["6"]}
        alignItems="center"
        justifyContent="center"
        maxW={["1200px"]}
        mx="auto"
        w="full"
      >
        <Box
          flex="1"
          flexDir="column"
          h={["424px", "auto"]}
          alignItems="start"
          justifyContent="center"
          px={["50px", "10"]}
          py={["46px", "6"]}
          rounded="20px"
          w="full"
        >
          <Box
            display="flex"
            flexDir="column"
            gap={["50px"]}
            alignItems="start"
            justifyContent="start"
            w="full"
          >
            <Box
              display="flex"
              flexDir="column"
              gap="4"
              alignItems="start"
              justifyContent="start"
              w="full"
            >
              <Text
                fontWeight="extrabold"
                lineHeight="140.00%"
                maxW={["488px", "full"]}
                fontSize={["4xl", "32px", "34px"]}
                letterSpacing={["-0.72px"]}
              >
                Simple & easy way to find your dream Appointment
              </Text>
              <Text lineHeight="180.00%" maxW={["488px", "full"]} fontSize="lg">
                Lorem Ipsum is simply dummy text of the printing and typesetting
                industry.
              </Text>
            </Box>
            <Button
              cursor="pointer"
              fontWeight="semibold"
              minW="138px"
              py="13px"
              rounded="10px"
              fontSize="base"
              color="whiteAlpha.900"
            >
              Get Started
            </Button>
          </Box>
        </Box>
        <Box
          flex="1"
          flexDir="column"
          alignItems="start"
          justifyContent="start"
          w="full"
        >
          <Box
            display={["grid"]}
            gridTemplateColumns={["1fr", "1fr"]}
            gap={["6"]}
            justifyContent="center"
            minH="auto"
            w="full"
          >
            <Box
              flex="1"
              flexDir="column"
              h={["200px", "auto"]}
              alignItems="start"
              justifyContent="center"
              px={["30px", "5"]}
              py="6"
              rounded="20px"
              w="full"
              bg="orange.300"
            >
              <Box
                display="flex"
                flexDir="column"
                gap="5"
                alignItems="start"
                justifyContent="start"
                w="full"
              >
                <Image className="h-[30px] w-[30px]" src="" alt="refresh" />
                <Text
                  fontWeight="extrabold"
                  lineHeight="135.00%"
                  maxW={["222px", "full"]}
                  fontSize={["2xl", "26px"]}
                  letterSpacing={["-0.56px"]}
                >
                  <>
                    Search <br />
                    your location
                  </>
                </Text>
              </Box>
            </Box>
            <Box
              flex="1"
              flexDir="column"
              h={["200px", "auto"]}
              alignItems="start"
              justifyContent="center"
              px={["30px", "5"]}
              py="6"
              rounded="20px"
              w="full"
              bg="orange.300"
            >
              <Box
                display="flex"
                flexDir="column"
                gap="5"
                alignItems="start"
                justifyContent="start"
                w="full"
              >
                <Image className="h-[30px] w-[30px]" src="" alt="instagram" />
                <Text
                  fontWeight="extrabold"
                  lineHeight="135.00%"
                  maxW={["222px", "full"]}
                  fontSize={["2xl", "26px"]}
                  letterSpacing={["-0.56px"]}
                >
                  <>
                    Visit <br />
                    Appointment
                  </>
                </Text>
              </Box>
            </Box>
            <Box
              flex="1"
              flexDir="column"
              h={["200px", "auto"]}
              alignItems="start"
              justifyContent="center"
              px={["30px", "5"]}
              py="6"
              rounded="20px"
              w="full"
              bg="orange.300"
            >
              <Box
                display="flex"
                flexDir="column"
                gap="5"
                alignItems="start"
                justifyContent="start"
                w="full"
              >
                <Image className="h-[30px] w-[30px]" src="" alt="camera" />
                <Text
                  fontWeight="extrabold"
                  lineHeight="135.00%"
                  maxW={["222px", "full"]}
                  fontSize={["2xl", "26px"]}
                  letterSpacing={["-0.56px"]}
                >
                  <>
                    Get your <br />
                    dream house
                  </>
                </Text>
              </Box>
            </Box>
            <Box
              flex="1"
              flexDir="column"
              h={["200px", "auto"]}
              alignItems="start"
              justifyContent="center"
              px={["30px", "5"]}
              py="6"
              rounded="20px"
              w="full"
              bg="orange.300"
            >
              <Box
                display="flex"
                flexDir="column"
                gap="5"
                alignItems="start"
                justifyContent="start"
                w="full"
              >
                <Image className="h-[30px] w-[30px]" src="" alt="refresh" />
                <Text
                  fontWeight="extrabold"
                  lineHeight="135.00%"
                  maxW={["222px", "full"]}
                  fontSize={["2xl", "26px"]}
                  letterSpacing={["-0.56px"]}
                >
                  <>
                    Enjoy your <br />
                    Appointment
                  </>
                </Text>
              </Box>
            </Box>
          </Box>
        </Box>
      </Box>
    </Box>
  );
};

export default Instruction;
