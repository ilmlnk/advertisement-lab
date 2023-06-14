import { Box } from "@chakra-ui/react";
import React from "react";
import StartPageHeader from "../Start/Components/StartPageHeader/StartPageHeader";
import SidebarWithHeader from "../../Components/navigation/Navigation";
import UsersFeed from "./Components/UsersFeed";

const CooperationPage = () => {

    return (
        <Box>
            <StartPageHeader/>
            <UsersFeed/>
        </Box>
    );
};

export default CooperationPage;