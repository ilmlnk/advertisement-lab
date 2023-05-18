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
import Task, { TaskModal } from "./Task";

const TaskList = ({ tasks }) => {
  const [selectedTask, setSelectedTask] = useState(null);

  const handleOpenModal = (inputTask) => {
    setSelectedTask(inputTask);
  };

  const handleCloseModal = () => {
    setSelectedTask(null);
  };

  return (
    <Box p="2em">
      <Box>
        <Heading mb="1em">Task List</Heading>

        {tasks.length > 0 ? (
          <Grid templateColumns="repeat(3, 1fr)" gap={4}>
            {tasks.map((block) => (
              <Task 
                key={block} 
                task={block} 
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

      {tasks.length > 0 ? (
        <Center>
          <Button mt="2em" colorScheme="blue">
            Show all tasks
          </Button>
        </Center>
      ) : (
        <Center>
          <Button mt="2em" colorScheme="blue">
            Refresh
          </Button>
        </Center>
      )}

      {selectedTask && (
        <TaskModal
          isOpen={selectedTask !== null}
          onClose={handleCloseModal}
          task={selectedTask}
        />
      )}
    </Box>
  );
};

export default TaskList;
