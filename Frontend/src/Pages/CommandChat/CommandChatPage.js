import React from "react";
import SidebarWithHeader from "../../Components/navigation/Navigation";
import Chat from "./Components/CommandChatContent";

const CommandChatPage = () => {
  return (
    <>
      <SidebarWithHeader children={<Chat/>}/>
    </>
  );
};


export default CommandChatPage;