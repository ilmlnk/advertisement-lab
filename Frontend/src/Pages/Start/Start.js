import React, { useNavigate, useState, useRef } from "react";
import Footer from "../../Components/footer/Footer.js";
import StartPageHeader from "./Components/StartPageHeader/StartPageHeader.js";
import StartPageIntro from "./Components/StartPageIntro/StartPageIntro.js";
import Instruction from "./Components/Instruction/Instruction.js";
import HowToBuy from "./Components/HowToBuy/HowToBuy.js";

import FeedbackCarousel from "./Components/Feedback/FeedbackCarousel.js";
import FeaturedProperties from "./Components/HotOffers/HotOffers.js";
import NewsSection from "./Components/NewsSection/NewsSection.js";

const StartPage = () => {
  const sliderRef = useRef(null);
  const [sliderState, setsliderState] = useState(0);
  return (
    <div className="start-page-container">
      <StartPageHeader />
      <StartPageIntro/>
      <Instruction />
      {/*<PriceList/>*/}
      <HowToBuy />
      <FeaturedProperties />
      <FeedbackCarousel/>
      <NewsSection/>
      <Footer />
    </div>
  );
};

export default StartPage;
