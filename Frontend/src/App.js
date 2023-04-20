import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';

import Layout from './Pages/Layout/layout';
import Admin from './Pages/Admin/admin';
import Analytics from './Pages/Analytics/analytics';
import UserManagement from './Pages/UserManagement/userManagement';
import BudgetManagement from './Pages/BudgetManagement/budgetManagement';
import ComplianceManagement from './Pages/ComplianceManagement/complianceManagement';
import CustomerSupport from './Pages/CustomerSupport/customerSupport';
import CommandChat from './Pages/CommandChat/commandChat';
import StartPage from './Pages/Start/start';
import Registration from './Pages/Registration/registration';
import Login from './Pages/LogIn/login';

import TermsOfUse from './Pages/TermsOfUse/termsOfUse';
import JoinOurTeam from './Pages/JoinOurTeam/joinOurteam';
import TelegramChannels from './Pages/TelegramChannels/telegramChannels';
import ViberChannels from './Pages/ViberChannels/viberChannels';


function App() {
  return (
    <>
    <Router>
      <Routes>
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

{/*

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
*/}
      </Routes>
    </Router>
    </>
  );
}

export default App;
