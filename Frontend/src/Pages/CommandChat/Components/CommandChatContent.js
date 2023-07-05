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
import CommandChat from "./CommandChat/CommandChat";
import Footer from "../../../Components/footer/Footer";

const Chat = () => {
  return (
    <>
    <CommandChat/>
    <Footer/>
    </>
  );
};

export default Chat;
