import React from "react";
import Footer from "../../Components/footer/Footer";
import StartPageHeader from "./Components/StartPageHeader/StartPageHeader";
import StartPageIntro from "./Components/StartPageIntro/StartPageIntro";
import Instruction from "./Components/Instruction/Instruction";
import HowToBuy from "./Components/HowToBuy/HowToBuy";
import FeedbackCarousel from "./Components/Feedback/FeedbackCarousel";

import PriceList from "./Components/PriceList/PriceList";
import HotOffers from "./Components/HotOffers/HotOffers";

const StartPage = () => {
    return (
        <div className="start-page-container">
            <StartPageHeader/>
            {/*<StartPageIntro/>*/}
            <Instruction/>
            {/*<PriceList/>*/}
            <HowToBuy/>
            {/*<FeedbackCarousel/>*/}
            <HotOffers/>
            <Footer/>
        </div>
    );
}

export default StartPage;