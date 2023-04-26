import React from "react";
import './startStyle.css';
import Footer from "../../Components/footer/Footer";
import StartPageHeader from "./Components/StartPageHeader";

const StartPage = () => {
    return (
        <div className="start-page-container">
            <StartPageHeader/>
            
            <Footer/>
        </div>
    );
}

export default StartPage;