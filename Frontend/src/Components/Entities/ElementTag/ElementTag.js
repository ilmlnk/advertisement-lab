import React from "react";

import {
  Tag,
  TagLabel,
  TagLeftIcon,
  TagRightIcon,
  TagCloseButton,
  HStack,
  AddIcon,
} from "@chakra-ui/react";

const ElementTag = () => {
  return (
    <HStack spacing={4}>
      {["sm", "md", "lg"].map((size) => (
        <Tag size={size} key={size} variant="subtle" colorScheme="cyan">
          <TagLeftIcon boxSize="12px" as={AddIcon} />
          <TagLabel>Cyan</TagLabel>
        </Tag>
      ))}
    </HStack>
  );
};

export default ElementTag;
