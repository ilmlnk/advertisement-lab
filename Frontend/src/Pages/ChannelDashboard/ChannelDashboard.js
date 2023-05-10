import React from "react";
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
} from "@chakra-ui/react";

import { FaStar } from "react-icons/fa";

import { SearchIcon, ChevronDownIcon } from "@chakra-ui/icons";

const ChannelDashboard = () => {
  return (
    <>
      <Box>
        <Heading>Filters</Heading>
        <InputGroup size="md" width={200}>
          <Input pr="4.5rem" placeholder="Basic usage" />
          <InputRightElement width="4.5rem">
            <Button h="1.75rem" size="sm">
              <SearchIcon />
            </Button>
          </InputRightElement>
        </InputGroup>
        <Menu>
          <MenuButton as={Button} rightIcon={<ChevronDownIcon />}>
            Actions
          </MenuButton>

          <MenuList>
            <Box>
              <InputGroup size="md" width={200}>
                <Input pr="4.5rem" placeholder="Basic usage" />
                <InputRightElement width="4.5rem">
                  <Button h="1.75rem" size="sm">
                    <SearchIcon />
                  </Button>
                </InputRightElement>
              </InputGroup>
            </Box>
            <MenuItem>Download</MenuItem>
            <MenuItem>Create a Copy</MenuItem>
            <MenuItem>Mark as Draft</MenuItem>
            <MenuItem>Delete</MenuItem>
            <MenuItem>Attend a Workshop</MenuItem>
          </MenuList>
        </Menu>

        <Box>
          <Heading>Tags</Heading>
          <Box>
            <Flex align="center">
              <Box marginRight={2}>
                <Icon as={FaStar} boxSize={6} color="yellow.400" />
              </Box>
              <Box marginRight={2}>
                <Icon as={FaStar} boxSize={6} color="yellow.400" />
              </Box>
              <Box marginRight={2}>
                <Icon as={FaStar} boxSize={6} color="yellow.400" />
              </Box>
              <Box marginRight={2}>
                <Icon as={FaStar} boxSize={6} color="yellow.400" />
              </Box>
              <Box marginRight={2}>
                <Icon as={FaStar} boxSize={6} color="yellow.400" />
              </Box>
            </Flex>
          </Box>
        </Box>
        <Box>
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
              <AccordionPanel pb={4}>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
                enim ad minim veniam, quis nostrud exercitation ullamco laboris
                nisi ut aliquip ex ea commodo consequat.
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
          </Accordion>
        </Box>
      </Box>
    </>
  );
};

export default ChannelDashboard;
