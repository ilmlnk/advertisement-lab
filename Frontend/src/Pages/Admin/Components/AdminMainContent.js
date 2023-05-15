import React from "react";
import Footer from "../../../Components/footer/Footer";
import AdvertisementList from "../../../Components/Entities/Advertisement/AdvertisementList";
import OnlineUserList from "../../../Components/Entities/User/OnlineUserList";
import TaskList from "../../../Components/Entities/Task/TaskList";
import RecentActions from "./RecentActions";

const AdminMainContent = () => {
  return (
    <>
      <AdvertisementList />
      <OnlineUserList />
      <TaskList />
      <RecentActions />
      <Footer />
    </>
  );
};

export default AdminMainContent;
