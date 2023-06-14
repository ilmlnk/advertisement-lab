import {
  Box,
  Card,
  CardBody,
  CardFooter,
  CardHeader,
  Heading,
} from "@chakra-ui/react";
import React from "react";
import { Doughnut } from "react-chartjs-2";
import ExportButtonMenu from "./ExportButtonMenu.js";

const ChannelPieChart = ({ data }) => {
  return (
    <Card>
      <CardHeader>
        <Heading>Channels distribution</Heading>
      </CardHeader>
      <CardBody>
        <Doughnut data={data}></Doughnut>
      </CardBody>
      <CardFooter>
        <ExportButtonMenu/>
      </CardFooter>
    </Card>
  );
};

export default ChannelPieChart;
