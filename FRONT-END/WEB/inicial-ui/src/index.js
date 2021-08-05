// Libs
import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect } from 'react-router-dom';

// Styles
import './assets/css/index.css';

// Pages
import Login from './pages/Login/Login';
import Salas from './pages/Salas/Salas';
import Equipamentos from './pages/Equipamentos/Equipamentos';

const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={Login} />
        <Route exact path="/salas" component={Salas} />
        <Route exact path="/equipamentos" component={Equipamentos} />
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(routing, document.getElementById('root'));