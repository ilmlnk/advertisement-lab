import React from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faRightFromBracket } from "@fortawesome/free-solid-svg-icons";
import "./ChatNavbarStyle.css";
import { Avatar } from "@chakra-ui/react";

const ChatNavbar = () => {
  return (
    <div className="navbar">
      <span className="logo">Chat</span>
      <div className="user">
        <Avatar size="xs"/>
        <span className="user">User</span>
        <button className="log-out">
            <FontAwesomeIcon icon={faRightFromBracket} />
        </button>
      </div>
    </div>
  );
};

export default ChatNavbar;
