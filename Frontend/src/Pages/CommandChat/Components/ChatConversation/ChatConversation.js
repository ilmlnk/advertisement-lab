import React from "react";
import { Avatar, Flex, Heading } from "@chakra-ui/react";
import { ChatBubble } from "../ChatMessage/ChatMessage";
import "./ChatConversationStyle.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faVideo,
  faUserPlus,
  faCircleInfo,
} from "@fortawesome/free-solid-svg-icons";
import ChatInput from "../ChatInput/ChatInput";
import ChatMessages from "../ChatMessages/ChatMessages";

const ChatConversation = () => {
  return (
    <div className="chatConversation">
      <div className="chatInfo">
        <div className="chatUserInformation">
          <Avatar size="sm" />
          <Heading 
          color="#fff" 
          marginLeft="1em"
          fontSize="2xl">Jane</Heading>
        </div>
        <div className="chatIcons">
          <button className="chatButton">
            <FontAwesomeIcon icon={faVideo} />
          </button>
          <button className="chatButton">
            <FontAwesomeIcon icon={faUserPlus} />
          </button>
          <button className="chatButton">
            <FontAwesomeIcon icon={faCircleInfo} />
          </button>
        </div>
      </div>
      <div>
        <ChatMessages/>
        <ChatInput/>
      </div>
    </div>
  );
};

export default ChatConversation;
