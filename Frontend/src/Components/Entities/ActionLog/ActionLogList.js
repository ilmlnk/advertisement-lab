import React, { useState } from "react";
import {
  Box,
  Heading,
  Table,
  Thead,
  Tbody,
  Tfoot,
  Tr,
  Th,
  Td,
  TableCaption,
  TableContainer,
  Button,
  Center,
  Modal,
  ModalOverlay,
  ModalContent,
  ModalHeader,
  ModalCloseButton,
  ModalBody,
  ModalFooter,
  useColorModeValue,
} from "@chakra-ui/react";
import ActionLog from "./ActionLog";

const ActionLogList = ({ recentActions }) => {
  const [selectedAction, setSelectedAction] = useState(null);
  const tableBgColor = useColorModeValue("gray.200", "gray.700");
  const cellBgColor = useColorModeValue("gray.300", "gray.600");

  const handleOpenModal = (recentAction) => {
    setSelectedAction(recentAction);
  };

  const handleCloseModal = () => {
    setSelectedAction(null);
  };

  return (
    <Box p="2em">
      <Heading>Recent Actions</Heading>
      <TableContainer
        p="1em"
        backgroundColor={tableBgColor}
        mt="2em"
        borderRadius="1em"
      >
        <Table variant="simple">
          <TableCaption>Imperial to metric conversion factors</TableCaption>
          <Thead>
            <Tr>
              <Th>Action</Th>
              <Th>User</Th>
              <Th>Date</Th>
            </Tr>
          </Thead>
          {recentActions.length > 0 ? (
            <Tbody>
              {recentActions.map((action) => (
                <ActionLog
                  key={action.id}
                  id={action.id}
                  name={action.name}
                  description={action.description}
                  conductedByUser={action.conductedByUser}
                  timestamp={action.timestamp}
                />
              ))}
            </Tbody>
          ) : (
            <Tbody>
              <Tr>
                <Td
                  colSpan={3}
                  borderTopRadius="10px"
                  borderBottomRadius="10px"
                  backgroundColor={cellBgColor}
                >
                  No data
                </Td>
              </Tr>
            </Tbody>
          )}
        </Table>
      </TableContainer>
      {recentActions.length > 0 ? null : (
        <Center>
          <Button colorScheme="blue" mt="2em">
            Refresh
          </Button>
        </Center>
      )}
    </Box>
  );
};

export const ActionLogModal = ({ isOpen, onClose, task }) => {
  return (
    <Modal isOpen={isOpen} onClose={onClose}>
      <ModalOverlay />
      <ModalContent>
        <ModalHeader>{task.name}</ModalHeader>
        <ModalCloseButton />
        <ModalBody>{/* Add content here for the task modal */}</ModalBody>
        <ModalFooter>
          <Button colorScheme="blue" onClick={onClose}>
            Close
          </Button>
        </ModalFooter>
      </ModalContent>
    </Modal>
  );
};

export default ActionLogList;
