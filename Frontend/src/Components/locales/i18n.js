import i18n from "i18next";
import { initReactI18next } from "react-i18next";

import translationUKR from "./ukr/translation.json";
import translationEN from "./en/translation.json";
import translationPL from "./pl/translation.json";
import translationDE from "./de/translation.json";

const resources = {
    ukr: {
        translation: translationUKR,
    },
    en: {
        translation: translationEN,
    },
    pl: {
        translation: translationPL,
    },
    de: {
        translation: translationDE,
    },
};

i18n
.use(initReactI18next)
.init({
    resources,
    lng: "en",
    fallbackLng: "en",
    interpolation: {
        escapeValue: false,
    },
});

export default i18n;