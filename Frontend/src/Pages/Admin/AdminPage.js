import React from "react";
import { useDisclosure } from "@chakra-ui/react";
import AdvertisementList from "../../Components/Entities/Advertisement/AdvertisementList.js";
import SidebarWithHeader from "../../Components/navigation/Navigation.js";
import AdminMainContent from "./Components/AdminMainContent.js";

const AdminPage = () => {

  return (
      <>
      <SidebarWithHeader children={<AdminMainContent/>}/>
      </>
  );
};

export default AdminPage;
