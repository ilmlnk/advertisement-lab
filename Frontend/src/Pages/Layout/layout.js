import React, { ReactNode } from 'react';

import Navigation from '../../Components/navigation/Navigation';
import Footer from '../../Components/footer/Footer';

export default function Layout({ children, history }) {
    return (
      <div className='layout-container'>
        <div className='content-wrapper'>
          <Navigation/>
          <main className='main-content'>{children}</main>
          <Footer history={history} />
        </div>
      </div>
    );
  }