import React from "react";
import './FooterStyle.css';

const Footer = () => {
    return (
        <footer className="footer">
            <div className="footer-container">
                <div className="adreach-block links-block-content">
                    <h2 className="links-block-title">AdReach</h2>
                    <div className="adreach-links-block links-block">
                        <ul className="adreach-links-list links-list">
                            <li className="mark-link adreach-mark-link terms-of-use">
                                <a className="footer-link">
                                    Terms of Use
                                </a>
                            </li>
                            <li className="mark-link adreach-mark-link ">
                                <a className="footer-link">
                                    Join our Team
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>

                <div className="products-block links-block-content">
                    <h2 className="links-block-title products-links-block-title">Products</h2>
                    <div className="links-block products-links-block">
                        <ul className="links-list products-links-list">
                            <li className="mark-link products-mark-link">
                                <a className="footer-link products-footer-link telegram-channels-link">
                                    Telegram channels catalogue
                                </a>
                            </li>
                            <li className="mark-link products-mark-link">
                                <a className="footer-link">
                                    WhatsApp channels catalogue
                                </a>
                            </li>
                            <li className="mark-link">
                                <a className="footer-link">
                                    Viber channels catalogue
                                </a>
                            </li>
                            <li className="mark-link">
                                <a className="footer-link">
                                    Instagram profiles catalogue
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div className="links-block-content">
                    <h2 className="links-block-title">Community</h2>
                    <div className="links-block community-">
                        <ul className="links-list">
                            <li className="mark-link">
                                <a className="footer-link">
                                    Blog
                                </a>
                            </li>
                            <li className="mark-link">
                                <a className="footer-link">
                                    Groups
                                </a>
                            </li>
                            <li className="mark-link">
                                <a className="footer-link">
                                    Our Telegram channel
                                </a>
                            </li>
                            <li className="mark-link">
                                <a className="footer-link">
                                    Service Reviews
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div className="links-block-content">
                    <h2 className="links-block-title">Help</h2>
                    <div className="links-block">
                        <ul className="links-list">
                            <li className="mark-link">
                                <a className="footer-link">
                                    FAQ
                                </a>
                            </li>
                            <li className="mark-link">
                                <a className="footer-link support-bot">
                                    Support Bot
                                </a>
                            </li>
                            <li className="mark-link">
                                <a className="footer-link">
                                    Report us
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </footer>
    );
}


export default Footer;