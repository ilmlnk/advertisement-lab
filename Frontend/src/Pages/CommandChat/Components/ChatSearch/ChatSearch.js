import React, { useState } from "react";
import "./ChatSearchStyle.css";
import { Avatar, Flex, Heading } from "@chakra-ui/react";
import { Text } from "@chakra-ui/react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faBullhorn, faUser } from "@fortawesome/free-solid-svg-icons";

const ChatSearch = () => {
  const [searchText, setSearchText] = useState("");

  const handleClearClick = () => {
    setSearchText("");
  };

  const handleInputChange = (event) => {
    setSearchText(event.target.value);
  };

  return (
    <div className="search">
      <div className="searchForm">
        <input
          value={searchText}
          onChange={handleInputChange}
          placeholder="Search"
          className="searchInput"
          type="text"
        />
        {searchText && (
          <span className="clearButton" onClick={handleClearClick}>
            &#x2715;
          </span>
        )}
      </div>

      <div className="chats">
        <div className="channelBlock">
          <Flex padding="10px" color="#fff">
            <FontAwesomeIcon icon={faBullhorn} />
            <Heading ml="5px" size="sm">
              Channels
            </Heading>
          </Flex>
          <div className="userChat userChannel">
            <Avatar size="md" />
            <div className="userChatInfo">
              <Heading size="sm">Jane</Heading>
              <Text fontSize="xs">Hello!</Text>
            </div>
          </div>
          <div className="userChat userChannel">
            <Avatar size="md" />
            <div className="userChatInfo">
              <Heading size="sm">Jane</Heading>
              <Text fontSize="xs">Hello!</Text>
            </div>
          </div>
          <div className="userChat userChannel">
            <Avatar size="md" />
            <div className="userChatInfo">
              <Heading size="sm">Jane</Heading>
              <Text fontSize="xs">Hello!</Text>
            </div>
          </div>
          <div className="userChat userChannel">
            <Avatar size="md" />
            <div className="userChatInfo">
              <Heading size="sm">Jane</Heading>
              <Text fontSize="xs">Hello!</Text>
            </div>
          </div>
          <div className="userChat userChannel">
            <Avatar size="md" />
            <div className="userChatInfo">
              <Heading size="sm">Jane</Heading>
              <Text fontSize="xs">Hello!</Text>
            </div>
          </div>
        </div>
        <div className="">
          <Flex padding="10px" color="#fff">
            <FontAwesomeIcon icon={faUser} />
            <Heading ml="5px" size="sm">
              Chats
            </Heading>
          </Flex>
          <div className="userChat">
            <Avatar size="md" />
            <div className="userChatInfo">
              <Heading size="sm">Jane</Heading>
              <Text fontSize="xs">Hello!</Text>
            </div>
          </div>
          <div className="userChat">
            <Avatar size="md" />
            <div className="userChatInfo">
              <Heading size="sm">Jane</Heading>
              <Text fontSize="xs">Hello!</Text>
            </div>
          </div>
          <div className="userChat">
            <Avatar size="md" />
            <div className="userChatInfo">
              <Heading size="sm">Jane</Heading>
              <Text fontSize="xs">Hello!</Text>
            </div>
          </div>
          <div className="userChat">
            <Avatar size="md" />
            <div className="userChatInfo">
              <Heading size="sm">Jane</Heading>
              <Text fontSize="xs">Hello!</Text>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ChatSearch;
