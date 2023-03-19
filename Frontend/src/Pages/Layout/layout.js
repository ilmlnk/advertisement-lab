import React from 'react';

import Navigation from '../../Components/navigation/Navigation';
import Footer from '../../Components/footer/Footer';
import Header from '../../Components/header/Header';

const Layout = ({ children, history }) => {
    return (
      <div className='layout-container'>
        <Header/>
        <Navigation/>
        <main>{children}</main>
        <Footer history={history} />
      </div>
    );
  }

export default Layout;