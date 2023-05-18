import React from "react";
import { Box, Td, Tr } from "@chakra-ui/react";

{
  /*
 - ActionName
 - ActionDescription
 - ConductedByUser
 - Timestamp

*/
}

const ActionLog = (props) => {
  return (
    <Tr key={props.id}>
      <Td>{props.name}</Td>
      <Td>{props.description}</Td>
      <Td>{props.conductedByUser}</Td>
      <Td>{props.timestamp}</Td>
    </Tr>
  );
};

export default ActionLog;
