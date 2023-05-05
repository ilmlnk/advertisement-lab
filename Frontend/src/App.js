import logo from "./logo.svg";
import "./App.css";
import {
  BrowserRouter as Router,
  Routes,
  Route,
  createBrowserRouter,
  createRoutesFromElements,
  RouterProvider,
} from "react-router-dom";

import Admin from "./Pages/Admin/Admin";
import Analytics from "./Pages/Analytics/Analytics";
import UserManagement from "./Pages/UserManagement/UserManagement";
import BudgetManagement from "./Pages/BudgetManagement/BudgetManagement";
import ComplianceManagement from "./Pages/ComplianceManagement/ComplianceManagement";
import CustomerSupport from "./Pages/CustomerSupport/CustomerSupport";
import CommandChat from "./Pages/CommandChat/CommandChat";
import StartPage from "./Pages/Start/Start";
import Registration from "./Pages/Registration/Registration";
import Login from "./Pages/LogIn/Login";
import NotFoundPage from "./Pages/ErrorPages/NotFoundPage";

import TermsOfUse from "./Pages/TermsOfUse/TermsOfUse";
import JoinOurTeam from "./Pages/JoinOurTeam/JoinOurTeam";
import TelegramChannels from "./Pages/TelegramChannels/TelegramChannels";
import ViberChannels from "./Pages/ViberChannels/ViberChannels";

const router = createBrowserRouter(
  createRoutesFromElements(
    <>
      <Route path="/" element={<StartPage/>}/>
      <Route path="/main" element={<StartPage />} />

      <Route path="/admin/:id" element={<Admin />} />
      <Route path="/analytics" element={<Analytics />} />
      <Route path="/user-management" element={<UserManagement />} />
      <Route path="/budget-management" element={<BudgetManagement />} />
      <Route path="/compliance-management" element={<ComplianceManagement />} />
      <Route path="/command-chat" element={<CommandChat />} />
      <Route path="/customer-support" element={<CustomerSupport />} />

      <Route path="/registration" element={<Registration />} />
      <Route path="/sign-up" element={<Registration/>}/>

      <Route path="/login" element={<Login />} />
      <Route path="/sign-in" element={<Login />} />

      <Route path="*" element={<NotFoundPage />} />
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

{
  /*
        <Route path='/' element={<StartPage />} />
        <Route path='/admin' element={<Admin />} />
        <Route path='/analytics' element={<Analytics />} />
        <Route path='/user-management' element={<UserManagement />} />
        <Route path='/budget-management' element={<BudgetManagement />} />
        <Route path='/compliance-management' element={<ComplianceManagement />}/>
        <Route path='/command-chat' element={<CommandChat />}/>
        <Route path='/customer-support' element={<CustomerSupport />}/>
        <Route path='/registration' element={<Registration />}/>
        <Route path='/login' element={<Login />}/>

        <Route path='/terms-of-use' element={<TermsOfUse/>}/>
        <Route path='/join-team' element={<JoinOurTeam/>}/>

        <Route path='/telegram-channels' element={<TelegramChannels/>}/>
        <Route path='/whatsapp-channels' element={<WhatsAppChannels/>}/>
        <Route path='/viber-channels' element={<ViberChannels/>}/>
        <Route path='/instagram-profiles' element={<InstagramProfiles/>}/>

        <Route path='/groups' element={<Groups/>}/>
        <Route path='/service-reviews' element={<ServiceReviews/>}/>

        <Route path='/faq' element={<Faq/>}/>
        <Route path='/report-us' element={<ReportUs/>}/>

*/
}

export default App;
