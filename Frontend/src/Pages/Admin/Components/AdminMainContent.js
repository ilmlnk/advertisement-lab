import React, { useEffect, useState } from "react";
import Footer from "../../../Components/footer/Footer";
import AdvertisementList from "../../../Components/Entities/Advertisement/AdvertisementList";
import OnlineUserList from "../../../Components/Entities/User/OnlineUserList";
import TaskList from "../../../Components/Entities/Task/TaskList";
import axios from "axios";
import ActionLogList from "../../../Components/Entities/ActionLog/ActionLogList";

const AdminMainContent = () => {
  const [advertisementData, setAdvertisementData] = useState([]);
  const [onlineUserData, setOnlineUserData] = useState([]);
  const [taskData, setTaskData] = useState([]);
  const [recentActionsData, setRecentActionsData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        {
          /* Fetch advertisements */
        }
        const advertisements = await axios.get(
          "https://localhost:50555/AdvertisementController/advertisements"
        );
        if (advertisements.status === 200) {
          setAdvertisementData(advertisements);
        } else {
          console.error("Error occurred: ", advertisements.statusText);
        }

        {
          /* Fetch online users */
        }
        const onlineUsers = await axios.get(
          "https://localhost:50555/UserController/users/onlineUsers"
        );
        if (onlineUsers.status === 200) {
          setOnlineUserData(onlineUsers);
        } else {
          console.error("Error occurred: ", onlineUsers.statusText);
        }

        {
          /* Fetch tasks */
        }
        const tasks = await axios.get(
          "https://localhost:50555/TaskController/tasks"
        );
        if (tasks.status === 200) {
          setTaskData(tasks);
        } else {
          console.error("Error occurred: ", tasks.statusText);
        }
      } catch (error){
        console.error(error);
      }
    };

    fetchData();
  }, []);

  return (
    <>
      <AdvertisementList ads={advertisementData} />
      <OnlineUserList onlineUsers={onlineUserData} />
      <TaskList tasks={taskData} />
      <ActionLogList recentActions={recentActionsData} />
      <Footer />
    </>
  );
};

export default AdminMainContent;
