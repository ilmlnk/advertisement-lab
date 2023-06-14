import { useState } from "react";
import {
  Box,
  Flex,
  Text,
  useColorModeValue,
  Icon,
  useDisclosure,
  Button,
  useToast,
  CircularProgress,
  useTheme,
} from "@chakra-ui/react";

import {
    Modal,
    ModalOverlay,
    ModalContent,
    ModalHeader,
    ModalFooter,
    ModalBody,
    ModalCloseButton,
  } from "@chakra-ui/react";
  
import { FaFileUpload } from "react-icons/fa";
import { useDropzone } from "react-dropzone";

export default function DropZone() {
  const [files, setFiles] = useState([]);
  const { isOpen, onOpen, onClose } = useDisclosure();
  const toast = useToast();
  const theme = useTheme();

  const handleDrop = (acceptedFiles) => {
    setFiles((prevFiles) => [...prevFiles, ...acceptedFiles]);
  };

  const removeFile = (file) => {
    setFiles((prevFiles) => prevFiles.filter((f) => f !== file));
  };

  const handleSubmit = async () => {
    try {
      // Here you can implement your file upload logic
      // For example, you can use the FormData API to upload the files to a server
      // and then display a success message using the toast function
      toast({
        title: "Files uploaded successfully!",
        status: "success",
        duration: 3000,
        isClosable: true,
      });
    } catch (error) {
      toast({
        title: "Error uploading files",
        description: error.message,
        status: "error",
        duration: 3000,
        isClosable: true,
      });
    } finally {
      setFiles([]);
      onClose();
    }
  };

  const { getRootProps, getInputProps, isDragActive } = useDropzone({
    onDrop: handleDrop,
    multiple: true,
  });

  const borderColor = useColorModeValue("gray.300", "gray.600");
  const backgroundColor = useColorModeValue("gray.50", "gray.800");
  const textColor = useColorModeValue("gray.500", "gray.400");

  return (
    <Box
      p={6}
      borderWidth="1px"
      borderStyle="dashed"
      borderColor={borderColor}
      backgroundColor={backgroundColor}
      color={textColor}
      borderRadius="md"
      _hover={{
        cursor: "pointer",
      }}
      {...getRootProps()}
    >
      <input {...getInputProps()} />
      <Flex direction="column" align="center">
        <Icon as={FaFileUpload} w={8} h={8} mb={2} />
        {isDragActive ? (
          <Text fontSize="lg" fontWeight="medium">
            Drop your files here
          </Text>
        ) : (
          <Text fontSize="lg" fontWeight="medium">
            Drag and drop your files here, or{" "}
            <Box as="span" color={theme.colors.blue[500]}>
              browse
            </Box>{" "}
            to select files
          </Text>
        )}
      </Flex>
      {files.length > 0 && (
        <Box mt={4}>
          <Text fontSize="lg" fontWeight="medium" mb={2}>
            Selected files
          </Text>
          <Box maxH="200px" overflowY="auto">
            <Flex direction="column" align="start">
              {files.map((file) => (
                <Flex key={file.name} align="center" mb={2}>
                  <Box as="span" mr={2}>
                    {file.name} ({file.size}
                    bytes)
                  </Box>
                  <Button size="sm" onClick={() => removeFile(file)}>
                    Remove
                  </Button>
                </Flex>
              ))}
            </Flex>
          </Box>
          <Button
            mt={4}
            colorScheme="blue"
            onClick={onOpen}
            isDisabled={files.length === 0}
          >
            Upload
          </Button>
        </Box>
      )}
      <Modal isOpen={isOpen} onClose={onClose}>
        <ModalOverlay />
        <ModalContent>
          <ModalHeader>Upload files</ModalHeader>
          <ModalBody>
            <Text fontSize="lg" fontWeight="medium" mb={2}>
              Selected files
            </Text>
            <Box maxH="200px" overflowY="auto">
              <Flex direction="column" align="start">
                {files.map((file) => (
                  <Flex key={file.name} align="center" mb={2}>
                    <Box as="span" mr={2}>
                      {file.name} ({file.size} bytes)
                    </Box>
                    <Button size="sm" onClick={() => removeFile(file)}>
                      Remove
                    </Button>
                  </Flex>
                ))}
              </Flex>
            </Box>
            <Box mt={4} textAlign="center">
              {files.length > 0 && (
                <Button
                  colorScheme="blue"
                  onClick={handleSubmit}
                  isDisabled={files.length === 0}
                >
                  Upload
                </Button>
              )}
              {files.length === 0 && (
                <Text fontSize="lg" fontWeight="medium">
                  No files selected
                </Text>
              )}
            </Box>
          </ModalBody>
        </ModalContent>
      </Modal>
    </Box>
  );
}
