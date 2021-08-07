// Libs
import { Component } from "react";
import axios from "axios";
// import {Link} from 'react-router-dom';

// Services
// import {parseJwt} from '../../services/Auth';

// Styles
import '../../assets/css/login.css';
import '../../assets/css/reset.css';

// Imgs
import banner from '../../assets/img/login-banner.svg';


class Login extends Component {
    constructor(props){
        super(props);
        this.state = {
            email : '',
            senha : '',
            mensagem : '',
            isLoading : false
        }
    }

    render() {
        return(
            <>
                <div className="login-banner-background">
                    <div className="login-banner">
                        <img src={banner} draggable="false" />
                    </div>
                </div>

                <div className="login-form-background">
                    <div className="login-form">
                        <div className="login-form-title">
                            <p>Login</p>
                        </div>

                        <div className="login-form-inputs">
                            <input type="email" placeholder="E-mail" />
                            <input type="password" placeholder="Senha" />
                        </div>

                        <div className="login-form-btns">
                            <button>Entrar</button>
                        </div>
                    </div>
                </div>
            </>
        )
    }

}

export default Login;