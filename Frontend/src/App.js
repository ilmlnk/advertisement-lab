import "./App.css";
import {
  BrowserRouter as Router,
  Routes,
  Route,
  createBrowserRouter,
  createRoutesFromElements,
  RouterProvider,
} from "react-router-dom";

import axios from "axios";

import { useState, useEffect } from "react";

import StartPage from "./Pages/Start/Start";
import Admin from "./Pages/Admin/Admin";
import Analytics from "./Pages/Analytics/Analytics";
import UserManagement from "./Pages/UserManagement/UserManagement";
import BudgetManagement from "./Pages/BudgetManagement/BudgetManagement";
import ComplianceManagement from "./Pages/ComplianceManagement/ComplianceManagement";
import CommandChat from "./Pages/CommandChat/CommandChat";
import CustomerSupport from "./Pages/CustomerSupport/CustomerSupport";
import Registration from "./Pages/Registration/Registration";
import Login from "./Pages/LogIn/Login";
import NotFoundPage from "./Pages/ErrorPages/NotFoundPage";

import TermsOfUse from "./Pages/TermsOfUse/TermsOfUse";
import JoinOurTeam from "./Pages/JoinOurTeam/JoinOurTeam";
import TelegramChannels from "./Pages/TelegramChannels/TelegramChannels";
import ViberChannels from "./Pages/ViberChannels/ViberChannels";
import WhatsAppChannels from "./Pages/WhatsAppChannels/WhatsAppChannels";
import InstagramProfiles from "./Pages/InstagramProfiles/InstagramProfiles";
import Groups from "./Pages/Groups/Groups";
import ServiceReviews from "./Pages/ServiceReviews/ServiceReviews";
import Faq from "./Pages/Faq/Faq";
import ReportUs from "./Pages/ReportUs/ReportUs";
import ForgotPasswordPage from "./Pages/LogIn/ForgotPasswordPage";
import ServerUnavailablePage from "./Pages/ErrorPages/ServerUnavailable";
import ChannelDashboard from "./Pages/ChannelDashboard/ChannelDashboard";

const router = createBrowserRouter(
  createRoutesFromElements(
    <>
      <Route path="/main" element={<StartPage />} />
      <Route path="/main/ukr" element={<StartPage />} />
      <Route path="/main/de" element={<StartPage />} />
      <Route path="/main/pl" element={<StartPage />} />

      <Route path="/admin/:id" element={<Admin />} />
      <Route path="/admin/ukr/:id" element={<Admin />} />
      <Route path="/admin/de/:id" element={<Admin />} />
      <Route path="/admin/pl/:id" element={<Admin />} />

      <Route path="/analytics/:id" element={<Analytics />} />
      <Route path="/analytics/ukr/:id" element={<Analytics />} />
      <Route path="/analytics/de/:id" element={<Analytics />} />
      <Route path="/analytics/pl/:id" element={<Analytics />} />

      <Route path="/user-management/:id" element={<UserManagement />} />
      <Route path="/user-management/ukr/:id" element={<UserManagement />} />
      <Route path="/user-management/de/:id" element={<UserManagement />} />
      <Route path="/user-management/pl/:id" element={<UserManagement />} />

      <Route path="/budget-management/:id" element={<BudgetManagement />} />
      <Route path="/budget-management/ukr/:id" element={<BudgetManagement />} />
      <Route path="/budget-management/de/:id" element={<BudgetManagement />} />
      <Route path="/budget-management/pl/:id" element={<BudgetManagement />} />

      <Route
        path="/compliance-management/:id"
        element={<ComplianceManagement />}
      />
      <Route
        path="/compliance-management/ukr/:id"
        element={<ComplianceManagement />}
      />
      <Route
        path="/compliance-management/de/:id"
        element={<ComplianceManagement />}
      />
      <Route
        path="/compliance-management/pl/:id"
        element={<ComplianceManagement />}
      />

      <Route path="/command-chat/:id" element={<CommandChat />} />
      <Route path="/command-chat/ukr/:id" element={<CommandChat />} />
      <Route path="/command-chat/de/:id" element={<CommandChat />} />
      <Route path="/command-chat/pl/:id" element={<CommandChat />} />

      <Route path="/customer-support/:id" element={<CustomerSupport />} />
      <Route path="/customer-support/ukr/:id" element={<CustomerSupport />} />
      <Route path="/customer-support/de/:id" element={<CustomerSupport />} />
      <Route path="/customer-support/pl/:id" element={<CustomerSupport />} />

      <Route path="/registration" element={<Registration />} />
      <Route path="/registration/ukr" element={<Registration />} />
      <Route path="/registration/de" element={<Registration />} />
      <Route path="/registration/pl" element={<Registration />} />

      <Route path="/sign-up" element={<Registration />} />
      <Route path="/sign-up/ukr" element={<Registration />} />
      <Route path="/sign-up/de" element={<Registration />} />
      <Route path="/sign-up/pl" element={<Registration />} />

      <Route path="/login" element={<Login />} />
      <Route path="/login/ukr" element={<Login />} />
      <Route path="/login/de" element={<Login />} />
      <Route path="/login/pl" element={<Login />} />

      <Route path="/sign-in" element={<Login />} />
      <Route path="/sign-in/ukr" element={<Login />} />
      <Route path="/sign-in/de" element={<Login />} />
      <Route path="/sign-in/pl" element={<Login />} />

      <Route path="/forgot" element={<ForgotPasswordPage />} />

      <Route path="*" element={<NotFoundPage />} />

      <Route path="/projects" />
      <Route path="/cooperation" />
      <Route path="/channel-board" element={<ChannelDashboard />} />

      <Route path="/telegram-channels" element={<TelegramChannels />} />
      <Route path="/telegram-channels/ukr" element={<TelegramChannels />} />
      <Route path="/telegram-channels/de" element={<TelegramChannels />} />
      <Route path="/telegram-channels/pl" element={<TelegramChannels />} />

      <Route path="/whatsapp-channels" element={<WhatsAppChannels />} />
      <Route path="/viber-channels" element={<ViberChannels />} />
      <Route path="/instagram-profiles" element={<InstagramProfiles />} />

      <Route path="/groups" element={<Groups />} />
      <Route path="/service-reviews" element={<ServiceReviews />} />

      <Route path="/faq" element={<Faq />} />
      <Route path="/report-us" element={<ReportUs />} />
    </>
  )
);

function App() {
  return (
    <>
      <RouterProvider router={router} />
    </>
  );
}

export default App;
