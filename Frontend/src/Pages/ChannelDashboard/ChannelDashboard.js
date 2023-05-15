import React from "react";
import { useState } from "react";
import {
  Box,
  Heading,
  Input,
  InputGroup,
  InputRightElement,
  Button,
  Menu,
  MenuButton,
  MenuList,
  MenuItem,
  Icon,
  Flex,
  Accordion,
  AccordionItem,
  AccordionButton,
  AccordionPanel,
  AccordionIcon,
  RangeSlider,
  RangeSliderTrack,
  RangeSliderFilledTrack,
  RangeSliderThumb,
  Text,
  List,
  ListItem,
  ListIcon,
  VStack,
  Divider,
  Card,
  CardBody,
  Switch,
  useDisclosure,
} from "@chakra-ui/react";

import Footer from "../../Components/footer/Footer";

import { FaStar, FaGem, FaShieldAlt } from "react-icons/fa";

import { SearchIcon, ChevronDownIcon } from "@chakra-ui/icons";
import StartPageHeader from "../Start/Components/StartPageHeader/StartPageHeader";

const ChannelDashboard = () => {
  const [searchTerm, setSearchTerm] = useState("");

  const toggleButtons = [
    {
      id: 1,
      name: "Exclusive",
      icon: <FaStar />,
    },
    {
      id: 2,
      name: "Trusted",
      icon: <FaStar />,
    },
    {
      id: 3,
      name: "Verified",
      icon: <FaStar />,
    },
  ];
  const [toggleState, setToggleState] = useState({});

  const handleToggle = (id) => {
    setToggleState((prevState) => ({
      ...prevState,
      [id]: !prevState[id],
    }));
  };

  {
    /* Types */
  }
  const types = [];

  for (let i = 1; i <= 15; i++) {
    types.push({
      id: i,
      name: `Name ${i}`,
    });
  }

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

  const handleSearch = (event) => {
    setSearchTerm(event.target.value);
  };

  const filteredItems = items.filter((item) =>
    item.name.toLowerCase().includes(searchTerm.toLowerCase())
  );

  return (
    <>
      <StartPageHeader />
      <Heading mt="2em" textAlign="center">
        Channel Board
      </Heading>
      <Box display="flex" flexDirection="row" padding={75}>
        <Box w="500px">
          <Heading>Filters</Heading>
          <InputGroup size="md" width={300} mt={6}>
            <Input pr="4.5rem" placeholder="Search..." />
            <InputRightElement width="4.5rem">
              <Button h="1.75rem" size="sm">
                <SearchIcon />
              </Button>
            </InputRightElement>
          </InputGroup>
          <Menu>
            <MenuButton
              as={Button}
              rightIcon={<ChevronDownIcon />}
              mt={6}
              width="300px"
              textAlign="left"
            >
              All themes
            </MenuButton>

            <MenuList zIndex={1000} overflowY="auto" maxH="300px">
              <Box>
                <InputGroup size="md" width="250px" m={4}>
                  <Input pr="4.5rem" placeholder="Basic usage" />
                  <InputRightElement width="4.5rem">
                    <Button h="1.75rem" size="sm">
                      <SearchIcon />
                    </Button>
                  </InputRightElement>
                </InputGroup>
              </Box>
              {types.map((type) => (
                <MenuItem key={type.id}>{type.name}</MenuItem>
              ))}
            </MenuList>
          </Menu>

          <Box mt={10}>
            <Heading>Tags</Heading>
            <Box mt={6}>
              <Flex align="center">
                {toggleButtons.map((button) => (
                  <Button
                    mr="6px"
                    key={button.id}
                    onClick={() => handleToggle(button.id)}
                    colorScheme={toggleState[button.id] ? "teal" : "gray"}
                    variant={toggleState[button.id] ? "solid" : "outline"}
                  >
                    {button.icon}
                  </Button>
                ))}
              </Flex>
            </Box>
          </Box>
          <Box maxW="400px" mt={6}>
            <Accordion allowToggle>
              <AccordionItem>
                <h2>
                  <AccordionButton>
                    <Box as="span" flex="1" textAlign="left">
                      Section 1 title
                    </Box>
                    <AccordionIcon />
                  </AccordionButton>
                </h2>
                <AccordionPanel
                  _expanded={{
                    width: "100px",
                  }}
                  pb={4}
                >
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                  do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                  Ut enim ad minim veniam, quis nostrud exercitation ullamco
                  laboris nisi ut aliquip ex ea commodo consequat.
                </AccordionPanel>
              </AccordionItem>

              <AccordionItem>
                <h2>
                  <AccordionButton>
                    <Box as="span" flex="1" textAlign="left">
                      Section 2 title
                    </Box>
                    <AccordionIcon />
                  </AccordionButton>
                </h2>
                <AccordionPanel pb={4}>
                  <Box>
                    <Text>ER, %</Text>
                    <RangeSlider
                      defaultValue={[0, 10000]}
                      min={0}
                      max={10000}
                      step={10}
                    >
                      <RangeSliderTrack bg="red.100">
                        <RangeSliderFilledTrack bg="tomato" />
                      </RangeSliderTrack>
                      <RangeSliderThumb boxSize={6} index={0} />
                      <RangeSliderThumb boxSize={6} index={1} />
                    </RangeSlider>
                    <Flex>
                      <Input />
                      <Input />
                    </Flex>
                  </Box>
                  <Box>
                    <Text>Subscribers</Text>
                    <RangeSlider
                      defaultValue={[0, 10000]}
                      min={0}
                      max={10000}
                      step={10}
                    >
                      <RangeSliderTrack bg="red.100">
                        <RangeSliderFilledTrack bg="tomato" />
                      </RangeSliderTrack>
                      <RangeSliderThumb boxSize={6} index={0} />
                      <RangeSliderThumb boxSize={6} index={1} />
                    </RangeSlider>
                    <Flex>
                      <Input />
                      <Input />
                    </Flex>
                  </Box>
                  <Box>
                    <Text>CPV</Text>
                    <RangeSlider
                      defaultValue={[0, 10000]}
                      min={0}
                      max={10000}
                      step={10}
                    >
                      <RangeSliderTrack bg="red.100">
                        <RangeSliderFilledTrack bg="tomato" />
                      </RangeSliderTrack>
                      <RangeSliderThumb boxSize={6} index={0} />
                      <RangeSliderThumb boxSize={6} index={1} />
                    </RangeSlider>
                    <Flex>
                      <Input />
                      <Input />
                    </Flex>
                  </Box>
                </AccordionPanel>
              </AccordionItem>

              <AccordionItem>
                <h2>
                  <AccordionButton>
                    <Box as="span" flex="1" textAlign="left">
                      Section 1 title
                    </Box>
                    <AccordionIcon />
                  </AccordionButton>
                </h2>
                <AccordionPanel
                  _expanded={{
                    width: "100px",
                  }}
                  pb={4}
                >
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                  do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                  Ut enim ad minim veniam, quis nostrud exercitation ullamco
                  laboris nisi ut aliquip ex ea commodo consequat.
                </AccordionPanel>
              </AccordionItem>
            </Accordion>
          </Box>
        </Box>
        <Box width="70%" padding="4" overflowX="auto" maxH="700px">
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
      <Footer />
    </>
  );
};

export default ChannelDashboard;
