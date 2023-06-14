import React from "react";
import axios from "axios";
import { useEffect, useState } from "react";
import AdminMainContent from "./AdminMainContent";

export const AdvertisementFetcher = () => {
  const [telegramAdsData, setTelegramAdsData] = useState([]);
  const [whatsAppAdsData, setWhatsAppAdsData] = useState([]);
  const [viberAdsData, setViberAdsData] = useState([]);

  const [adsData, setAdsData] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    try {
      const telegramAdvertisements = await axios.get('https://localhost:50555/TelegramAdvertisementController/telegram/ads');
      if (telegramAdvertisements.status === 200) {
        setTelegramAdsData(telegramAdvertisements);
      }

      const whatsAppAdvertisements = await axios.get('https://localhost:50555/WhatsAppAdvertisementController/whatsapp/ads');
      if (whatsAppAdvertisements.status === 200) {
        setWhatsAppAdsData(whatsAppAdvertisements);
      }

      const viberAdvertisements = await axios.get('https://localhost:50555/ViberAdvertisementController/viber/ads');
      if (viberAdvertisements.status === 200) {
        setViberAdsData(viberAdvertisements);
      }

      const mergedAdsData = [...telegramAdsData, ...whatsAppAdsData, ...viberAdsData];

      setAdsData(mergedAdsData);

    } catch (error){
      console.error(error);
    }
  };

  return (
    <AdminMainContent adsData={adsData}/>
  )
};

{/*export const OnlineUsersFetcher = () => {
  const [onlineUsersData, setOnlineUserData] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    try {
      const response = await axios.get("https://localhost:50555/");
      if (response.status === 200) {
        
      }
    } catch (error) {}
  };
  
  return onlineUsersData;
};*/}

{/*export const TaskFetcher = () => {
  const [tasksData, setTasksData] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  /*const fetchData = async () => {
    try {
      const response = await axios.get("https://localhost:50555/");
    } catch (error) {}
  };

  return tasksData;
};*/}

{/*export const RecentActionsFetcher = () => {
  const [recentActionsData, setRecentActionsData] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    try {
      const response = await axios.get(
        "https://localhost:50555/RecentActions/actions"
      );
      if (response.status === 200) {
        setRecentActionsData(response.data);
      } else {
        console.error("Error occurred: ", response.statusText);
      }
    } catch (error) {
      console.error(error);
    }
  };
  return recentActionsData;
};*/}
