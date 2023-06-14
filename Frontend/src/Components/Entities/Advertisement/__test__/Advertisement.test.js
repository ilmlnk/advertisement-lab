import { render, screen, fireEvent } from "@testing-library/react";
import axios from "axios";
import Advertisement from "../Advertisement";

jest.mock("axios");

describe("Advertisement", () => {
  test("renders correctly with props", () => {
    const ad = {
      id: 1,
      name: "Sample advertisement 1",
      topic: "Sample topic 1",
      description: "Sample description",
      price: 100,
      systemUserId: 123,
    };

    const onOpenModal = jest.fn();

    const { container } = render(
      <Advertisement
        ad={ad}
        onOpenModal={onOpenModal}
        name={ad.name}
        topic={ad.topic}
        description={ad.description}
        price={ad.price}
        systemUserId={ad.systemUserId}
      />
    );

    expect(screen.getByText(ad.name)).toBeInTheDocument();
    

  });
});
