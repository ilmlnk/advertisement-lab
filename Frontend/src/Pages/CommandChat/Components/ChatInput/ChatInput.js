import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import React from "react";
import { faPaperclip, faImages } from "@fortawesome/free-solid-svg-icons";
import { BiSend, BiSolidSend } from "react-icons/bi";
import { IoSend } from "react-icons/io5";
import "./ChatInputStyle.css";

const ChatInput = () => {
  const handleInputChange = (event) => {
    event.target.style.height = "auto";
    event.target.style.height = event.target.scrollHeight + "px";
  };

  return (
    <div className="input">
      <input
        onChange={handleInputChange}
        type="text"
        placeholder="Type something..."
        className="chatInputField"
      />
      <div className="send">
        <button>
          <FontAwesomeIcon icon={faPaperclip} />
        </button>
        <input type="file" style={{ display: "none" }} id="file" />
        <button>
          <FontAwesomeIcon icon={faImages} />
        </button>
        <button className="chatSendButton">
          <IoSend />
        </button>
      </div>
    </div>
  );
};

export default ChatInput;
