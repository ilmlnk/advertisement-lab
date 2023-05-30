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
import Admin from "./Pages/Admin/AdminPage";
import Analytics from "./Pages/Analytics/Analytics";
import UserManagement from "./Pages/UserManagement/UserManagement";
import BudgetManagement from "./Pages/BudgetManagement/BudgetManagement";
import ComplianceManagement from "./Pages/ComplianceManagement/ComplianceManagement";
import CommandChat from "./Pages/CommandChat/Components/CommandChat";
import CustomerSupport from "./Pages/CustomerSupport/CustomerSupport";
import Registration from "./Pages/Registration/Registration";
import Login from "./Pages/LogIn/Login";
import NotFoundPage from "./Pages/ErrorPages/NotFoundPage";
import CommandChatPage from "./Pages/CommandChat/CommandChatPage";

import TermsOfUse from "./Pages/TermsOfUse/TermsOfUse";
import JoinOurTeam from "./Pages/JoinOurTeam/JoinOurTeam";
import TelegramChannels from "./Pages/TelegramChannels/TelegramChannelsPage";
import ViberChannels from "./Pages/ViberChannels/ViberChannelsPage";
import WhatsAppChannels from "./Pages/WhatsAppChannels/WhatsAppChannelsPage";
import InstagramProfiles from "./Pages/InstagramProfiles/InstagramProfiles";
import Groups from "./Pages/Groups/Groups";
import ServiceReviews from "./Pages/ServiceReviews/ServiceReviews";
import Faq from "./Pages/Faq/Faq";
import ReportUs from "./Pages/ReportUs/ReportUs";
import ForgotPasswordPage from "./Pages/LogIn/ForgotPasswordPage";
import ServerUnavailablePage from "./Pages/ErrorPages/ServerUnavailable";
import ChannelDashboard from "./Pages/ChannelDashboard/ChannelDashboard";
import RequireCredentialsPage from "./Pages/RequireCredentials/RequireCredentialsPage";
import PublicationsPage from "./Pages/Publications/PublicationsPage";

const router = createBrowserRouter(
  createRoutesFromElements(
    <>
      <Route path="/main" element={<StartPage />} />
      <Route path="/main/ukr" element={<StartPage />} />
      <Route path="/main/de" element={<StartPage />} />
      <Route path="/main/pl" element={<StartPage />} />

      <Route path="/admin/:userId" element={<Admin />} />
      <Route path="/admin/ukr/:userId" element={<Admin />} />
      <Route path="/admin/de/:userId" element={<Admin />} />
      <Route path="/admin/pl/:userId" element={<Admin />} />

      <Route path="/analytics/:userId" element={<Analytics />} />
      <Route path="/analytics/ukr/:userId" element={<Analytics />} />
      <Route path="/analytics/de/:userId" element={<Analytics />} />
      <Route path="/analytics/pl/:userId" element={<Analytics />} />

      <Route path="/user-management/:userId" element={<UserManagement />} />
      <Route path="/user-management/ukr/:userId" element={<UserManagement />} />
      <Route path="/user-management/de/:userId" element={<UserManagement />} />
      <Route path="/user-management/pl/:userId" element={<UserManagement />} />

      <Route path="/budget-management/:userId" element={<BudgetManagement />} />
      <Route path="/budget-management/ukr/:userId" element={<BudgetManagement />} />
      <Route path="/budget-management/de/:userId" element={<BudgetManagement />} />
      <Route path="/budget-management/pl/:userId" element={<BudgetManagement />} />

      <Route
        path="/compliance-management/:userId"
        element={<ComplianceManagement />}
      />
      <Route
        path="/compliance-management/ukr/:userId"
        element={<ComplianceManagement />}
      />
      <Route
        path="/compliance-management/de/:userId"
        element={<ComplianceManagement />}
      />
      <Route
        path="/compliance-management/pl/:userId"
        element={<ComplianceManagement />}
      />

      <Route path="/command-chat/:userId" element={<CommandChatPage />} />
      <Route path="/command-chat/ukr/:userId" element={<CommandChatPage />} />
      <Route path="/command-chat/de/:userId" element={<CommandChatPage />} />
      <Route path="/command-chat/pl/:userId" element={<CommandChatPage />} />

      <Route path="/customer-support/:userId" element={<CustomerSupport />} />
      <Route path="/customer-support/ukr/:userId" element={<CustomerSupport />} />
      <Route path="/customer-support/de/:userId" element={<CustomerSupport />} />
      <Route path="/customer-support/pl/:userId" element={<CustomerSupport />} />

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

      <Route path="/join-team" element={<JoinOurTeam />} />
      <Route path="/advertisement/edit/:userId" element={<RequireCredentialsPage />} />

      <Route path="/publications" element={<PublicationsPage/>}/>
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
