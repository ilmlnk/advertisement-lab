import React, { useState } from "react";
import {
  Box,
  Flex,
  Heading,
  Text,
  Button,
  Input,
  VStack,
  Divider,
  Stat,
  StatLabel,
  StatNumber,
} from "@chakra-ui/react";

const BudgetManagement = () => {
  const [budget, setBudget] = useState(0);
  const [expense, setExpense] = useState(0);
  const [newExpense, setNewExpense] = useState("");

  const handleAddExpense = () => {
    if (newExpense.trim() === "") {
      return;
    }

    const expenseAmount = parseFloat(newExpense);
    if (isNaN(expenseAmount)) {
      return;
    }

    setExpense((prevExpense) => prevExpense + expenseAmount);
    setNewExpense("");
  };

  const handleReset = () => {
    setBudget(0);
    setExpense(0);
    setNewExpense("");
  };

  const remainingBudget = budget - expense;

  return (
    <Box p={4}>
      <Heading mb={4}>Budget Management</Heading>
      <Box bg="white" p={4} borderRadius="md">
        <Flex justifyContent="space-between" alignItems="center" mb={4}>
          <Text>Budget:</Text>
          <Input
            type="number"
            min={0}
            value={budget}
            onChange={(e) => setBudget(parseFloat(e.target.value))}
            width="120px"
          />
        </Flex>
        <Divider mb={4} />
        <VStack spacing={4} alignItems="flex-start">
          <Flex justifyContent="space-between" alignItems="center" width="100%">
            <Text>Expense:</Text>
            <Flex alignItems="center">
              <Input
                type="number"
                min={0}
                value={newExpense}
                onChange={(e) => setNewExpense(e.target.value)}
                width="120px"
                mr={2}
              />
              <Button colorScheme="teal" onClick={handleAddExpense}>
                Add Expense
              </Button>
            </Flex>
          </Flex>
          <Divider width="100%" />
          <Stat textAlign="center">
            <StatLabel>Budget Remaining:</StatLabel>
            <StatNumber>${remainingBudget.toFixed(2)}</StatNumber>
          </Stat>
        </VStack>
      </Box>
      <Button mt={4} colorScheme="red" onClick={handleReset}>
        Reset
      </Button>
    </Box>
  );
};

export default BudgetManagement;
