import React, { useEffect, useState } from "react";
import { Box, Center, Heading } from "@chakra-ui/react";
import axios from "axios";
import Post from "../../../Components/Entities/Post/Post";

const PublicationFeed = () => {
  const [publicationData, setPublicationData] = useState([]);
  const blocks = [1, 2, 3, 4, 5, 6];

  {
    /*useEffect(() => {
    const fetchPosts = async () => {
      try {
        const posts = await axios.get(
          "https://localhost:50555/PostController/posts"
        );
        setPublicationData(posts);
      } catch (error) {
        console.error(error);
      }
    };
}, []);*/
  }
  return (
    <>
      <Center>
        <Heading>Publications</Heading>
      </Center>
      <Center>
        <Box mb={8}>
          {blocks.map((publication) => (
            <Post />
          ))}
        </Box>
      </Center>
    </>
  );
};

export default PublicationFeed;
