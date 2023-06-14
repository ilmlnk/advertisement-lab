import React, { useEffect, useState } from "react";
import Footer from "../../../Components/footer/Footer.js";
import AdvertisementList from "../../../Components/Entities/Advertisement/AdvertisementList.js";
import OnlineUserList from "../../../Components/Entities/User/OnlineUserList.js";
import TaskList from "../../../Components/Entities/Task/TaskList.js";
import axios from "axios";
import ActionLogList from "../../../Components/Entities/ActionLog/ActionLogList.js";

const AdminMainContent = ({adsData}) => {
  const [onlineUserData, setOnlineUserData] = useState([]);
  const [taskData, setTaskData] = useState([]);
  const [recentActionsData, setRecentActionsData] = useState([]);


  return (
    <>
      <AdvertisementList ads={adsData} />
      <OnlineUserList onlineUsers={onlineUserData} />
      <TaskList tasks={taskData} />
      <ActionLogList recentActions={recentActionsData} />
      <Footer />
    </>
  );
};

export default AdminMainContent;
