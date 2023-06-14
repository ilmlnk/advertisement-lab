import React from "react";
import PublicationSidebar from "./Components/PublicationSidebar";
import PublicationFeed from "./Components/PublicationFeed";
import Footer from "../../Components/footer/Footer";
import { Heading } from "@chakra-ui/react";

const PublicationsPage = () => {
  return (
    <>
      <PublicationFeed />
      <Footer />
    </>
  );
};

export default PublicationsPage;
