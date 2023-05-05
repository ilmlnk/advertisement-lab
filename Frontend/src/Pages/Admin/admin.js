import React from "react";
import Layout from "../Layout/Layout";
import { useDisclosure } from "@chakra-ui/react";

const Admin = () => {
  //const [isOpenUserModal, setIsOpenUserModal] = useDisclosure();

  return (
    <Layout>
      <div className="admin-content">
        {/* Advertisements List */}
        {/* <OrdersList/> */}
        {/*<OnlineUsersList/>*/} 
        {/* show the latest 6 online users */}
        {/* <TasksList/> */}
      </div>
    </Layout>
  );
};

export default Admin;
