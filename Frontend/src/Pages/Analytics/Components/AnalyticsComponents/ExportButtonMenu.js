import React from "react";
import {
  Box,
  Button,
  Menu,
  MenuButton,
  MenuList,
  MenuItem,
  MenuItemOption,
  MenuGroup,
  MenuOptionGroup,
  MenuDivider,
} from "@chakra-ui/react";
import { ChevronDownIcon } from "@chakra-ui/icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { Document, Page, Text as PdfText } from "react-pdf";
import {
  faFilePdf,
  faFileCsv,
  faFileExcel,
} from "@fortawesome/free-solid-svg-icons";
import { saveAs } from "file-saver";
import { type } from "@testing-library/user-event/dist/type";
import yaml from "js-yaml";

const ExportButtonMenu = ({ chartData }) => {

  {
    /* method to fetch current date for file names */
  }
  const handleFormattedDate = () => {
    const currentDate = new Date();
    const formattedDate = `${currentDate.getFullYear()}_${currentDate.getMonth()}_${currentDate.getDay()}_${currentDate.getHours()}_${currentDate.getMinutes()}_${currentDate.getSeconds()}`;
    return formattedDate;
  };

  return (
    <Menu>
      <MenuButton
        colorScheme="blue"
        as={Button}
        rightIcon={<ChevronDownIcon />}
      >
        Export...
      </MenuButton>
      <MenuList>
        <MenuItem>
          <FontAwesomeIcon icon={faFileCsv} />
          CSV
        </MenuItem>
        <MenuItem>
          <FontAwesomeIcon icon={faFilePdf} />
          PDF
        </MenuItem>
        <MenuItem>
          <FontAwesomeIcon icon={faFileExcel} />
          XLSX
        </MenuItem>
        <MenuItem>JSON</MenuItem>
        <MenuItem>XML</MenuItem>
        <MenuItem>YAML</MenuItem>
      </MenuList>
    </Menu>
  );
};


export default ExportButtonMenu;
