import React, { useState } from "react";
import {
  Box,
  Heading,
  Grid,
  Modal,
  ModalOverlay,
  ModalContent,
  ModalHeader,
  ModalBody,
  ModalFooter,
  Button,
  Text,
  Divider,
  Center,
} from "@chakra-ui/react";
import Advertisement from "./Advertisement";
import { useTranslation } from "react-i18next";

import translationUKR from "../../locales/ukr/translation.json";

const AdvertisementList = ({ ads }) => {
  const { t } = useTranslation();
  const [selectedAd, setSelectedAd] = useState(null);

  const handleOpenModal = (ad) => {
    setSelectedAd(ad);
  };

  const handleCloseModal = () => {
    setSelectedAd(null);
  };

  return (
    <Box p="2em">
      <Box>
        <Heading mb="1em">Advertisements</Heading>
        {ads.length > 0 ? (
          <Grid templateColumns="repeat(3, 1fr)" gap={4}>
            {ads.slice(0, 6).map((block) => (
              <Advertisement
                key={block}
                ad={block}
                onOpenModal={handleOpenModal}
              />
            ))}
          </Grid>
        ) : (
          <Box textAlign="center" mt="2em">
            <Heading>No data</Heading>
          </Box>
        )}
      </Box>
      {selectedAd && (
        <Modal isOpen={selectedAd !== null} onClose={handleCloseModal}>
          <ModalOverlay />
          <ModalContent>
            <ModalHeader>Header</ModalHeader>
            <Divider />
            <ModalBody>
              <Box>
                <Heading>Description</Heading>
                <Text>Lorem ipsum.</Text>
              </Box>
              <Divider />
              <Box>
                <Heading>Price</Heading>
                <Text>Price</Text>
              </Box>
              <Divider />
              <Box>
                <Heading>Example</Heading>
                <Text>Location</Text>
              </Box>
            </ModalBody>
            <ModalFooter>
              <Button mr={2} colorScheme="yellow" onClick={handleCloseModal}>
                Edit
              </Button>
              <Button mr={2} colorScheme="red" onClick={handleCloseModal}>
                Delete
              </Button>
              <Button mr={2} colorScheme="blue" onClick={handleCloseModal}>
                Close
              </Button>
            </ModalFooter>
          </ModalContent>
        </Modal>
      )}
      {ads.length > 0 ? (
        <Center>
          <Button colorScheme="blue" mt={10}>
            Show more
          </Button>
        </Center>
      ) : (
        <Center>
          <Button colorScheme="blue" mt={10}>
            Refresh
          </Button>
        </Center>
      )}
    </Box>
  );
};

export default AdvertisementList;
