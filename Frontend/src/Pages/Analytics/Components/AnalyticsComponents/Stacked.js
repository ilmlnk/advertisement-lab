import React from "react";
import { ChartComponent, Inject, SeriesCollectionDirective, StackingColumnSeries, Category, Legend, Tooltip, SeriesDirective } from "@syncfusion/ej2-react-charts";
import { stackedPrimaryXAxis, stackedPrimaryYAxis, stackedCustomSeries } from "../../Data/Dummy";

const StackedChart = ({ width, height }) => {
  return (
    <ChartComponent
      id="charts"
      primaryXAxis={stackedPrimaryXAxis}
      primaryYAxis={stackedPrimaryYAxis}
      width={width}
      height={height}
      chartArea={{ border: { width: 0 } }}
      tooltip={{ enable: true }}
      background="#fff"
      legendSettings={{ background: "white" }}
    >
      <Inject services={[StackingColumnSeries, Category, Legend, Tooltip]} />
      <SeriesCollectionDirective>
        {/* eslint-disable-next-line react/jsx-props-no-spreading */}
        {stackedCustomSeries.map((item, index) => (
          <SeriesDirective key={index} {...item} />
        ))}
      </SeriesCollectionDirective>
    </ChartComponent>
  );
};

export default StackedChart;
