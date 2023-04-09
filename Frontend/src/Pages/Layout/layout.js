import React from 'react';

import Navigation from '../../Components/navigation/Navigation';
import Footer from '../../Components/footer/Footer';
import Header from '../../Components/header/Header';

const Layout = ({ children, history }) => {
    return (
      <div className='layout-container'>
        <div className='content-wrapper'>
          <Header/>
          <Navigation/>
          <main className='main-content'>{children}</main>
          <Footer history={history} />
        </div>
      </div>
    );
  }

export default Layout;