import React from "react";
import axios from "axios";
import { useEffect, useState } from "react";

export const AdvertisementFetcher = () => {
  const [advertisementData, setAdvertisementData] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    try {
      const response = await axios.get("https://localhost:50555/");
    } catch (error) {
      console.error(error);
    }
  };

  return advertisementData;
};

export const OnlineUsersFetcher = () => {
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
};

export const TaskFetcher = () => {
  const [tasksData, setTasksData] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    try {
      const response = await axios.get("https://localhost:50555/");
    } catch (error) {}
  };

  return tasksData;
};

export const RecentActionsFetcher = () => {
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
};
