// Libs
import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect } from 'react-router-dom';

// Styles
import './assets/css/index.css';

// Services
import {parseJwt, userAuthentication} from './services/Auth';

// Pages
import Login from './pages/Login/Login';
import Salas from './pages/Salas/Salas';
import Equipamentos from './pages/Equipamentos/Equipamentos';


const Permissao = ({component : Component}) => (
  <Route 
    render = {props =>
      userAuthentication() && parseJwt().role === "1" || userAuthentication() && parseJwt().role === "2" ?
      <Component {...props} /> :
      <Redirect to="/" />
    }
  />
)

const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={Login} />
        <Permissao exact path="/salas" component={Salas} />
        <Permissao exact path="/equipamentos" component={Equipamentos} />
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(routing, document.getElementById('root'));