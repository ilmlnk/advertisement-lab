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

const AdvertisementList = () => {
  const blocks = [1, 2, 3, 4, 5, 6, 7, 8, 9];
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
        <Heading mb="1em">{t("advertisements")}</Heading>
        <Grid templateColumns="repeat(3, 1fr)" gap={4}>
          {blocks.map((block) => (
            <Advertisement
              key={block}
              ad={block}
              onOpenModal={handleOpenModal}
            />
          ))}
        </Grid>
      </Box>
      {selectedAd && (
        <Modal isOpen={selectedAd !== null} onClose={handleCloseModal}>
          <ModalOverlay />
          <ModalContent>
            <ModalHeader>Header</ModalHeader>
            <Divider />
            <ModalBody>
              <Box>
                <Heading>{t("description")}</Heading>
                <Text>Lorem ipsum.</Text>
              </Box>
              <Divider />
              <Box>
                <Heading>{t("price")}</Heading>
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
                {t("edit")}
              </Button>
              <Button mr={2} colorScheme="red" onClick={handleCloseModal}>
                {t("delete")}
              </Button>
              <Button mr={2} colorScheme="blue" onClick={handleCloseModal}>
                {t("close")}
              </Button>
            </ModalFooter>
          </ModalContent>
        </Modal>
      )}
      <Center>
        <Button colorScheme="blue" mt={10}>
          {t("show-more")}
        </Button>
      </Center>
    </Box>
  );
};

export default AdvertisementList;
