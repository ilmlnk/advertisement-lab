import React from "react";
import { ChatMessage } from "../ChatMessage/ChatMessage";
import './ChatMessagesStyle.css';

const ChatMessages = () => {
    return (
        <div className="chatMessages">
            <ChatMessage/>
            <ChatMessage/>
            <ChatMessage/>
            <ChatMessage/>
            <ChatMessage/>
        </div>
    );
};

export default ChatMessages;