import React from "react";
import { Avatar, Box, Heading, Icon, Text } from "@chakra-ui/react";

const Comment = () => {
    return (
        <Box>
            <Avatar/>
            <Heading>Username</Heading>
            <Text>Lorem ipsum.</Text>
            {/* Likes box */}
            <Box>
                <Icon/>
                <Text>99+</Text>
            </Box>
            {/*  */}
        </Box>
    );
}

export default Comment;