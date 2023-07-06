import {
  Box,
  Button,
  Img,
  Input,
  List,
  Text,
  useColorMode,
} from "@chakra-ui/react";

const NewsSection = () => {
  const { colorMode } = useColorMode();

  return (
    <Box
      bg={colorMode === "dark" ? "gray.900" : "gray.100"}
      className="flex flex-col font-manrope items-center justify-center p-[120px] md:px-10 sm:px-5 w-full"
    >
      <Box className="flex flex-col md:gap-10 gap-[120px] items-center justify-start max-w-[1200px] mx-auto w-full">
        <Box className="flex flex-col md:gap-10 gap-[60px] items-start justify-start w-full">
          <Box
            className="flex sm:flex-col flex-row gap-5 items-center justify-start w-full"
            color={colorMode === "dark" ? "white" : "gray.900"}
          >
            <Text
              flex="1"
              fontWeight="extrabold"
              className="text-4xl sm:text-[32px] md:text-[34px] tracking-[-0.72px] w-auto"
            >
              News & Consult
            </Text>
            <Button
              className="bg-transparent cursor-pointer flex items-center justify-center min-w-[124px]"
              rightIcon={
                <Img
                  className="h-6 mb-[3px] ml-2"
                  src="images/img_arrowright.svg"
                  alt="arrow_right"
                />
              }
            >
              <Text className="font-bold text-left text-lg text-orange-A700">
                Explore All
              </Text>
            </Button>
          </Box>
          <List
            className="sm:flex-col flex-row gap-6 grid sm:grid-cols-1 md:grid-cols-2 grid-cols-3 justify-start w-full"
            orientation="horizontal"
          >
            <Box className="flex flex-1 flex-col gap-6 h-[487px] md:h-auto items-start justify-start w-full">
              <Img
                className="md:h-auto h-full object-cover rounded-bl-[10px] rounded-br-[10px] w-full"
                src="images/img_image_350x384.png"
                alt="image"
              />
              <Box className="flex flex-col gap-6 items-start justify-start w-full">
                <Text
                  fontWeight="bold"
                  className="leading-[135.00%] md:max-w-full max-w-sm text-2xl md:text-[22px] sm:text-xl tracking-[-0.48px]"
                >
                  9 Easy-to-Ambitious DIY Projects to Improve Your Home
                </Text>
                <Box className="flex flex-row gap-2 items-center justify-start w-full sm:w-full">
                  <Text className="font-bold text-deep_orange-400 text-lg w-auto">
                    Read the Article
                  </Text>
                  <Img
                    className="h-6 w-6"
                    src="images/img_arrowright_deep_orange_400.svg"
                    alt="arrowright"
                  />
                </Box>
              </Box>
            </Box>
            <Box className="flex flex-1 flex-col gap-6 h-[487px] md:h-auto items-start justify-start w-full">
              <Img
                className="md:h-auto h-full object-cover rounded-bl-[10px] rounded-br-[10px] w-full"
                src="images/img_image_6.png"
                alt="image"
              />
              <Box className="flex flex-col gap-6 items-start justify-start w-full">
                <Text
                  fontWeight="bold"
                  className="leading-[135.00%] md:max-w-full max-w-sm text-2xl md:text-[22px] sm:text-xl tracking-[-0.48px]"
                >
                  Serie Shophouse Launch In July, Opportunity For Investors
                </Text>
                <Box className="flex flex-row gap-2 items-center justify-start w-full sm:w-full">
                  <Text className="font-bold text-deep_orange-400 text-lg w-auto">
                    Read the Article
                  </Text>
                  <Img
                    className="h-6 w-6"
                    src="images/img_arrowright_deep_orange_400.svg"
                    alt="arrowright"
                  />
                </Box>
              </Box>
            </Box>
            <Box className="flex flex-1 flex-col gap-6 h-[487px] md:h-auto items-start justify-start w-full">
              <Img
                className="md:h-auto h-full object-cover rounded-bl-[10px] rounded-br-[10px] w-full"
                src="images/img_image_7.png"
                alt="image"
              />
              <Box className="flex flex-col gap-6 items-start justify-start w-full">
                <Text
                  fontWeight="bold"
                  className="leading-[135.00%] md:max-w-full max-w-sm text-2xl md:text-[22px] sm:text-xl tracking-[-0.48px]"
                >
                  Looking for a New Place? Use This Time to Create Your Wishlist
                </Text>
                <Box className="flex flex-row gap-2 items-center justify-start w-full sm:w-full">
                  <Text className="font-bold text-deep_orange-400 text-lg w-auto">
                    Read the Article
                  </Text>
                  <Img
                    className="h-6 w-6"
                    src="images/img_arrowright_deep_orange_400.svg"
                    alt="arrowright"
                  />
                </Box>
              </Box>
            </Box>
          </List>
        </Box>
        <Box
          bg={colorMode === "dark" ? "gray.400" : "gray.50"}
          className="flex flex-col items-center justify-center md:px-10 sm:px-5 px-[100px] py-10 rounded-[10px] w-full"
        >
          <Box className="flex flex-col gap-[30px] items-center justify-start md:px-10 sm:px-5 px-[200px] w-full">
            <Box className="flex flex-col gap-2.5 items-center justify-start w-full">
              <Text
                fontWeight="extrabold"
                className="sm:text-2xl md:text-[26px] text-[28px] text-center text-gray-900 tracking-[-0.56px] w-full"
              >
                For Recent Update, News.
              </Text>
              <Text className="leading-[180.00%] max-w-[600px] md:max-w-full text-center text-gray-900 text-lg">
                We help businesses customize, automate, and scale up their ad
                production and delivery.
              </Text>
            </Box>
            <Box className="flex sm:flex-col flex-row gap-2 items-start justify-start w-full">
              <Input
                name="input"
                placeholder="Enter your Email"
                className="font-semibold p-0 placeholder:text-gray-700 text-gray-700 text-left text-sm w-full"
                wrapClassName="bg-gray-52 flex-1 sm:flex-1 pb-3 pl-4 pr-3 pt-[15px] rounded-[10px] w-[78%] sm:w-full"
                type="email"
              />
              <Button className="bg-gray-900 cursor-pointer font-semibold min-w-[126px] py-[13px] rounded-[10px] text-base text-center text-white-A700">
                Subscribe
              </Button>
            </Box>
          </Box>
        </Box>
      </Box>
    </Box>
  );
};

export default NewsSection;
