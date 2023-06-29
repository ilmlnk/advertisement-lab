import React from "react";
import Select from "react-select";
import { Box, Flex, Input, Button, Text, Avatar, Img } from "@chakra-ui/react";
import StartPageHeader from "../Start/Components/StartPageHeader/StartPageHeader";
import Footer from "../../Components/footer/Footer";
import SelectBox from "../../Components/SelectBox";
import HotOfferCard from "./Components/HotOfferCard";

const dropdownlargeOptionsList = [
  { label: "Option1", value: "option1" },
  { label: "Option2", value: "option2" },
  { label: "Option3", value: "option3" },
];

const hotOffers = [
  {
    name: "Example 1",
    category: "Category 1",
    views: 3125,
    er: 41.25,
    subscribers: 6958,
    cpv: 0.36,
    format: "2/48",
    price: 415.36
  },
  {
    name: "Example 2",
    category: "Category 2",
    views: 5000,
    er: 52.1,
    subscribers: 10000,
    cpv: 0.45,
    format: "1/24",
    price: 600.5
  },
  {
    name: "Example 3",
    category: "Category 3",
    views: 8000,
    er: 35.8,
    subscribers: 15000,
    cpv: 0.28,
    format: "3/72",
    price: 750.8
  },
  {
    name: "Example 4",
    category: "Category 1",
    views: 4000,
    er: 47.5,
    subscribers: 8000,
    cpv: 0.32,
    format: "2/48",
    price: 500.3
  },
  {
    name: "Example 5",
    category: "Category 2",
    views: 6000,
    er: 50.6,
    subscribers: 12000,
    cpv: 0.42,
    format: "1/24",
    price: 700.2
  },
  {
    name: "Example 6",
    category: "Category 3",
    views: 7000,
    er: 38.9,
    subscribers: 10000,
    cpv: 0.25,
    format: "3/72",
    price: 900.9
  }
];


const HotOffersPage = () => {
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
            textAlign="center"
          >
            Hot Offers
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
            {hotOffers.map((hotOffer, index) => (
              <HotOfferCard 
              key={index} 
              name={hotOffer.name}
              category={hotOffer.category}
              views={hotOffer.views}
              er={hotOffer.er}
              subscribers={hotOffer.subscribers}
              cpv={hotOffer.cpv}
              format={hotOffer.format}
              price={hotOffer.price}
              />
            ))}
          </Flex>
        </Flex>
      </Box>
      <Footer />
    </>
  );
};

export default HotOffersPage;
