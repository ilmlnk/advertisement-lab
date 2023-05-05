import React from "react";
import {
    Menu,
    MenuButton,
    MenuList,
    MenuItem,
    MenuItemOption,
    MenuGroup,
    MenuOptionGroup,
    MenuDivider,
  } from '@chakra-ui/react';

import { Button } from "@chakra-ui/button"

import {
    FaChevronDown,
    FaSearch,
    FaTruck,
    FaUndoAlt,
    FaUnlink,
  } from "react-icons/fa";

const StartPageHeader = () => {
    return (
        <div>
            <h1>AdReach</h1>
            <Menu>
                <MenuButton as={Button} rightIcon={<FaChevronDown />}>
                    Actions
                </MenuButton>
                <MenuList>
                    <MenuItem>Download</MenuItem>
                    <MenuItem>Create a Copy</MenuItem>
                    <MenuItem>Mark as Draft</MenuItem>
                    <MenuItem>Delete</MenuItem>
                    <MenuItem>Attend a Workshop</MenuItem>
                </MenuList>
            </Menu>
        </div>
    );
};

export default StartPageHeader;