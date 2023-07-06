import { Box, Img, Text, useColorMode } from "@chakra-ui/react";

const FeedbackCarousel = () => {
  const { colorMode } = useColorMode();

  return (
    <Box
      className="flex flex-1 flex-col items-start justify-start w-full"
      bg={colorMode === "dark" ? "gray.900" : "white"}
    >
      <Box
        className="flex flex-col gap-[30px] items-start justify-start w-full"
        color={colorMode === "dark" ? "gray.200" : "gray.900"}
      >
        <Box className="flex sm:flex-col flex-row sm:gap-10 gap-[73px] items-center justify-start w-full">
          <Box className="flex flex-1 flex-col gap-1 items-start justify-start w-full">
            <Text
              fontWeight="extrabold"
              className="sm:text-2xl md:text-[26px] text-[28px] tracking-[-0.56px] w-full"
            >
              Taylor Wilson
            </Text>
            <Text
              fontWeight="semibold"
              className="text-lg w-full"
            >
              Product Manager - Static Mania
            </Text>
          </Box>
          <Img
            className="h-[51px] max-h-[51px]"
            src="images/img_shape.svg"
            alt="shape"
          />
        </Box>
        <Text
          fontWeight="semibold"
          maxW={["455px", "none"]}
          className="leading-[165.00%] text-2xl md:text-[22px] sm:text-xl"
        >
          Eget eu massa et consectetur. Mauris donec. Leo a, id sed duis proin sodales. Turpis viverra diam porttitor mattis morbi ac amet. Euismod commodo. We get you customer relationships that last.
        </Text>
      </Box>
    </Box>
  );
};

export default FeedbackCarousel;