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
      <Route
        path="/budget-management/ukr/:userId"
        element={<BudgetManagement />}
      />
      <Route
        path="/budget-management/de/:userId"
        element={<BudgetManagement />}
      />
      <Route
        path="/budget-management/pl/:userId"
        element={<BudgetManagement />}
      />

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
      <Route
        path="/customer-support/ukr/:userId"
        element={<CustomerSupport />}
      />
      <Route
        path="/customer-support/de/:userId"
        element={<CustomerSupport />}
      />
      <Route
        path="/customer-support/pl/:userId"
        element={<CustomerSupport />}
      />

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
      <Route path="/cooperation-page" element={<CooperationPage />} />
      <Route path="/channel-board" element={<ChannelDashboard />} />
      <Route path="/instagram-profiles" element={<InstagramProfiles />} />

      <Route path="/groups" element={<Groups />} />
      <Route path="/service-reviews" element={<ServiceReviews />} />

      <Route path="/faq" element={<Faq />} />
      <Route path="/report-us" element={<ReportUs />} />

      <Route path="/join-team" element={<JoinOurTeam />} />
      <Route
        path="/advertisement/edit/:userId"
        element={<RequireCredentialsPage />}
      />

      <Route path="/publications" element={<PublicationsPage />} />
      <Route path="/community" element={<CommunityPage />} />
      <Route path="/orders" element={<OrdersPage/>} />
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
