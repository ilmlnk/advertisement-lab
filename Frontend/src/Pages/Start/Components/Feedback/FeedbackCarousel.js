import React from "react";
import {
  Box,
  Flex,
  Text,
  useDisclosure,
  SlideFade,
  useBreakpointValue,
  Card,
  CardBody,
  CardHeader,
  Heading,
  Button
} from "@chakra-ui/react";
import { ChevronLeftIcon, ChevronRightIcon } from "@chakra-ui/icons";

const images = [
  {
    id: 1,
    title: "Perfect website!",
    comment:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce id justo at mauris fringilla blandit. Maecenas maximus, lectus eget facilisis iaculis, tellus mauris rutrum lectus, vel blandit nulla dolor in sapien. Praesent vel ultrices purus. Suspendisse potenti. In vel est libero. Donec euismod, velit in dapibus semper, arcu nunc efficitur nulla, vel bibendum enim libero ac est. Nulla facilisi. Sed euismod, ipsum a venenatis lobortis, odio metus mattis ex, eu congue nisi quam id enim. Quisque nec consectetur enim. Donec non enim rhoncus, vulputate dolor eget, maximus nunc. Nunc ac tortor velit. Sed bibendum augue ipsum, eu tempor leo blandit in. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Nam pretium metus nec justo vestibulum consequat.",
  },
  {
    id: 2,
    title: "It's amazing!!",
    comment:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce id justo at mauris fringilla blandit. Maecenas maximus, lectus eget facilisis iaculis, tellus mauris rutrum lectus, vel blandit nulla dolor in sapien. Praesent vel ultrices purus. Suspendisse potenti. In vel est libero. Donec euismod, velit in dapibus semper, arcu nunc efficitur nulla, vel bibendum enim libero ac est. Nulla facilisi. Sed euismod, ipsum a venenatis lobortis, odio metus mattis ex, eu congue nisi quam id enim. Quisque nec consectetur enim. Donec non enim rhoncus, vulputate dolor eget, maximus nunc. Nunc ac tortor velit. Sed bibendum augue ipsum, eu tempor leo blandit in. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Nam pretium metus nec justo vestibulum consequat.",
  },
  {
    id: 3,
    title: "Magnificent!",
    comment:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce id justo at mauris fringilla blandit. Maecenas maximus, lectus eget facilisis iaculis, tellus mauris rutrum lectus, vel blandit nulla dolor in sapien. Praesent vel ultrices purus. Suspendisse potenti. In vel est libero. Donec euismod, velit in dapibus semper, arcu nunc efficitur nulla, vel bibendum enim libero ac est. Nulla facilisi. Sed euismod, ipsum a venenatis lobortis, odio metus mattis ex, eu congue nisi quam id enim. Quisque nec consectetur enim. Donec non enim rhoncus, vulputate dolor eget, maximus nunc. Nunc ac tortor velit. Sed bibendum augue ipsum, eu tempor leo blandit in. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Nam pretium metus nec justo vestibulum consequat.",
  },
  {
    id: 4,
    title: "Masterpiece.",
    comment:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce id justo at mauris fringilla blandit. Maecenas maximus, lectus eget facilisis iaculis, tellus mauris rutrum lectus, vel blandit nulla dolor in sapien. Praesent vel ultrices purus. Suspendisse potenti. In vel est libero. Donec euismod, velit in dapibus semper, arcu nunc efficitur nulla, vel bibendum enim libero ac est. Nulla facilisi. Sed euismod, ipsum a venenatis lobortis, odio metus mattis ex, eu congue nisi quam id enim. Quisque nec consectetur enim. Donec non enim rhoncus, vulputate dolor eget, maximus nunc. Nunc ac tortor velit. Sed bibendum augue ipsum, eu tempor leo blandit in. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Nam pretium metus nec justo vestibulum consequat.",
  },
];

const FeedbackCarousel = () => {
  const { isOpen, onToggle } = useDisclosure();
  const [currentImageIndex, setCurrentImageIndex] = React.useState(0);
  const isSmallerThanMd = useBreakpointValue({ base: true, md: false });

  const handleNextImage = () => {
    const lastIndex = images.length - 1;
    const shouldResetIndex = currentImageIndex === lastIndex;
    const index = shouldResetIndex ? 0 : currentImageIndex + 1;

    setCurrentImageIndex(index);
  };

  const handlePrevImage = () => {
    const lastIndex = images.length - 1;
    const shouldResetIndex = currentImageIndex === 0;
    const index = shouldResetIndex ? lastIndex : currentImageIndex - 1;

    setCurrentImageIndex(index);
  };

  const slideStyles = {
    flex: "0 0 100%",
    transition: "all .5s ease",
    transform: `translateX(-${currentImageIndex * 100}%)`,
  };

  return (
    <>
    <Box 
    position="relative" 
    maxW="500px" 
    margin="0 auto" 
    mb={8} 
    mt={12}>
    <Heading textAlign="center" mb={4}>What users say about us</Heading>
      <Flex overflowX="hidden" overflowY="hidden">
        <Box
          display="flex"
          w="100%"
          style={slideStyles}
          transition="transform ease-out 0.45s"
        >
          {images.map((image) => (
            <Box key={image.id} flex="0 0 100%">
              <SlideFade in={currentImageIndex === image.id - 1}>
                <Card>
                  <CardHeader fontWeight={600} fontSize={24}>
                    {image.title}
                  </CardHeader>
                  <CardBody>{image.comment}</CardBody>
                </Card>
                <Box
                  position="absolute"
                  bottom="0"
                  left="0"
                  right="0"
                  p="4"
                  bg="rgba(0,0,0,0.4)"
                  color="white"
                  display={isOpen ? "block" : "none"}
                >
                  <Text fontSize="xl" fontWeight="bold">
                    {image.title}
                  </Text>
                  <Text fontSize="sm" mt="2">
                    {image.alt}
                  </Text>
                </Box>
              </SlideFade>
            </Box>
          ))}
        </Box>
      </Flex>
      <Box position="absolute" top="50%" left="-15%">
        <Button
          aria-label="Previous Image"
          onClick={handlePrevImage}
          variant="ghost"
          size="lg"
          display={isSmallerThanMd ? "none" : "block"}
        >
            <ChevronLeftIcon />
        </Button>
      </Box>
      <Box position="absolute" top="50%" right="-15%">
        <Button
          aria-label="Next Image"
          onClick={handleNextImage}
          variant="ghost"
          size="lg"
          display={isSmallerThanMd ? "none" : "block"}
        >
            <ChevronRightIcon />
        </Button>
      </Box>
    </Box>
    </>
  );
};

export default FeedbackCarousel;
