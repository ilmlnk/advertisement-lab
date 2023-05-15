import React from "react";
import { Box, Heading, Grid } from "@chakra-ui/react";
import Advertisement from "../Advertisement/Advertisement";

const TaskList = () => {
  const blocks = [1, 2, 3, 4, 5, 6, 7, 8, 9];

  return (
    <Box p="2em">
      <Box>
        <Heading mb="1em">Task List</Heading>
        <Grid templateColumns="repeat(3, 1fr)" gap={4}>
          {blocks.map((block) => (
            <Advertisement />
          ))}
        </Grid>
      </Box>
    </Box>
  );
};

export default TaskList;