import React from "react";
import { useDisclosure } from "@chakra-ui/react";
import AdvertisementList from "../../Components/Entities/Advertisement/AdvertisementList";
import SidebarWithHeader from "../../Components/navigation/Navigation";
import AdminMainContent from "./Components/AdminMainContent";

const AdminPage = () => {

  return (
      <>
      <SidebarWithHeader children={<AdminMainContent/>}/>
      </>
  );
};

export default AdminPage;
