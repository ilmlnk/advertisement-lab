import React from 'react';

import Navigation from '../../Components/navigation/Navigation';
import Footer from '../../Components/footer/Footer';

const Layout = ({ children, history }) => {
    return (
      <div className='layout-container'>
            <main>{children}</main>
            <Footer history={history} />
      </div>
    )
  }

export default Layout;