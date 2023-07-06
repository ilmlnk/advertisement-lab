import React, { useState } from "react";
import {
  Box,
  Flex,
  Input,
  IconButton,
  Divider,
  VStack,
  Avatar,
  Text,
  Heading,
} from "@chakra-ui/react";
import { AiOutlineSend } from "react-icons/ai";
import CommandChat from "./CommandChat";
import Footer from "../../../Components/footer/Footer";

const Chat = () => {
  return (
    <>
    <Heading textAlign="center" m="1em">Command Chat</Heading>
    <CommandChat/>
    <Footer/>
    </>
  );
};

export default Chat;
