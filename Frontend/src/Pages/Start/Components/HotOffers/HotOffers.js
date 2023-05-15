import React from "react";
import {
  Box,
  List,
  Card,
  CardBody,
  CardFooter,
  ListItem,
  Icon,
  Divider,
  Text,
  Heading,
  Center,
} from "@chakra-ui/react";

const HotOffers = () => {
  const items = [
    {
      id: 1,
      name: "Item 1",
      description: "Description 1",
      category: "Category 1",
    },
    {
      id: 2,
      name: "Item 2",
      description: "Description 2",
      category: "Category 2",
    },
    {
      id: 3,
      name: "Item 3",
      description: "Description 3",
      category: "Category 3",
    },
    {
      id: 4,
      name: "Item 3",
      description: "Description 3",
      category: "Category 3",
    },
    {
      id: 5,
      name: "Item 3",
      description: "Description 3",
      category: "Category 3",
    },
    {
      id: 6,
      name: "Item 3",
      description: "Description 3",
      category: "Category 3",
    },
    {
      id: 7,
      name: "Item 3",
      description: "Description 3",
      category: "Category 3",
    },
  ];

  return (
    <Center pb="4em" backgroundColor="blue">
      <Box mt="4em">
        <Heading color="white" textAlign="center" mb="1em">
          Hot Offers
        </Heading>
        <Box>
          <List spacing={3}>
            {items.map((item) => (
              <ListItem key={item.id} display="flex" alignItems="center">
                <Card>
                  <CardBody>
                    <Box display="flex" alignItems="center" marginRight="4">
                      <Box marginRight="4">
                        <Box
                          display="flex"
                          flexDirection="column"
                          alignItems="center"
                        >
                          <Box>
                            <Icon />
                          </Box>
                          <Divider orientation="vertical" />
                          <Box>
                            <Icon />
                          </Box>
                        </Box>
                      </Box>
                      <Box>
                        <Text>{item.name}</Text>
                        <Divider
                          marginTop="2"
                          marginBottom="2"
                          orientation="vertical"
                        />
                        <Box>
                          <Text>{item.description}</Text>
                          <Text>{item.category}</Text>
                        </Box>
                      </Box>
                      <Divider orientation="vertical" />
                      <Box ml={10}>
                        <Text>Example 1</Text>
                        <Text>Example 2</Text>
                        <Text>Example 3</Text>
                      </Box>
                      <Box ml={10}>
                        <Text>Example 1</Text>
                        <Text>Example 2</Text>
                        <Text>Example 3</Text>
                      </Box>
                      <Box ml={10}>
                        <Text>Example 1</Text>
                        <Text>Example 2</Text>
                        <Text>Example 3</Text>
                      </Box>
                      <Box ml={10}>
                        <Text>Example 1</Text>
                        <Text>Example 2</Text>
                        <Text>Example 3</Text>
                      </Box>
                      <Box ml={10}>
                        <Text>Example 1</Text>
                        <Text>Example 2</Text>
                        <Text>Example 3</Text>
                      </Box>
                    </Box>
                  </CardBody>
                </Card>
              </ListItem>
            ))}
          </List>
        </Box>
      </Box>
    </Center>
  );
};

export default HotOffers;
