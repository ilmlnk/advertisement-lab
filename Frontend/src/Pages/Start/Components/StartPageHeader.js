import React from "react";

const StartPageHeader = () => {
    return (
        <div>
            <h1>AdReach</h1>
            <div>
                {/* Замовник або Власник каналу */}
                <button className="">Режим замовника</button>

                <div className="start-page-header-dropmenu">
                    <button className="">Каталог</button>
                    <div>
                        <ul>
                            <li>
                                <div>
                                    <i></i>
                                    <p>Каталог Telegram каналів</p>
                                </div>
                            </li>
                            <li>
                                <div>
                                    <i></i>
                                    <p>Каталог Viber каналів</p>
                                </div>
                            </li>
                            <li>
                                <div>
                                    <i></i>
                                    <p>Каталог WhatsApp каналів</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <button className="">Реєстрація</button>
                <button className="">Увійти</button>
            </div>
        </div>
    );
};

export default StartPageHeader;