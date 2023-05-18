import React, { useState } from "react";
// Chakra imports
import {
  Avatar,
  AvatarGroup,
  Box,
  Flex,
  Button,
  Icon,
  Image,
  Text,
  useColorModeValue,
} from "@chakra-ui/react";
// Assets
import { MdTimer, MdVideoLibrary } from "react-icons/md";
import { IoEllipsisHorizontalSharp } from "react-icons/io5";

const Advertisement = ({ ad, onOpenModal }, props) => {
  {
    /* Props of Advertisement entity */
  }
  const name = useState("");
  const topic = useState("");
  const description = useState("");
  const price = useState(0.0);
  const datePosted = useState(null);
  const userEntity = useState(null);
  const channelType = useState(null);

  {
    /* Color mode values */
  }
  const boxBg = useColorModeValue("white !important", "#111c44 !important");
  const secondaryBg = useColorModeValue("gray.50", "whiteAlpha.100");
  const mainText = useColorModeValue("gray.800", "white");
  const iconBox = useColorModeValue("gray.100", "whiteAlpha.200");
  const iconColor = useColorModeValue("brand.200", "white");

  const handleClick = () => {
    onOpenModal(ad);
  };

  return (
    <Flex
      borderRadius="20px"
      bg={boxBg}
      h="345px"
      w={{ base: "315px", md: "345px" }}
      direction="column"
    >
      <Box p="20px">
        <Flex w="100%" mb="10px">
          <Image src="https://i.ibb.co/ZWxRPRq/Venus-Logo.png" me="auto" />
          <Button
            w="38px"
            h="38px"
            align="center"
            justify="center"
            borderRadius="12px"
            me="12px"
            bg={iconBox}
            onClick={handleClick}
            cursor="pointer"
          >
            <Icon
              w="24px"
              h="24px"
              as={IoEllipsisHorizontalSharp}
              color={iconColor}
            />
          </Button>
        </Flex>
        <Box>
          <Text fontWeight="600" color={mainText} w="100%" fontSize="2xl">
            {props.name}
          </Text>
          <Box>
            <Avatar src="https://i.ibb.co/CmxNdhQ/avatar1.png" />
            <Text>{props.userEntity}</Text>
          </Box>
        </Box>
      </Box>
      <Flex
        bg={secondaryBg}
        w="100%"
        p="20px"
        borderBottomLeftRadius="inherit"
        borderBottomRightRadius="inherit"
        height="100%"
        direction="column"
      >
        <Text
          fontSize="sm"
          color="gray.500"
          lineHeight="24px"
          pe="40px"
          fontWeight="500"
          mb="auto"
        >
          You have the opportunity to play this game of life you need to
          appreciate every moment.
        </Text>
        <Flex>
          <Flex me="25px">
            <Icon as={MdTimer} w="20px" h="20px" me="6px" color="green.400" />
            <Text color={mainText} fontSize="sm" my="auto" fontWeight="500">
              85 mins
            </Text>
          </Flex>
          <Flex>
            <Icon
              as={MdVideoLibrary}
              w="20px"
              h="20px"
              me="6px"
              color="red.500"
            />
            <Text color={mainText} fontSize="sm" my="auto" fontWeight="500">
              Video Format
            </Text>
          </Flex>
        </Flex>
      </Flex>
    </Flex>
  );
};

export default Advertisement;
