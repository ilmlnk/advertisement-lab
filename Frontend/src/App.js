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

import StartPage from "./Pages/Start/Start.js";
import Admin from "./Pages/Admin/AdminPage.js";
import Analytics from "./Pages/Analytics/Analytics.js";
import UserManagement from "./Pages/UserManagement/UserManagement.js";
import BudgetManagement from "./Pages/BudgetManagement/BudgetManagement.js";
import ComplianceManagement from "./Pages/ComplianceManagement/ComplianceManagement.js";
import CommandChat from "./Pages/CommandChat/Components/CommandChat.js";
import CustomerSupport from "./Pages/CustomerSupport/CustomerSupport.js";
import Registration from "./Pages/Registration/Registration.js";
import Login from "./Pages/LogIn/Login.js";
import NotFoundPage from "./Pages/ErrorPages/NotFoundPage.js";
import CommandChatPage from "./Pages/CommandChat/CommandChatPage.js";

import TermsOfUse from "./Pages/TermsOfUse/TermsOfUse.js";
import JoinOurTeam from "./Pages/JoinOurTeam/JoinOurTeam.js";
import InstagramProfiles from "./Pages/InstagramProfiles/InstagramProfiles.js";
import Groups from "./Pages/Groups/Groups.js";
import ServiceReviews from "./Pages/ServiceReviews/ServiceReviews.js";
import Faq from "./Pages/Faq/Faq.js";
import ReportUs from "./Pages/ReportUs/ReportUs.js";
import ForgotPasswordPage from "./Pages/LogIn/ForgotPasswordPage.js";
import ServerUnavailablePage from "./Pages/ErrorPages/ServerUnavailable.js";
import ChannelDashboard from "./Pages/ChannelDashboard/ChannelDashboard.js";
import RequireCredentialsPage from "./Pages/RequireCredentials/RequireCredentialsPage.js";
import PublicationsPage from "./Pages/Publications/PublicationsPage.js";
import CooperationPage from "./Pages/Cooperation/CooperationPage";
import CommunityPage from "./Pages/Community/CommunityPage";
import OrdersPage from "./Pages/Orders/OrdersPage";
import BotsCataloguePage from "./Pages/BotsCatalogue/BotsCataloguePage";
import HotOffersPage from "./Pages/HotOffersPage/HotOffersPage";

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

      <Route path="/admin/:userId/analytics" element={<Analytics />} />
      <Route path="/admin/:userId/analytics/ukr" element={<Analytics />} />
      <Route path="/admin/:userId/analytics/de" element={<Analytics />} />
      <Route path="/admin/:userId/analytics/pl" element={<Analytics />} />

      <Route path="/admin/:userId/user_management" element={<UserManagement />} />
      <Route path="/admin/:userId/user_management/ukr" element={<UserManagement />} />
      <Route path="/admin/:userId/user_management/de" element={<UserManagement />} />
      <Route path="/admin/:userId/user_management/pl" element={<UserManagement />} />

      <Route path="/admin/:userId/budget_management" element={<BudgetManagement />} />
      <Route
        path="/admin/:userId/budget_management/ukr"
        element={<BudgetManagement />}
      />
      <Route
        path="/admin/:userId/budget_management/de"
        element={<BudgetManagement />}
      />
      <Route
        path="/admin/:userId/budget_management/pl"
        element={<BudgetManagement />}
      />

      <Route
        path="/admin/:userId/compliance_management"
        element={<ComplianceManagement />}
      />
      <Route
        path="/admin/:userId/compliance_management/ukr"
        element={<ComplianceManagement />}
      />
      <Route
        path="/admin/:userId/compliance_management/de"
        element={<ComplianceManagement />}
      />
      <Route
        path="/admin/:userId/compliance_management/pl"
        element={<ComplianceManagement />}
      />

      <Route path="/admin/:userId/command_chat" element={<CommandChatPage />} />
      <Route path="/admin/:userId/command_chat/ukr" element={<CommandChatPage />} />
      <Route path="/admin/:userId/command_chat/de" element={<CommandChatPage />} />
      <Route path="/admin/:userId/command_chat/pl" element={<CommandChatPage />} />

      <Route path="/admin/:userId/customer_support" element={<CustomerSupport />} />
      <Route
        path="/admin/:userId/customer_support/ukr"
        element={<CustomerSupport />}
      />
      <Route
        path="/admin/:userId/customer_support/de"
        element={<CustomerSupport />}
      />
      <Route
        path="/customer_support/pl/:userId"
        element={<CustomerSupport />}
      />

      <Route path="/registration" element={<Registration />} />
      <Route path="/registration/ukr" element={<Registration />} />
      <Route path="/registration/de" element={<Registration />} />
      <Route path="/registration/pl" element={<Registration />} />

      <Route path="/sign_up" element={<Registration />} />
      <Route path="/sign_up/ukr" element={<Registration />} />
      <Route path="/sign_up/de" element={<Registration />} />
      <Route path="/sign_up/pl" element={<Registration />} />

      <Route path="/login" element={<Login />} />
      <Route path="/login/ukr" element={<Login />} />
      <Route path="/login/de" element={<Login />} />
      <Route path="/login/pl" element={<Login />} />

      <Route path="/sign_in" element={<Login />} />
      <Route path="/sign_in/ukr" element={<Login />} />
      <Route path="/sign_in/de" element={<Login />} />
      <Route path="/sign_in/pl" element={<Login />} />

      <Route path="/forgot" element={<ForgotPasswordPage />} />

      <Route path="*" element={<NotFoundPage />} />

      <Route path="/projects" />
      <Route path="/cooperation_page" element={<CooperationPage />} />
      <Route path="/channel_board" element={<ChannelDashboard />} />
      <Route path="/instagram_profiles" element={<InstagramProfiles />} />

      <Route path="/groups" element={<Groups />} />
      <Route path="/service_reviews" element={<ServiceReviews />} />

      <Route path="/faq" element={<Faq />} />
      <Route path="/report_us" element={<ReportUs />} />

      <Route path="/join_team" element={<JoinOurTeam />} />
      <Route
        path="/advertisement/edit/:userId"
        element={<RequireCredentialsPage />}
      />

      <Route path="/publications" element={<PublicationsPage />} />
      <Route path="/community" element={<CommunityPage />} />
      <Route path="/orders" element={<OrdersPage />} />
      <Route path="/bots_catalogue" element={<BotsCataloguePage />} />
      <Route path="/hot_offers" element={<HotOffersPage />} />
    </>
  )
);

function App() {
  const isAuthenticated = localStorage.getItem('authToken') !== null;
  return (
    <>
      <RouterProvider router={router} />
    </>
  );
}

export default App;
