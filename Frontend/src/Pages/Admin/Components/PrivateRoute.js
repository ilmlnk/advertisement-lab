import React from "react";
import { Route, Redirect } from "react-router-dom";

export const PrivateRoute = ({ component: Component, isAdmin, ...rest }) => {
    <Route 
    {...rest}
    render={(props) => isAdmin ? <Component {...props}/> : <Redirect to='/unauthorized'/>}
    />
};
