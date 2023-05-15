import { Box, Table, Thead, Tbody, Tr, Th, Td } from "@chakra-ui/react";

const LaunchTable = () => {
  return (
    <Box mt={8}>
      <Table variant="simple">
        <Thead>
          <Tr>
            <Th>№</Th>
            <Th>Name</Th>
            <Th>Description</Th>
            <Th>Cost</Th>
          </Tr>
        </Thead>
        <Tbody>
          <Tr>
            <Td>1</Td>
            <Td>Starter Pack</Td>
            <Td>Starter Pack description</Td>
            <Td>100$</Td>
          </Tr>
          <Tr>
            <Td>2</Td>
            <Td>Standard Pack</Td>
            <Td>Standard Pack description</Td>
            <Td>200$</Td>
          </Tr>
          <Tr>
            <Td>3</Td>
            <Td>Premium</Td>
            <Td>Premium Pack description</Td>
            <Td>300$</Td>
          </Tr>
        </Tbody>
      </Table>
    </Box>
  );
};

export default LaunchTable;
