import React from "react";
import Footer from "../../Components/footer/Footer";
import StartPageHeader from "./Components/StartPageHeader/StartPageHeader";
import StartPageIntro from "./Components/StartPageIntro/StartPageIntro";
import Instruction from "./Components/Instruction/Instruction";
import HowToBuy from "./Components/HowToBuy/HowToBuy";
import Feedback from "./Components/Feedback/FeedbackCarousel";

import './StartStyle.css';

const StartPage = () => {
    return (
        <div className="start-page-container">
            <StartPageHeader/>
            <StartPageIntro/>
            <Instruction/>
            <HowToBuy/>
            <Feedback/>
            <Footer/>
        </div>
    );
}

export default StartPage;