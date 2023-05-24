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
  Center,
  useColorModeValue,
  Checkbox,
} from "@chakra-ui/react";

import Footer from "../../Components/footer/Footer";

import {
  FaStar,
  FaGem,
  FaShieldAlt,
  FaLock,
  FaHandSparkles,
  FaBolt,
  FaComments,
  FaPercent,
  FaUserCheck,
  FaSortAlphaDownAlt,
  FaMars,
  FaVenus,
} from "react-icons/fa";

import { SearchIcon, ChevronDownIcon } from "@chakra-ui/icons";
import StartPageHeader from "../Start/Components/StartPageHeader/StartPageHeader";

const ChannelDashboard = () => {
  const [searchTerm, setSearchTerm] = useState("");
  const [tagToggleState, setTagToggleState] = useState({});
  const [formatToggleState, setFormatToggleState] = useState({});
  const [filterToggleState, setFilterToggleState] = useState(null);
  const [selectedValueDropdown, setSelectedValueDropdown] = useState("");

  const colorModeBackground = useColorModeValue("white", "gray.700");

  const malePercentage = 50;
  const femalePercentage = 50;
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

  const toggleFilterButtons = [
    {
      id: 1,
      name: "Rating",
    },
    {
      id: 2,
      name: "ER",
    },
    {
      id: 3,
      name: "Views",
    },
    {
      id: 4,
      name: "Subscribers",
    },
    {
      id: 5,
      name: "Price",
    },
    {
      id: 6,
      name: "Added",
    },
    {
      id: 7,
      name: "CPV",
    },
  ];

  const toggleTagButtons = [
    {
      id: 1,
      name: "Exclusive",
      icon: <FaGem />,
    },
    {
      id: 2,
      name: "Trusted",
      icon: <FaShieldAlt />,
    },
    {
      id: 3,
      name: "Verified",
      icon: <FaStar />,
    },
    {
      id: 4,
      name: "Private",
      icon: <FaLock />,
    },
    {
      id: 5,
      name: "Private",
      icon: <FaBolt />,
    },
    {
      id: 6,
      name: "Chat",
      icon: <FaComments />,
    },
    {
      id: 7,
      name: "Discount",
      icon: <FaPercent />,
    },
    {
      id: 8,
      name: "Author",
      icon: <FaUserCheck />,
    },
  ];

  const formats = [
    {
      id: 1,
      name: "1/24",
      hiddenDescription: "",
    },
    {
      id: 2,
      name: "2/48",
      hiddenDescription: "",
    },
    {
      id: 3,
      name: "3/72",
      hiddenDescription: "",
    },
    {
      id: 4,
      name: "Native",
      hiddenDescription: "",
    },
    {
      id: 5,
      name: "Without deletion",
      hiddenDescription: "",
    },
    {
      id: 6,
      name: "Repost",
      hiddenDescription: "",
    },
  ];

  /*  */
  const advertisementItems = [
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

  const handleTagToggle = (id) => {
    setTagToggleState((prevState) => ({
      ...prevState,
      [id]: !prevState[id],
    }));
  };

  const handleFormatToggle = (id) => {
    setFormatToggleState((prevState) => ({
      ...prevState,
      [id]: !prevState[id],
    }));
  };

  const handleFilterToggle = (id) => {
    setFilterToggleState(id);
  };

  const handleSearch = (event) => {
    setSearchTerm(event.target.value);
  };

  const filteredItems = advertisementItems.filter((item) =>
    item.name.toLowerCase().includes(searchTerm.toLowerCase())
  );

  const handleSelectValue = (value) => {
    setSelectedValueDropdown(value);
  };

  return (
    <>
      <StartPageHeader />
      <Heading mt="2em" textAlign="center">
        Channel Board
      </Heading>
      <Center>
        <Box display="flex" flexDirection="row" padding={75}>
          <Box
            borderRadius="1em"
            p="2em"
            w="400px"
            backgroundColor={colorModeBackground}
          >
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
                {selectedValueDropdown || "All themes"}
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
                  <MenuItem
                    key={type.id}
                    onClick={() => handleSelectValue(type.name)}
                  >
                    {type.name}
                  </MenuItem>
                ))}
              </MenuList>
            </Menu>

            <Box mt={10}>
              <Heading>Tags</Heading>
              <Box mt={6}>
                <Flex align="center" flexWrap="wrap" maxW="400px">
                  {toggleTagButtons.map((button) => (
                    <Button
                      key={button.id}
                      onClick={() => handleTagToggle(button.id)}
                      colorScheme={tagToggleState[button.id] ? "teal" : "gray"}
                      variant={tagToggleState[button.id] ? "solid" : "outline"}
                      mx={1}
                      my={1}
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
                        <Heading size="md">Format</Heading>
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
                    {formats.map((format) => (
                      <Button
                        mr={2}
                        mb={2}
                        key={format.id}
                        onClick={() => handleFormatToggle(format.id)}
                        colorScheme={
                          formatToggleState[format.id] ? "teal" : "gray"
                        }
                        variant={
                          formatToggleState[format.id] ? "solid" : "outline"
                        }
                      >
                        {format.name}
                      </Button>
                    ))}
                  </AccordionPanel>
                </AccordionItem>

                <AccordionItem>
                  <h2>
                    <AccordionButton>
                      <Box as="span" flex="1" textAlign="left">
                        <Heading size="md">Ranges</Heading>
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
                          <RangeSliderFilledTrack bg="green" />
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
                    <Box>
                      <Text>ER, %</Text>
                      <RangeSlider
                        defaultValue={[0, 10000]}
                        min={0}
                        max={10000}
                        step={10}
                      >
                        <RangeSliderTrack bg="red.100">
                          <RangeSliderFilledTrack bg="green" />
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
                        <Heading size="md">Hide Channels</Heading>
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
                    <VStack align="start">
                      <Checkbox>Channels without ratings</Checkbox>
                      <Checkbox>New channels</Checkbox>
                      <Checkbox>Chats</Checkbox>
                      <Checkbox>Private channels</Checkbox>
                      <Checkbox>Channels from Black list</Checkbox>
                    </VStack>
                  </AccordionPanel>
                </AccordionItem>
              </Accordion>
            </Box>
          </Box>

          <Box width="75%" padding="4" overflowX="auto" maxH="700px">
            <Center mr={3}>
              <Flex w="100%" mb={3}>
                {toggleFilterButtons.map((filter) => (
                  <Button
                    key={filter.id}
                    onClick={() => handleFilterToggle(filter.id)}
                    colorScheme={
                      filterToggleState === filter.id ? "orange" : "gray"
                    }
                    w="full"
                    fontSize="12px"
                    m={2}
                  >
                    {filter.name}
                    {filterToggleState === filter.id && <FaSortAlphaDownAlt />}
                  </Button>
                ))}
              </Flex>
            </Center>
            <List spacing={3}>
              {advertisementItems.map((item) => (
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
                          <Heading size="sm" textAlign="center">Subscribers</Heading>
                          <Text textAlign="center">Amount</Text>
                          <Box>
                            <Flex align="center" justify="center">
                              <Box
                                width="150px"
                                height="10px"
                                bg={colorModeBackground}
                                borderRadius="full"
                                position="relative"
                              >
                                <Box
                                  bg="blue.500"
                                  borderRadius="full"
                                  height="10px"
                                  width={`${malePercentage}%`}
                                  position="absolute"
                                ></Box>
                                <Box
                                  bg="pink.500"
                                  borderRadius="full"
                                  height="10px"
                                  width={`${femalePercentage}%`}
                                  position="absolute"
                                  right="0"
                                ></Box>
                              </Box>
                            </Flex>
                            <Flex justify="space-between" mt={2}>
                              <FaMars />
                              <FaVenus />
                            </Flex>
                          </Box>
                        </Box>
                        <Box ml={10}>
                          <Heading textAlign="center" size="sm">
                            Views
                          </Heading>
                          <Text textAlign="center">Amount</Text>
                          <Heading textAlign="center" size="sm">
                            ER
                          </Heading>
                          <Text textAlign="center">Amount</Text>
                        </Box>
                        <Box ml={10}>
                          <Heading textAlign="center" size="sm">
                            CPV
                          </Heading>
                          <Text textAlign="center">Amount</Text>
                        </Box>

                        <Box ml={10}>
                          <Menu>
                            <MenuButton
                              as={Button}
                              rightIcon={<ChevronDownIcon />}
                              mr={2}
                              width="100px"
                              textAlign="left"
                            >
                              100
                            </MenuButton>

                            <MenuList
                              zIndex={1000}
                              overflowY="auto"
                              maxH="300px"
                            >
                              {types.map((type) => (
                                <MenuItem
                                  key={type.id}
                                  onClick={() => handleSelectValue(type.name)}
                                >
                                  {type.name}
                                </MenuItem>
                              ))}
                            </MenuList>
                          </Menu>
                          <Menu>
                            <MenuButton
                              as={Button}
                              rightIcon={<ChevronDownIcon />}
                              width="100px"
                              textAlign="left"
                            >
                              100
                            </MenuButton>

                            <MenuList
                              zIndex={1000}
                              overflowY="auto"
                              maxH="300px"
                            >
                              {types.map((type) => (
                                <MenuItem
                                  key={type.id}
                                  onClick={() => handleSelectValue(type.name)}
                                >
                                  {type.name}
                                </MenuItem>
                              ))}
                            </MenuList>
                          </Menu>
                          <Text textAlign="center" mt={2}>Price</Text>
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
      <Footer />
    </>
  );
};

export default ChannelDashboard;
