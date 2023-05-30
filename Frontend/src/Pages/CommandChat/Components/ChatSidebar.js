import {
  Box,
  Flex,
  VStack,
  Text,
  ChakraProvider,
  Avatar,
  Button,
  Heading,
  AvatarBadge,
  HStack,
  Input,
} from "@chakra-ui/react";

const users = [
  { id: 1, name: "User 1" },
  { id: 2, name: "User 2" },
  { id: 3, name: "User 3" },
  { id: 3, name: "User 3" },
  { id: 3, name: "User 3" },
  { id: 3, name: "User 3" },
  { id: 3, name: "User 3" },
  { id: 3, name: "User 3" },
  { id: 3, name: "User 3" },
  { id: 3, name: "User 3" },
  { id: 3, name: "User 3" },
  { id: 3, name: "User 3" },
];

const handleOpenChat = () => {};

export const ChatSidebar = () => {
    return (
      <Box bg="gray.300" w="460px" h="100vh" overflowY="auto">
        <Input></Input>
        <HStack>
          <VStack align="stretch">
            {users.map((user) => (
              <Box
                height="80px"
                cursor="pointer"
                key={user.id}
                p={4}
                bg="gray.200"
                onClick={() => handleOpenChat()}
              >
                <Flex>
                  <Avatar>
                    <AvatarBadge boxSize="1.25em" bg="green.500" />
                  </Avatar>
                  <Box ml={4}>
                    <Heading size="md">User</Heading>
                    <Text
                      maxW="240px"
                      overflow="hidden"
                      whiteSpace="nowrap"
                      textOverflow="ellipsis"
                    >
                      Examplfedfjfjgfkejdijfjdfefejsdkjdfejhfjejfjee
                    </Text>
                  </Box>
                </Flex>
              </Box>
            ))}
          </VStack>
        </HStack>
      </Box>
    );
  };
  
