import React from "react";
import Select from "react-select";
import { Box, Flex, Input, Button, Text, Avatar, Img } from "@chakra-ui/react";
import StartPageHeader from "../Start/Components/StartPageHeader/StartPageHeader";
import Footer from "../../Components/footer/Footer";
import SelectBox from "../../Components/SelectBox";
import UserCard from "./Components/UserCard";

const dropdownlargeOptionsList = [
  { label: "Option1", value: "option1" },
  { label: "Option2", value: "option2" },
  { label: "Option3", value: "option3" },
];

const CommunityPage = () => {
  return (
    <>
      <Box
        bg="gray.51"
        display="flex"
        flexDirection="column"
        fontFamily="markoone"
        gap={["100px", "100px", "10", "10"]}
        mb="4em"
      >
        <StartPageHeader />
        <Flex
          flexDirection="column"
          fontFamily="manrope"
          gap="4"
          alignItems="center"
          justifyContent="center"
          maxW="1200px"
          mx="auto"
          width="full"
        >
          <Text
            fontWeight="extrabold"
            fontSize={["4xl", "32px", "34px"]}
            color="gray.900"
            letterSpacing={[-0.72]}
            width="full"
          >
            Some Nearby Good Agents
          </Text>
          <Flex
            flexDirection={["column", "column", "row"]}
            gap="4"
            alignItems="center"
            justifyContent="start"
            width="full"
          >
            <Box
              bg="white-A700"
              border="1px"
              borderColor="bluegray.100"
              display="flex"
              flex="1"
              flexDirection="column"
              alignItems="start"
              justifyContent="start"
              px="4"
              py="3.5"
              rounded="10px"
              width="full"
            >
              <Input
                placeholder="Enter your address"
                fontWeight="semibold"
                p={0}
                placeholderTextColor="gray.600"
                textAlign="left"
                fontSize="lg"
                width="full"
                suffix={
                  <Img
                    mt="auto"
                    mb={-3}
                    h={6}
                    ml={3}
                    src="images/img_search_gray_600.svg"
                    alt="search"
                  />
                }
              />
            </Box>
            <Select
              className="bg-white-A700 border border-bluegray-100 border-solid md:flex-1 font-bold pl-5 pr-4 py-[17px] rounded-[10px] text-gray-600 text-left text-lg w-[12%] md:w-full"
              placeholderClassName="text-gray-600"
              indicator={
                <Img
                  className="h-6 w-6"
                  src="images/img_arrowdown_gray_600_24x24.svg"
                  alt="arrow_down"
                />
              }
              isMulti={false}
              name="dropdownlarge"
              options={dropdownlargeOptionsList}
              isSearchable={false}
              placeholder="Review"
            />
            <Button
              className="bg-gray-900 cursor-pointer flex items-center justify-center min-w-[128px] pl-5 pr-4 py-[17px] rounded-[10px]"
              rightIcon={
                <Img
                  className="h-5 mt-px mb-[3px] ml-2.5"
                  src="images/img_search_white_a700.svg"
                  alt="search"
                />
              }
            >
              <Text fontWeight="bold" fontSize="lg" color="white-A700">
                Search
              </Text>
            </Button>
          </Flex>
          <Flex gap="4" mt="4" flexWrap="wrap">
            {Array.from({ length: 6 }).map((_, index) => (
              <UserCard key={index} />
            ))}
          </Flex>
        </Flex>
      </Box>
      <Footer />
    </>
  );
};

export default CommunityPage;
